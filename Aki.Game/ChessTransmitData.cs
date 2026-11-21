using System;

// Token: 0x0200068D RID: 1677
public class ChessTransmitData : IChessTransmitData
{
	// Token: 0x17000A84 RID: 2692
	// (get) Token: 0x06004D47 RID: 19783 RVA: 0x001A2D5C File Offset: 0x001A0F5C
	// (set) Token: 0x06004D48 RID: 19784 RVA: 0x001A2D64 File Offset: 0x001A0F64
	public int ItemId { get; set; }

	// Token: 0x17000A85 RID: 2693
	// (get) Token: 0x06004D49 RID: 19785 RVA: 0x001A2D6D File Offset: 0x001A0F6D
	// (set) Token: 0x06004D4A RID: 19786 RVA: 0x001A2D75 File Offset: 0x001A0F75
	public int TargetPointId { get; set; }

	// Token: 0x17000A86 RID: 2694
	// (get) Token: 0x06004D4B RID: 19787 RVA: 0x001A2D7E File Offset: 0x001A0F7E
	// (set) Token: 0x06004D4C RID: 19788 RVA: 0x001A2D86 File Offset: 0x001A0F86
	public int High { get; set; }
}
