using System;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02004E9C RID: 20124
	public interface IDetectingObj
	{
		// Token: 0x17006285 RID: 25221
		// (get) Token: 0x06032A7E RID: 207486
		// (set) Token: 0x06032A7F RID: 207487
		int Id { get; set; }

		// Token: 0x17006286 RID: 25222
		// (get) Token: 0x06032A80 RID: 207488
		// (set) Token: 0x06032A81 RID: 207489
		long RefreshTime { get; set; }

		// Token: 0x17006287 RID: 25223
		// (get) Token: 0x06032A82 RID: 207490
		// (set) Token: 0x06032A83 RID: 207491
		int MapId { get; set; }

		// Token: 0x17006288 RID: 25224
		// (get) Token: 0x06032A84 RID: 207492
		// (set) Token: 0x06032A85 RID: 207493
		float PositionX { get; set; }

		// Token: 0x17006289 RID: 25225
		// (get) Token: 0x06032A86 RID: 207494
		// (set) Token: 0x06032A87 RID: 207495
		float PositionY { get; set; }

		// Token: 0x1700628A RID: 25226
		// (get) Token: 0x06032A88 RID: 207496
		// (set) Token: 0x06032A89 RID: 207497
		float PositionZ { get; set; }
	}
}
