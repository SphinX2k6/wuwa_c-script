using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02002A1B RID: 10779
[NullableContext(1)]
[Nullable(0)]
public class FlySkinBuyDetailViewData
{
	// Token: 0x060165FC RID: 91644 RVA: 0x005A98DA File Offset: 0x005A7ADA
	public static FlySkinBuyDetailViewData Create(List<ShopFlySkinData> goodsData)
	{
		FlySkinBuyDetailViewData flySkinBuyDetailViewData = new FlySkinBuyDetailViewData();
		flySkinBuyDetailViewData.InitData(goodsData);
		return flySkinBuyDetailViewData;
	}

	// Token: 0x060165FD RID: 91645 RVA: 0x005A98E8 File Offset: 0x005A7AE8
	public void SetPreviewTitle(string title)
	{
		this.PreviewTitle = title;
	}

	// Token: 0x060165FE RID: 91646 RVA: 0x005A98F1 File Offset: 0x005A7AF1
	public string GetPreviewTitle()
	{
		return this.PreviewTitle;
	}

	// Token: 0x060165FF RID: 91647 RVA: 0x005A98F9 File Offset: 0x005A7AF9
	public void SetIndex(int index)
	{
		this.CurrentIndex = index;
	}

	// Token: 0x06016600 RID: 91648 RVA: 0x005A9904 File Offset: 0x005A7B04
	public void InitData(List<ShopFlySkinData> goodsData)
	{
		this.AllGoodsData = goodsData;
		this.AllSoarWingSkinData = new List<FlySkinData>();
		this.AllParaglidingSkinData = new List<FlySkinData>();
		foreach (ShopFlySkinData shopFlySkinData in goodsData)
		{
			FlySkinData flySkinData = FlySkinModel.Instance.GetFlySkinData(shopFlySkinData.GetSoarWingSkinId());
			this.AllSoarWingSkinData.Add(flySkinData);
			flySkinData = FlySkinModel.Instance.GetFlySkinData(shopFlySkinData.GetParaglidingSkinId());
			this.AllParaglidingSkinData.Add(flySkinData);
		}
	}

	// Token: 0x06016601 RID: 91649 RVA: 0x005A99A4 File Offset: 0x005A7BA4
	public bool CheckIfHaveMutiGood()
	{
		return this.AllGoodsData.Count > 1;
	}

	// Token: 0x06016602 RID: 91650 RVA: 0x005A99B4 File Offset: 0x005A7BB4
	[NullableContext(2)]
	public ShopFlySkinData GetCurrentGoodsData()
	{
		if (this.AllGoodsData.Count == 0)
		{
			return null;
		}
		return this.AllGoodsData[this.CurrentIndex];
	}

	// Token: 0x06016603 RID: 91651 RVA: 0x005A99D6 File Offset: 0x005A7BD6
	public void SwitchToNextGoods()
	{
		this.CurrentIndex++;
		if (this.CurrentIndex > this.AllGoodsData.Count - 1)
		{
			this.CurrentIndex = 0;
		}
	}

	// Token: 0x06016604 RID: 91652 RVA: 0x005A9A02 File Offset: 0x005A7C02
	public void SwitchToPreGoods()
	{
		this.CurrentIndex--;
		if (this.CurrentIndex < 0)
		{
			this.CurrentIndex = this.AllGoodsData.Count - 1;
		}
	}

	// Token: 0x06016605 RID: 91653 RVA: 0x005A9A2E File Offset: 0x005A7C2E
	public FlySkinData GetCurrentSkinData(EFlySkinType flySkinType)
	{
		if (flySkinType == EFlySkinType.SoarWing)
		{
			return this.AllSoarWingSkinData[this.CurrentIndex];
		}
		return this.AllParaglidingSkinData[this.CurrentIndex];
	}

	// Token: 0x06016606 RID: 91654 RVA: 0x005A9A56 File Offset: 0x005A7C56
	public string GetDiscountText()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return "";
		}
		return this.GetCurrentGoodsData().GetDiscountText();
	}

	// Token: 0x06016607 RID: 91655 RVA: 0x005A9A71 File Offset: 0x005A7C71
	[NullableContext(2)]
	public object GetDiscountTimeData()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return null;
		}
		return this.GetCurrentGoodsData().GetDiscountTimeData();
	}

	// Token: 0x06016608 RID: 91656 RVA: 0x005A9A88 File Offset: 0x005A7C88
	public bool GetIfDirect()
	{
		return this.GetCurrentGoodsData() != null && this.GetCurrentGoodsData().GetIfDirect();
	}

	// Token: 0x06016609 RID: 91657 RVA: 0x005A9A9F File Offset: 0x005A7C9F
	[NullableContext(2)]
	public IPriceData GetPriceData()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return null;
		}
		return this.GetCurrentGoodsData().GetPriceData();
	}

	// Token: 0x0601660A RID: 91658 RVA: 0x005A9AB6 File Offset: 0x005A7CB6
	public string GetDirectPriceText()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return "";
		}
		return this.GetCurrentGoodsData().GetDirectPriceText();
	}

	// Token: 0x0400A685 RID: 42629
	private List<FlySkinData> AllSoarWingSkinData = new List<FlySkinData>();

	// Token: 0x0400A686 RID: 42630
	private List<FlySkinData> AllParaglidingSkinData = new List<FlySkinData>();

	// Token: 0x0400A687 RID: 42631
	private List<ShopFlySkinData> AllGoodsData = new List<ShopFlySkinData>();

	// Token: 0x0400A688 RID: 42632
	private int CurrentIndex;

	// Token: 0x0400A689 RID: 42633
	private string PreviewTitle = "";
}
