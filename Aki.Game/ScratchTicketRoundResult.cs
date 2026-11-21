using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020009A1 RID: 2465
[NullableContext(1)]
[Nullable(0)]
public class ScratchTicketRoundResult : IScratchTicketRoundResult
{
	// Token: 0x17000D48 RID: 3400
	// (get) Token: 0x06006C34 RID: 27700 RVA: 0x00218666 File Offset: 0x00216866
	// (set) Token: 0x06006C35 RID: 27701 RVA: 0x0021866E File Offset: 0x0021686E
	public List<ScratchTicketRewardResult> RewardList { get; set; }

	// Token: 0x17000D49 RID: 3401
	// (get) Token: 0x06006C36 RID: 27702 RVA: 0x00218677 File Offset: 0x00216877
	// (set) Token: 0x06006C37 RID: 27703 RVA: 0x0021867F File Offset: 0x0021687F
	public float DelayInterval { get; set; }

	// Token: 0x17000D4A RID: 3402
	// (get) Token: 0x06006C38 RID: 27704 RVA: 0x00218688 File Offset: 0x00216888
	// (set) Token: 0x06006C39 RID: 27705 RVA: 0x00218690 File Offset: 0x00216890
	public string SequenceName { get; set; }
}
