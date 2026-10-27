using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;

// Token: 0x020021E9 RID: 8681
[NullableContext(1)]
public interface IMarkPoolHandle
{
	// Token: 0x1700156E RID: 5486
	// (get) Token: 0x06010E52 RID: 69202
	// (set) Token: 0x06010E53 RID: 69203
	double RecycleTimeStamp { get; set; }

	// Token: 0x1700156F RID: 5487
	// (get) Token: 0x06010E54 RID: 69204
	// (set) Token: 0x06010E55 RID: 69205
	MarkPanelBase Obj { get; set; }

	// Token: 0x17001570 RID: 5488
	// (get) Token: 0x06010E56 RID: 69206
	// (set) Token: 0x06010E57 RID: 69207
	int? RefCount { get; set; }
}
