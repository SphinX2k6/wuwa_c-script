using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200183E RID: 6206
public class PayShopGoodsPrice
{
	// Token: 0x0600F558 RID: 62808 RVA: 0x0047A243 File Offset: 0x00478443
	[NullableContext(1)]
	public void Phrase(PayShopPrice data)
	{
		this.Id = data.Id;
		this.Count = data.Count;
		this.PromotionCount = data.PromotionCount;
	}

	// Token: 0x0600F559 RID: 62809 RVA: 0x0047A269 File Offset: 0x00478469
	public int GetDiscount()
	{
		return (int)Math.Ceiling((double)((this.Count - this.PromotionCount) * 100) / (double)this.Count);
	}

	// Token: 0x0600F55A RID: 62810 RVA: 0x0047A28A File Offset: 0x0047848A
	public int GetDiscountNew()
	{
		return (int)Math.Floor((double)((this.Count - this.PromotionCount) * 100) / (double)this.PromotionCount);
	}

	// Token: 0x040089A1 RID: 35233
	public int Id;

	// Token: 0x040089A2 RID: 35234
	public int Count;

	// Token: 0x040089A3 RID: 35235
	public int PromotionCount;
}
