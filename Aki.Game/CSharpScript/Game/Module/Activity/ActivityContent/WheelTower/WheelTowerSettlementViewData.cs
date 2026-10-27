using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F46 RID: 24390
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerSettlementViewData : IWheelTowerSettlementViewData
	{
		// Token: 0x17008FA9 RID: 36777
		// (get) Token: 0x0603DF7E RID: 253822 RVA: 0x00EF5B6C File Offset: 0x00EF3D6C
		// (set) Token: 0x0603DF7F RID: 253823 RVA: 0x00EF5B74 File Offset: 0x00EF3D74
		public bool EndlessMode { get; set; }

		// Token: 0x17008FAA RID: 36778
		// (get) Token: 0x0603DF80 RID: 253824 RVA: 0x00EF5B7D File Offset: 0x00EF3D7D
		// (set) Token: 0x0603DF81 RID: 253825 RVA: 0x00EF5B85 File Offset: 0x00EF3D85
		public int TotalRound { get; set; }

		// Token: 0x17008FAB RID: 36779
		// (get) Token: 0x0603DF82 RID: 253826 RVA: 0x00EF5B8E File Offset: 0x00EF3D8E
		// (set) Token: 0x0603DF83 RID: 253827 RVA: 0x00EF5B96 File Offset: 0x00EF3D96
		public int CurrentRound { get; set; }

		// Token: 0x17008FAC RID: 36780
		// (get) Token: 0x0603DF84 RID: 253828 RVA: 0x00EF5B9F File Offset: 0x00EF3D9F
		// (set) Token: 0x0603DF85 RID: 253829 RVA: 0x00EF5BA7 File Offset: 0x00EF3DA7
		public int TotalScore { get; set; }

		// Token: 0x17008FAD RID: 36781
		// (get) Token: 0x0603DF86 RID: 253830 RVA: 0x00EF5BB0 File Offset: 0x00EF3DB0
		// (set) Token: 0x0603DF87 RID: 253831 RVA: 0x00EF5BB8 File Offset: 0x00EF3DB8
		public int CurrentScore { get; set; }

		// Token: 0x17008FAE RID: 36782
		// (get) Token: 0x0603DF88 RID: 253832 RVA: 0x00EF5BC1 File Offset: 0x00EF3DC1
		// (set) Token: 0x0603DF89 RID: 253833 RVA: 0x00EF5BC9 File Offset: 0x00EF3DC9
		public List<IBossItemData> BossInfoList { get; set; } = new List<IBossItemData>();

		// Token: 0x17008FAF RID: 36783
		// (get) Token: 0x0603DF8A RID: 253834 RVA: 0x00EF5BD2 File Offset: 0x00EF3DD2
		// (set) Token: 0x0603DF8B RID: 253835 RVA: 0x00EF5BDA File Offset: 0x00EF3DDA
		public int MaxBossWaveNum { get; set; }

		// Token: 0x17008FB0 RID: 36784
		// (get) Token: 0x0603DF8C RID: 253836 RVA: 0x00EF5BE3 File Offset: 0x00EF3DE3
		// (set) Token: 0x0603DF8D RID: 253837 RVA: 0x00EF5BEB File Offset: 0x00EF3DEB
		public List<RoleDataWithBranch> RoleList { get; set; } = new List<RoleDataWithBranch>();

		// Token: 0x17008FB1 RID: 36785
		// (get) Token: 0x0603DF8E RID: 253838 RVA: 0x00EF5BF4 File Offset: 0x00EF3DF4
		// (set) Token: 0x0603DF8F RID: 253839 RVA: 0x00EF5BFC File Offset: 0x00EF3DFC
		public List<int> FinishedSeasonTaskIds { get; set; } = new List<int>();

		// Token: 0x17008FB2 RID: 36786
		// (get) Token: 0x0603DF90 RID: 253840 RVA: 0x00EF5C05 File Offset: 0x00EF3E05
		// (set) Token: 0x0603DF91 RID: 253841 RVA: 0x00EF5C0D File Offset: 0x00EF3E0D
		[Nullable(2)]
		public IWheelTowerSettlementViewButtonData LeftButtonData { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008FB3 RID: 36787
		// (get) Token: 0x0603DF92 RID: 253842 RVA: 0x00EF5C16 File Offset: 0x00EF3E16
		// (set) Token: 0x0603DF93 RID: 253843 RVA: 0x00EF5C1E File Offset: 0x00EF3E1E
		[Nullable(2)]
		public IWheelTowerSettlementViewButtonData CenterButtonData { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008FB4 RID: 36788
		// (get) Token: 0x0603DF94 RID: 253844 RVA: 0x00EF5C27 File Offset: 0x00EF3E27
		// (set) Token: 0x0603DF95 RID: 253845 RVA: 0x00EF5C2F File Offset: 0x00EF3E2F
		[Nullable(2)]
		public IWheelTowerSettlementViewButtonData RightButtonData { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008FB5 RID: 36789
		// (get) Token: 0x0603DF96 RID: 253846 RVA: 0x00EF5C38 File Offset: 0x00EF3E38
		// (set) Token: 0x0603DF97 RID: 253847 RVA: 0x00EF5C40 File Offset: 0x00EF3E40
		public bool? ShowEndlessUnlockTips { get; set; }
	}
}
