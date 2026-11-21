using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005CC RID: 1484
	[Flags]
	public enum DllImportSearchPath
	{
		// Token: 0x04001295 RID: 4757
		UseDllDirectoryForDependencies = 256,
		// Token: 0x04001296 RID: 4758
		ApplicationDirectory = 512,
		// Token: 0x04001297 RID: 4759
		UserDirectories = 1024,
		// Token: 0x04001298 RID: 4760
		System32 = 2048,
		// Token: 0x04001299 RID: 4761
		SafeDirectories = 4096,
		// Token: 0x0400129A RID: 4762
		AssemblyDirectory = 2,
		// Token: 0x0400129B RID: 4763
		LegacyBehavior = 0
	}
}
