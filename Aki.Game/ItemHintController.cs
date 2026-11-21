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

// Token: 0x020014C6 RID: 5318
[NullableContext(1)]
[Nullable(0)]
[TickController(42)]
public class ItemHintController : UiControllerBase
{
	// Token: 0x17001395 RID: 5013
	// (get) Token: 0x0600D4B7 RID: 54455 RVA: 0x003F3D10 File Offset: 0x003F1F10
	protected override bool IsTickEvenPausedInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0600D4B8 RID: 54456 RVA: 0x003F3D13 File Offset: 0x003F1F13
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.ItemRewardNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleItemRewardNotify));
	}

	// Token: 0x0600D4B9 RID: 54457 RVA: 0x003F3D31 File Offset: 0x003F1F31
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.ItemRewardNotify);
	}

	// Token: 0x0600D4BA RID: 54458 RVA: 0x003F3D43 File Offset: 0x003F1F43
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

	// Token: 0x0600D4BB RID: 54459 RVA: 0x003F3D60 File Offset: 0x003F1F60
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

	// Token: 0x0600D4BC RID: 54460 RVA: 0x003F3DB4 File Offset: 0x003F1FB4
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

	// Token: 0x0600D4BD RID: 54461 RVA: 0x003F3E48 File Offset: 0x003F2048
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

	// Token: 0x0600D4BE RID: 54462 RVA: 0x003F406C File Offset: 0x003F226C
	public static void AddItemRewardList(ItemRewardNotify itemRewardInfo)
	{
		ItemHintModel.Instance.AddItemRewardList(itemRewardInfo);
	}

	// Token: 0x0600D4BF RID: 54463 RVA: 0x003F407C File Offset: 0x003F227C
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

	// Token: 0x0600D4C0 RID: 54464 RVA: 0x003F4314 File Offset: 0x003F2514
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

	// Token: 0x0600D4C1 RID: 54465 RVA: 0x003F438C File Offset: 0x003F258C
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

	// Token: 0x0600D4C2 RID: 54466 RVA: 0x003F44C0 File Offset: 0x003F26C0
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

	// Token: 0x0600D4C3 RID: 54467 RVA: 0x003F45FC File Offset: 0x003F27FC
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

	// Token: 0x0600D4C4 RID: 54468 RVA: 0x003F4738 File Offset: 0x003F2938
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

	// Token: 0x0600D4C5 RID: 54469 RVA: 0x003F477C File Offset: 0x003F297C
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

	// Token: 0x0600D4C6 RID: 54470 RVA: 0x003F47C0 File Offset: 0x003F29C0
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

	// Token: 0x0600D4C7 RID: 54471 RVA: 0x003F488C File Offset: 0x003F2A8C
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

	// Token: 0x0600D4C8 RID: 54472 RVA: 0x003F4960 File Offset: 0x003F2B60
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

	// Token: 0x0600D4C9 RID: 54473 RVA: 0x003F49D8 File Offset: 0x003F2BD8
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

	// Token: 0x0600D4CA RID: 54474 RVA: 0x003F4A14 File Offset: 0x003F2C14
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

	// Token: 0x0600D4CB RID: 54475 RVA: 0x003F4AA0 File Offset: 0x003F2CA0
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

	// Token: 0x0600D4CC RID: 54476 RVA: 0x003F4B2C File Offset: 0x003F2D2C
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

	// Token: 0x0600D4CD RID: 54477 RVA: 0x003F4BB0 File Offset: 0x003F2DB0
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

	// Token: 0x0600D4CE RID: 54478 RVA: 0x003F4C08 File Offset: 0x003F2E08
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

	// Token: 0x0600D4CF RID: 54479 RVA: 0x003F4C50 File Offset: 0x003F2E50
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

	// Token: 0x0600D4D0 RID: 54480 RVA: 0x003F4CC1 File Offset: 0x003F2EC1
	private void CheckVisibility()
	{
		this.CheckVisibilityInternal();
	}

	// Token: 0x0600D4D1 RID: 54481 RVA: 0x003F4CC9 File Offset: 0x003F2EC9
	private void CheckVisibility(PlotInfo plotInfo)
	{
		this.CheckVisibilityInternal();
	}

	// Token: 0x0600D4D2 RID: 54482 RVA: 0x003F4CD1 File Offset: 0x003F2ED1
	private void CheckVisibility(PlotResultInfo plotResultInfo)
	{
		this.CheckVisibilityInternal();
	}

	// Token: 0x0600D4D3 RID: 54483 RVA: 0x003F4CD9 File Offset: 0x003F2ED9
	private void CheckVisibility(EUiViewName viewName, int viewId)
	{
		this.CheckVisibilityInternal();
	}

	// Token: 0x0600D4D4 RID: 54484 RVA: 0x003F4CE4 File Offset: 0x003F2EE4
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

	// Token: 0x0600D4D5 RID: 54485 RVA: 0x003F4D7C File Offset: 0x003F2F7C
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

	// Token: 0x0600D4D6 RID: 54486 RVA: 0x003F4DC5 File Offset: 0x003F2FC5
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

	// Token: 0x0600D4D7 RID: 54487 RVA: 0x003F4DEC File Offset: 0x003F2FEC
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

	// Token: 0x0600D4D8 RID: 54488 RVA: 0x003F4FF8 File Offset: 0x003F31F8
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

	// Token: 0x17001396 RID: 5014
	// (get) Token: 0x0600D4D9 RID: 54489 RVA: 0x003F5077 File Offset: 0x003F3277
	public static ItemHintController Instance
	{
		get
		{
			return ItemHintController._Instance;
		}
	}

	// Token: 0x0600D4DA RID: 54490 RVA: 0x003F507E File Offset: 0x003F327E
	public static ItemHintController GetOrCreateInstance()
	{
		if (ItemHintController._Instance == null)
		{
			ItemHintController.CreateInstance();
		}
		return ItemHintController._Instance;
	}

	// Token: 0x0600D4DB RID: 54491 RVA: 0x003F5092 File Offset: 0x003F3292
	public static bool CreateInstance()
	{
		if (ItemHintController._Instance != null)
		{
			return true;
		}
		ItemHintController._Instance = new ItemHintController();
		return true;
	}

	// Token: 0x0600D4DC RID: 54492 RVA: 0x003F50A8 File Offset: 0x003F32A8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D4DD RID: 54493 RVA: 0x003F50AA File Offset: 0x003F32AA
	public static void ResetStaticDefaultValue()
	{
		ItemHintController._Instance = null;
	}

	// Token: 0x0600D4DE RID: 54494 RVA: 0x003F50B2 File Offset: 0x003F32B2
	static ItemHintController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemHintController.CreateStaticDefaultValue), new Action(ItemHintController.ResetStaticDefaultValue));
	}

	// Token: 0x0400778D RID: 30605
	public bool IsPrintNoRewardReason;

	// Token: 0x0400778E RID: 30606
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

	// Token: 0x0400778F RID: 30607
	[Nullable(2)]
	private static ItemHintController _Instance;
}
