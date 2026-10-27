using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001FFF RID: 8191
[NullableContext(2)]
public interface IItemHintPanelData<[Nullable(0)] T, TData> where T : ItemHintItemBase<TData>
{
	// Token: 0x17001370 RID: 4976
	// (get) Token: 0x060100E3 RID: 65763
	// (set) Token: 0x060100E4 RID: 65764
	[Nullable(1)]
	Func<TData> ShiftItem { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001371 RID: 4977
	// (get) Token: 0x060100E5 RID: 65765
	// (set) Token: 0x060100E6 RID: 65766
	[Nullable(1)]
	Func<bool> CheckNext { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001372 RID: 4978
	// (get) Token: 0x060100E7 RID: 65767
	// (set) Token: 0x060100E8 RID: 65768
	[Nullable(1)]
	Func<T> CreateProxyFunction { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001373 RID: 4979
	// (get) Token: 0x060100E9 RID: 65769
	// (set) Token: 0x060100EA RID: 65770
	UUIItem ChildTemplate { get; set; }

	// Token: 0x17001374 RID: 4980
	// (get) Token: 0x060100EB RID: 65771
	// (set) Token: 0x060100EC RID: 65772
	string ChildResourceId { get; set; }

	// Token: 0x17001375 RID: 4981
	// (get) Token: 0x060100ED RID: 65773
	// (set) Token: 0x060100EE RID: 65774
	string TitleTextId { get; set; }

	// Token: 0x17001376 RID: 4982
	// (get) Token: 0x060100EF RID: 65775
	// (set) Token: 0x060100F0 RID: 65776
	int? MaxShowCount { get; set; }

	// Token: 0x17001377 RID: 4983
	// (get) Token: 0x060100F1 RID: 65777
	// (set) Token: 0x060100F2 RID: 65778
	int? AddItemTime { get; set; }

	// Token: 0x17001378 RID: 4984
	// (get) Token: 0x060100F3 RID: 65779
	// (set) Token: 0x060100F4 RID: 65780
	int? ItemSliderTime { get; set; }

	// Token: 0x17001379 RID: 4985
	// (get) Token: 0x060100F5 RID: 65781
	// (set) Token: 0x060100F6 RID: 65782
	int? ItemShowTime { get; set; }

	// Token: 0x1700137A RID: 4986
	// (get) Token: 0x060100F7 RID: 65783
	// (set) Token: 0x060100F8 RID: 65784
	ESliderMode? SliderMode { get; set; }

	// Token: 0x1700137B RID: 4987
	// (get) Token: 0x060100F9 RID: 65785
	// (set) Token: 0x060100FA RID: 65786
	ETickItemMode? TickMode { get; set; }

	// Token: 0x1700137C RID: 4988
	// (get) Token: 0x060100FB RID: 65787
	// (set) Token: 0x060100FC RID: 65788
	Action FinishCallback { get; set; }
}
