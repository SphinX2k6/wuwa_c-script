using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002121 RID: 8481
[NullableContext(2)]
[Nullable(0)]
public class TermExplanationRegistryParam : ITermExplanationRegistryParam
{
	// Token: 0x17001F94 RID: 8084
	// (get) Token: 0x06014C86 RID: 85126 RVA: 0x0060AF28 File Offset: 0x00609128
	// (set) Token: 0x06014C87 RID: 85127 RVA: 0x0060AF30 File Offset: 0x00609130
	[Nullable(1)]
	public UUIText UiText { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001F95 RID: 8085
	// (get) Token: 0x06014C88 RID: 85128 RVA: 0x0060AF39 File Offset: 0x00609139
	// (set) Token: 0x06014C89 RID: 85129 RVA: 0x0060AF41 File Offset: 0x00609141
	public ETermExplanationViewType ViewType { get; set; }

	// Token: 0x17001F96 RID: 8086
	// (get) Token: 0x06014C8A RID: 85130 RVA: 0x0060AF4A File Offset: 0x0060914A
	// (set) Token: 0x06014C8B RID: 85131 RVA: 0x0060AF52 File Offset: 0x00609152
	public ETermExplanationReportType ReportType { get; set; }

	// Token: 0x17001F97 RID: 8087
	// (get) Token: 0x06014C8C RID: 85132 RVA: 0x0060AF5B File Offset: 0x0060915B
	// (set) Token: 0x06014C8D RID: 85133 RVA: 0x0060AF63 File Offset: 0x00609163
	public ETermExplanationViewAttachDirection? AttachDirection { get; set; }

	// Token: 0x17001F98 RID: 8088
	// (get) Token: 0x06014C8E RID: 85134 RVA: 0x0060AF6C File Offset: 0x0060916C
	// (set) Token: 0x06014C8F RID: 85135 RVA: 0x0060AF74 File Offset: 0x00609174
	public UUIItem AttachItem { get; set; }

	// Token: 0x17001F99 RID: 8089
	// (get) Token: 0x06014C90 RID: 85136 RVA: 0x0060AF7D File Offset: 0x0060917D
	// (set) Token: 0x06014C91 RID: 85137 RVA: 0x0060AF85 File Offset: 0x00609185
	public Action OnDisableClick { get; set; }

	// Token: 0x17001F9A RID: 8090
	// (get) Token: 0x06014C92 RID: 85138 RVA: 0x0060AF8E File Offset: 0x0060918E
	// (set) Token: 0x06014C93 RID: 85139 RVA: 0x0060AF96 File Offset: 0x00609196
	[Nullable(0)]
	public ValueTuple<float, float>? CustomOffset { [NullableContext(0)] get; [NullableContext(0)] set; }

	// Token: 0x17001F9B RID: 8091
	// (get) Token: 0x06014C94 RID: 85140 RVA: 0x0060AF9F File Offset: 0x0060919F
	// (set) Token: 0x06014C95 RID: 85141 RVA: 0x0060AFA7 File Offset: 0x006091A7
	public ETermExplanationGroup? Group { get; set; }

	// Token: 0x17001F9C RID: 8092
	// (get) Token: 0x06014C96 RID: 85142 RVA: 0x0060AFB0 File Offset: 0x006091B0
	// (set) Token: 0x06014C97 RID: 85143 RVA: 0x0060AFB8 File Offset: 0x006091B8
	public int? Priority { get; set; }

	// Token: 0x17001F9D RID: 8093
	// (get) Token: 0x06014C98 RID: 85144 RVA: 0x0060AFC1 File Offset: 0x006091C1
	// (set) Token: 0x06014C99 RID: 85145 RVA: 0x0060AFC9 File Offset: 0x006091C9
	public ETermExplanationViewStyle? Style { get; set; }
}
