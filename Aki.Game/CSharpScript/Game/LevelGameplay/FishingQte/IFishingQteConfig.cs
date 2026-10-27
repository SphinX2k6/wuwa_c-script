using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E2D RID: 28205
	[NullableContext(1)]
	public interface IFishingQteConfig
	{
		// Token: 0x17009A01 RID: 39425
		// (get) Token: 0x06044BDB RID: 281563
		// (set) Token: 0x06044BDC RID: 281564
		int Id { get; set; }

		// Token: 0x17009A02 RID: 39426
		// (get) Token: 0x06044BDD RID: 281565
		// (set) Token: 0x06044BDE RID: 281566
		List<int> RandomArea { get; set; }

		// Token: 0x17009A03 RID: 39427
		// (get) Token: 0x06044BDF RID: 281567
		// (set) Token: 0x06044BE0 RID: 281568
		IntArray[] InvalidArea { get; set; }

		// Token: 0x17009A04 RID: 39428
		// (get) Token: 0x06044BE1 RID: 281569
		// (set) Token: 0x06044BE2 RID: 281570
		int MaxScore { get; set; }

		// Token: 0x17009A05 RID: 39429
		// (get) Token: 0x06044BE3 RID: 281571
		// (set) Token: 0x06044BE4 RID: 281572
		int HitAreaScore { get; set; }

		// Token: 0x17009A06 RID: 39430
		// (get) Token: 0x06044BE5 RID: 281573
		// (set) Token: 0x06044BE6 RID: 281574
		int PerfectSize { get; set; }

		// Token: 0x17009A07 RID: 39431
		// (get) Token: 0x06044BE7 RID: 281575
		// (set) Token: 0x06044BE8 RID: 281576
		Dictionary<int, int> PerfectAppearRate { get; set; }

		// Token: 0x17009A08 RID: 39432
		// (get) Token: 0x06044BE9 RID: 281577
		// (set) Token: 0x06044BEA RID: 281578
		int PerfectScore { get; set; }

		// Token: 0x17009A09 RID: 39433
		// (get) Token: 0x06044BEB RID: 281579
		// (set) Token: 0x06044BEC RID: 281580
		Dictionary<int, int> CursorSpeed { get; set; }

		// Token: 0x17009A0A RID: 39434
		// (get) Token: 0x06044BED RID: 281581
		// (set) Token: 0x06044BEE RID: 281582
		int HitColdTime { get; set; }

		// Token: 0x17009A0B RID: 39435
		// (get) Token: 0x06044BEF RID: 281583
		// (set) Token: 0x06044BF0 RID: 281584
		int ScoreUp { get; set; }

		// Token: 0x17009A0C RID: 39436
		// (get) Token: 0x06044BF1 RID: 281585
		// (set) Token: 0x06044BF2 RID: 281586
		int MultiBoxGroup { get; set; }

		// Token: 0x17009A0D RID: 39437
		// (get) Token: 0x06044BF3 RID: 281587
		// (set) Token: 0x06044BF4 RID: 281588
		List<float> HiddenInterval { get; set; }

		// Token: 0x17009A0E RID: 39438
		// (get) Token: 0x06044BF5 RID: 281589
		// (set) Token: 0x06044BF6 RID: 281590
		Dictionary<int, int> RouletteRotateSpeed { get; set; }

		// Token: 0x17009A0F RID: 39439
		// (get) Token: 0x06044BF7 RID: 281591
		// (set) Token: 0x06044BF8 RID: 281592
		int MistakeScore { get; set; }

		// Token: 0x17009A10 RID: 39440
		// (get) Token: 0x06044BF9 RID: 281593
		// (set) Token: 0x06044BFA RID: 281594
		bool IsAnticlockwise { get; set; }

		// Token: 0x17009A11 RID: 39441
		// (get) Token: 0x06044BFB RID: 281595
		// (set) Token: 0x06044BFC RID: 281596
		string Comment { get; set; }

		// Token: 0x17009A12 RID: 39442
		// (get) Token: 0x06044BFD RID: 281597
		// (set) Token: 0x06044BFE RID: 281598
		int RefreshType { get; set; }
	}
}
