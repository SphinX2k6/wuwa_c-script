using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006787 RID: 26503
	[Flags]
	public enum ECombineLineShowReason
	{
		// Token: 0x040227EF RID: 141295
		None = 0,
		// Token: 0x040227F0 RID: 141296
		Hover = 1,
		// Token: 0x040227F1 RID: 141297
		Drag = 2,
		// Token: 0x040227F2 RID: 141298
		Holding = 4,
		// Token: 0x040227F3 RID: 141299
		Partner = 8,
		// Token: 0x040227F4 RID: 141300
		Always = 16
	}
}
