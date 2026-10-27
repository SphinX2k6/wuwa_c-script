using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200235B RID: 9051
[NullableContext(1)]
[Nullable(0)]
public class PayShopRecommendData
{
	// Token: 0x060120AE RID: 73902 RVA: 0x0046D2B0 File Offset: 0x0046B4B0
	public void Phrase(PayShopRecommendConfigInfo info)
	{
		this.Id = info.Id;
		this.RecommendType = info.RecommendType;
		this.RecommendId = info.RecommendId;
		this.TabName = info.TabName;
		this.PrefabPath = info.PrefabPath;
		this.Sort = info.Sort;
		this.Show = info.Show;
		this.TabImage = info.TabImage;
	}

	// Token: 0x04008869 RID: 34921
	public int Id;

	// Token: 0x0400886A RID: 34922
	public int RecommendType;

	// Token: 0x0400886B RID: 34923
	public int RecommendId;

	// Token: 0x0400886C RID: 34924
	public string TabName = "";

	// Token: 0x0400886D RID: 34925
	public string PrefabPath = "";

	// Token: 0x0400886E RID: 34926
	public int Sort;

	// Token: 0x0400886F RID: 34927
	public bool Show = true;

	// Token: 0x04008870 RID: 34928
	public string TabImage = "";
}
