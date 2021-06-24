using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index() {

            List < Department > lista =  new List<Department>();
            lista.Add(new Department { Id = 1, Nome = "Eletronics" });
            lista.Add(new Department { Id = 2, Nome = "Fashion" });
            return View(lista);
        }
    }
}
