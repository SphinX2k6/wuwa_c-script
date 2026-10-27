using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200235A RID: 9050
[NullableContext(1)]
[Nullable(0)]
public class PayShopInfoData
{
	// Token: 0x060120AC RID: 73900 RVA: 0x0046D1F4 File Offset: 0x0046B3F4
	public void Phrase(PayShopInfo info)
	{
		this.Id = info.Id;
		this.UpdateTime = MathUtils.Instance.LongToBigInt(info.UpdateTime);
		this.LastUpdateTime = MathUtils.Instance.LongToBigInt(info.LastUpdateTime);
		this.ShopTabViewType = info.ShopTabViewType;
		this.DynamicTabId = info.DynamicTabId;
		this.Sort = info.Sort;
		this.Money = info.Money.ToList<int>();
		this.SortRule = info.SortRule;
		this.TabContentPath = info.PayShopTabTogContent;
		this.EnableServerRedDot = info.EnableServerRedDot;
	}

	// Token: 0x0400885F RID: 34911
	public int Id;

	// Token: 0x04008860 RID: 34912
	public long UpdateTime;

	// Token: 0x04008861 RID: 34913
	public long LastUpdateTime;

	// Token: 0x04008862 RID: 34914
	public int ShopTabViewType;

	// Token: 0x04008863 RID: 34915
	public int DynamicTabId;

	// Token: 0x04008864 RID: 34916
	public int Sort;

	// Token: 0x04008865 RID: 34917
	public List<int> Money = new List<int>();

	// Token: 0x04008866 RID: 34918
	public int SortRule;

	// Token: 0x04008867 RID: 34919
	public string TabContentPath = "";

	// Token: 0x04008868 RID: 34920
	public bool EnableServerRedDot;
}
