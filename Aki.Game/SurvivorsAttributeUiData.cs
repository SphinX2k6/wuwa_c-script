using System;

// Token: 0x02002AF9 RID: 11001
public class SurvivorsAttributeUiData : ISurvivorsAttributeUiData
{
	// Token: 0x17001E92 RID: 7826
	// (get) Token: 0x06016E24 RID: 93732 RVA: 0x005CE55A File Offset: 0x005CC75A
	// (set) Token: 0x06016E25 RID: 93733 RVA: 0x005CE562 File Offset: 0x005CC762
	public int AttrId { get; set; }

	// Token: 0x17001E93 RID: 7827
	// (get) Token: 0x06016E26 RID: 93734 RVA: 0x005CE56B File Offset: 0x005CC76B
	// (set) Token: 0x06016E27 RID: 93735 RVA: 0x005CE573 File Offset: 0x005CC773
	public double Value { get; set; }

	// Token: 0x17001E94 RID: 7828
	// (get) Token: 0x06016E28 RID: 93736 RVA: 0x005CE57C File Offset: 0x005CC77C
	// (set) Token: 0x06016E29 RID: 93737 RVA: 0x005CE584 File Offset: 0x005CC784
	public bool IsRecommend { get; set; }

	// Token: 0x17001E95 RID: 7829
	// (get) Token: 0x06016E2A RID: 93738 RVA: 0x005CE58D File Offset: 0x005CC78D
	// (set) Token: 0x06016E2B RID: 93739 RVA: 0x005CE595 File Offset: 0x005CC795
	public bool? IsAddition { get; set; }
}
