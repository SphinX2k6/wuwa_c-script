using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002BA5 RID: 11173
[NullableContext(2)]
[Nullable(0)]
public class TermExplanationRegistryParam : ITermExplanationRegistryParam
{
	// Token: 0x17001F3C RID: 7996
	// (get) Token: 0x06017255 RID: 94805 RVA: 0x005DE354 File Offset: 0x005DC554
	// (set) Token: 0x06017256 RID: 94806 RVA: 0x005DE35C File Offset: 0x005DC55C
	[Nullable(1)]
	public UUIText UiText { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001F3D RID: 7997
	// (get) Token: 0x06017257 RID: 94807 RVA: 0x005DE365 File Offset: 0x005DC565
	// (set) Token: 0x06017258 RID: 94808 RVA: 0x005DE36D File Offset: 0x005DC56D
	public ETermExplanationViewType ViewType { get; set; }

	// Token: 0x17001F3E RID: 7998
	// (get) Token: 0x06017259 RID: 94809 RVA: 0x005DE376 File Offset: 0x005DC576
	// (set) Token: 0x0601725A RID: 94810 RVA: 0x005DE37E File Offset: 0x005DC57E
	public ETermExplanationReportType ReportType { get; set; }

	// Token: 0x17001F3F RID: 7999
	// (get) Token: 0x0601725B RID: 94811 RVA: 0x005DE387 File Offset: 0x005DC587
	// (set) Token: 0x0601725C RID: 94812 RVA: 0x005DE38F File Offset: 0x005DC58F
	public ETermExplanationViewAttachDirection? AttachDirection { get; set; }

	// Token: 0x17001F40 RID: 8000
	// (get) Token: 0x0601725D RID: 94813 RVA: 0x005DE398 File Offset: 0x005DC598
	// (set) Token: 0x0601725E RID: 94814 RVA: 0x005DE3A0 File Offset: 0x005DC5A0
	public UUIItem AttachItem { get; set; }

	// Token: 0x17001F41 RID: 8001
	// (get) Token: 0x0601725F RID: 94815 RVA: 0x005DE3A9 File Offset: 0x005DC5A9
	// (set) Token: 0x06017260 RID: 94816 RVA: 0x005DE3B1 File Offset: 0x005DC5B1
	public Action OnDisableClick { get; set; }

	// Token: 0x17001F42 RID: 8002
	// (get) Token: 0x06017261 RID: 94817 RVA: 0x005DE3BA File Offset: 0x005DC5BA
	// (set) Token: 0x06017262 RID: 94818 RVA: 0x005DE3C2 File Offset: 0x005DC5C2
	[Nullable(0)]
	public ValueTuple<float, float>? CustomOffset { [NullableContext(0)] get; [NullableContext(0)] set; }

	// Token: 0x17001F43 RID: 8003
	// (get) Token: 0x06017263 RID: 94819 RVA: 0x005DE3CB File Offset: 0x005DC5CB
	// (set) Token: 0x06017264 RID: 94820 RVA: 0x005DE3D3 File Offset: 0x005DC5D3
	public ETermExplanationGroup? Group { get; set; }

	// Token: 0x17001F44 RID: 8004
	// (get) Token: 0x06017265 RID: 94821 RVA: 0x005DE3DC File Offset: 0x005DC5DC
	// (set) Token: 0x06017266 RID: 94822 RVA: 0x005DE3E4 File Offset: 0x005DC5E4
	public int? Priority { get; set; }

	// Token: 0x17001F45 RID: 8005
	// (get) Token: 0x06017267 RID: 94823 RVA: 0x005DE3ED File Offset: 0x005DC5ED
	// (set) Token: 0x06017268 RID: 94824 RVA: 0x005DE3F5 File Offset: 0x005DC5F5
	public ETermExplanationViewStyle? Style { get; set; }
}
