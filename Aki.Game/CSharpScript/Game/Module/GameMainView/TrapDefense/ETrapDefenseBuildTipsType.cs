using System;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense
{
	// Token: 0x020059F5 RID: 23029
	[Flags]
	public enum ETrapDefenseBuildTipsType
	{
		// Token: 0x0401E6DA RID: 124634
		None = 0,
		// Token: 0x0401E6DB RID: 124635
		Build = 1,
		// Token: 0x0401E6DC RID: 124636
		Rotate = 2,
		// Token: 0x0401E6DD RID: 124637
		Recycle = 4,
		// Token: 0x0401E6DE RID: 124638
		Pollute = 8,
		// Token: 0x0401E6DF RID: 124639
		Disable = 16
	}
}
