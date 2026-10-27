using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02001FF3 RID: 8179
[NullableContext(1)]
[Nullable(0)]
[TickController(42)]
public class ItemHintController : UiControllerBase
{
	// Token: 0x17001368 RID: 4968
	// (get) Token: 0x0601004F RID: 65615 RVA: 0x003E7718 File Offset: 0x003E5918
	protected override bool IsTickEvenPausedInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06010050 RID: 65616 RVA: 0x003E771B File Offset: 0x003E591B
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ItemRewardNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleItemRewardNotify));
	}

	// Token: 0x06010051 RID: 65617 RVA: 0x003E7739 File Offset: 0x003E5939
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ItemRewardNotify);
	}

	// Token: 0x06010052 RID: 65618 RVA: 0x003E774B File Offset: 0x003E594B
	private void TryOpenItemReward(AddCountItemInfo[] addCountItemInfoList)
	{
		if (addCountItemInfoList.Length == 0)
		{
			return;
		}
		if (this.CheckShowInItemHint())
		{
			ItemHintModel.Instance.MainInterfaceInsertItemRewardInfo(addCountItemInfoList);
		}
	}

	// Token: 0x06010053 RID: 65619 RVA: 0x003E7768 File Offset: 0x003E5968
	private bool CheckShowInItemHint()
	{
		if (this.CanShowHintOtherViewIsOpen(true))
		{
			return true;
		}
		UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.PlotView);
		if (viewByName != null && !viewByName.IsRegister)
		{
			return true;
		}
		UiViewBase viewByName2 = UiManager.Instance.GetViewByName(EUiViewName.FunctionOpenView);
		return viewByName2 != null && !viewByName2.IsRegister;
	}

	// Token: 0x06010054 RID: 65620 RVA: 0x003E77BC File Offset: 0x003E59BC
	[NullableContext(2)]
	public void HandleRecallItemRewardNotify(IMessage msg, Net.CallbackStatus status)
	{
		RecallItemRewardNotify recallItemRewardNotify = (RecallItemRewardNotify)msg;
		ItemRewardNotify itemRewardNotify = ItemRewardNotify.Create();
		itemRewardNotify.DropId = recallItemRewardNotify.DropId;
		itemRewardNotify.Reason = recallItemRewardNotify.Reason;
		RewardItemInfoList rewardItemInfoList = RewardItemInfoList.Create();
		foreach (RewardItemInfo item in recallItemRewardNotify.RewardItems)
		{
			rewardItemInfoList.ItemList.Add(item);
		}
		itemRewardNotify.RewardItems.Add(0, rewardItemInfoList);
		this.HandleItemRewardNotify(itemRewardNotify, status);
	}

	// Token: 0x06010055 RID: 65621 RVA: 0x003E7850 File Offset: 0x003E5A50
	[NullableContext(2)]
	public void HandleItemRewardNotify(IMessage msg, Net.CallbackStatus status)
	{
		ItemRewardNotify itemRewardNotify = (ItemRewardNotify)msg;
		MapField<int, RewardItemInfoList> rewardItems = itemRewardNotify.RewardItems;
		if (rewardItems == null)
		{
			return;
		}
		DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(itemRewardNotify.DropId);
		EShowBgType? eshowBgType = null;
		if (!dropPackage.Value.ShowBg)
		{
			eshowBgType = new EShowBgType?(EShowBgType.None);
		}
		else
		{
			foreach (int key in rewardItems.Keys)
			{
				RewardItemInfoList rewardItemInfoList;
				if (rewardItems.TryGetValue(key, out rewardItemInfoList) && rewardItemInfoList != null)
				{
					RepeatedField<RewardItemInfo> itemList = rewardItemInfoList.ItemList;
					if (itemList != null)
					{
						foreach (RewardItemInfo rewardItemInfo in itemList)
						{
							int showPlanId = rewardItemInfo.ShowPlanId;
							DropShowPlan? dropShowPlan = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropShowPlan(showPlanId);
							if (dropShowPlan == null)
							{
								Log instance = Log.Instance;
								ELogModule module = ELogModule.ItemHint;
								ELogAuthor author = ELogAuthor.CFT;
								string message = "缺少showPlan配置";
								ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("showPlanId", showPlanId);
								instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
							}
							else if (dropShowPlan.Value.ShowBg != 0 && rewardItemInfo.Count > 0)
							{
								if (eshowBgType == null)
								{
									eshowBgType = new EShowBgType?((EShowBgType)dropShowPlan.Value.ShowBg);
								}
								else if (eshowBgType.Value != (EShowBgType)dropShowPlan.Value.ShowBg)
								{
									Log instance2 = Log.Instance;
									ELogModule module2 = ELogModule.ItemHint;
									ELogAuthor author2 = ELogAuthor.CFT;
									string message2 = "一次掉落有多个不同背景的掉落组，请检查配置";
									ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("dropId", itemRewardNotify.DropId);
									instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
								}
							}
						}
					}
				}
			}
		}
		if (eshowBgType != null)
		{
			EShowBgType valueOrDefault = eshowBgType.GetValueOrDefault();
			if (valueOrDefault != EShowBgType.None && valueOrDefault - EShowBgType.ItemReward <= 2)
			{
				ItemHintController.AddItemRewardList(itemRewardNotify);
			}
		}
		EventSystem.Instance.Emit<ItemRewardNotify>(EEventName.OnItemRewardNotify, itemRewardNotify);
	}

	// Token: 0x06010056 RID: 65622 RVA: 0x003E7A74 File Offset: 0x003E5C74
	public static void AddItemRewardList(ItemRewardNotify itemRewardInfo)
	{
		ItemHintModel.Instance.AddItemRewardList(itemRewardInfo);
	}

	// Token: 0x06010057 RID: 65623 RVA: 0x003E7A84 File Offset: 0x003E5C84
	public ItemRewardInfo[] CombineAllShowItems(ItemRewardNotify inItemRewardNotify, bool needSort)
	{
		List<ItemRewardInfo> list = new List<ItemRewardInfo>();
		Dictionary<int, ItemRewardInfo> dictionary = new Dictionary<int, ItemRewardInfo>();
		MapField<int, RewardItemInfoList> rewardItems = inItemRewardNotify.RewardItems;
		if (rewardItems == null)
		{
			return list.ToArray();
		}
		foreach (int key in rewardItems.Keys)
		{
			RewardItemInfoList rewardItemInfoList;
			if (rewardItems.TryGetValue(key, out rewardItemInfoList) && rewardItemInfoList != null)
			{
				RepeatedField<RewardItemInfo> itemList = rewardItemInfoList.ItemList;
				if (itemList != null)
				{
					foreach (RewardItemInfo rewardItemInfo in itemList)
					{
						if (rewardItemInfo.Count != 0)
						{
							DropShowPlan? dropShowPlan = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropShowPlan(rewardItemInfo.ShowPlanId);
							if (dropShowPlan == null)
							{
								Log instance = Log.Instance;
								ELogModule module = ELogModule.ItemHint;
								ELogAuthor author = ELogAuthor.CFT;
								string message = "缺少ShowPlan配置";
								ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("showPlanId", rewardItemInfo.ShowPlanId);
								instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
							}
							else if (dropShowPlan.Value.ShowBg != 0)
							{
								if (dictionary.ContainsKey(rewardItemInfo.ItemId))
								{
									dictionary[rewardItemInfo.ItemId].ItemCount += rewardItemInfo.Count;
								}
								else
								{
									CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(rewardItemInfo.ItemId);
									ItemRewardInfo itemRewardInfo = new ItemRewardInfo();
									itemRewardInfo.ItemId = new int?(rewardItemInfo.ItemId);
									itemRewardInfo.ItemCount = new int?(rewardItemInfo.Count);
									itemRewardInfo.Quality = itemConfigData.QualityId;
									dictionary.Add(itemRewardInfo.ItemId.Value, itemRewardInfo);
								}
							}
						}
					}
				}
			}
		}
		foreach (KeyValuePair<int, ItemRewardInfo> keyValuePair in dictionary)
		{
			list.Add(keyValuePair.Value);
		}
		if (needSort)
		{
			list.Sort(delegate(ItemRewardInfo a, ItemRewardInfo b)
			{
				if (a.Quality != b.Quality)
				{
					return a.Quality - b.Quality;
				}
				return a.ItemId.Value - b.ItemId.Value;
			});
		}
		return list.ToArray();
	}

	// Token: 0x06010058 RID: 65624 RVA: 0x003E7D1C File Offset: 0x003E5F1C
	public static List<TItem> ConvertRewardListToItem(List<ItemRewardInfo> itemList)
	{
		List<TItem> list = new List<TItem>();
		foreach (ItemRewardInfo itemRewardInfo in itemList)
		{
			TItem item = new TItem(new InventoryDefine.GetItemData(itemRewardInfo.ItemId.Value, 0), itemRewardInfo.ItemCount.Value);
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06010059 RID: 65625 RVA: 0x003E7D94 File Offset: 0x003E5F94
	public DropShowPlan? GetFirstShowBgDropGroup(ItemRewardNotify inItemRewardNotify)
	{
		MapField<int, RewardItemInfoList> rewardItems = inItemRewardNotify.RewardItems;
		if (rewardItems == null)
		{
			return null;
		}
		foreach (int key in rewardItems.Keys)
		{
			RewardItemInfoList rewardItemInfoList;
			if (rewardItems.TryGetValue(key, out rewardItemInfoList) && rewardItemInfoList != null)
			{
				RepeatedField<RewardItemInfo> itemList = rewardItemInfoList.ItemList;
				if (itemList != null)
				{
					foreach (RewardItemInfo rewardItemInfo in itemList)
					{
						int showPlanId = rewardItemInfo.ShowPlanId;
						DropShowPlan? dropShowPlan = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropShowPlan(showPlanId);
						if (dropShowPlan == null)
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.ItemHint;
							ELogAuthor author = ELogAuthor.CFT;
							string message = "缺少ShowPlan配置";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("showPlanId", rewardItemInfo.ShowPlanId);
							instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						}
						else if (dropShowPlan.Value.ShowBg != 0)
						{
							return dropShowPlan;
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0601005A RID: 65626 RVA: 0x003E7EC8 File Offset: 0x003E60C8
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<int, int, int, int, int, int, int>(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
		EventSystem.Instance.Add<int, int, int>(EEventName.OnPlayerExpChanged, new Action<int, int, int>(this.OnPlayerExpChanged));
		EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.CheckVisibility));
		EventSystem.Instance.Add<PlotResultInfo>(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.CheckVisibility));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.CheckVisibility));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.CheckVisibility));
		EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.CheckVisibility));
		EventSystem.Instance.Add<IReadOnlyList<WeaponItem>, bool, bool>(EEventName.OnAddWeaponItemList, new Action<IReadOnlyList<WeaponItem>, bool, bool>(this.OnAddWeaponItemList));
		EventSystem.Instance.Add<IReadOnlyList<Aki.Protocol.PhantomItem>, bool>(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<Aki.Protocol.PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Add<TItem>(EEventName.OnAddFavorItem, new Action<TItem>(this.OnAddFavorItem));
		EventSystem.Instance.Add<TItem[]>(EEventName.OnAddOrnamentItemList, new Action<TItem[]>(this.OnAddOrnamentItemList));
	}

	// Token: 0x0601005B RID: 65627 RVA: 0x003E8004 File Offset: 0x003E6204
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnPlayerLevelChanged, new Action<int, int, int, int, int, int, int>(this.OnPlayerLevelChanged));
		EventSystem.Instance.Remove(EEventName.OnPlayerExpChanged, new Action<int, int, int>(this.OnPlayerExpChanged));
		EventSystem.Instance.Remove<PlotInfo>(EEventName.PlotNetworkStart, delegate(PlotInfo data)
		{
			this.CheckVisibility(data);
		});
		EventSystem.Instance.Remove<PlotResultInfo>(EEventName.PlotNetworkEnd, delegate(PlotResultInfo data)
		{
			this.CheckVisibility(data);
		});
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, delegate(EUiViewName name, int id)
		{
			this.CheckVisibility(name, id);
		});
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, delegate(EUiViewName name, int id)
		{
			this.CheckVisibility(name, id);
		});
		EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.CheckVisibility));
		EventSystem.Instance.Remove(EEventName.OnAddWeaponItemList, new Action<IReadOnlyList<WeaponItem>, bool, bool>(this.OnAddWeaponItemList));
		EventSystem.Instance.Remove(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<Aki.Protocol.PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Remove(EEventName.OnAddFavorItem, new Action<TItem>(this.OnAddFavorItem));
		EventSystem.Instance.Remove<TItem[]>(EEventName.OnAddOrnamentItemList, new Action<TItem[]>(this.OnAddOrnamentItemList));
	}

	// Token: 0x0601005C RID: 65628 RVA: 0x003E8140 File Offset: 0x003E6340
	private void OnPlayerLevelChanged(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp)
	{
		List<AddCountItemInfo> list = new List<AddCountItemInfo>();
		AddCountItemInfo addCountItemInfo = AddCountItemInfo.Create();
		addCountItemInfo.Id = 1;
		addCountItemInfo.Count = addExp;
		addCountItemInfo.IncrId = 0;
		list.Add(addCountItemInfo);
		this.TryOpenItemReward(list.ToArray());
	}

	// Token: 0x0601005D RID: 65629 RVA: 0x003E8184 File Offset: 0x003E6384
	private void OnPlayerExpChanged(int currentExp, int lastExp, int maxExp)
	{
		List<AddCountItemInfo> list = new List<AddCountItemInfo>();
		AddCountItemInfo addCountItemInfo = AddCountItemInfo.Create();
		addCountItemInfo.Id = 1;
		addCountItemInfo.Count = currentExp - lastExp;
		addCountItemInfo.IncrId = 0;
		list.Add(addCountItemInfo);
		this.TryOpenItemReward(list.ToArray());
	}

	// Token: 0x0601005E RID: 65630 RVA: 0x003E81C8 File Offset: 0x003E63C8
	public void AddCommonItemList(IReadOnlyList<NormalItem> normalItemList)
	{
		List<AddCountItemInfo> list = new List<AddCountItemInfo>();
		InventoryModel instance = InventoryModel.Instance;
		foreach (NormalItem normalItem in normalItemList)
		{
			int id = normalItem.Id;
			if (id != 1)
			{
				CommonItemData commonItemData = instance.GetCommonItemData(id, 0);
				if (commonItemData != null)
				{
					int lastCount = commonItemData.GetLastCount();
					int count = normalItem.Count;
					int num = (lastCount > 0) ? (count - lastCount) : count;
					if (num >= 0)
					{
						AddCountItemInfo addCountItemInfo = AddCountItemInfo.Create();
						addCountItemInfo.Id = normalItem.Id;
						addCountItemInfo.Count = num;
						addCountItemInfo.IncrId = 0;
						list.Add(addCountItemInfo);
					}
				}
			}
		}
		ItemHintController.Instance.TryOpenItemReward(list.ToArray());
	}

	// Token: 0x0601005F RID: 65631 RVA: 0x003E8294 File Offset: 0x003E6494
	public void AddCommonItemList(IReadOnlyList<ValidTimeItem> normalItemList)
	{
		List<AddCountItemInfo> list = new List<AddCountItemInfo>();
		InventoryModel instance = InventoryModel.Instance;
		foreach (ValidTimeItem validTimeItem in normalItemList)
		{
			int id = validTimeItem.Id;
			if (id != 1)
			{
				CommonItemData commonItemData = instance.GetCommonItemData(id, 0);
				if (commonItemData != null)
				{
					int lastCount = commonItemData.GetLastCount();
					int count = validTimeItem.Count;
					int num = (lastCount > 0) ? (count - lastCount) : count;
					if (num >= 0)
					{
						AddCountItemInfo addCountItemInfo = AddCountItemInfo.Create();
						addCountItemInfo.Id = validTimeItem.Id;
						addCountItemInfo.Count = num;
						addCountItemInfo.IncrId = validTimeItem.IncrId;
						list.Add(addCountItemInfo);
					}
				}
			}
		}
		ItemHintController.Instance.TryOpenItemReward(list.ToArray());
	}

	// Token: 0x06010060 RID: 65632 RVA: 0x003E8368 File Offset: 0x003E6568
	public void AddRecallItemList([TupleElementNames(new string[]
	{
		"configId",
		"addCount"
	})] [Nullable(new byte[]
	{
		1,
		0
	})] ValueTuple<int, int>[] addCountList)
	{
		List<AddCountItemInfo> list = new List<AddCountItemInfo>();
		foreach (ValueTuple<int, int> valueTuple in addCountList)
		{
			int item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			if (item != 1 && item2 > 0)
			{
				AddCountItemInfo addCountItemInfo = AddCountItemInfo.Create();
				addCountItemInfo.Id = item;
				addCountItemInfo.Count = item2;
				addCountItemInfo.IncrId = 0;
				list.Add(addCountItemInfo);
			}
		}
		this.TryOpenItemReward(list.ToArray());
	}

	// Token: 0x06010061 RID: 65633 RVA: 0x003E83E0 File Offset: 0x003E65E0
	public void AddRoguelikeItemList(int itemId, int count)
	{
		AddCountItemInfo addCountItemInfo = AddCountItemInfo.Create();
		addCountItemInfo.Id = itemId;
		addCountItemInfo.Count = count;
		addCountItemInfo.IncrId = 0;
		ItemHintModel.Instance.MainInterfaceInsertItemRewardInfo(new AddCountItemInfo[]
		{
			addCountItemInfo
		});
	}

	// Token: 0x06010062 RID: 65634 RVA: 0x003E841C File Offset: 0x003E661C
	public void AddAbyssItemList(Dictionary<int, int> dataMap)
	{
		List<AddCountItemInfo> list = new List<AddCountItemInfo>();
		foreach (KeyValuePair<int, int> keyValuePair in dataMap)
		{
			AddCountItemInfo addCountItemInfo = AddCountItemInfo.Create();
			addCountItemInfo.Id = keyValuePair.Key;
			addCountItemInfo.Count = keyValuePair.Value;
			addCountItemInfo.IncrId = 0;
			list.Add(addCountItemInfo);
		}
		ItemHintModel.Instance.MainInterfaceInsertItemRewardInfo(list.ToArray());
	}

	// Token: 0x06010063 RID: 65635 RVA: 0x003E84A8 File Offset: 0x003E66A8
	public void AddItemRewardInfoList([Nullable(new byte[]
	{
		1,
		0
	})] List<ValueTuple<int, int>> infoList)
	{
		List<AddCountItemInfo> list = new List<AddCountItemInfo>();
		foreach (ValueTuple<int, int> valueTuple in infoList)
		{
			AddCountItemInfo addCountItemInfo = AddCountItemInfo.Create();
			addCountItemInfo.Id = valueTuple.Item1;
			addCountItemInfo.Count = valueTuple.Item2;
			addCountItemInfo.IncrId = 0;
			list.Add(addCountItemInfo);
		}
		ItemHintModel.Instance.MainInterfaceInsertItemRewardInfo(list.ToArray());
	}

	// Token: 0x06010064 RID: 65636 RVA: 0x003E8534 File Offset: 0x003E6734
	private void OnAddWeaponItemList(IReadOnlyList<WeaponItem> weaponItemList, bool bAddFromRole, bool bShowNewTips)
	{
		if (bAddFromRole || !bShowNewTips)
		{
			return;
		}
		List<AddCountItemInfo> list = new List<AddCountItemInfo>();
		foreach (WeaponItem weaponItem in weaponItemList)
		{
			AddCountItemInfo addCountItemInfo = AddCountItemInfo.Create();
			addCountItemInfo.Id = weaponItem.Id;
			addCountItemInfo.Count = 1;
			addCountItemInfo.IncrId = 0;
			list.Add(addCountItemInfo);
		}
		this.TryOpenItemReward(list.ToArray());
	}

	// Token: 0x06010065 RID: 65637 RVA: 0x003E85B8 File Offset: 0x003E67B8
	private void OnAddPhantomItemList(IReadOnlyList<Aki.Protocol.PhantomItem> phantomItemList, bool isCatch)
	{
		if (!isCatch)
		{
			return;
		}
		foreach (Aki.Protocol.PhantomItem phantomItem in phantomItemList)
		{
			ItemModel.Instance.PushWaitPhantomItem(phantomItem.IncrId);
		}
	}

	// Token: 0x06010066 RID: 65638 RVA: 0x003E8610 File Offset: 0x003E6810
	private void OnAddFavorItem(TItem item)
	{
		AddCountItemInfo addCountItemInfo = AddCountItemInfo.Create();
		addCountItemInfo.Id = item.ItemData.ItemId;
		addCountItemInfo.Count = item.Count;
		addCountItemInfo.IncrId = 0;
		this.TryOpenItemReward(new AddCountItemInfo[]
		{
			addCountItemInfo
		});
	}

	// Token: 0x06010067 RID: 65639 RVA: 0x003E8658 File Offset: 0x003E6858
	private void OnAddOrnamentItemList(TItem[] itemList)
	{
		List<AddCountItemInfo> list = new List<AddCountItemInfo>();
		foreach (TItem titem in itemList)
		{
			AddCountItemInfo addCountItemInfo = AddCountItemInfo.Create();
			addCountItemInfo.Id = titem.ItemData.ItemId;
			addCountItemInfo.Count = titem.Count;
			addCountItemInfo.IncrId = 0;
			list.Add(addCountItemInfo);
		}
		ItemHintModel.Instance.MainInterfaceInsertItemRewardInfo(list.ToArray());
	}

	// Token: 0x06010068 RID: 65640 RVA: 0x003E86C9 File Offset: 0x003E68C9
	private void CheckVisibility()
	{
		this.CheckVisibilityInternal();
	}

	// Token: 0x06010069 RID: 65641 RVA: 0x003E86D1 File Offset: 0x003E68D1
	private void CheckVisibility(PlotInfo plotInfo)
	{
		this.CheckVisibilityInternal();
	}

	// Token: 0x0601006A RID: 65642 RVA: 0x003E86D9 File Offset: 0x003E68D9
	private void CheckVisibility(PlotResultInfo plotResultInfo)
	{
		this.CheckVisibilityInternal();
	}

	// Token: 0x0601006B RID: 65643 RVA: 0x003E86E1 File Offset: 0x003E68E1
	private void CheckVisibility(EUiViewName viewName, int viewId)
	{
		this.CheckVisibilityInternal();
	}

	// Token: 0x0601006C RID: 65644 RVA: 0x003E86EC File Offset: 0x003E68EC
	private void CheckVisibilityInternal()
	{
		bool visibility = ItemHintModel.Instance.Visibility;
		bool flag = PlotModel.Instance.IsInHighLevelPlot();
		bool isLoadingView = LoadingModel.Instance.IsLoadingView;
		bool flag2 = this.CanShowHintOtherViewIsOpen(false);
		bool flag3 = !flag && flag2 && !isLoadingView;
		if (flag3 != visibility)
		{
			ItemHintModel.Instance.Visibility = flag3;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ItemHint;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "奖励可视化状态改变";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Visibility", flag3);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Emit<bool>(EEventName.ItemHintVisibilityChange, flag3);
		}
	}

	// Token: 0x0601006D RID: 65645 RVA: 0x003E8784 File Offset: 0x003E6984
	private bool CanShowHintOtherViewIsOpen(bool isPush = false)
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.BattleView))
		{
			return true;
		}
		if (!UiManager.Instance.IsViewOpen(EUiViewName.DangoMonopolyMainView))
		{
			return false;
		}
		ActivityDangoMonopolyConfig instance = ActivityDangoMonopolyConfig.Instance;
		if (!isPush)
		{
			return instance.GetIsOpenHintShow();
		}
		return instance.GetIsPushHintShow();
	}

	// Token: 0x0601006E RID: 65646 RVA: 0x003E87CD File Offset: 0x003E69CD
	protected override void OnTick(float delta)
	{
		this.CheckItemHint();
		if (!ItemHintModel.Instance.Visibility)
		{
			return;
		}
		ItemController.Instance.CheckNewItemTips();
		this.CheckItemReward();
	}

	// Token: 0x0601006F RID: 65647 RVA: 0x003E87F4 File Offset: 0x003E69F4
	public void CheckItemReward()
	{
		if (ItemHintModel.Instance.IsItemRewardListEmpty)
		{
			bool isPrintNoRewardReason = this.IsPrintNoRewardReason;
			return;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.ItemRewardView) || UiManager.Instance.IsViewOpen(EUiViewName.SceneGameplayItemRewardView) || SundryModel.Instance.IsBlockTips)
		{
			bool isPrintNoRewardReason2 = this.IsPrintNoRewardReason;
			return;
		}
		ItemRewardNotify itemReward = ItemHintModel.Instance.PeekItemRewardListFirst().ItemReward;
		MapField<int, RewardItemInfoList> mapField = (itemReward != null) ? itemReward.RewardItems : null;
		if (mapField == null)
		{
			ItemHintModel.Instance.ShiftItemRewardListFirst();
			bool isPrintNoRewardReason3 = this.IsPrintNoRewardReason;
			return;
		}
		EShowBgType? eshowBgType = null;
		foreach (int key in mapField.Keys)
		{
			RewardItemInfoList rewardItemInfoList;
			if (mapField.TryGetValue(key, out rewardItemInfoList) && rewardItemInfoList != null)
			{
				RepeatedField<RewardItemInfo> itemList = rewardItemInfoList.ItemList;
				if (itemList != null)
				{
					foreach (RewardItemInfo rewardItemInfo in itemList)
					{
						int showPlanId = rewardItemInfo.ShowPlanId;
						DropShowPlan? dropShowPlan = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropShowPlan(showPlanId);
						if (dropShowPlan == null)
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.ItemHint;
							ELogAuthor author = ELogAuthor.CFT;
							string message = "缺少showPlan配置";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("showPlanId", showPlanId);
							instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						}
						else if (dropShowPlan.Value.ShowBg != 0 && rewardItemInfo.Count > 0 && eshowBgType == null)
						{
							eshowBgType = new EShowBgType?((EShowBgType)dropShowPlan.Value.ShowBg);
							break;
						}
					}
				}
			}
		}
		if (eshowBgType != null)
		{
			EShowBgType valueOrDefault = eshowBgType.GetValueOrDefault();
			if (valueOrDefault == EShowBgType.None)
			{
				bool isPrintNoRewardReason4 = this.IsPrintNoRewardReason;
				return;
			}
			if (valueOrDefault - EShowBgType.ItemReward > 2)
			{
				return;
			}
			UiManager.Instance.OpenView(this.showBgTypeToView[eshowBgType.Value].Value, null, null);
		}
	}

	// Token: 0x06010070 RID: 65648 RVA: 0x003E8A00 File Offset: 0x003E6C00
	public void CheckItemHint()
	{
		if (!ItemHintModel.Instance.Visibility)
		{
			bool isPrintNoRewardReason = this.IsPrintNoRewardReason;
			return;
		}
		if (ItemHintModel.Instance.IsMainInterfaceDataEmpty && ItemHintModel.Instance.IsPriorInterfaceDataEmpty)
		{
			bool isPrintNoRewardReason2 = this.IsPrintNoRewardReason;
			return;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.ItemHintView))
		{
			bool isPrintNoRewardReason3 = this.IsPrintNoRewardReason;
			return;
		}
		if (SundryModel.Instance.IsBlockTips)
		{
			bool isPrintNoRewardReason4 = this.IsPrintNoRewardReason;
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.ItemHintView, null, null);
	}

	// Token: 0x17001369 RID: 4969
	// (get) Token: 0x06010071 RID: 65649 RVA: 0x003E8A7F File Offset: 0x003E6C7F
	public static ItemHintController Instance
	{
		get
		{
			return ItemHintController._Instance;
		}
	}

	// Token: 0x06010072 RID: 65650 RVA: 0x003E8A86 File Offset: 0x003E6C86
	public static ItemHintController GetOrCreateInstance()
	{
		if (ItemHintController._Instance == null)
		{
			ItemHintController.CreateInstance();
		}
		return ItemHintController._Instance;
	}

	// Token: 0x06010073 RID: 65651 RVA: 0x003E8A9A File Offset: 0x003E6C9A
	public static bool CreateInstance()
	{
		if (ItemHintController._Instance != null)
		{
			return true;
		}
		ItemHintController._Instance = new ItemHintController();
		return true;
	}

	// Token: 0x06010074 RID: 65652 RVA: 0x003E8AB0 File Offset: 0x003E6CB0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010075 RID: 65653 RVA: 0x003E8AB2 File Offset: 0x003E6CB2
	public static void ResetStaticDefaultValue()
	{
		ItemHintController._Instance = null;
	}

	// Token: 0x06010076 RID: 65654 RVA: 0x003E8ABA File Offset: 0x003E6CBA
	static ItemHintController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemHintController.CreateStaticDefaultValue), new Action(ItemHintController.ResetStaticDefaultValue));
	}

	// Token: 0x040076A4 RID: 30372
	public bool IsPrintNoRewardReason;

	// Token: 0x040076A5 RID: 30373
	private IReadOnlyDictionary<EShowBgType, EUiViewName?> showBgTypeToView = new Dictionary<EShowBgType, EUiViewName?>
	{
		{
			EShowBgType.None,
			null
		},
		{
			EShowBgType.ItemReward,
			new EUiViewName?(EUiViewName.ItemRewardView)
		},
		{
			EShowBgType.ItemRewardWithMouse,
			new EUiViewName?(EUiViewName.ItemRewardView)
		},
		{
			EShowBgType.GameplayItemReward,
			new EUiViewName?(EUiViewName.SceneGameplayItemRewardView)
		}
	};

	// Token: 0x040076A6 RID: 30374
	[Nullable(2)]
	private static ItemHintController _Instance;
}
