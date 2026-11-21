using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Service;

namespace Aki.Common.ConsoleManagerGenerate
{
	// Token: 0x0200001C RID: 28
	public static class ConsoleRegister
	{
		// Token: 0x06000135 RID: 309 RVA: 0x0000E99C File Offset: 0x0000CB9C
		[ModuleInitializer]
		public static void RegisterAll()
		{
			IConsoleManager.RegisterConsoleVariable("cs.JitProfile.Disable", false, "Disable JitProfile", EConsoleVariableFlags.ECVF_Default);
			IConsoleManager.RegisterConsoleVariable("cs.JitProfile.FrameSplit", true, "Enable JitProfile frameSplit mode, if true, async will disable", EConsoleVariableFlags.ECVF_Default);
			IConsoleManager.RegisterConsoleVariable("cs.JitProfile.FrameSplitBatch", 100, "JitProfile frameSplit batch job count", EConsoleVariableFlags.ECVF_Default);
		}
	}
}
