using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F43 RID: 24387
	[NullableContext(2)]
	public interface IWheelTowerResultViewData
	{
		// Token: 0x17008F88 RID: 36744
		// (get) Token: 0x0603DF3B RID: 253755
		// (set) Token: 0x0603DF3C RID: 253756
		bool EndlessMode { get; set; }

		// Token: 0x17008F89 RID: 36745
		// (get) Token: 0x0603DF3D RID: 253757
		// (set) Token: 0x0603DF3E RID: 253758
		int TotalRound { get; set; }

		// Token: 0x17008F8A RID: 36746
		// (get) Token: 0x0603DF3F RID: 253759
		// (set) Token: 0x0603DF40 RID: 253760
		int CurrentRound { get; set; }

		// Token: 0x17008F8B RID: 36747
		// (get) Token: 0x0603DF41 RID: 253761
		// (set) Token: 0x0603DF42 RID: 253762
		int TotalScore { get; set; }

		// Token: 0x17008F8C RID: 36748
		// (get) Token: 0x0603DF43 RID: 253763
		// (set) Token: 0x0603DF44 RID: 253764
		int CurrentScore { get; set; }

		// Token: 0x17008F8D RID: 36749
		// (get) Token: 0x0603DF45 RID: 253765
		// (set) Token: 0x0603DF46 RID: 253766
		[Nullable(1)]
		List<IBossItemData> BossInfoList { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17008F8E RID: 36750
		// (get) Token: 0x0603DF47 RID: 253767
		// (set) Token: 0x0603DF48 RID: 253768
		IWheelTowerResultViewButtonData LeftButtonData { get; set; }

		// Token: 0x17008F8F RID: 36751
		// (get) Token: 0x0603DF49 RID: 253769
		// (set) Token: 0x0603DF4A RID: 253770
		IWheelTowerResultViewButtonData CenterButtonData { get; set; }

		// Token: 0x17008F90 RID: 36752
		// (get) Token: 0x0603DF4B RID: 253771
		// (set) Token: 0x0603DF4C RID: 253772
		IWheelTowerResultViewButtonData RightButtonData { get; set; }

		// Token: 0x17008F91 RID: 36753
		// (get) Token: 0x0603DF4D RID: 253773
		// (set) Token: 0x0603DF4E RID: 253774
		bool? ShowEndlessUnlockTips { get; set; }
	}
}
