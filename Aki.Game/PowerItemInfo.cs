using System;
using System.Runtime.CompilerServices;

// Token: 0x020025F7 RID: 9719
public class PowerItemInfo
{
	// Token: 0x17001954 RID: 6484
	// (get) Token: 0x06013C5B RID: 80987 RVA: 0x004F4F85 File Offset: 0x004F3185
	// (set) Token: 0x06013C5A RID: 80986 RVA: 0x004F4F60 File Offset: 0x004F3160
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

	// Token: 0x06013C5C RID: 80988 RVA: 0x004F4F8D File Offset: 0x004F318D
	public PowerItemInfo(int itemId)
	{
		this.ItemId = itemId;
	}

	// Token: 0x040094FB RID: 38139
	[Nullable(1)]
	public string ItemName = "";

	// Token: 0x040094FC RID: 38140
	private int InnerItemId;

	// Token: 0x040094FD RID: 38141
	public int StackValue;

	// Token: 0x040094FE RID: 38142
	public int RenewValue;

	// Token: 0x040094FF RID: 38143
	public int CostValue;

	// Token: 0x04009500 RID: 38144
	public int ShopId;

	// Token: 0x04009501 RID: 38145
	public int GoodsId;

	// Token: 0x04009502 RID: 38146
	public bool IsHideWhenZero;

	// Token: 0x04009503 RID: 38147
	public int RemainCount;
}
