using System;
using System.Runtime.CompilerServices;

// Token: 0x0200024E RID: 590
[NullableContext(1)]
[Nullable(0)]
public class CloudGameUserInfoLegacy : ICloudGameUserInfoLegacy, ILoginInfo
{
	// Token: 0x170005A8 RID: 1448
	// (get) Token: 0x0600246E RID: 9326 RVA: 0x000E10F8 File Offset: 0x000DF2F8
	// (set) Token: 0x0600246F RID: 9327 RVA: 0x000E1100 File Offset: 0x000DF300
	public string TraceId { get; set; }

	// Token: 0x170005A9 RID: 1449
	// (get) Token: 0x06002470 RID: 9328 RVA: 0x000E1109 File Offset: 0x000DF309
	// (set) Token: 0x06002471 RID: 9329 RVA: 0x000E1111 File Offset: 0x000DF311
	public int LoginCode { get; set; }

	// Token: 0x170005AA RID: 1450
	// (get) Token: 0x06002472 RID: 9330 RVA: 0x000E111A File Offset: 0x000DF31A
	// (set) Token: 0x06002473 RID: 9331 RVA: 0x000E1122 File Offset: 0x000DF322
	public string Uid { get; set; }

	// Token: 0x170005AB RID: 1451
	// (get) Token: 0x06002474 RID: 9332 RVA: 0x000E112B File Offset: 0x000DF32B
	// (set) Token: 0x06002475 RID: 9333 RVA: 0x000E1133 File Offset: 0x000DF333
	public string UserName { get; set; }

	// Token: 0x170005AC RID: 1452
	// (get) Token: 0x06002476 RID: 9334 RVA: 0x000E113C File Offset: 0x000DF33C
	// (set) Token: 0x06002477 RID: 9335 RVA: 0x000E1144 File Offset: 0x000DF344
	public string Token { get; set; }
}
