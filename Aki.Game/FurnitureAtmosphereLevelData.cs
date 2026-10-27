using System;

// Token: 0x02000F91 RID: 3985
public class FurnitureAtmosphereLevelData : IFurnitureAtmosphereLevelData
{
	// Token: 0x170007FB RID: 2043
	// (get) Token: 0x06006620 RID: 26144 RVA: 0x00143F55 File Offset: 0x00142155
	// (set) Token: 0x06006621 RID: 26145 RVA: 0x00143F5D File Offset: 0x0014215D
	public int Level { get; set; }

	// Token: 0x170007FC RID: 2044
	// (get) Token: 0x06006622 RID: 26146 RVA: 0x00143F66 File Offset: 0x00142166
	// (set) Token: 0x06006623 RID: 26147 RVA: 0x00143F6E File Offset: 0x0014216E
	public int CurLevelAtmosphere { get; set; }

	// Token: 0x170007FD RID: 2045
	// (get) Token: 0x06006624 RID: 26148 RVA: 0x00143F77 File Offset: 0x00142177
	// (set) Token: 0x06006625 RID: 26149 RVA: 0x00143F7F File Offset: 0x0014217F
	public int CurLevelMaxAtmosphere { get; set; }
}
