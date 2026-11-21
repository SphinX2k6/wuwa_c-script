using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02000895 RID: 2197
public class PinballExchangeShopItemProxy : CommonGameplayShopItemProxy
{
	// Token: 0x06006347 RID: 25415 RVA: 0x001F9E58 File Offset: 0x001F8058
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
		this.UpdateBuyLimitCountText();
		base.UpdateDiscountData();
	}

	// Token: 0x06006348 RID: 25416 RVA: 0x001F9EA8 File Offset: 0x001F80A8
	public override void UpdateBottomBgVisible()
	{
		base.BottomBgVisible = false;
	}

	// Token: 0x06006349 RID: 25417 RVA: 0x001F9EB1 File Offset: 0x001F80B1
	public new void UpdateRaycastTarget()
	{
		base.RaycastTarget = false;
	}

	// Token: 0x0600634A RID: 25418 RVA: 0x001F9EBA File Offset: 0x001F80BA
	public new void UpdateRedDot()
	{
		base.RedDotVisible = false;
	}

	// Token: 0x0600634B RID: 25419 RVA: 0x001F9EC3 File Offset: 0x001F80C3
	public override void UpdatePriceData()
	{
		base.PriceItemVisible = false;
	}

	// Token: 0x0600634C RID: 25420 RVA: 0x001F9ECC File Offset: 0x001F80CC
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

	// Token: 0x0600634D RID: 25421 RVA: 0x001F9F10 File Offset: 0x001F8110
	public override void UpdateItemIconData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.ItemId = this.GoodsData.GetGoodsData().ItemId;
	}

	// Token: 0x0600634E RID: 25422 RVA: 0x001F9F34 File Offset: 0x001F8134
	public override void UpdateItemName()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		PayShopGoodsData goodsData = this.GoodsData.GetGoodsData();
		int num = (goodsData != null) ? goodsData.ItemId : 0;
		if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(num)) == InventoryDefine.EItemDataType.PinballWeaponItem)
		{
			PinballWeaponConfig? pinballWeaponConfigById = PinballConfig.Instance.GetPinballWeaponConfigById(num);
			if (pinballWeaponConfigById != null)
			{
				base.ItemNameTextData.SetData(new TableTextArgNew(pinballWeaponConfigById.Value.Name, Array.Empty<object>()));
				return;
			}
		}
		base.UpdateItemName();
	}
}
