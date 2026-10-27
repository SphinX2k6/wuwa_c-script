using System;
using System.Runtime.CompilerServices;

// Token: 0x020011F7 RID: 4599
[NullableContext(1)]
[Nullable(0)]
public class ActivityCorniceMeetingRewardItemData : IActivityCorniceMeetingRewardItemData
{
	// Token: 0x17000A81 RID: 2689
	// (get) Token: 0x06007AEE RID: 31470 RVA: 0x0019E677 File Offset: 0x0019C877
	// (set) Token: 0x06007AEF RID: 31471 RVA: 0x0019E67F File Offset: 0x0019C87F
	public int RewardId { get; set; }

	// Token: 0x17000A82 RID: 2690
	// (get) Token: 0x06007AF0 RID: 31472 RVA: 0x0019E688 File Offset: 0x0019C888
	// (set) Token: 0x06007AF1 RID: 31473 RVA: 0x0019E690 File Offset: 0x0019C890
	public Action OnClickFinishBtnCb { get; set; }
}
