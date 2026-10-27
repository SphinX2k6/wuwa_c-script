using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002C72 RID: 11378
[NullableContext(1)]
[Nullable(0)]
public class UiModelDecorationParam : IUiModelDecorationParam
{
	// Token: 0x17001FE8 RID: 8168
	// (get) Token: 0x06017C3E RID: 97342 RVA: 0x0060B953 File Offset: 0x00609B53
	// (set) Token: 0x06017C3F RID: 97343 RVA: 0x0060B95B File Offset: 0x00609B5B
	public string SocketName { get; set; }

	// Token: 0x17001FE9 RID: 8169
	// (get) Token: 0x06017C40 RID: 97344 RVA: 0x0060B964 File Offset: 0x00609B64
	// (set) Token: 0x06017C41 RID: 97345 RVA: 0x0060B96C File Offset: 0x00609B6C
	public USkeletalMesh SkeletalMesh { get; set; }

	// Token: 0x17001FEA RID: 8170
	// (get) Token: 0x06017C42 RID: 97346 RVA: 0x0060B975 File Offset: 0x00609B75
	// (set) Token: 0x06017C43 RID: 97347 RVA: 0x0060B97D File Offset: 0x00609B7D
	public FTransform Transform { get; set; }
}
