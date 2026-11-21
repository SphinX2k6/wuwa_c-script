using System;

// Token: 0x02001F71 RID: 8049
public class ItemPrice
{
	// Token: 0x06013E8B RID: 81547 RVA: 0x005CDF46 File Offset: 0x005CC146
	public ItemPrice(int id, int price, int originPrice)
	{
		this.CoinId = id;
		this.CoinPrice = price;
		this.OriginalPrice = originPrice;
	}

	// Token: 0x0400A9A6 RID: 43430
	public readonly int CoinId;

	// Token: 0x0400A9A7 RID: 43431
	public readonly int CoinPrice;

	// Token: 0x0400A9A8 RID: 43432
	public readonly int OriginalPrice;
}
