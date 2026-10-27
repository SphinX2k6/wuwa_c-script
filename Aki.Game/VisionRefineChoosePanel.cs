using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001769 RID: 5993
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineChoosePanel : UiPanelBase
{
	// Token: 0x17000E6B RID: 3691
	// (get) Token: 0x0600ADA4 RID: 44452 RVA: 0x00271768 File Offset: 0x0026F968
	private PhantomItemData SelectedData
	{
		get
		{
			if (this.CurrentRefineType == EVisionRefineRefineType.Main)
			{
				Log.Instance.Error(ELogModule.Calabash, ELogAuthor.WZ, "主音洗练时不应该使用单选逻辑", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return this.SelectedDataInternal;
		}
	}

	// Token: 0x17000E6C RID: 3692
	// (get) Token: 0x0600ADA5 RID: 44453 RVA: 0x002717A4 File Offset: 0x0026F9A4
	public EFilterSortGroupId FilterSortGroupId
	{
		get
		{
			if (this.CurrentRefineType == EVisionRefineRefineType.Main)
			{
				EVisionRefineCostType? currentCostType = this.CurrentCostType;
				if (currentCostType != null)
				{
					switch (currentCostType.GetValueOrDefault())
					{
					case EVisionRefineCostType.Cost4:
						return EFilterSortGroupId.VisionRefineMainCost4C;
					case EVisionRefineCostType.Cost3:
						return EFilterSortGroupId.VisionRefineMainCost3C;
					case EVisionRefineCostType.Cost1:
						return EFilterSortGroupId.VisionRefineMainCost1C;
					}
				}
				return EFilterSortGroupId.VisionRefine;
			}
			if (this.CurrentRefineType == EVisionRefineRefineType.Sub)
			{
				return EFilterSortGroupId.VisionRefineSub;
			}
			return EFilterSortGroupId.VisionRefine;
		}
	}

	// Token: 0x17000E6D RID: 3693
	// (get) Token: 0x0600ADA6 RID: 44454 RVA: 0x00271800 File Offset: 0x0026FA00
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<ISelectedData> CurrentSelectedList
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			if (this.CurrentRefineType != EVisionRefineRefineType.Main)
			{
				Log.Instance.Error(ELogModule.Calabash, ELogAuthor.WZ, "辅音洗练时不应该使用多选逻辑", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			if (this.CurrentCostType == null)
			{
				Log.Instance.Error(ELogModule.Calabash, ELogAuthor.WZ, "主音洗练时尚未选择cost，检查调用时机", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			List<ISelectedData> result;
			if (this.MultiSelectedData.TryGetValue(this.CurrentCostType.Value, out result))
			{
				return result;
			}
			return null;
		}
	}

	// Token: 0x17000E6E RID: 3694
	// (get) Token: 0x0600ADA7 RID: 44455 RVA: 0x00271887 File Offset: 0x0026FA87
	// (set) Token: 0x0600ADA8 RID: 44456 RVA: 0x0027188F File Offset: 0x0026FA8F
	public EVisionRefineRefineType CurrentRefineType
	{
		get
		{
			return this.CurrentRefineTypeInternal;
		}
		set
		{
			this.CurrentRefineTypeInternal = value;
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.CurrentRefineTypeInternal == EVisionRefineRefineType.Main);
		}
	}

	// Token: 0x17000E6F RID: 3695
	// (get) Token: 0x0600ADA9 RID: 44457 RVA: 0x002718B4 File Offset: 0x0026FAB4
	public EVisionRefineCostType? CurrentCostType
	{
		get
		{
			if (this.CurrentRefineType == EVisionRefineRefineType.Sub)
			{
				Log.Instance.Error(ELogModule.Calabash, ELogAuthor.WZ, "辅音洗练时不应该使用Cost逻辑", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return new EVisionRefineCostType?(this.CurrentCostTypeInternal);
		}
	}

	// Token: 0x0600ADAA RID: 44458 RVA: 0x00271900 File Offset: 0x0026FB00
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickMask)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickClose))
		};
	}

	// Token: 0x0600ADAB RID: 44459 RVA: 0x00271A5F File Offset: 0x0026FC5F
	protected override void OnBeforeCreateImplement()
	{
		this.UiViewSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiViewSequence);
	}

	// Token: 0x0600ADAC RID: 44460 RVA: 0x00271A7C File Offset: 0x0026FC7C
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineChoosePanel.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineChoosePanel.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600ADAD RID: 44461 RVA: 0x00271ABF File Offset: 0x0026FCBF
	protected override void OnStart()
	{
		this.FilterEntrance = new FilterEntrance<PhantomItemData>(base.GetItem(7), new TUpdateDataListFunction<PhantomItemData>(this.OnFilterSortRefresh));
		this.SortEntrance = new SortEntrance<PhantomItemData>(base.GetItem(8), new TUpdateDataListFunction<PhantomItemData>(this.OnFilterSortRefresh));
	}

	// Token: 0x0600ADAE RID: 44462 RVA: 0x00271B00 File Offset: 0x0026FD00
	[NullableContext(1)]
	private VisionRefineMediumItemGrid InitItem()
	{
		VisionRefineMediumItemGrid visionRefineMediumItemGrid = new VisionRefineMediumItemGrid();
		visionRefineMediumItemGrid.SetUseFixedAsync(true);
		visionRefineMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnItemToggleStateChanged));
		visionRefineMediumItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnItemClicked));
		visionRefineMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnItemCanExecuteChange));
		visionRefineMediumItemGrid.BindReduceButtonCallback(new Action<MediumItemGridButtonCallback>(this.OnItemReduceButtonClicked), null);
		visionRefineMediumItemGrid.CheckSelectByView = new Func<PhantomItemData, bool>(this.CheckItemSelect);
		visionRefineMediumItemGrid.CheckFocusByView = new Func<PhantomItemData, bool>(this.CheckItemFocus);
		visionRefineMediumItemGrid.CheckWarningByView = new Func<PhantomItemData, bool>(this.CheckItemWarning);
		visionRefineMediumItemGrid.GetRefineType = (() => this.CurrentRefineType);
		visionRefineMediumItemGrid.GetSelectedCountByView = new Func<PhantomItemData, int>(this.GetSelectedUnitCountByData);
		return visionRefineMediumItemGrid;
	}

	// Token: 0x0600ADAF RID: 44463 RVA: 0x00271BBC File Offset: 0x0026FDBC
	[NullableContext(1)]
	private void OnItemClicked(MediumItemGridExtendCallback callbackData)
	{
		if (this.CurrentRefineType != EVisionRefineRefineType.Main)
		{
			return;
		}
		PhantomItemData phantomItemData = callbackData.Data as PhantomItemData;
		if (phantomItemData == null)
		{
			return;
		}
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(phantomItemData.GetUniqueId());
		if (phantomBattleData == null || !phantomBattleData.GetVisionIfCanRefine(this.CurrentRefineType))
		{
			return;
		}
		this.MoveFocusTo(phantomItemData);
		if (!phantomItemData.IsStack())
		{
			return;
		}
		this.TryOpenStackCountPopup(phantomItemData);
	}

	// Token: 0x0600ADB0 RID: 44464 RVA: 0x00271C1D File Offset: 0x0026FE1D
	[NullableContext(1)]
	private VisionRefineTabCostItem InitCostTabItem()
	{
		return new VisionRefineTabCostItem();
	}

	// Token: 0x0600ADB1 RID: 44465 RVA: 0x00271C24 File Offset: 0x0026FE24
	public void ClearSelection()
	{
		this.RefreshChangeSelect(null);
		if (this.OnChangeCallBack != null)
		{
			this.OnChangeCallBack(this.SelectedData);
		}
	}

	// Token: 0x0600ADB2 RID: 44466 RVA: 0x00271C48 File Offset: 0x0026FE48
	public void ClearCurrentCostMultiChoose()
	{
		if (this.CurrentCostType == null)
		{
			return;
		}
		List<ISelectedData> list;
		if (!this.MultiSelectedData.TryGetValue(this.CurrentCostType.Value, out list))
		{
			return;
		}
		for (int i = list.Count - 1; i >= 0; i--)
		{
			int incId = list[i].IncId;
			list.RemoveAt(i);
			PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(incId);
			if (phantomItemData != null)
			{
				this.RefreshGridByData(phantomItemData);
			}
		}
	}

	// Token: 0x0600ADB3 RID: 44467 RVA: 0x00271CC4 File Offset: 0x0026FEC4
	public void RemoveInvalidSelections()
	{
		this.ShowTipsComponent(null);
		if (this.SelectedDataInternal != null)
		{
			int uniqueId = this.SelectedDataInternal.GetUniqueId();
			if (PhantomBattleModel.Instance.GetPhantomDataBase(uniqueId) == null)
			{
				this.SelectedDataInternal = null;
			}
		}
		foreach (KeyValuePair<EVisionRefineCostType, List<ISelectedData>> keyValuePair in this.MultiSelectedData)
		{
			List<ISelectedData> value = keyValuePair.Value;
			for (int i = value.Count - 1; i >= 0; i--)
			{
				ISelectedData selectedData = value[i];
				bool phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(selectedData.IncId) != null;
				PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(selectedData.IncId);
				if (!phantomDataBase || phantomItemData == null)
				{
					value.RemoveAt(i);
				}
				else
				{
					int stackCount = phantomItemData.GetStackCount();
					if (selectedData.SelectedCount > stackCount)
					{
						selectedData.SelectedCount = stackCount;
					}
				}
			}
		}
	}

	// Token: 0x0600ADB4 RID: 44468 RVA: 0x00271DC0 File Offset: 0x0026FFC0
	public void RedirectSelectionOnStackMerge(int mergedIncId, int representativeIncId)
	{
		PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(representativeIncId);
		if (phantomItemData == null)
		{
			return;
		}
		if (this.SelectedDataInternal != null && this.SelectedDataInternal.GetUniqueId() == mergedIncId)
		{
			this.SelectedDataInternal = phantomItemData;
		}
		if (this.FocusedIncId == mergedIncId)
		{
			this.FocusedIncId = representativeIncId;
		}
		int stackCount = phantomItemData.GetStackCount();
		foreach (KeyValuePair<EVisionRefineCostType, List<ISelectedData>> keyValuePair in this.MultiSelectedData)
		{
			List<ISelectedData> value = keyValuePair.Value;
			for (int i = value.Count - 1; i >= 0; i--)
			{
				ISelectedData selectedData = value[i];
				if (selectedData.IncId == mergedIncId)
				{
					ISelectedData selectedData2 = null;
					foreach (ISelectedData selectedData3 in value)
					{
						if (selectedData3.IncId == representativeIncId)
						{
							selectedData2 = selectedData3;
							break;
						}
					}
					if (selectedData2 != null)
					{
						int num = selectedData2.SelectedCount + selectedData.SelectedCount;
						selectedData2.SelectedCount = ((num > stackCount) ? stackCount : num);
						selectedData2.Count = stackCount;
						value.RemoveAt(i);
					}
					else
					{
						selectedData.IncId = representativeIncId;
						selectedData.Count = stackCount;
					}
				}
			}
		}
	}

	// Token: 0x0600ADB5 RID: 44469 RVA: 0x00271F2C File Offset: 0x0027012C
	public PhantomItemData GetSelection()
	{
		return this.SelectedData;
	}

	// Token: 0x0600ADB6 RID: 44470 RVA: 0x00271F34 File Offset: 0x00270134
	public void SetSelection(PhantomItemData data)
	{
		this.SelectedDataInternal = data;
	}

	// Token: 0x0600ADB7 RID: 44471 RVA: 0x00271F40 File Offset: 0x00270140
	[NullableContext(1)]
	private bool CostFilter(PhantomItemData value)
	{
		int rarity = value.GetConfig().As<PhantomItem>().Value.Rarity;
		switch (PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity).Value.Cost)
		{
		case 1:
			return this.CurrentCostType.GetValueOrDefault() == EVisionRefineCostType.Cost1;
		case 3:
			return this.CurrentCostType.GetValueOrDefault() == EVisionRefineCostType.Cost3;
		case 4:
		{
			EVisionRefineCostType? currentCostType = this.CurrentCostType;
			EVisionRefineCostType evisionRefineCostType = EVisionRefineCostType.Cost4;
			return currentCostType.GetValueOrDefault() == evisionRefineCostType & currentCostType != null;
		}
		}
		return false;
	}

	// Token: 0x0600ADB8 RID: 44472 RVA: 0x00271FE8 File Offset: 0x002701E8
	[NullableContext(1)]
	public void SetSelectionDummy(PhantomItemData data)
	{
		int rarity = data.GetConfig().As<PhantomItem>().Value.Rarity;
		switch (PhantomBattleConfig.Instance.GetPhantomRareConfig(rarity).Value.Cost)
		{
		case 1:
			this.CurrentCostTypeInternal = EVisionRefineCostType.Cost1;
			break;
		case 3:
			this.CurrentCostTypeInternal = EVisionRefineCostType.Cost3;
			break;
		case 4:
			this.CurrentCostTypeInternal = EVisionRefineCostType.Cost4;
			break;
		}
		List<ISelectedData> list;
		this.MultiSelectedData.TryGetValue(this.CurrentCostTypeInternal, out list);
		if (list == null || list.Count != 0)
		{
			return;
		}
		list.Add(this.BuildSelectedEntry(data, 1));
	}

	// Token: 0x0600ADB9 RID: 44473 RVA: 0x00272094 File Offset: 0x00270294
	[NullableContext(1)]
	public void RefreshList(List<PhantomItemData> data)
	{
		this.MetaAllDataCache = data;
		List<PhantomItemData> dataList = data;
		if (this.CurrentRefineType == EVisionRefineRefineType.Main)
		{
			List<PhantomItemData> list = new List<PhantomItemData>();
			foreach (PhantomItemData phantomItemData in data)
			{
				if (this.CostFilter(phantomItemData))
				{
					list.Add(phantomItemData);
				}
			}
			dataList = list;
		}
		this.SortEntrance.SetSortToggleState(false);
		this.FilterEntrance.UpdateData(this.FilterSortGroupId, dataList, Array.Empty<object>());
		int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(this.FilterSortGroupId);
		this.SortEntrance.SetFilterUniqueId(uniqueIdByGroupId);
		this.SortEntrance.UpdateData(this.FilterSortGroupId, dataList, Array.Empty<object>());
		int uniqueIdByGroupId2 = this.SortEntrance.GetUniqueIdByGroupId(this.FilterSortGroupId);
		this.FilterEntrance.SetSortUniqueId(uniqueIdByGroupId2);
	}

	// Token: 0x0600ADBA RID: 44474 RVA: 0x00272180 File Offset: 0x00270380
	public void ShowTipsComponent(PhantomItemData itemData)
	{
		if (itemData == null || this.CurrentRefineType == EVisionRefineRefineType.Sub)
		{
			this.CurrentTipsIncId = 0;
			base.GetItem(2).SetUIActive(false);
			UUIButtonComponent button = base.GetButton(1);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(false);
			return;
		}
		else
		{
			ItemTipsData tipsDataById = ItemTipsComponentUtilTool.GetTipsDataById(itemData.GetConfigId(), new int?(itemData.GetUniqueId()), null);
			if (tipsDataById != null)
			{
				TipsVisionData tipsVisionData = tipsDataById as TipsVisionData;
				if (tipsVisionData != null)
				{
					TipsVisionData tipsVisionData2 = tipsVisionData;
					ISelectedData selectedEntry = this.GetSelectedEntry(itemData.GetUniqueId());
					tipsVisionData2.SelectedCount = ((selectedEntry != null) ? selectedEntry.SelectedCount : 0);
				}
				this.TipsComponent.Refresh(tipsDataById);
			}
			this.CurrentTipsIncId = itemData.GetUniqueId();
			base.GetItem(2).SetUIActive(true);
			UUIButtonComponent button2 = base.GetButton(1);
			if (button2 == null)
			{
				return;
			}
			button2.RootUIComp.Get().SetUIActive(true);
			return;
		}
	}

	// Token: 0x0600ADBB RID: 44475 RVA: 0x00272254 File Offset: 0x00270454
	private void RefreshTipsByIncId(int incId)
	{
		if (this.CurrentTipsIncId != incId)
		{
			return;
		}
		this.ShowTipsComponent(InventoryModel.Instance.GetPhantomItemData(incId));
	}

	// Token: 0x0600ADBC RID: 44476 RVA: 0x00272271 File Offset: 0x00270471
	public void RefreshCurrency(int[] itemIdList)
	{
		if (itemIdList == null)
		{
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetUiActive(false);
			return;
		}
		else
		{
			PopupCaptionItem captionItem2 = this.CaptionItem;
			if (captionItem2 != null)
			{
				captionItem2.SetUiActive(true);
			}
			PopupCaptionItem captionItem3 = this.CaptionItem;
			if (captionItem3 == null)
			{
				return;
			}
			captionItem3.SetCurrencyItemList(itemIdList).Forget();
			return;
		}
	}

	// Token: 0x0600ADBD RID: 44477 RVA: 0x002722B0 File Offset: 0x002704B0
	protected void OnClickMask()
	{
		base.GetItem(2).SetUIActive(false);
		UUIButtonComponent button = base.GetButton(1);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0600ADBE RID: 44478 RVA: 0x002722E9 File Offset: 0x002704E9
	protected void OnClickClose()
	{
		if (this.OnClickCloseCallBack != null)
		{
			this.OnClickCloseCallBack();
			return;
		}
		this.SetActive(false);
	}

	// Token: 0x0600ADBF RID: 44479 RVA: 0x00272308 File Offset: 0x00270508
	[NullableContext(1)]
	private void OnItemToggleStateChanged(MediumItemGridExtendCallback callbackData)
	{
		PhantomItemData itemData = callbackData.Data as PhantomItemData;
		this.RefreshSelectionByItemData(itemData);
	}

	// Token: 0x0600ADC0 RID: 44480 RVA: 0x00272328 File Offset: 0x00270528
	[NullableContext(1)]
	public void RefreshSelectionByItemData(PhantomItemData itemData)
	{
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(itemData.GetUniqueId());
		if (phantomBattleData == null || !phantomBattleData.GetVisionIfCanRefine(this.CurrentRefineType))
		{
			return;
		}
		this.MoveFocusTo(itemData);
		if (this.CurrentRefineType == EVisionRefineRefineType.Main)
		{
			if (this.CurrentSelectedList == null)
			{
				return;
			}
			ISelectedData selectedEntry = this.GetSelectedEntry(itemData.GetUniqueId());
			if (selectedEntry != null)
			{
				this.CurrentSelectedList.Remove(selectedEntry);
				this.RefreshGridByData(itemData);
				this.ShowTipsComponent(itemData);
				this.NotifyMultiSelectionChange();
				return;
			}
			this.RefreshChangeMultiSelect(itemData);
			this.ShowTipsComponent(itemData);
			this.NotifyMultiSelectionChange();
			return;
		}
		else
		{
			if (this.SelectedData == itemData)
			{
				this.ClearSelection();
				return;
			}
			this.RefreshChangeSelect(itemData);
			this.ShowTipsComponent(itemData);
			if (this.OnChangeCallBack != null)
			{
				this.OnChangeCallBack(this.SelectedData);
			}
			return;
		}
	}

	// Token: 0x0600ADC1 RID: 44481 RVA: 0x002723F0 File Offset: 0x002705F0
	public void OnItemFuncValueChange(int uniqueId)
	{
		if (InventoryModel.Instance.GetAttributeItemData(uniqueId) == null)
		{
			return;
		}
		for (int i = 0; i < this.AllData.Count; i++)
		{
			if (this.AllData[i].GetUniqueId() == uniqueId)
			{
				this.ItemScroll.RefreshGridProxy(i);
				return;
			}
		}
	}

	// Token: 0x0600ADC2 RID: 44482 RVA: 0x00272444 File Offset: 0x00270644
	[NullableContext(1)]
	private bool OnItemCanExecuteChange(object data, bool isForceSelected, EToggleState state)
	{
		PhantomItemData phantomItemData = data as PhantomItemData;
		int uniqueId = phantomItemData.GetUniqueId();
		PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(uniqueId);
		if (phantomBattleData == null)
		{
			return false;
		}
		if (!phantomBattleData.GetVisionIfCanRefine(this.CurrentRefineType))
		{
			EVisionRefineRefineType currentRefineType = this.CurrentRefineType;
			if (currentRefineType != EVisionRefineRefineType.Main)
			{
				if (currentRefineType == EVisionRefineRefineType.Sub)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Text_VisionRefineSub_InvalidTips_Text", Array.Empty<object>());
				}
			}
			else
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("VisionRefineChooseCheck", Array.Empty<object>());
			}
			this.ShowTipsComponent(phantomItemData);
			return false;
		}
		if (this.CurrentRefineType == EVisionRefineRefineType.Main && this.CurrentSelectedList != null)
		{
			if (phantomItemData.IsStack())
			{
				return false;
			}
			if (this.GetSelectedEntry(uniqueId) != null)
			{
				return false;
			}
			if (this.GetSelectedUnitCount() >= 10)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Text_VisionRefineChooseListFull_Text", Array.Empty<object>());
				this.ShowTipsComponent(phantomItemData);
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600ADC3 RID: 44483 RVA: 0x00272510 File Offset: 0x00270710
	[NullableContext(1)]
	private void OnItemReduceButtonClicked(MediumItemGridButtonCallback args)
	{
		PhantomItemData phantomItemData = args.Data as PhantomItemData;
		if (phantomItemData == null)
		{
			return;
		}
		if (phantomItemData.IsStack())
		{
			this.MoveFocusTo(phantomItemData);
			this.SetStackSelectedCount(phantomItemData.GetUniqueId(), 0);
			this.ShowTipsComponent(null);
			return;
		}
		this.RefreshSelectionByItemData(phantomItemData);
		this.ShowTipsComponent(null);
	}

	// Token: 0x0600ADC4 RID: 44484 RVA: 0x00272560 File Offset: 0x00270760
	[NullableContext(1)]
	private void OnFilterSortRefresh(List<PhantomItemData> list, bool _1, EFilterSortType _2)
	{
		List<PhantomItemData> list2 = new List<PhantomItemData>();
		foreach (PhantomItemData phantomItemData in list)
		{
			if (phantomItemData != null)
			{
				PhantomItemData item = phantomItemData;
				list2.Add(item);
			}
		}
		this.AllData = list2;
		this.ItemScroll.RefreshByData(this.AllData, false, null, false);
		base.GetItem(6).SetUIActive(list.Count <= 0);
		this.FocusedIncId = 0;
		this.ShowTipsComponent(null);
	}

	// Token: 0x0600ADC5 RID: 44485 RVA: 0x002725FC File Offset: 0x002707FC
	private bool CheckItemSelect(PhantomItemData data)
	{
		if (this.CurrentRefineType == EVisionRefineRefineType.Main)
		{
			return data != null && this.CurrentSelectedList != null && this.GetSelectedEntry(data.GetUniqueId()) != null;
		}
		if (data == null || this.SelectedData == null)
		{
			return false;
		}
		int uniqueId = data.GetUniqueId();
		int uniqueId2 = this.SelectedData.GetUniqueId();
		return uniqueId == uniqueId2;
	}

	// Token: 0x0600ADC6 RID: 44486 RVA: 0x00272650 File Offset: 0x00270850
	private bool CheckItemFocus(PhantomItemData data)
	{
		if (data == null)
		{
			return false;
		}
		if (this.CurrentRefineType == EVisionRefineRefineType.Main)
		{
			return this.FocusedIncId > 0 && data.GetUniqueId() == this.FocusedIncId;
		}
		return this.CheckItemSelect(data);
	}

	// Token: 0x0600ADC7 RID: 44487 RVA: 0x00272680 File Offset: 0x00270880
	private void MoveFocusTo(PhantomItemData data)
	{
		if (this.CurrentRefineType != EVisionRefineRefineType.Main)
		{
			return;
		}
		int num = (data != null) ? data.GetUniqueId() : 0;
		if (this.FocusedIncId == num)
		{
			return;
		}
		int focusedIncId = this.FocusedIncId;
		this.FocusedIncId = num;
		if (focusedIncId > 0)
		{
			this.RefreshGridByData(InventoryModel.Instance.GetPhantomItemData(focusedIncId));
		}
		this.RefreshGridByData(data);
	}

	// Token: 0x0600ADC8 RID: 44488 RVA: 0x002726D8 File Offset: 0x002708D8
	private bool CheckItemWarning(PhantomItemData data)
	{
		int? num = (data != null) ? new int?(data.GetUniqueId()) : null;
		if (num == null)
		{
			return false;
		}
		if (this.OnGetMainPropItemIdCallback == null)
		{
			return false;
		}
		PhantomDataBase phantomDataBase = PhantomBattleModel.Instance.GetPhantomDataBase(num.Value);
		if (phantomDataBase == null)
		{
			return false;
		}
		int? num2 = this.OnGetMainPropItemIdCallback();
		return num2 != null && num2.Value == phantomDataBase.GetPhantomFirstMainProp().PhantomPropId;
	}

	// Token: 0x0600ADC9 RID: 44489 RVA: 0x00272758 File Offset: 0x00270958
	private void RefreshChangeSelect(PhantomItemData newData)
	{
		PhantomItemData selectedData = this.SelectedData;
		this.SelectedDataInternal = null;
		this.RefreshGridByData(selectedData);
		this.SelectedDataInternal = newData;
		this.RefreshGridByData(newData);
	}

	// Token: 0x0600ADCA RID: 44490 RVA: 0x00272788 File Offset: 0x00270988
	[NullableContext(1)]
	private void RefreshChangeMultiSelect(PhantomItemData newData)
	{
		if (this.CurrentSelectedList == null || this.GetSelectedUnitCount() >= 10)
		{
			return;
		}
		this.CurrentSelectedList.Add(this.BuildSelectedEntry(newData, 1));
		this.RefreshGridByData(newData);
	}

	// Token: 0x0600ADCB RID: 44491 RVA: 0x002727B8 File Offset: 0x002709B8
	[NullableContext(1)]
	private bool TryOpenStackCountPopup(PhantomItemData itemData)
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomStackCountPopupView))
		{
			return true;
		}
		int incId = itemData.GetUniqueId();
		ISelectedData selectedEntry = this.GetSelectedEntry(incId);
		int num = (selectedEntry != null) ? selectedEntry.SelectedCount : 0;
		int num2 = 10 - (this.GetSelectedUnitCount() - num);
		int stackCount = itemData.GetStackCount();
		int num3 = (stackCount < num2) ? stackCount : num2;
		if (num3 <= 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Text_VisionRefineChooseListFull_Text", Array.Empty<object>());
			return true;
		}
		this.ShowTipsComponent(itemData);
		UiManager.Instance.OpenView(EUiViewName.PhantomStackCountPopupView, new PhantomStackCountPopupData
		{
			IncId = incId,
			MaxCount = num3,
			MinCount = 0,
			InitCount = ((num > 0) ? num : 1),
			OnConfirm = delegate(int count)
			{
				this.SetStackSelectedCount(incId, count);
			}
		}, null);
		return true;
	}

	// Token: 0x0600ADCC RID: 44492 RVA: 0x0027289C File Offset: 0x00270A9C
	private void SetStackSelectedCount(int incId, int count)
	{
		if (this.CurrentSelectedList == null)
		{
			return;
		}
		PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(incId);
		ISelectedData selectedEntry = this.GetSelectedEntry(incId);
		if (count <= 0)
		{
			if (selectedEntry != null)
			{
				this.CurrentSelectedList.Remove(selectedEntry);
			}
		}
		else if (selectedEntry == null)
		{
			if (phantomItemData == null)
			{
				return;
			}
			this.CurrentSelectedList.Add(this.BuildSelectedEntry(phantomItemData, count));
		}
		else
		{
			selectedEntry.SelectedCount = count;
		}
		if (phantomItemData != null)
		{
			this.RefreshGridByData(phantomItemData);
		}
		this.NotifyMultiSelectionChange();
		this.RefreshTipsByIncId(incId);
	}

	// Token: 0x0600ADCD RID: 44493 RVA: 0x00272918 File Offset: 0x00270B18
	public void ReduceSelectionByIncId(int incId)
	{
		if (this.CurrentSelectedList == null)
		{
			return;
		}
		ISelectedData selectedEntry = this.GetSelectedEntry(incId);
		if (selectedEntry == null)
		{
			return;
		}
		if (selectedEntry.SelectedCount > 1)
		{
			selectedEntry.SelectedCount--;
		}
		else
		{
			this.CurrentSelectedList.Remove(selectedEntry);
		}
		PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(incId);
		if (phantomItemData != null)
		{
			this.RefreshGridByData(phantomItemData);
		}
		this.NotifyMultiSelectionChange();
		this.RefreshTipsByIncId(incId);
	}

	// Token: 0x0600ADCE RID: 44494 RVA: 0x00272983 File Offset: 0x00270B83
	[NullableContext(1)]
	private ISelectedData BuildSelectedEntry(PhantomItemData itemData, int selectedCount)
	{
		return new SelectedData
		{
			ItemId = itemData.GetConfigId(),
			IncId = itemData.GetUniqueId(),
			Count = itemData.GetStackCount(),
			SelectedCount = selectedCount
		};
	}

	// Token: 0x0600ADCF RID: 44495 RVA: 0x002729B8 File Offset: 0x00270BB8
	public ISelectedData GetSelectedEntry(int incId)
	{
		if (this.CurrentSelectedList == null)
		{
			return null;
		}
		foreach (ISelectedData selectedData in this.CurrentSelectedList)
		{
			if (selectedData.IncId == incId)
			{
				return selectedData;
			}
		}
		return null;
	}

	// Token: 0x0600ADD0 RID: 44496 RVA: 0x00272A20 File Offset: 0x00270C20
	public int GetSelectedUnitCount()
	{
		return PhantomStackUtil.GetSelectedUnitCount(this.CurrentSelectedList);
	}

	// Token: 0x0600ADD1 RID: 44497 RVA: 0x00272A2D File Offset: 0x00270C2D
	private int GetSelectedUnitCountByData(PhantomItemData data)
	{
		if (data == null || this.CurrentRefineType != EVisionRefineRefineType.Main)
		{
			return 0;
		}
		ISelectedData selectedEntry = this.GetSelectedEntry(data.GetUniqueId());
		if (selectedEntry == null)
		{
			return 0;
		}
		return selectedEntry.SelectedCount;
	}

	// Token: 0x0600ADD2 RID: 44498 RVA: 0x00272A54 File Offset: 0x00270C54
	private void NotifyMultiSelectionChange()
	{
		if (this.OnChangeMultiCallback == null || this.CurrentCostType == null)
		{
			return;
		}
		List<ISelectedData> obj;
		if (this.MultiSelectedData.TryGetValue(this.CurrentCostType.Value, out obj))
		{
			this.OnChangeMultiCallback(obj);
		}
	}

	// Token: 0x0600ADD3 RID: 44499 RVA: 0x00272AA4 File Offset: 0x00270CA4
	private void OnEventClickItem(int configId, int incId)
	{
		PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(incId);
		this.ShowTipsComponent(phantomItemData);
	}

	// Token: 0x0600ADD4 RID: 44500 RVA: 0x00272AC4 File Offset: 0x00270CC4
	private void RefreshGridByData(PhantomItemData itemData)
	{
		if (itemData == null)
		{
			return;
		}
		int gridIndex = -1;
		for (int i = 0; i < this.AllData.Count; i++)
		{
			if (this.AllData[i].GetUniqueId() == itemData.GetUniqueId())
			{
				gridIndex = i;
				break;
			}
		}
		if (!this.ItemScroll.IsGridDisplaying(gridIndex))
		{
			return;
		}
		VisionRefineMediumItemGrid visionRefineMediumItemGrid = this.ItemScroll.UnsafeGetGridProxy(gridIndex, false);
		if (visionRefineMediumItemGrid == null)
		{
			return;
		}
		visionRefineMediumItemGrid.RefreshByView(itemData);
	}

	// Token: 0x0600ADD5 RID: 44501 RVA: 0x00272B34 File Offset: 0x00270D34
	[NullableContext(1)]
	private List<VisionRefineTabCostItemData> BuildCostTabData()
	{
		List<VisionRefineTabCostItemData> list = new List<VisionRefineTabCostItemData>();
		if (CalabashDefine.visionRefineCostMap == null)
		{
			return list;
		}
		foreach (KeyValuePair<EVisionRefineCostType, string> keyValuePair in CalabashDefine.visionRefineCostMap)
		{
			EVisionRefineCostType e = keyValuePair.Key;
			string value = keyValuePair.Value;
			VisionRefineTabCostItemData visionRefineTabCostItemData = new VisionRefineTabCostItemData();
			VisionRefineTabCostItemData visionRefineTabCostItemData2 = visionRefineTabCostItemData;
			EVisionRefineCostType e2 = e;
			EVisionRefineCostType? currentCostType = this.CurrentCostType;
			visionRefineTabCostItemData2.IsChosen = (e2 == currentCostType.GetValueOrDefault() & currentCostType != null);
			visionRefineTabCostItemData.CostType = e;
			visionRefineTabCostItemData.TabTextId = value;
			visionRefineTabCostItemData.OnClick = delegate()
			{
				this.CurrentCostTypeInternal = e;
				this.OnClickRefreshCostTab(e);
				this.RefreshList(this.MetaAllDataCache);
				if (this.OnCostTabChangeCallback != null)
				{
					this.OnCostTabChangeCallback();
				}
			};
			list.Add(visionRefineTabCostItemData);
		}
		return list;
	}

	// Token: 0x0600ADD6 RID: 44502 RVA: 0x00272C18 File Offset: 0x00270E18
	private void OnClickRefreshCostTab(EVisionRefineCostType current)
	{
		if (this.CostTabLayout == null)
		{
			return;
		}
		foreach (VisionRefineTabCostItem visionRefineTabCostItem in this.CostTabLayout.GetLayoutItemList())
		{
			if (visionRefineTabCostItem.CheckChosen(current))
			{
				visionRefineTabCostItem.OnSelected(false);
			}
			else
			{
				visionRefineTabCostItem.OnDeselected(false);
			}
		}
	}

	// Token: 0x0600ADD7 RID: 44503 RVA: 0x00272C8C File Offset: 0x00270E8C
	protected override void OnAfterShow()
	{
		this.OnAddEventListener();
	}

	// Token: 0x0600ADD8 RID: 44504 RVA: 0x00272C94 File Offset: 0x00270E94
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x0600ADD9 RID: 44505 RVA: 0x00272C9C File Offset: 0x00270E9C
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnEventClickItem));
	}

	// Token: 0x0600ADDA RID: 44506 RVA: 0x00272CBA File Offset: 0x00270EBA
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnEventClickItem));
	}

	// Token: 0x0600ADDB RID: 44507 RVA: 0x00272CD8 File Offset: 0x00270ED8
	[NullableContext(1)]
	public UUIItem GetFilterToggleItem()
	{
		return this.FilterEntrance.GetFilterToggleItem();
	}

	// Token: 0x04004EEE RID: 20206
	[Nullable(1)]
	private List<PhantomItemData> AllData = new List<PhantomItemData>();

	// Token: 0x04004EEF RID: 20207
	[Nullable(1)]
	private List<PhantomItemData> MetaAllDataCache = new List<PhantomItemData>();

	// Token: 0x04004EF0 RID: 20208
	private PhantomItemData SelectedDataInternal;

	// Token: 0x04004EF1 RID: 20209
	private int FocusedIncId;

	// Token: 0x04004EF2 RID: 20210
	public UiBehaviorLevelSequence UiViewSequence;

	// Token: 0x04004EF3 RID: 20211
	private ItemTipsComponentContentComponent TipsComponent;

	// Token: 0x04004EF4 RID: 20212
	private int CurrentTipsIncId;

	// Token: 0x04004EF5 RID: 20213
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<VisionRefineMediumItemGrid, PhantomItemData> ItemScroll;

	// Token: 0x04004EF6 RID: 20214
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterEntrance<PhantomItemData> FilterEntrance;

	// Token: 0x04004EF7 RID: 20215
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SortEntrance<PhantomItemData> SortEntrance;

	// Token: 0x04004EF8 RID: 20216
	[Nullable(1)]
	private readonly Dictionary<EVisionRefineCostType, List<ISelectedData>> MultiSelectedData = new Dictionary<EVisionRefineCostType, List<ISelectedData>>
	{
		{
			EVisionRefineCostType.Cost1,
			new List<ISelectedData>()
		},
		{
			EVisionRefineCostType.Cost3,
			new List<ISelectedData>()
		},
		{
			EVisionRefineCostType.Cost4,
			new List<ISelectedData>()
		}
	};

	// Token: 0x04004EF9 RID: 20217
	private EVisionRefineRefineType CurrentRefineTypeInternal;

	// Token: 0x04004EFA RID: 20218
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRefineTabCostItem, VisionRefineTabCostItemData> CostTabLayout;

	// Token: 0x04004EFB RID: 20219
	private EVisionRefineCostType CurrentCostTypeInternal;

	// Token: 0x04004EFC RID: 20220
	private PopupCaptionItem CaptionItem;

	// Token: 0x04004EFD RID: 20221
	public Action OnClickCloseCallBack;

	// Token: 0x04004EFE RID: 20222
	public Action<PhantomItemData> OnChangeCallBack;

	// Token: 0x04004EFF RID: 20223
	[Nullable(new byte[]
	{
		2,
		2,
		1
	})]
	public Action<List<ISelectedData>> OnChangeMultiCallback;

	// Token: 0x04004F00 RID: 20224
	public Action OnCostTabChangeCallback;

	// Token: 0x04004F01 RID: 20225
	public Func<int?> OnGetMainPropItemIdCallback;

	// Token: 0x02007D5D RID: 32093
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040290D2 RID: 168146
		RootTips,
		// Token: 0x040290D3 RID: 168147
		BtnMask,
		// Token: 0x040290D4 RID: 168148
		ItemTips,
		// Token: 0x040290D5 RID: 168149
		BtnClose,
		// Token: 0x040290D6 RID: 168150
		ItemScrollView,
		// Token: 0x040290D7 RID: 168151
		ItemBase,
		// Token: 0x040290D8 RID: 168152
		EmptyItem,
		// Token: 0x040290D9 RID: 168153
		FilterItem,
		// Token: 0x040290DA RID: 168154
		SortItem,
		// Token: 0x040290DB RID: 168155
		CostTabRootItem,
		// Token: 0x040290DC RID: 168156
		CostTabLayout,
		// Token: 0x040290DD RID: 168157
		CostTabLayoutItem,
		// Token: 0x040290DE RID: 168158
		CurrencyCaptionItem
	}
}
