using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02001F98 RID: 8088
[NullableContext(1)]
[Nullable(0)]
public class MotorSkinBuyDetailViewData
{
	// Token: 0x06014028 RID: 81960 RVA: 0x005D4CDF File Offset: 0x005D2EDF
	public static MotorSkinBuyDetailViewData Create(List<ShopMotorSkinData> goodsData)
	{
		MotorSkinBuyDetailViewData motorSkinBuyDetailViewData = new MotorSkinBuyDetailViewData();
		motorSkinBuyDetailViewData.InitData(goodsData);
		return motorSkinBuyDetailViewData;
	}

	// Token: 0x06014029 RID: 81961 RVA: 0x005D4CED File Offset: 0x005D2EED
	public void SetPreviewTitle(string title)
	{
		this.PreviewTitle = title;
	}

	// Token: 0x0601402A RID: 81962 RVA: 0x005D4CF6 File Offset: 0x005D2EF6
	public string GetPreviewTitle()
	{
		return this.PreviewTitle;
	}

	// Token: 0x0601402B RID: 81963 RVA: 0x005D4CFE File Offset: 0x005D2EFE
	public void SetIndex(int index)
	{
		this.CurrentIndex = index;
	}

	// Token: 0x0601402C RID: 81964 RVA: 0x005D4D07 File Offset: 0x005D2F07
	public void InitData(List<ShopMotorSkinData> goodsData)
	{
		this.AllGoodsData = goodsData;
		this.AllSkinData = new List<MotorSkinData>();
	}

	// Token: 0x0601402D RID: 81965 RVA: 0x005D4D1B File Offset: 0x005D2F1B
	public bool CheckIfHaveMutiGood()
	{
		return this.AllGoodsData.Count > 1;
	}

	// Token: 0x0601402E RID: 81966 RVA: 0x005D4D2B File Offset: 0x005D2F2B
	[NullableContext(2)]
	public ShopMotorSkinData GetCurrentGoodsData()
	{
		if (this.AllGoodsData.Count == 0)
		{
			return null;
		}
		return this.AllGoodsData[this.CurrentIndex];
	}

	// Token: 0x0601402F RID: 81967 RVA: 0x005D4D4D File Offset: 0x005D2F4D
	public void SwitchToNextGoods()
	{
		this.CurrentIndex++;
		if (this.CurrentIndex > this.AllGoodsData.Count - 1)
		{
			this.CurrentIndex = 0;
		}
	}

	// Token: 0x06014030 RID: 81968 RVA: 0x005D4D79 File Offset: 0x005D2F79
	public void SwitchToPreGoods()
	{
		this.CurrentIndex--;
		if (this.CurrentIndex < 0)
		{
			this.CurrentIndex = this.AllGoodsData.Count - 1;
		}
	}

	// Token: 0x06014031 RID: 81969 RVA: 0x005D4DA5 File Offset: 0x005D2FA5
	public MotorSkinData GetCurrentSkinData()
	{
		return this.AllSkinData[this.CurrentIndex];
	}

	// Token: 0x06014032 RID: 81970 RVA: 0x005D4DB8 File Offset: 0x005D2FB8
	public string GetDiscountText()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return "";
		}
		return this.GetCurrentGoodsData().GetDiscountText();
	}

	// Token: 0x06014033 RID: 81971 RVA: 0x005D4DD3 File Offset: 0x005D2FD3
	[NullableContext(2)]
	public object GetDiscountTimeData()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return null;
		}
		return this.GetCurrentGoodsData().GetDiscountTimeData();
	}

	// Token: 0x06014034 RID: 81972 RVA: 0x005D4DEA File Offset: 0x005D2FEA
	public bool GetIfDirect()
	{
		return this.GetCurrentGoodsData() != null && this.GetCurrentGoodsData().GetIfDirect();
	}

	// Token: 0x06014035 RID: 81973 RVA: 0x005D4E01 File Offset: 0x005D3001
	[NullableContext(2)]
	public IPriceData GetPriceData()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return null;
		}
		return this.GetCurrentGoodsData().GetPriceData();
	}

	// Token: 0x06014036 RID: 81974 RVA: 0x005D4E18 File Offset: 0x005D3018
	public string GetDirectPriceText()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return "";
		}
		return this.GetCurrentGoodsData().GetDirectPriceText();
	}

	// Token: 0x0400AA76 RID: 43638
	private List<MotorSkinData> AllSkinData = new List<MotorSkinData>();

	// Token: 0x0400AA77 RID: 43639
	private List<ShopMotorSkinData> AllGoodsData = new List<ShopMotorSkinData>();

	// Token: 0x0400AA78 RID: 43640
	private int CurrentIndex;

	// Token: 0x0400AA79 RID: 43641
	private string PreviewTitle = "";
}
