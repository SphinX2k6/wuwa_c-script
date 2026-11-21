using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02000D0C RID: 3340
[NullableContext(1)]
public interface IFilterStorageData
{
	// Token: 0x17000F52 RID: 3922
	// (get) Token: 0x06008A4E RID: 35406
	// (set) Token: 0x06008A4F RID: 35407
	int ConfigId { get; set; }

	// Token: 0x17000F53 RID: 3923
	// (get) Token: 0x06008A50 RID: 35408
	// (set) Token: 0x06008A51 RID: 35409
	Dictionary<FilterDefine.EFilterType, List<int>> SelectRuleMap { get; set; }
}
