﻿// Copyright 2015 ThoughtWorks, Inc.
//
// This file is part of Gauge-CSharp.
//
// Gauge-CSharp is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// Gauge-CSharp is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with Gauge-CSharp.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;
using Gauge.CSharp.Runner.Processors;
using Gauge.CSharp.Runner.Strategy;
using Gauge.Messages;

namespace Gauge.CSharp.Runner.UnitTests.Processors.Stubs
{
    public class TestTaggedHooksFirstExecutionProcessor : TaggedHooksFirstExecutionProcessor
    {

        public HooksStrategy GetHooksStrategy()
        {
            return Strategy;
        }

        public TestTaggedHooksFirstExecutionProcessor() : base(null, null)
        {
        }

        protected override HashSet<HookMethod> GetHooks()
        {
            throw new System.NotImplementedException();
        }

        protected override ExecutionInfo GetExecutionInfo(Message request)
        {
            throw new System.NotImplementedException();
        }
    }
}