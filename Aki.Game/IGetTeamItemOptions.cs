using System;

// Token: 0x02002958 RID: 10584
public interface IGetTeamItemOptions
{
	// Token: 0x17001D6A RID: 7530
	// (get) Token: 0x06015DE1 RID: 89569
	// (set) Token: 0x06015DE2 RID: 89570
	ETeamParamType ParamType { get; set; }

	// Token: 0x17001D6B RID: 7531
	// (get) Token: 0x06015DE3 RID: 89571
	// (set) Token: 0x06015DE4 RID: 89572
	bool? OnlyMyRole { get; set; }

	// Token: 0x17001D6C RID: 7532
	// (get) Token: 0x06015DE5 RID: 89573
	// (set) Token: 0x06015DE6 RID: 89574
	bool? IsControl { get; set; }
}
