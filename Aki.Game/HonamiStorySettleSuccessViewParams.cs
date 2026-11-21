using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020013DB RID: 5083
[NullableContext(1)]
[Nullable(0)]
public class HonamiStorySettleSuccessViewParams : IHonamiStorySettleSuccessViewParams
{
	// Token: 0x1700135E RID: 4958
	// (get) Token: 0x0600C95D RID: 51549 RVA: 0x003BE662 File Offset: 0x003BC862
	// (set) Token: 0x0600C95E RID: 51550 RVA: 0x003BE66A File Offset: 0x003BC86A
	public List<IHonamiStorySettleItemParams> DisplayItems { get; set; } = new List<IHonamiStorySettleItemParams>();

	// Token: 0x1700135F RID: 4959
	// (get) Token: 0x0600C95F RID: 51551 RVA: 0x003BE673 File Offset: 0x003BC873
	// (set) Token: 0x0600C960 RID: 51552 RVA: 0x003BE67B File Offset: 0x003BC87B
	public int TotalReward { get; set; }

	// Token: 0x17001360 RID: 4960
	// (get) Token: 0x0600C961 RID: 51553 RVA: 0x003BE684 File Offset: 0x003BC884
	// (set) Token: 0x0600C962 RID: 51554 RVA: 0x003BE68C File Offset: 0x003BC88C
	public bool IsNewRecord { get; set; }
}
