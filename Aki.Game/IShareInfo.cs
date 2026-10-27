using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E42 RID: 3650
[NullableContext(1)]
public interface IShareInfo
{
	// Token: 0x1700065A RID: 1626
	// (get) Token: 0x060057DF RID: 22495
	// (set) Token: 0x060057E0 RID: 22496
	string ImageData { get; set; }

	// Token: 0x1700065B RID: 1627
	// (get) Token: 0x060057E1 RID: 22497
	// (set) Token: 0x060057E2 RID: 22498
	ShareData ShareData { get; set; }
}
