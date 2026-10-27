using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F45 RID: 24389
	[NullableContext(1)]
	public interface IWheelTowerSettlementViewData
	{
		// Token: 0x17008F9C RID: 36764
		// (get) Token: 0x0603DF64 RID: 253796
		// (set) Token: 0x0603DF65 RID: 253797
		bool EndlessMode { get; set; }

		// Token: 0x17008F9D RID: 36765
		// (get) Token: 0x0603DF66 RID: 253798
		// (set) Token: 0x0603DF67 RID: 253799
		int TotalRound { get; set; }

		// Token: 0x17008F9E RID: 36766
		// (get) Token: 0x0603DF68 RID: 253800
		// (set) Token: 0x0603DF69 RID: 253801
		int CurrentRound { get; set; }

		// Token: 0x17008F9F RID: 36767
		// (get) Token: 0x0603DF6A RID: 253802
		// (set) Token: 0x0603DF6B RID: 253803
		int TotalScore { get; set; }

		// Token: 0x17008FA0 RID: 36768
		// (get) Token: 0x0603DF6C RID: 253804
		// (set) Token: 0x0603DF6D RID: 253805
		int CurrentScore { get; set; }

		// Token: 0x17008FA1 RID: 36769
		// (get) Token: 0x0603DF6E RID: 253806
		// (set) Token: 0x0603DF6F RID: 253807
		List<IBossItemData> BossInfoList { get; set; }

		// Token: 0x17008FA2 RID: 36770
		// (get) Token: 0x0603DF70 RID: 253808
		// (set) Token: 0x0603DF71 RID: 253809
		int MaxBossWaveNum { get; set; }

		// Token: 0x17008FA3 RID: 36771
		// (get) Token: 0x0603DF72 RID: 253810
		// (set) Token: 0x0603DF73 RID: 253811
		List<RoleDataWithBranch> RoleList { get; set; }

		// Token: 0x17008FA4 RID: 36772
		// (get) Token: 0x0603DF74 RID: 253812
		// (set) Token: 0x0603DF75 RID: 253813
		List<int> FinishedSeasonTaskIds { get; set; }

		// Token: 0x17008FA5 RID: 36773
		// (get) Token: 0x0603DF76 RID: 253814
		// (set) Token: 0x0603DF77 RID: 253815
		[Nullable(2)]
		IWheelTowerSettlementViewButtonData LeftButtonData { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008FA6 RID: 36774
		// (get) Token: 0x0603DF78 RID: 253816
		// (set) Token: 0x0603DF79 RID: 253817
		[Nullable(2)]
		IWheelTowerSettlementViewButtonData CenterButtonData { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008FA7 RID: 36775
		// (get) Token: 0x0603DF7A RID: 253818
		// (set) Token: 0x0603DF7B RID: 253819
		[Nullable(2)]
		IWheelTowerSettlementViewButtonData RightButtonData { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008FA8 RID: 36776
		// (get) Token: 0x0603DF7C RID: 253820
		// (set) Token: 0x0603DF7D RID: 253821
		bool? ShowEndlessUnlockTips { get; set; }
	}
}
