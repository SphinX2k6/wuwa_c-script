using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x0200203E RID: 8254
[NullableContext(1)]
[Nullable(0)]
public class CardItemData : ICardItemData
{
	// Token: 0x170013CD RID: 5069
	// (get) Token: 0x06010348 RID: 66376 RVA: 0x003F2EDB File Offset: 0x003F10DB
	// (set) Token: 0x06010349 RID: 66377 RVA: 0x003F2EE3 File Offset: 0x003F10E3
	public int Id { get; set; }

	// Token: 0x170013CE RID: 5070
	// (get) Token: 0x0601034A RID: 66378 RVA: 0x003F2EEC File Offset: 0x003F10EC
	// (set) Token: 0x0601034B RID: 66379 RVA: 0x003F2EF4 File Offset: 0x003F10F4
	public List<ITalkOption> Options { get; set; }

	// Token: 0x170013CF RID: 5071
	// (get) Token: 0x0601034C RID: 66380 RVA: 0x003F2EFD File Offset: 0x003F10FD
	// (set) Token: 0x0601034D RID: 66381 RVA: 0x003F2F05 File Offset: 0x003F1105
	public string Tid { get; set; }

	// Token: 0x170013D0 RID: 5072
	// (get) Token: 0x0601034E RID: 66382 RVA: 0x003F2F0E File Offset: 0x003F110E
	// (set) Token: 0x0601034F RID: 66383 RVA: 0x003F2F16 File Offset: 0x003F1116
	public int WhoId { get; set; }

	// Token: 0x170013D1 RID: 5073
	// (get) Token: 0x06010350 RID: 66384 RVA: 0x003F2F1F File Offset: 0x003F111F
	// (set) Token: 0x06010351 RID: 66385 RVA: 0x003F2F27 File Offset: 0x003F1127
	public string BackGroundConfig { get; set; }
}
