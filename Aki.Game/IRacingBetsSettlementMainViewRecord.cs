using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001BEC RID: 7148
[NullableContext(1)]
public interface IRacingBetsSettlementMainViewRecord
{
	// Token: 0x17001B18 RID: 6936
	// (get) Token: 0x06011C80 RID: 72832
	// (set) Token: 0x06011C81 RID: 72833
	int SeasonId { get; set; }

	// Token: 0x17001B19 RID: 6937
	// (get) Token: 0x06011C82 RID: 72834
	// (set) Token: 0x06011C83 RID: 72835
	List<int> ViewedLegMatchIds { get; set; }
}
