using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DDE RID: 7646
[NullableContext(1)]
[Nullable(0)]
public class GeographyHandBookItemData : IGeographyHandBookItemData
{
	// Token: 0x1700127B RID: 4731
	// (get) Token: 0x0600E8BD RID: 59581 RVA: 0x00371A91 File Offset: 0x0036FC91
	// (set) Token: 0x0600E8BE RID: 59582 RVA: 0x00371A99 File Offset: 0x0036FC99
	public GeographyTabType TabType { get; set; }

	// Token: 0x1700127C RID: 4732
	// (get) Token: 0x0600E8BF RID: 59583 RVA: 0x00371AA2 File Offset: 0x0036FCA2
	// (set) Token: 0x0600E8C0 RID: 59584 RVA: 0x00371AAA File Offset: 0x0036FCAA
	public GeographyType Type { get; set; }

	// Token: 0x1700127D RID: 4733
	// (get) Token: 0x0600E8C1 RID: 59585 RVA: 0x00371AB3 File Offset: 0x0036FCB3
	// (set) Token: 0x0600E8C2 RID: 59586 RVA: 0x00371ABB File Offset: 0x0036FCBB
	public List<GeographyHandBook> HandBookList { get; set; }
}
