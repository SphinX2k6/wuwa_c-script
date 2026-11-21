using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200183F RID: 6207
[NullableContext(1)]
[Nullable(0)]
public class PayShopInfoData
{
	// Token: 0x0600F55C RID: 62812 RVA: 0x0047A2B4 File Offset: 0x004784B4
	public void Phrase(PayShopInfo info)
	{
		this.Id = info.Id;
		this.UpdateTime = MathUtils.Instance.LongToBigInt(info.UpdateTime);
		this.LastUpdateTime = MathUtils.Instance.LongToBigInt(info.LastUpdateTime);
		this.ShopTabViewType = info.ShopTabViewType;
		this.DynamicTabId = info.DynamicTabId;
		this.Sort = info.Sort;
		this.Money = new List<int>(info.Money);
		this.SortRule = info.SortRule;
		this.TabContentPath = info.PayShopTabTogContent;
		this.EnableServerRedDot = info.EnableServerRedDot;
	}

	// Token: 0x040089A4 RID: 35236
	public int Id;

	// Token: 0x040089A5 RID: 35237
	public long UpdateTime;

	// Token: 0x040089A6 RID: 35238
	public long LastUpdateTime;

	// Token: 0x040089A7 RID: 35239
	public int ShopTabViewType;

	// Token: 0x040089A8 RID: 35240
	public int DynamicTabId;

	// Token: 0x040089A9 RID: 35241
	public int Sort;

	// Token: 0x040089AA RID: 35242
	public List<int> Money = new List<int>();

	// Token: 0x040089AB RID: 35243
	public int SortRule;

	// Token: 0x040089AC RID: 35244
	public string TabContentPath = "";

	// Token: 0x040089AD RID: 35245
	public bool EnableServerRedDot;
}
