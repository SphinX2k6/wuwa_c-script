using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002E81 RID: 11905
[NullableContext(1)]
[Nullable(0)]
public class AddBuffParam
{
	// Token: 0x17002310 RID: 8976
	// (get) Token: 0x06019765 RID: 104293 RVA: 0x00694043 File Offset: 0x00692243
	// (set) Token: 0x06019766 RID: 104294 RVA: 0x0069404B File Offset: 0x0069224B
	public long InstigatorId { get; set; }

	// Token: 0x17002311 RID: 8977
	// (get) Token: 0x06019767 RID: 104295 RVA: 0x00694054 File Offset: 0x00692254
	// (set) Token: 0x06019768 RID: 104296 RVA: 0x0069405C File Offset: 0x0069225C
	public int? Level { get; set; }

	// Token: 0x17002312 RID: 8978
	// (get) Token: 0x06019769 RID: 104297 RVA: 0x00694065 File Offset: 0x00692265
	// (set) Token: 0x0601976A RID: 104298 RVA: 0x0069406D File Offset: 0x0069226D
	public int? OuterStackCount { get; set; }

	// Token: 0x17002313 RID: 8979
	// (get) Token: 0x0601976B RID: 104299 RVA: 0x00694076 File Offset: 0x00692276
	// (set) Token: 0x0601976C RID: 104300 RVA: 0x0069407E File Offset: 0x0069227E
	public ApplyGEType? ApplyType { get; set; }

	// Token: 0x17002314 RID: 8980
	// (get) Token: 0x0601976D RID: 104301 RVA: 0x00694087 File Offset: 0x00692287
	// (set) Token: 0x0601976E RID: 104302 RVA: 0x0069408F File Offset: 0x0069228F
	public long? PreMessageId { get; set; }

	// Token: 0x17002315 RID: 8981
	// (get) Token: 0x0601976F RID: 104303 RVA: 0x00694098 File Offset: 0x00692298
	// (set) Token: 0x06019770 RID: 104304 RVA: 0x006940A0 File Offset: 0x006922A0
	public long? MessageId { get; set; }

	// Token: 0x17002316 RID: 8982
	// (get) Token: 0x06019771 RID: 104305 RVA: 0x006940A9 File Offset: 0x006922A9
	// (set) Token: 0x06019772 RID: 104306 RVA: 0x006940B1 File Offset: 0x006922B1
	public float? Duration { get; set; }

	// Token: 0x17002317 RID: 8983
	// (get) Token: 0x06019773 RID: 104307 RVA: 0x006940BA File Offset: 0x006922BA
	// (set) Token: 0x06019774 RID: 104308 RVA: 0x006940C2 File Offset: 0x006922C2
	public int? ServerId { get; set; }

	// Token: 0x17002318 RID: 8984
	// (get) Token: 0x06019775 RID: 104309 RVA: 0x006940CB File Offset: 0x006922CB
	// (set) Token: 0x06019776 RID: 104310 RVA: 0x006940D3 File Offset: 0x006922D3
	public bool? IsIterable { get; set; }

	// Token: 0x17002319 RID: 8985
	// (get) Token: 0x06019777 RID: 104311 RVA: 0x006940DC File Offset: 0x006922DC
	// (set) Token: 0x06019778 RID: 104312 RVA: 0x006940E4 File Offset: 0x006922E4
	public bool? IsServerOrder { get; set; }

	// Token: 0x1700231A RID: 8986
	// (get) Token: 0x06019779 RID: 104313 RVA: 0x006940ED File Offset: 0x006922ED
	// (set) Token: 0x0601977A RID: 104314 RVA: 0x006940F5 File Offset: 0x006922F5
	public string Reason { get; set; } = string.Empty;

	// Token: 0x1700231B RID: 8987
	// (get) Token: 0x0601977B RID: 104315 RVA: 0x006940FE File Offset: 0x006922FE
	// (set) Token: 0x0601977C RID: 104316 RVA: 0x00694106 File Offset: 0x00692306
	public long? BulletMessageId { get; set; }

	// Token: 0x1700231C RID: 8988
	// (get) Token: 0x0601977D RID: 104317 RVA: 0x0069410F File Offset: 0x0069230F
	// (set) Token: 0x0601977E RID: 104318 RVA: 0x00694117 File Offset: 0x00692317
	public bool? BornBuff { get; set; }

	// Token: 0x1700231D RID: 8989
	// (get) Token: 0x0601977F RID: 104319 RVA: 0x00694120 File Offset: 0x00692320
	// (set) Token: 0x06019780 RID: 104320 RVA: 0x00694128 File Offset: 0x00692328
	public float? RemainDuration { get; set; }

	// Token: 0x1700231E RID: 8990
	// (get) Token: 0x06019781 RID: 104321 RVA: 0x00694131 File Offset: 0x00692331
	// (set) Token: 0x06019782 RID: 104322 RVA: 0x00694139 File Offset: 0x00692339
	public bool? IsActive { get; set; }
}
