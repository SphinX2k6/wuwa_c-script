using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020025DA RID: 9690
[NullableContext(1)]
[Nullable(0)]
public class PhotoPositionData : IPositionData
{
	// Token: 0x17001941 RID: 6465
	// (get) Token: 0x06013AF4 RID: 80628 RVA: 0x004EDD84 File Offset: 0x004EBF84
	// (set) Token: 0x06013AF5 RID: 80629 RVA: 0x004EDD8C File Offset: 0x004EBF8C
	public string Id { get; set; } = "";

	// Token: 0x17001942 RID: 6466
	// (get) Token: 0x06013AF6 RID: 80630 RVA: 0x004EDD95 File Offset: 0x004EBF95
	// (set) Token: 0x06013AF7 RID: 80631 RVA: 0x004EDD9D File Offset: 0x004EBF9D
	public FVector2D Vector { get; set; } = new FVector2D(0f, 0f);

	// Token: 0x17001943 RID: 6467
	// (get) Token: 0x06013AF8 RID: 80632 RVA: 0x004EDDA6 File Offset: 0x004EBFA6
	// (set) Token: 0x06013AF9 RID: 80633 RVA: 0x004EDDAE File Offset: 0x004EBFAE
	public bool NotShow { get; set; }

	// Token: 0x17001944 RID: 6468
	// (get) Token: 0x06013AFA RID: 80634 RVA: 0x004EDDB7 File Offset: 0x004EBFB7
	// (set) Token: 0x06013AFB RID: 80635 RVA: 0x004EDDBF File Offset: 0x004EBFBF
	public bool IsOptional { get; set; }

	// Token: 0x17001945 RID: 6469
	// (get) Token: 0x06013AFC RID: 80636 RVA: 0x004EDDC8 File Offset: 0x004EBFC8
	// (set) Token: 0x06013AFD RID: 80637 RVA: 0x004EDDD0 File Offset: 0x004EBFD0
	public bool IsOptionalFinished { get; set; }
}
