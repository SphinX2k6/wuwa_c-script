using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002359 RID: 9049
public class PayShopGoodsPrice
{
	// Token: 0x060120A8 RID: 73896 RVA: 0x0046D183 File Offset: 0x0046B383
	[NullableContext(1)]
	public void Phrase(PayShopPrice data)
	{
		this.Id = data.Id;
		this.Count = data.Count;
		this.PromotionCount = data.PromotionCount;
	}

	// Token: 0x060120A9 RID: 73897 RVA: 0x0046D1A9 File Offset: 0x0046B3A9
	public int GetDiscount()
	{
		return (int)Math.Ceiling((double)((this.Count - this.PromotionCount) * 100) / (double)this.Count);
	}

	// Token: 0x060120AA RID: 73898 RVA: 0x0046D1CA File Offset: 0x0046B3CA
	public int GetDiscountNew()
	{
		return (int)Math.Floor((double)((this.Count - this.PromotionCount) * 100) / (double)this.PromotionCount);
	}

	// Token: 0x0400885C RID: 34908
	public int Id;

	// Token: 0x0400885D RID: 34909
	public int Count;

	// Token: 0x0400885E RID: 34910
	public int PromotionCount;
}
