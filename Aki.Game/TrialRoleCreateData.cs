using System;

// Token: 0x02001E64 RID: 7780
public class TrialRoleCreateData : ITrialRoleCreateData
{
	// Token: 0x17001D64 RID: 7524
	// (get) Token: 0x060133F6 RID: 78838 RVA: 0x0059FDA0 File Offset: 0x0059DFA0
	// (set) Token: 0x060133F7 RID: 78839 RVA: 0x0059FDA8 File Offset: 0x0059DFA8
	public int TrialRoleId { get; set; }

	// Token: 0x17001D65 RID: 7525
	// (get) Token: 0x060133F8 RID: 78840 RVA: 0x0059FDB1 File Offset: 0x0059DFB1
	// (set) Token: 0x060133F9 RID: 78841 RVA: 0x0059FDB9 File Offset: 0x0059DFB9
	public bool IsUnlocked { get; set; }
}
