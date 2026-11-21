using System;

// Token: 0x02002074 RID: 8308
public interface ISurvivorsAttributeUiData
{
	// Token: 0x17001EE6 RID: 7910
	// (get) Token: 0x06014851 RID: 84049
	int AttrId { get; }

	// Token: 0x17001EE7 RID: 7911
	// (get) Token: 0x06014852 RID: 84050
	double Value { get; }

	// Token: 0x17001EE8 RID: 7912
	// (get) Token: 0x06014853 RID: 84051
	bool IsRecommend { get; }

	// Token: 0x17001EE9 RID: 7913
	// (get) Token: 0x06014854 RID: 84052
	bool? IsAddition { get; }
}
