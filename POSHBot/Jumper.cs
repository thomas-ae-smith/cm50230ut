using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POSH_sharp.sys;
using POSH_sharp.sys.annotations;
using Posh_sharp.POSHBot.util;
using POSH_sharp.sys.strict;

namespace Posh_sharp.POSHBot
{
    /// <summary>
    /// This class provides an action to execute a jump
    /// </summary>
    public class Tester : UTBehaviour
    {

        public Tester(AgentBase agent)
            :base(agent,new string[] {"MakeJump"},
                        new string[] {})
        {
        }
            

        /*
        * 
        * ACTIONS 
        * 
        */

        /// <summary>
        /// This is an action that can be used to make the agent jump.
        /// </summary>
        /// <returns>True or false, dependent if the jump was executed successfuly.</returns>

        [ExecutableAction("MakeJump")]
        public bool MakeJump()
        {
            GetBot().SendMessage("JUMP", new Dictionary<string, string>());
            return true;
        }
        /*
         * 
         * SENSES
         * 
         */

        /// <summary>
        /// This is a template sense that can be used to modify the agent behaviour.
        /// Senses are used to retrieve information about the environment the agent is in. They do not modify the environment but rather observe.
        /// Senses should be rather lightweight as they are called frequently, meaning they are not good for heavy computation except for special 
        /// cases where a sense is called rather seldom.
        /// </summary>
        /// <returns>Senses can return bools, ints, floats and longs but should not return complex objects. If you are in need of complex 
        /// information about the world you should store those inside the behaviour and let actions read them directly.</returns>
        //[ExecutableSense("ShouldJump")]
        //public bool ShouldJump()
        //{
        //    if (_debug_)
        //        Console.Out.WriteLine(" in ShouldJump");
        //    return false;
        //}
    }
}     

    
