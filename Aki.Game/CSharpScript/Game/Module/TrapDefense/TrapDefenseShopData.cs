using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A1A RID: 18970
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseShopData
	{
		// Token: 0x17007A1D RID: 31261
		// (get) Token: 0x060313EF RID: 201711 RVA: 0x00B6B9E1 File Offset: 0x00B69BE1
		public List<TrapDefenseShopItemData> ItemGoodsList
		{
			get
			{
				return new List<TrapDefenseShopItemData>(this.ItemGoodsMap.Values);
			}
		}

		// Token: 0x17007A1E RID: 31262
		// (get) Token: 0x060313F0 RID: 201712 RVA: 0x00B6B9F3 File Offset: 0x00B69BF3
		public List<TrapDefenseShopBuffData> BuffGoodsList
		{
			get
			{
				return new List<TrapDefenseShopBuffData>(this.BuffGoodsMap.Values);
			}
		}

		// Token: 0x060313F1 RID: 201713 RVA: 0x00B6BA05 File Offset: 0x00B69C05
		public static TrapDefenseShopData Create()
		{
			TrapDefenseShopData trapDefenseShopData = new TrapDefenseShopData();
			trapDefenseShopData.Init();
			return trapDefenseShopData;
		}

		// Token: 0x060313F2 RID: 201714 RVA: 0x00B6BA12 File Offset: 0x00B69C12
		public void UpdateByServerData(TrapDefenseShopPanelInfo serverData)
		{
			this.ServerDataCache = serverData;
			this.TryUpdateData();
		}

		// Token: 0x060313F3 RID: 201715 RVA: 0x00B6BA24 File Offset: 0x00B69C24
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

		// Token: 0x060313F4 RID: 201716 RVA: 0x00B6BC80 File Offset: 0x00B69E80
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

		// Token: 0x060313F5 RID: 201717 RVA: 0x00B6BD5C File Offset: 0x00B69F5C
		private void Init()
		{
		}

		// Token: 0x0401A549 RID: 107849
		public Dictionary<int, TrapDefenseShopItemData> ItemGoodsMap = new Dictionary<int, TrapDefenseShopItemData>();

		// Token: 0x0401A54A RID: 107850
		public Dictionary<int, TrapDefenseShopBuffData> BuffGoodsMap = new Dictionary<int, TrapDefenseShopBuffData>();

		// Token: 0x0401A54B RID: 107851
		[Nullable(2)]
		public TrapDefenseShopPanelInfo ServerDataCache;

		// Token: 0x0401A54C RID: 107852
		public int TotalRefreshCount;

		// Token: 0x0401A54D RID: 107853
		public int RemainingRefreshCount;

		// Token: 0x0401A54E RID: 107854
		public int RefreshCost;
	}
}
