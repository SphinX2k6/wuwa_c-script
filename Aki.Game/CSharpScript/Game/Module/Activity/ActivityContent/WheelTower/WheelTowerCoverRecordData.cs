using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F1D RID: 20253
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerCoverRecordData : IWheelTowerCoverRecordData
	{
		// Token: 0x17006312 RID: 25362
		// (get) Token: 0x06032E3F RID: 208447 RVA: 0x00E47459 File Offset: 0x00E45659
		// (set) Token: 0x06032E40 RID: 208448 RVA: 0x00E47461 File Offset: 0x00E45661
		public int TotalScore { get; set; }

		// Token: 0x17006313 RID: 25363
		// (get) Token: 0x06032E41 RID: 208449 RVA: 0x00E4746A File Offset: 0x00E4566A
		// (set) Token: 0x06032E42 RID: 208450 RVA: 0x00E47472 File Offset: 0x00E45672
		public int TeamScore { get; set; }

		// Token: 0x17006314 RID: 25364
		// (get) Token: 0x06032E43 RID: 208451 RVA: 0x00E4747B File Offset: 0x00E4567B
		// (set) Token: 0x06032E44 RID: 208452 RVA: 0x00E47483 File Offset: 0x00E45683
		public List<int> TeamRoleIdList { get; set; } = new List<int>();

		// Token: 0x17006315 RID: 25365
		// (get) Token: 0x06032E45 RID: 208453 RVA: 0x00E4748C File Offset: 0x00E4568C
		// (set) Token: 0x06032E46 RID: 208454 RVA: 0x00E47494 File Offset: 0x00E45694
		public int BuffId { get; set; }

		// Token: 0x17006316 RID: 25366
		// (get) Token: 0x06032E47 RID: 208455 RVA: 0x00E4749D File Offset: 0x00E4569D
		// (set) Token: 0x06032E48 RID: 208456 RVA: 0x00E474A5 File Offset: 0x00E456A5
		public int BossRound { get; set; }

		// Token: 0x17006317 RID: 25367
		// (get) Token: 0x06032E49 RID: 208457 RVA: 0x00E474AE File Offset: 0x00E456AE
		// (set) Token: 0x06032E4A RID: 208458 RVA: 0x00E474B6 File Offset: 0x00E456B6
		public int BossWave { get; set; }

		// Token: 0x17006318 RID: 25368
		// (get) Token: 0x06032E4B RID: 208459 RVA: 0x00E474BF File Offset: 0x00E456BF
		// (set) Token: 0x06032E4C RID: 208460 RVA: 0x00E474C7 File Offset: 0x00E456C7
		public int NeedChallengeBossWaveNum { get; set; }

		// Token: 0x17006319 RID: 25369
		// (get) Token: 0x06032E4D RID: 208461 RVA: 0x00E474D0 File Offset: 0x00E456D0
		// (set) Token: 0x06032E4E RID: 208462 RVA: 0x00E474D8 File Offset: 0x00E456D8
		public int AddTeamScore { get; set; }
	}
}
