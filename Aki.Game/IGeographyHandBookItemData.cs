using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200129F RID: 4767
[NullableContext(1)]
public interface IGeographyHandBookItemData
{
	// Token: 0x170012A2 RID: 4770
	// (get) Token: 0x0600BCD6 RID: 48342
	// (set) Token: 0x0600BCD7 RID: 48343
	GeographyTabType TabType { get; set; }

	// Token: 0x170012A3 RID: 4771
	// (get) Token: 0x0600BCD8 RID: 48344
	// (set) Token: 0x0600BCD9 RID: 48345
	GeographyType Type { get; set; }

	// Token: 0x170012A4 RID: 4772
	// (get) Token: 0x0600BCDA RID: 48346
	// (set) Token: 0x0600BCDB RID: 48347
	List<GeographyHandBook> HandBookList { get; set; }
}
