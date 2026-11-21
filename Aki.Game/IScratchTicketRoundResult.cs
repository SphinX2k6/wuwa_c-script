using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020009A0 RID: 2464
[NullableContext(1)]
public interface IScratchTicketRoundResult
{
	// Token: 0x17000D45 RID: 3397
	// (get) Token: 0x06006C2E RID: 27694
	// (set) Token: 0x06006C2F RID: 27695
	List<ScratchTicketRewardResult> RewardList { get; set; }

	// Token: 0x17000D46 RID: 3398
	// (get) Token: 0x06006C30 RID: 27696
	// (set) Token: 0x06006C31 RID: 27697
	float DelayInterval { get; set; }

	// Token: 0x17000D47 RID: 3399
	// (get) Token: 0x06006C32 RID: 27698
	// (set) Token: 0x06006C33 RID: 27699
	string SequenceName { get; set; }
}
