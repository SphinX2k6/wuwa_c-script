using System;

// Token: 0x0200168F RID: 5775
public class LordGymDifficultySelectViewParam : ILordGymDifficultySelectViewParam
{
	// Token: 0x17001583 RID: 5507
	// (get) Token: 0x0600E0D2 RID: 57554 RVA: 0x0041F505 File Offset: 0x0041D705
	// (set) Token: 0x0600E0D3 RID: 57555 RVA: 0x0041F50D File Offset: 0x0041D70D
	public int LordEntranceSetId { get; set; }

	// Token: 0x17001584 RID: 5508
	// (get) Token: 0x0600E0D4 RID: 57556 RVA: 0x0041F516 File Offset: 0x0041D716
	// (set) Token: 0x0600E0D5 RID: 57557 RVA: 0x0041F51E File Offset: 0x0041D71E
	public int LordEntranceId { get; set; }

	// Token: 0x17001585 RID: 5509
	// (get) Token: 0x0600E0D6 RID: 57558 RVA: 0x0041F527 File Offset: 0x0041D727
	// (set) Token: 0x0600E0D7 RID: 57559 RVA: 0x0041F52F File Offset: 0x0041D72F
	public bool IsPlaySpecialSequence { get; set; }

	// Token: 0x17001586 RID: 5510
	// (get) Token: 0x0600E0D8 RID: 57560 RVA: 0x0041F538 File Offset: 0x0041D738
	// (set) Token: 0x0600E0D9 RID: 57561 RVA: 0x0041F540 File Offset: 0x0041D740
	public int DefaultLordId { get; set; }
}
