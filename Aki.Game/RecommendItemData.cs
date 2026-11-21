using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001995 RID: 6549
[NullableContext(1)]
[Nullable(0)]
public class RecommendItemData
{
	// Token: 0x04008F44 RID: 36676
	public int AttrId;

	// Token: 0x04008F45 RID: 36677
	public int AddType;

	// Token: 0x04008F46 RID: 36678
	public List<VisionSelectRecommendData> CurrentSelectArray = new List<VisionSelectRecommendData>();

	// Token: 0x04008F47 RID: 36679
	public string UsageText = "";

	// Token: 0x04008F48 RID: 36680
	public int Type;

	// Token: 0x04008F49 RID: 36681
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RecommendItemData> OnSelectCallBack;
}
