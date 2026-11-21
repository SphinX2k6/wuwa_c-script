using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02000D0D RID: 3341
[NullableContext(1)]
[Nullable(0)]
public class FilterStorageData : IFilterStorageData
{
	// Token: 0x17000F54 RID: 3924
	// (get) Token: 0x06008A52 RID: 35410 RVA: 0x0029E1D8 File Offset: 0x0029C3D8
	// (set) Token: 0x06008A53 RID: 35411 RVA: 0x0029E1E0 File Offset: 0x0029C3E0
	public int ConfigId { get; set; }

	// Token: 0x17000F55 RID: 3925
	// (get) Token: 0x06008A54 RID: 35412 RVA: 0x0029E1E9 File Offset: 0x0029C3E9
	// (set) Token: 0x06008A55 RID: 35413 RVA: 0x0029E1F1 File Offset: 0x0029C3F1
	public Dictionary<FilterDefine.EFilterType, List<int>> SelectRuleMap { get; set; }
}
