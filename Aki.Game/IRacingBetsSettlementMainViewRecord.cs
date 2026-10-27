using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002701 RID: 9985
[NullableContext(1)]
public interface IRacingBetsSettlementMainViewRecord
{
	// Token: 0x17001AE0 RID: 6880
	// (get) Token: 0x0601479E RID: 83870
	// (set) Token: 0x0601479F RID: 83871
	int SeasonId { get; set; }

	// Token: 0x17001AE1 RID: 6881
	// (get) Token: 0x060147A0 RID: 83872
	// (set) Token: 0x060147A1 RID: 83873
	List<int> ViewedLegMatchIds { get; set; }
}
