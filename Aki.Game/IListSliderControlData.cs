using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020014E0 RID: 5344
[NullableContext(1)]
public interface IListSliderControlData<[Nullable(0)] T> where T : SliderItem
{
	// Token: 0x170013B9 RID: 5049
	// (get) Token: 0x0600D5C5 RID: 54725
	UUIItem ParentUi { get; }

	// Token: 0x170013BA RID: 5050
	// (get) Token: 0x0600D5C6 RID: 54726
	Func<T> CreateProxyFunction { get; }

	// Token: 0x170013BB RID: 5051
	// (get) Token: 0x0600D5C7 RID: 54727
	Func<bool> CheckNext { get; }

	// Token: 0x170013BC RID: 5052
	// (get) Token: 0x0600D5C8 RID: 54728
	[Nullable(2)]
	UUIItem ChildTemplate { [NullableContext(2)] get; }

	// Token: 0x170013BD RID: 5053
	// (get) Token: 0x0600D5C9 RID: 54729
	[Nullable(2)]
	string ChildResourceId { [NullableContext(2)] get; }

	// Token: 0x170013BE RID: 5054
	// (get) Token: 0x0600D5CA RID: 54730
	int? MaxShowCount { get; }

	// Token: 0x170013BF RID: 5055
	// (get) Token: 0x0600D5CB RID: 54731
	float? AddItemTime { get; }

	// Token: 0x170013C0 RID: 5056
	// (get) Token: 0x0600D5CC RID: 54732
	float? ItemSliderTime { get; }

	// Token: 0x170013C1 RID: 5057
	// (get) Token: 0x0600D5CD RID: 54733
	float? ItemShowTime { get; }

	// Token: 0x170013C2 RID: 5058
	// (get) Token: 0x0600D5CE RID: 54734
	ESliderMode? SliderMode { get; }

	// Token: 0x170013C3 RID: 5059
	// (get) Token: 0x0600D5CF RID: 54735
	ETickItemMode? TickMode { get; }

	// Token: 0x170013C4 RID: 5060
	// (get) Token: 0x0600D5D0 RID: 54736
	[Nullable(2)]
	Action FinishCallback { [NullableContext(2)] get; }
}
