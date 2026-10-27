using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E1B RID: 3611
[NullableContext(1)]
public interface ISDKPayment
{
	// Token: 0x17000613 RID: 1555
	// (get) Token: 0x0600569A RID: 22170
	// (set) Token: 0x0600569B RID: 22171
	string product_id { get; set; }

	// Token: 0x17000614 RID: 1556
	// (get) Token: 0x0600569C RID: 22172
	// (set) Token: 0x0600569D RID: 22173
	string cpOrderId { get; set; }

	// Token: 0x17000615 RID: 1557
	// (get) Token: 0x0600569E RID: 22174
	// (set) Token: 0x0600569F RID: 22175
	string price { get; set; }

	// Token: 0x17000616 RID: 1558
	// (get) Token: 0x060056A0 RID: 22176
	// (set) Token: 0x060056A1 RID: 22177
	string goodsName { get; set; }

	// Token: 0x17000617 RID: 1559
	// (get) Token: 0x060056A2 RID: 22178
	// (set) Token: 0x060056A3 RID: 22179
	string goodsDesc { get; set; }

	// Token: 0x17000618 RID: 1560
	// (get) Token: 0x060056A4 RID: 22180
	// (set) Token: 0x060056A5 RID: 22181
	[Nullable(2)]
	string extraParams { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000619 RID: 1561
	// (get) Token: 0x060056A6 RID: 22182
	// (set) Token: 0x060056A7 RID: 22183
	[Nullable(2)]
	string callbackUrl { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700061A RID: 1562
	// (get) Token: 0x060056A8 RID: 22184
	// (set) Token: 0x060056A9 RID: 22185
	string currency { get; set; }
}
