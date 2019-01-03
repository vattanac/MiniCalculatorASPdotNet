using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniCalculator.Models;

namespace MiniCalculator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculator calculatorModel,string operater)
        {
            if(operater == "+")
            {
                calculatorModel.result = calculatorModel.a + calculatorModel.b;
            }
            if (operater == "-")
            {
                calculatorModel.result = calculatorModel.a - calculatorModel.b;
            }
            if (operater == "*")
            {
                calculatorModel.result = calculatorModel.a * calculatorModel.b;
            }
            if (operater == "/")
            {
                calculatorModel.result = calculatorModel.a / calculatorModel.b;
            }
            return View(calculatorModel);
        }
    }
}