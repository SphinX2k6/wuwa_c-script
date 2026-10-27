using System;

// Token: 0x02002C29 RID: 11305
public interface ITutorialViewParam
{
	// Token: 0x17001FB6 RID: 8118
	// (get) Token: 0x060178D6 RID: 96470
	// (set) Token: 0x060178D7 RID: 96471
	int? TutorialId { get; set; }

	// Token: 0x17001FB7 RID: 8119
	// (get) Token: 0x060178D8 RID: 96472
	// (set) Token: 0x060178D9 RID: 96473
	EExclusiveTutorialType? ExclusiveType { get; set; }
}
