using System;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState
{
	// Token: 0x02005B55 RID: 23381
	[Flags]
	public enum ESunSpiritStateStatus
	{
		// Token: 0x0401E59A RID: 124314
		None = 0,
		// Token: 0x0401E59B RID: 124315
		Entering = 1,
		// Token: 0x0401E59C RID: 124316
		Entered = 2,
		// Token: 0x0401E59D RID: 124317
		Exiting = 4,
		// Token: 0x0401E59E RID: 124318
		Exited = 8
	}
}
