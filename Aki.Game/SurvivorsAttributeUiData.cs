using System;

// Token: 0x02002075 RID: 8309
public class SurvivorsAttributeUiData : ISurvivorsAttributeUiData
{
	// Token: 0x17001EEA RID: 7914
	// (get) Token: 0x06014855 RID: 84053 RVA: 0x005FB0DA File Offset: 0x005F92DA
	// (set) Token: 0x06014856 RID: 84054 RVA: 0x005FB0E2 File Offset: 0x005F92E2
	public int AttrId { get; set; }

	// Token: 0x17001EEB RID: 7915
	// (get) Token: 0x06014857 RID: 84055 RVA: 0x005FB0EB File Offset: 0x005F92EB
	// (set) Token: 0x06014858 RID: 84056 RVA: 0x005FB0F3 File Offset: 0x005F92F3
	public double Value { get; set; }

	// Token: 0x17001EEC RID: 7916
	// (get) Token: 0x06014859 RID: 84057 RVA: 0x005FB0FC File Offset: 0x005F92FC
	// (set) Token: 0x0601485A RID: 84058 RVA: 0x005FB104 File Offset: 0x005F9304
	public bool IsRecommend { get; set; }

	// Token: 0x17001EED RID: 7917
	// (get) Token: 0x0601485B RID: 84059 RVA: 0x005FB10D File Offset: 0x005F930D
	// (set) Token: 0x0601485C RID: 84060 RVA: 0x005FB115 File Offset: 0x005F9315
	public bool? IsAddition { get; set; }
}
