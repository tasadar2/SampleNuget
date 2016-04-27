using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SampleNuget.Tests
{
    [TestFixture]
    public class MainLibraryTests
    {
        [Test]
        public void This_is_a_sample_test()
        {
            Assert.That(MainLibrary.ReturnTrue(), Is.EqualTo(true));
        }
    }
}
