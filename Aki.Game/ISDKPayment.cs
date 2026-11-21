using System;
using System.Runtime.CompilerServices;

// Token: 0x020002CF RID: 719
[NullableContext(1)]
public interface ISDKPayment
{
	// Token: 0x17000637 RID: 1591
	// (get) Token: 0x06002A2A RID: 10794
	// (set) Token: 0x06002A2B RID: 10795
	string product_id { get; set; }

	// Token: 0x17000638 RID: 1592
	// (get) Token: 0x06002A2C RID: 10796
	// (set) Token: 0x06002A2D RID: 10797
	string cpOrderId { get; set; }

	// Token: 0x17000639 RID: 1593
	// (get) Token: 0x06002A2E RID: 10798
	// (set) Token: 0x06002A2F RID: 10799
	string price { get; set; }

	// Token: 0x1700063A RID: 1594
	// (get) Token: 0x06002A30 RID: 10800
	// (set) Token: 0x06002A31 RID: 10801
	string goodsName { get; set; }

	// Token: 0x1700063B RID: 1595
	// (get) Token: 0x06002A32 RID: 10802
	// (set) Token: 0x06002A33 RID: 10803
	string goodsDesc { get; set; }

	// Token: 0x1700063C RID: 1596
	// (get) Token: 0x06002A34 RID: 10804
	// (set) Token: 0x06002A35 RID: 10805
	[Nullable(2)]
	string extraParams { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700063D RID: 1597
	// (get) Token: 0x06002A36 RID: 10806
	// (set) Token: 0x06002A37 RID: 10807
	[Nullable(2)]
	string callbackUrl { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700063E RID: 1598
	// (get) Token: 0x06002A38 RID: 10808
	// (set) Token: 0x06002A39 RID: 10809
	string currency { get; set; }
}
