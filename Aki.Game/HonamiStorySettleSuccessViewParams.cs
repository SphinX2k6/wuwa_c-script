using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F19 RID: 7961
[NullableContext(1)]
[Nullable(0)]
public class HonamiStorySettleSuccessViewParams : IHonamiStorySettleSuccessViewParams
{
	// Token: 0x17001334 RID: 4916
	// (get) Token: 0x0600F53E RID: 62782 RVA: 0x003B2B76 File Offset: 0x003B0D76
	// (set) Token: 0x0600F53F RID: 62783 RVA: 0x003B2B7E File Offset: 0x003B0D7E
	public List<IHonamiStorySettleItemParams> DisplayItems { get; set; } = new List<IHonamiStorySettleItemParams>();

	// Token: 0x17001335 RID: 4917
	// (get) Token: 0x0600F540 RID: 62784 RVA: 0x003B2B87 File Offset: 0x003B0D87
	// (set) Token: 0x0600F541 RID: 62785 RVA: 0x003B2B8F File Offset: 0x003B0D8F
	public int TotalReward { get; set; }

	// Token: 0x17001336 RID: 4918
	// (get) Token: 0x0600F542 RID: 62786 RVA: 0x003B2B98 File Offset: 0x003B0D98
	// (set) Token: 0x0600F543 RID: 62787 RVA: 0x003B2BA0 File Offset: 0x003B0DA0
	public bool IsNewRecord { get; set; }
}
