using System;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense
{
	// Token: 0x020049D1 RID: 18897
	[Flags]
	public enum ETrapDefenseBuildTipsType
	{
		// Token: 0x04019181 RID: 102785
		None = 0,
		// Token: 0x04019182 RID: 102786
		Build = 1,
		// Token: 0x04019183 RID: 102787
		Rotate = 2,
		// Token: 0x04019184 RID: 102788
		Recycle = 4,
		// Token: 0x04019185 RID: 102789
		Pollute = 8,
		// Token: 0x04019186 RID: 102790
		Disable = 16
	}
}
