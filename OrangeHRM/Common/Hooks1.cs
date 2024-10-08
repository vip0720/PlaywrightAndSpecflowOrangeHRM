﻿using Microsoft.Playwright;
using TechTalk.SpecFlow;

namespace PlayWrightSpecFlow.Common
{
    [Binding]
    public class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        public static IPage page;
        public IBrowser browser;


        [BeforeTestRun]
        public  async Task BeforeTest()
        {
            using var playwright = await Playwright.CreateAsync();
            var chrome = playwright.Chromium;
            browser = await chrome.LaunchAsync(new() { Headless = false });
            page = await browser.NewPageAsync();
        }

        [BeforeScenario("@tag1")]
        public static void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
        }

        [BeforeScenario(Order = 1)]
        public static void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}