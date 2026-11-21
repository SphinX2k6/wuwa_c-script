using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F2C RID: 20268
	[NullableContext(1)]
	public interface IWheelTowerSettlementViewData
	{
		// Token: 0x1700636E RID: 25454
		// (get) Token: 0x06032EFF RID: 208639
		// (set) Token: 0x06032F00 RID: 208640
		bool EndlessMode { get; set; }

		// Token: 0x1700636F RID: 25455
		// (get) Token: 0x06032F01 RID: 208641
		// (set) Token: 0x06032F02 RID: 208642
		int TotalRound { get; set; }

		// Token: 0x17006370 RID: 25456
		// (get) Token: 0x06032F03 RID: 208643
		// (set) Token: 0x06032F04 RID: 208644
		int CurrentRound { get; set; }

		// Token: 0x17006371 RID: 25457
		// (get) Token: 0x06032F05 RID: 208645
		// (set) Token: 0x06032F06 RID: 208646
		int TotalScore { get; set; }

		// Token: 0x17006372 RID: 25458
		// (get) Token: 0x06032F07 RID: 208647
		// (set) Token: 0x06032F08 RID: 208648
		int CurrentScore { get; set; }

		// Token: 0x17006373 RID: 25459
		// (get) Token: 0x06032F09 RID: 208649
		// (set) Token: 0x06032F0A RID: 208650
		List<IBossItemData> BossInfoList { get; set; }

		// Token: 0x17006374 RID: 25460
		// (get) Token: 0x06032F0B RID: 208651
		// (set) Token: 0x06032F0C RID: 208652
		int MaxBossWaveNum { get; set; }

		// Token: 0x17006375 RID: 25461
		// (get) Token: 0x06032F0D RID: 208653
		// (set) Token: 0x06032F0E RID: 208654
		List<RoleDataWithBranch> RoleList { get; set; }

		// Token: 0x17006376 RID: 25462
		// (get) Token: 0x06032F0F RID: 208655
		// (set) Token: 0x06032F10 RID: 208656
		List<int> FinishedSeasonTaskIds { get; set; }

		// Token: 0x17006377 RID: 25463
		// (get) Token: 0x06032F11 RID: 208657
		// (set) Token: 0x06032F12 RID: 208658
		[Nullable(2)]
		IWheelTowerSettlementViewButtonData LeftButtonData { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006378 RID: 25464
		// (get) Token: 0x06032F13 RID: 208659
		// (set) Token: 0x06032F14 RID: 208660
		[Nullable(2)]
		IWheelTowerSettlementViewButtonData CenterButtonData { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006379 RID: 25465
		// (get) Token: 0x06032F15 RID: 208661
		// (set) Token: 0x06032F16 RID: 208662
		[Nullable(2)]
		IWheelTowerSettlementViewButtonData RightButtonData { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x1700637A RID: 25466
		// (get) Token: 0x06032F17 RID: 208663
		// (set) Token: 0x06032F18 RID: 208664
		bool? ShowEndlessUnlockTips { get; set; }
	}
}
