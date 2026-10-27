using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200200D RID: 8205
[NullableContext(1)]
public interface IListSliderControlData<[Nullable(0)] T> where T : SliderItem
{
	// Token: 0x1700138C RID: 5004
	// (get) Token: 0x0601015D RID: 65885
	UUIItem ParentUi { get; }

	// Token: 0x1700138D RID: 5005
	// (get) Token: 0x0601015E RID: 65886
	Func<T> CreateProxyFunction { get; }

	// Token: 0x1700138E RID: 5006
	// (get) Token: 0x0601015F RID: 65887
	Func<bool> CheckNext { get; }

	// Token: 0x1700138F RID: 5007
	// (get) Token: 0x06010160 RID: 65888
	[Nullable(2)]
	UUIItem ChildTemplate { [NullableContext(2)] get; }

	// Token: 0x17001390 RID: 5008
	// (get) Token: 0x06010161 RID: 65889
	[Nullable(2)]
	string ChildResourceId { [NullableContext(2)] get; }

	// Token: 0x17001391 RID: 5009
	// (get) Token: 0x06010162 RID: 65890
	int? MaxShowCount { get; }

	// Token: 0x17001392 RID: 5010
	// (get) Token: 0x06010163 RID: 65891
	float? AddItemTime { get; }

	// Token: 0x17001393 RID: 5011
	// (get) Token: 0x06010164 RID: 65892
	float? ItemSliderTime { get; }

	// Token: 0x17001394 RID: 5012
	// (get) Token: 0x06010165 RID: 65893
	float? ItemShowTime { get; }

	// Token: 0x17001395 RID: 5013
	// (get) Token: 0x06010166 RID: 65894
	ESliderMode? SliderMode { get; }

	// Token: 0x17001396 RID: 5014
	// (get) Token: 0x06010167 RID: 65895
	ETickItemMode? TickMode { get; }

	// Token: 0x17001397 RID: 5015
	// (get) Token: 0x06010168 RID: 65896
	[Nullable(2)]
	Action FinishCallback { [NullableContext(2)] get; }
}
