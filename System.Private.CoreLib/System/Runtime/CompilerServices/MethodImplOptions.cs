using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006B3 RID: 1715
	[Flags]
	public enum MethodImplOptions
	{
		// Token: 0x040014C9 RID: 5321
		Unmanaged = 4,
		// Token: 0x040014CA RID: 5322
		NoInlining = 8,
		// Token: 0x040014CB RID: 5323
		ForwardRef = 16,
		// Token: 0x040014CC RID: 5324
		Synchronized = 32,
		// Token: 0x040014CD RID: 5325
		NoOptimization = 64,
		// Token: 0x040014CE RID: 5326
		PreserveSig = 128,
		// Token: 0x040014CF RID: 5327
		AggressiveInlining = 256,
		// Token: 0x040014D0 RID: 5328
		AggressiveOptimization = 512,
		// Token: 0x040014D1 RID: 5329
		InternalCall = 4096
	}
}
