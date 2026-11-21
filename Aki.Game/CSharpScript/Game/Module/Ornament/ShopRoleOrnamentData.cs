using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;

namespace CSharpScript.Game.Module.Ornament
{
	// Token: 0x02004340 RID: 17216
	[NullableContext(1)]
	[Nullable(0)]
	public class ShopRoleOrnamentData
	{
		// Token: 0x0602B794 RID: 178068 RVA: 0x00C37DA6 File Offset: 0x00C35FA6
		public static ShopRoleOrnamentData Create(PayShopGoods data)
		{
			ShopRoleOrnamentData shopRoleOrnamentData = new ShopRoleOrnamentData();
			shopRoleOrnamentData.InitData(data);
			return shopRoleOrnamentData;
		}

		// Token: 0x0602B795 RID: 178069 RVA: 0x00C37DB4 File Offset: 0x00C35FB4
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

		// Token: 0x0602B796 RID: 178070 RVA: 0x00C37EA8 File Offset: 0x00C360A8
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

		// Token: 0x0602B797 RID: 178071 RVA: 0x00C37EFC File Offset: 0x00C360FC
		public PayShopGoods GetCurrentGoodsData()
		{
			return this.PayShopGoods;
		}

		// Token: 0x0602B798 RID: 178072 RVA: 0x00C37F04 File Offset: 0x00C36104
		public PayShopGoods GetPayShopGoods()
		{
			return this.PayShopGoods;
		}

		// Token: 0x0602B799 RID: 178073 RVA: 0x00C37F0C File Offset: 0x00C3610C
		public int GetItemId()
		{
			return this.OrnamentId;
		}

		// Token: 0x0602B79A RID: 178074 RVA: 0x00C37F14 File Offset: 0x00C36114
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

		// Token: 0x0602B79B RID: 178075 RVA: 0x00C37F80 File Offset: 0x00C36180
		public List<TItem> GetAllReward()
		{
			List<TItem> list = new List<TItem>();
			list.Add(new TItem(new InventoryDefine.GetItemData(this.GetItemId(), 0), 1));
			list.AddRange(this.GetOtherReward());
			return list;
		}

		// Token: 0x0602B79C RID: 178076 RVA: 0x00C37FAC File Offset: 0x00C361AC
		public List<TItem> GetOtherReward()
		{
			List<TItem> list = new List<TItem>();
			foreach (KeyValuePair<int, int> keyValuePair in this.OtherRewardMap)
			{
				list.Add(new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value));
			}
			return list;
		}

		// Token: 0x0602B79D RID: 178077 RVA: 0x00C38020 File Offset: 0x00C36220
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

		// Token: 0x0602B79E RID: 178078 RVA: 0x00C38070 File Offset: 0x00C36270
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

		// Token: 0x0602B79F RID: 178079 RVA: 0x00C380A6 File Offset: 0x00C362A6
		public IPriceData GetPriceData()
		{
			return this.GetCurrentGoodsData().GetPriceData();
		}

		// Token: 0x0602B7A0 RID: 178080 RVA: 0x00C380B3 File Offset: 0x00C362B3
		public bool GetIfDirect()
		{
			return this.GetCurrentGoodsData().IsDirect();
		}

		// Token: 0x0602B7A1 RID: 178081 RVA: 0x00C380C0 File Offset: 0x00C362C0
		public string GetDirectPriceText()
		{
			return this.GetCurrentGoodsData().GetDirectPriceText();
		}

		// Token: 0x0602B7A2 RID: 178082 RVA: 0x00C380CD File Offset: 0x00C362CD
		public string GetTitleName()
		{
			return this.GetRoleOrnamentData().GetTitleName();
		}

		// Token: 0x0602B7A3 RID: 178083 RVA: 0x00C380DA File Offset: 0x00C362DA
		public string GetPreviewTextureInPayShop()
		{
			return this.GetRoleOrnamentData().GetPreviewTextureInPayShop();
		}

		// Token: 0x0602B7A4 RID: 178084 RVA: 0x00C380E7 File Offset: 0x00C362E7
		public RoleOrnamentData GetRoleOrnamentData()
		{
			return RoleOrnamentModel.Instance.GetRoleOrnamentData(this.GetItemId());
		}

		// Token: 0x040177E4 RID: 96228
		[Nullable(2)]
		private PayShopGoods PayShopGoods;

		// Token: 0x040177E5 RID: 96229
		private int OrnamentId;

		// Token: 0x040177E6 RID: 96230
		private readonly Dictionary<int, int> OtherRewardMap = new Dictionary<int, int>();
	}
}
