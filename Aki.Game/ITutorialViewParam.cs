using System;

// Token: 0x020021A4 RID: 8612
public interface ITutorialViewParam
{
	// Token: 0x1700200E RID: 8206
	// (get) Token: 0x06015308 RID: 86792
	// (set) Token: 0x06015309 RID: 86793
	int? TutorialId { get; set; }

	// Token: 0x1700200F RID: 8207
	// (get) Token: 0x0601530A RID: 86794
	// (set) Token: 0x0601530B RID: 86795
	EExclusiveTutorialType? ExclusiveType { get; set; }
}
