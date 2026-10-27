using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002703 RID: 9987
[NullableContext(1)]
public interface IRacingBetsBettingMainViewRecord
{
	// Token: 0x17001AE4 RID: 6884
	// (get) Token: 0x060147A7 RID: 83879
	// (set) Token: 0x060147A8 RID: 83880
	int SeasonId { get; set; }

	// Token: 0x17001AE5 RID: 6885
	// (get) Token: 0x060147A9 RID: 83881
	// (set) Token: 0x060147AA RID: 83882
	List<int> EnteredLegMatchIds { get; set; }
}
