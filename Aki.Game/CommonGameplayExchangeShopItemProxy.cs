using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x0200233D RID: 9021
public class CommonGameplayExchangeShopItemProxy : CommonGameplayShopItemProxy
{
	// Token: 0x06011E21 RID: 73249 RVA: 0x0046651D File Offset: 0x0046471D
	[NullableContext(1)]
	public override void UpdateFromPayShopGoods(PayShopGoods data)
	{
		this.GoodsData = data;
		this.UpdateBottomBgVisible();
		this.UpdateRaycastTarget();
		this.UpdateRedDot();
		this.UpdatePriceData();
		this.UpdateItemName();
		this.UpdateQualityData();
		this.UpdateItemIconData();
		this.UpdateSoldOutData();
	}

	// Token: 0x06011E22 RID: 73250 RVA: 0x00466556 File Offset: 0x00464756
	public new void UpdateBottomBgVisible()
	{
		base.BottomBgVisible = false;
	}

	// Token: 0x06011E23 RID: 73251 RVA: 0x0046655F File Offset: 0x0046475F
	public new void UpdateRaycastTarget()
	{
		base.RaycastTarget = false;
	}

	// Token: 0x06011E24 RID: 73252 RVA: 0x00466568 File Offset: 0x00464768
	public new void UpdateRedDot()
	{
		base.RedDotVisible = false;
	}

	// Token: 0x06011E25 RID: 73253 RVA: 0x00466571 File Offset: 0x00464771
	public new void UpdatePriceData()
	{
		base.PriceItemVisible = false;
	}

	// Token: 0x06011E26 RID: 73254 RVA: 0x0046657A File Offset: 0x0046477A
	public override void UpdateItemName()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.ItemNameTextData.SetContent(this.GoodsData.GetGoodsData().GetGoodsName(LanguageSystem.Instance.PackageLanguage));
	}

	// Token: 0x06011E27 RID: 73255 RVA: 0x004665AC File Offset: 0x004647AC
	public override void UpdateQualityData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		CSharpScript.Game.Module.PayShop.IItemData itemData = this.GoodsData.GetItemData();
		if (itemData == null)
		{
			return;
		}
		string payShopItemQualitySpriteByItemIdAndQuality = PayShopModel.Instance.GetPayShopItemQualitySpriteByItemIdAndQuality(itemData.ItemId, itemData.Quality);
		base.QualitySpritePath = payShopItemQualitySpriteByItemIdAndQuality;
	}

	// Token: 0x06011E28 RID: 73256 RVA: 0x004665F0 File Offset: 0x004647F0
	public override void UpdateItemIconData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.ItemId = this.GoodsData.GetGoodsData().ItemId;
	}

	// Token: 0x06011E29 RID: 73257 RVA: 0x00466614 File Offset: 0x00464814
	public override void UpdateSoldOutData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.SoldOutItemVisible = (this.GoodsData.IsLimitGoods() && this.GoodsData.IsSoldOut());
		if (base.SoldOutItemVisible)
		{
			if (this.GoodsData.CheckIfMonthCardItem())
			{
				base.SoldOutTextData.SetData(new TableTextArgNew("MonthlyCardMax", Array.Empty<object>()));
				return;
			}
			base.SoldOutTextData.SetData(new TableTextArgNew("SoldOut", Array.Empty<object>()));
		}
	}
}
