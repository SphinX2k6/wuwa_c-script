using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058E1 RID: 22753
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolShopData : SolarSchoolRecordBase
	{
		// Token: 0x0603811E RID: 229662 RVA: 0x00FAC0CC File Offset: 0x00FAA2CC
		public List<SolarSchoolShopGoodsData> GetVisibleGoodsList()
		{
			List<SolarSchoolShopGoodsData> list = new List<SolarSchoolShopGoodsData>(this.GoodsList);
			for (int i = list.Count - 1; i >= 0; i--)
			{
				int showConditionId = list[i].Goods.ShowConditionId;
				if (!this.IsShopAvailable(list[i].ShopId) || (showConditionId != 0 && !ActivityConditionCenter.Instance.CheckGroup(showConditionId)))
				{
					list.RemoveAt(i);
				}
			}
			List<SolarSchoolShopGoodsData> list2 = list;
			Comparison<SolarSchoolShopGoodsData> comparison;
			if ((comparison = SolarSchoolShopData.<>O.<0>__CompareShopGoodsById) == null)
			{
				comparison = (SolarSchoolShopData.<>O.<0>__CompareShopGoodsById = new Comparison<SolarSchoolShopGoodsData>(SolarSchoolShopData.CompareShopGoodsById));
			}
			list2.Sort(comparison);
			return list;
		}

		// Token: 0x0603811F RID: 229663 RVA: 0x00FAC15C File Offset: 0x00FAA35C
		private static int CompareShopGoodsById(SolarSchoolShopGoodsData first, SolarSchoolShopGoodsData second)
		{
			return first.Goods.Id.CompareTo(second.Goods.Id);
		}

		// Token: 0x06038120 RID: 229664 RVA: 0x00FAC190 File Offset: 0x00FAA390
		[NullableContext(2)]
		public SolarSchoolShopGoodsData GetGoods(int shopId, int goodsId)
		{
			if (!this.IsShopAvailable(shopId))
			{
				return null;
			}
			foreach (SolarSchoolShopGoodsData solarSchoolShopGoodsData in this.GoodsList)
			{
				if (solarSchoolShopGoodsData.ShopId == shopId && solarSchoolShopGoodsData.Goods.Id == goodsId)
				{
					return solarSchoolShopGoodsData;
				}
			}
			return null;
		}

		// Token: 0x06038121 RID: 229665 RVA: 0x00FAC208 File Offset: 0x00FAA408
		[NullableContext(2)]
		public int GetBoughtCount(int shopId, IReadOnlyCollection<int> goodsIds = null)
		{
			SolarSchoolShop? shop = SolarSchoolConfig.Instance.GetShop(shopId);
			SolarSchoolShopData.ShopRuntimeData shopRuntimeData;
			if (shop == null || !this.ShopDataMap.TryGetValue(shopId, out shopRuntimeData) || shopRuntimeData.RefreshCycleIndex != this.GetShopRefreshCycleIndex(SolarSchoolGamePlayModel.Instance.TimeData.GetCurrentWeek(), shop.Value.RefreshIntervalDays))
			{
				return 0;
			}
			HashSet<int> hashSet = (goodsIds == null) ? null : new HashSet<int>(goodsIds);
			long num = 0L;
			if (shopRuntimeData.GoodsList.Count == 0)
			{
				using (IEnumerator<KeyValuePair<int, int>> enumerator = shopRuntimeData.BoughtCountMap.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<int, int> keyValuePair = enumerator.Current;
						if (hashSet == null || hashSet.Contains(keyValuePair.Key))
						{
							num += (long)keyValuePair.Value;
						}
					}
					goto IL_135;
				}
			}
			HashSet<int> hashSet2 = new HashSet<int>();
			foreach (SolarSchoolShopGoodsData solarSchoolShopGoodsData in shopRuntimeData.GoodsList)
			{
				if (hashSet2.Add(solarSchoolShopGoodsData.Goods.Id) && (hashSet == null || hashSet.Contains(solarSchoolShopGoodsData.Goods.Id)))
				{
					num += (long)solarSchoolShopGoodsData.BoughtCount;
				}
			}
			IL_135:
			return (int)Math.Min(num, 2147483647L);
		}

		// Token: 0x06038122 RID: 229666 RVA: 0x00FAC374 File Offset: 0x00FAA574
		public bool ShouldShowEntryTip()
		{
			return this.GoodsList.Count > 0 && !this.HasEnteredCurrentRefreshCycle;
		}

		// Token: 0x06038123 RID: 229667 RVA: 0x00FAC38F File Offset: 0x00FAA58F
		public void MarkCurrentCycleEntered()
		{
			if (this.GoodsList.Count > 0)
			{
				this.HasEnteredCurrentRefreshCycle = true;
			}
		}

		// Token: 0x06038124 RID: 229668 RVA: 0x00FAC3A8 File Offset: 0x00FAA5A8
		public bool IsShopOpen()
		{
			IReadOnlyList<SolarSchoolShop> shopListByActivityId = SolarSchoolConfig.Instance.GetShopListByActivityId(SolarSchoolGamePlayModel.Instance.ActivityId);
			if (shopListByActivityId == null || shopListByActivityId.Count == 0)
			{
				return false;
			}
			foreach (SolarSchoolShop shop in shopListByActivityId)
			{
				if (this.IsShopAvailable(shop))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06038125 RID: 229669 RVA: 0x00FAC41C File Offset: 0x00FAA61C
		public void Restore()
		{
			this.HasEnteredCurrentRefreshCycle = false;
			this.GoodsList.Clear();
			this.ShopDataMap.Clear();
		}

		// Token: 0x06038126 RID: 229670 RVA: 0x00FAC43B File Offset: 0x00FAA63B
		public void Reset()
		{
			this.Restore();
		}

		// Token: 0x06038127 RID: 229671 RVA: 0x00FAC444 File Offset: 0x00FAA644
		public bool Refresh(int activityId, int currentWeek)
		{
			IReadOnlyList<SolarSchoolShop> shopListByActivityId = SolarSchoolConfig.Instance.GetShopListByActivityId(activityId);
			if (shopListByActivityId == null || shopListByActivityId.Count == 0)
			{
				return false;
			}
			bool flag = false;
			HashSet<int> hashSet = new HashSet<int>();
			foreach (SolarSchoolShop solarSchoolShop in shopListByActivityId)
			{
				hashSet.Add(solarSchoolShop.Id);
			}
			List<int> list = new List<int>();
			foreach (int item in this.ShopDataMap.Keys)
			{
				if (!hashSet.Contains(item))
				{
					list.Add(item);
				}
			}
			foreach (int key in list)
			{
				this.ShopDataMap.Remove(key);
				flag = true;
			}
			bool result = false;
			bool flag2 = false;
			foreach (SolarSchoolShop shop in shopListByActivityId)
			{
				int shopRefreshCycleIndex = this.GetShopRefreshCycleIndex(currentWeek, shop.RefreshIntervalDays);
				SolarSchoolShopData.ShopRuntimeData shopRuntimeData;
				if (this.ShopDataMap.TryGetValue(shop.Id, out shopRuntimeData) && shopRuntimeData.RefreshCycleIndex == shopRefreshCycleIndex && shopRuntimeData.GoodsList.Count > 0)
				{
					result = true;
				}
				else
				{
					int shopRefreshWeek = this.GetShopRefreshWeek(currentWeek, shop.RefreshIntervalDays);
					SolarSchoolShopRefresh? shopRefresh = SolarSchoolConfig.Instance.GetShopRefresh(shop.Id, shopRefreshWeek);
					if (shopRefresh == null)
					{
						flag |= this.ShopDataMap.Remove(shop.Id);
					}
					else
					{
						int randomSeed = this.CreateRandomSeed();
						IReadOnlyDictionary<int, int> boughtCountMap = null;
						if (shopRuntimeData != null && shopRuntimeData.RefreshCycleIndex == shopRefreshCycleIndex)
						{
							randomSeed = shopRuntimeData.RandomSeed;
							boughtCountMap = shopRuntimeData.BoughtCountMap;
						}
						List<SolarSchoolShopGoodsData> goodsList = this.GenerateShopGoods(shop, shopRefresh.Value, currentWeek, randomSeed, boughtCountMap);
						this.ShopDataMap[shop.Id] = new SolarSchoolShopData.ShopRuntimeData(randomSeed, shopRefreshCycleIndex, goodsList, null);
						result = true;
						flag2 = true;
						flag = true;
					}
				}
			}
			if (flag)
			{
				this.RebuildGoodsList(shopListByActivityId);
			}
			if (flag2)
			{
				this.HasEnteredCurrentRefreshCycle = false;
			}
			return result;
		}

		// Token: 0x06038128 RID: 229672 RVA: 0x00FAC6DC File Offset: 0x00FAA8DC
		private bool IsShopAvailable(int shopId)
		{
			SolarSchoolShop? shop = SolarSchoolConfig.Instance.GetShop(shopId);
			return shop != null && this.IsShopAvailable(shop.Value);
		}

		// Token: 0x06038129 RID: 229673 RVA: 0x00FAC70D File Offset: 0x00FAA90D
		private bool IsShopAvailable(SolarSchoolShop shop)
		{
			return SolarSchoolGamePlayModel.Instance.MapData.IsLocationAvailable(shop.LocationId) && (shop.OpenConditionId == 0 || ActivityConditionCenter.Instance.CheckGroup(shop.OpenConditionId));
		}

		// Token: 0x0603812A RID: 229674 RVA: 0x00FAC748 File Offset: 0x00FAA948
		private unsafe List<SolarSchoolShopGoodsData> GenerateShopGoods(SolarSchoolShop shop, SolarSchoolShopRefresh refresh, int currentWeek, int randomSeed, [Nullable(2)] IReadOnlyDictionary<int, int> boughtCountMap)
		{
			uint num = (uint)randomSeed;
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			for (int i = 0; i < refresh.GroupWeightsLength; i++)
			{
				DicIntInt? dicIntInt = refresh.GroupWeights(i);
				if (dicIntInt != null)
				{
					list.Add(new ValueTuple<int, int>(dicIntInt.Value.Key, dicIntInt.Value.Value));
				}
			}
			int num2 = this.PickGroup(list, SolarSchoolShopData.NextRandom(ref num));
			if (num2 == 0)
			{
				return new List<SolarSchoolShopGoodsData>();
			}
			List<SolarSchoolShopGoods> list2 = new List<SolarSchoolShopGoods>();
			IReadOnlyList<SolarSchoolShopGoods> shopGoodsListByGroupId = SolarSchoolConfig.Instance.GetShopGoodsListByGroupId(num2);
			if (shopGoodsListByGroupId != null)
			{
				list2.AddRange(shopGoodsListByGroupId);
			}
			List<SolarSchoolShopGoods> list3 = this.PickGoods(list2, shop.GroupMaxCount, ref num);
			List<SolarSchoolShopGoodsData> list4 = new List<SolarSchoolShopGoodsData>();
			foreach (SolarSchoolShopGoods goods in list3)
			{
				SolarSchoolItem? item = SolarSchoolConfig.Instance.GetItem(goods.ItemId);
				if (item != null)
				{
					int boughtCount = 0;
					if (boughtCountMap != null)
					{
						boughtCount = boughtCountMap.GetValueOrDefault(goods.Id, 0);
					}
					list4.Add(new SolarSchoolShopGoodsData(shop.Id, goods, item.Value, boughtCount));
				}
			}
			List<int> list5 = new List<int>(list4.Count);
			foreach (SolarSchoolShopGoodsData solarSchoolShopGoodsData in list4)
			{
				list5.Add(solarSchoolShopGoodsData.Goods.Id);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 商店刷新";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("shopId", shop.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("currentWeek", currentWeek);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("refreshWeek", refresh.Week);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("groupId", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("goodsIds", string.Join<int>(",", list5));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("randomSeed", randomSeed);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			return list4;
		}

		// Token: 0x0603812B RID: 229675 RVA: 0x00FAC9D8 File Offset: 0x00FAABD8
		private void RebuildGoodsList(IReadOnlyList<SolarSchoolShop> shops)
		{
			this.GoodsList.Clear();
			foreach (SolarSchoolShop solarSchoolShop in shops)
			{
				SolarSchoolShopData.ShopRuntimeData shopRuntimeData;
				if (this.ShopDataMap.TryGetValue(solarSchoolShop.Id, out shopRuntimeData))
				{
					this.GoodsList.AddRange(shopRuntimeData.GoodsList);
				}
			}
		}

		// Token: 0x0603812C RID: 229676 RVA: 0x00FACA4C File Offset: 0x00FAAC4C
		private int CreateRandomSeed()
		{
			int randomInteger = RandomSystem.GetRandomInteger();
			if (randomInteger == 0)
			{
				return 1;
			}
			return randomInteger;
		}

		// Token: 0x0603812D RID: 229677 RVA: 0x00FACA68 File Offset: 0x00FAAC68
		private int PickGroup([TupleElementNames(new string[]
		{
			"GroupId",
			"Weight"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] IReadOnlyList<ValueTuple<int, int>> groups, uint roll)
		{
			long num = 0L;
			foreach (ValueTuple<int, int> valueTuple in groups)
			{
				if (valueTuple.Item2 > 0)
				{
					num += (long)valueTuple.Item2;
				}
			}
			if (num == 0L)
			{
				return 0;
			}
			long num2 = (long)((ulong)roll % (ulong)num);
			foreach (ValueTuple<int, int> valueTuple2 in groups)
			{
				if (valueTuple2.Item2 > 0)
				{
					if (num2 < (long)valueTuple2.Item2)
					{
						return valueTuple2.Item1;
					}
					num2 -= (long)valueTuple2.Item2;
				}
			}
			return 0;
		}

		// Token: 0x0603812E RID: 229678 RVA: 0x00FACB2C File Offset: 0x00FAAD2C
		private List<SolarSchoolShopGoods> PickGoods(IReadOnlyList<SolarSchoolShopGoods> goodsList, int maxCount, ref uint randomState)
		{
			List<SolarSchoolShopGoods> list = new List<SolarSchoolShopGoods>(goodsList);
			if (maxCount <= 0 || list.Count <= maxCount)
			{
				return list;
			}
			for (int i = 0; i < maxCount; i++)
			{
				int num = i + (int)(SolarSchoolShopData.NextRandom(ref randomState) % (uint)(list.Count - i));
				List<SolarSchoolShopGoods> list2 = list;
				int index = i;
				List<SolarSchoolShopGoods> list3 = list;
				int index2 = num;
				SolarSchoolShopGoods value = list[num];
				SolarSchoolShopGoods value2 = list[i];
				list2[index] = value;
				list3[index2] = value2;
			}
			list.RemoveRange(maxCount, list.Count - maxCount);
			return list;
		}

		// Token: 0x0603812F RID: 229679 RVA: 0x00FACBAB File Offset: 0x00FAADAB
		private static uint NextRandom(ref uint randomState)
		{
			randomState ^= randomState << 13;
			randomState ^= randomState >> 17;
			randomState ^= randomState << 5;
			return randomState;
		}

		// Token: 0x06038130 RID: 229680 RVA: 0x00FACBCC File Offset: 0x00FAADCC
		private int GetShopRefreshCycleIndex(int currentWeek, int refreshIntervalDays)
		{
			int num = SolarSchoolShopData.GetMondayAlignedInterval(refreshIntervalDays) / 7;
			return (Math.Max(1, currentWeek) - 1) / num + 1;
		}

		// Token: 0x06038131 RID: 229681 RVA: 0x00FACBF0 File Offset: 0x00FAADF0
		private int GetShopRefreshWeek(int currentWeek, int refreshIntervalDays)
		{
			int num = SolarSchoolShopData.GetMondayAlignedInterval(refreshIntervalDays) / 7;
			return (Math.Max(1, currentWeek) - 1) / num * num + 1;
		}

		// Token: 0x06038132 RID: 229682 RVA: 0x00FACC18 File Offset: 0x00FAAE18
		public int GetShopRefreshRemainingDays(int dayIndex)
		{
			IReadOnlyList<SolarSchoolShop> shopListByActivityId = SolarSchoolConfig.Instance.GetShopListByActivityId(SolarSchoolGamePlayModel.Instance.ActivityId);
			if (shopListByActivityId == null || shopListByActivityId.Count == 0)
			{
				return 0;
			}
			int num = Math.Max(1, dayIndex);
			int firstMondayDayIndex = SolarSchoolUtils.GetFirstMondayDayIndex();
			if (num < firstMondayDayIndex)
			{
				return firstMondayDayIndex - num;
			}
			int num2 = int.MaxValue;
			foreach (SolarSchoolShop solarSchoolShop in shopListByActivityId)
			{
				int mondayAlignedInterval = SolarSchoolShopData.GetMondayAlignedInterval(solarSchoolShop.RefreshIntervalDays);
				num2 = Math.Min(num2, mondayAlignedInterval - (num - firstMondayDayIndex) % mondayAlignedInterval);
			}
			return num2;
		}

		// Token: 0x06038133 RID: 229683 RVA: 0x00FACCBC File Offset: 0x00FAAEBC
		private static int GetMondayAlignedInterval(int intervalDays)
		{
			return (Math.Max(1, intervalDays) + 7 - 1) / 7 * 7;
		}

		// Token: 0x06038134 RID: 229684 RVA: 0x00FACCD0 File Offset: 0x00FAAED0
		public override void Serialize(SolarSchoolSaveGamePb gameData)
		{
			SolarSchoolShopDataPb solarSchoolShopDataPb = new SolarSchoolShopDataPb();
			foreach (KeyValuePair<int, SolarSchoolShopData.ShopRuntimeData> keyValuePair in this.ShopDataMap)
			{
				SolarSchoolShopData.ShopRuntimeData value = keyValuePair.Value;
				SolarSchoolShopRuntimeDataPb solarSchoolShopRuntimeDataPb = new SolarSchoolShopRuntimeDataPb();
				solarSchoolShopRuntimeDataPb.ShopId = keyValuePair.Key;
				solarSchoolShopRuntimeDataPb.RandomSeed = value.RandomSeed;
				solarSchoolShopRuntimeDataPb.RefreshCycleIndex = value.RefreshCycleIndex;
				foreach (SolarSchoolShopGoodsData solarSchoolShopGoodsData in value.GoodsList)
				{
					if (solarSchoolShopGoodsData.BoughtCount > 0)
					{
						SolarSchoolShopGoodsBuyDataPb solarSchoolShopGoodsBuyDataPb = new SolarSchoolShopGoodsBuyDataPb();
						solarSchoolShopGoodsBuyDataPb.GoodsId = solarSchoolShopGoodsData.Goods.Id;
						solarSchoolShopGoodsBuyDataPb.BoughtCount = solarSchoolShopGoodsData.BoughtCount;
						solarSchoolShopRuntimeDataPb.GoodsBuyData.Add(solarSchoolShopGoodsBuyDataPb);
					}
				}
				solarSchoolShopDataPb.ShopData.Add(solarSchoolShopRuntimeDataPb);
			}
			gameData.Shop = solarSchoolShopDataPb;
		}

		// Token: 0x06038135 RID: 229685 RVA: 0x00FACDF4 File Offset: 0x00FAAFF4
		public override void Deserialize(SolarSchoolSaveGamePb gameData)
		{
			this.Reset();
			if (gameData.Shop == null)
			{
				return;
			}
			foreach (SolarSchoolShopRuntimeDataPb solarSchoolShopRuntimeDataPb in gameData.Shop.ShopData)
			{
				if (solarSchoolShopRuntimeDataPb.ShopId > 0 && solarSchoolShopRuntimeDataPb.RandomSeed != 0 && solarSchoolShopRuntimeDataPb.RefreshCycleIndex > 0)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					foreach (SolarSchoolShopGoodsBuyDataPb solarSchoolShopGoodsBuyDataPb in solarSchoolShopRuntimeDataPb.GoodsBuyData)
					{
						if (solarSchoolShopGoodsBuyDataPb.GoodsId > 0 && solarSchoolShopGoodsBuyDataPb.BoughtCount > 0)
						{
							dictionary[solarSchoolShopGoodsBuyDataPb.GoodsId] = solarSchoolShopGoodsBuyDataPb.BoughtCount;
						}
					}
					this.ShopDataMap[solarSchoolShopRuntimeDataPb.ShopId] = new SolarSchoolShopData.ShopRuntimeData(solarSchoolShopRuntimeDataPb.RandomSeed, solarSchoolShopRuntimeDataPb.RefreshCycleIndex, Array.Empty<SolarSchoolShopGoodsData>(), dictionary);
				}
			}
		}

		// Token: 0x0401D8BE RID: 121022
		private bool HasEnteredCurrentRefreshCycle;

		// Token: 0x0401D8BF RID: 121023
		private readonly List<SolarSchoolShopGoodsData> GoodsList = new List<SolarSchoolShopGoodsData>();

		// Token: 0x0401D8C0 RID: 121024
		private readonly Dictionary<int, SolarSchoolShopData.ShopRuntimeData> ShopDataMap = new Dictionary<int, SolarSchoolShopData.ShopRuntimeData>();

		// Token: 0x0200B4B1 RID: 46257
		[Nullable(0)]
		private sealed class ShopRuntimeData
		{
			// Token: 0x17007A39 RID: 31289
			// (get) Token: 0x06047A4D RID: 293453 RVA: 0x015CB0DE File Offset: 0x015C92DE
			public int RandomSeed { get; }

			// Token: 0x17007A3A RID: 31290
			// (get) Token: 0x06047A4E RID: 293454 RVA: 0x015CB0E6 File Offset: 0x015C92E6
			public int RefreshCycleIndex { get; }

			// Token: 0x17007A3B RID: 31291
			// (get) Token: 0x06047A4F RID: 293455 RVA: 0x015CB0EE File Offset: 0x015C92EE
			public IReadOnlyList<SolarSchoolShopGoodsData> GoodsList { get; }

			// Token: 0x17007A3C RID: 31292
			// (get) Token: 0x06047A50 RID: 293456 RVA: 0x015CB0F6 File Offset: 0x015C92F6
			public IReadOnlyDictionary<int, int> BoughtCountMap { get; }

			// Token: 0x06047A51 RID: 293457 RVA: 0x015CB0FE File Offset: 0x015C92FE
			public ShopRuntimeData(int randomSeed, int refreshCycleIndex, IReadOnlyList<SolarSchoolShopGoodsData> goodsList, [Nullable(2)] IReadOnlyDictionary<int, int> boughtCountMap = null)
			{
				this.RandomSeed = randomSeed;
				this.RefreshCycleIndex = refreshCycleIndex;
				this.GoodsList = goodsList;
				this.BoughtCountMap = (boughtCountMap ?? new Dictionary<int, int>());
			}
		}

		// Token: 0x0200B4B2 RID: 46258
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04037E01 RID: 228865
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<SolarSchoolShopGoodsData> <0>__CompareShopGoodsById;
		}
	}
}
