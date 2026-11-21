using System;
using System.Runtime.CompilerServices;

// Token: 0x02001AE2 RID: 6882
public class PowerItemInfo
{
	// Token: 0x1700198C RID: 6540
	// (get) Token: 0x0601113D RID: 69949 RVA: 0x00503D11 File Offset: 0x00501F11
	// (set) Token: 0x0601113C RID: 69948 RVA: 0x00503CEC File Offset: 0x00501EEC
	public int ItemId
	{
		get
		{
			return this.InnerItemId;
		}
		set
		{
			this.InnerItemId = value;
			if (this.InnerItemId <= 2000)
			{
				this.ShopId = 6;
				return;
			}
			this.ShopId = 7;
		}
	}

	// Token: 0x0601113E RID: 69950 RVA: 0x00503D19 File Offset: 0x00501F19
	public PowerItemInfo(int itemId)
	{
		this.ItemId = itemId;
	}

	// Token: 0x04009652 RID: 38482
	[Nullable(1)]
	public string ItemName = "";

	// Token: 0x04009653 RID: 38483
	private int InnerItemId;

	// Token: 0x04009654 RID: 38484
	public int StackValue;

	// Token: 0x04009655 RID: 38485
	public int RenewValue;

	// Token: 0x04009656 RID: 38486
	public int CostValue;

	// Token: 0x04009657 RID: 38487
	public int ShopId;

	// Token: 0x04009658 RID: 38488
	public int GoodsId;

	// Token: 0x04009659 RID: 38489
	public bool IsHideWhenZero;

	// Token: 0x0400965A RID: 38490
	public int RemainCount;
}
