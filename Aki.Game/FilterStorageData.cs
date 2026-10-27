using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02001854 RID: 6228
[NullableContext(1)]
[Nullable(0)]
public class FilterStorageData : IFilterStorageData
{
	// Token: 0x17000F31 RID: 3889
	// (get) Token: 0x0600B669 RID: 46697 RVA: 0x00293AC8 File Offset: 0x00291CC8
	// (set) Token: 0x0600B66A RID: 46698 RVA: 0x00293AD0 File Offset: 0x00291CD0
	public int ConfigId { get; set; }

	// Token: 0x17000F32 RID: 3890
	// (get) Token: 0x0600B66B RID: 46699 RVA: 0x00293AD9 File Offset: 0x00291CD9
	// (set) Token: 0x0600B66C RID: 46700 RVA: 0x00293AE1 File Offset: 0x00291CE1
	public Dictionary<FilterDefine.EFilterType, List<int>> SelectRuleMap { get; set; }
}
