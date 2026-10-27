using System;

// Token: 0x020011D2 RID: 4562
public interface IChessItemParams
{
	// Token: 0x17000A58 RID: 2648
	// (get) Token: 0x0600798A RID: 31114
	// (set) Token: 0x0600798B RID: 31115
	int Id { get; set; }

	// Token: 0x17000A59 RID: 2649
	// (get) Token: 0x0600798C RID: 31116
	// (set) Token: 0x0600798D RID: 31117
	long CreatureDataId { get; set; }

	// Token: 0x17000A5A RID: 2650
	// (get) Token: 0x0600798E RID: 31118
	// (set) Token: 0x0600798F RID: 31119
	bool RotationIsForward { get; set; }

	// Token: 0x17000A5B RID: 2651
	// (get) Token: 0x06007990 RID: 31120
	// (set) Token: 0x06007991 RID: 31121
	int InitPointId { get; set; }
}
