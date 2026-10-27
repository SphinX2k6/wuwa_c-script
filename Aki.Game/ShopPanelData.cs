using System;
using System.Runtime.CompilerServices;

// Token: 0x020029F2 RID: 10738
[NullableContext(2)]
[Nullable(0)]
public class ShopPanelData
{
	// Token: 0x06016457 RID: 91223 RVA: 0x005A1CCD File Offset: 0x0059FECD
	public bool IsSoldOut()
	{
		return this.BuyLimit > 0 && this.BoughtCount == this.BuyLimit;
	}

	// Token: 0x06016458 RID: 91224 RVA: 0x005A1CE8 File Offset: 0x0059FEE8
	public bool IsInteractive()
	{
		return !this.IsSoldOut() && this.InSellTime && !this.IsLock;
	}

	// Token: 0x0400A5A2 RID: 42402
	public int ItemId;

	// Token: 0x0400A5A3 RID: 42403
	public object ParamData;

	// Token: 0x0400A5A4 RID: 42404
	public int CurrencyId;

	// Token: 0x0400A5A5 RID: 42405
	public int SingleBuyCount;

	// Token: 0x0400A5A6 RID: 42406
	public int SingleBuyPrice;

	// Token: 0x0400A5A7 RID: 42407
	public int BoughtCount;

	// Token: 0x0400A5A8 RID: 42408
	public int BuyLimit;

	// Token: 0x0400A5A9 RID: 42409
	public bool IsLock;

	// Token: 0x0400A5AA RID: 42410
	public object LockText;

	// Token: 0x0400A5AB RID: 42411
	public bool InSellTime;

	// Token: 0x0400A5AC RID: 42412
	public TBuySuccess BuySuccessFunction;
}
