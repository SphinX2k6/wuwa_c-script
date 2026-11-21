using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001931 RID: 6449
[NullableContext(1)]
public interface ICostCombinationData
{
	// Token: 0x17001867 RID: 6247
	// (get) Token: 0x0600FEE1 RID: 65249
	// (set) Token: 0x0600FEE2 RID: 65250
	int CostId { get; set; }

	// Token: 0x17001868 RID: 6248
	// (get) Token: 0x0600FEE3 RID: 65251
	// (set) Token: 0x0600FEE4 RID: 65252
	List<int> Costs { get; set; }

	// Token: 0x17001869 RID: 6249
	// (get) Token: 0x0600FEE5 RID: 65253
	// (set) Token: 0x0600FEE6 RID: 65254
	int Usage { get; set; }
}
