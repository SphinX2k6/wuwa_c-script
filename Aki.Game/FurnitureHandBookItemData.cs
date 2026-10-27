using System;
using Aki.Config;

// Token: 0x02000FD9 RID: 4057
public class FurnitureHandBookItemData : IFurnitureHandBookItemData
{
	// Token: 0x17000870 RID: 2160
	// (get) Token: 0x06006835 RID: 26677 RVA: 0x0014B0F0 File Offset: 0x001492F0
	// (set) Token: 0x06006836 RID: 26678 RVA: 0x0014B0F8 File Offset: 0x001492F8
	public Furniture FurnitureConfig { get; set; }

	// Token: 0x17000871 RID: 2161
	// (get) Token: 0x06006837 RID: 26679 RVA: 0x0014B101 File Offset: 0x00149301
	// (set) Token: 0x06006838 RID: 26680 RVA: 0x0014B109 File Offset: 0x00149309
	public bool IsLock { get; set; }

	// Token: 0x17000872 RID: 2162
	// (get) Token: 0x06006839 RID: 26681 RVA: 0x0014B112 File Offset: 0x00149312
	// (set) Token: 0x0600683A RID: 26682 RVA: 0x0014B11A File Offset: 0x0014931A
	public bool RedDotVisible { get; set; }
}
