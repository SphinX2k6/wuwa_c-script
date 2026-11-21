using System;

// Token: 0x02000687 RID: 1671
public class ChessItemParams : IChessItemParams
{
	// Token: 0x17000A7C RID: 2684
	// (get) Token: 0x06004D29 RID: 19753 RVA: 0x001A2A2B File Offset: 0x001A0C2B
	// (set) Token: 0x06004D2A RID: 19754 RVA: 0x001A2A33 File Offset: 0x001A0C33
	public int Id { get; set; }

	// Token: 0x17000A7D RID: 2685
	// (get) Token: 0x06004D2B RID: 19755 RVA: 0x001A2A3C File Offset: 0x001A0C3C
	// (set) Token: 0x06004D2C RID: 19756 RVA: 0x001A2A44 File Offset: 0x001A0C44
	public long CreatureDataId { get; set; }

	// Token: 0x17000A7E RID: 2686
	// (get) Token: 0x06004D2D RID: 19757 RVA: 0x001A2A4D File Offset: 0x001A0C4D
	// (set) Token: 0x06004D2E RID: 19758 RVA: 0x001A2A55 File Offset: 0x001A0C55
	public bool RotationIsForward { get; set; }

	// Token: 0x17000A7F RID: 2687
	// (get) Token: 0x06004D2F RID: 19759 RVA: 0x001A2A5E File Offset: 0x001A0C5E
	// (set) Token: 0x06004D30 RID: 19760 RVA: 0x001A2A66 File Offset: 0x001A0C66
	public int InitPointId { get; set; }
}
