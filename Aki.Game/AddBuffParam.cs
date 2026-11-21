using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020023D3 RID: 9171
[NullableContext(1)]
[Nullable(0)]
public class AddBuffParam
{
	// Token: 0x1700239B RID: 9115
	// (get) Token: 0x0601703B RID: 94267 RVA: 0x006BA3FF File Offset: 0x006B85FF
	// (set) Token: 0x0601703C RID: 94268 RVA: 0x006BA407 File Offset: 0x006B8607
	public long InstigatorId { get; set; }

	// Token: 0x1700239C RID: 9116
	// (get) Token: 0x0601703D RID: 94269 RVA: 0x006BA410 File Offset: 0x006B8610
	// (set) Token: 0x0601703E RID: 94270 RVA: 0x006BA418 File Offset: 0x006B8618
	public int? Level { get; set; }

	// Token: 0x1700239D RID: 9117
	// (get) Token: 0x0601703F RID: 94271 RVA: 0x006BA421 File Offset: 0x006B8621
	// (set) Token: 0x06017040 RID: 94272 RVA: 0x006BA429 File Offset: 0x006B8629
	public int? OuterStackCount { get; set; }

	// Token: 0x1700239E RID: 9118
	// (get) Token: 0x06017041 RID: 94273 RVA: 0x006BA432 File Offset: 0x006B8632
	// (set) Token: 0x06017042 RID: 94274 RVA: 0x006BA43A File Offset: 0x006B863A
	public ApplyGEType? ApplyType { get; set; }

	// Token: 0x1700239F RID: 9119
	// (get) Token: 0x06017043 RID: 94275 RVA: 0x006BA443 File Offset: 0x006B8643
	// (set) Token: 0x06017044 RID: 94276 RVA: 0x006BA44B File Offset: 0x006B864B
	public long? PreMessageId { get; set; }

	// Token: 0x170023A0 RID: 9120
	// (get) Token: 0x06017045 RID: 94277 RVA: 0x006BA454 File Offset: 0x006B8654
	// (set) Token: 0x06017046 RID: 94278 RVA: 0x006BA45C File Offset: 0x006B865C
	public long? MessageId { get; set; }

	// Token: 0x170023A1 RID: 9121
	// (get) Token: 0x06017047 RID: 94279 RVA: 0x006BA465 File Offset: 0x006B8665
	// (set) Token: 0x06017048 RID: 94280 RVA: 0x006BA46D File Offset: 0x006B866D
	public float? Duration { get; set; }

	// Token: 0x170023A2 RID: 9122
	// (get) Token: 0x06017049 RID: 94281 RVA: 0x006BA476 File Offset: 0x006B8676
	// (set) Token: 0x0601704A RID: 94282 RVA: 0x006BA47E File Offset: 0x006B867E
	public int? ServerId { get; set; }

	// Token: 0x170023A3 RID: 9123
	// (get) Token: 0x0601704B RID: 94283 RVA: 0x006BA487 File Offset: 0x006B8687
	// (set) Token: 0x0601704C RID: 94284 RVA: 0x006BA48F File Offset: 0x006B868F
	public bool? IsIterable { get; set; }

	// Token: 0x170023A4 RID: 9124
	// (get) Token: 0x0601704D RID: 94285 RVA: 0x006BA498 File Offset: 0x006B8698
	// (set) Token: 0x0601704E RID: 94286 RVA: 0x006BA4A0 File Offset: 0x006B86A0
	public bool? IsServerOrder { get; set; }

	// Token: 0x170023A5 RID: 9125
	// (get) Token: 0x0601704F RID: 94287 RVA: 0x006BA4A9 File Offset: 0x006B86A9
	// (set) Token: 0x06017050 RID: 94288 RVA: 0x006BA4B1 File Offset: 0x006B86B1
	public string Reason { get; set; } = string.Empty;

	// Token: 0x170023A6 RID: 9126
	// (get) Token: 0x06017051 RID: 94289 RVA: 0x006BA4BA File Offset: 0x006B86BA
	// (set) Token: 0x06017052 RID: 94290 RVA: 0x006BA4C2 File Offset: 0x006B86C2
	public long? BulletMessageId { get; set; }

	// Token: 0x170023A7 RID: 9127
	// (get) Token: 0x06017053 RID: 94291 RVA: 0x006BA4CB File Offset: 0x006B86CB
	// (set) Token: 0x06017054 RID: 94292 RVA: 0x006BA4D3 File Offset: 0x006B86D3
	public bool? BornBuff { get; set; }

	// Token: 0x170023A8 RID: 9128
	// (get) Token: 0x06017055 RID: 94293 RVA: 0x006BA4DC File Offset: 0x006B86DC
	// (set) Token: 0x06017056 RID: 94294 RVA: 0x006BA4E4 File Offset: 0x006B86E4
	public float? RemainDuration { get; set; }

	// Token: 0x170023A9 RID: 9129
	// (get) Token: 0x06017057 RID: 94295 RVA: 0x006BA4ED File Offset: 0x006B86ED
	// (set) Token: 0x06017058 RID: 94296 RVA: 0x006BA4F5 File Offset: 0x006B86F5
	public bool? IsActive { get; set; }
}
