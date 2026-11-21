using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056D7 RID: 22231
	[Flags]
	public enum ECombineLineShowReason
	{
		// Token: 0x0401D04C RID: 118860
		None = 0,
		// Token: 0x0401D04D RID: 118861
		Hover = 1,
		// Token: 0x0401D04E RID: 118862
		Drag = 2,
		// Token: 0x0401D04F RID: 118863
		Holding = 4,
		// Token: 0x0401D050 RID: 118864
		Partner = 8,
		// Token: 0x0401D051 RID: 118865
		Always = 16
	}
}
