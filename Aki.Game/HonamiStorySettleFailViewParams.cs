using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F13 RID: 7955
[NullableContext(1)]
[Nullable(0)]
public class HonamiStorySettleFailViewParams : IHonamiStorySettleFailViewParams
{
	// Token: 0x17001329 RID: 4905
	// (get) Token: 0x0600F51E RID: 62750 RVA: 0x003B2798 File Offset: 0x003B0998
	// (set) Token: 0x0600F51F RID: 62751 RVA: 0x003B27A0 File Offset: 0x003B09A0
	public List<IHonamiStorySettleItemParams> DisplayItems { get; set; } = new List<IHonamiStorySettleItemParams>();

	// Token: 0x1700132A RID: 4906
	// (get) Token: 0x0600F520 RID: 62752 RVA: 0x003B27A9 File Offset: 0x003B09A9
	// (set) Token: 0x0600F521 RID: 62753 RVA: 0x003B27B1 File Offset: 0x003B09B1
	public int TotalReward { get; set; }

	// Token: 0x1700132B RID: 4907
	// (get) Token: 0x0600F522 RID: 62754 RVA: 0x003B27BA File Offset: 0x003B09BA
	// (set) Token: 0x0600F523 RID: 62755 RVA: 0x003B27C2 File Offset: 0x003B09C2
	public bool IsNewRecord { get; set; }

	// Token: 0x1700132C RID: 4908
	// (get) Token: 0x0600F524 RID: 62756 RVA: 0x003B27CB File Offset: 0x003B09CB
	// (set) Token: 0x0600F525 RID: 62757 RVA: 0x003B27D3 File Offset: 0x003B09D3
	public int FailAddProportion { get; set; }
}
