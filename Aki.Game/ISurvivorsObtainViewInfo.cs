using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002056 RID: 8278
[NullableContext(1)]
public interface ISurvivorsObtainViewInfo
{
	// Token: 0x17001EAC RID: 7852
	// (get) Token: 0x06014782 RID: 83842
	string CaptionId { get; }

	// Token: 0x17001EAD RID: 7853
	// (get) Token: 0x06014783 RID: 83843
	string TitleId { get; }

	// Token: 0x17001EAE RID: 7854
	// (get) Token: 0x06014784 RID: 83844
	string ButtonId { get; }

	// Token: 0x17001EAF RID: 7855
	// (get) Token: 0x06014785 RID: 83845
	ISurvivorsChooseData ChooseData { get; }

	// Token: 0x17001EB0 RID: 7856
	// (get) Token: 0x06014786 RID: 83846
	IList<GoodsDetail> GoodsList { get; }
}
