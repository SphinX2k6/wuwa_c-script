using System;
using System.Runtime.CompilerServices;

// Token: 0x020011F6 RID: 4598
[NullableContext(1)]
public interface IActivityCorniceMeetingRewardItemData
{
	// Token: 0x17000A7F RID: 2687
	// (get) Token: 0x06007AEA RID: 31466
	// (set) Token: 0x06007AEB RID: 31467
	int RewardId { get; set; }

	// Token: 0x17000A80 RID: 2688
	// (get) Token: 0x06007AEC RID: 31468
	// (set) Token: 0x06007AED RID: 31469
	Action OnClickFinishBtnCb { get; set; }
}
