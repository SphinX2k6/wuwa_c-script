using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020012A0 RID: 4768
[NullableContext(1)]
[Nullable(0)]
public class GeographyHandBookItemData : IGeographyHandBookItemData
{
	// Token: 0x170012A5 RID: 4773
	// (get) Token: 0x0600BCDC RID: 48348 RVA: 0x0037D77D File Offset: 0x0037B97D
	// (set) Token: 0x0600BCDD RID: 48349 RVA: 0x0037D785 File Offset: 0x0037B985
	public GeographyTabType TabType { get; set; }

	// Token: 0x170012A6 RID: 4774
	// (get) Token: 0x0600BCDE RID: 48350 RVA: 0x0037D78E File Offset: 0x0037B98E
	// (set) Token: 0x0600BCDF RID: 48351 RVA: 0x0037D796 File Offset: 0x0037B996
	public GeographyType Type { get; set; }

	// Token: 0x170012A7 RID: 4775
	// (get) Token: 0x0600BCE0 RID: 48352 RVA: 0x0037D79F File Offset: 0x0037B99F
	// (set) Token: 0x0600BCE1 RID: 48353 RVA: 0x0037D7A7 File Offset: 0x0037B9A7
	public List<GeographyHandBook> HandBookList { get; set; }
}
