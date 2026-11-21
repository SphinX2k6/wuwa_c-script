using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02001822 RID: 6178
public class CommonGameplayExchangeShopItemProxy : CommonGameplayShopItemProxy
{
	// Token: 0x0600F2D1 RID: 62161 RVA: 0x004735E5 File Offset: 0x004717E5
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

	// Token: 0x0600F2D2 RID: 62162 RVA: 0x0047361E File Offset: 0x0047181E
	public new void UpdateBottomBgVisible()
	{
		base.BottomBgVisible = false;
	}

	// Token: 0x0600F2D3 RID: 62163 RVA: 0x00473627 File Offset: 0x00471827
	public new void UpdateRaycastTarget()
	{
		base.RaycastTarget = false;
	}

	// Token: 0x0600F2D4 RID: 62164 RVA: 0x00473630 File Offset: 0x00471830
	public new void UpdateRedDot()
	{
		base.RedDotVisible = false;
	}

	// Token: 0x0600F2D5 RID: 62165 RVA: 0x00473639 File Offset: 0x00471839
	public new void UpdatePriceData()
	{
		base.PriceItemVisible = false;
	}

	// Token: 0x0600F2D6 RID: 62166 RVA: 0x00473642 File Offset: 0x00471842
	public override void UpdateItemName()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.ItemNameTextData.SetContent(this.GoodsData.GetGoodsData().GetGoodsName(LanguageSystem.Instance.PackageLanguage));
	}

	// Token: 0x0600F2D7 RID: 62167 RVA: 0x00473674 File Offset: 0x00471874
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

	// Token: 0x0600F2D8 RID: 62168 RVA: 0x004736B8 File Offset: 0x004718B8
	public override void UpdateItemIconData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.ItemId = this.GoodsData.GetGoodsData().ItemId;
	}

	// Token: 0x0600F2D9 RID: 62169 RVA: 0x004736DC File Offset: 0x004718DC
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
