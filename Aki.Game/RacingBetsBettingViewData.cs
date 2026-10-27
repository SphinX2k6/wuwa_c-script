using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020026F6 RID: 9974
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsBettingViewData : IRacingBetsBettingViewData
{
	// Token: 0x17001AA9 RID: 6825
	// (get) Token: 0x0601472A RID: 83754 RVA: 0x0052BA5A File Offset: 0x00529C5A
	// (set) Token: 0x0601472B RID: 83755 RVA: 0x0052BA62 File Offset: 0x00529C62
	public int SelectDangoId { get; set; }

	// Token: 0x17001AAA RID: 6826
	// (get) Token: 0x0601472C RID: 83756 RVA: 0x0052BA6B File Offset: 0x00529C6B
	// (set) Token: 0x0601472D RID: 83757 RVA: 0x0052BA73 File Offset: 0x00529C73
	public RacingBetsLegMatchData LegMatchData { get; set; }

	// Token: 0x17001AAB RID: 6827
	// (get) Token: 0x0601472E RID: 83758 RVA: 0x0052BA7C File Offset: 0x00529C7C
	// (set) Token: 0x0601472F RID: 83759 RVA: 0x0052BA84 File Offset: 0x00529C84
	public List<TsUiSceneDangoActor> DangoActorList { get; set; }
}
