using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Service;

namespace Aki.Common.ConsoleManagerGenerate
{
	// Token: 0x0200001B RID: 27
	public static class ConsoleRegister
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0000B1D0 File Offset: 0x000093D0
		[ModuleInitializer]
		public static void RegisterAll()
		{
			IConsoleManager.RegisterConsoleVariable("cs.JitProfile.Disable", false, "Disable JitProfile", EConsoleVariableFlags.ECVF_Default);
			IConsoleManager.RegisterConsoleVariable("cs.JitProfile.FrameSplit", true, "Enable JitProfile frameSplit mode, if true, async will disable", EConsoleVariableFlags.ECVF_Default);
			IConsoleManager.RegisterConsoleVariable("cs.JitProfile.FrameSplitBatch", 100, "JitProfile frameSplit batch job count", EConsoleVariableFlags.ECVF_Default);
		}
	}
}
