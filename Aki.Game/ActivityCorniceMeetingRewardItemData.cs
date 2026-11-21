using System;
using System.Runtime.CompilerServices;

// Token: 0x020006AB RID: 1707
[NullableContext(1)]
[Nullable(0)]
public class ActivityCorniceMeetingRewardItemData : IActivityCorniceMeetingRewardItemData
{
	// Token: 0x17000AA1 RID: 2721
	// (get) Token: 0x06004E84 RID: 20100 RVA: 0x001A732F File Offset: 0x001A552F
	// (set) Token: 0x06004E85 RID: 20101 RVA: 0x001A7337 File Offset: 0x001A5537
	public int RewardId { get; set; }

	// Token: 0x17000AA2 RID: 2722
	// (get) Token: 0x06004E86 RID: 20102 RVA: 0x001A7340 File Offset: 0x001A5540
	// (set) Token: 0x06004E87 RID: 20103 RVA: 0x001A7348 File Offset: 0x001A5548
	public Action OnClickFinishBtnCb { get; set; }
}
