using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C2C RID: 7212
[NullableContext(1)]
[Nullable(0)]
public class RechargeInfo
{
	// Token: 0x06011EC0 RID: 73408 RVA: 0x00546602 File Offset: 0x00544802
	public void Init(int payId, string amount, string productId)
	{
		this.PayId = payId;
		this.Amount = amount;
		this.ProductId = productId;
	}

	// Token: 0x04009C3A RID: 39994
	public int PayId;

	// Token: 0x04009C3B RID: 39995
	public string Amount = "";

	// Token: 0x04009C3C RID: 39996
	public string ProductId = "";
}
