using System;

namespace System.Reflection
{
	// Token: 0x02000770 RID: 1904
	[Flags]
	public enum PropertyAttributes
	{
		// Token: 0x0400170B RID: 5899
		None = 0,
		// Token: 0x0400170C RID: 5900
		SpecialName = 512,
		// Token: 0x0400170D RID: 5901
		RTSpecialName = 1024,
		// Token: 0x0400170E RID: 5902
		HasDefault = 4096,
		// Token: 0x0400170F RID: 5903
		Reserved2 = 8192,
		// Token: 0x04001710 RID: 5904
		Reserved3 = 16384,
		// Token: 0x04001711 RID: 5905
		Reserved4 = 32768,
		// Token: 0x04001712 RID: 5906
		ReservedMask = 62464
	}
}
