using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F2D RID: 20269
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerSettlementViewData : IWheelTowerSettlementViewData
	{
		// Token: 0x1700637B RID: 25467
		// (get) Token: 0x06032F19 RID: 208665 RVA: 0x00E47898 File Offset: 0x00E45A98
		// (set) Token: 0x06032F1A RID: 208666 RVA: 0x00E478A0 File Offset: 0x00E45AA0
		public bool EndlessMode { get; set; }

		// Token: 0x1700637C RID: 25468
		// (get) Token: 0x06032F1B RID: 208667 RVA: 0x00E478A9 File Offset: 0x00E45AA9
		// (set) Token: 0x06032F1C RID: 208668 RVA: 0x00E478B1 File Offset: 0x00E45AB1
		public int TotalRound { get; set; }

		// Token: 0x1700637D RID: 25469
		// (get) Token: 0x06032F1D RID: 208669 RVA: 0x00E478BA File Offset: 0x00E45ABA
		// (set) Token: 0x06032F1E RID: 208670 RVA: 0x00E478C2 File Offset: 0x00E45AC2
		public int CurrentRound { get; set; }

		// Token: 0x1700637E RID: 25470
		// (get) Token: 0x06032F1F RID: 208671 RVA: 0x00E478CB File Offset: 0x00E45ACB
		// (set) Token: 0x06032F20 RID: 208672 RVA: 0x00E478D3 File Offset: 0x00E45AD3
		public int TotalScore { get; set; }

		// Token: 0x1700637F RID: 25471
		// (get) Token: 0x06032F21 RID: 208673 RVA: 0x00E478DC File Offset: 0x00E45ADC
		// (set) Token: 0x06032F22 RID: 208674 RVA: 0x00E478E4 File Offset: 0x00E45AE4
		public int CurrentScore { get; set; }

		// Token: 0x17006380 RID: 25472
		// (get) Token: 0x06032F23 RID: 208675 RVA: 0x00E478ED File Offset: 0x00E45AED
		// (set) Token: 0x06032F24 RID: 208676 RVA: 0x00E478F5 File Offset: 0x00E45AF5
		public List<IBossItemData> BossInfoList { get; set; } = new List<IBossItemData>();

		// Token: 0x17006381 RID: 25473
		// (get) Token: 0x06032F25 RID: 208677 RVA: 0x00E478FE File Offset: 0x00E45AFE
		// (set) Token: 0x06032F26 RID: 208678 RVA: 0x00E47906 File Offset: 0x00E45B06
		public int MaxBossWaveNum { get; set; }

		// Token: 0x17006382 RID: 25474
		// (get) Token: 0x06032F27 RID: 208679 RVA: 0x00E4790F File Offset: 0x00E45B0F
		// (set) Token: 0x06032F28 RID: 208680 RVA: 0x00E47917 File Offset: 0x00E45B17
		public List<RoleDataWithBranch> RoleList { get; set; } = new List<RoleDataWithBranch>();

		// Token: 0x17006383 RID: 25475
		// (get) Token: 0x06032F29 RID: 208681 RVA: 0x00E47920 File Offset: 0x00E45B20
		// (set) Token: 0x06032F2A RID: 208682 RVA: 0x00E47928 File Offset: 0x00E45B28
		public List<int> FinishedSeasonTaskIds { get; set; } = new List<int>();

		// Token: 0x17006384 RID: 25476
		// (get) Token: 0x06032F2B RID: 208683 RVA: 0x00E47931 File Offset: 0x00E45B31
		// (set) Token: 0x06032F2C RID: 208684 RVA: 0x00E47939 File Offset: 0x00E45B39
		[Nullable(2)]
		public IWheelTowerSettlementViewButtonData LeftButtonData { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006385 RID: 25477
		// (get) Token: 0x06032F2D RID: 208685 RVA: 0x00E47942 File Offset: 0x00E45B42
		// (set) Token: 0x06032F2E RID: 208686 RVA: 0x00E4794A File Offset: 0x00E45B4A
		[Nullable(2)]
		public IWheelTowerSettlementViewButtonData CenterButtonData { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006386 RID: 25478
		// (get) Token: 0x06032F2F RID: 208687 RVA: 0x00E47953 File Offset: 0x00E45B53
		// (set) Token: 0x06032F30 RID: 208688 RVA: 0x00E4795B File Offset: 0x00E45B5B
		[Nullable(2)]
		public IWheelTowerSettlementViewButtonData RightButtonData { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006387 RID: 25479
		// (get) Token: 0x06032F31 RID: 208689 RVA: 0x00E47964 File Offset: 0x00E45B64
		// (set) Token: 0x06032F32 RID: 208690 RVA: 0x00E4796C File Offset: 0x00E45B6C
		public bool? ShowEndlessUnlockTips { get; set; }
	}
}
