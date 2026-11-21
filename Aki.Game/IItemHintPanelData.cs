using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020014D2 RID: 5330
[NullableContext(2)]
public interface IItemHintPanelData<[Nullable(0)] T, TData> where T : ItemHintItemBase<TData>
{
	// Token: 0x1700139D RID: 5021
	// (get) Token: 0x0600D54B RID: 54603
	// (set) Token: 0x0600D54C RID: 54604
	[Nullable(1)]
	Func<TData> ShiftItem { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700139E RID: 5022
	// (get) Token: 0x0600D54D RID: 54605
	// (set) Token: 0x0600D54E RID: 54606
	[Nullable(1)]
	Func<bool> CheckNext { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700139F RID: 5023
	// (get) Token: 0x0600D54F RID: 54607
	// (set) Token: 0x0600D550 RID: 54608
	[Nullable(1)]
	Func<T> CreateProxyFunction { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170013A0 RID: 5024
	// (get) Token: 0x0600D551 RID: 54609
	// (set) Token: 0x0600D552 RID: 54610
	UUIItem ChildTemplate { get; set; }

	// Token: 0x170013A1 RID: 5025
	// (get) Token: 0x0600D553 RID: 54611
	// (set) Token: 0x0600D554 RID: 54612
	string ChildResourceId { get; set; }

	// Token: 0x170013A2 RID: 5026
	// (get) Token: 0x0600D555 RID: 54613
	// (set) Token: 0x0600D556 RID: 54614
	string TitleTextId { get; set; }

	// Token: 0x170013A3 RID: 5027
	// (get) Token: 0x0600D557 RID: 54615
	// (set) Token: 0x0600D558 RID: 54616
	int? MaxShowCount { get; set; }

	// Token: 0x170013A4 RID: 5028
	// (get) Token: 0x0600D559 RID: 54617
	// (set) Token: 0x0600D55A RID: 54618
	int? AddItemTime { get; set; }

	// Token: 0x170013A5 RID: 5029
	// (get) Token: 0x0600D55B RID: 54619
	// (set) Token: 0x0600D55C RID: 54620
	int? ItemSliderTime { get; set; }

	// Token: 0x170013A6 RID: 5030
	// (get) Token: 0x0600D55D RID: 54621
	// (set) Token: 0x0600D55E RID: 54622
	int? ItemShowTime { get; set; }

	// Token: 0x170013A7 RID: 5031
	// (get) Token: 0x0600D55F RID: 54623
	// (set) Token: 0x0600D560 RID: 54624
	ESliderMode? SliderMode { get; set; }

	// Token: 0x170013A8 RID: 5032
	// (get) Token: 0x0600D561 RID: 54625
	// (set) Token: 0x0600D562 RID: 54626
	ETickItemMode? TickMode { get; set; }

	// Token: 0x170013A9 RID: 5033
	// (get) Token: 0x0600D563 RID: 54627
	// (set) Token: 0x0600D564 RID: 54628
	Action FinishCallback { get; set; }
}
