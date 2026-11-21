using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001BE1 RID: 7137
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsBettingViewData : IRacingBetsBettingViewData
{
	// Token: 0x17001AE1 RID: 6881
	// (get) Token: 0x06011C0C RID: 72716 RVA: 0x0053A776 File Offset: 0x00538976
	// (set) Token: 0x06011C0D RID: 72717 RVA: 0x0053A77E File Offset: 0x0053897E
	public int SelectDangoId { get; set; }

	// Token: 0x17001AE2 RID: 6882
	// (get) Token: 0x06011C0E RID: 72718 RVA: 0x0053A787 File Offset: 0x00538987
	// (set) Token: 0x06011C0F RID: 72719 RVA: 0x0053A78F File Offset: 0x0053898F
	public RacingBetsLegMatchData LegMatchData { get; set; }

	// Token: 0x17001AE3 RID: 6883
	// (get) Token: 0x06011C10 RID: 72720 RVA: 0x0053A798 File Offset: 0x00538998
	// (set) Token: 0x06011C11 RID: 72721 RVA: 0x0053A7A0 File Offset: 0x005389A0
	public List<TsUiSceneDangoActor> DangoActorList { get; set; }
}
