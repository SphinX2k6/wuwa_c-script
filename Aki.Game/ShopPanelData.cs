using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F6D RID: 8045
[NullableContext(2)]
[Nullable(0)]
public class ShopPanelData
{
	// Token: 0x06013E5E RID: 81502 RVA: 0x005CCCAD File Offset: 0x005CAEAD
	public bool IsSoldOut()
	{
		return this.BuyLimit > 0 && this.BoughtCount == this.BuyLimit;
	}

	// Token: 0x06013E5F RID: 81503 RVA: 0x005CCCC8 File Offset: 0x005CAEC8
	public bool IsInteractive()
	{
		return !this.IsSoldOut() && this.InSellTime && !this.IsLock;
	}

	// Token: 0x0400A98C RID: 43404
	public int ItemId;

	// Token: 0x0400A98D RID: 43405
	public object ParamData;

	// Token: 0x0400A98E RID: 43406
	public int CurrencyId;

	// Token: 0x0400A98F RID: 43407
	public int SingleBuyCount;

	// Token: 0x0400A990 RID: 43408
	public int SingleBuyPrice;

	// Token: 0x0400A991 RID: 43409
	public int BoughtCount;

	// Token: 0x0400A992 RID: 43410
	public int BuyLimit;

	// Token: 0x0400A993 RID: 43411
	public bool IsLock;

	// Token: 0x0400A994 RID: 43412
	public object LockText;

	// Token: 0x0400A995 RID: 43413
	public bool InSellTime;

	// Token: 0x0400A996 RID: 43414
	public TBuySuccess BuySuccessFunction;
}
