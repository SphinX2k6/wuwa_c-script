using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;

// Token: 0x020013E1 RID: 5089
public class PinballExchangeShopItemProxy : CommonGameplayShopItemProxy
{
	// Token: 0x06008FB2 RID: 36786 RVA: 0x001F131C File Offset: 0x001EF51C
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

	// Token: 0x06008FB3 RID: 36787 RVA: 0x001F136C File Offset: 0x001EF56C
	public override void UpdateBottomBgVisible()
	{
		base.BottomBgVisible = false;
	}

	// Token: 0x06008FB4 RID: 36788 RVA: 0x001F1375 File Offset: 0x001EF575
	public new void UpdateRaycastTarget()
	{
		base.RaycastTarget = false;
	}

	// Token: 0x06008FB5 RID: 36789 RVA: 0x001F137E File Offset: 0x001EF57E
	public new void UpdateRedDot()
	{
		base.RedDotVisible = false;
	}

	// Token: 0x06008FB6 RID: 36790 RVA: 0x001F1387 File Offset: 0x001EF587
	public override void UpdatePriceData()
	{
		base.PriceItemVisible = false;
	}

	// Token: 0x06008FB7 RID: 36791 RVA: 0x001F1390 File Offset: 0x001EF590
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

	// Token: 0x06008FB8 RID: 36792 RVA: 0x001F13D4 File Offset: 0x001EF5D4
	public override void UpdateItemIconData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		base.ItemId = this.GoodsData.GetGoodsData().ItemId;
	}

	// Token: 0x06008FB9 RID: 36793 RVA: 0x001F13F8 File Offset: 0x001EF5F8
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
