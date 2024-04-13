﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CoursesAPI.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public required string Title { get; set; }
        public int Credits { get; set; }

    }
}
