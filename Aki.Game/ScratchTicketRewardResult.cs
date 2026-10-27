using System;

// Token: 0x020014E7 RID: 5351
public class ScratchTicketRewardResult : IScratchTicketRewardResult
{
	// Token: 0x17000D21 RID: 3361
	// (get) Token: 0x0600984D RID: 38989 RVA: 0x0020E8EB File Offset: 0x0020CAEB
	// (set) Token: 0x0600984E RID: 38990 RVA: 0x0020E8F3 File Offset: 0x0020CAF3
	public int Index { get; set; }

	// Token: 0x17000D22 RID: 3362
	// (get) Token: 0x0600984F RID: 38991 RVA: 0x0020E8FC File Offset: 0x0020CAFC
	// (set) Token: 0x06009850 RID: 38992 RVA: 0x0020E904 File Offset: 0x0020CB04
	public EScratchDirectionType DirectionType { get; set; }

	// Token: 0x17000D23 RID: 3363
	// (get) Token: 0x06009851 RID: 38993 RVA: 0x0020E90D File Offset: 0x0020CB0D
	// (set) Token: 0x06009852 RID: 38994 RVA: 0x0020E915 File Offset: 0x0020CB15
	public ECellSequenceType SequenceType { get; set; }
}
