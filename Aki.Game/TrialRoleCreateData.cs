using System;

// Token: 0x020028E9 RID: 10473
public class TrialRoleCreateData : ITrialRoleCreateData
{
	// Token: 0x17001D0A RID: 7434
	// (get) Token: 0x060159F2 RID: 88562 RVA: 0x00574ED8 File Offset: 0x005730D8
	// (set) Token: 0x060159F3 RID: 88563 RVA: 0x00574EE0 File Offset: 0x005730E0
	public int TrialRoleId { get; set; }

	// Token: 0x17001D0B RID: 7435
	// (get) Token: 0x060159F4 RID: 88564 RVA: 0x00574EE9 File Offset: 0x005730E9
	// (set) Token: 0x060159F5 RID: 88565 RVA: 0x00574EF1 File Offset: 0x005730F1
	public bool IsUnlocked { get; set; }
}
