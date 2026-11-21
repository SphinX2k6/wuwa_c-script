using System;

// Token: 0x02001ED3 RID: 7891
public interface IGetTeamItemOptions
{
	// Token: 0x17001DC3 RID: 7619
	// (get) Token: 0x060137E5 RID: 79845
	// (set) Token: 0x060137E6 RID: 79846
	ETeamParamType ParamType { get; set; }

	// Token: 0x17001DC4 RID: 7620
	// (get) Token: 0x060137E7 RID: 79847
	// (set) Token: 0x060137E8 RID: 79848
	bool? OnlyMyRole { get; set; }

	// Token: 0x17001DC5 RID: 7621
	// (get) Token: 0x060137E9 RID: 79849
	// (set) Token: 0x060137EA RID: 79850
	bool? IsControl { get; set; }
}
