using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000D62 RID: 3426
[NullableContext(2)]
[Nullable(0)]
public class SortStorageData : ISortStorageData
{
	// Token: 0x17000F77 RID: 3959
	// (get) Token: 0x06008CAD RID: 36013 RVA: 0x002A92DC File Offset: 0x002A74DC
	// (set) Token: 0x06008CAE RID: 36014 RVA: 0x002A92E4 File Offset: 0x002A74E4
	public int ConfigId { get; set; }

	// Token: 0x17000F78 RID: 3960
	// (get) Token: 0x06008CAF RID: 36015 RVA: 0x002A92ED File Offset: 0x002A74ED
	// (set) Token: 0x06008CB0 RID: 36016 RVA: 0x002A92F5 File Offset: 0x002A74F5
	public int? SelectBaseSort { get; set; }

	// Token: 0x17000F79 RID: 3961
	// (get) Token: 0x06008CB1 RID: 36017 RVA: 0x002A92FE File Offset: 0x002A74FE
	// (set) Token: 0x06008CB2 RID: 36018 RVA: 0x002A9306 File Offset: 0x002A7506
	public List<int> SelectAttributeSort { get; set; }

	// Token: 0x17000F7A RID: 3962
	// (get) Token: 0x06008CB3 RID: 36019 RVA: 0x002A930F File Offset: 0x002A750F
	// (set) Token: 0x06008CB4 RID: 36020 RVA: 0x002A9317 File Offset: 0x002A7517
	public bool IsAscending { get; set; }
}
