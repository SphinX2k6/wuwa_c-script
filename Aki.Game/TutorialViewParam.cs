using System;

// Token: 0x020021A5 RID: 8613
public class TutorialViewParam : ITutorialViewParam
{
	// Token: 0x17002010 RID: 8208
	// (get) Token: 0x0601530C RID: 86796 RVA: 0x00629AEC File Offset: 0x00627CEC
	// (set) Token: 0x0601530D RID: 86797 RVA: 0x00629AF4 File Offset: 0x00627CF4
	public int? TutorialId { get; set; }

	// Token: 0x17002011 RID: 8209
	// (get) Token: 0x0601530E RID: 86798 RVA: 0x00629AFD File Offset: 0x00627CFD
	// (set) Token: 0x0601530F RID: 86799 RVA: 0x00629B05 File Offset: 0x00627D05
	public EExclusiveTutorialType? ExclusiveType { get; set; }
}
