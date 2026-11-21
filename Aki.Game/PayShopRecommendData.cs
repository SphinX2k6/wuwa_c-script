using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001840 RID: 6208
[NullableContext(1)]
[Nullable(0)]
public class PayShopRecommendData
{
	// Token: 0x0600F55E RID: 62814 RVA: 0x0047A370 File Offset: 0x00478570
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

	// Token: 0x040089AE RID: 35246
	public int Id;

	// Token: 0x040089AF RID: 35247
	public int RecommendType;

	// Token: 0x040089B0 RID: 35248
	public int RecommendId;

	// Token: 0x040089B1 RID: 35249
	public string TabName = "";

	// Token: 0x040089B2 RID: 35250
	public string PrefabPath = "";

	// Token: 0x040089B3 RID: 35251
	public int Sort;

	// Token: 0x040089B4 RID: 35252
	public bool Show = true;

	// Token: 0x040089B5 RID: 35253
	public string TabImage = "";
}
