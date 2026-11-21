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

// Token: 0x02000C22 RID: 3106
[NullableContext(2)]
[Nullable(0)]
public class VisionRefineChoosePanel : UiPanelBase
{
	// Token: 0x17000E8E RID: 3726
	// (get) Token: 0x0600818B RID: 33163 RVA: 0x0027BC2C File Offset: 0x00279E2C
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

	// Token: 0x17000E8F RID: 3727
	// (get) Token: 0x0600818C RID: 33164 RVA: 0x0027BC68 File Offset: 0x00279E68
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

	// Token: 0x17000E90 RID: 3728
	// (get) Token: 0x0600818D RID: 33165 RVA: 0x0027BCC4 File Offset: 0x00279EC4
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

	// Token: 0x17000E91 RID: 3729
	// (get) Token: 0x0600818E RID: 33166 RVA: 0x0027BD4B File Offset: 0x00279F4B
	// (set) Token: 0x0600818F RID: 33167 RVA: 0x0027BD53 File Offset: 0x00279F53
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

	// Token: 0x17000E92 RID: 3730
	// (get) Token: 0x06008190 RID: 33168 RVA: 0x0027BD78 File Offset: 0x00279F78
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

	// Token: 0x06008191 RID: 33169 RVA: 0x0027BDC4 File Offset: 0x00279FC4
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

	// Token: 0x06008192 RID: 33170 RVA: 0x0027BF23 File Offset: 0x0027A123
	protected override void OnBeforeCreateImplement()
	{
		this.UiViewSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiViewSequence);
	}

	// Token: 0x06008193 RID: 33171 RVA: 0x0027BF40 File Offset: 0x0027A140
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRefineChoosePanel.<OnBeforeStartAsync>d__34 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRefineChoosePanel.<OnBeforeStartAsync>d__34>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008194 RID: 33172 RVA: 0x0027BF83 File Offset: 0x0027A183
	protected override void OnStart()
	{
		this.FilterEntrance = new FilterEntrance<PhantomItemData>(base.GetItem(7), new TUpdateDataListFunction<PhantomItemData>(this.OnFilterSortRefresh));
		this.SortEntrance = new SortEntrance<PhantomItemData>(base.GetItem(8), new TUpdateDataListFunction<PhantomItemData>(this.OnFilterSortRefresh));
	}

	// Token: 0x06008195 RID: 33173 RVA: 0x0027BFC4 File Offset: 0x0027A1C4
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

	// Token: 0x06008196 RID: 33174 RVA: 0x0027C080 File Offset: 0x0027A280
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

	// Token: 0x06008197 RID: 33175 RVA: 0x0027C0E1 File Offset: 0x0027A2E1
	[NullableContext(1)]
	private VisionRefineTabCostItem InitCostTabItem()
	{
		return new VisionRefineTabCostItem();
	}

	// Token: 0x06008198 RID: 33176 RVA: 0x0027C0E8 File Offset: 0x0027A2E8
	public void ClearSelection()
	{
		this.RefreshChangeSelect(null);
		if (this.OnChangeCallBack != null)
		{
			this.OnChangeCallBack(this.SelectedData);
		}
	}

	// Token: 0x06008199 RID: 33177 RVA: 0x0027C10C File Offset: 0x0027A30C
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

	// Token: 0x0600819A RID: 33178 RVA: 0x0027C188 File Offset: 0x0027A388
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

	// Token: 0x0600819B RID: 33179 RVA: 0x0027C284 File Offset: 0x0027A484
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

	// Token: 0x0600819C RID: 33180 RVA: 0x0027C3F0 File Offset: 0x0027A5F0
	public PhantomItemData GetSelection()
	{
		return this.SelectedData;
	}

	// Token: 0x0600819D RID: 33181 RVA: 0x0027C3F8 File Offset: 0x0027A5F8
	public void SetSelection(PhantomItemData data)
	{
		this.SelectedDataInternal = data;
	}

	// Token: 0x0600819E RID: 33182 RVA: 0x0027C404 File Offset: 0x0027A604
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

	// Token: 0x0600819F RID: 33183 RVA: 0x0027C4AC File Offset: 0x0027A6AC
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

	// Token: 0x060081A0 RID: 33184 RVA: 0x0027C558 File Offset: 0x0027A758
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

	// Token: 0x060081A1 RID: 33185 RVA: 0x0027C644 File Offset: 0x0027A844
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

	// Token: 0x060081A2 RID: 33186 RVA: 0x0027C718 File Offset: 0x0027A918
	private void RefreshTipsByIncId(int incId)
	{
		if (this.CurrentTipsIncId != incId)
		{
			return;
		}
		this.ShowTipsComponent(InventoryModel.Instance.GetPhantomItemData(incId));
	}

	// Token: 0x060081A3 RID: 33187 RVA: 0x0027C735 File Offset: 0x0027A935
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

	// Token: 0x060081A4 RID: 33188 RVA: 0x0027C774 File Offset: 0x0027A974
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

	// Token: 0x060081A5 RID: 33189 RVA: 0x0027C7AD File Offset: 0x0027A9AD
	protected void OnClickClose()
	{
		if (this.OnClickCloseCallBack != null)
		{
			this.OnClickCloseCallBack();
			return;
		}
		this.SetActive(false);
	}

	// Token: 0x060081A6 RID: 33190 RVA: 0x0027C7CC File Offset: 0x0027A9CC
	[NullableContext(1)]
	private void OnItemToggleStateChanged(MediumItemGridExtendCallback callbackData)
	{
		PhantomItemData itemData = callbackData.Data as PhantomItemData;
		this.RefreshSelectionByItemData(itemData);
	}

	// Token: 0x060081A7 RID: 33191 RVA: 0x0027C7EC File Offset: 0x0027A9EC
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

	// Token: 0x060081A8 RID: 33192 RVA: 0x0027C8B4 File Offset: 0x0027AAB4
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

	// Token: 0x060081A9 RID: 33193 RVA: 0x0027C908 File Offset: 0x0027AB08
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

	// Token: 0x060081AA RID: 33194 RVA: 0x0027C9D4 File Offset: 0x0027ABD4
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

	// Token: 0x060081AB RID: 33195 RVA: 0x0027CA24 File Offset: 0x0027AC24
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

	// Token: 0x060081AC RID: 33196 RVA: 0x0027CAC0 File Offset: 0x0027ACC0
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

	// Token: 0x060081AD RID: 33197 RVA: 0x0027CB14 File Offset: 0x0027AD14
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

	// Token: 0x060081AE RID: 33198 RVA: 0x0027CB44 File Offset: 0x0027AD44
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

	// Token: 0x060081AF RID: 33199 RVA: 0x0027CB9C File Offset: 0x0027AD9C
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

	// Token: 0x060081B0 RID: 33200 RVA: 0x0027CC1C File Offset: 0x0027AE1C
	private void RefreshChangeSelect(PhantomItemData newData)
	{
		PhantomItemData selectedData = this.SelectedData;
		this.SelectedDataInternal = null;
		this.RefreshGridByData(selectedData);
		this.SelectedDataInternal = newData;
		this.RefreshGridByData(newData);
	}

	// Token: 0x060081B1 RID: 33201 RVA: 0x0027CC4C File Offset: 0x0027AE4C
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

	// Token: 0x060081B2 RID: 33202 RVA: 0x0027CC7C File Offset: 0x0027AE7C
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

	// Token: 0x060081B3 RID: 33203 RVA: 0x0027CD60 File Offset: 0x0027AF60
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

	// Token: 0x060081B4 RID: 33204 RVA: 0x0027CDDC File Offset: 0x0027AFDC
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

	// Token: 0x060081B5 RID: 33205 RVA: 0x0027CE47 File Offset: 0x0027B047
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

	// Token: 0x060081B6 RID: 33206 RVA: 0x0027CE7C File Offset: 0x0027B07C
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

	// Token: 0x060081B7 RID: 33207 RVA: 0x0027CEE4 File Offset: 0x0027B0E4
	public int GetSelectedUnitCount()
	{
		return PhantomStackUtil.GetSelectedUnitCount(this.CurrentSelectedList);
	}

	// Token: 0x060081B8 RID: 33208 RVA: 0x0027CEF1 File Offset: 0x0027B0F1
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

	// Token: 0x060081B9 RID: 33209 RVA: 0x0027CF18 File Offset: 0x0027B118
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

	// Token: 0x060081BA RID: 33210 RVA: 0x0027CF68 File Offset: 0x0027B168
	private void OnEventClickItem(int configId, int incId)
	{
		PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(incId);
		this.ShowTipsComponent(phantomItemData);
	}

	// Token: 0x060081BB RID: 33211 RVA: 0x0027CF88 File Offset: 0x0027B188
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

	// Token: 0x060081BC RID: 33212 RVA: 0x0027CFF8 File Offset: 0x0027B1F8
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

	// Token: 0x060081BD RID: 33213 RVA: 0x0027D0DC File Offset: 0x0027B2DC
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

	// Token: 0x060081BE RID: 33214 RVA: 0x0027D150 File Offset: 0x0027B350
	protected override void OnAfterShow()
	{
		this.OnAddEventListener();
	}

	// Token: 0x060081BF RID: 33215 RVA: 0x0027D158 File Offset: 0x0027B358
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x060081C0 RID: 33216 RVA: 0x0027D160 File Offset: 0x0027B360
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnEventClickItem));
	}

	// Token: 0x060081C1 RID: 33217 RVA: 0x0027D17E File Offset: 0x0027B37E
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnEventClickItem));
	}

	// Token: 0x060081C2 RID: 33218 RVA: 0x0027D19C File Offset: 0x0027B39C
	[NullableContext(1)]
	public UUIItem GetFilterToggleItem()
	{
		return this.FilterEntrance.GetFilterToggleItem();
	}

	// Token: 0x04004F98 RID: 20376
	[Nullable(1)]
	private List<PhantomItemData> AllData = new List<PhantomItemData>();

	// Token: 0x04004F99 RID: 20377
	[Nullable(1)]
	private List<PhantomItemData> MetaAllDataCache = new List<PhantomItemData>();

	// Token: 0x04004F9A RID: 20378
	private PhantomItemData SelectedDataInternal;

	// Token: 0x04004F9B RID: 20379
	private int FocusedIncId;

	// Token: 0x04004F9C RID: 20380
	public UiBehaviorLevelSequence UiViewSequence;

	// Token: 0x04004F9D RID: 20381
	private ItemTipsComponentContentComponent TipsComponent;

	// Token: 0x04004F9E RID: 20382
	private int CurrentTipsIncId;

	// Token: 0x04004F9F RID: 20383
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<VisionRefineMediumItemGrid, PhantomItemData> ItemScroll;

	// Token: 0x04004FA0 RID: 20384
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterEntrance<PhantomItemData> FilterEntrance;

	// Token: 0x04004FA1 RID: 20385
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SortEntrance<PhantomItemData> SortEntrance;

	// Token: 0x04004FA2 RID: 20386
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

	// Token: 0x04004FA3 RID: 20387
	private EVisionRefineRefineType CurrentRefineTypeInternal;

	// Token: 0x04004FA4 RID: 20388
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<VisionRefineTabCostItem, VisionRefineTabCostItemData> CostTabLayout;

	// Token: 0x04004FA5 RID: 20389
	private EVisionRefineCostType CurrentCostTypeInternal;

	// Token: 0x04004FA6 RID: 20390
	private PopupCaptionItem CaptionItem;

	// Token: 0x04004FA7 RID: 20391
	public Action OnClickCloseCallBack;

	// Token: 0x04004FA8 RID: 20392
	public Action<PhantomItemData> OnChangeCallBack;

	// Token: 0x04004FA9 RID: 20393
	[Nullable(new byte[]
	{
		2,
		2,
		1
	})]
	public Action<List<ISelectedData>> OnChangeMultiCallback;

	// Token: 0x04004FAA RID: 20394
	public Action OnCostTabChangeCallback;

	// Token: 0x04004FAB RID: 20395
	public Func<int?> OnGetMainPropItemIdCallback;

	// Token: 0x02006EE3 RID: 28387
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040243FD RID: 148477
		RootTips,
		// Token: 0x040243FE RID: 148478
		BtnMask,
		// Token: 0x040243FF RID: 148479
		ItemTips,
		// Token: 0x04024400 RID: 148480
		BtnClose,
		// Token: 0x04024401 RID: 148481
		ItemScrollView,
		// Token: 0x04024402 RID: 148482
		ItemBase,
		// Token: 0x04024403 RID: 148483
		EmptyItem,
		// Token: 0x04024404 RID: 148484
		FilterItem,
		// Token: 0x04024405 RID: 148485
		SortItem,
		// Token: 0x04024406 RID: 148486
		CostTabRootItem,
		// Token: 0x04024407 RID: 148487
		CostTabLayout,
		// Token: 0x04024408 RID: 148488
		CostTabLayoutItem,
		// Token: 0x04024409 RID: 148489
		CurrencyCaptionItem
	}
}
