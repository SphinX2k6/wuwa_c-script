using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.MusicalInstrument;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FCC RID: 8140
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(false)]
public class InventoryView : UiViewBase
{
	// Token: 0x0600FEA8 RID: 65192 RVA: 0x003DDA15 File Offset: 0x003DBC15
	private bool IsRealPlayerInventory()
	{
		return !RecallQuestModel.Instance.IsInRecallInstance();
	}

	// Token: 0x0600FEA9 RID: 65193 RVA: 0x003DDA26 File Offset: 0x003DBC26
	private bool ShouldHandlePlayerInventoryServerNotices()
	{
		return this.IsRealPlayerInventory();
	}

	// Token: 0x0600FEAA RID: 65194 RVA: 0x003DDA30 File Offset: 0x003DBC30
	public InventoryView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FEAB RID: 65195 RVA: 0x003DDA94 File Offset: 0x003DBC94
	protected unsafe override void OnRegisterComponent()
	{
		int num = 24;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 7;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnClickedDestroyEnterButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnClickedDestroyExitButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(20, new Action(this.OnClickedDestroyExecuteButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(18, new Action<EToggleState>(this.OnClickedAllSelect));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(21, new Action(this.OnClickedManage));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(22, new Action(this.OnClickedRecovery));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(23, new Action(this.OnClickedPhantomPlan));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FEAC RID: 65196 RVA: 0x003DDEFC File Offset: 0x003DC0FC
	private void InitButtonRelationMap()
	{
		this.TipsButtonIndexMap = new Dictionary<ItemViewDefine.ETipsButtonType, int>();
		this.TipsButtonRelationMap = new Dictionary<ItemViewDefine.ETipsButtonType, IButtonInfo>();
		this.TipsButtonRelationMap.Add(ItemViewDefine.ETipsButtonType.Use, new ButtonInfo
		{
			Function = new Action<int>(this.OnClickedUseItemButton),
			Text = "HotKeyText_UseItemTips_Name",
			Index = 0
		});
		this.TipsButtonRelationMap.Add(ItemViewDefine.ETipsButtonType.RouletteEquip, new ButtonInfo
		{
			Function = new Action<int>(this.OnClickedSpecialItemFuncUseButton),
			Text = "Text_ButtonTextConfirm_Text",
			Index = 0
		});
		this.TipsButtonRelationMap.Add(ItemViewDefine.ETipsButtonType.WeaponCultivate, new ButtonInfo
		{
			Function = new Action<int>(this.OnClickedWeaponCultivateButton),
			Text = "Text_BagFosterButton_Text",
			Index = 0
		});
		this.TipsButtonRelationMap.Add(ItemViewDefine.ETipsButtonType.VisionCultivate, new ButtonInfo
		{
			Function = new Action<int>(this.OnClickedVisionCultivateButton),
			Text = "Text_BagFosterButton_Text",
			Index = 0
		});
		this.TipsButtonRelationMap.Add(ItemViewDefine.ETipsButtonType.FragmentMemory, new ButtonInfo
		{
			Function = new Action<int>(this.OnClickFragmentMemoryButton),
			Text = "Text_FragmentMemoryButton_Text",
			Index = 0
		});
		this.TipsButtonRelationMap.Add(ItemViewDefine.ETipsButtonType.EquipBuffItem, new ButtonInfo
		{
			Function = new Action<int>(this.OnClickedUseItemButton),
			Text = "Mask_Wear_01",
			Index = 0
		});
		this.TipsButtonRelationMap.Add(ItemViewDefine.ETipsButtonType.QuestReview, new ButtonInfo
		{
			Function = new Action<int>(this.OnClickedQuestReviewButton),
			Text = "Item_70140005_UseTip",
			Index = 0
		});
		this.TipsButtonRelationMap.Add(ItemViewDefine.ETipsButtonType.ChineseZither, new ButtonInfo
		{
			Function = new Action<int>(this.OnClickedChineseZitherButton),
			Text = "HotKeyText_UseItemTips_Name",
			Index = 0
		});
	}

	// Token: 0x0600FEAD RID: 65197 RVA: 0x003DE0C8 File Offset: 0x003DC2C8
	protected override UniTask OnBeforeStartAsync()
	{
		InventoryView.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<InventoryView.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FEAE RID: 65198 RVA: 0x003DE10B File Offset: 0x003DC30B
	private void RefreshCurrencyShow()
	{
		if (this.CommonCurrencyItem1 == null || this.CommonCurrencyItem2 == null)
		{
			return;
		}
		if (InventoryModel.Instance.SupportInventoryViewShowCurrency())
		{
			this.CommonCurrencyItem1.ShowAsync().Forget<bool>();
			this.CommonCurrencyItem2.ShowAsync().Forget<bool>();
		}
	}

	// Token: 0x0600FEAF RID: 65199 RVA: 0x003DE14A File Offset: 0x003DC34A
	protected override void OnStart()
	{
		EventSystem.Instance.Emit(EEventName.OnVisionRefineSubNeedAck);
	}

	// Token: 0x0600FEB0 RID: 65200 RVA: 0x003DE15C File Offset: 0x003DC35C
	protected override void OnAfterPlayStartSequence()
	{
		int selectedIndex = this.TabComponent.GetSelectedIndex();
		this.TabComponent.ScrollToToggleByIndex(selectedIndex);
	}

	// Token: 0x0600FEB1 RID: 65201 RVA: 0x003DE184 File Offset: 0x003DC384
	protected override void OnBeforeShow()
	{
		int selectedTypeIndex = InventoryModel.Instance.GetSelectedTypeIndex();
		this.TabComponent.SelectToggleByIndex(selectedTypeIndex, true);
		this.SelectedItemTypeHandle(selectedTypeIndex);
	}

	// Token: 0x0600FEB2 RID: 65202 RVA: 0x003DE1B0 File Offset: 0x003DC3B0
	protected override void OnAfterShow()
	{
		this.RefreshAllItemList();
		this.RequestInvalidItemInfo();
	}

	// Token: 0x0600FEB3 RID: 65203 RVA: 0x003DE1C0 File Offset: 0x003DC3C0
	protected override void OnBeforeDestroy()
	{
		foreach (AccessPathButton accessPathButton in this.AccessPathButtonList)
		{
			accessPathButton.Destroy(null);
		}
		this.RemoveItemCdTimer();
		this.ClearAllItemViewData();
		this.AccessPathButtonList.Clear();
		this.SelectedItemIndex = 0;
		this.SelectedItemViewData = null;
		this.ItemScrollView = null;
		this.FilterSortEntrance.Destroy(null);
		this.CommonCurrencyItem1.Destroy(null);
		this.CommonCurrencyItem1 = null;
		this.CommonCurrencyItem2.Destroy(null);
		this.CommonCurrencyItem2 = null;
		this.ItemTipsComponent.Destroy(null);
		this.ItemTipsComponent = null;
		this.TabMarkPositions = null;
		this.TabMarkUniqueIds = null;
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy(null);
			this.TabComponent = null;
		}
		InventoryModel instance = InventoryModel.Instance;
		instance.SaveNewCommonItemConfigIdList();
		instance.SaveNewAttributeItemUniqueIdList();
		instance.SaveRedDotCommonItemConfigIdList();
		instance.SaveRedDotAttributeItemUniqueIdList();
	}

	// Token: 0x0600FEB4 RID: 65204 RVA: 0x003DE2CC File Offset: 0x003DC4CC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<WeaponItem>, bool, bool>(EEventName.OnAddWeaponItemList, new Action<IReadOnlyList<WeaponItem>, bool, bool>(this.OnAddWeaponItemList));
		EventSystem.Instance.Add<IReadOnlyList<Aki.Protocol.PhantomItem>, bool>(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<Aki.Protocol.PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnRemoveWeaponItem, new Action<IReadOnlyList<int>>(this.OnRemoveWeaponItem));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnRemovePhantomItem, new Action<IReadOnlyList<int>>(this.OnRemovePhantomItem));
		EventSystem.Instance.Add(EEventName.OnPhantomItemUpdate, new Action(this.OnPhantomItemUpdate));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnItemFuncValueBatchChange, new Action<IReadOnlyList<int>>(this.OnItemFuncValueBatchChange));
		EventSystem.Instance.Add<int, long, int>(EEventName.OnUseBuffItem, new Action<int, long, int>(this.OnUseBuffItem));
		EventSystem.Instance.Add<int, bool>(EEventName.OnEquipBuffItemUpdate, new Action<int, bool>(this.OnEquipBuffItemUpdate));
		EventSystem.Instance.Add<int, int>(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Add<int?>(EEventName.OnSpecialItemUpdate, new Action<int?>(this.OnSpecialItemUpdate));
		EventSystem.Instance.Add<Dictionary<int, int>>(EEventName.NotifyInvalidItem, new Action<Dictionary<int, int>>(this.OnNotifyInvalidItem));
		EventSystem.Instance.Add<IReadOnlyList<TItem>, IReadOnlyList<TItem>>(EEventName.NotifyExpireConvertItem, new Action<IReadOnlyList<TItem>, IReadOnlyList<TItem>>(this.OnNotifyExpireConvertItem));
		EventSystem.Instance.Add(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevelopInventoryRefresh));
		EventSystem.Instance.Add(EEventName.RoleDevelopNeedItemsChanged, new Action(this.OnRoleDevelopInventoryRefresh));
	}

	// Token: 0x0600FEB5 RID: 65205 RVA: 0x003DE4CC File Offset: 0x003DC6CC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnAddWeaponItemList, new Action<IReadOnlyList<WeaponItem>, bool, bool>(this.OnAddWeaponItemList));
		EventSystem.Instance.Remove(EEventName.OnAddPhantomItemList, new Action<IReadOnlyList<Aki.Protocol.PhantomItem>, bool>(this.OnAddPhantomItemList));
		EventSystem.Instance.Remove(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnCommonItemCountAnyChange));
		EventSystem.Instance.Remove(EEventName.OnRemoveWeaponItem, new Action<IReadOnlyList<int>>(this.OnRemoveWeaponItem));
		EventSystem.Instance.Remove(EEventName.OnRemovePhantomItem, new Action<IReadOnlyList<int>>(this.OnRemovePhantomItem));
		EventSystem.Instance.Remove(EEventName.OnPhantomItemUpdate, new Action(this.OnPhantomItemUpdate));
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueBatchChange, new Action<IReadOnlyList<int>>(this.OnItemFuncValueBatchChange));
		EventSystem.Instance.Remove(EEventName.OnUseBuffItem, new Action<int, long, int>(this.OnUseBuffItem));
		EventSystem.Instance.Remove(EEventName.OnEquipBuffItemUpdate, new Action<int, bool>(this.OnEquipBuffItemUpdate));
		EventSystem.Instance.Remove(EEventName.OnItemUse, new Action<int, int>(this.OnItemUse));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
		EventSystem.Instance.Remove(EEventName.OnSpecialItemUpdate, new Action<int?>(this.OnSpecialItemUpdate));
		EventSystem.Instance.Remove(EEventName.NotifyInvalidItem, new Action<Dictionary<int, int>>(this.OnNotifyInvalidItem));
		EventSystem.Instance.Remove(EEventName.NotifyExpireConvertItem, new Action<IReadOnlyList<TItem>, IReadOnlyList<TItem>>(this.OnNotifyExpireConvertItem));
		EventSystem.Instance.Remove(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevelopInventoryRefresh));
		EventSystem.Instance.Remove(EEventName.RoleDevelopNeedItemsChanged, new Action(this.OnRoleDevelopInventoryRefresh));
	}

	// Token: 0x0600FEB6 RID: 65206 RVA: 0x003DE6CC File Offset: 0x003DC8CC
	private void TryActivateRefreshItemCdTimer()
	{
		this.CurrentCdItemMap.Clear();
		BuffItemModel.Instance.GetInCdBuffItemMap(this.CurrentCdItemMap);
		if (this.CurrentCdItemMap.Count <= 0)
		{
			this.RemoveItemCdTimer();
			return;
		}
		this.RefreshItemCdTime();
		if (!TimerSystem.GameplayTimeInstance.Has(this.RefreshCdTimerId))
		{
			this.RefreshCdTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnRefreshCdDisplay), 500f, 1f, null, null, true);
		}
		this.RefreshTimeDilation();
	}

	// Token: 0x0600FEB7 RID: 65207 RVA: 0x003DE750 File Offset: 0x003DC950
	private void RemoveItemCdTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.RefreshCdTimerId))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshCdTimerId);
		}
		this.RefreshCdTimerId = null;
	}

	// Token: 0x0600FEB8 RID: 65208 RVA: 0x003DE77C File Offset: 0x003DC97C
	private void OnRefreshCdDisplay(float delta)
	{
		this.RefreshItemCdTime();
	}

	// Token: 0x0600FEB9 RID: 65209 RVA: 0x003DE784 File Offset: 0x003DC984
	private void RefreshItemCdTime()
	{
		List<int> list = new List<int>();
		foreach (BuffItemData buffItemData in this.CurrentCdItemMap.Values)
		{
			int itemConfigId = buffItemData.ItemConfigId;
			for (int i = 0; i < this.ItemViewDataList.Count; i++)
			{
				if (this.ItemViewDataList[i].GetConfigId() == itemConfigId && this.ItemScrollView.IsGridDisplaying(i))
				{
					InventoryMediumItemGrid inventoryMediumItemGrid = this.ItemScrollView.UnsafeGetGridProxy(i, false);
					if (inventoryMediumItemGrid != null)
					{
						inventoryMediumItemGrid.RefreshCoolDown();
					}
				}
			}
			if (buffItemData.GetBuffItemRemainCdTime() <= 0.0)
			{
				list.Add(itemConfigId);
			}
		}
		foreach (int num in list)
		{
			this.CurrentCdItemMap.Remove(num);
			if (num == this.SelectedItemViewData.GetConfigId())
			{
				this.SetTipsButtonEnableByType(ItemViewDefine.ETipsButtonType.Use, true);
			}
		}
	}

	// Token: 0x0600FEBA RID: 65210 RVA: 0x003DE8B8 File Offset: 0x003DCAB8
	private void RequestInvalidItemInfo()
	{
		if (!this.ShouldHandlePlayerInventoryServerNotices())
		{
			return;
		}
		InventoryController.Instance.InvalidItemCheckRequest();
	}

	// Token: 0x0600FEBB RID: 65211 RVA: 0x003DE8CD File Offset: 0x003DCACD
	private void OnNotifyInvalidItem(Dictionary<int, int> itemMap)
	{
		if (!this.ShouldHandlePlayerInventoryServerNotices())
		{
			return;
		}
		if (!this.IsInvalidItemViewShow)
		{
			this.ShowInvalidItemConfirmBox(itemMap);
			return;
		}
		this.InvalidItemTempList.Add(itemMap);
	}

	// Token: 0x0600FEBC RID: 65212 RVA: 0x003DE8F4 File Offset: 0x003DCAF4
	private void CheckInvalidItem()
	{
		if (this.InvalidItemTempList.Count > 0)
		{
			List<Dictionary<int, int>> invalidItemTempList = this.InvalidItemTempList;
			Dictionary<int, int> itemMap = invalidItemTempList[invalidItemTempList.Count - 1];
			this.InvalidItemTempList.RemoveAt(this.InvalidItemTempList.Count - 1);
			this.ShowInvalidItemConfirmBox(itemMap);
		}
	}

	// Token: 0x0600FEBD RID: 65213 RVA: 0x003DE944 File Offset: 0x003DCB44
	private void ShowInvalidItemConfirmBox(Dictionary<int, int> itemMap)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ItemInvalidTips);
		confirmBoxDataNew.IsMultipleView = true;
		confirmBoxDataNew.ItemIdMap = itemMap;
		confirmBoxDataNew.SetCloseFunction(delegate
		{
			this.IsInvalidItemViewShow = false;
			this.CheckInvalidItem();
		});
		this.IsInvalidItemViewShow = true;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600FEBE RID: 65214 RVA: 0x003DE990 File Offset: 0x003DCB90
	private void OnNotifyExpireConvertItem(IReadOnlyList<TItem> beforeItemList, IReadOnlyList<TItem> afterItemList)
	{
		if (!this.ShouldHandlePlayerInventoryServerNotices())
		{
			return;
		}
		ItemExpiredAutoConvertTipsViewDefine itemExpiredAutoConvertTipsViewDefine = new ItemExpiredAutoConvertTipsViewDefine();
		itemExpiredAutoConvertTipsViewDefine.BeforeItemList = beforeItemList;
		itemExpiredAutoConvertTipsViewDefine.AfterItemList = afterItemList;
		itemExpiredAutoConvertTipsViewDefine.TitleText = "AutoConvertText_1";
		itemExpiredAutoConvertTipsViewDefine.BeforeTitleText = "AutoConvertText_2";
		itemExpiredAutoConvertTipsViewDefine.AfterTitleText = "AutoConvertText_3";
		itemExpiredAutoConvertTipsViewDefine.OnConfirmCallBack = delegate(int _)
		{
			this.CheckExpireConvertItem();
		};
		this.CacheExpireShowDataList.Add(itemExpiredAutoConvertTipsViewDefine);
		this.CheckExpireConvertItem();
	}

	// Token: 0x0600FEBF RID: 65215 RVA: 0x003DEA00 File Offset: 0x003DCC00
	private void CheckExpireConvertItem()
	{
		if (this.CacheExpireShowDataList.Count > 0)
		{
			ItemExpiredAutoConvertTipsViewDefine data = this.CacheExpireShowDataList[this.CacheExpireShowDataList.Count - 1];
			this.CacheExpireShowDataList.RemoveAt(this.CacheExpireShowDataList.Count - 1);
			this.ShowExpireConvertItemConfirmBox(data);
		}
	}

	// Token: 0x0600FEC0 RID: 65216 RVA: 0x003DEA53 File Offset: 0x003DCC53
	private void ShowExpireConvertItemConfirmBox(ItemExpiredAutoConvertTipsViewDefine data)
	{
		UiManager.Instance.OpenView(EUiViewName.ItemExpiredAutoConvertTipsView, data, null);
	}

	// Token: 0x0600FEC1 RID: 65217 RVA: 0x003DEA66 File Offset: 0x003DCC66
	private void OnClickedDestroyExitButton()
	{
		if (this.ViewMode == ItemViewDefine.EItemOperationMode.Destruction)
		{
			this.SetViewMode(ItemViewDefine.EItemOperationMode.Normal);
		}
	}

	// Token: 0x0600FEC2 RID: 65218 RVA: 0x003DEA78 File Offset: 0x003DCC78
	private void OnClickedDestroyEnterButton()
	{
		if (this.ViewMode == ItemViewDefine.EItemOperationMode.Normal)
		{
			this.SetViewMode(ItemViewDefine.EItemOperationMode.Destruction);
		}
	}

	// Token: 0x0600FEC3 RID: 65219 RVA: 0x003DEA8C File Offset: 0x003DCC8C
	private void OnClickedUseItemButton(int _)
	{
		InventoryModel instance = InventoryModel.Instance;
		global::ItemViewData selectedItemData = instance.GetSelectedItemData();
		if (selectedItemData == null)
		{
			return;
		}
		this.RemoveItemViewNewFlag(selectedItemData);
		if (selectedItemData.GetRedDotDisableRule() == InventoryDefine.ERedDotDisableRule.AfterUse)
		{
			this.RemoveItemViewRedDot(selectedItemData);
		}
		InventoryDefine.EItemDataType itemDataType = selectedItemData.GetItemDataType();
		if (itemDataType == InventoryDefine.EItemDataType.CommonItem)
		{
			instance.SaveNewCommonItemConfigIdList();
			instance.SaveRedDotCommonItemConfigIdList();
		}
		else
		{
			instance.SaveNewAttributeItemUniqueIdList();
			instance.SaveRedDotAttributeItemUniqueIdList();
		}
		int num = this.ItemViewDataList.IndexOf(selectedItemData);
		if (num >= 0)
		{
			this.ItemScrollView.RefreshGridProxy(num);
		}
		this.SetTipsButtonRedDotVisibleByType(ItemViewDefine.ETipsButtonType.Use, false);
		this.RefreshSameConfigIdItemView(selectedItemData);
		if (itemDataType == InventoryDefine.EItemDataType.CalabashSkinItem)
		{
			SkinController.Instance.SkipToCalabashSkinView(selectedItemData.GetConfigId());
			return;
		}
		InventoryController.Instance.TryUseItem(selectedItemData.GetConfigId(), 1);
	}

	// Token: 0x0600FEC4 RID: 65220 RVA: 0x003DEB3C File Offset: 0x003DCD3C
	private void OnClickedSpecialItemFuncUseButton(int _)
	{
		InventoryModel instance = InventoryModel.Instance;
		global::ItemViewData selectedItemData = instance.GetSelectedItemData();
		if (selectedItemData == null)
		{
			return;
		}
		this.RemoveItemViewNewFlag(selectedItemData);
		if (selectedItemData.GetRedDotDisableRule() == InventoryDefine.ERedDotDisableRule.AfterUse)
		{
			this.RemoveItemViewRedDot(selectedItemData);
		}
		if (selectedItemData.GetItemDataType() == InventoryDefine.EItemDataType.CommonItem)
		{
			instance.SaveNewCommonItemConfigIdList();
			instance.SaveRedDotCommonItemConfigIdList();
		}
		else
		{
			instance.SaveNewAttributeItemUniqueIdList();
			instance.SaveRedDotAttributeItemUniqueIdList();
		}
		this.RefreshSameConfigIdItemView(selectedItemData);
		if (SpecialItemController.Instance.AutoEquipOrUnEquipSpecialItem(selectedItemData.GetConfigId()))
		{
			UiManager.Instance.ResetToBattleView(null);
		}
	}

	// Token: 0x0600FEC5 RID: 65221 RVA: 0x003DEBBC File Offset: 0x003DCDBC
	private void OnClickedWeaponCultivateButton(int _)
	{
		global::ItemViewData selectedItemData = InventoryModel.Instance.GetSelectedItemData();
		if (selectedItemData == null)
		{
			return;
		}
		SkipTaskManager.Run(ESkipName.SkipToWeaponRoot, new object[]
		{
			selectedItemData.GetUniqueId()
		});
	}

	// Token: 0x0600FEC6 RID: 65222 RVA: 0x003DEBF4 File Offset: 0x003DCDF4
	private void OnClickedVisionCultivateButton(int _)
	{
		global::ItemViewData selectedItemData = InventoryModel.Instance.GetSelectedItemData();
		if (selectedItemData == null)
		{
			return;
		}
		SkipTaskManager.Run(ESkipName.SkipToVisionIntensifyView, new object[]
		{
			selectedItemData.GetUniqueId()
		});
	}

	// Token: 0x0600FEC7 RID: 65223 RVA: 0x003DEC2A File Offset: 0x003DCE2A
	private void OnClickFragmentMemoryButton(int _)
	{
		FragmentMemoryController.Instance.OpenFragmentMemoryView();
	}

	// Token: 0x0600FEC8 RID: 65224 RVA: 0x003DEC36 File Offset: 0x003DCE36
	private void OnClickedPhantomPlan()
	{
		InventoryController.Instance.OpenManageConfigNewView();
	}

	// Token: 0x0600FEC9 RID: 65225 RVA: 0x003DEC42 File Offset: 0x003DCE42
	private void OnClickedCloseButton()
	{
		UiManager.Instance.CloseView(EUiViewName.InventoryView, null);
		if (UiManager.Instance.IsViewShow(EUiViewName.PowerView))
		{
			UiManager.Instance.CloseView(EUiViewName.PowerView, null);
		}
	}

	// Token: 0x0600FECA RID: 65226 RVA: 0x003DEC78 File Offset: 0x003DCE78
	private void OnClickedQuestReviewButton(int _)
	{
		SpecialItemConfig instance = SpecialItemConfig.Instance;
		global::ItemViewData selectedItemViewData = this.SelectedItemViewData;
		SpecialItem? config = instance.GetConfig((selectedItemViewData != null) ? selectedItemViewData.GetConfigId() : 0);
		if (config != null)
		{
			SpecialItem value = config.Value;
			int entryId = 0;
			if (value.ParametersLength > 0)
			{
				string text = value.Parameters(0);
				if (!string.IsNullOrEmpty(text))
				{
					int.TryParse(text, out entryId);
				}
			}
			QuestReviewController.Instance.OpenQuestReview(entryId, true);
		}
	}

	// Token: 0x0600FECB RID: 65227 RVA: 0x003DECE8 File Offset: 0x003DCEE8
	private void OnClickedChineseZitherButton(int _)
	{
		int restrictConditionGroupId = InventoryConfig.Instance.GetItemConfig(80700051).Value.RestrictConditionGroupId;
		if (restrictConditionGroupId > 0 && LevelGeneralController.Instance.CheckCondition(restrictConditionGroupId.ToString(), null, false, Array.Empty<object>()))
		{
			string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(restrictConditionGroupId);
			if (conditionGroupHintText != null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(conditionGroupHintText, Array.Empty<object>());
			}
			return;
		}
		MusicalInstrumentController.Instance.Enter(new MusicalInstrumentEnterParam
		{
			Type = EInstrumentType.ChineseZither
		}).Forget();
	}

	// Token: 0x0600FECC RID: 65228 RVA: 0x003DED69 File Offset: 0x003DCF69
	private void OnAddWeaponItemList(IReadOnlyList<WeaponItem> weaponItem, bool bAddFromRole, bool bShowNewTips)
	{
		this.RefreshInventoryView();
	}

	// Token: 0x0600FECD RID: 65229 RVA: 0x003DED71 File Offset: 0x003DCF71
	private void OnAddPhantomItemList(IReadOnlyList<Aki.Protocol.PhantomItem> weaponItem, bool isCatch)
	{
		this.RefreshInventoryView();
	}

	// Token: 0x0600FECE RID: 65230 RVA: 0x003DED79 File Offset: 0x003DCF79
	private void OnCommonItemCountAnyChange(int configId, int count)
	{
		this.RefreshInventoryView();
	}

	// Token: 0x0600FECF RID: 65231 RVA: 0x003DED81 File Offset: 0x003DCF81
	private void OnRoleDevelopInventoryRefresh()
	{
		this.RefreshInventoryView();
	}

	// Token: 0x0600FED0 RID: 65232 RVA: 0x003DED89 File Offset: 0x003DCF89
	private void OnRemoveWeaponItem(IReadOnlyList<int> uniqueIdList)
	{
		this.RefreshInventoryView();
	}

	// Token: 0x0600FED1 RID: 65233 RVA: 0x003DED91 File Offset: 0x003DCF91
	private void OnRemovePhantomItem(IReadOnlyList<int> uniqueIdList)
	{
		this.RefreshInventoryView();
	}

	// Token: 0x0600FED2 RID: 65234 RVA: 0x003DED99 File Offset: 0x003DCF99
	private void OnPhantomItemUpdate()
	{
		this.RefreshInventoryView();
	}

	// Token: 0x0600FED3 RID: 65235 RVA: 0x003DEDA4 File Offset: 0x003DCFA4
	private void OnUseBuffItem(int itemConfigId, long endCdTimeStamp, int useCount)
	{
		this.TryActivateRefreshItemCdTimer();
		if (BuffItemConfig.Instance.IsBuffItem(itemConfigId))
		{
			double buffItemRemainCdTime = BuffItemModel.Instance.GetBuffItemRemainCdTime(itemConfigId);
			this.SetTipsButtonEnableByType(ItemViewDefine.ETipsButtonType.Use, buffItemRemainCdTime <= 0.0);
		}
	}

	// Token: 0x0600FED4 RID: 65236 RVA: 0x003DEDE8 File Offset: 0x003DCFE8
	private void OnEquipBuffItemUpdate(int itemConfigId, bool equipped)
	{
		if (this.SelectedItemViewData == null)
		{
			return;
		}
		ItemDataBase itemDataBase = this.SelectedItemViewData.GetItemDataBase();
		if (itemDataBase.IsBuffEquipItem())
		{
			this.RefreshBuffEquipItemFunction(itemDataBase);
		}
	}

	// Token: 0x0600FED5 RID: 65237 RVA: 0x003DEE19 File Offset: 0x003DD019
	private void OnItemUse(int configId, int useCount)
	{
	}

	// Token: 0x0600FED6 RID: 65238 RVA: 0x003DEE1B File Offset: 0x003DD01B
	private void RefreshInventoryView()
	{
		this.SetViewMode(this.ViewMode);
		this.RefreshAllItemList();
	}

	// Token: 0x0600FED7 RID: 65239 RVA: 0x003DEE30 File Offset: 0x003DD030
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.UseBuffItemView)
		{
			return;
		}
		this.LevelSequencePlayer.StopSequenceByKey("Tc", false, false);
		this.LevelSequencePlayer.PlaySequencePurely("Tc", false, true, null, null, false);
		global::ItemViewData itemViewData = this.ItemViewDataList[this.SelectedItemIndex];
		if (itemViewData != null)
		{
			this.SelectedItem(itemViewData);
		}
	}

	// Token: 0x0600FED8 RID: 65240 RVA: 0x003DEE96 File Offset: 0x003DD096
	private void OnChangedTimeScale()
	{
		this.RefreshTimeDilation();
	}

	// Token: 0x0600FED9 RID: 65241 RVA: 0x003DEEA0 File Offset: 0x003DD0A0
	private void RefreshTimeDilation()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.RefreshCdTimerId))
		{
			float timeDilation = Time.Instance.TimeDilation;
			if (timeDilation <= 0f)
			{
				return;
			}
			TimerSystem.GameplayTimeInstance.ChangeDilation(this.RefreshCdTimerId, timeDilation, null);
		}
	}

	// Token: 0x0600FEDA RID: 65242 RVA: 0x003DEEE8 File Offset: 0x003DD0E8
	private void OnItemFuncValueChange(int uniqueId)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(uniqueId);
		if (attributeItemData == null)
		{
			return;
		}
		for (int i = 0; i < this.ItemViewDataList.Count; i++)
		{
			global::ItemViewData itemViewData = this.ItemViewDataList[i];
			if (itemViewData.GetUniqueId() == uniqueId)
			{
				itemViewData.SetIsLock(attributeItemData.GetIsLock());
				itemViewData.SetIsDeprecate(attributeItemData.GetIsDeprecated());
				itemViewData.RemoveNewItem();
				this.ItemScrollView.RefreshGridProxy(i);
				return;
			}
		}
	}

	// Token: 0x0600FEDB RID: 65243 RVA: 0x003DEF5C File Offset: 0x003DD15C
	private void OnItemFuncValueBatchChange(IReadOnlyList<int> uniqueIdList)
	{
		InventoryModel instance = InventoryModel.Instance;
		HashSet<int> hashSet = new HashSet<int>(uniqueIdList);
		for (int i = 0; i < this.ItemViewDataList.Count; i++)
		{
			global::ItemViewData itemViewData = this.ItemViewDataList[i];
			if (hashSet.Contains(itemViewData.GetUniqueId()))
			{
				AttributeItemData attributeItemData = instance.GetAttributeItemData(itemViewData.GetUniqueId());
				if (attributeItemData != null)
				{
					itemViewData.SetIsLock(attributeItemData.GetIsLock());
					itemViewData.SetIsDeprecate(attributeItemData.GetIsDeprecated());
					itemViewData.RemoveNewItem();
					this.ItemScrollView.RefreshGridProxy(i);
				}
			}
		}
	}

	// Token: 0x0600FEDC RID: 65244 RVA: 0x003DEFE8 File Offset: 0x003DD1E8
	private void RefreshNormalItemFunction(ItemDataBase itemData)
	{
		int configId = itemData.GetConfigId();
		bool isShowUseButton = itemData.GetIsShowUseButton();
		if (isShowUseButton)
		{
			this.RefreshButtonByTypeList(new List<ItemViewDefine.ETipsButtonType>
			{
				ItemViewDefine.ETipsButtonType.Use
			});
		}
		if (itemData.IsBuffItem() && isShowUseButton)
		{
			double buffItemRemainCdTime = BuffItemModel.Instance.GetBuffItemRemainCdTime(configId);
			this.SetTipsButtonEnableByType(ItemViewDefine.ETipsButtonType.Use, buffItemRemainCdTime <= 0.0);
		}
		if (itemData.GetRedDotDisableRule() == InventoryDefine.ERedDotDisableRule.AfterUse)
		{
			this.SetTipsButtonRedDotVisibleByType(ItemViewDefine.ETipsButtonType.Use, itemData.HasRedDot());
			return;
		}
		this.SetTipsButtonRedDotVisibleByType(ItemViewDefine.ETipsButtonType.Use, false);
	}

	// Token: 0x0600FEDD RID: 65245 RVA: 0x003DF064 File Offset: 0x003DD264
	private void RefreshBuffEquipItemFunction(ItemDataBase itemData)
	{
		bool flag = itemData.IsBuffEquippedItem();
		string text = flag ? "Mask_Remove_01" : "Mask_Wear_01";
		if (!flag && BuffItemModel.Instance.IsEquippedBuffCategory((EBuffItemEquipCategory)BuffItemConfig.Instance.GetBuffEquipItemCategory(itemData.GetConfigId())))
		{
			text = "Instead";
		}
		this.SetTipsButtonTextByType(ItemViewDefine.ETipsButtonType.EquipBuffItem, text, null);
	}

	// Token: 0x0600FEDE RID: 65246 RVA: 0x003DF0B4 File Offset: 0x003DD2B4
	private List<ItemViewDefine.ETipsButtonType> GetTipsButtonListByCurrentItemData(ItemDataBase dataBase)
	{
		List<ItemViewDefine.ETipsButtonType> list = new List<ItemViewDefine.ETipsButtonType>();
		if (this.SelectedItemViewData == null)
		{
			return list;
		}
		InventoryDefine.EItemType itemType = this.SelectedItemViewData.GetItemType();
		if (itemType != InventoryDefine.EItemType.Weapon)
		{
			if (itemType != InventoryDefine.EItemType.Phantom)
			{
				ItemInfo? itemInfo;
				if (itemType == InventoryDefine.EItemType.SpecialItem)
				{
					SpecialItem? config = SpecialItemConfig.Instance.GetConfig(dataBase.GetConfigId());
					if (config != null)
					{
						SpecialItem value = config.Value;
						if (value.UseButtonAdditionParamLength > 0)
						{
							for (int i = 0; i < value.UseButtonAdditionParamLength; i++)
							{
								ItemViewDefine.ETipsButtonType etipsButtonType = (ItemViewDefine.ETipsButtonType)value.UseButtonAdditionParam(i);
								if (etipsButtonType != ItemViewDefine.ETipsButtonType.RouletteEquip || RouletteModel.Instance.IsExploreRouletteOpen(false))
								{
									list.Add(etipsButtonType);
								}
							}
						}
						else if (RouletteModel.Instance.IsExploreRouletteOpen(false) && value.SpecialItemType == 0)
						{
							list.Add(ItemViewDefine.ETipsButtonType.RouletteEquip);
						}
					}
				}
				else if (dataBase.GetConfig().As<ItemInfo>() != null && itemInfo.GetValueOrDefault().ShowUseButton)
				{
					if (dataBase.IsBuffEquipItem())
					{
						list.Add(ItemViewDefine.ETipsButtonType.EquipBuffItem);
					}
					else
					{
						list.Add(ItemViewDefine.ETipsButtonType.Use);
					}
				}
			}
			else
			{
				list.Add(ItemViewDefine.ETipsButtonType.VisionCultivate);
			}
		}
		else
		{
			list.Add(ItemViewDefine.ETipsButtonType.WeaponCultivate);
		}
		return list;
	}

	// Token: 0x0600FEDF RID: 65247 RVA: 0x003DF1DC File Offset: 0x003DD3DC
	private void RefreshSpecialItemText()
	{
		if (this.SelectedItemViewData == null)
		{
			return;
		}
		int configId = this.SelectedItemViewData.GetConfigId();
		int? equipSpecialItemId = SpecialItemModel.Instance.GetEquipSpecialItemId();
		int? num = equipSpecialItemId;
		string text;
		if (configId == num.GetValueOrDefault() & num != null)
		{
			text = "UnEquip";
		}
		else if (equipSpecialItemId != null)
		{
			text = "Instead";
		}
		else
		{
			text = "Equip";
		}
		this.SetTipsButtonTextByType(ItemViewDefine.ETipsButtonType.RouletteEquip, text, null);
	}

	// Token: 0x0600FEE0 RID: 65248 RVA: 0x003DF247 File Offset: 0x003DD447
	private void InitializeFilterSortComponent()
	{
		this.FilterSortEntrance = new FilterSortEntrance<global::ItemViewData>(base.GetItem(12), new TUpdateDataListFunction<global::ItemViewData>(this.OnFilterSortRefresh));
	}

	// Token: 0x0600FEE1 RID: 65249 RVA: 0x003DF268 File Offset: 0x003DD468
	private void ClearFilterSortComponentData(ItemViewDefine.EItemOperationMode viewMode)
	{
		foreach (ItemMainType itemMainType in this.ItemTypeList)
		{
			ItemMainType? itemMainTypeConfig = InventoryConfig.Instance.GetItemMainTypeConfig(itemMainType.Id);
			if (itemMainTypeConfig != null)
			{
				ItemMainType value = itemMainTypeConfig.Value;
				int groupId = (viewMode == ItemViewDefine.EItemOperationMode.Normal) ? value.UseWayId : value.DestroyUseWayId;
				this.FilterSortEntrance.ClearData((EFilterSortGroupId)groupId);
			}
		}
	}

	// Token: 0x0600FEE2 RID: 65250 RVA: 0x003DF2FC File Offset: 0x003DD4FC
	private void RefreshFilterSortPerformance(InventoryDefine.EItemMainTypeId itemMainType)
	{
		ItemMainType? itemMainTypeConfig = InventoryConfig.Instance.GetItemMainTypeConfig((int)itemMainType);
		bool flag = false;
		if (itemMainTypeConfig != null)
		{
			flag = itemMainTypeConfig.Value.BFilterSortVisible;
		}
		int useWayId = 0;
		ItemMainType value = InventoryConfig.Instance.GetItemMainTypeConfig((int)itemMainType).Value;
		ItemViewDefine.EItemOperationMode viewMode = this.ViewMode;
		if (viewMode != ItemViewDefine.EItemOperationMode.Normal)
		{
			if (viewMode == ItemViewDefine.EItemOperationMode.Destruction)
			{
				useWayId = value.DestroyUseWayId;
				bool flag2 = this.DestroyViewMode == ItemViewDefine.EDestroyViewMode.Default;
				this.FilterSortEntrance.SetUiActive(flag && flag2);
			}
		}
		else
		{
			useWayId = value.UseWayId;
			this.FilterSortEntrance.SetUiActive(flag);
		}
		List<global::ItemViewData> list = this.GenerateItemViewData(itemMainType);
		this.RefreshFilterSort(useWayId, list);
		this.RefreshCapacity(itemMainType, list);
	}

	// Token: 0x0600FEE3 RID: 65251 RVA: 0x003DF3B0 File Offset: 0x003DD5B0
	private void RefreshPhantomManageButton(InventoryDefine.EItemMainTypeId itemMainType)
	{
		base.SetButtonUiActive(21, itemMainType == InventoryDefine.EItemMainTypeId.Phantom && this.ViewMode == ItemViewDefine.EItemOperationMode.Normal);
		bool flag = FunctionModel.Instance.IsOpen(10096);
		base.SetButtonUiActive(22, flag && itemMainType == InventoryDefine.EItemMainTypeId.Phantom && this.ViewMode == ItemViewDefine.EItemOperationMode.Normal);
		base.SetButtonUiActive(23, flag && itemMainType == InventoryDefine.EItemMainTypeId.Phantom && this.ViewMode == ItemViewDefine.EItemOperationMode.Normal);
	}

	// Token: 0x0600FEE4 RID: 65252 RVA: 0x003DF41C File Offset: 0x003DD61C
	private void RefreshFilterSort(int useWayId, List<global::ItemViewData> itemDataList)
	{
		EFilterSortConfigId saveConfigId = (this.ViewMode == ItemViewDefine.EItemOperationMode.Normal) ? EFilterSortConfigId.InventoryView : EFilterSortConfigId.InventoryDestroy;
		this.FilterSortEntrance.UpdateDataWithConfig((EFilterSortGroupId)useWayId, saveConfigId, itemDataList);
	}

	// Token: 0x0600FEE5 RID: 65253 RVA: 0x003DF444 File Offset: 0x003DD644
	private bool ShouldApplyDevelopDeficitPinSort()
	{
		RoleDevelopModel instance = RoleDevelopModel.Instance;
		return instance != null && instance.DevTargetRoleId != 0 && InventoryModel.Instance.IsResourceOrMaterialTab();
	}

	// Token: 0x0600FEE6 RID: 65254 RVA: 0x003DF470 File Offset: 0x003DD670
	private List<global::ItemViewData> ApplyDevelopDeficitPinSort(List<global::ItemViewData> itemViewDataList)
	{
		if (!this.ShouldApplyDevelopDeficitPinSort())
		{
			return itemViewDataList;
		}
		RoleDevelopModel instance = RoleDevelopModel.Instance;
		List<global::ItemViewData> list = new List<global::ItemViewData>();
		List<global::ItemViewData> list2 = new List<global::ItemViewData>();
		foreach (global::ItemViewData itemViewData in itemViewDataList)
		{
			if (instance.GetDevelopRoleNeedItemDeficitCount(itemViewData.GetConfigId()) > 0)
			{
				list.Add(itemViewData);
			}
			else
			{
				list2.Add(itemViewData);
			}
		}
		list.AddRange(list2);
		return list;
	}

	// Token: 0x0600FEE7 RID: 65255 RVA: 0x003DF500 File Offset: 0x003DD700
	[NullableContext(2)]
	private global::ItemViewData GetCurrentTabMarkViewData()
	{
		int selectedTypeIndex = InventoryModel.Instance.GetSelectedTypeIndex();
		int num = this.TabMarkUniqueIds[selectedTypeIndex];
		if (num > 0)
		{
			foreach (global::ItemViewData itemViewData in this.ItemViewDataList)
			{
				if (itemViewData.GetUniqueId() == num)
				{
					return itemViewData;
				}
			}
		}
		int num2 = this.TabMarkPositions[selectedTypeIndex];
		if (num2 != -1 && this.ItemViewDataList.Count > num2)
		{
			return this.ItemViewDataList[num2];
		}
		if (this.ItemViewDataList.Count <= 0)
		{
			return null;
		}
		return this.ItemViewDataList[0];
	}

	// Token: 0x0600FEE8 RID: 65256 RVA: 0x003DF5BC File Offset: 0x003DD7BC
	private void OnFilterSortRefresh(List<global::ItemViewData> list, bool isOutSideChange, EFilterSortType operationType)
	{
		this.IsReloadData = true;
		List<global::ItemViewData> list2 = list;
		if (this.ViewMode == ItemViewDefine.EItemOperationMode.Normal)
		{
			list2 = this.ApplyDevelopDeficitPinSort(list2);
		}
		if (this.ViewMode == ItemViewDefine.EItemOperationMode.Destruction)
		{
			List<global::ItemViewData> list3 = new List<global::ItemViewData>();
			List<global::ItemViewData> list4 = new List<global::ItemViewData>();
			foreach (global::ItemViewData itemViewData in list2)
			{
				if (itemViewData.GetSelectOn())
				{
					list3.Add(itemViewData);
				}
				else
				{
					list4.Add(itemViewData);
				}
			}
			list3.AddRange(list4);
			list2 = list3;
			this.SetDestroyAllSelectedState(null, new bool?(false));
		}
		this.ItemViewDataList = list2;
		this.RefreshItemScrollView(list2);
		if (this.IsReSelectType)
		{
			this.SelectGridIndexByOpenParam(list2);
			this.SelectedItem(this.GetCurrentTabMarkViewData());
		}
		else if (operationType == EFilterSortType.Sort)
		{
			this.SelectedItem((list2.Count > 0) ? list2[0] : null);
		}
		else
		{
			global::ItemViewData itemViewData2 = null;
			if (this.SelectedItemViewData != null && this.ItemViewDataList.Contains(this.SelectedItemViewData))
			{
				itemViewData2 = this.SelectedItemViewData;
			}
			this.SelectedItem(itemViewData2 ?? ((list2.Count > 0) ? list2[0] : null));
		}
		this.IsReloadData = false;
		this.IsReSelectType = false;
	}

	// Token: 0x0600FEE9 RID: 65257 RVA: 0x003DF70C File Offset: 0x003DD90C
	private void RefreshItemScrollView(List<global::ItemViewData> itemViewDataList)
	{
		if (this.ItemScrollView == null)
		{
			return;
		}
		int count = itemViewDataList.Count;
		this.ItemScrollView.RefreshByData(itemViewDataList, false, delegate
		{
			this.RefreshNoneItemVisible(itemViewDataList.Count <= 0);
		}, true);
		if (count <= 0)
		{
			InventoryModel.Instance.SetSelectedItemViewData(null);
		}
	}

	// Token: 0x0600FEEA RID: 65258 RVA: 0x003DF770 File Offset: 0x003DD970
	private void InitializeItemScrollView()
	{
		UUIItem item = base.GetItem(7);
		AUIBaseActor gridActor = item.GetOwner() as AUIBaseActor;
		item.SetUIActive(true);
		this.ItemScrollView = new LoopScrollView<InventoryMediumItemGrid, global::ItemViewData>(base.GetLoopScrollViewComponent(6), gridActor, new Func<InventoryMediumItemGrid>(this.OnGridProxyCreate), false);
		item.SetUIActive(false);
	}

	// Token: 0x0600FEEB RID: 65259 RVA: 0x003DF7C0 File Offset: 0x003DD9C0
	private void InitializePayShopCurrencyItem()
	{
		this.CommonCurrencyItem1.RefreshTemp(2, null);
		this.CommonCurrencyItem1.SetToPayShopFunction();
		this.CommonCurrencyItem1.RefreshAddButtonActive();
		this.CommonCurrencyItem2.RefreshTemp(3, null);
		this.CommonCurrencyItem2.SetToPayShopFunction();
		this.CommonCurrencyItem2.RefreshAddButtonActive();
	}

	// Token: 0x0600FEEC RID: 65260 RVA: 0x003DF813 File Offset: 0x003DDA13
	private InventoryMediumItemGrid OnGridProxyCreate()
	{
		InventoryMediumItemGrid inventoryMediumItemGrid = new InventoryMediumItemGrid();
		inventoryMediumItemGrid.BindOnItemButtonClickedCallback(new Action<global::ItemViewData>(this.OnItemButtonClicked));
		return inventoryMediumItemGrid;
	}

	// Token: 0x0600FEED RID: 65261 RVA: 0x003DF82C File Offset: 0x003DDA2C
	private void InitItemTypeList()
	{
		this.ItemTypeList = InventoryModel.Instance.GetOpenIdMainTypeConfig();
		if (this.ItemTypeList.Count <= 0)
		{
			return;
		}
		this.ItemTypeList.Sort((ItemMainType aTypeConfig, ItemMainType bTypeConfig) => aTypeConfig.SequenceId - bTypeConfig.SequenceId);
	}

	// Token: 0x0600FEEE RID: 65262 RVA: 0x003DF884 File Offset: 0x003DDA84
	private UniTask CreateAllItemMainTypeButton(int index)
	{
		InventoryView.<CreateAllItemMainTypeButton>d__99 <CreateAllItemMainTypeButton>d__;
		<CreateAllItemMainTypeButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAllItemMainTypeButton>d__.<>4__this = this;
		<CreateAllItemMainTypeButton>d__.index = index;
		<CreateAllItemMainTypeButton>d__.<>1__state = -1;
		<CreateAllItemMainTypeButton>d__.<>t__builder.Start<InventoryView.<CreateAllItemMainTypeButton>d__99>(ref <CreateAllItemMainTypeButton>d__);
		return <CreateAllItemMainTypeButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600FEEF RID: 65263 RVA: 0x003DF8D0 File Offset: 0x003DDAD0
	private List<CommonTabItemData> GetTabItemData(List<ItemMainType> tabData)
	{
		int count = tabData.Count;
		List<CommonTabItemData> list = this.TabComponent.CreateTabItemDataByLength(count);
		for (int i = 0; i < count; i++)
		{
			ItemMainType itemMainType = this.ItemTypeList[i];
			if (this.IsRealPlayerInventory())
			{
				list[i].RedDotName = this.GetRedDotNameByItemId(itemMainType.Id);
			}
		}
		return list;
	}

	// Token: 0x0600FEF0 RID: 65264 RVA: 0x003DF92C File Offset: 0x003DDB2C
	private ERedDotName? GetRedDotNameByItemId(int id)
	{
		ERedDotName? result = null;
		switch (id)
		{
		case 0:
			result = new ERedDotName?(ERedDotName.InventoryVirtual);
			break;
		case 1:
			result = new ERedDotName?(ERedDotName.InventoryCommon);
			break;
		case 2:
			result = new ERedDotName?(ERedDotName.InventoryWeapon);
			break;
		case 3:
			result = new ERedDotName?(ERedDotName.InventoryPhantom);
			break;
		case 4:
			result = new ERedDotName?(ERedDotName.InventoryCollection);
			break;
		case 5:
			result = new ERedDotName?(ERedDotName.InventoryMaterial);
			break;
		case 6:
			result = new ERedDotName?(ERedDotName.InventoryMission);
			break;
		case 7:
			result = new ERedDotName?(ERedDotName.InventorySpecial);
			break;
		case 8:
			result = new ERedDotName?(ERedDotName.InventoryCard);
			break;
		}
		return result;
	}

	// Token: 0x0600FEF1 RID: 65265 RVA: 0x003DF9CF File Offset: 0x003DDBCF
	[NullableContext(2)]
	private CommonTabItem ProxyCreateTabItem(UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600FEF2 RID: 65266 RVA: 0x003DF9D8 File Offset: 0x003DDBD8
	private void OnTypeButtonClicked(int index)
	{
		InventoryModel instance = InventoryModel.Instance;
		if (instance.GetSelectedTypeIndex() == index)
		{
			return;
		}
		this.SaveCurrentMarkPosition();
		instance.SetSelectedTypeIndex(index);
		this.SelectedItemTypeHandle(index);
		if (index == 1)
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "InventoryPhantomTab");
		}
	}

	// Token: 0x0600FEF3 RID: 65267 RVA: 0x003DFA24 File Offset: 0x003DDC24
	private CommonTabData GetCommonData(int index)
	{
		ItemMainType itemMainType = this.ItemTypeList[index];
		return new CommonTabData(itemMainType.Icon, new CommonTabTitleData(itemMainType.Name, Array.Empty<object>()), null);
	}

	// Token: 0x0600FEF4 RID: 65268 RVA: 0x003DFA5C File Offset: 0x003DDC5C
	private void SelectedCurrentIndex()
	{
		int selectedTypeIndex = InventoryModel.Instance.GetSelectedTypeIndex();
		this.SelectedItemTypeHandle(selectedTypeIndex);
	}

	// Token: 0x0600FEF5 RID: 65269 RVA: 0x003DFA7C File Offset: 0x003DDC7C
	private void SelectedItemTypeHandle(int index)
	{
		this.IsReSelectType = true;
		int id = this.ItemTypeList[index].Id;
		this.RefreshFilterSortPerformance((InventoryDefine.EItemMainTypeId)id);
		this.RefreshPhantomManageButton((InventoryDefine.EItemMainTypeId)id);
		this.TryActivateRefreshItemCdTimer();
		this.RefreshMaxCapacityNoticeAnimation();
	}

	// Token: 0x0600FEF6 RID: 65270 RVA: 0x003DFAC0 File Offset: 0x003DDCC0
	private List<global::ItemViewData> GenerateItemViewData(InventoryDefine.EItemMainTypeId itemMainType)
	{
		this.ClearAllItemViewData();
		InventoryModel instance = InventoryModel.Instance;
		foreach (ItemDataBase itemDataBase in instance.GetItemDataBaseByMainType(itemMainType))
		{
			if (itemDataBase.IsShowInInventory())
			{
				CommonItemData commonItemData = itemDataBase as CommonItemData;
				if (commonItemData != null)
				{
					int maxStackCount = commonItemData.GetMaxStackCount();
					if (maxStackCount > 0)
					{
						ItemInfo value = commonItemData.GetConfig().As<ItemInfo>().Value;
						int configId = commonItemData.GetConfigId();
						this.NewCommonItemViewData(value.Id, commonItemData.GetCount(), maxStackCount, value.QualityId, false, false, instance.IsNewCommonItem(configId, 0), instance.IsCommonItemHasRedDot(configId, 0), commonItemData);
					}
				}
				else
				{
					InventoryDefine.IItemViewDataInfo itemViewDataInfo = itemDataBase.GetItemViewDataInfo(this.ViewMode);
					if (itemViewDataInfo != null)
					{
						this.NewItemViewData(itemViewDataInfo);
					}
				}
			}
		}
		return this.ItemViewDataList;
	}

	// Token: 0x0600FEF7 RID: 65271 RVA: 0x003DFBB4 File Offset: 0x003DDDB4
	private void ClearAllItemViewData()
	{
		this.ItemViewDataList.Clear();
		this.ItemViewDataMap.Clear();
	}

	// Token: 0x0600FEF8 RID: 65272 RVA: 0x003DFBCC File Offset: 0x003DDDCC
	private void RefreshAllItemList()
	{
		if (this.ItemTypeList == null)
		{
			return;
		}
		if (!this.IsRealPlayerInventory())
		{
			return;
		}
		List<string> list = new List<string>();
		foreach (ItemMainType itemMainType in this.ItemTypeList)
		{
			int inventoryItemGridCountByMainType = InventoryModel.Instance.GetInventoryItemGridCountByMainType((InventoryDefine.EItemMainTypeId)itemMainType.Id);
			ItemMainType? itemMainTypeConfig = InventoryConfig.Instance.GetItemMainTypeConfig(itemMainType.Id);
			if (itemMainTypeConfig != null)
			{
				ItemMainType value = itemMainTypeConfig.Value;
				int packageId = value.PackageId;
				PackageCapacity? packageConfig = InventoryConfig.Instance.GetPackageConfig(packageId);
				if (packageConfig != null)
				{
					int capacity = packageConfig.Value.Capacity;
					if (inventoryItemGridCountByMainType >= capacity && itemMainType.Id != 3)
					{
						string item = ConfigMultiTextLang.GetLocalTextNew(value.Name, null) + " ";
						list.Add(item);
					}
				}
			}
		}
		this.RefreshMaxCapacityNoticeAnimation();
		if (InventoryController.Instance.CheckAndShowPhantomTips())
		{
			return;
		}
		bool flag = list.Count > 0;
		if (!this.IsMaxCapacityViewShow && flag)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string value2 in list)
			{
				stringBuilder.Append(value2);
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.InventoryCapacityMax);
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				stringBuilder.ToString()
			});
			this.IsMaxCapacityViewShow = true;
			confirmBoxDataNew.FunctionMap.Add(1, delegate
			{
				this.IsMaxCapacityViewShow = false;
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}

	// Token: 0x0600FEF9 RID: 65273 RVA: 0x003DFD98 File Offset: 0x003DDF98
	private void RefreshMaxCapacityNoticeAnimation()
	{
		int selectedTypeIndex = InventoryModel.Instance.GetSelectedTypeIndex();
		ItemMainType itemMainType = this.ItemTypeList[selectedTypeIndex];
		int inventoryItemGridCountByMainType = InventoryModel.Instance.GetInventoryItemGridCountByMainType((InventoryDefine.EItemMainTypeId)itemMainType.Id);
		int packageId = InventoryConfig.Instance.GetItemMainTypeConfig(itemMainType.Id).Value.PackageId;
		int capacity = InventoryConfig.Instance.GetPackageConfig(packageId).Value.Capacity;
		bool flag = inventoryItemGridCountByMainType >= capacity && itemMainType.Id != 3;
		if (this.IsMaxCapacityFlag != flag)
		{
			this.PlayMaxCapacityNoticeSequence(flag);
			this.IsMaxCapacityFlag = flag;
		}
	}

	// Token: 0x0600FEFA RID: 65274 RVA: 0x003DFE40 File Offset: 0x003DE040
	private void PlayMaxCapacityNoticeSequence(bool isOn)
	{
		if (isOn)
		{
			this.UiViewSequence.PlaySequence("Notice", false, null);
			return;
		}
		this.UiViewSequence.StopSequenceByKey("Notice", false, true);
	}

	// Token: 0x0600FEFB RID: 65275 RVA: 0x003DFE80 File Offset: 0x003DE080
	private global::ItemViewData NewItemViewData(InventoryDefine.IItemViewDataInfo itemViewInfo)
	{
		global::ItemViewData itemViewData = new global::ItemViewData(itemViewInfo);
		foreach (global::ItemViewData itemViewData2 in new List<global::ItemViewData>(this.SelectItemSet))
		{
			if (itemViewData2.IsEqual(itemViewData, new bool?(true)))
			{
				itemViewData.SetSelectOn(itemViewData2.GetSelectOn());
				itemViewData.SetSelectNum(itemViewData2.GetSelectNum());
				break;
			}
		}
		this.ItemViewDataList.Add(itemViewData);
		int configId = itemViewInfo.ConfigId;
		HashSet<global::ItemViewData> hashSet;
		if (!this.ItemViewDataMap.TryGetValue(configId, out hashSet))
		{
			hashSet = new HashSet<global::ItemViewData>();
			this.ItemViewDataMap.Add(configId, hashSet);
		}
		hashSet.Add(itemViewData);
		return itemViewData;
	}

	// Token: 0x0600FEFC RID: 65276 RVA: 0x003DFF44 File Offset: 0x003DE144
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private HashSet<global::ItemViewData> GetItemViewDataSetByConfigId(int configId)
	{
		HashSet<global::ItemViewData> result;
		if (this.ItemViewDataMap.TryGetValue(configId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600FEFD RID: 65277 RVA: 0x003DFF64 File Offset: 0x003DE164
	private void NewCommonItemViewData(int configId, int count, int stackCount, int qualityId, bool isLock, bool isDeprecate, bool isNewItem, bool hasRedDot, CommonItemData commonItemData)
	{
		if (stackCount <= 0)
		{
			return;
		}
		int num = count;
		int num2 = 0;
		InventoryDefine.ItemViewDataInfo itemViewDataInfo = new InventoryDefine.ItemViewDataInfo(configId, stackCount, 0, qualityId, isLock, isDeprecate, isNewItem, InventoryDefine.EItemDataType.CommonItem, commonItemData, hasRedDot, this.ViewMode, false, 0);
		while (num - stackCount > 0)
		{
			this.NewItemViewData(new InventoryDefine.ItemViewDataInfo(configId, stackCount, 0, qualityId, isLock, isDeprecate, isNewItem, InventoryDefine.EItemDataType.CommonItem, commonItemData, hasRedDot, this.ViewMode, false, 0)
			{
				Count = stackCount,
				StackId = num2
			});
			num -= stackCount;
			num2++;
		}
		itemViewDataInfo.Count = num;
		itemViewDataInfo.StackId = num2;
		this.NewItemViewData(itemViewDataInfo);
	}

	// Token: 0x0600FEFE RID: 65278 RVA: 0x003DFFF4 File Offset: 0x003DE1F4
	[NullableContext(2)]
	private void SelectedItem(global::ItemViewData selectedItemViewData)
	{
		if (selectedItemViewData == null)
		{
			this.HideDescription();
			return;
		}
		InventoryDefine.ERedDotDisableRule redDotDisableRule = selectedItemViewData.GetRedDotDisableRule();
		InventoryModel instance = InventoryModel.Instance;
		this.RemoveItemViewNewFlag(selectedItemViewData);
		if (redDotDisableRule == InventoryDefine.ERedDotDisableRule.AfterSelect || redDotDisableRule == InventoryDefine.ERedDotDisableRule.ServerFirstSelect)
		{
			this.RemoveItemViewRedDot(selectedItemViewData);
		}
		if (selectedItemViewData.GetItemDataType() == InventoryDefine.EItemDataType.CommonItem)
		{
			instance.SaveNewCommonItemConfigIdList();
			instance.SaveRedDotCommonItemConfigIdList();
		}
		else
		{
			instance.SaveNewAttributeItemUniqueIdList();
			instance.SaveRedDotAttributeItemUniqueIdList();
		}
		this.RefreshSelectedItemView(selectedItemViewData);
		this.RefreshSameConfigIdItemView(selectedItemViewData);
		this.RefreshItemDescription(selectedItemViewData);
		this.SaveCurrentMarkPosition();
		if (this.ViewMode == ItemViewDefine.EItemOperationMode.Destruction)
		{
			this.RefreshDestroyModeViewByItem(selectedItemViewData, this.IsReloadData);
			if (!this.IsReloadData && !this.TryOpenStackDestroyCountPopup(selectedItemViewData))
			{
				this.TrySetItemDestroyModeSelectOn(!selectedItemViewData.GetSelectOn(), selectedItemViewData);
			}
		}
	}

	// Token: 0x0600FEFF RID: 65279 RVA: 0x003E00A8 File Offset: 0x003DE2A8
	private void RefreshCapacity(InventoryDefine.EItemMainTypeId itemMainTypeId, List<global::ItemViewData> allItemDataList)
	{
		InventoryConfig instance = InventoryConfig.Instance;
		ItemMainType? itemMainTypeConfig = instance.GetItemMainTypeConfig((int)itemMainTypeId);
		if (itemMainTypeConfig != null)
		{
			ItemMainType value = itemMainTypeConfig.Value;
			string name = value.Name;
			int packageId = value.PackageId;
			PackageCapacity? packageConfig = instance.GetPackageConfig(packageId);
			if (packageConfig != null)
			{
				PackageCapacity value2 = packageConfig.Value;
				UUIText text = base.GetText(5);
				LguiUtil.Instance.SetLocalTextNew(text, name, Array.Empty<object>());
				int count = allItemDataList.Count;
				int capacity = value2.Capacity;
				UUIText text2 = base.GetText(2);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				if (count >= capacity)
				{
					UUIText uuitext = text2;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
					defaultInterpolatedStringHandler.AppendLiteral("<color=red>");
					defaultInterpolatedStringHandler.AppendFormatted<int>(count);
					defaultInterpolatedStringHandler.AppendLiteral("</color>/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(capacity);
					uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
					AudioSystem.Instance.PostEvent("ui_inventory_capacity_full");
					return;
				}
				UUIText uuitext2 = text2;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(count);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(capacity);
				uuitext2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}
	}

	// Token: 0x0600FF00 RID: 65280 RVA: 0x003E01CC File Offset: 0x003DE3CC
	private void RefreshNoneItemVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(4);
		ULGUIBehaviour loopScrollViewComponent = base.GetLoopScrollViewComponent(6);
		item.SetUIActive(bVisible);
		loopScrollViewComponent.RootUIComp.Get().SetUIActive(!bVisible);
		this.RefreshDestroyEnterButton();
		if (bVisible && this.ViewMode == ItemViewDefine.EItemOperationMode.Destruction)
		{
			this.SetDestroyViewMode(ItemViewDefine.EDestroyViewMode.Default);
		}
	}

	// Token: 0x0600FF01 RID: 65281 RVA: 0x003E0220 File Offset: 0x003DE420
	private void OnItemButtonClicked(global::ItemViewData itemViewData)
	{
		if (this.SelectedItemViewData == itemViewData)
		{
			int gridIndex = this.ItemViewDataList.IndexOf(itemViewData);
			this.ItemScrollView.DeselectCurrentGridProxy(false);
			this.ItemScrollView.SelectGridProxy(gridIndex, false);
			if (this.ViewMode == ItemViewDefine.EItemOperationMode.Destruction && !this.TryOpenStackDestroyCountPopup(itemViewData))
			{
				this.TrySetItemDestroyModeSelectOn(!itemViewData.GetSelectOn(), itemViewData);
			}
			return;
		}
		this.SelectedItem(itemViewData);
	}

	// Token: 0x0600FF02 RID: 65282 RVA: 0x003E0288 File Offset: 0x003DE488
	private void SaveCurrentMarkPosition()
	{
		int selectedTypeIndex = InventoryModel.Instance.GetSelectedTypeIndex();
		this.TabMarkPositions[selectedTypeIndex] = this.ItemScrollView.GetSelectedGridIndex();
		int[] tabMarkUniqueIds = this.TabMarkUniqueIds;
		int num = selectedTypeIndex;
		global::ItemViewData selectedItemViewData = this.SelectedItemViewData;
		tabMarkUniqueIds[num] = ((selectedItemViewData != null) ? selectedItemViewData.GetUniqueId() : 0);
	}

	// Token: 0x0600FF03 RID: 65283 RVA: 0x003E02D0 File Offset: 0x003DE4D0
	private void RefreshSelectedItemView(global::ItemViewData itemViewData)
	{
		if (this.SelectedItemViewData != null)
		{
			this.ItemScrollView.DeselectCurrentGridProxy(false);
		}
		int num = this.ItemViewDataList.IndexOf(itemViewData);
		if (!this.ItemScrollView.IsGridDisplaying(num))
		{
			this.ItemScrollView.ScrollToGridIndex(num, true);
		}
		this.SelectedItemViewData = itemViewData;
		this.SelectedItemIndex = num;
		InventoryModel.Instance.SetSelectedItemViewData(itemViewData);
		this.ItemScrollView.SelectGridProxy(num, true);
		this.ItemScrollView.RefreshGridProxy(num);
		this.RefreshItemTipsFunction(itemViewData);
	}

	// Token: 0x0600FF04 RID: 65284 RVA: 0x003E0354 File Offset: 0x003DE554
	private void RemoveItemViewNewFlag(global::ItemViewData removeItemViewData)
	{
		removeItemViewData.RemoveNewItem();
		if (removeItemViewData.GetUniqueId() > 0)
		{
			return;
		}
		HashSet<global::ItemViewData> itemViewDataSetByConfigId = this.GetItemViewDataSetByConfigId(removeItemViewData.GetConfigId());
		if (itemViewDataSetByConfigId == null)
		{
			return;
		}
		foreach (global::ItemViewData itemViewData in itemViewDataSetByConfigId)
		{
			if (itemViewData != removeItemViewData)
			{
				itemViewData.RemoveNewItem();
			}
		}
	}

	// Token: 0x0600FF05 RID: 65285 RVA: 0x003E03C8 File Offset: 0x003DE5C8
	private void RemoveItemViewRedDot(global::ItemViewData removeItemViewData)
	{
		removeItemViewData.RemoveRedDotItem();
		if (removeItemViewData.GetUniqueId() > 0)
		{
			return;
		}
		HashSet<global::ItemViewData> itemViewDataSetByConfigId = this.GetItemViewDataSetByConfigId(removeItemViewData.GetConfigId());
		if (itemViewDataSetByConfigId == null)
		{
			return;
		}
		foreach (global::ItemViewData itemViewData in itemViewDataSetByConfigId)
		{
			if (itemViewData != removeItemViewData)
			{
				itemViewData.RemoveRedDotItem();
			}
		}
	}

	// Token: 0x0600FF06 RID: 65286 RVA: 0x003E043C File Offset: 0x003DE63C
	private void RefreshSameConfigIdItemView(global::ItemViewData checkItemViewData)
	{
		if (checkItemViewData.GetUniqueId() > 0)
		{
			return;
		}
		HashSet<global::ItemViewData> itemViewDataSetByConfigId = this.GetItemViewDataSetByConfigId(checkItemViewData.GetConfigId());
		if (itemViewDataSetByConfigId == null)
		{
			return;
		}
		foreach (global::ItemViewData itemViewData in itemViewDataSetByConfigId)
		{
			if (itemViewData != checkItemViewData)
			{
				int gridIndex = this.ItemViewDataList.IndexOf(itemViewData);
				this.ItemScrollView.RefreshGridProxy(gridIndex);
			}
		}
	}

	// Token: 0x0600FF07 RID: 65287 RVA: 0x003E04BC File Offset: 0x003DE6BC
	public void RefreshItemTipsFunction(global::ItemViewData itemViewData)
	{
		InventoryDefine.EItemType itemType = this.SelectedItemViewData.GetItemType();
		ItemDataBase itemDataBase = itemViewData.GetItemDataBase();
		this.ItemTipsComponent.ClearButtonList();
		List<ItemViewDefine.ETipsButtonType> tipsButtonListByCurrentItemData = this.GetTipsButtonListByCurrentItemData(itemDataBase);
		this.RefreshButtonByTypeList(tipsButtonListByCurrentItemData);
		if (itemType == InventoryDefine.EItemType.SpecialItem)
		{
			if (RouletteModel.Instance.IsExploreRouletteOpen(false) && !tipsButtonListByCurrentItemData.Contains(ItemViewDefine.ETipsButtonType.FragmentMemory) && !tipsButtonListByCurrentItemData.Contains(ItemViewDefine.ETipsButtonType.QuestReview))
			{
				this.RefreshSpecialItemText();
				return;
			}
		}
		else if (itemType != InventoryDefine.EItemType.Phantom && itemType != InventoryDefine.EItemType.Weapon)
		{
			if (itemDataBase.IsBuffEquipItem())
			{
				this.RefreshBuffEquipItemFunction(itemDataBase);
				return;
			}
			this.RefreshNormalItemFunction(itemDataBase);
		}
	}

	// Token: 0x0600FF08 RID: 65288 RVA: 0x003E0544 File Offset: 0x003DE744
	public void RefreshItemDescription(global::ItemViewData itemViewData)
	{
		ItemDataBase itemDataBase = itemViewData.GetItemDataBase();
		int configId = itemDataBase.GetConfigId();
		int uniqueId = itemDataBase.GetUniqueId();
		ItemTipsData tipsDataById = ItemTipsComponentUtilTool.GetTipsDataById(configId, new int?(uniqueId), null);
		tipsDataById.ShowPreview = false;
		TipsVisionData tipsVisionData = tipsDataById as TipsVisionData;
		if (tipsVisionData != null)
		{
			tipsVisionData.SelectedCount = ((this.ViewMode == ItemViewDefine.EItemOperationMode.Destruction && itemViewData.GetSelectOn()) ? itemViewData.GetSelectNum() : 0);
		}
		this.ItemTipsComponent.SetPreviewVisible(tipsDataById.PreviewType != ESkipName.NoSkip);
		ItemViewDefine.EItemOperationMode viewMode = this.ViewMode;
		if (viewMode != ItemViewDefine.EItemOperationMode.Normal)
		{
			if (viewMode == ItemViewDefine.EItemOperationMode.Destruction)
			{
				IGetWayItemData[] array = tipsDataById.GetWayData ?? Array.Empty<IGetWayItemData>();
				IGetWayItemData[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].Function = new Action(this.ForbiddenJumpFunction);
				}
				tipsDataById.GetWayData = array;
				this.ItemTipsComponent.RefreshTips(tipsDataById);
				this.ItemTipsComponent.SetVisible(true);
				this.ItemTipsComponent.SetTipsComponentLockButton(false);
			}
		}
		else
		{
			this.ItemTipsComponent.RefreshTips(tipsDataById);
			this.ItemTipsComponent.SetVisible(true);
		}
		this.LevelSequencePlayer.StopCurrentSequence(false, false);
	}

	// Token: 0x0600FF09 RID: 65289 RVA: 0x003E065F File Offset: 0x003DE85F
	private void OnSpecialItemUpdate(int? itemId)
	{
		this.RefreshSpecialItemText();
	}

	// Token: 0x0600FF0A RID: 65290 RVA: 0x003E0667 File Offset: 0x003DE867
	private void ForbiddenJumpFunction()
	{
		GenericPromptController.Instance.ShowPromptByCode("ItemDestroyNotJump", Array.Empty<object>());
	}

	// Token: 0x0600FF0B RID: 65291 RVA: 0x003E067D File Offset: 0x003DE87D
	private void HideDescription()
	{
		this.ItemTipsComponent.SetVisible(false);
	}

	// Token: 0x0600FF0C RID: 65292 RVA: 0x003E068C File Offset: 0x003DE88C
	private void SetTipsButtonEnableByType(ItemViewDefine.ETipsButtonType type, bool bEnable)
	{
		int num;
		if (this.TipsButtonIndexMap.TryGetValue(type, out num) && num != 0)
		{
			this.ItemTipsComponent.SetButtonEnableByIndex(num, bEnable);
		}
	}

	// Token: 0x0600FF0D RID: 65293 RVA: 0x003E06BC File Offset: 0x003DE8BC
	private void SetTipsButtonTextByType(ItemViewDefine.ETipsButtonType type, string text, [Nullable(new byte[]
	{
		2,
		1
	})] string[] @params = null)
	{
		if (this.TipsButtonIndexMap.ContainsKey(type))
		{
			int index;
			this.TipsButtonIndexMap.TryGetValue(type, out index);
			this.ItemTipsComponent.SetButtonTextByIndex(index, text, @params);
		}
	}

	// Token: 0x0600FF0E RID: 65294 RVA: 0x003E06F8 File Offset: 0x003DE8F8
	private void SetTipsButtonRedDotVisibleByType(ItemViewDefine.ETipsButtonType type, bool bVisible)
	{
		int index;
		if (this.TipsButtonIndexMap.TryGetValue(type, out index))
		{
			this.ItemTipsComponent.SetButtonRedDotVisible(index, bVisible);
		}
	}

	// Token: 0x0600FF0F RID: 65295 RVA: 0x003E0724 File Offset: 0x003DE924
	private void RefreshButtonByTypeList(List<ItemViewDefine.ETipsButtonType> typeList)
	{
		int num = 0;
		List<IButtonInfo> list = new List<IButtonInfo>();
		this.TipsButtonIndexMap.Clear();
		foreach (ItemViewDefine.ETipsButtonType key in typeList)
		{
			IButtonInfo buttonInfo;
			if (!this.TipsButtonRelationMap.TryGetValue(key, out buttonInfo))
			{
				global::Log.Instance.Error(ELogModule.Inventory, ELogAuthor.YYZ, "背包Tips按钮功能设置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			buttonInfo.Index = num;
			this.TipsButtonIndexMap.Add(key, num);
			list.Add(buttonInfo);
			num++;
		}
		this.ItemTipsComponent.RefreshButton(list);
	}

	// Token: 0x0600FF10 RID: 65296 RVA: 0x003E07DC File Offset: 0x003DE9DC
	private bool IsDestroyModeSelectMax()
	{
		return this.SelectItemSet.Count == 100;
	}

	// Token: 0x0600FF11 RID: 65297 RVA: 0x003E07F0 File Offset: 0x003DE9F0
	protected void SetViewMode(ItemViewDefine.EItemOperationMode viewMode)
	{
		ItemViewDefine.EItemOperationMode viewMode2 = this.ViewMode;
		this.ViewMode = viewMode;
		this.SelectItemSet.Clear();
		UUIButtonComponent button = base.GetButton(14);
		UUIButtonComponent button2 = base.GetButton(20);
		UUIExtendToggle extendToggle = base.GetExtendToggle(18);
		UUIItem item = base.GetItem(15);
		UUIText text = base.GetText(16);
		UUIText text2 = base.GetText(17);
		if (viewMode2 != this.ViewMode)
		{
			this.ClearFilterSortComponentData(viewMode2);
		}
		this.TabComponent.NeedCaptionSwitchWithToggle = (this.ViewMode == ItemViewDefine.EItemOperationMode.Normal);
		int selectedTypeIndex = InventoryModel.Instance.GetSelectedTypeIndex();
		this.TabComponent.SelectToggleByIndex(selectedTypeIndex, true);
		this.SelectedCurrentIndex();
		this.RefreshDestroyEnterButton();
		ItemViewDefine.EItemOperationMode viewMode3 = this.ViewMode;
		if (viewMode3 != ItemViewDefine.EItemOperationMode.Normal)
		{
			if (viewMode3 == ItemViewDefine.EItemOperationMode.Destruction)
			{
				this.TabComponent.SetTitle(ConfigMultiTextLang.GetLocalTextNew("Text_ItemRecycle_text", null));
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_DestroyModeIcon");
				this.TabComponent.SetTitleIcon(resourcePath);
				this.TabComponent.SetCloseBtnShowState(false);
				button.RootUIComp.Get().SetUIActive(true);
				this.ItemTipsComponent.SetButtonPanelVisible(false);
				button2.RootUIComp.Get().SetUIActive(true);
				item.SetUIActive(true);
				this.RefreshTotalSelectOnNum();
				text2.SetUIActive(true);
			}
		}
		else
		{
			this.TabComponent.SetCloseBtnShowState(true);
			button.RootUIComp.Get().SetUIActive(false);
			this.ItemTipsComponent.SetButtonPanelVisible(true);
			extendToggle.RootUIComp.Get().SetUIActive(false);
			button2.RootUIComp.Get().SetUIActive(false);
			this.NumberSelect.SetUiActive(false);
			item.SetUIActive(false);
			text.SetUIActive(false);
			text2.SetUIActive(false);
		}
		if (viewMode2 == this.ViewMode)
		{
			return;
		}
		string sequenceName = (viewMode2 == ItemViewDefine.EItemOperationMode.Normal) ? "DestroyShow" : "DestroyHide";
		this.UiViewSequence.PlaySequence(sequenceName, true, null);
	}

	// Token: 0x0600FF12 RID: 65298 RVA: 0x003E09F4 File Offset: 0x003DEBF4
	protected void SetDestroyViewMode(ItemViewDefine.EDestroyViewMode destroyViewMode)
	{
		this.DestroyViewMode = destroyViewMode;
		UUIText text = base.GetText(16);
		switch (this.DestroyViewMode)
		{
		case ItemViewDefine.EDestroyViewMode.Default:
		{
			int selectedTypeIndex = InventoryModel.Instance.GetSelectedTypeIndex();
			int id = this.ItemTypeList[selectedTypeIndex].Id;
			ItemMainType? itemMainTypeConfig = InventoryConfig.Instance.GetItemMainTypeConfig(id);
			bool flag = false;
			if (itemMainTypeConfig != null)
			{
				flag = itemMainTypeConfig.Value.BFilterSortVisible;
			}
			if (!flag)
			{
				text.ShowTextNew("Text_ItemRecycleChooseTip_text");
			}
			text.SetUIActive(!flag);
			this.FilterSortEntrance.SetUiActive(flag);
			this.SetDestroyAllSelectedState(new bool?(flag), null);
			this.NumberSelect.SetUiActive(false);
			break;
		}
		case ItemViewDefine.EDestroyViewMode.Disabled:
			text.SetUIActive(true);
			text.ShowTextNew("Text_ItemRecycleLimited_text");
			this.NumberSelect.SetUiActive(false);
			this.FilterSortEntrance.SetUiActive(false);
			this.SetDestroyAllSelectedState(new bool?(false), null);
			break;
		case ItemViewDefine.EDestroyViewMode.Multiple:
			text.SetUIActive(false);
			this.NumberSelect.SetUiActive(true);
			this.FilterSortEntrance.SetUiActive(false);
			this.SetDestroyAllSelectedState(new bool?(false), null);
			break;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Inventory;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "切换摧毁模式表现";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Mode", this.DestroyViewMode.ToString());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600FF13 RID: 65299 RVA: 0x003E0B78 File Offset: 0x003DED78
	private void RefreshDestroyModeViewByItem(global::ItemViewData itemViewData, bool isReloadData)
	{
		if (!itemViewData.IsItemCanDestroy())
		{
			this.SetDestroyViewMode(isReloadData ? ItemViewDefine.EDestroyViewMode.Default : ItemViewDefine.EDestroyViewMode.Disabled);
			return;
		}
		InventoryDefine.EItemDataType itemDataType = itemViewData.GetItemDataType();
		if (itemDataType != InventoryDefine.EItemDataType.CommonItem)
		{
			if (itemDataType - InventoryDefine.EItemDataType.WeaponItem > 1)
			{
				return;
			}
			this.SetDestroyViewMode(ItemViewDefine.EDestroyViewMode.Default);
		}
		else
		{
			this.SetDestroyViewMode(isReloadData ? ItemViewDefine.EDestroyViewMode.Default : ItemViewDefine.EDestroyViewMode.Multiple);
			if (!isReloadData)
			{
				this.RefreshNumberSelect(itemViewData);
				return;
			}
		}
	}

	// Token: 0x0600FF14 RID: 65300 RVA: 0x003E0BD0 File Offset: 0x003DEDD0
	[NullableContext(2)]
	private void TrySetItemDestroyModeSelectOn(bool isSelectedOn, global::ItemViewData itemViewData)
	{
		if (itemViewData == null)
		{
			return;
		}
		if (this.IsDestroyModeSelectMax() && isSelectedOn)
		{
			GenericPromptController.Instance.ShowPromptByCode("ItemDestroyCountLimit", Array.Empty<object>());
			return;
		}
		if (!itemViewData.IsItemCanDestroy())
		{
			if (this.DestroyViewMode != ItemViewDefine.EDestroyViewMode.Disabled)
			{
				this.SetDestroyViewMode(ItemViewDefine.EDestroyViewMode.Disabled);
			}
			return;
		}
		int num = this.ItemViewDataList.IndexOf(itemViewData);
		if (num < 0)
		{
			return;
		}
		foreach (global::ItemViewData itemViewData2 in new List<global::ItemViewData>(this.SelectItemSet))
		{
			if (itemViewData2.IsEqual(itemViewData, new bool?(true)))
			{
				this.SelectItemSet.Remove(itemViewData2);
				break;
			}
		}
		if (isSelectedOn)
		{
			this.SelectItemSet.Add(itemViewData);
			int destroyStackCount = this.GetDestroyStackCount(itemViewData);
			itemViewData.SetSelectNum(destroyStackCount);
		}
		else
		{
			itemViewData.SetSelectNum(0);
		}
		itemViewData.SetSelectOn(isSelectedOn);
		this.ItemScrollView.RefreshGridProxy(num);
		this.RefreshSelectOnPerformance(isSelectedOn, itemViewData);
	}

	// Token: 0x0600FF15 RID: 65301 RVA: 0x003E0CD0 File Offset: 0x003DEED0
	[return: Nullable(2)]
	private PhantomItemData GetStackPhantomItemData(global::ItemViewData itemViewData)
	{
		if (itemViewData.GetItemDataType() != InventoryDefine.EItemDataType.PhantomItem)
		{
			return null;
		}
		PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(itemViewData.GetUniqueId());
		if (phantomItemData == null || !phantomItemData.IsStack())
		{
			return null;
		}
		return phantomItemData;
	}

	// Token: 0x0600FF16 RID: 65302 RVA: 0x003E0D08 File Offset: 0x003DEF08
	private int GetDestroyStackCount(global::ItemViewData itemViewData)
	{
		PhantomItemData stackPhantomItemData = this.GetStackPhantomItemData(itemViewData);
		if (stackPhantomItemData == null)
		{
			return 1;
		}
		return stackPhantomItemData.GetStackCount();
	}

	// Token: 0x0600FF17 RID: 65303 RVA: 0x003E0D28 File Offset: 0x003DEF28
	private bool TryOpenStackDestroyCountPopup(global::ItemViewData itemViewData)
	{
		PhantomItemData stackPhantomItemData = this.GetStackPhantomItemData(itemViewData);
		if (stackPhantomItemData == null)
		{
			return false;
		}
		if (!itemViewData.IsItemCanDestroy())
		{
			if (this.DestroyViewMode != ItemViewDefine.EDestroyViewMode.Disabled)
			{
				this.SetDestroyViewMode(ItemViewDefine.EDestroyViewMode.Disabled);
			}
			return true;
		}
		if (this.IsDestroyModeSelectMax() && !itemViewData.GetSelectOn())
		{
			GenericPromptController.Instance.ShowPromptByCode("ItemDestroyCountLimit", Array.Empty<object>());
			return true;
		}
		int num = itemViewData.GetSelectOn() ? itemViewData.GetSelectNum() : 0;
		UiManager.Instance.OpenView(EUiViewName.PhantomStackCountPopupView, new PhantomStackCountPopupData
		{
			IncId = itemViewData.GetUniqueId(),
			MaxCount = stackPhantomItemData.GetStackCount(),
			MinCount = 0,
			InitCount = ((num > 0) ? num : 1),
			OnConfirm = delegate(int count)
			{
				this.SetItemDestroyModeSelectCount(itemViewData, count);
			}
		}, null);
		return true;
	}

	// Token: 0x0600FF18 RID: 65304 RVA: 0x003E0E1C File Offset: 0x003DF01C
	private void SetItemDestroyModeSelectCount(global::ItemViewData itemViewData, int count)
	{
		int num = this.ItemViewDataList.IndexOf(itemViewData);
		if (num < 0)
		{
			return;
		}
		foreach (global::ItemViewData itemViewData2 in new List<global::ItemViewData>(this.SelectItemSet))
		{
			if (itemViewData2.IsEqual(itemViewData, new bool?(true)))
			{
				this.SelectItemSet.Remove(itemViewData2);
				break;
			}
		}
		bool flag = count > 0;
		if (flag)
		{
			this.SelectItemSet.Add(itemViewData);
		}
		itemViewData.SetSelectNum(count);
		itemViewData.SetSelectOn(flag);
		this.ItemScrollView.RefreshGridProxy(num);
		this.RefreshSelectOnPerformance(flag, itemViewData);
		if (this.SelectedItemViewData == itemViewData)
		{
			this.RefreshItemDescription(itemViewData);
		}
	}

	// Token: 0x0600FF19 RID: 65305 RVA: 0x003E0EE4 File Offset: 0x003DF0E4
	private void RefreshSelectOnPerformance(bool isSelectedOn, global::ItemViewData itemViewData)
	{
		this.RefreshTotalSelectOnNum();
		ItemViewDefine.EDestroyViewMode destroyViewMode = this.DestroyViewMode;
		if (destroyViewMode != ItemViewDefine.EDestroyViewMode.Default)
		{
			if (destroyViewMode != ItemViewDefine.EDestroyViewMode.Multiple)
			{
				return;
			}
			if (isSelectedOn)
			{
				this.RefreshNumberSelect(this.SelectedItemViewData);
				return;
			}
			this.SetDestroyViewMode(ItemViewDefine.EDestroyViewMode.Default);
		}
		else if (isSelectedOn)
		{
			this.RefreshDestroyModeViewByItem(itemViewData, false);
			return;
		}
	}

	// Token: 0x0600FF1A RID: 65306 RVA: 0x003E0F2C File Offset: 0x003DF12C
	protected void SetDestroyAllSelectedState(bool? isShow = null, bool? isOn = null)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(18);
		if (isShow != null)
		{
			extendToggle.RootUIComp.Get().SetUIActive(isShow.Value);
		}
		if (isOn != null)
		{
			extendToggle.SetToggleState(isOn.Value ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x0600FF1B RID: 65307 RVA: 0x003E0F88 File Offset: 0x003DF188
	private void RefreshTotalSelectOnNum()
	{
		int count = this.SelectItemSet.Count;
		UUIText text = base.GetText(17);
		LguiUtil.Instance.SetLocalTextNew(text, "Text_ItemRecycleChosenTotal_text", new <>z__ReadOnlyArray<object>(new object[]
		{
			count.ToString(),
			100.ToString()
		}));
	}

	// Token: 0x0600FF1C RID: 65308 RVA: 0x003E0FDC File Offset: 0x003DF1DC
	private void RefreshDestroyEnterButton()
	{
		ULGUIBehaviour button = base.GetButton(13);
		bool flag = this.ViewMode == ItemViewDefine.EItemOperationMode.Destruction;
		bool flag2 = this.ItemScrollView.EndGridIndex >= 0;
		button.RootUIComp.Get().SetUIActive(!flag && flag2 && this.IsRealPlayerInventory());
	}

	// Token: 0x0600FF1D RID: 65309 RVA: 0x003E1030 File Offset: 0x003DF230
	protected void OnClickedDestroyExecuteButton()
	{
		InventoryView.<>c__DisplayClass148_0 CS$<>8__locals1 = new InventoryView.<>c__DisplayClass148_0();
		CS$<>8__locals1.<>4__this = this;
		if (this.ViewMode != ItemViewDefine.EItemOperationMode.Destruction)
		{
			return;
		}
		if (this.SelectItemSet.Count == 0)
		{
			GenericPromptController.Instance.ShowPromptByCode("ItemDestroyNotChoose", Array.Empty<object>());
			return;
		}
		bool flag = false;
		bool flag2 = false;
		CS$<>8__locals1.ifHighQuality = false;
		CS$<>8__locals1.stackSelectedCount = 0;
		CS$<>8__locals1.itemList = new List<DecomposeItemInfo>();
		List<global::ItemViewData> list = new List<global::ItemViewData>(this.SelectItemSet);
		list.Sort(new Comparison<global::ItemViewData>(this.SortViewDataConfigId));
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			int num = 0;
			while (i + 1 < count && list[i].GetConfigId() == list[i + 1].GetConfigId() && list[i].GetUniqueId() == 0 && list[i + 1].GetUniqueId() == 0)
			{
				num += list[i].GetSelectNum();
				i++;
			}
			DecomposeItemInfo decomposeItemInfo = DecomposeItemInfo.Create();
			decomposeItemInfo.ItemId = list[i].GetConfigId();
			decomposeItemInfo.IncrId = list[i].GetUniqueId();
			decomposeItemInfo.Count = num + list[i].GetSelectNum();
			CS$<>8__locals1.itemList.Add(decomposeItemInfo);
			if (decomposeItemInfo.IncrId > 0 && VisionEquipGroupModel.Instance.CheckVisionConsumeBreakGroup(decomposeItemInfo.IncrId, decomposeItemInfo.Count))
			{
				flag = true;
			}
			if (PhantomStackUtil.IsStackedPhantom(decomposeItemInfo.IncrId))
			{
				CS$<>8__locals1.stackSelectedCount += decomposeItemInfo.Count;
			}
			if (list[i].GetQuality() >= 4)
			{
				CS$<>8__locals1.ifHighQuality = true;
			}
			if (flag || CS$<>8__locals1.stackSelectedCount > 0 || (!flag2 & CS$<>8__locals1.ifHighQuality))
			{
				flag2 = true;
			}
		}
		if (InventoryModel.Instance.IsConfirmDestruction || !flag2)
		{
			CS$<>8__locals1.<OnClickedDestroyExecuteButton>g__confirmCallback|0();
			return;
		}
		if (flag)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DestroyVisionInGroup);
			confirmBoxDataNew.FunctionMap.Add(2, new Action(CS$<>8__locals1.<OnClickedDestroyExecuteButton>g__openConfirmDestroyConfirm|1));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		CS$<>8__locals1.<OnClickedDestroyExecuteButton>g__openConfirmDestroyConfirm|1();
	}

	// Token: 0x0600FF1E RID: 65310 RVA: 0x003E1252 File Offset: 0x003DF452
	private void OnClickedNotShowConfirm(bool toggleState)
	{
		InventoryModel.Instance.IsConfirmDestruction = toggleState;
	}

	// Token: 0x0600FF1F RID: 65311 RVA: 0x003E125F File Offset: 0x003DF45F
	private void OnClickedAllSelect(EToggleState toggleState)
	{
		if (this.ViewMode != ItemViewDefine.EItemOperationMode.Destruction)
		{
			return;
		}
		this.<OnClickedAllSelect>g__selectAll|150_0(toggleState == EToggleState.ETT_Checked);
	}

	// Token: 0x0600FF20 RID: 65312 RVA: 0x003E1278 File Offset: 0x003DF478
	private void OnClickedManage()
	{
		global::ItemViewData selectedItemViewData = this.SelectedItemViewData;
		int num = (selectedItemViewData != null) ? selectedItemViewData.GetUniqueId() : 0;
		global::ItemViewData selectedItemViewData2 = this.SelectedItemViewData;
		if (selectedItemViewData2 == null || selectedItemViewData2.GetItemDataType() != InventoryDefine.EItemDataType.PhantomItem)
		{
			num = 0;
		}
		UiManager.Instance.OpenView(EUiViewName.PhantomManageView, num, null);
	}

	// Token: 0x0600FF21 RID: 65313 RVA: 0x003E12CA File Offset: 0x003DF4CA
	private void OnClickedRecovery()
	{
		CalabashController.Instance.JumpToCalabashRootView(EUiTabViewName.VisionRecoveryTabView, null);
	}

	// Token: 0x0600FF22 RID: 65314 RVA: 0x003E12DC File Offset: 0x003DF4DC
	protected int SortViewDataSelectOn(global::ItemViewData dataA, global::ItemViewData dataB)
	{
		int num = (dataA.GetSelectOn() > false) ? 1 : 0;
		return ((dataB.GetSelectOn() > false) ? 1 : 0) - num;
	}

	// Token: 0x0600FF23 RID: 65315 RVA: 0x003E12FE File Offset: 0x003DF4FE
	protected int SortViewDataConfigId(global::ItemViewData dataA, global::ItemViewData dataB)
	{
		return dataA.GetConfigId() - dataB.GetConfigId();
	}

	// Token: 0x0600FF24 RID: 65316 RVA: 0x003E1310 File Offset: 0x003DF510
	[NullableContext(2)]
	private void RefreshNumberSelect(global::ItemViewData itemViewData)
	{
		if (itemViewData == null)
		{
			return;
		}
		INumberSelectData data = new INumberSelectData
		{
			MaxNumber = itemViewData.GetCount(),
			GetExchangeTableText = new Func<int, TableTextArgNew>(this.GetExchangeTableText),
			ValueChangeFunction = new Action<int>(this.ValueChangeFunction)
		};
		this.NumberSelect.Init(data);
	}

	// Token: 0x0600FF25 RID: 65317 RVA: 0x003E1363 File Offset: 0x003DF563
	private TableTextArgNew GetExchangeTableText(int selectValue)
	{
		return new TableTextArgNew(TextConfig.Instance.GetTextContentIdById("ItemRecycleCount"), new <>z__ReadOnlySingleElementList<object>(selectValue));
	}

	// Token: 0x0600FF26 RID: 65318 RVA: 0x003E1384 File Offset: 0x003DF584
	private void ValueChangeFunction(int selectValue)
	{
		if (this.SelectedItemViewData == null)
		{
			return;
		}
		int num = this.ItemViewDataList.IndexOf(this.SelectedItemViewData);
		if (num < 0)
		{
			return;
		}
		this.SelectedItemViewData.SetSelectNum(selectValue);
		this.ItemScrollView.RefreshGridProxy(num);
	}

	// Token: 0x0600FF27 RID: 65319 RVA: 0x003E13CC File Offset: 0x003DF5CC
	private unsafe void SelectTypeIndexByOpenParam()
	{
		if (this.OpenParam == null)
		{
			return;
		}
		if (!(this.OpenParam is int))
		{
			global::Log.Instance.Error(ELogModule.Inventory, ELogAuthor.CB, "跳转参数类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int num = (int)this.OpenParam;
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(num);
		if (attributeItemData == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Inventory;
			ELogAuthor author = ELogAuthor.CB;
			string message = "要定位的背包物品不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("uniqueId", num);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		InventoryDefine.EItemMainTypeId? mainType = attributeItemData.GetMainType();
		int num2 = this.ItemTypeList.FindIndex((ItemMainType item) => item.Id == (int)mainType.Value);
		if (num2 != -1)
		{
			InventoryModel.Instance.SetSelectedTypeIndex(num2);
			return;
		}
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.Inventory;
		ELogAuthor author2 = ELogAuthor.CB;
		string message2 = "要定位的物品找不到对应页签";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("uniqueId", num);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("mainType", mainType);
		instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0600FF28 RID: 65320 RVA: 0x003E14F4 File Offset: 0x003DF6F4
	private void SelectGridIndexByOpenParam(List<global::ItemViewData> itemViewDataList)
	{
		if (this.OpenParam == null)
		{
			return;
		}
		if (!(this.OpenParam is int))
		{
			global::Log.Instance.Error(ELogModule.Inventory, ELogAuthor.CB, "跳转参数类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int uniqueId = (int)this.OpenParam;
		int num = itemViewDataList.FindIndex((global::ItemViewData item) => item.GetUniqueId() == uniqueId);
		if (num != -1)
		{
			this.SaveCurrentMarkPositionByGridIndex(num, uniqueId);
		}
		else
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Inventory;
			ELogAuthor author = ELogAuthor.CB;
			string message = "要定位的物品找不到对应格子";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("uniqueId", uniqueId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.OpenParam = null;
	}

	// Token: 0x0600FF29 RID: 65321 RVA: 0x003E15AC File Offset: 0x003DF7AC
	private void SaveCurrentMarkPositionByGridIndex(int gridIndex, int uniqueId)
	{
		int selectedTypeIndex = InventoryModel.Instance.GetSelectedTypeIndex();
		this.TabMarkPositions[selectedTypeIndex] = gridIndex;
		this.TabMarkUniqueIds[selectedTypeIndex] = uniqueId;
	}

	// Token: 0x0600FF2A RID: 65322 RVA: 0x003E15D8 File Offset: 0x003DF7D8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (!(configParams[0] == "Filter"))
		{
			return null;
		}
		UUIItem filterToggleItem = this.FilterSortEntrance.GetFilterToggleItem();
		if (filterToggleItem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			filterToggleItem,
			filterToggleItem
		};
	}

	// Token: 0x0600FF2B RID: 65323 RVA: 0x003E1618 File Offset: 0x003DF818
	[NullableContext(0)]
	public virtual bool TryGetMember(string key, out object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 8:
				if (key == "ViewMode")
				{
					value = this.ViewMode;
					return true;
				}
				break;
			case 12:
			{
				char c = key[1];
				if (c != 'a')
				{
					switch (c)
					{
					case 's':
						if (key == "IsReloadData")
						{
							value = this.IsReloadData;
							return true;
						}
						break;
					case 't':
						if (key == "ItemTypeList")
						{
							value = this.ItemTypeList;
							return true;
						}
						break;
					case 'u':
						if (key == "NumberSelect")
						{
							value = this.NumberSelect;
							return true;
						}
						break;
					}
				}
				else if (key == "TabComponent")
				{
					value = this.TabComponent;
					return true;
				}
				break;
			}
			case 13:
				if (key == "SelectItemSet")
				{
					value = this.SelectItemSet;
					return true;
				}
				break;
			case 14:
			{
				char c = key[1];
				if (c != 's')
				{
					if (c == 't')
					{
						if (key == "ItemScrollView")
						{
							value = this.ItemScrollView;
							return true;
						}
					}
				}
				else if (key == "IsReSelectType")
				{
					value = this.IsReSelectType;
					return true;
				}
				break;
			}
			case 15:
			{
				char c = key[0];
				if (c != 'D')
				{
					if (c == 'I')
					{
						if (key == "ItemViewDataMap")
						{
							value = this.ItemViewDataMap;
							return true;
						}
					}
				}
				else if (key == "DestroyViewMode")
				{
					value = this.DestroyViewMode;
					return true;
				}
				break;
			}
			case 16:
			{
				char c = key[9];
				if (c <= 'T')
				{
					if (c != 'I')
					{
						if (c == 'T')
						{
							if (key == "RefreshCdTimerId")
							{
								value = this.RefreshCdTimerId;
								return true;
							}
						}
					}
					else if (key == "CurrentCdItemMap")
					{
						value = this.CurrentCdItemMap;
						return true;
					}
				}
				else if (c != 'a')
				{
					if (c != 'i')
					{
						if (c == 's')
						{
							if (key == "TabMarkPositions")
							{
								value = this.TabMarkPositions;
								return true;
							}
						}
					}
					else if (key == "TabMarkUniqueIds")
					{
						value = this.TabMarkUniqueIds;
						return true;
					}
				}
				else if (key == "ItemViewDataList")
				{
					value = this.ItemViewDataList;
					return true;
				}
				break;
			}
			case 17:
			{
				char c = key[1];
				if (c != 'e')
				{
					if (c != 's')
					{
						if (c == 't')
						{
							if (key == "ItemTipsComponent")
							{
								value = this.ItemTipsComponent;
								return true;
							}
						}
					}
					else if (key == "IsMaxCapacityFlag")
					{
						value = this.IsMaxCapacityFlag;
						return true;
					}
				}
				else if (key == "SelectedItemIndex")
				{
					value = this.SelectedItemIndex;
					return true;
				}
				break;
			}
			case 18:
			{
				char c = key[0];
				if (c != 'F')
				{
					if (c == 'T')
					{
						if (key == "TipsButtonIndexMap")
						{
							value = this.TipsButtonIndexMap;
							return true;
						}
					}
				}
				else if (key == "FilterSortEntrance")
				{
					value = this.FilterSortEntrance;
					return true;
				}
				break;
			}
			case 19:
			{
				char c = key[18];
				if (c <= '2')
				{
					if (c != '1')
					{
						if (c == '2')
						{
							if (key == "CommonCurrencyItem2")
							{
								value = this.CommonCurrencyItem2;
								return true;
							}
						}
					}
					else if (key == "CommonCurrencyItem1")
					{
						value = this.CommonCurrencyItem1;
						return true;
					}
				}
				else if (c != 'r')
				{
					if (c == 't')
					{
						if (key == "InvalidItemTempList")
						{
							value = this.InvalidItemTempList;
							return true;
						}
					}
				}
				else if (key == "LevelSequencePlayer")
				{
					value = this.LevelSequencePlayer;
					return true;
				}
				break;
			}
			case 20:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c == 'S')
					{
						if (key == "SelectedItemViewData")
						{
							value = this.SelectedItemViewData;
							return true;
						}
					}
				}
				else if (key == "AccessPathButtonList")
				{
					value = this.AccessPathButtonList;
					return true;
				}
				break;
			}
			case 21:
			{
				char c = key[2];
				if (c != 'I')
				{
					if (c != 'M')
					{
						if (c == 'p')
						{
							if (key == "TipsButtonRelationMap")
							{
								value = this.TipsButtonRelationMap;
								return true;
							}
						}
					}
					else if (key == "IsMaxCapacityViewShow")
					{
						value = this.IsMaxCapacityViewShow;
						return true;
					}
				}
				else if (key == "IsInvalidItemViewShow")
				{
					value = this.IsInvalidItemViewShow;
					return true;
				}
				break;
			}
			case 23:
				if (key == "CacheExpireShowDataList")
				{
					value = this.CacheExpireShowDataList;
					return true;
				}
				break;
			case 27:
				if (key == "IsExpireConvertItemViewShow")
				{
					value = this.IsExpireConvertItemViewShow;
					return true;
				}
				break;
			}
		}
		value = null;
		return false;
	}

	// Token: 0x0600FF2C RID: 65324 RVA: 0x003E1BE4 File Offset: 0x003DFDE4
	[NullableContext(0)]
	public virtual void SetMember(string key, object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 8:
				if (key == "ViewMode")
				{
					this.ViewMode = (ItemViewDefine.EItemOperationMode)value;
					return;
				}
				break;
			case 12:
			{
				char c = key[1];
				if (c != 'a')
				{
					switch (c)
					{
					case 's':
						if (key == "IsReloadData")
						{
							this.IsReloadData = (bool)value;
							return;
						}
						break;
					case 't':
						if (key == "ItemTypeList")
						{
							this.ItemTypeList = (List<ItemMainType>)value;
							return;
						}
						break;
					case 'u':
						if (key == "NumberSelect")
						{
							this.NumberSelect = (NumberSelectComponent)value;
							return;
						}
						break;
					}
				}
				else if (key == "TabComponent")
				{
					this.TabComponent = (TabComponentWithCaptionItem<CommonTabItem>)value;
					return;
				}
				break;
			}
			case 14:
			{
				char c = key[1];
				if (c != 's')
				{
					if (c == 't')
					{
						if (key == "ItemScrollView")
						{
							this.ItemScrollView = (LoopScrollView<InventoryMediumItemGrid, global::ItemViewData>)value;
							return;
						}
					}
				}
				else if (key == "IsReSelectType")
				{
					this.IsReSelectType = (bool)value;
					return;
				}
				break;
			}
			case 15:
				if (key == "DestroyViewMode")
				{
					this.DestroyViewMode = (ItemViewDefine.EDestroyViewMode)value;
					return;
				}
				break;
			case 16:
			{
				char c = key[7];
				if (c <= 'P')
				{
					if (c != 'C')
					{
						if (c == 'P')
						{
							if (key == "TabMarkPositions")
							{
								this.TabMarkPositions = (int[])value;
								return;
							}
						}
					}
					else if (key == "RefreshCdTimerId")
					{
						this.RefreshCdTimerId = (TimerHandle)value;
						return;
					}
				}
				else if (c != 'U')
				{
					if (c == 'w')
					{
						if (key == "ItemViewDataList")
						{
							this.ItemViewDataList = (List<global::ItemViewData>)value;
							return;
						}
					}
				}
				else if (key == "TabMarkUniqueIds")
				{
					this.TabMarkUniqueIds = (int[])value;
					return;
				}
				break;
			}
			case 17:
			{
				char c = key[1];
				if (c != 'e')
				{
					if (c != 's')
					{
						if (c == 't')
						{
							if (key == "ItemTipsComponent")
							{
								this.ItemTipsComponent = (ItemTipsWithButtonComponent)value;
								return;
							}
						}
					}
					else if (key == "IsMaxCapacityFlag")
					{
						this.IsMaxCapacityFlag = (bool)value;
						return;
					}
				}
				else if (key == "SelectedItemIndex")
				{
					int selectedItemIndex;
					if (value is double)
					{
						double num = (double)value;
						selectedItemIndex = (int)num;
					}
					else if (value is float)
					{
						float num2 = (float)value;
						selectedItemIndex = (int)num2;
					}
					else if (value is int)
					{
						int num3 = (int)value;
						selectedItemIndex = num3;
					}
					else if (value is long)
					{
						long num4 = (long)value;
						selectedItemIndex = (int)num4;
					}
					else
					{
						selectedItemIndex = (int)value;
					}
					this.SelectedItemIndex = selectedItemIndex;
					return;
				}
				break;
			}
			case 18:
			{
				char c = key[0];
				if (c != 'F')
				{
					if (c == 'T')
					{
						if (key == "TipsButtonIndexMap")
						{
							this.TipsButtonIndexMap = (Dictionary<ItemViewDefine.ETipsButtonType, int>)value;
							return;
						}
					}
				}
				else if (key == "FilterSortEntrance")
				{
					this.FilterSortEntrance = (FilterSortEntrance<global::ItemViewData>)value;
					return;
				}
				break;
			}
			case 19:
			{
				char c = key[18];
				if (c <= '2')
				{
					if (c != '1')
					{
						if (c == '2')
						{
							if (key == "CommonCurrencyItem2")
							{
								this.CommonCurrencyItem2 = (CommonCurrencyItem)value;
								return;
							}
						}
					}
					else if (key == "CommonCurrencyItem1")
					{
						this.CommonCurrencyItem1 = (CommonCurrencyItem)value;
						return;
					}
				}
				else if (c != 'r')
				{
					if (c == 't')
					{
						if (key == "InvalidItemTempList")
						{
							this.InvalidItemTempList = (List<Dictionary<int, int>>)value;
							return;
						}
					}
				}
				else if (key == "LevelSequencePlayer")
				{
					this.LevelSequencePlayer = (LevelSequencePlayer)value;
					return;
				}
				break;
			}
			case 20:
				if (key == "SelectedItemViewData")
				{
					this.SelectedItemViewData = (global::ItemViewData)value;
					return;
				}
				break;
			case 21:
			{
				char c = key[2];
				if (c != 'I')
				{
					if (c != 'M')
					{
						if (c == 'p')
						{
							if (key == "TipsButtonRelationMap")
							{
								this.TipsButtonRelationMap = (Dictionary<ItemViewDefine.ETipsButtonType, IButtonInfo>)value;
								return;
							}
						}
					}
					else if (key == "IsMaxCapacityViewShow")
					{
						this.IsMaxCapacityViewShow = (bool)value;
						return;
					}
				}
				else if (key == "IsInvalidItemViewShow")
				{
					this.IsInvalidItemViewShow = (bool)value;
					return;
				}
				break;
			}
			case 27:
				if (key == "IsExpireConvertItemViewShow")
				{
					this.IsExpireConvertItemViewShow = (bool)value;
					return;
				}
				break;
			}
		}
		throw new KeyNotFoundException("设置InventoryView成员属性失败" + key + ")");
	}

	// Token: 0x0600FF30 RID: 65328 RVA: 0x003E2180 File Offset: 0x003E0380
	[CompilerGenerated]
	private void <OnClickedAllSelect>g__selectAll|150_0(bool selectOn)
	{
		if (!selectOn)
		{
			foreach (global::ItemViewData itemViewData in this.ItemViewDataList)
			{
				if (itemViewData.IsItemCanDestroy() && itemViewData.GetUniqueId() != 0)
				{
					this.TrySetItemDestroyModeSelectOn(false, itemViewData);
				}
			}
			return;
		}
		foreach (global::ItemViewData itemViewData2 in new List<global::ItemViewData>(this.SelectItemSet))
		{
			int destroyStackCount = this.GetDestroyStackCount(itemViewData2);
			if (itemViewData2.GetSelectNum() < destroyStackCount)
			{
				this.SetItemDestroyModeSelectCount(itemViewData2, destroyStackCount);
			}
		}
		foreach (global::ItemViewData itemViewData3 in this.ItemViewDataList)
		{
			if (this.IsDestroyModeSelectMax())
			{
				break;
			}
			if (!itemViewData3.GetSelectOn() && itemViewData3.IsItemCanDestroy() && itemViewData3.GetUniqueId() != 0)
			{
				this.TrySetItemDestroyModeSelectOn(true, itemViewData3);
			}
		}
	}

	// Token: 0x040075EE RID: 30190
	[Nullable(2)]
	private global::ItemViewData SelectedItemViewData;

	// Token: 0x040075EF RID: 30191
	private int SelectedItemIndex;

	// Token: 0x040075F0 RID: 30192
	private readonly List<AccessPathButton> AccessPathButtonList = new List<AccessPathButton>();

	// Token: 0x040075F1 RID: 30193
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<InventoryMediumItemGrid, global::ItemViewData> ItemScrollView;

	// Token: 0x040075F2 RID: 30194
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<global::ItemViewData> FilterSortEntrance;

	// Token: 0x040075F3 RID: 30195
	[Nullable(2)]
	private TimerHandle RefreshCdTimerId;

	// Token: 0x040075F4 RID: 30196
	private readonly Dictionary<int, BuffItemData> CurrentCdItemMap = new Dictionary<int, BuffItemData>();

	// Token: 0x040075F5 RID: 30197
	[Nullable(2)]
	private CommonCurrencyItem CommonCurrencyItem1;

	// Token: 0x040075F6 RID: 30198
	[Nullable(2)]
	private CommonCurrencyItem CommonCurrencyItem2;

	// Token: 0x040075F7 RID: 30199
	private List<global::ItemViewData> ItemViewDataList = new List<global::ItemViewData>();

	// Token: 0x040075F8 RID: 30200
	private readonly Dictionary<int, HashSet<global::ItemViewData>> ItemViewDataMap = new Dictionary<int, HashSet<global::ItemViewData>>();

	// Token: 0x040075F9 RID: 30201
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<CommonTabItem> TabComponent;

	// Token: 0x040075FA RID: 30202
	[Nullable(2)]
	private List<ItemMainType> ItemTypeList;

	// Token: 0x040075FB RID: 30203
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040075FC RID: 30204
	[Nullable(2)]
	private ItemTipsWithButtonComponent ItemTipsComponent;

	// Token: 0x040075FD RID: 30205
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<ItemViewDefine.ETipsButtonType, IButtonInfo> TipsButtonRelationMap;

	// Token: 0x040075FE RID: 30206
	[Nullable(2)]
	protected Dictionary<ItemViewDefine.ETipsButtonType, int> TipsButtonIndexMap;

	// Token: 0x040075FF RID: 30207
	[Nullable(2)]
	private int[] TabMarkPositions;

	// Token: 0x04007600 RID: 30208
	[Nullable(2)]
	private int[] TabMarkUniqueIds;

	// Token: 0x04007601 RID: 30209
	private ItemViewDefine.EItemOperationMode ViewMode;

	// Token: 0x04007602 RID: 30210
	[Nullable(2)]
	private NumberSelectComponent NumberSelect;

	// Token: 0x04007603 RID: 30211
	private bool IsReloadData;

	// Token: 0x04007604 RID: 30212
	private bool IsReSelectType;

	// Token: 0x04007605 RID: 30213
	private bool IsMaxCapacityViewShow;

	// Token: 0x04007606 RID: 30214
	private bool IsMaxCapacityFlag;

	// Token: 0x04007607 RID: 30215
	protected List<Dictionary<int, int>> InvalidItemTempList = new List<Dictionary<int, int>>();

	// Token: 0x04007608 RID: 30216
	protected bool IsInvalidItemViewShow;

	// Token: 0x04007609 RID: 30217
	private readonly List<ItemExpiredAutoConvertTipsViewDefine> CacheExpireShowDataList = new List<ItemExpiredAutoConvertTipsViewDefine>();

	// Token: 0x0400760A RID: 30218
	protected bool IsExpireConvertItemViewShow;

	// Token: 0x0400760B RID: 30219
	private ItemViewDefine.EDestroyViewMode DestroyViewMode;

	// Token: 0x0400760C RID: 30220
	private readonly HashSet<global::ItemViewData> SelectItemSet = new HashSet<global::ItemViewData>();
}
