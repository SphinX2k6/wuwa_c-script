using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002ADA RID: 10970
[NullableContext(1)]
public interface ISurvivorsObtainViewInfo
{
	// Token: 0x17001E54 RID: 7764
	// (get) Token: 0x06016D51 RID: 93521
	string CaptionId { get; }

	// Token: 0x17001E55 RID: 7765
	// (get) Token: 0x06016D52 RID: 93522
	string TitleId { get; }

	// Token: 0x17001E56 RID: 7766
	// (get) Token: 0x06016D53 RID: 93523
	string ButtonId { get; }

	// Token: 0x17001E57 RID: 7767
	// (get) Token: 0x06016D54 RID: 93524
	ISurvivorsChooseData ChooseData { get; }

	// Token: 0x17001E58 RID: 7768
	// (get) Token: 0x06016D55 RID: 93525
	IList<GoodsDetail> GoodsList { get; }
}
