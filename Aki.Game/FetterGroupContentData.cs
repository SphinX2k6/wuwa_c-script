using System;
using System.Runtime.CompilerServices;

// Token: 0x020024EF RID: 9455
public class FetterGroupContentData
{
	// Token: 0x04008F1E RID: 36638
	public int Index;

	// Token: 0x04008F1F RID: 36639
	public int CurrentSelectIndex;

	// Token: 0x04008F20 RID: 36640
	[Nullable(2)]
	public VisionFetterRecommendInfo VisionFetterRecommendInfo;

	// Token: 0x04008F21 RID: 36641
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FetterGroupContentData> ClickCallBack;
}
