using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02002A1D RID: 10781
[NullableContext(1)]
[Nullable(0)]
public class MotorSkinBuyDetailViewData
{
	// Token: 0x06016622 RID: 91682 RVA: 0x005A9D03 File Offset: 0x005A7F03
	public static MotorSkinBuyDetailViewData Create(List<ShopMotorSkinData> goodsData)
	{
		MotorSkinBuyDetailViewData motorSkinBuyDetailViewData = new MotorSkinBuyDetailViewData();
		motorSkinBuyDetailViewData.InitData(goodsData);
		return motorSkinBuyDetailViewData;
	}

	// Token: 0x06016623 RID: 91683 RVA: 0x005A9D11 File Offset: 0x005A7F11
	public void SetPreviewTitle(string title)
	{
		this.PreviewTitle = title;
	}

	// Token: 0x06016624 RID: 91684 RVA: 0x005A9D1A File Offset: 0x005A7F1A
	public string GetPreviewTitle()
	{
		return this.PreviewTitle;
	}

	// Token: 0x06016625 RID: 91685 RVA: 0x005A9D22 File Offset: 0x005A7F22
	public void SetIndex(int index)
	{
		this.CurrentIndex = index;
	}

	// Token: 0x06016626 RID: 91686 RVA: 0x005A9D2B File Offset: 0x005A7F2B
	public void InitData(List<ShopMotorSkinData> goodsData)
	{
		this.AllGoodsData = goodsData;
		this.AllSkinData = new List<MotorSkinData>();
	}

	// Token: 0x06016627 RID: 91687 RVA: 0x005A9D3F File Offset: 0x005A7F3F
	public bool CheckIfHaveMutiGood()
	{
		return this.AllGoodsData.Count > 1;
	}

	// Token: 0x06016628 RID: 91688 RVA: 0x005A9D4F File Offset: 0x005A7F4F
	[NullableContext(2)]
	public ShopMotorSkinData GetCurrentGoodsData()
	{
		if (this.AllGoodsData.Count == 0)
		{
			return null;
		}
		return this.AllGoodsData[this.CurrentIndex];
	}

	// Token: 0x06016629 RID: 91689 RVA: 0x005A9D71 File Offset: 0x005A7F71
	public void SwitchToNextGoods()
	{
		this.CurrentIndex++;
		if (this.CurrentIndex > this.AllGoodsData.Count - 1)
		{
			this.CurrentIndex = 0;
		}
	}

	// Token: 0x0601662A RID: 91690 RVA: 0x005A9D9D File Offset: 0x005A7F9D
	public void SwitchToPreGoods()
	{
		this.CurrentIndex--;
		if (this.CurrentIndex < 0)
		{
			this.CurrentIndex = this.AllGoodsData.Count - 1;
		}
	}

	// Token: 0x0601662B RID: 91691 RVA: 0x005A9DC9 File Offset: 0x005A7FC9
	public MotorSkinData GetCurrentSkinData()
	{
		return this.AllSkinData[this.CurrentIndex];
	}

	// Token: 0x0601662C RID: 91692 RVA: 0x005A9DDC File Offset: 0x005A7FDC
	public string GetDiscountText()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return "";
		}
		return this.GetCurrentGoodsData().GetDiscountText();
	}

	// Token: 0x0601662D RID: 91693 RVA: 0x005A9DF7 File Offset: 0x005A7FF7
	[NullableContext(2)]
	public object GetDiscountTimeData()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return null;
		}
		return this.GetCurrentGoodsData().GetDiscountTimeData();
	}

	// Token: 0x0601662E RID: 91694 RVA: 0x005A9E0E File Offset: 0x005A800E
	public bool GetIfDirect()
	{
		return this.GetCurrentGoodsData() != null && this.GetCurrentGoodsData().GetIfDirect();
	}

	// Token: 0x0601662F RID: 91695 RVA: 0x005A9E25 File Offset: 0x005A8025
	[NullableContext(2)]
	public IPriceData GetPriceData()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return null;
		}
		return this.GetCurrentGoodsData().GetPriceData();
	}

	// Token: 0x06016630 RID: 91696 RVA: 0x005A9E3C File Offset: 0x005A803C
	public string GetDirectPriceText()
	{
		if (this.GetCurrentGoodsData() == null)
		{
			return "";
		}
		return this.GetCurrentGoodsData().GetDirectPriceText();
	}

	// Token: 0x0400A68D RID: 42637
	private List<MotorSkinData> AllSkinData = new List<MotorSkinData>();

	// Token: 0x0400A68E RID: 42638
	private List<ShopMotorSkinData> AllGoodsData = new List<ShopMotorSkinData>();

	// Token: 0x0400A68F RID: 42639
	private int CurrentIndex;

	// Token: 0x0400A690 RID: 42640
	private string PreviewTitle = "";
}
