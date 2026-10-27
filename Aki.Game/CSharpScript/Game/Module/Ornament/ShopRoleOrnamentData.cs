using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;

namespace CSharpScript.Game.Module.Ornament
{
	// Token: 0x0200535D RID: 21341
	[NullableContext(1)]
	[Nullable(0)]
	public class ShopRoleOrnamentData
	{
		// Token: 0x0603684E RID: 223310 RVA: 0x00CE8F1E File Offset: 0x00CE711E
		public static ShopRoleOrnamentData Create(PayShopGoods data)
		{
			ShopRoleOrnamentData shopRoleOrnamentData = new ShopRoleOrnamentData();
			shopRoleOrnamentData.InitData(data);
			return shopRoleOrnamentData;
		}

		// Token: 0x0603684F RID: 223311 RVA: 0x00CE8F2C File Offset: 0x00CE712C
		public void InitData(PayShopGoods data)
		{
			this.PayShopGoods = data;
			this.OtherRewardMap.Clear();
			this.OrnamentId = data.GetRewardOrnamentId();
			if (this.OrnamentId == 0)
			{
				return;
			}
			if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(data.GetGoodsData().ItemId)) == InventoryDefine.EItemDataType.OrnamentItem)
			{
				return;
			}
			int packageRewardId = data.GetPackageRewardId();
			if (packageRewardId == 0)
			{
				return;
			}
			GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(packageRewardId);
			if (giftPackageConfig == null)
			{
				return;
			}
			foreach (KeyValuePair<int, int> keyValuePair in giftPackageConfig.Value.Content())
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(key)) != InventoryDefine.EItemDataType.OrnamentItem)
				{
					this.OtherRewardMap[key] = value;
				}
			}
		}

		// Token: 0x06036850 RID: 223312 RVA: 0x00CE9020 File Offset: 0x00CE7220
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

		// Token: 0x06036851 RID: 223313 RVA: 0x00CE9074 File Offset: 0x00CE7274
		public PayShopGoods GetCurrentGoodsData()
		{
			return this.PayShopGoods;
		}

		// Token: 0x06036852 RID: 223314 RVA: 0x00CE907C File Offset: 0x00CE727C
		public PayShopGoods GetPayShopGoods()
		{
			return this.PayShopGoods;
		}

		// Token: 0x06036853 RID: 223315 RVA: 0x00CE9084 File Offset: 0x00CE7284
		public int GetItemId()
		{
			return this.OrnamentId;
		}

		// Token: 0x06036854 RID: 223316 RVA: 0x00CE908C File Offset: 0x00CE728C
		[return: TupleElementNames(new string[]
		{
			"ItemId",
			"Count"
		})]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public List<ValueTuple<int, int>> GetOtherRewardSimple()
		{
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			foreach (KeyValuePair<int, int> keyValuePair in this.OtherRewardMap)
			{
				list.Add(new ValueTuple<int, int>(keyValuePair.Key, keyValuePair.Value));
			}
			return list;
		}

		// Token: 0x06036855 RID: 223317 RVA: 0x00CE90F8 File Offset: 0x00CE72F8
		public List<TItem> GetAllReward()
		{
			List<TItem> list = new List<TItem>();
			list.Add(new TItem(new InventoryDefine.GetItemData(this.GetItemId(), 0), 1));
			list.AddRange(this.GetOtherReward());
			return list;
		}

		// Token: 0x06036856 RID: 223318 RVA: 0x00CE9124 File Offset: 0x00CE7324
		public List<TItem> GetOtherReward()
		{
			List<TItem> list = new List<TItem>();
			foreach (KeyValuePair<int, int> keyValuePair in this.OtherRewardMap)
			{
				list.Add(new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value));
			}
			return list;
		}

		// Token: 0x06036857 RID: 223319 RVA: 0x00CE9198 File Offset: 0x00CE7398
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

		// Token: 0x06036858 RID: 223320 RVA: 0x00CE91E8 File Offset: 0x00CE73E8
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

		// Token: 0x06036859 RID: 223321 RVA: 0x00CE921E File Offset: 0x00CE741E
		public IPriceData GetPriceData()
		{
			return this.GetCurrentGoodsData().GetPriceData();
		}

		// Token: 0x0603685A RID: 223322 RVA: 0x00CE922B File Offset: 0x00CE742B
		public bool GetIfDirect()
		{
			return this.GetCurrentGoodsData().IsDirect();
		}

		// Token: 0x0603685B RID: 223323 RVA: 0x00CE9238 File Offset: 0x00CE7438
		public string GetDirectPriceText()
		{
			return this.GetCurrentGoodsData().GetDirectPriceText();
		}

		// Token: 0x0603685C RID: 223324 RVA: 0x00CE9245 File Offset: 0x00CE7445
		public string GetTitleName()
		{
			return this.GetRoleOrnamentData().GetTitleName();
		}

		// Token: 0x0603685D RID: 223325 RVA: 0x00CE9252 File Offset: 0x00CE7452
		public string GetPreviewTextureInPayShop()
		{
			return this.GetRoleOrnamentData().GetPreviewTextureInPayShop();
		}

		// Token: 0x0603685E RID: 223326 RVA: 0x00CE925F File Offset: 0x00CE745F
		public RoleOrnamentData GetRoleOrnamentData()
		{
			return RoleOrnamentModel.Instance.GetRoleOrnamentData(this.GetItemId());
		}

		// Token: 0x0401CD50 RID: 118096
		[Nullable(2)]
		private PayShopGoods PayShopGoods;

		// Token: 0x0401CD51 RID: 118097
		private int OrnamentId;

		// Token: 0x0401CD52 RID: 118098
		private readonly Dictionary<int, int> OtherRewardMap = new Dictionary<int, int>();
	}
}
