using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;

// Token: 0x020016CD RID: 5837
[NullableContext(1)]
public interface IMarkPoolHandle
{
	// Token: 0x170015A5 RID: 5541
	// (get) Token: 0x0600E2E3 RID: 58083
	// (set) Token: 0x0600E2E4 RID: 58084
	double RecycleTimeStamp { get; set; }

	// Token: 0x170015A6 RID: 5542
	// (get) Token: 0x0600E2E5 RID: 58085
	// (set) Token: 0x0600E2E6 RID: 58086
	MarkPanelBase Obj { get; set; }

	// Token: 0x170015A7 RID: 5543
	// (get) Token: 0x0600E2E7 RID: 58087
	// (set) Token: 0x0600E2E8 RID: 58088
	int? RefCount { get; set; }
}
