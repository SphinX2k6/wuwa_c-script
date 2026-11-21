using System;
using System.Runtime.CompilerServices;

// Token: 0x020002D0 RID: 720
[NullableContext(1)]
[Nullable(0)]
public class SDKPayment : ISDKPayment
{
	// Token: 0x1700063F RID: 1599
	// (get) Token: 0x06002A3A RID: 10810 RVA: 0x00101898 File Offset: 0x000FFA98
	// (set) Token: 0x06002A3B RID: 10811 RVA: 0x001018A0 File Offset: 0x000FFAA0
	public string product_id { get; set; }

	// Token: 0x17000640 RID: 1600
	// (get) Token: 0x06002A3C RID: 10812 RVA: 0x001018A9 File Offset: 0x000FFAA9
	// (set) Token: 0x06002A3D RID: 10813 RVA: 0x001018B1 File Offset: 0x000FFAB1
	public string cpOrderId { get; set; }

	// Token: 0x17000641 RID: 1601
	// (get) Token: 0x06002A3E RID: 10814 RVA: 0x001018BA File Offset: 0x000FFABA
	// (set) Token: 0x06002A3F RID: 10815 RVA: 0x001018C2 File Offset: 0x000FFAC2
	public string price { get; set; }

	// Token: 0x17000642 RID: 1602
	// (get) Token: 0x06002A40 RID: 10816 RVA: 0x001018CB File Offset: 0x000FFACB
	// (set) Token: 0x06002A41 RID: 10817 RVA: 0x001018D3 File Offset: 0x000FFAD3
	public string goodsName { get; set; }

	// Token: 0x17000643 RID: 1603
	// (get) Token: 0x06002A42 RID: 10818 RVA: 0x001018DC File Offset: 0x000FFADC
	// (set) Token: 0x06002A43 RID: 10819 RVA: 0x001018E4 File Offset: 0x000FFAE4
	public string goodsDesc { get; set; }

	// Token: 0x17000644 RID: 1604
	// (get) Token: 0x06002A44 RID: 10820 RVA: 0x001018ED File Offset: 0x000FFAED
	// (set) Token: 0x06002A45 RID: 10821 RVA: 0x001018F5 File Offset: 0x000FFAF5
	[Nullable(2)]
	public string extraParams { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000645 RID: 1605
	// (get) Token: 0x06002A46 RID: 10822 RVA: 0x001018FE File Offset: 0x000FFAFE
	// (set) Token: 0x06002A47 RID: 10823 RVA: 0x00101906 File Offset: 0x000FFB06
	[Nullable(2)]
	public string callbackUrl { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000646 RID: 1606
	// (get) Token: 0x06002A48 RID: 10824 RVA: 0x0010190F File Offset: 0x000FFB0F
	// (set) Token: 0x06002A49 RID: 10825 RVA: 0x00101917 File Offset: 0x000FFB17
	public string currency { get; set; }
}
