using System;

// Token: 0x0200099F RID: 2463
public class ScratchTicketRewardResult : IScratchTicketRewardResult
{
	// Token: 0x17000D42 RID: 3394
	// (get) Token: 0x06006C27 RID: 27687 RVA: 0x0021862B File Offset: 0x0021682B
	// (set) Token: 0x06006C28 RID: 27688 RVA: 0x00218633 File Offset: 0x00216833
	public int Index { get; set; }

	// Token: 0x17000D43 RID: 3395
	// (get) Token: 0x06006C29 RID: 27689 RVA: 0x0021863C File Offset: 0x0021683C
	// (set) Token: 0x06006C2A RID: 27690 RVA: 0x00218644 File Offset: 0x00216844
	public EScratchDirectionType DirectionType { get; set; }

	// Token: 0x17000D44 RID: 3396
	// (get) Token: 0x06006C2B RID: 27691 RVA: 0x0021864D File Offset: 0x0021684D
	// (set) Token: 0x06006C2C RID: 27692 RVA: 0x00218655 File Offset: 0x00216855
	public ECellSequenceType SequenceType { get; set; }
}
