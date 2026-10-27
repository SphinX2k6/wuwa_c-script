using System;

// Token: 0x020021AB RID: 8619
public class LordGymDifficultySelectViewParam : ILordGymDifficultySelectViewParam
{
	// Token: 0x1700154C RID: 5452
	// (get) Token: 0x06010C41 RID: 68673 RVA: 0x00412C1D File Offset: 0x00410E1D
	// (set) Token: 0x06010C42 RID: 68674 RVA: 0x00412C25 File Offset: 0x00410E25
	public int LordEntranceSetId { get; set; }

	// Token: 0x1700154D RID: 5453
	// (get) Token: 0x06010C43 RID: 68675 RVA: 0x00412C2E File Offset: 0x00410E2E
	// (set) Token: 0x06010C44 RID: 68676 RVA: 0x00412C36 File Offset: 0x00410E36
	public int LordEntranceId { get; set; }

	// Token: 0x1700154E RID: 5454
	// (get) Token: 0x06010C45 RID: 68677 RVA: 0x00412C3F File Offset: 0x00410E3F
	// (set) Token: 0x06010C46 RID: 68678 RVA: 0x00412C47 File Offset: 0x00410E47
	public bool IsPlaySpecialSequence { get; set; }

	// Token: 0x1700154F RID: 5455
	// (get) Token: 0x06010C47 RID: 68679 RVA: 0x00412C50 File Offset: 0x00410E50
	// (set) Token: 0x06010C48 RID: 68680 RVA: 0x00412C58 File Offset: 0x00410E58
	public int DefaultLordId { get; set; }
}
