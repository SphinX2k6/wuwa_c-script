using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039C2 RID: 14786
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseShopData
	{
		// Token: 0x17004DCA RID: 19914
		// (get) Token: 0x0602617F RID: 156031 RVA: 0x00AAF9DD File Offset: 0x00AADBDD
		public List<TrapDefenseShopItemData> ItemGoodsList
		{
			get
			{
				return new List<TrapDefenseShopItemData>(this.ItemGoodsMap.Values);
			}
		}

		// Token: 0x17004DCB RID: 19915
		// (get) Token: 0x06026180 RID: 156032 RVA: 0x00AAF9EF File Offset: 0x00AADBEF
		public List<TrapDefenseShopBuffData> BuffGoodsList
		{
			get
			{
				return new List<TrapDefenseShopBuffData>(this.BuffGoodsMap.Values);
			}
		}

		// Token: 0x06026181 RID: 156033 RVA: 0x00AAFA01 File Offset: 0x00AADC01
		public static TrapDefenseShopData Create()
		{
			TrapDefenseShopData trapDefenseShopData = new TrapDefenseShopData();
			trapDefenseShopData.Init();
			return trapDefenseShopData;
		}

		// Token: 0x06026182 RID: 156034 RVA: 0x00AAFA0E File Offset: 0x00AADC0E
		public void UpdateByServerData(TrapDefenseShopPanelInfo serverData)
		{
			this.ServerDataCache = serverData;
			this.TryUpdateData();
		}

		// Token: 0x06026183 RID: 156035 RVA: 0x00AAFA20 File Offset: 0x00AADC20
		public void TryUpdateData()
		{
			if (this.ServerDataCache == null)
			{
				return;
			}
			TrapDefenseShopPanelInfo serverDataCache = this.ServerDataCache;
			this.TotalRefreshCount = serverDataCache.TotalRefreshTimes;
			this.RemainingRefreshCount = serverDataCache.RemainRefreshTimes;
			this.RefreshCost = serverDataCache.RefreshCost;
			Dictionary<int, bool> dictionary = new Dictionary<int, bool>();
			Dictionary<int, bool> dictionary2 = new Dictionary<int, bool>();
			foreach (TrapDefenseShopProductPbInfo trapDefenseShopProductPbInfo in serverDataCache.ShopProductPbInfos)
			{
				if (trapDefenseShopProductPbInfo.ItemPbInfo != null)
				{
					if (this.ItemGoodsMap.ContainsKey(trapDefenseShopProductPbInfo.ItemPbInfo.ItemConfigId))
					{
						this.ItemGoodsMap[trapDefenseShopProductPbInfo.ItemPbInfo.ItemConfigId].Update(trapDefenseShopProductPbInfo);
					}
					else
					{
						TrapDefenseShopItemData trapDefenseShopItemData = TrapDefenseShopItemData.Create(trapDefenseShopProductPbInfo);
						this.ItemGoodsMap.Add(trapDefenseShopItemData.Id, trapDefenseShopItemData);
					}
					dictionary[trapDefenseShopProductPbInfo.ItemPbInfo.ItemConfigId] = true;
				}
				else if (trapDefenseShopProductPbInfo.BdGroupPbInfo != null)
				{
					if (this.BuffGoodsMap.ContainsKey(trapDefenseShopProductPbInfo.BdGroupPbInfo.BdGrougConfigId))
					{
						this.BuffGoodsMap[trapDefenseShopProductPbInfo.BdGroupPbInfo.BdGrougConfigId].Update(trapDefenseShopProductPbInfo);
					}
					else
					{
						TrapDefenseShopBuffData trapDefenseShopBuffData = TrapDefenseShopBuffData.Create(trapDefenseShopProductPbInfo);
						this.BuffGoodsMap.Add(trapDefenseShopBuffData.Id, trapDefenseShopBuffData);
					}
					dictionary2[trapDefenseShopProductPbInfo.BdGroupPbInfo.BdGrougConfigId] = true;
				}
			}
			foreach (int key in new List<int>(this.ItemGoodsMap.Keys))
			{
				if (!dictionary.ContainsKey(key))
				{
					this.ItemGoodsMap.Remove(key);
				}
			}
			foreach (int key2 in new List<int>(this.BuffGoodsMap.Keys))
			{
				if (!dictionary2.ContainsKey(key2))
				{
					this.BuffGoodsMap.Remove(key2);
				}
			}
			this.ServerDataCache = null;
		}

		// Token: 0x06026184 RID: 156036 RVA: 0x00AAFC7C File Offset: 0x00AADE7C
		public int SortGoods(ITrapDefenseShopGoods a, ITrapDefenseShopGoods b)
		{
			if (a.Disable != b.Disable)
			{
				if (!a.Disable)
				{
					return -1;
				}
				return 1;
			}
			else
			{
				float num = (float)((a.CurrentPrice != 0) ? a.CurrentPrice : 1) / (float)((a.OriginalPrice.GetValueOrDefault() != 0) ? a.OriginalPrice.Value : 1);
				float num2 = (float)((b.CurrentPrice != 0) ? b.CurrentPrice : 1) / (float)((b.OriginalPrice.GetValueOrDefault() != 0) ? b.OriginalPrice.Value : 1);
				if (num != num2)
				{
					if (num - num2 <= 0f)
					{
						return -1;
					}
					return 1;
				}
				else
				{
					if (a.QualityId != b.QualityId)
					{
						return b.QualityId.CompareTo(a.QualityId);
					}
					return a.Id.CompareTo(b.Id);
				}
			}
		}

		// Token: 0x06026185 RID: 156037 RVA: 0x00AAFD58 File Offset: 0x00AADF58
		private void Init()
		{
		}

		// Token: 0x04014EA0 RID: 85664
		public Dictionary<int, TrapDefenseShopItemData> ItemGoodsMap = new Dictionary<int, TrapDefenseShopItemData>();

		// Token: 0x04014EA1 RID: 85665
		public Dictionary<int, TrapDefenseShopBuffData> BuffGoodsMap = new Dictionary<int, TrapDefenseShopBuffData>();

		// Token: 0x04014EA2 RID: 85666
		[Nullable(2)]
		public TrapDefenseShopPanelInfo ServerDataCache;

		// Token: 0x04014EA3 RID: 85667
		public int TotalRefreshCount;

		// Token: 0x04014EA4 RID: 85668
		public int RemainingRefreshCount;

		// Token: 0x04014EA5 RID: 85669
		public int RefreshCost;
	}
}
