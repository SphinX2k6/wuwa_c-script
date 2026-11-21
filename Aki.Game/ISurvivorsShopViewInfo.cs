using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002064 RID: 8292
[NullableContext(1)]
public interface ISurvivorsShopViewInfo
{
	// Token: 0x17001ECA RID: 7882
	// (get) Token: 0x060147E4 RID: 83940
	List<GoodsDetail> DataList { get; }

	// Token: 0x17001ECB RID: 7883
	// (get) Token: 0x060147E5 RID: 83941
	int RefreshItemId { get; }

	// Token: 0x17001ECC RID: 7884
	// (get) Token: 0x060147E6 RID: 83942
	int RefreshCost { get; }
}
