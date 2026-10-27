using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F44 RID: 24388
	[NullableContext(2)]
	[Nullable(0)]
	public class WheelTowerResultViewData : IWheelTowerResultViewData
	{
		// Token: 0x17008F92 RID: 36754
		// (get) Token: 0x0603DF4F RID: 253775 RVA: 0x00EF5AAF File Offset: 0x00EF3CAF
		// (set) Token: 0x0603DF50 RID: 253776 RVA: 0x00EF5AB7 File Offset: 0x00EF3CB7
		public bool EndlessMode { get; set; }

		// Token: 0x17008F93 RID: 36755
		// (get) Token: 0x0603DF51 RID: 253777 RVA: 0x00EF5AC0 File Offset: 0x00EF3CC0
		// (set) Token: 0x0603DF52 RID: 253778 RVA: 0x00EF5AC8 File Offset: 0x00EF3CC8
		public int TotalRound { get; set; }

		// Token: 0x17008F94 RID: 36756
		// (get) Token: 0x0603DF53 RID: 253779 RVA: 0x00EF5AD1 File Offset: 0x00EF3CD1
		// (set) Token: 0x0603DF54 RID: 253780 RVA: 0x00EF5AD9 File Offset: 0x00EF3CD9
		public int CurrentRound { get; set; }

		// Token: 0x17008F95 RID: 36757
		// (get) Token: 0x0603DF55 RID: 253781 RVA: 0x00EF5AE2 File Offset: 0x00EF3CE2
		// (set) Token: 0x0603DF56 RID: 253782 RVA: 0x00EF5AEA File Offset: 0x00EF3CEA
		public int TotalScore { get; set; }

		// Token: 0x17008F96 RID: 36758
		// (get) Token: 0x0603DF57 RID: 253783 RVA: 0x00EF5AF3 File Offset: 0x00EF3CF3
		// (set) Token: 0x0603DF58 RID: 253784 RVA: 0x00EF5AFB File Offset: 0x00EF3CFB
		public int CurrentScore { get; set; }

		// Token: 0x17008F97 RID: 36759
		// (get) Token: 0x0603DF59 RID: 253785 RVA: 0x00EF5B04 File Offset: 0x00EF3D04
		// (set) Token: 0x0603DF5A RID: 253786 RVA: 0x00EF5B0C File Offset: 0x00EF3D0C
		[Nullable(1)]
		public List<IBossItemData> BossInfoList { [NullableContext(1)] get; [NullableContext(1)] set; } = new List<IBossItemData>();

		// Token: 0x17008F98 RID: 36760
		// (get) Token: 0x0603DF5B RID: 253787 RVA: 0x00EF5B15 File Offset: 0x00EF3D15
		// (set) Token: 0x0603DF5C RID: 253788 RVA: 0x00EF5B1D File Offset: 0x00EF3D1D
		public IWheelTowerResultViewButtonData LeftButtonData { get; set; }

		// Token: 0x17008F99 RID: 36761
		// (get) Token: 0x0603DF5D RID: 253789 RVA: 0x00EF5B26 File Offset: 0x00EF3D26
		// (set) Token: 0x0603DF5E RID: 253790 RVA: 0x00EF5B2E File Offset: 0x00EF3D2E
		public IWheelTowerResultViewButtonData CenterButtonData { get; set; }

		// Token: 0x17008F9A RID: 36762
		// (get) Token: 0x0603DF5F RID: 253791 RVA: 0x00EF5B37 File Offset: 0x00EF3D37
		// (set) Token: 0x0603DF60 RID: 253792 RVA: 0x00EF5B3F File Offset: 0x00EF3D3F
		public IWheelTowerResultViewButtonData RightButtonData { get; set; }

		// Token: 0x17008F9B RID: 36763
		// (get) Token: 0x0603DF61 RID: 253793 RVA: 0x00EF5B48 File Offset: 0x00EF3D48
		// (set) Token: 0x0603DF62 RID: 253794 RVA: 0x00EF5B50 File Offset: 0x00EF3D50
		public bool? ShowEndlessUnlockTips { get; set; }
	}
}
