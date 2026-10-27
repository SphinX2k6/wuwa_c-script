using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DDD RID: 7645
[NullableContext(1)]
public interface IGeographyHandBookItemData
{
	// Token: 0x17001278 RID: 4728
	// (get) Token: 0x0600E8B7 RID: 59575
	// (set) Token: 0x0600E8B8 RID: 59576
	GeographyTabType TabType { get; set; }

	// Token: 0x17001279 RID: 4729
	// (get) Token: 0x0600E8B9 RID: 59577
	// (set) Token: 0x0600E8BA RID: 59578
	GeographyType Type { get; set; }

	// Token: 0x1700127A RID: 4730
	// (get) Token: 0x0600E8BB RID: 59579
	// (set) Token: 0x0600E8BC RID: 59580
	List<GeographyHandBook> HandBookList { get; set; }
}
