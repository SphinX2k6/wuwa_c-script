using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020014E8 RID: 5352
[NullableContext(1)]
public interface IScratchTicketRoundResult
{
	// Token: 0x17000D24 RID: 3364
	// (get) Token: 0x06009854 RID: 38996
	// (set) Token: 0x06009855 RID: 38997
	List<ScratchTicketRewardResult> RewardList { get; set; }

	// Token: 0x17000D25 RID: 3365
	// (get) Token: 0x06009856 RID: 38998
	// (set) Token: 0x06009857 RID: 38999
	float DelayInterval { get; set; }

	// Token: 0x17000D26 RID: 3366
	// (get) Token: 0x06009858 RID: 39000
	// (set) Token: 0x06009859 RID: 39001
	string SequenceName { get; set; }
}
