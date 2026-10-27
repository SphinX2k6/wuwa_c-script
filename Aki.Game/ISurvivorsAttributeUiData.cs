using System;

// Token: 0x02002AF8 RID: 11000
public interface ISurvivorsAttributeUiData
{
	// Token: 0x17001E8E RID: 7822
	// (get) Token: 0x06016E20 RID: 93728
	int AttrId { get; }

	// Token: 0x17001E8F RID: 7823
	// (get) Token: 0x06016E21 RID: 93729
	double Value { get; }

	// Token: 0x17001E90 RID: 7824
	// (get) Token: 0x06016E22 RID: 93730
	bool IsRecommend { get; }

	// Token: 0x17001E91 RID: 7825
	// (get) Token: 0x06016E23 RID: 93731
	bool? IsAddition { get; }
}
