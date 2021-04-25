using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var slist = from s in StudentList
                        orderby s.RollNo
                        select s;
            return View(slist);
        }


        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student s)
        {
            try
            {
                StudentList.Add(s);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public static List<Student> StudentList = new List<Student>
        {

                new Student
                {
                    RollNo=101, Name="Suhas", DeptName="IT"
                },
                new Student
                {
                    RollNo=102, Name="Geet", DeptName="CSE"
                }

        };

    }
}
