using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyApp
{
    class Program
    {
        IWebDriver driver = new FirefoxDriver();

        static void Main(string[] args)
        {
          

        }

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html");

            Console.WriteLine("Otwarto URL");

        }
        [Test]
        public void ExecuteTest()

        {
            TestSetMetods.SelectDropDown(driver, "TitleId", "Ms.", "Id");

            TestSetMetods.EnterText(driver, "Initial", "testowanie", "Name");

            TestSetMetods.EnterText(driver, "FirstName", "Katarzyna", "Id");

            TestSetMetods.EnterText(driver, "MiddleName", "Łuczyńska", "Id");

            TestSetMetods.SelectRadioButton(driver, "Female", "Name");

            TestSetMetods.SelectCheckBox(driver, "english", "Name");

            Console.WriteLine("Wartość z pola Tytył to" + TestGetMetods.GetText(driver, "TitleId","Id"));

            Console.WriteLine("Wartość z pola Initial to " + TestGetMetods.GetText(driver, "Initial", "Name"));

            Console.WriteLine("Wartość z pola FirstName to " + TestGetMetods.GetText(driver, "FirstName", "Id"));

            Console.WriteLine("Wartość z pola MiddleName to " + TestGetMetods.GetText(driver, "MiddleName", "Id"));



            TestSetMetods.Click(driver, "Save", "Name");

            System.Threading.Thread.Sleep(3000);
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();

            Console.WriteLine("Zamknięto przeglądarkę");

        }



    }
}
