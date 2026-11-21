using System;
using System.Runtime.CompilerServices;

// Token: 0x02000B1C RID: 2844
[NullableContext(2)]
[Nullable(0)]
public class WuWuLogisticsInfoItemData : IWuWuLogisticsInfoItemData
{
	// Token: 0x17000DBF RID: 3519
	// (get) Token: 0x06007574 RID: 30068 RVA: 0x00244691 File Offset: 0x00242891
	// (set) Token: 0x06007575 RID: 30069 RVA: 0x00244699 File Offset: 0x00242899
	public int CfgId { get; set; }

	// Token: 0x17000DC0 RID: 3520
	// (get) Token: 0x06007576 RID: 30070 RVA: 0x002446A2 File Offset: 0x002428A2
	// (set) Token: 0x06007577 RID: 30071 RVA: 0x002446AA File Offset: 0x002428AA
	public bool IsToday { get; set; }

	// Token: 0x17000DC1 RID: 3521
	// (get) Token: 0x06007578 RID: 30072 RVA: 0x002446B3 File Offset: 0x002428B3
	// (set) Token: 0x06007579 RID: 30073 RVA: 0x002446BB File Offset: 0x002428BB
	public string Content { get; set; }
}
