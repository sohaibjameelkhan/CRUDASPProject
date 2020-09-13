using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SohaibJameel.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public int no_of_fculty { get; set; }
    }

    public class DepartmentDBContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
    }
}