using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;

// Token: 0x020016D1 RID: 5841
[NullableContext(1)]
[Nullable(0)]
public class MarkPoolHandle : IMarkPoolHandle
{
	// Token: 0x170015A8 RID: 5544
	// (get) Token: 0x0600E2FC RID: 58108 RVA: 0x00429700 File Offset: 0x00427900
	// (set) Token: 0x0600E2FD RID: 58109 RVA: 0x00429708 File Offset: 0x00427908
	public double RecycleTimeStamp { get; set; }

	// Token: 0x170015A9 RID: 5545
	// (get) Token: 0x0600E2FE RID: 58110 RVA: 0x00429711 File Offset: 0x00427911
	// (set) Token: 0x0600E2FF RID: 58111 RVA: 0x00429719 File Offset: 0x00427919
	public MarkPanelBase Obj { get; set; }

	// Token: 0x170015AA RID: 5546
	// (get) Token: 0x0600E300 RID: 58112 RVA: 0x00429722 File Offset: 0x00427922
	// (set) Token: 0x0600E301 RID: 58113 RVA: 0x0042972A File Offset: 0x0042792A
	public int? RefCount { get; set; }
}
