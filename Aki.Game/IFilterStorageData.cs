using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02001853 RID: 6227
[NullableContext(1)]
public interface IFilterStorageData
{
	// Token: 0x17000F2F RID: 3887
	// (get) Token: 0x0600B665 RID: 46693
	// (set) Token: 0x0600B666 RID: 46694
	int ConfigId { get; set; }

	// Token: 0x17000F30 RID: 3888
	// (get) Token: 0x0600B667 RID: 46695
	// (set) Token: 0x0600B668 RID: 46696
	Dictionary<FilterDefine.EFilterType, List<int>> SelectRuleMap { get; set; }
}
