using System;

namespace System.Reflection
{
	// Token: 0x0200074A RID: 1866
	[Flags]
	internal enum InvocationFlags : uint
	{
		// Token: 0x0400167E RID: 5758
		Unknown = 0U,
		// Token: 0x0400167F RID: 5759
		Initialized = 1U,
		// Token: 0x04001680 RID: 5760
		NoInvoke = 2U,
		// Token: 0x04001681 RID: 5761
		RunClassConstructor = 4U,
		// Token: 0x04001682 RID: 5762
		NoConstructorInvoke = 8U,
		// Token: 0x04001683 RID: 5763
		IsConstructor = 16U,
		// Token: 0x04001684 RID: 5764
		IsDelegateConstructor = 128U,
		// Token: 0x04001685 RID: 5765
		ContainsStackPointers = 256U,
		// Token: 0x04001686 RID: 5766
		SpecialField = 16U,
		// Token: 0x04001687 RID: 5767
		FieldSpecialCast = 32U
	}
}
