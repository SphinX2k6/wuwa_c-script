using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020018A8 RID: 6312
[NullableContext(2)]
public interface ISortStorageData
{
	// Token: 0x17000F50 RID: 3920
	// (get) Token: 0x0600B8BC RID: 47292
	// (set) Token: 0x0600B8BD RID: 47293
	int ConfigId { get; set; }

	// Token: 0x17000F51 RID: 3921
	// (get) Token: 0x0600B8BE RID: 47294
	// (set) Token: 0x0600B8BF RID: 47295
	int? SelectBaseSort { get; set; }

	// Token: 0x17000F52 RID: 3922
	// (get) Token: 0x0600B8C0 RID: 47296
	// (set) Token: 0x0600B8C1 RID: 47297
	List<int> SelectAttributeSort { get; set; }

	// Token: 0x17000F53 RID: 3923
	// (get) Token: 0x0600B8C2 RID: 47298
	// (set) Token: 0x0600B8C3 RID: 47299
	bool IsAscending { get; set; }
}
