using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D8C RID: 3468
[NullableContext(1)]
public interface IGetWayItemData
{
	// Token: 0x17000F8F RID: 3983
	// (get) Token: 0x06008E53 RID: 36435
	// (set) Token: 0x06008E54 RID: 36436
	int Id { get; set; }

	// Token: 0x17000F90 RID: 3984
	// (get) Token: 0x06008E55 RID: 36437
	// (set) Token: 0x06008E56 RID: 36438
	EGetWayItemType Type { get; set; }

	// Token: 0x17000F91 RID: 3985
	// (get) Token: 0x06008E57 RID: 36439
	// (set) Token: 0x06008E58 RID: 36440
	string Text { get; set; }

	// Token: 0x17000F92 RID: 3986
	// (get) Token: 0x06008E59 RID: 36441
	// (set) Token: 0x06008E5A RID: 36442
	int SortIndex { get; set; }

	// Token: 0x17000F93 RID: 3987
	// (get) Token: 0x06008E5B RID: 36443
	// (set) Token: 0x06008E5C RID: 36444
	Action Function { get; set; }
}
