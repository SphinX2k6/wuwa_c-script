using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005EC RID: 1516
[NullableContext(1)]
public interface IBabelTowerMutexGroupData
{
	// Token: 0x17000A19 RID: 2585
	// (get) Token: 0x06004760 RID: 18272
	// (set) Token: 0x06004761 RID: 18273
	int MutexId { get; set; }

	// Token: 0x17000A1A RID: 2586
	// (get) Token: 0x06004762 RID: 18274
	// (set) Token: 0x06004763 RID: 18275
	int GroupId { get; set; }

	// Token: 0x17000A1B RID: 2587
	// (get) Token: 0x06004764 RID: 18276
	// (set) Token: 0x06004765 RID: 18277
	List<int> DeTermList { get; set; }

	// Token: 0x17000A1C RID: 2588
	// (get) Token: 0x06004766 RID: 18278
	// (set) Token: 0x06004767 RID: 18279
	bool? IsNecessary { get; set; }

	// Token: 0x17000A1D RID: 2589
	// (get) Token: 0x06004768 RID: 18280
	// (set) Token: 0x06004769 RID: 18281
	int? CurrentDeTermId { get; set; }
}
