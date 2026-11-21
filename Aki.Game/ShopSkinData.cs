using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02001F9D RID: 8093
[NullableContext(1)]
[Nullable(0)]
public class ShopSkinData
{
	// Token: 0x0601408E RID: 82062 RVA: 0x005D5B0D File Offset: 0x005D3D0D
	public static ShopSkinData Create(PayShopGoods data)
	{
		ShopSkinData shopSkinData = new ShopSkinData();
		shopSkinData.InitData(data);
		return shopSkinData;
	}

	// Token: 0x0601408F RID: 82063 RVA: 0x005D5B1C File Offset: 0x005D3D1C
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

	// Token: 0x06014090 RID: 82064 RVA: 0x005D5BE0 File Offset: 0x005D3DE0
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

	// Token: 0x06014091 RID: 82065 RVA: 0x005D5C34 File Offset: 0x005D3E34
	public PayShopGoods GetCurrentGoodsData()
	{
		return this.PayShopGoods;
	}

	// Token: 0x06014092 RID: 82066 RVA: 0x005D5C3C File Offset: 0x005D3E3C
	public int GetItemId()
	{
		return this.RewardSkinId.Value;
	}

	// Token: 0x06014093 RID: 82067 RVA: 0x005D5C4C File Offset: 0x005D3E4C
	public TItem[] GetAllReward()
	{
		List<TItem> list = new List<TItem>();
		InventoryDefine.GetItemData itemData = new InventoryDefine.GetItemData(this.GetItemId(), 0);
		TItem item = new TItem(itemData, 1);
		list.Add(item);
		list.AddRange(this.GetOtherReward());
		return list.ToArray();
	}

	// Token: 0x06014094 RID: 82068 RVA: 0x005D5C8C File Offset: 0x005D3E8C
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

	// Token: 0x06014095 RID: 82069 RVA: 0x005D5D0C File Offset: 0x005D3F0C
	public PayShopGoods GetPayShopGoods()
	{
		return this.PayShopGoods;
	}

	// Token: 0x06014096 RID: 82070 RVA: 0x005D5D14 File Offset: 0x005D3F14
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

	// Token: 0x06014097 RID: 82071 RVA: 0x005D5D64 File Offset: 0x005D3F64
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

	// Token: 0x06014098 RID: 82072 RVA: 0x005D5D9A File Offset: 0x005D3F9A
	public IPriceData GetPriceData()
	{
		return this.GetCurrentGoodsData().GetPriceData();
	}

	// Token: 0x06014099 RID: 82073 RVA: 0x005D5DA7 File Offset: 0x005D3FA7
	public bool GetIfDirect()
	{
		return this.GetCurrentGoodsData().IsDirect();
	}

	// Token: 0x0601409A RID: 82074 RVA: 0x005D5DB4 File Offset: 0x005D3FB4
	public string GetDirectPriceText()
	{
		return this.GetCurrentGoodsData().GetDirectPriceText();
	}

	// Token: 0x0601409B RID: 82075 RVA: 0x005D5DC1 File Offset: 0x005D3FC1
	public RoleSkinData GetRoleSkinData()
	{
		return RoleSkinModel.Instance.GetRoleSkinData(this.GetItemId());
	}

	// Token: 0x0601409C RID: 82076 RVA: 0x005D5DD3 File Offset: 0x005D3FD3
	public string GetPayShopPreviewRoleTexturePath()
	{
		return this.GetRoleSkinData().GetPayShopPreviewRoleTexturePath();
	}

	// Token: 0x0601409D RID: 82077 RVA: 0x005D5DE0 File Offset: 0x005D3FE0
	public string GetPayShopPreviewRoleTextureBgPath()
	{
		return this.GetRoleSkinData().GetPayShopPreviewRoleTextureBgPath();
	}

	// Token: 0x0601409E RID: 82078 RVA: 0x005D5DED File Offset: 0x005D3FED
	public string GetPayShopPreviewWeaponTexturePath()
	{
		return this.GetRoleSkinData().GetPayShopPreviewWeaponTexturePath();
	}

	// Token: 0x0601409F RID: 82079 RVA: 0x005D5DFA File Offset: 0x005D3FFA
	public string GetPayShopPreviewBuyRoleTexturePath()
	{
		return this.GetRoleSkinData().GetPayShopPreviewBuyRoleTexturePath();
	}

	// Token: 0x060140A0 RID: 82080 RVA: 0x005D5E07 File Offset: 0x005D4007
	public string GetPayShopPreviewBuyRoleSuitWeaponTexturePath()
	{
		return this.GetRoleSkinData().GetPayShopPreviewBuyRoleSuitWeaponTexturePath();
	}

	// Token: 0x0400AA87 RID: 43655
	[Nullable(2)]
	private PayShopGoods PayShopGoods;

	// Token: 0x0400AA88 RID: 43656
	private int? RewardSkinId;

	// Token: 0x0400AA89 RID: 43657
	private readonly Dictionary<int, int> OtherRewardMap = new Dictionary<int, int>();
}
