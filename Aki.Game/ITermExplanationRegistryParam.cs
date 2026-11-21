using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002120 RID: 8480
[NullableContext(2)]
public interface ITermExplanationRegistryParam
{
	// Token: 0x17001F8A RID: 8074
	// (get) Token: 0x06014C72 RID: 85106
	// (set) Token: 0x06014C73 RID: 85107
	[Nullable(1)]
	UUIText UiText { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001F8B RID: 8075
	// (get) Token: 0x06014C74 RID: 85108
	// (set) Token: 0x06014C75 RID: 85109
	ETermExplanationViewType ViewType { get; set; }

	// Token: 0x17001F8C RID: 8076
	// (get) Token: 0x06014C76 RID: 85110
	// (set) Token: 0x06014C77 RID: 85111
	ETermExplanationReportType ReportType { get; set; }

	// Token: 0x17001F8D RID: 8077
	// (get) Token: 0x06014C78 RID: 85112
	// (set) Token: 0x06014C79 RID: 85113
	ETermExplanationViewAttachDirection? AttachDirection { get; set; }

	// Token: 0x17001F8E RID: 8078
	// (get) Token: 0x06014C7A RID: 85114
	// (set) Token: 0x06014C7B RID: 85115
	UUIItem AttachItem { get; set; }

	// Token: 0x17001F8F RID: 8079
	// (get) Token: 0x06014C7C RID: 85116
	// (set) Token: 0x06014C7D RID: 85117
	Action OnDisableClick { get; set; }

	// Token: 0x17001F90 RID: 8080
	// (get) Token: 0x06014C7E RID: 85118
	// (set) Token: 0x06014C7F RID: 85119
	[Nullable(0)]
	ValueTuple<float, float>? CustomOffset { [NullableContext(0)] get; [NullableContext(0)] set; }

	// Token: 0x17001F91 RID: 8081
	// (get) Token: 0x06014C80 RID: 85120
	// (set) Token: 0x06014C81 RID: 85121
	ETermExplanationGroup? Group { get; set; }

	// Token: 0x17001F92 RID: 8082
	// (get) Token: 0x06014C82 RID: 85122
	// (set) Token: 0x06014C83 RID: 85123
	int? Priority { get; set; }

	// Token: 0x17001F93 RID: 8083
	// (get) Token: 0x06014C84 RID: 85124
	// (set) Token: 0x06014C85 RID: 85125
	ETermExplanationViewStyle? Style { get; set; }
}
