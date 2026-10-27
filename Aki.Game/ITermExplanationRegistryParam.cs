using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002BA4 RID: 11172
[NullableContext(2)]
public interface ITermExplanationRegistryParam
{
	// Token: 0x17001F32 RID: 7986
	// (get) Token: 0x06017241 RID: 94785
	// (set) Token: 0x06017242 RID: 94786
	[Nullable(1)]
	UUIText UiText { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17001F33 RID: 7987
	// (get) Token: 0x06017243 RID: 94787
	// (set) Token: 0x06017244 RID: 94788
	ETermExplanationViewType ViewType { get; set; }

	// Token: 0x17001F34 RID: 7988
	// (get) Token: 0x06017245 RID: 94789
	// (set) Token: 0x06017246 RID: 94790
	ETermExplanationReportType ReportType { get; set; }

	// Token: 0x17001F35 RID: 7989
	// (get) Token: 0x06017247 RID: 94791
	// (set) Token: 0x06017248 RID: 94792
	ETermExplanationViewAttachDirection? AttachDirection { get; set; }

	// Token: 0x17001F36 RID: 7990
	// (get) Token: 0x06017249 RID: 94793
	// (set) Token: 0x0601724A RID: 94794
	UUIItem AttachItem { get; set; }

	// Token: 0x17001F37 RID: 7991
	// (get) Token: 0x0601724B RID: 94795
	// (set) Token: 0x0601724C RID: 94796
	Action OnDisableClick { get; set; }

	// Token: 0x17001F38 RID: 7992
	// (get) Token: 0x0601724D RID: 94797
	// (set) Token: 0x0601724E RID: 94798
	[Nullable(0)]
	ValueTuple<float, float>? CustomOffset { [NullableContext(0)] get; [NullableContext(0)] set; }

	// Token: 0x17001F39 RID: 7993
	// (get) Token: 0x0601724F RID: 94799
	// (set) Token: 0x06017250 RID: 94800
	ETermExplanationGroup? Group { get; set; }

	// Token: 0x17001F3A RID: 7994
	// (get) Token: 0x06017251 RID: 94801
	// (set) Token: 0x06017252 RID: 94802
	int? Priority { get; set; }

	// Token: 0x17001F3B RID: 7995
	// (get) Token: 0x06017253 RID: 94803
	// (set) Token: 0x06017254 RID: 94804
	ETermExplanationViewStyle? Style { get; set; }
}
