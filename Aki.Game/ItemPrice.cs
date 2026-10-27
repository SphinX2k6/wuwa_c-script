using System;

// Token: 0x020029F6 RID: 10742
public class ItemPrice
{
	// Token: 0x06016484 RID: 91268 RVA: 0x005A2F6E File Offset: 0x005A116E
	public ItemPrice(int id, int price, int originPrice)
	{
		this.CoinId = id;
		this.CoinPrice = price;
		this.OriginalPrice = originPrice;
	}

	// Token: 0x0400A5BC RID: 42428
	public readonly int CoinId;

	// Token: 0x0400A5BD RID: 42429
	public readonly int CoinPrice;

	// Token: 0x0400A5BE RID: 42430
	public readonly int OriginalPrice;
}
