using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02002362 RID: 9058
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PayShopModel : ModelBase
{
	// Token: 0x060120BD RID: 73917 RVA: 0x0046D734 File Offset: 0x0046B934
	public PayShopModel()
	{
		Dictionary<PayShopDefine.EPayShopTabType, Func<bool>> dictionary = new Dictionary<PayShopDefine.EPayShopTabType, Func<bool>>();
		dictionary[PayShopDefine.EPayShopTabType.NewPlayerShop] = (() => this.GetPayShopTabIdList(PayShopDefine.EPayShopTabType.NewPlayerShop, false).Count > 0);
		this.VisibilityPredicates = dictionary;
	}

	// Token: 0x060120BE RID: 73918 RVA: 0x0046D7C0 File Offset: 0x0046B9C0
	public bool IsPayShopVisible(PayShopDefine.EPayShopTabType payShopId)
	{
		Func<bool> func;
		return !this.VisibilityPredicates.TryGetValue(payShopId, out func) || func();
	}

	// Token: 0x17001795 RID: 6037
	// (get) Token: 0x060120BF RID: 73919 RVA: 0x0046D7E5 File Offset: 0x0046B9E5
	// (set) Token: 0x060120C0 RID: 73920 RVA: 0x0046D7ED File Offset: 0x0046B9ED
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

	// Token: 0x060120C1 RID: 73921 RVA: 0x0046D7F6 File Offset: 0x0046B9F6
	public int GetCurrentPayShopId()
	{
		return this.CurrentPayShopId;
	}

	// Token: 0x060120C2 RID: 73922 RVA: 0x0046D800 File Offset: 0x0046BA00
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

	// Token: 0x060120C3 RID: 73923 RVA: 0x0046D878 File Offset: 0x0046BA78
	public void SetPayShopInfoList(List<PayShopInfo> infoList)
	{
		foreach (PayShopInfo info in infoList)
		{
			this.RefreshPayShopInfo(info);
		}
		EventSystem.Instance.Emit<IEnumerable<PayShopDefine.EPayShopTabType>>(EEventName.RefreshAllPayShop, this.PayShopMap.Keys);
	}

	// Token: 0x060120C4 RID: 73924 RVA: 0x0046D8E4 File Offset: 0x0046BAE4
	public void SetPayShopRecommendData(List<PayShopRecommendConfigInfo> info)
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

	// Token: 0x060120C5 RID: 73925 RVA: 0x0046D968 File Offset: 0x0046BB68
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

	// Token: 0x060120C6 RID: 73926 RVA: 0x0046D9C4 File Offset: 0x0046BBC4
	public void SetPayShopTabData(List<PayShopTabConfigInfo> info)
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

	// Token: 0x060120C7 RID: 73927 RVA: 0x0046DA38 File Offset: 0x0046BC38
	public void SetPayShopInfo(PayShopInfo info)
	{
		this.RefreshPayShopInfo(info);
		this.CurrentPayShopId = info.Id;
	}

	// Token: 0x060120C8 RID: 73928 RVA: 0x0046DA50 File Offset: 0x0046BC50
	public void SetPayShopGoodsList(List<Aki.Protocol.PayShopItem> goodsInfoList)
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

	// Token: 0x060120C9 RID: 73929 RVA: 0x0046DB24 File Offset: 0x0046BD24
	public PayShopInfoData GetPayShopInfoById(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopInfoData result;
		if (this.PayShopInfoMap.TryGetValue(payShopId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060120CA RID: 73930 RVA: 0x0046DB44 File Offset: 0x0046BD44
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

	// Token: 0x060120CB RID: 73931 RVA: 0x0046DC58 File Offset: 0x0046BE58
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

	// Token: 0x060120CC RID: 73932 RVA: 0x0046DC90 File Offset: 0x0046BE90
	private PayShopGoods CreatePayShopGoods(Aki.Protocol.PayShopItem goodsInfo, PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopGoodsData payShopGoodsData = new PayShopGoodsData();
		payShopGoodsData.Phrase(goodsInfo);
		PayShopGoods payShopGoods = new PayShopGoods(payShopId);
		payShopGoods.SetGoodsData(payShopGoodsData);
		this.PayShopGoodsMap[payShopGoodsData.Id] = payShopGoods;
		return payShopGoods;
	}

	// Token: 0x060120CD RID: 73933 RVA: 0x0046DCCC File Offset: 0x0046BECC
	public void UnLockPayShopGoods(List<int> idList)
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

	// Token: 0x060120CE RID: 73934 RVA: 0x0046DD7C File Offset: 0x0046BF7C
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

	// Token: 0x060120CF RID: 73935 RVA: 0x0046DE18 File Offset: 0x0046C018
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

	// Token: 0x060120D0 RID: 73936 RVA: 0x0046DF9C File Offset: 0x0046C19C
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

	// Token: 0x060120D1 RID: 73937 RVA: 0x0046E090 File Offset: 0x0046C290
	private bool IfGoodsContributeTab(PayShopDefine.EPayShopTabType payShopId, PayShopGoods goods)
	{
		int tabId = goods.GetTabId();
		if ((payShopId == PayShopDefine.EPayShopTabType.NewPlayerShop || (payShopId == PayShopDefine.EPayShopTabType.GiftBag && PayShopDefine.GiftBagShopSpecialTabList.Contains(tabId))) && !goods.CheckGoodIfShow())
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

	// Token: 0x060120D2 RID: 73938 RVA: 0x0046E10C File Offset: 0x0046C30C
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

	// Token: 0x060120D3 RID: 73939 RVA: 0x0046E1D8 File Offset: 0x0046C3D8
	private bool IfPayGiftRoutedShop(PayShopDefine.EPayShopTabType payShopId)
	{
		return PayShopDefine.payGiftRoutedShopSet.Contains(payShopId);
	}

	// Token: 0x060120D4 RID: 73940 RVA: 0x0046E1E5 File Offset: 0x0046C3E5
	private bool IfSkinShopGoods(PayShopDefine.EPayShopTabType payShopId)
	{
		return payShopId == PayShopDefine.EPayShopTabType.SkinShop;
	}

	// Token: 0x060120D5 RID: 73941 RVA: 0x0046E1EC File Offset: 0x0046C3EC
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

	// Token: 0x060120D6 RID: 73942 RVA: 0x0046E350 File Offset: 0x0046C550
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

	// Token: 0x060120D7 RID: 73943 RVA: 0x0046E420 File Offset: 0x0046C620
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

	// Token: 0x060120D8 RID: 73944 RVA: 0x0046E4A8 File Offset: 0x0046C6A8
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

	// Token: 0x060120D9 RID: 73945 RVA: 0x0046E5A0 File Offset: 0x0046C7A0
	private Comparison<PayShopGoods> GetSortFunctionByPayShopId(PayShopDefine.EPayShopTabType payShopId)
	{
		if (this.GetPayShopInfoSortRule(payShopId) == 1)
		{
			return new Comparison<PayShopGoods>(this.RougeLikeSort);
		}
		return new Comparison<PayShopGoods>(this.GoodsSort);
	}

	// Token: 0x060120DA RID: 73946 RVA: 0x0046E5C5 File Offset: 0x0046C7C5
	private int SortBySortValueThenId(PayShopGoods aGoods, PayShopGoods bGoods)
	{
		if (aGoods.GetGoodsData().GetSortValue() != bGoods.GetGoodsData().GetSortValue())
		{
			return aGoods.GetGoodsData().GetSortValue() - bGoods.GetGoodsData().GetSortValue();
		}
		return aGoods.GetGoodsId() - bGoods.GetGoodsId();
	}

	// Token: 0x060120DB RID: 73947 RVA: 0x0046E604 File Offset: 0x0046C804
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

	// Token: 0x060120DC RID: 73948 RVA: 0x0046E680 File Offset: 0x0046C880
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

	// Token: 0x060120DD RID: 73949 RVA: 0x0046E728 File Offset: 0x0046C928
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

	// Token: 0x060120DE RID: 73950 RVA: 0x0046E7EA File Offset: 0x0046C9EA
	[NullableContext(2)]
	public PayShopGoods GetPayShopGoods(int goodsId)
	{
		return this.PayShopGoodsMap.GetValueOrDefault(goodsId);
	}

	// Token: 0x060120DF RID: 73951 RVA: 0x0046E7F8 File Offset: 0x0046C9F8
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

	// Token: 0x060120E0 RID: 73952 RVA: 0x0046E878 File Offset: 0x0046CA78
	public long GetPayShopUpdateTime(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopInfoData payShopInfoById = this.GetPayShopInfoById(payShopId);
		if (payShopInfoById == null)
		{
			return 0L;
		}
		return payShopInfoById.UpdateTime;
	}

	// Token: 0x060120E1 RID: 73953 RVA: 0x0046E89C File Offset: 0x0046CA9C
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

	// Token: 0x060120E2 RID: 73954 RVA: 0x0046E900 File Offset: 0x0046CB00
	public void UpdateActivityPayShopGoodsCount(int goodsId, int count)
	{
		PayShopGoods payShopGoods;
		if (this.PayShopGoodsMap.TryGetValue(goodsId, out payShopGoods) && payShopGoods.IsLimitGoods())
		{
			payShopGoods.AddBoughtCount(count);
		}
	}

	// Token: 0x060120E3 RID: 73955 RVA: 0x0046E92C File Offset: 0x0046CB2C
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

	// Token: 0x060120E4 RID: 73956 RVA: 0x0046E9A8 File Offset: 0x0046CBA8
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

	// Token: 0x060120E5 RID: 73957 RVA: 0x0046EA18 File Offset: 0x0046CC18
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
		if (!PayShopDefine.payShopViewTabType.Contains(payShopInfoTabViewType))
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

	// Token: 0x060120E6 RID: 73958 RVA: 0x0046EAD0 File Offset: 0x0046CCD0
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

	// Token: 0x060120E7 RID: 73959 RVA: 0x0046EBC8 File Offset: 0x0046CDC8
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

	// Token: 0x060120E8 RID: 73960 RVA: 0x0046EC24 File Offset: 0x0046CE24
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

	// Token: 0x060120E9 RID: 73961 RVA: 0x0046ED10 File Offset: 0x0046CF10
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

	// Token: 0x060120EA RID: 73962 RVA: 0x0046EDD4 File Offset: 0x0046CFD4
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

	// Token: 0x060120EB RID: 73963 RVA: 0x0046EE5C File Offset: 0x0046D05C
	public int GetPayShopInfoTabViewType(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopInfoData payShopInfoById = this.GetPayShopInfoById(payShopId);
		if (payShopInfoById == null)
		{
			return 0;
		}
		return payShopInfoById.ShopTabViewType;
	}

	// Token: 0x060120EC RID: 73964 RVA: 0x0046EE7C File Offset: 0x0046D07C
	public int GetPayShopInfoDynamicTabId(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopInfoData payShopInfoById = this.GetPayShopInfoById(payShopId);
		if (payShopInfoById == null)
		{
			return 0;
		}
		return payShopInfoById.DynamicTabId;
	}

	// Token: 0x060120ED RID: 73965 RVA: 0x0046EE9C File Offset: 0x0046D09C
	public int GetPayShopInfoSortRule(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopInfoData payShopInfoById = this.GetPayShopInfoById(payShopId);
		if (payShopInfoById == null)
		{
			return 0;
		}
		return payShopInfoById.SortRule;
	}

	// Token: 0x060120EE RID: 73966 RVA: 0x0046EEBC File Offset: 0x0046D0BC
	public int GetPayShopInfoSort(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopInfoData payShopInfoById = this.GetPayShopInfoById(payShopId);
		if (payShopInfoById == null)
		{
			return 0;
		}
		return payShopInfoById.Sort;
	}

	// Token: 0x060120EF RID: 73967 RVA: 0x0046EEDC File Offset: 0x0046D0DC
	public void AddPreviewPayGiftEntry(int configId, IPreviewPayGiftEntry entry)
	{
		if (configId <= 0)
		{
			return;
		}
		this.PreviewPayGiftEntryMap[configId] = entry;
	}

	// Token: 0x060120F0 RID: 73968 RVA: 0x0046EEF0 File Offset: 0x0046D0F0
	[NullableContext(2)]
	public IPreviewPayGiftEntry TryGetPreviewPayGiftEntry(int configId)
	{
		return this.PreviewPayGiftEntryMap.GetValueOrDefault(configId);
	}

	// Token: 0x060120F1 RID: 73969 RVA: 0x0046EEFE File Offset: 0x0046D0FE
	public void ClearPreviewPayGiftEntries()
	{
		if (this.PreviewPayGiftEntryMap.Count == 0)
		{
			return;
		}
		this.PreviewPayGiftEntryMap.Clear();
	}

	// Token: 0x060120F2 RID: 73970 RVA: 0x0046EF1C File Offset: 0x0046D11C
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

	// Token: 0x060120F3 RID: 73971 RVA: 0x0046F024 File Offset: 0x0046D224
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

	// Token: 0x060120F4 RID: 73972 RVA: 0x0046F0A4 File Offset: 0x0046D2A4
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

	// Token: 0x060120F5 RID: 73973 RVA: 0x0046F0EC File Offset: 0x0046D2EC
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

	// Token: 0x060120F6 RID: 73974 RVA: 0x0046F13C File Offset: 0x0046D33C
	public List<int> GetPayShopInfoMoney(PayShopDefine.EPayShopTabType payShopId)
	{
		PayShopInfoData payShopInfoById = this.GetPayShopInfoById(payShopId);
		if (payShopInfoById == null)
		{
			return new List<int>();
		}
		return payShopInfoById.Money;
	}

	// Token: 0x060120F7 RID: 73975 RVA: 0x0046F160 File Offset: 0x0046D360
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

	// Token: 0x060120F8 RID: 73976 RVA: 0x0046F23C File Offset: 0x0046D43C
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

	// Token: 0x060120F9 RID: 73977 RVA: 0x0046F2A4 File Offset: 0x0046D4A4
	public List<PayShopRecommendData> GetRecommendData()
	{
		List<PayShopRecommendData> list = new List<PayShopRecommendData>();
		foreach (PayShopRecommendData item in this.PayShopRecommendData.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x060120FA RID: 73978 RVA: 0x0046F304 File Offset: 0x0046D504
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

	// Token: 0x060120FB RID: 73979 RVA: 0x0046F36C File Offset: 0x0046D56C
	public PayShopRecommendData GetRecommendDataById(int id)
	{
		PayShopRecommendData result;
		if (this.PayShopRecommendData.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060120FC RID: 73980 RVA: 0x0046F38C File Offset: 0x0046D58C
	public void ClearData()
	{
		this.PayShopInfoMap.Clear();
		this.PayShopMap.Clear();
		this.PayShopGoodsMap.Clear();
		this.PreviewPayGiftEntryMap.Clear();
		this.ConsoleExtraPerformancePayGiftId = 0;
	}

	// Token: 0x17001796 RID: 6038
	// (get) Token: 0x060120FD RID: 73981 RVA: 0x0046F3C1 File Offset: 0x0046D5C1
	public static PayShopModel Instance
	{
		get
		{
			return PayShopModel._Instance;
		}
	}

	// Token: 0x060120FE RID: 73982 RVA: 0x0046F3C8 File Offset: 0x0046D5C8
	public static PayShopModel GetOrCreateInstance()
	{
		if (PayShopModel._Instance == null)
		{
			PayShopModel.CreateInstance();
		}
		return PayShopModel._Instance;
	}

	// Token: 0x060120FF RID: 73983 RVA: 0x0046F3DC File Offset: 0x0046D5DC
	public static bool CreateInstance()
	{
		if (PayShopModel._Instance != null)
		{
			return true;
		}
		PayShopModel._Instance = new PayShopModel();
		return true;
	}

	// Token: 0x06012100 RID: 73984 RVA: 0x0046F3F2 File Offset: 0x0046D5F2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012101 RID: 73985 RVA: 0x0046F3F4 File Offset: 0x0046D5F4
	public static void ResetStaticDefaultValue()
	{
		PayShopModel._Instance = null;
	}

	// Token: 0x06012102 RID: 73986 RVA: 0x0046F3FC File Offset: 0x0046D5FC
	static PayShopModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PayShopModel.CreateStaticDefaultValue), new Action(PayShopModel.ResetStaticDefaultValue));
	}

	// Token: 0x040088AD RID: 34989
	private readonly Dictionary<PayShopDefine.EPayShopTabType, PayShopInfoData> PayShopInfoMap = new Dictionary<PayShopDefine.EPayShopTabType, PayShopInfoData>();

	// Token: 0x040088AE RID: 34990
	private readonly Dictionary<PayShopDefine.EPayShopTabType, HashSet<int>> PayShopMap = new Dictionary<PayShopDefine.EPayShopTabType, HashSet<int>>();

	// Token: 0x040088AF RID: 34991
	private readonly Dictionary<int, PayShopGoods> PayShopGoodsMap = new Dictionary<int, PayShopGoods>();

	// Token: 0x040088B0 RID: 34992
	private List<PayShopTabData> PayShopTabArray = new List<PayShopTabData>();

	// Token: 0x040088B1 RID: 34993
	private readonly Dictionary<int, PayShopRecommendData> PayShopRecommendData = new Dictionary<int, PayShopRecommendData>();

	// Token: 0x040088B2 RID: 34994
	private string DataVersionInternal = "";

	// Token: 0x040088B3 RID: 34995
	private int CurrentPayShopId;

	// Token: 0x040088B4 RID: 34996
	private bool ShopChangeDirty;

	// Token: 0x040088B5 RID: 34997
	private List<PayShopDefine.EPayShopTabType> CurrentPayShopTabTypeList = new List<PayShopDefine.EPayShopTabType>();

	// Token: 0x040088B6 RID: 34998
	public bool BusinessCompliance;

	// Token: 0x040088B7 RID: 34999
	public int ConsoleExtraPerformancePayGiftId;

	// Token: 0x040088B8 RID: 35000
	private readonly Dictionary<int, IPreviewPayGiftEntry> PreviewPayGiftEntryMap = new Dictionary<int, IPreviewPayGiftEntry>();

	// Token: 0x040088B9 RID: 35001
	private readonly Dictionary<PayShopDefine.EPayShopTabType, Func<bool>> VisibilityPredicates;

	// Token: 0x040088BA RID: 35002
	[Nullable(2)]
	private static PayShopModel _Instance;
}
