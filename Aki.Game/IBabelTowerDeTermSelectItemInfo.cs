using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005E6 RID: 1510
[NullableContext(1)]
public interface IBabelTowerDeTermSelectItemInfo
{
	// Token: 0x170009FB RID: 2555
	// (get) Token: 0x06004721 RID: 18209
	// (set) Token: 0x06004722 RID: 18210
	bool IsNecessary { get; set; }

	// Token: 0x170009FC RID: 2556
	// (get) Token: 0x06004723 RID: 18211
	// (set) Token: 0x06004724 RID: 18212
	List<int> AllDeTerm { get; set; }

	// Token: 0x170009FD RID: 2557
	// (get) Token: 0x06004725 RID: 18213
	// (set) Token: 0x06004726 RID: 18214
	List<int> DailyDeTerm { get; set; }

	// Token: 0x170009FE RID: 2558
	// (get) Token: 0x06004727 RID: 18215
	// (set) Token: 0x06004728 RID: 18216
	Action<int> OnChangeSelectDeTerm { get; set; }
}
