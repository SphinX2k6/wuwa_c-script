using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020026F5 RID: 9973
[NullableContext(1)]
public interface IRacingBetsBettingViewData
{
	// Token: 0x17001AA6 RID: 6822
	// (get) Token: 0x06014724 RID: 83748
	// (set) Token: 0x06014725 RID: 83749
	int SelectDangoId { get; set; }

	// Token: 0x17001AA7 RID: 6823
	// (get) Token: 0x06014726 RID: 83750
	// (set) Token: 0x06014727 RID: 83751
	RacingBetsLegMatchData LegMatchData { get; set; }

	// Token: 0x17001AA8 RID: 6824
	// (get) Token: 0x06014728 RID: 83752
	// (set) Token: 0x06014729 RID: 83753
	List<TsUiSceneDangoActor> DangoActorList { get; set; }
}
