using System;
using System.Runtime.CompilerServices;

// Token: 0x020019D6 RID: 6614
public class FetterGroupContentData
{
	// Token: 0x04009068 RID: 36968
	public int Index;

	// Token: 0x04009069 RID: 36969
	public int CurrentSelectIndex;

	// Token: 0x0400906A RID: 36970
	[Nullable(2)]
	public VisionFetterRecommendInfo VisionFetterRecommendInfo;

	// Token: 0x0400906B RID: 36971
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FetterGroupContentData> ClickCallBack;
}
