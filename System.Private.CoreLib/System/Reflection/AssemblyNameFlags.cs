using System;

namespace System.Reflection
{
	// Token: 0x0200072D RID: 1837
	[Flags]
	public enum AssemblyNameFlags
	{
		// Token: 0x040015F9 RID: 5625
		None = 0,
		// Token: 0x040015FA RID: 5626
		PublicKey = 1,
		// Token: 0x040015FB RID: 5627
		EnableJITcompileOptimizer = 16384,
		// Token: 0x040015FC RID: 5628
		EnableJITcompileTracking = 32768,
		// Token: 0x040015FD RID: 5629
		Retargetable = 256
	}
}
