using System;

// Token: 0x0200041A RID: 1050
public class QTEFlavorInfo : IQTEFlavorInfo
{
	// Token: 0x170007DF RID: 2015
	// (get) Token: 0x06003872 RID: 14450 RVA: 0x0014897F File Offset: 0x00146B7F
	// (set) Token: 0x06003873 RID: 14451 RVA: 0x00148987 File Offset: 0x00146B87
	public EDrinksFlavorType Type { get; set; }

	// Token: 0x170007E0 RID: 2016
	// (get) Token: 0x06003874 RID: 14452 RVA: 0x00148990 File Offset: 0x00146B90
	// (set) Token: 0x06003875 RID: 14453 RVA: 0x00148998 File Offset: 0x00146B98
	public int Value { get; set; }
}
