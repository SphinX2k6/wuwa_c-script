using System;

// Token: 0x020011D9 RID: 4569
public class ChessTransmitData : IChessTransmitData
{
	// Token: 0x17000A64 RID: 2660
	// (get) Token: 0x060079B0 RID: 31152 RVA: 0x0019A0AC File Offset: 0x001982AC
	// (set) Token: 0x060079B1 RID: 31153 RVA: 0x0019A0B4 File Offset: 0x001982B4
	public int ItemId { get; set; }

	// Token: 0x17000A65 RID: 2661
	// (get) Token: 0x060079B2 RID: 31154 RVA: 0x0019A0BD File Offset: 0x001982BD
	// (set) Token: 0x060079B3 RID: 31155 RVA: 0x0019A0C5 File Offset: 0x001982C5
	public int TargetPointId { get; set; }

	// Token: 0x17000A66 RID: 2662
	// (get) Token: 0x060079B4 RID: 31156 RVA: 0x0019A0CE File Offset: 0x001982CE
	// (set) Token: 0x060079B5 RID: 31157 RVA: 0x0019A0D6 File Offset: 0x001982D6
	public int High { get; set; }
}
