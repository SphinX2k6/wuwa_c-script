using System;
using System.Runtime.CompilerServices;

// Token: 0x02002743 RID: 10051
[NullableContext(1)]
[Nullable(0)]
public class RecommendQualityItemData : IRecommendQualityItemData
{
	// Token: 0x17001B03 RID: 6915
	// (get) Token: 0x060149E8 RID: 84456 RVA: 0x0053792B File Offset: 0x00535B2B
	// (set) Token: 0x060149E9 RID: 84457 RVA: 0x00537933 File Offset: 0x00535B33
	public EGameQualitySettingLevel Quality { get; set; }

	// Token: 0x17001B04 RID: 6916
	// (get) Token: 0x060149EA RID: 84458 RVA: 0x0053793C File Offset: 0x00535B3C
	// (set) Token: 0x060149EB RID: 84459 RVA: 0x00537944 File Offset: 0x00535B44
	public string Name { get; set; } = "";

	// Token: 0x17001B05 RID: 6917
	// (get) Token: 0x060149EC RID: 84460 RVA: 0x0053794D File Offset: 0x00535B4D
	// (set) Token: 0x060149ED RID: 84461 RVA: 0x00537955 File Offset: 0x00535B55
	public bool IsRecommend { get; set; }

	// Token: 0x17001B06 RID: 6918
	// (get) Token: 0x060149EE RID: 84462 RVA: 0x0053795E File Offset: 0x00535B5E
	// (set) Token: 0x060149EF RID: 84463 RVA: 0x00537966 File Offset: 0x00535B66
	public string Bg { get; set; } = "";
}
