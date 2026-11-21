using System;

namespace System.Reflection
{
	// Token: 0x0200073F RID: 1855
	[Flags]
	public enum EventAttributes
	{
		// Token: 0x0400164D RID: 5709
		None = 0,
		// Token: 0x0400164E RID: 5710
		SpecialName = 512,
		// Token: 0x0400164F RID: 5711
		RTSpecialName = 1024,
		// Token: 0x04001650 RID: 5712
		ReservedMask = 1024
	}
}
