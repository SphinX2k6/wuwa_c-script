using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002AE8 RID: 10984
[NullableContext(1)]
public interface ISurvivorsShopViewInfo
{
	// Token: 0x17001E72 RID: 7794
	// (get) Token: 0x06016DB3 RID: 93619
	List<GoodsDetail> DataList { get; }

	// Token: 0x17001E73 RID: 7795
	// (get) Token: 0x06016DB4 RID: 93620
	int RefreshItemId { get; }

	// Token: 0x17001E74 RID: 7796
	// (get) Token: 0x06016DB5 RID: 93621
	int RefreshCost { get; }
}
