using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001BE0 RID: 7136
[NullableContext(1)]
public interface IRacingBetsBettingViewData
{
	// Token: 0x17001ADE RID: 6878
	// (get) Token: 0x06011C06 RID: 72710
	// (set) Token: 0x06011C07 RID: 72711
	int SelectDangoId { get; set; }

	// Token: 0x17001ADF RID: 6879
	// (get) Token: 0x06011C08 RID: 72712
	// (set) Token: 0x06011C09 RID: 72713
	RacingBetsLegMatchData LegMatchData { get; set; }

	// Token: 0x17001AE0 RID: 6880
	// (get) Token: 0x06011C0A RID: 72714
	// (set) Token: 0x06011C0B RID: 72715
	List<TsUiSceneDangoActor> DangoActorList { get; set; }
}
