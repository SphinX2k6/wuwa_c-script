using System;
using System.Runtime.CompilerServices;

// Token: 0x02002741 RID: 10049
[NullableContext(1)]
[Nullable(0)]
public class RechargeInfo
{
	// Token: 0x060149DE RID: 84446 RVA: 0x005378F6 File Offset: 0x00535AF6
	public void Init(int payId, string amount, string productId)
	{
		this.PayId = payId;
		this.Amount = amount;
		this.ProductId = productId;
	}

	// Token: 0x04009AE2 RID: 39650
	public int PayId;

	// Token: 0x04009AE3 RID: 39651
	public string Amount = "";

	// Token: 0x04009AE4 RID: 39652
	public string ProductId = "";
}
