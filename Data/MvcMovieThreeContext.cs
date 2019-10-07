using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovieThree.Models
{
    public class MvcMovieThreeContext : DbContext
    {
        public MvcMovieThreeContext (DbContextOptions<MvcMovieThreeContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; }
    }
}
