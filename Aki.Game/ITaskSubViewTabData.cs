using System;
using System.Runtime.CompilerServices;

// Token: 0x0200095C RID: 2396
[NullableContext(1)]
[Nullable(0)]
public struct ITaskSubViewTabData
{
	// Token: 0x17000D1C RID: 3356
	// (get) Token: 0x06006950 RID: 26960 RVA: 0x0020DB07 File Offset: 0x0020BD07
	// (set) Token: 0x06006951 RID: 26961 RVA: 0x0020DB0F File Offset: 0x0020BD0F
	public string TitleKey { readonly get; set; }

	// Token: 0x17000D1D RID: 3357
	// (get) Token: 0x06006952 RID: 26962 RVA: 0x0020DB18 File Offset: 0x0020BD18
	// (set) Token: 0x06006953 RID: 26963 RVA: 0x0020DB20 File Offset: 0x0020BD20
	public string IconName { readonly get; set; }

	// Token: 0x17000D1E RID: 3358
	// (get) Token: 0x06006954 RID: 26964 RVA: 0x0020DB29 File Offset: 0x0020BD29
	// (set) Token: 0x06006955 RID: 26965 RVA: 0x0020DB31 File Offset: 0x0020BD31
	public EActivityRegressTaskSubViewType Type { readonly get; set; }

	// Token: 0x17000D1F RID: 3359
	// (get) Token: 0x06006956 RID: 26966 RVA: 0x0020DB3A File Offset: 0x0020BD3A
	// (set) Token: 0x06006957 RID: 26967 RVA: 0x0020DB42 File Offset: 0x0020BD42
	public ERedDotName? RedDotName { readonly get; set; }
}
