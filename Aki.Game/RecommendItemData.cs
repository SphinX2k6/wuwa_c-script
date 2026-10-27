using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020024AE RID: 9390
[NullableContext(1)]
[Nullable(0)]
public class RecommendItemData
{
	// Token: 0x04008DFA RID: 36346
	public int AttrId;

	// Token: 0x04008DFB RID: 36347
	public int AddType;

	// Token: 0x04008DFC RID: 36348
	public List<VisionSelectRecommendData> CurrentSelectArray = new List<VisionSelectRecommendData>();

	// Token: 0x04008DFD RID: 36349
	public string UsageText = "";

	// Token: 0x04008DFE RID: 36350
	public int Type;

	// Token: 0x04008DFF RID: 36351
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RecommendItemData> OnSelectCallBack;
}
