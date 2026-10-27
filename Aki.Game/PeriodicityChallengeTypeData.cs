using System;
using System.Runtime.CompilerServices;

// Token: 0x020016B6 RID: 5814
[NullableContext(1)]
[Nullable(0)]
public class PeriodicityChallengeTypeData : IPeriodicityChallengeTypeData
{
	// Token: 0x17000DE4 RID: 3556
	// (get) Token: 0x0600A5D0 RID: 42448 RVA: 0x00250F10 File Offset: 0x0024F110
	// (set) Token: 0x0600A5D1 RID: 42449 RVA: 0x00250F18 File Offset: 0x0024F118
	public float LeftTime { get; set; }

	// Token: 0x17000DE5 RID: 3557
	// (get) Token: 0x0600A5D2 RID: 42450 RVA: 0x00250F21 File Offset: 0x0024F121
	// (set) Token: 0x0600A5D3 RID: 42451 RVA: 0x00250F29 File Offset: 0x0024F129
	public int CurrentNum { get; set; }

	// Token: 0x17000DE6 RID: 3558
	// (get) Token: 0x0600A5D4 RID: 42452 RVA: 0x00250F32 File Offset: 0x0024F132
	// (set) Token: 0x0600A5D5 RID: 42453 RVA: 0x00250F3A File Offset: 0x0024F13A
	public int TotalNum { get; set; }

	// Token: 0x17000DE7 RID: 3559
	// (get) Token: 0x0600A5D6 RID: 42454 RVA: 0x00250F43 File Offset: 0x0024F143
	// (set) Token: 0x0600A5D7 RID: 42455 RVA: 0x00250F4B File Offset: 0x0024F14B
	public bool IsFinish { get; set; }

	// Token: 0x17000DE8 RID: 3560
	// (get) Token: 0x0600A5D8 RID: 42456 RVA: 0x00250F54 File Offset: 0x0024F154
	// (set) Token: 0x0600A5D9 RID: 42457 RVA: 0x00250F5C File Offset: 0x0024F15C
	public bool RedPoint { get; set; }

	// Token: 0x17000DE9 RID: 3561
	// (get) Token: 0x0600A5DA RID: 42458 RVA: 0x00250F65 File Offset: 0x0024F165
	// (set) Token: 0x0600A5DB RID: 42459 RVA: 0x00250F6D File Offset: 0x0024F16D
	public string SubText { get; set; }
}
