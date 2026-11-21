using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.PayShop;
using Google.Protobuf.Collections;

// Token: 0x02001847 RID: 6215
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PayShopModel : ModelBase
{
	// Token: 0x0600F56D RID: 62829 RVA: 0x0047A7F4 File Offset: 0x004789F4
	public PayShopModel()
	{
		Dictionary<PayShopDefine.EPayShopTabType, Func<bool>> dictionary = new Dictionary<PayShopDefine.EPayShopTabType, Func<bool>>();
		dictionary[PayShopDefine.EPayShopTabType.NewPlayerShop] = (() => this.GetPayShopTabIdList(PayShopDefine.EPayShopTabType.NewPlayerShop, false).Count > 0);
		this.VisibilityPredicates = dictionary;
	}

	// Token: 0x0600F56E RID: 62830 RVA: 0x0047A880 File Offset: 0x00478A80
	public bool IsPayShopVisible(PayShopDefine.EPayShopTabType payShopId)
	{
		Func<bool> func;
		return !this.VisibilityPredicates.TryGetValue(payShopId, out func) || func();
	}

	// Token: 0x170017CF RID: 6095
	// (get) Token: 0x0600F56F RID: 62831 RVA: 0x0047A8A5 File Offset: 0x00478AA5
	// (set) Token: 0x0600F570 RID: 62832 RVA: 0x0047A8AD File Offset: 0x00478AAD
	public string Version
	{
		get
		{
			return this.DataVersionInternal;
		}
		set
		{
			this.DataVersionInternal = value;
		}
	}

	// Token: 0x0600F571 RID: 62833 RVA: 0x0047A8B6 File Offset: 0x00478AB6
	public int GetCurrentPayShopId()
	{
		return this.CurrentPayShopId;
	}

	// Token: 0x0600F572 RID: 62834 RVA: 0x0047A8C0 File Offset: 0x00478AC0
	public UiDynamicTab? GetTabInfoByPayShopIdId(int payShopId)
	{
		foreach (PayShopDefine.EPayShopTabType epayShopTabType in this.GetPayShopIdList())
		{
			if (epayShopTabType == (PayShopDefine.EPayShopTabType)payShopId)
			{
				int payShopInfoDynamicTabId = this.GetPayShopInfoDynamicTabId(epayShopTabType);
				return new UiDynamicTab?(DynamicTabConfig.Instance.GetTabViewConfById(payShopInfoDynamicTabId));
			}
		}
		return null;
	}

	// Token: 0x0600F573 RID: 62835 RVA: 0x0047A938 File Offset: 0x00478B38
	public void SetPayShopInfoList(IEnumerable<PayShopInfo> infoList)
	{
		foreach (PayShopInfo info in infoList)
		{
			this.RefreshPayShopInfo(info);
		}
		EventSystem.Instance.Emit<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, this.PayShopMap.Keys);
	}

	// Token: 0x0600F574 RID: 62836 RVA: 0x0047A99C File Offset: 0x00478B9C
	public void SetPayShopRecommendData(IEnumerable<PayShopRecommendConfigInfo> info)
	{
		foreach (PayShopRecommendConfigInfo payShopRecommendConfigInfo in info)
		{
			int id = payShopRecommendConfigInfo.Id;
			PayShopRecommendData payShopRecommendData;
			if (this.PayShopRecommendData.TryGetValue(id, out payShopRecommendData))
			{
				payShopRecommendData.Phrase(payShopRecommendConfigInfo);
			}
			else
			{
				PayShopRecommendData payShopRecommendData2 = new PayShopRecommendData();
				payShopRecommendData2.Phrase(payShopRecommendConfigInfo);
				this.PayShopRecommendData[id] = payShopRecommendData2;
			}
		}
	}

	// Token: 0x0600F575 RID: 62837 RVA: 0x0047AA1C File Offset: 0x00478C1C
	public bool CheckRecommendHasBought(int type, int boughtParam)
	{
		if (type == 1)
		{
			return false;
		}
		if (type == 3)
		{
			return false;
		}
		if (type == 4)
		{
			if (boughtParam < 0)
			{
				return false;
			}
			PayShopGoods payShopGoodsById = PayGiftModel.Instance.GetPayShopGoodsById(boughtParam);
			return payShopGoodsById != null && payShopGoodsById.IsSoldOut();
		}
		else
		{
			if (type != 2)
			{
				return false;
			}
			if (boughtParam < 0)
			{
				return false;
			}
			PayShopGoods payShopGoods = PayShopModel.Instance.GetPayShopGoods(boughtParam);
			return payShopGoods != null && payShopGoods.IsSoldOut();
		}
	}

	// Token: 0x0600F576 RID: 62838 RVA: 0x0047AA78 File Offset: 0x00478C78
	public void SetPayShopTabData(IReadOnlyList<PayShopTabConfigInfo> info)
	{
		if (info.Count == 0)
		{
			return;
		}
		this.PayShopTabArray.Clear();
		foreach (PayShopTabConfigInfo info2 in info)
		{
			PayShopTabData payShopTabData = new PayShopTabData();
			payShopTabData.Phrase(info2);
			this.PayShopTabArray.Add(payShopTabData);
		}
	}

	// Token: 0x0600F577 RID: 62839 RVA: 0x0047AAE8 File Offset: 0x00478CE8
	public void SetPayShopInfo(PayShopInfo info)
	{
		this.RefreshPayShopInfo(info);
		this.CurrentPayShopId = info.Id;
	}

	// Token: 0x0600F578 RID: 62840 RVA: 0x0047AB00 File Offset: 0x00478D00
	public void SetPayShopGoodsList(IEnumerable<Aki.Protocol.PayShopItem> goodsInfoList)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (Aki.Protocol.PayShopItem payShopItem in goodsInfoList)
		{
			PayShopGoods payShopGoods;
			if (this.PayShopGoodsMap.TryGetValue(payShopItem.Id, out payShopGoods))
			{
				this.RefreshPayShopGoods(payShopItem);
			}
			else
			{
				PayShopDefine.EPayShopTabType shopId = (PayShopDefine.EPayShopTabType)payShopItem.ShopId;
				HashSet<int> hashSet2;
				if (!this.PayShopMap.TryGetValue(shopId, out hashSet2))
				{
					hashSet2 = new HashSet<int>();
				}
				hashSet2.Add(payShopItem.Id);
				this.PayShopMap[shopId] = hashSet2;
				payShopGoods = this.CreatePayShopGoods(payShopItem, shopId);
			}
			hashSet.Add(payShopGoods.GetTabId());
		}
		EventSystem.Instance.Emit<IReadOnlySet<int>>(EEventName.RefreshGoodsList, hashSet);
	}

	// Token: 0x0600F579 RID: 62841 RVA: 0x0047ABD0 File Offset: 0x00478DD0
	public PayShopInfoData GetPayShopInfoById(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopInfoData result;
		if (this.PayShopInfoMap.TryGetValue(payShopId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600F57A RID: 62842 RVA: 0x0047ABF0 File Offset: 0x00478DF0
	private unsafe void RefreshPayShopInfo(PayShopInfo info)
	{
		PayShopDefine.EPayShopTabType id = (PayShopDefine.EPayShopTabType)info.Id;
		RepeatedField<Aki.Protocol.PayShopItem> items = info.Items;
		HashSet<int> hashSet = new HashSet<int>();
		foreach (Aki.Protocol.PayShopItem payShopItem in items)
		{
			hashSet.Add(payShopItem.Id);
			this.CreatePayShopGoods(payShopItem, id);
		}
		this.PayShopMap[id] = hashSet;
		PayShopInfoData payShopInfoData;
		if (!this.PayShopInfoMap.TryGetValue(id, out payShopInfoData))
		{
			payShopInfoData = new PayShopInfoData();
		}
		payShopInfoData.Phrase(info);
		this.PayShopInfoMap[id] = payShopInfoData;
		this.ShopChangeDirty = true;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:Root 刷新商城数据";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ShopId", id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("goodsLength", hashSet.Count);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0600F57B RID: 62843 RVA: 0x0047AD04 File Offset: 0x00478F04
	protected void RefreshPayShopGoods(Aki.Protocol.PayShopItem goodsInfo)
	{
		PayShopGoodsData payShopGoodsData = new PayShopGoodsData();
		payShopGoodsData.Phrase(goodsInfo);
		PayShopGoods payShopGoods;
		if (this.PayShopGoodsMap.TryGetValue(goodsInfo.Id, out payShopGoods))
		{
			payShopGoods.SetGoodsData(payShopGoodsData);
		}
	}

	// Token: 0x0600F57C RID: 62844 RVA: 0x0047AD3C File Offset: 0x00478F3C
	private PayShopGoods CreatePayShopGoods(Aki.Protocol.PayShopItem goodsInfo, PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopGoodsData payShopGoodsData = new PayShopGoodsData();
		payShopGoodsData.Phrase(goodsInfo);
		PayShopGoods payShopGoods = new PayShopGoods(payShopId);
		payShopGoods.SetGoodsData(payShopGoodsData);
		this.PayShopGoodsMap[payShopGoodsData.Id] = payShopGoods;
		return payShopGoods;
	}

	// Token: 0x0600F57D RID: 62845 RVA: 0x0047AD78 File Offset: 0x00478F78
	public void UnLockPayShopGoods(IEnumerable<int> idList)
	{
		Dictionary<int, HashSet<int>> dictionary = new Dictionary<int, HashSet<int>>();
		foreach (int key in idList)
		{
			PayShopGoods payShopGoods;
			if (this.PayShopGoodsMap.TryGetValue(key, out payShopGoods))
			{
				payShopGoods.SetUnLock();
				HashSet<int> hashSet;
				if (!dictionary.TryGetValue((int)payShopGoods.PayShopId, out hashSet))
				{
					hashSet = new HashSet<int>();
				}
				hashSet.Add(payShopGoods.GetTabId());
				dictionary[(int)payShopGoods.PayShopId] = hashSet;
			}
		}
		this.ShopChangeDirty = true;
		EventSystem.Instance.Emit<IReadOnlyDictionary<int, HashSet<int>>>(EEventName.UnLockGoods, dictionary);
	}

	// Token: 0x0600F57E RID: 62846 RVA: 0x0047AE20 File Offset: 0x00479020
	public List<PayShopDefine.EPayShopTabType> GetPayShopIdList()
	{
		if (!this.ShopChangeDirty)
		{
			return this.CurrentPayShopTabTypeList;
		}
		this.ShopChangeDirty = false;
		this.CurrentPayShopTabTypeList.Clear();
		foreach (PayShopDefine.EPayShopTabType item in this.PayShopMap.Keys)
		{
			this.CurrentPayShopTabTypeList.Add(item);
		}
		this.CurrentPayShopTabTypeList.Sort(delegate(PayShopDefine.EPayShopTabType aPayShopId, PayShopDefine.EPayShopTabType bPayShopId)
		{
			int payShopInfoSort = this.GetPayShopInfoSort(aPayShopId);
			int payShopInfoSort2 = this.GetPayShopInfoSort(bPayShopId);
			if (payShopInfoSort != payShopInfoSort2)
			{
				return payShopInfoSort - payShopInfoSort2;
			}
			return aPayShopId - bPayShopId;
		});
		return this.CurrentPayShopTabTypeList;
	}

	// Token: 0x0600F57F RID: 62847 RVA: 0x0047AEBC File Offset: 0x004790BC
	public List<int> GetPayShopTabIdList(PayShopDefine.EPayShopTabType payShopId, bool sort = true)
	{
		HashSet<int> hashSet = new HashSet<int>();
		if (payShopId == PayShopDefine.EPayShopTabType.Recommend)
		{
			using (List<PayShopRecommendData>.Enumerator enumerator = this.GetNeedShowRecommendData().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					PayShopRecommendData payShopRecommendData = enumerator.Current;
					if (!hashSet.Contains(payShopRecommendData.Id))
					{
						hashSet.Add(payShopRecommendData.Id);
					}
				}
				goto IL_C5;
			}
		}
		foreach (PayShopGoods payShopGoods in this.CollectTabSourceGoods(payShopId))
		{
			if (this.IfGoodsContributeTab(payShopId, payShopGoods))
			{
				hashSet.Add(payShopGoods.GetTabId());
			}
		}
		IL_C5:
		if (payShopId == PayShopDefine.EPayShopTabType.SkinShop)
		{
			foreach (int item in PayGiftModel.Instance.GetSkinTabList())
			{
				hashSet.Add(item);
			}
		}
		if (payShopId == PayShopDefine.EPayShopTabType.NewPlayerShop && WeekCardModel.Instance.GetViewModel(EWeekCardKind.NewPlayer).IsKindOpen())
		{
			hashSet.Add(1);
		}
		List<int> list = new List<int>(hashSet);
		if (sort)
		{
			list.Sort(delegate(int aTabId, int bTabId)
			{
				PayShopTabData payShopTabDataByPayShopIdAndTabId = this.GetPayShopTabDataByPayShopIdAndTabId(payShopId, aTabId);
				PayShopTabData payShopTabDataByPayShopIdAndTabId2 = this.GetPayShopTabDataByPayShopIdAndTabId(payShopId, bTabId);
				int num = (payShopTabDataByPayShopIdAndTabId != null) ? payShopTabDataByPayShopIdAndTabId.Sort : 0;
				int num2 = (payShopTabDataByPayShopIdAndTabId2 != null) ? payShopTabDataByPayShopIdAndTabId2.Sort : 0;
				if (num != num2)
				{
					return num - num2;
				}
				return aTabId - bTabId;
			});
		}
		return list;
	}

	// Token: 0x0600F580 RID: 62848 RVA: 0x0047B040 File Offset: 0x00479240
	private List<PayShopGoods> CollectTabSourceGoods(PayShopDefine.EPayShopTabType payShopId)
	{
		List<PayShopGoods> list = new List<PayShopGoods>();
		HashSet<int> hashSet;
		if (this.PayShopMap.TryGetValue(payShopId, out hashSet))
		{
			foreach (int key in hashSet)
			{
				PayShopGoods item;
				if (this.PayShopGoodsMap.TryGetValue(key, out item))
				{
					list.Add(item);
				}
			}
		}
		if (this.IfPayGiftRoutedShop(payShopId))
		{
			foreach (PayShopGoods payShopGoods in PayGiftModel.Instance.GetPayShopGoodsList())
			{
				if (payShopGoods.PayShopId == payShopId)
				{
					PayPackageData getPayGiftData = payShopGoods.GetGetPayGiftData();
					if (getPayGiftData != null && getPayGiftData.ShowInShop() && getPayGiftData.CanShowInShopTab())
					{
						list.Add(payShopGoods);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x0600F581 RID: 62849 RVA: 0x0047B134 File Offset: 0x00479334
	private bool IfGoodsContributeTab(PayShopDefine.EPayShopTabType payShopId, PayShopGoods goods)
	{
		int tabId = goods.GetTabId();
		bool flag = payShopId == PayShopDefine.EPayShopTabType.NewPlayerShop;
		if (!flag && payShopId == PayShopDefine.EPayShopTabType.GiftBag)
		{
			using (IEnumerator<int> enumerator = PayShopDefine.GiftBagShopSpecialTabList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == tabId)
					{
						flag = true;
						break;
					}
				}
			}
		}
		if (flag && !goods.CheckGoodIfShow())
		{
			return false;
		}
		PayShopTabData payShopTabDataByPayShopIdAndTabId = this.GetPayShopTabDataByPayShopIdAndTabId(payShopId, tabId);
		if (payShopTabDataByPayShopIdAndTabId != null && payShopTabDataByPayShopIdAndTabId.BeginTime > 0L && payShopTabDataByPayShopIdAndTabId.EndTime > 0L)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			if (serverTime < (double)payShopTabDataByPayShopIdAndTabId.BeginTime || serverTime > (double)payShopTabDataByPayShopIdAndTabId.EndTime)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600F582 RID: 62850 RVA: 0x0047B1E4 File Offset: 0x004793E4
	public int GetPayShopFirstTabId(PayShopDefine.EPayShopTabType payShopId)
	{
		HashSet<int> hashSet;
		if (!this.PayShopMap.TryGetValue(payShopId, out hashSet))
		{
			return 0;
		}
		int num = 0;
		int num2 = 0;
		foreach (int key in hashSet)
		{
			PayShopGoods payShopGoods;
			if (this.PayShopGoodsMap.TryGetValue(key, out payShopGoods))
			{
				int tabId = payShopGoods.GetTabId();
				if (num == 0 && num2 == 0)
				{
					num = tabId;
					PayShopTabData payShopTabDataByPayShopIdAndTabId = this.GetPayShopTabDataByPayShopIdAndTabId(payShopId, num);
					num2 = ((payShopTabDataByPayShopIdAndTabId != null) ? payShopTabDataByPayShopIdAndTabId.Sort : 0);
				}
				else
				{
					PayShopTabData payShopTabDataByPayShopIdAndTabId2 = this.GetPayShopTabDataByPayShopIdAndTabId(payShopId, num);
					int num3 = (payShopTabDataByPayShopIdAndTabId2 != null) ? payShopTabDataByPayShopIdAndTabId2.Sort : 0;
					if (num2 > num3 || (num2 == num3 && num > tabId))
					{
						num = tabId;
						num2 = num3;
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0600F583 RID: 62851 RVA: 0x0047B2B0 File Offset: 0x004794B0
	private bool IfPayGiftRoutedShop(PayShopDefine.EPayShopTabType payShopId)
	{
		return PayShopDefine.payGiftRoutedShopSet.Contains(payShopId);
	}

	// Token: 0x0600F584 RID: 62852 RVA: 0x0047B2BD File Offset: 0x004794BD
	private bool IfSkinShopGoods(PayShopDefine.EPayShopTabType payShopId)
	{
		return payShopId == PayShopDefine.EPayShopTabType.SkinShop;
	}

	// Token: 0x0600F585 RID: 62853 RVA: 0x0047B2C4 File Offset: 0x004794C4
	public List<PayShopGoods> GetPayShopGoodsByTabType(PayShopDefine.EPayShopTabType payShopId, int tabId = 1)
	{
		List<PayShopGoods> list = new List<PayShopGoods>();
		if (this.IfPayGiftRoutedShop(payShopId))
		{
			using (List<PayShopGoods>.Enumerator enumerator = PayGiftModel.Instance.GetPayShopGoodsList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					PayShopGoods payShopGoods = enumerator.Current;
					if (payShopGoods.PayShopId == payShopId && payShopGoods.GetGetPayGiftData().ShowInShop() && payShopGoods.GetGetPayGiftData().CanShowInShopTab())
					{
						list.Add(payShopGoods);
					}
				}
				goto IL_D7;
			}
		}
		if (this.IfSkinShopGoods(payShopId))
		{
			foreach (PayShopGoods payShopGoods2 in PayGiftModel.Instance.GetPayShopGoodsList())
			{
				if (payShopGoods2.GetTabId() == tabId && payShopGoods2.GetGetPayGiftData().ShowInSkinTab() && payShopGoods2.GetGetPayGiftData().CanShowInShopTab())
				{
					list.Add(payShopGoods2);
				}
			}
		}
		IL_D7:
		HashSet<int> hashSet;
		if (this.PayShopMap.TryGetValue(payShopId, out hashSet))
		{
			foreach (int key in hashSet)
			{
				PayShopGoods item;
				if (this.PayShopGoodsMap.TryGetValue(key, out item))
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	// Token: 0x0600F586 RID: 62854 RVA: 0x0047B428 File Offset: 0x00479628
	public PayShopGoods GetGoodsInTab(PayShopDefine.EPayShopTabType payShopId, int itemConfigId)
	{
		List<PayShopGoods> list = new List<PayShopGoods>();
		HashSet<int> hashSet;
		if (this.PayShopMap.TryGetValue(payShopId, out hashSet))
		{
			foreach (int key in hashSet)
			{
				PayShopGoods item;
				if (this.PayShopGoodsMap.TryGetValue(key, out item))
				{
					list.Add(item);
				}
			}
		}
		foreach (PayShopGoods payShopGoods in list)
		{
			if (payShopGoods.GetItemData().ItemId == itemConfigId && payShopGoods.CheckGoodIfShow())
			{
				return payShopGoods;
			}
		}
		return null;
	}

	// Token: 0x0600F587 RID: 62855 RVA: 0x0047B4F8 File Offset: 0x004796F8
	public List<PayShopGoods> GetPayShopTabData(PayShopDefine.EPayShopTabType payShopId, int tabId = 1, bool isSort = true)
	{
		if (payShopId == PayShopDefine.EPayShopTabType.None || payShopId == PayShopDefine.EPayShopTabType.Default)
		{
			return new List<PayShopGoods>();
		}
		List<PayShopGoods> payShopGoodsByTabType = this.GetPayShopGoodsByTabType(payShopId, tabId);
		List<PayShopGoods> list = new List<PayShopGoods>();
		foreach (PayShopGoods payShopGoods in payShopGoodsByTabType)
		{
			if (payShopGoods.GetTabId() == tabId && payShopGoods.CheckGoodIfShow())
			{
				list.Add(payShopGoods);
			}
		}
		if (isSort)
		{
			return this.SortPayShopGoods(payShopId, list);
		}
		return list;
	}

	// Token: 0x0600F588 RID: 62856 RVA: 0x0047B580 File Offset: 0x00479780
	private List<PayShopGoods> SortPayShopGoods(PayShopDefine.EPayShopTabType payShopId, List<PayShopGoods> goods)
	{
		if (this.GetPayShopInfoSortRule(payShopId) == 1)
		{
			List<PayShopGoods> list = new List<PayShopGoods>();
			List<PayShopGoods> list2 = new List<PayShopGoods>();
			List<PayShopGoods> list3 = new List<PayShopGoods>();
			foreach (PayShopGoods payShopGoods in goods)
			{
				if (payShopGoods.IsSoldOut())
				{
					list3.Add(payShopGoods);
				}
				else if (payShopGoods.IfCanBuy())
				{
					list.Add(payShopGoods);
				}
				else
				{
					list2.Add(payShopGoods);
				}
			}
			list.Sort(new Comparison<PayShopGoods>(this.SortByQualityThenSortValueThenId));
			list2.Sort(new Comparison<PayShopGoods>(this.SortBySortValueThenId));
			list3.Sort(new Comparison<PayShopGoods>(this.SortByQualityThenSortValueThenId));
			List<PayShopGoods> list4 = new List<PayShopGoods>();
			list4.AddRange(list);
			list4.AddRange(list2);
			list4.AddRange(list3);
			return list4;
		}
		Comparison<PayShopGoods> sortFunctionByPayShopId = this.GetSortFunctionByPayShopId(payShopId);
		goods.Sort(sortFunctionByPayShopId);
		return goods;
	}

	// Token: 0x0600F589 RID: 62857 RVA: 0x0047B678 File Offset: 0x00479878
	private Comparison<PayShopGoods> GetSortFunctionByPayShopId(PayShopDefine.EPayShopTabType payShopId)
	{
		if (this.GetPayShopInfoSortRule(payShopId) == 1)
		{
			return new Comparison<PayShopGoods>(this.RougeLikeSort);
		}
		return new Comparison<PayShopGoods>(this.GoodsSort);
	}

	// Token: 0x0600F58A RID: 62858 RVA: 0x0047B69D File Offset: 0x0047989D
	private int SortBySortValueThenId(PayShopGoods aGoods, PayShopGoods bGoods)
	{
		if (aGoods.GetGoodsData().GetSortValue() != bGoods.GetGoodsData().GetSortValue())
		{
			return aGoods.GetGoodsData().GetSortValue() - bGoods.GetGoodsData().GetSortValue();
		}
		return aGoods.GetGoodsId() - bGoods.GetGoodsId();
	}

	// Token: 0x0600F58B RID: 62859 RVA: 0x0047B6DC File Offset: 0x004798DC
	private int SortByQualityThenSortValueThenId(PayShopGoods aGoods, PayShopGoods bGoods)
	{
		if (aGoods.GetItemData().Quality != bGoods.GetItemData().Quality)
		{
			return bGoods.GetItemData().Quality - aGoods.GetItemData().Quality;
		}
		if (aGoods.GetGoodsData().GetSortValue() != bGoods.GetGoodsData().GetSortValue())
		{
			return aGoods.GetGoodsData().GetSortValue() - bGoods.GetGoodsData().GetSortValue();
		}
		return aGoods.GetGoodsId() - bGoods.GetGoodsId();
	}

	// Token: 0x0600F58C RID: 62860 RVA: 0x0047B758 File Offset: 0x00479958
	private int RougeLikeSort(PayShopGoods aGoods, PayShopGoods bGoods)
	{
		if (aGoods.IsSoldOut() != bGoods.IsSoldOut())
		{
			if (!aGoods.IsSoldOut())
			{
				return -1;
			}
			return 1;
		}
		else if (aGoods.IfCanBuy() != bGoods.IfCanBuy())
		{
			if (!aGoods.IfCanBuy())
			{
				return 1;
			}
			return -1;
		}
		else
		{
			CSharpScript.Game.Module.PayShop.IItemData itemData = aGoods.GetItemData();
			CSharpScript.Game.Module.PayShop.IItemData itemData2 = bGoods.GetItemData();
			if (itemData.Quality != itemData2.Quality)
			{
				return itemData2.Quality - itemData.Quality;
			}
			if (aGoods.GetGoodsData().GetSortValue() != bGoods.GetGoodsData().GetSortValue())
			{
				return aGoods.GetGoodsData().GetSortValue() - bGoods.GetGoodsData().GetSortValue();
			}
			return aGoods.GetGoodsId() - bGoods.GetGoodsId();
		}
	}

	// Token: 0x0600F58D RID: 62861 RVA: 0x0047B800 File Offset: 0x00479A00
	private int GoodsSort(PayShopGoods aGoods, PayShopGoods bGoods)
	{
		if (aGoods.IsSoldOut() != bGoods.IsSoldOut())
		{
			if (!aGoods.IsSoldOut())
			{
				return -1;
			}
			return 1;
		}
		else if (aGoods.IsLocked() != bGoods.IsLocked())
		{
			if (!aGoods.IsLocked())
			{
				return -1;
			}
			return 1;
		}
		else
		{
			bool flag = aGoods.IfCanBuy() || aGoods.IsShowTimePreview();
			bool flag2 = bGoods.IfCanBuy() || bGoods.IsShowTimePreview();
			if (flag != flag2)
			{
				if (!flag)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				if (aGoods.GetGoodsData().GetSortValue() != bGoods.GetGoodsData().GetSortValue())
				{
					return aGoods.GetGoodsData().GetSortValue() - bGoods.GetGoodsData().GetSortValue();
				}
				CSharpScript.Game.Module.PayShop.IItemData itemData = aGoods.GetItemData();
				CSharpScript.Game.Module.PayShop.IItemData itemData2 = bGoods.GetItemData();
				if (itemData.Quality != itemData2.Quality)
				{
					return itemData2.Quality - itemData.Quality;
				}
				return aGoods.GetGoodsId() - bGoods.GetGoodsId();
			}
		}
	}

	// Token: 0x0600F58E RID: 62862 RVA: 0x0047B8D7 File Offset: 0x00479AD7
	[NullableContext(2)]
	public PayShopGoods GetPayShopGoods(int goodsId)
	{
		return this.PayShopGoodsMap.GetValueOrDefault(goodsId);
	}

	// Token: 0x0600F58F RID: 62863 RVA: 0x0047B8E8 File Offset: 0x00479AE8
	public CommonDefine.ICountDown GetPayShopCountDownData(PayShopDefine.EPayShopTabType payShopId)
	{
		long payShopUpdateTime = this.GetPayShopUpdateTime(payShopId);
		if (payShopUpdateTime <= 0L)
		{
			return null;
		}
		long num = payShopUpdateTime;
		ValueTuple<int, int> timeTypeData = PayShopGoods.GetTimeTypeData(num);
		double num2 = (double)num - Math.Ceiling(TimeUtil.Instance.GetServerTime());
		if (timeTypeData.Item1 == 0)
		{
			return new CommonDefine.CountDown
			{
				CountDownText = TextConfig.Instance.GetTextById("NotEnoughOneHour"),
				RemainingTime = num2
			};
		}
		return TimeUtil.Instance.GetCountDownData(num2, null, null);
	}

	// Token: 0x0600F590 RID: 62864 RVA: 0x0047B968 File Offset: 0x00479B68
	public long GetPayShopUpdateTime(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopInfoData payShopInfoById = this.GetPayShopInfoById(payShopId);
		if (payShopInfoById == null)
		{
			return 0L;
		}
		return payShopInfoById.UpdateTime;
	}

	// Token: 0x0600F591 RID: 62865 RVA: 0x0047B98C File Offset: 0x00479B8C
	public void UpdatePayShopGoodsCount(int goodsId, int count)
	{
		PayShopGoods payShopGoods;
		if (this.PayShopGoodsMap.TryGetValue(goodsId, out payShopGoods))
		{
			if (payShopGoods.IsLimitGoods())
			{
				payShopGoods.AddBoughtCount(count);
				if (payShopGoods.IsSoldOut())
				{
					EventSystem.Instance.Emit<int>(EEventName.GoodsSoldOut, goodsId);
				}
			}
			EventSystem.Instance.Emit<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, goodsId, payShopGoods.PayShopId, payShopGoods.GetTabId());
		}
	}

	// Token: 0x0600F592 RID: 62866 RVA: 0x0047B9F0 File Offset: 0x00479BF0
	public void UpdateActivityPayShopGoodsCount(int goodsId, int count)
	{
		PayShopGoods payShopGoods;
		if (this.PayShopGoodsMap.TryGetValue(goodsId, out payShopGoods) && payShopGoods.IsLimitGoods())
		{
			payShopGoods.AddBoughtCount(count);
		}
	}

	// Token: 0x0600F593 RID: 62867 RVA: 0x0047BA1C File Offset: 0x00479C1C
	public List<PayShopGoods> GetNeedCheckGoods(PayShopDefine.EPayShopTabType payShopId)
	{
		List<PayShopGoods> list = new List<PayShopGoods>();
		foreach (PayShopGoods payShopGoods in this.GetPayShopGoodsByTabType(payShopId, 1))
		{
			if (payShopGoods.IsShowInShop() && (payShopGoods.InUpdateTime() || payShopGoods.InUnPermanentSellTime() || payShopGoods.WillSell()))
			{
				list.Add(payShopGoods);
			}
		}
		return list;
	}

	// Token: 0x0600F594 RID: 62868 RVA: 0x0047BA98 File Offset: 0x00479C98
	public bool CheckPayShopEntranceHasRedDot()
	{
		if (!FunctionModel.Instance.IsOpen(10010))
		{
			return false;
		}
		foreach (PayShopDefine.EPayShopTabType payShopId in this.GetPayShopIdList())
		{
			if (this.CheckPayShopHasRedDot(payShopId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600F595 RID: 62869 RVA: 0x0047BB08 File Offset: 0x00479D08
	public bool CheckPayShopHasRedDot(PayShopDefine.EPayShopTabType payShopId)
	{
		if (payShopId == PayShopDefine.EPayShopTabType.Recommend)
		{
			return MonthCardModel.Instance.GetPayButtonRedDotState() || WeekCardModel.Instance.GetViewModel(EWeekCardKind.Normal).GetRedDotState();
		}
		if (payShopId == PayShopDefine.EPayShopTabType.Recharge)
		{
			return !LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.PayShopRechargeRedDot, false) && PayItemModel.Instance.HasBonusData();
		}
		PayShopDefine.EShopTabViewType payShopInfoTabViewType = (PayShopDefine.EShopTabViewType)this.GetPayShopInfoTabViewType(payShopId);
		bool flag = false;
		using (IEnumerator<PayShopDefine.EShopTabViewType> enumerator = PayShopDefine.payShopViewTabType.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == payShopInfoTabViewType)
				{
					flag = true;
					break;
				}
			}
		}
		if (!flag)
		{
			return false;
		}
		foreach (int tabId in this.GetPayShopTabIdList(payShopId, false))
		{
			if (this.CheckPayShopTabHasRedDot(payShopId, tabId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600F596 RID: 62870 RVA: 0x0047BBF8 File Offset: 0x00479DF8
	public bool CheckPayShopTabHasRedDot(PayShopDefine.EPayShopTabType payShopId, int tabId = 1)
	{
		if (payShopId == PayShopDefine.EPayShopTabType.Recommend)
		{
			return this.CheckRecommendPayShopTabRedDot(payShopId, tabId);
		}
		if (payShopId == PayShopDefine.EPayShopTabType.NewPlayerShop && tabId == 1)
		{
			return WeekCardModel.Instance.GetViewModel(EWeekCardKind.NewPlayer).GetRedDotState();
		}
		if (payShopId == PayShopDefine.EPayShopTabType.SkinShop && tabId != 1)
		{
			foreach (PayShopGoods payShopGoods in PayGiftModel.Instance.GetPayShopGoodsList())
			{
				if (payShopGoods.GetTabId() == tabId)
				{
					PayPackageData getPayGiftData = payShopGoods.GetGetPayGiftData();
					if (getPayGiftData.ShowInSkinTab() && getPayGiftData.CanShowInShopTab() && payShopGoods.GetIfNeedRemind())
					{
						return true;
					}
				}
			}
		}
		using (List<PayShopGoods>.Enumerator enumerator = this.GetPayShopTabData(payShopId, tabId, false).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.GetIfNeedRemind())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600F597 RID: 62871 RVA: 0x0047BCF0 File Offset: 0x00479EF0
	private bool CheckRecommendPayShopTabRedDot(PayShopDefine.EPayShopTabType payShopId, int tabId = 1)
	{
		if (!this.GetPayShopTabIdList(payShopId, false).Contains(tabId))
		{
			return false;
		}
		PayShopRecommendData recommendDataById = this.GetRecommendDataById(tabId);
		if (recommendDataById != null && recommendDataById.RecommendType == 1)
		{
			return MonthCardModel.Instance.GetPayButtonRedDotState();
		}
		return recommendDataById != null && recommendDataById.RecommendType == 3 && WeekCardModel.Instance.GetViewModel(EWeekCardKind.Normal).GetRedDotState();
	}

	// Token: 0x0600F598 RID: 62872 RVA: 0x0047BD4C File Offset: 0x00479F4C
	public bool ReadShopItemCheckFlag(PayShopDefine.EPayShopTabType payShopId, int tabId = 1)
	{
		List<PayShopGoods> list;
		if (this.IfPayGiftRoutedShop(payShopId))
		{
			list = PayGiftModel.Instance.GetPayShopGoodsList().FindAll((PayShopGoods g) => g.PayShopId == payShopId);
		}
		else
		{
			list = this.GetPayShopTabData(payShopId, tabId, false);
		}
		bool flag = false;
		foreach (PayShopGoods payShopGoods in list)
		{
			if (!payShopGoods.IsSoldOut() && !payShopGoods.IsLocked() && payShopGoods.IfCanBuy() && !NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.PayShopTabItemChecked, payShopGoods.GetGoodsId()))
			{
				NewFlagModel.Instance.AddNewFlag(ELocalStoragePlayerKey.PayShopTabItemChecked, payShopGoods.GetGoodsId());
				flag = true;
			}
		}
		if (flag)
		{
			NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.PayShopTabItemChecked);
		}
		return flag;
	}

	// Token: 0x0600F599 RID: 62873 RVA: 0x0047BE38 File Offset: 0x0047A038
	public bool CheckShopItemCheckFlag(PayShopDefine.EPayShopTabType payShopId, int tabId = 1)
	{
		List<PayShopGoods> list;
		if (this.IfPayGiftRoutedShop(payShopId))
		{
			list = PayGiftModel.Instance.GetPayShopGoodsList().FindAll((PayShopGoods g) => g.PayShopId == payShopId);
		}
		else
		{
			list = this.GetPayShopTabData(payShopId, tabId, false);
		}
		foreach (PayShopGoods payShopGoods in list)
		{
			if (!payShopGoods.IsSoldOut() && !payShopGoods.IsLocked() && payShopGoods.IfCanBuy() && !NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.PayShopTabItemChecked, payShopGoods.GetGoodsId()))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600F59A RID: 62874 RVA: 0x0047BEFC File Offset: 0x0047A0FC
	public string GetPayShopItemQualitySpriteByItemIdAndQuality(int itemId, int quality)
	{
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemId));
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.DangoAbyssItem)
		{
			return DangoAbyssConfig.Instance.GetAbyssQualityById(quality).Value.PayShopQualitySprite;
		}
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.HonamiStoryItem || HonamiStoryUtil.CheckIsPluginBoxItem(itemId))
		{
			return HonamiStoryConfig.Instance.GetHonamiStoryQuality(quality).Value.PayShopQualitySprite;
		}
		return CSharpScript.Game.Module.Item.ItemConfig.Instance.GetQualityConfig(quality).Value.PayShopQualitySprite;
	}

	// Token: 0x0600F59B RID: 62875 RVA: 0x0047BF84 File Offset: 0x0047A184
	public int GetPayShopInfoTabViewType(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopInfoData payShopInfoById = this.GetPayShopInfoById(payShopId);
		if (payShopInfoById == null)
		{
			return 0;
		}
		return payShopInfoById.ShopTabViewType;
	}

	// Token: 0x0600F59C RID: 62876 RVA: 0x0047BFA4 File Offset: 0x0047A1A4
	public int GetPayShopInfoDynamicTabId(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopInfoData payShopInfoById = this.GetPayShopInfoById(payShopId);
		if (payShopInfoById == null)
		{
			return 0;
		}
		return payShopInfoById.DynamicTabId;
	}

	// Token: 0x0600F59D RID: 62877 RVA: 0x0047BFC4 File Offset: 0x0047A1C4
	public int GetPayShopInfoSortRule(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopInfoData payShopInfoById = this.GetPayShopInfoById(payShopId);
		if (payShopInfoById == null)
		{
			return 0;
		}
		return payShopInfoById.SortRule;
	}

	// Token: 0x0600F59E RID: 62878 RVA: 0x0047BFE4 File Offset: 0x0047A1E4
	public int GetPayShopInfoSort(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopInfoData payShopInfoById = this.GetPayShopInfoById(payShopId);
		if (payShopInfoById == null)
		{
			return 0;
		}
		return payShopInfoById.Sort;
	}

	// Token: 0x0600F59F RID: 62879 RVA: 0x0047C004 File Offset: 0x0047A204
	public void AddPreviewPayGiftEntry(int configId, IPreviewPayGiftEntry entry)
	{
		if (configId <= 0)
		{
			return;
		}
		this.PreviewPayGiftEntryMap[configId] = entry;
	}

	// Token: 0x0600F5A0 RID: 62880 RVA: 0x0047C018 File Offset: 0x0047A218
	[NullableContext(2)]
	public IPreviewPayGiftEntry TryGetPreviewPayGiftEntry(int configId)
	{
		return this.PreviewPayGiftEntryMap.GetValueOrDefault(configId);
	}

	// Token: 0x0600F5A1 RID: 62881 RVA: 0x0047C026 File Offset: 0x0047A226
	public void ClearPreviewPayGiftEntries()
	{
		if (this.PreviewPayGiftEntryMap.Count == 0)
		{
			return;
		}
		this.PreviewPayGiftEntryMap.Clear();
	}

	// Token: 0x0600F5A2 RID: 62882 RVA: 0x0047C044 File Offset: 0x0047A244
	[NullableContext(2)]
	public PayGiftPreviewBuildResult TryBuildConsoleExtraPayGiftPreview(int reasonId)
	{
		if (reasonId != 8001)
		{
			return null;
		}
		int consoleExtraPerformancePayGiftId = this.ConsoleExtraPerformancePayGiftId;
		if (consoleExtraPerformancePayGiftId <= 0)
		{
			return null;
		}
		this.ConsoleExtraPerformancePayGiftId = 0;
		PayPackageData payGiftDataById = PayGiftModel.Instance.GetPayGiftDataById(consoleExtraPerformancePayGiftId);
		if (payGiftDataById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Shop;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "[ConsoleExtraPayGift] payGiftData missing, fallback to normal flow";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("payGiftId", consoleExtraPerformancePayGiftId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		List<RewardItemData> list = this.BuildPayGiftPreviewItemList(payGiftDataById);
		if (list.Count == 0)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Shop;
			ELogAuthor author2 = ELogAuthor.YZY;
			string message2 = "[ConsoleExtraPayGift] preview items empty, fallback";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("payGiftId", consoleExtraPerformancePayGiftId);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		int configId = list[0].ConfigId;
		PreviewPayGiftEntry entry = new PreviewPayGiftEntry
		{
			EndStampSec = (long)Math.Floor(TimeUtil.Instance.GetServerTime()) + 2592000L,
			Title = this.BuildPayGiftRewardTitleText(payGiftDataById),
			RewardListDesc = this.BuildPayGiftRewardDescText(payGiftDataById)
		};
		this.AddPreviewPayGiftEntry(configId, entry);
		return new PayGiftPreviewBuildResult
		{
			PreviewItems = list
		};
	}

	// Token: 0x0600F5A3 RID: 62883 RVA: 0x0047C14C File Offset: 0x0047A34C
	private unsafe List<RewardItemData> BuildPayGiftPreviewItemList(PayPackageData payGiftData)
	{
		if (payGiftData.ItemId <= 0 || payGiftData.ItemCount <= 0)
		{
			return new List<RewardItemData>();
		}
		int previewPayGiftItemTemplateId = PayShopConfig.Instance.GetPreviewPayGiftItemTemplateId();
		RewardItemData rewardItemData = new RewardItemData((previewPayGiftItemTemplateId > 0) ? previewPayGiftItemTemplateId : payGiftData.ItemId, payGiftData.ItemCount, null, EDropItemType.Normal);
		rewardItemData.SetShowTimeFlag(true);
		int num = 1;
		List<RewardItemData> list = new List<RewardItemData>(num);
		CollectionsMarshal.SetCount<RewardItemData>(list, num);
		Span<RewardItemData> span = CollectionsMarshal.AsSpan<RewardItemData>(list);
		int index = 0;
		*span[index] = rewardItemData;
		return list;
	}

	// Token: 0x0600F5A4 RID: 62884 RVA: 0x0047C1CC File Offset: 0x0047A3CC
	private string BuildPayGiftRewardTitleText(PayPackageData payGiftData)
	{
		int itemId = payGiftData.ItemId;
		if (itemId <= 0)
		{
			return "";
		}
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		string text = (itemConfigData != null) ? itemConfigData.Name : null;
		if (text == null || StringUtils.IsEmpty(text))
		{
			return "";
		}
		return text;
	}

	// Token: 0x0600F5A5 RID: 62885 RVA: 0x0047C214 File Offset: 0x0047A414
	private string BuildPayGiftRewardDescText(PayPackageData payGiftData)
	{
		int itemId = payGiftData.ItemId;
		if (itemId <= 0)
		{
			return "";
		}
		string name = InventoryConfig.Instance.GetItemConfigData(itemId).Name;
		return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Common_Get_PayGift", null), new string[]
		{
			ConfigMultiTextLang.GetLocalTextNew(name, null)
		});
	}

	// Token: 0x0600F5A6 RID: 62886 RVA: 0x0047C264 File Offset: 0x0047A464
	public List<int> GetPayShopInfoMoney(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopInfoData payShopInfoById = this.GetPayShopInfoById(payShopId);
		if (payShopInfoById == null)
		{
			return new List<int>();
		}
		return payShopInfoById.Money;
	}

	// Token: 0x0600F5A7 RID: 62887 RVA: 0x0047C288 File Offset: 0x0047A488
	public List<int> GetPayShopTableList(int shopId)
	{
		List<PayShopTabData> list = new List<PayShopTabData>();
		foreach (PayShopTabData payShopTabData in this.PayShopTabArray)
		{
			if (payShopTabData.ShopId == shopId)
			{
				list.Add(payShopTabData);
			}
		}
		List<int> list2 = new List<int>();
		list.Sort((PayShopTabData a, PayShopTabData b) => a.Sort - b.Sort);
		foreach (PayShopTabData payShopTabData2 in list)
		{
			if (payShopTabData2.Enable)
			{
				list2.Add(payShopTabData2.TabId);
			}
		}
		return list2;
	}

	// Token: 0x0600F5A8 RID: 62888 RVA: 0x0047C364 File Offset: 0x0047A564
	public PayShopTabData GetPayShopTabDataByPayShopIdAndTabId(PayShopDefine.EPayShopTabType payShopId, int tabId)
	{
		foreach (PayShopTabData payShopTabData in this.PayShopTabArray)
		{
			if (payShopTabData.ShopId == (int)payShopId && payShopTabData.TabId == tabId)
			{
				return payShopTabData;
			}
		}
		return null;
	}

	// Token: 0x0600F5A9 RID: 62889 RVA: 0x0047C3CC File Offset: 0x0047A5CC
	public List<PayShopRecommendData> GetRecommendData()
	{
		List<PayShopRecommendData> list = new List<PayShopRecommendData>();
		foreach (PayShopRecommendData item in this.PayShopRecommendData.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600F5AA RID: 62890 RVA: 0x0047C42C File Offset: 0x0047A62C
	public List<PayShopRecommendData> GetNeedShowRecommendData()
	{
		List<PayShopRecommendData> list = new List<PayShopRecommendData>();
		foreach (PayShopRecommendData payShopRecommendData in this.PayShopRecommendData.Values)
		{
			if (payShopRecommendData.Show)
			{
				list.Add(payShopRecommendData);
			}
		}
		return list;
	}

	// Token: 0x0600F5AB RID: 62891 RVA: 0x0047C494 File Offset: 0x0047A694
	public PayShopRecommendData GetRecommendDataById(int id)
	{
		PayShopRecommendData result;
		if (this.PayShopRecommendData.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600F5AC RID: 62892 RVA: 0x0047C4B4 File Offset: 0x0047A6B4
	public void ClearData()
	{
		this.PayShopInfoMap.Clear();
		this.PayShopMap.Clear();
		this.PayShopGoodsMap.Clear();
		this.PreviewPayGiftEntryMap.Clear();
		this.ConsoleExtraPerformancePayGiftId = 0;
	}

	// Token: 0x170017D0 RID: 6096
	// (get) Token: 0x0600F5AD RID: 62893 RVA: 0x0047C4E9 File Offset: 0x0047A6E9
	public static PayShopModel Instance
	{
		get
		{
			return PayShopModel._Instance;
		}
	}

	// Token: 0x0600F5AE RID: 62894 RVA: 0x0047C4F0 File Offset: 0x0047A6F0
	public static PayShopModel GetOrCreateInstance()
	{
		if (PayShopModel._Instance == null)
		{
			PayShopModel.CreateInstance();
		}
		return PayShopModel._Instance;
	}

	// Token: 0x0600F5AF RID: 62895 RVA: 0x0047C504 File Offset: 0x0047A704
	public static bool CreateInstance()
	{
		if (PayShopModel._Instance != null)
		{
			return true;
		}
		PayShopModel._Instance = new PayShopModel();
		return true;
	}

	// Token: 0x0600F5B0 RID: 62896 RVA: 0x0047C51A File Offset: 0x0047A71A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F5B1 RID: 62897 RVA: 0x0047C51C File Offset: 0x0047A71C
	public static void ResetStaticDefaultValue()
	{
		PayShopModel._Instance = null;
	}

	// Token: 0x0600F5B2 RID: 62898 RVA: 0x0047C524 File Offset: 0x0047A724
	static PayShopModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PayShopModel.CreateStaticDefaultValue), new Action(PayShopModel.ResetStaticDefaultValue));
	}

	// Token: 0x040089F2 RID: 35314
	private readonly Dictionary<PayShopDefine.EPayShopTabType, PayShopInfoData> PayShopInfoMap = new Dictionary<PayShopDefine.EPayShopTabType, PayShopInfoData>();

	// Token: 0x040089F3 RID: 35315
	private readonly Dictionary<PayShopDefine.EPayShopTabType, HashSet<int>> PayShopMap = new Dictionary<PayShopDefine.EPayShopTabType, HashSet<int>>();

	// Token: 0x040089F4 RID: 35316
	private readonly Dictionary<int, PayShopGoods> PayShopGoodsMap = new Dictionary<int, PayShopGoods>();

	// Token: 0x040089F5 RID: 35317
	private List<PayShopTabData> PayShopTabArray = new List<PayShopTabData>();

	// Token: 0x040089F6 RID: 35318
	private readonly Dictionary<int, PayShopRecommendData> PayShopRecommendData = new Dictionary<int, PayShopRecommendData>();

	// Token: 0x040089F7 RID: 35319
	private string DataVersionInternal = "";

	// Token: 0x040089F8 RID: 35320
	private int CurrentPayShopId;

	// Token: 0x040089F9 RID: 35321
	private bool ShopChangeDirty;

	// Token: 0x040089FA RID: 35322
	private List<PayShopDefine.EPayShopTabType> CurrentPayShopTabTypeList = new List<PayShopDefine.EPayShopTabType>();

	// Token: 0x040089FB RID: 35323
	public bool BusinessCompliance;

	// Token: 0x040089FC RID: 35324
	public int ConsoleExtraPerformancePayGiftId;

	// Token: 0x040089FD RID: 35325
	private readonly Dictionary<int, IPreviewPayGiftEntry> PreviewPayGiftEntryMap = new Dictionary<int, IPreviewPayGiftEntry>();

	// Token: 0x040089FE RID: 35326
	private readonly Dictionary<PayShopDefine.EPayShopTabType, Func<bool>> VisibilityPredicates;

	// Token: 0x040089FF RID: 35327
	[Nullable(2)]
	private static PayShopModel _Instance;
}
