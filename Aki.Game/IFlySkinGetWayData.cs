using System;
using System.Runtime.CompilerServices;

// Token: 0x02001FC5 RID: 8133
[NullableContext(1)]
public interface IFlySkinGetWayData
{
	// Token: 0x17001E3E RID: 7742
	// (get) Token: 0x060142F9 RID: 82681
	// (set) Token: 0x060142FA RID: 82682
	int Id { get; set; }

	// Token: 0x17001E3F RID: 7743
	// (get) Token: 0x060142FB RID: 82683
	// (set) Token: 0x060142FC RID: 82684
	int ConfigId { get; set; }

	// Token: 0x17001E40 RID: 7744
	// (get) Token: 0x060142FD RID: 82685
	// (set) Token: 0x060142FE RID: 82686
	EFlySkinGetWayType Type { get; set; }

	// Token: 0x17001E41 RID: 7745
	// (get) Token: 0x060142FF RID: 82687
	// (set) Token: 0x06014300 RID: 82688
	string Text { get; set; }

	// Token: 0x17001E42 RID: 7746
	// (get) Token: 0x06014301 RID: 82689
	// (set) Token: 0x06014302 RID: 82690
	int SortIndex { get; set; }
}
