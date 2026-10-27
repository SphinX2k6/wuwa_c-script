using System;

// Token: 0x020026FD RID: 9981
public interface IDangoMatchRoleData
{
	// Token: 0x17001AD2 RID: 6866
	// (get) Token: 0x06014780 RID: 83840
	// (set) Token: 0x06014781 RID: 83841
	int GroupMatchId { get; set; }

	// Token: 0x17001AD3 RID: 6867
	// (get) Token: 0x06014782 RID: 83842
	// (set) Token: 0x06014783 RID: 83843
	int DangoId { get; set; }

	// Token: 0x17001AD4 RID: 6868
	// (get) Token: 0x06014784 RID: 83844
	// (set) Token: 0x06014785 RID: 83845
	bool IsMatchFinished { get; set; }

	// Token: 0x17001AD5 RID: 6869
	// (get) Token: 0x06014786 RID: 83846
	// (set) Token: 0x06014787 RID: 83847
	bool IsPromote { get; set; }

	// Token: 0x17001AD6 RID: 6870
	// (get) Token: 0x06014788 RID: 83848
	// (set) Token: 0x06014789 RID: 83849
	bool IsBasicGroupMatch { get; set; }
}
