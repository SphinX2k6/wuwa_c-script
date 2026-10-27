using System;

// Token: 0x02002C2A RID: 11306
public class TutorialViewParam : ITutorialViewParam
{
	// Token: 0x17001FB8 RID: 8120
	// (get) Token: 0x060178DA RID: 96474 RVA: 0x005FD0C8 File Offset: 0x005FB2C8
	// (set) Token: 0x060178DB RID: 96475 RVA: 0x005FD0D0 File Offset: 0x005FB2D0
	public int? TutorialId { get; set; }

	// Token: 0x17001FB9 RID: 8121
	// (get) Token: 0x060178DC RID: 96476 RVA: 0x005FD0D9 File Offset: 0x005FB2D9
	// (set) Token: 0x060178DD RID: 96477 RVA: 0x005FD0E1 File Offset: 0x005FB2E1
	public EExclusiveTutorialType? ExclusiveType { get; set; }
}
