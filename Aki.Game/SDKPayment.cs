using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E1C RID: 3612
[NullableContext(1)]
[Nullable(0)]
public class SDKPayment : ISDKPayment
{
	// Token: 0x1700061B RID: 1563
	// (get) Token: 0x060056AA RID: 22186 RVA: 0x000FA0B2 File Offset: 0x000F82B2
	// (set) Token: 0x060056AB RID: 22187 RVA: 0x000FA0BA File Offset: 0x000F82BA
	public string product_id { get; set; }

	// Token: 0x1700061C RID: 1564
	// (get) Token: 0x060056AC RID: 22188 RVA: 0x000FA0C3 File Offset: 0x000F82C3
	// (set) Token: 0x060056AD RID: 22189 RVA: 0x000FA0CB File Offset: 0x000F82CB
	public string cpOrderId { get; set; }

	// Token: 0x1700061D RID: 1565
	// (get) Token: 0x060056AE RID: 22190 RVA: 0x000FA0D4 File Offset: 0x000F82D4
	// (set) Token: 0x060056AF RID: 22191 RVA: 0x000FA0DC File Offset: 0x000F82DC
	public string price { get; set; }

	// Token: 0x1700061E RID: 1566
	// (get) Token: 0x060056B0 RID: 22192 RVA: 0x000FA0E5 File Offset: 0x000F82E5
	// (set) Token: 0x060056B1 RID: 22193 RVA: 0x000FA0ED File Offset: 0x000F82ED
	public string goodsName { get; set; }

	// Token: 0x1700061F RID: 1567
	// (get) Token: 0x060056B2 RID: 22194 RVA: 0x000FA0F6 File Offset: 0x000F82F6
	// (set) Token: 0x060056B3 RID: 22195 RVA: 0x000FA0FE File Offset: 0x000F82FE
	public string goodsDesc { get; set; }

	// Token: 0x17000620 RID: 1568
	// (get) Token: 0x060056B4 RID: 22196 RVA: 0x000FA107 File Offset: 0x000F8307
	// (set) Token: 0x060056B5 RID: 22197 RVA: 0x000FA10F File Offset: 0x000F830F
	[Nullable(2)]
	public string extraParams { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000621 RID: 1569
	// (get) Token: 0x060056B6 RID: 22198 RVA: 0x000FA118 File Offset: 0x000F8318
	// (set) Token: 0x060056B7 RID: 22199 RVA: 0x000FA120 File Offset: 0x000F8320
	[Nullable(2)]
	public string callbackUrl { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000622 RID: 1570
	// (get) Token: 0x060056B8 RID: 22200 RVA: 0x000FA129 File Offset: 0x000F8329
	// (set) Token: 0x060056B9 RID: 22201 RVA: 0x000FA131 File Offset: 0x000F8331
	public string currency { get; set; }
}
