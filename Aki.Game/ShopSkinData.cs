using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02002A22 RID: 10786
[NullableContext(1)]
[Nullable(0)]
public class ShopSkinData
{
	// Token: 0x06016688 RID: 91784 RVA: 0x005AAB31 File Offset: 0x005A8D31
	public static ShopSkinData Create(PayShopGoods data)
	{
		ShopSkinData shopSkinData = new ShopSkinData();
		shopSkinData.InitData(data);
		return shopSkinData;
	}

	// Token: 0x06016689 RID: 91785 RVA: 0x005AAB40 File Offset: 0x005A8D40
	public void InitData(PayShopGoods data)
	{
		this.PayShopGoods = data;
		this.OtherRewardMap.Clear();
		GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(data.GetPackageRewardId());
		if (giftPackageConfig != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair in giftPackageConfig.Value.Content())
			{
				int key = keyValuePair.Key;
				if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(key)) == InventoryDefine.EItemDataType.RoleSkinItem)
				{
					this.RewardSkinId = new int?(key);
				}
				else
				{
					this.OtherRewardMap.Add(key, keyValuePair.Value);
				}
			}
		}
	}

	// Token: 0x0601668A RID: 91786 RVA: 0x005AAC04 File Offset: 0x005A8E04
	public bool GetIfCanBuy()
	{
		if (!this.GetPayShopGoods().IfCanBuy())
		{
			return false;
		}
		PayShopGoodsData goodsData = this.GetPayShopGoods().GetGoodsData();
		if (goodsData != null && goodsData.HasBuyLimit())
		{
			PayShopGoodsData goodsData2 = this.GetPayShopGoods().GetGoodsData();
			if (goodsData2 != null && goodsData2.GetRemainingCount() == 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601668B RID: 91787 RVA: 0x005AAC58 File Offset: 0x005A8E58
	public PayShopGoods GetCurrentGoodsData()
	{
		return this.PayShopGoods;
	}

	// Token: 0x0601668C RID: 91788 RVA: 0x005AAC60 File Offset: 0x005A8E60
	public int GetItemId()
	{
		return this.RewardSkinId.Value;
	}

	// Token: 0x0601668D RID: 91789 RVA: 0x005AAC70 File Offset: 0x005A8E70
	public TItem[] GetAllReward()
	{
		List<TItem> list = new List<TItem>();
		InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(this.GetItemId(), 0);
		TItem item = new TItem(itemData, 1);
		list.Add(item);
		list.AddRange(this.GetOtherReward());
		return list.ToArray();
	}

	// Token: 0x0601668E RID: 91790 RVA: 0x005AACB0 File Offset: 0x005A8EB0
	public TItem[] GetOtherReward()
	{
		List<TItem> list = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in this.OtherRewardMap)
		{
			InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(keyValuePair.Key, 0);
			TItem item = new TItem(itemData, keyValuePair.Value);
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x0601668F RID: 91791 RVA: 0x005AAD30 File Offset: 0x005A8F30
	public PayShopGoods GetPayShopGoods()
	{
		return this.PayShopGoods;
	}

	// Token: 0x06016690 RID: 91792 RVA: 0x005AAD38 File Offset: 0x005A8F38
	public string GetDiscountText()
	{
		PayShopGoods currentGoodsData = this.GetCurrentGoodsData();
		if (!currentGoodsData.HasDiscount())
		{
			return "";
		}
		int discount = currentGoodsData.GetDiscount();
		if (discount > 0)
		{
			return StringUtils.Format("-{0}%", new string[]
			{
				discount.ToString()
			});
		}
		return "";
	}

	// Token: 0x06016691 RID: 91793 RVA: 0x005AAD88 File Offset: 0x005A8F88
	[NullableContext(2)]
	public object GetDiscountTimeData()
	{
		PayShopGoods currentGoodsData = this.GetCurrentGoodsData();
		if (!currentGoodsData.HasDiscount())
		{
			return null;
		}
		ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = currentGoodsData.GetCountDownData();
		if (countDownData.Item1 == EPayCountTimeType.Discount)
		{
			return countDownData.Item2;
		}
		return null;
	}

	// Token: 0x06016692 RID: 91794 RVA: 0x005AADBE File Offset: 0x005A8FBE
	public IPriceData GetPriceData()
	{
		return this.GetCurrentGoodsData().GetPriceData();
	}

	// Token: 0x06016693 RID: 91795 RVA: 0x005AADCB File Offset: 0x005A8FCB
	public bool GetIfDirect()
	{
		return this.GetCurrentGoodsData().IsDirect();
	}

	// Token: 0x06016694 RID: 91796 RVA: 0x005AADD8 File Offset: 0x005A8FD8
	public string GetDirectPriceText()
	{
		return this.GetCurrentGoodsData().GetDirectPriceText();
	}

	// Token: 0x06016695 RID: 91797 RVA: 0x005AADE5 File Offset: 0x005A8FE5
	public RoleSkinData GetRoleSkinData()
	{
		return RoleSkinModel.Instance.GetRoleSkinData(this.GetItemId());
	}

	// Token: 0x06016696 RID: 91798 RVA: 0x005AADF7 File Offset: 0x005A8FF7
	public string GetPayShopPreviewRoleTexturePath()
	{
		return this.GetRoleSkinData().GetPayShopPreviewRoleTexturePath();
	}

	// Token: 0x06016697 RID: 91799 RVA: 0x005AAE04 File Offset: 0x005A9004
	public string GetPayShopPreviewRoleTextureBgPath()
	{
		return this.GetRoleSkinData().GetPayShopPreviewRoleTextureBgPath();
	}

	// Token: 0x06016698 RID: 91800 RVA: 0x005AAE11 File Offset: 0x005A9011
	public string GetPayShopPreviewWeaponTexturePath()
	{
		return this.GetRoleSkinData().GetPayShopPreviewWeaponTexturePath();
	}

	// Token: 0x06016699 RID: 91801 RVA: 0x005AAE1E File Offset: 0x005A901E
	public string GetPayShopPreviewBuyRoleTexturePath()
	{
		return this.GetRoleSkinData().GetPayShopPreviewBuyRoleTexturePath();
	}

	// Token: 0x0601669A RID: 91802 RVA: 0x005AAE2B File Offset: 0x005A902B
	public string GetPayShopPreviewBuyRoleSuitWeaponTexturePath()
	{
		return this.GetRoleSkinData().GetPayShopPreviewBuyRoleSuitWeaponTexturePath();
	}

	// Token: 0x0400A69E RID: 42654
	[Nullable(2)]
	private PayShopGoods PayShopGoods;

	// Token: 0x0400A69F RID: 42655
	private int? RewardSkinId;

	// Token: 0x0400A6A0 RID: 42656
	private readonly Dictionary<int, int> OtherRewardMap = new Dictionary<int, int>();
}
