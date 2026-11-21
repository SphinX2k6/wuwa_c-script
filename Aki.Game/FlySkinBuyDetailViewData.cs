using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02001F96 RID: 8086
[NullableContext(1)]
[Nullable(0)]
public class FlySkinBuyDetailViewData
{
	// Token: 0x06014002 RID: 81922 RVA: 0x005D48B6 File Offset: 0x005D2AB6
	public static FlySkinBuyDetailViewData Create(List<ShopFlySkinData> goodsData)
	{
		FlySkinBuyDetailViewData flySkinBuyDetailViewData = new FlySkinBuyDetailViewData();
		flySkinBuyDetailViewData.InitData(goodsData);
		return flySkinBuyDetailViewData;
	}

	// Token: 0x06014003 RID: 81923 RVA: 0x005D48C4 File Offset: 0x005D2AC4
	public void SetPreviewTitle(string title)
	{
		this.PreviewTitle = title;
	}

	// Token: 0x06014004 RID: 81924 RVA: 0x005D48CD File Offset: 0x005D2ACD
	public string GetPreviewTitle()
	{
		return this.PreviewTitle;
	}

	// Token: 0x06014005 RID: 81925 RVA: 0x005D48D5 File Offset: 0x005D2AD5
	public void SetIndex(int index)
	{
		this.CurrentIndex = index;
	}

	// Token: 0x06014006 RID: 81926 RVA: 0x005D48E0 File Offset: 0x005D2AE0
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

	// Token: 0x06014007 RID: 81927 RVA: 0x005D4980 File Offset: 0x005D2B80
	public bool CheckIfHaveMutiGood()
	{
		return this.AllGoodsData.Count > 1;
	}

	// Token: 0x06014008 RID: 81928 RVA: 0x005D4990 File Offset: 0x005D2B90
	[NullableContext(2)]
	public ShopFlySkinData GetCurrentGoodsData()
	{
		if (this.AllGoodsData.Count == 0)
		{
			return null;
		}
		return this.AllGoodsData[this.CurrentIndex];
	}

	// Token: 0x06014009 RID: 81929 RVA: 0x005D49B2 File Offset: 0x005D2BB2
	public void SwitchToNextGoods()
	{
		this.CurrentIndex++;
		if (this.CurrentIndex > this.AllGoodsData.Count - 1)
		{
			this.CurrentIndex = 0;
		}
	}

	// Token: 0x0601400A RID: 81930 RVA: 0x005D49DE File Offset: 0x005D2BDE
	public void SwitchToPreGoods()
	{
		this.CurrentIndex--;
		if (this.CurrentIndex < 0)
		{
			this.CurrentIndex = this.AllGoodsData.Count - 1;
		}
	}

	// Token: 0x0601400B RID: 81931 RVA: 0x005D4A0A File Offset: 0x005D2C0A
	public FlySkinData GetCurrentSkinData(EFlySkinType flySkinType)
	{
		if (flySkinType == EFlySkinType.SoarWing)
		{
			return this.AllSoarWingSkinData[this.CurrentIndex];
		}
		return this.AllParaglidingSkinData[this.CurrentIndex];
	}

	// Token: 0x0601400C RID: 81932 RVA: 0x005D4A32 File Offset: 0x005D2C32
	public string GetDiscountText()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return "";
		}
		return this.GetCurrentGoodsData().GetDiscountText();
	}

	// Token: 0x0601400D RID: 81933 RVA: 0x005D4A4D File Offset: 0x005D2C4D
	[NullableContext(2)]
	public object GetDiscountTimeData()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return null;
		}
		return this.GetCurrentGoodsData().GetDiscountTimeData();
	}

	// Token: 0x0601400E RID: 81934 RVA: 0x005D4A64 File Offset: 0x005D2C64
	public bool GetIfDirect()
	{
		return this.GetCurrentGoodsData() != null && this.GetCurrentGoodsData().GetIfDirect();
	}

	// Token: 0x0601400F RID: 81935 RVA: 0x005D4A7B File Offset: 0x005D2C7B
	[NullableContext(2)]
	public IPriceData GetPriceData()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return null;
		}
		return this.GetCurrentGoodsData().GetPriceData();
	}

	// Token: 0x06014010 RID: 81936 RVA: 0x005D4A92 File Offset: 0x005D2C92
	public string GetDirectPriceText()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return "";
		}
		return this.GetCurrentGoodsData().GetDirectPriceText();
	}

	// Token: 0x0400AA6E RID: 43630
	private List<FlySkinData> AllSoarWingSkinData = new List<FlySkinData>();

	// Token: 0x0400AA6F RID: 43631
	private List<FlySkinData> AllParaglidingSkinData = new List<FlySkinData>();

	// Token: 0x0400AA70 RID: 43632
	private List<ShopFlySkinData> AllGoodsData = new List<ShopFlySkinData>();

	// Token: 0x0400AA71 RID: 43633
	private int CurrentIndex;

	// Token: 0x0400AA72 RID: 43634
	private string PreviewTitle = "";
}
