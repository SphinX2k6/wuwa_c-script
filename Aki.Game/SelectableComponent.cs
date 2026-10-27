using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001958 RID: 6488
[NullableContext(1)]
[Nullable(0)]
public class SelectableComponent<[Nullable(0)] T> : UiPanelBase where T : ItemDataBase
{
	// Token: 0x17000FD5 RID: 4053
	// (get) Token: 0x0600BD76 RID: 48502 RVA: 0x002ADABB File Offset: 0x002ABCBB
	protected bool IsSelectFrameFollowClick
	{
		get
		{
			SelectableComponentData data = this.Data;
			return data != null && data.IsSelectFrameFollowClick;
		}
	}

	// Token: 0x0600BD77 RID: 48503 RVA: 0x002ADACE File Offset: 0x002ABCCE
	public void InitLoopScroller(UUILoopScrollViewComponent loopComponent, UUIItem templateActor, SelectableComponentData data)
	{
		this.LoopScrollView = new LoopScrollView<SelectablePropMediumItemGrid, SelectablePropData>(loopComponent, templateActor.GetOwner() as AUIBaseActor, new Func<SelectablePropMediumItemGrid>(this.InitItem), false);
		this.SetData(data);
	}

	// Token: 0x0600BD78 RID: 48504 RVA: 0x002ADAFC File Offset: 0x002ABCFC
	protected void SetData(SelectableComponentData data)
	{
		this.Data = data;
	}

	// Token: 0x0600BD79 RID: 48505 RVA: 0x002ADB05 File Offset: 0x002ABD05
	public void SetExpData(CommonIntensifyPropExpData expData)
	{
		this.SelectableExpData = SelectableExpData.PhraseData(expData);
	}

	// Token: 0x0600BD7A RID: 48506 RVA: 0x002ADB13 File Offset: 0x002ABD13
	public void SetMaxSize(int size)
	{
		this.MaxSize = size;
	}

	// Token: 0x0600BD7B RID: 48507 RVA: 0x002ADB1C File Offset: 0x002ABD1C
	public void SetOnlyGold(bool onlyGold)
	{
		this.OnlyGold = onlyGold;
	}

	// Token: 0x0600BD7C RID: 48508 RVA: 0x002ADB25 File Offset: 0x002ABD25
	public void UpdateComponent(List<T> itemDataBaseList, List<ISelectedData> selectedDataList, [Nullable(2)] CommonIntensifyPropExpData expData = null)
	{
		this.InitSelectedData(selectedDataList);
		if (expData != null)
		{
			this.ExpData = expData;
			this.SetExpData(expData);
			this.UpdateExp();
		}
	}

	// Token: 0x0600BD7D RID: 48509 RVA: 0x002ADB45 File Offset: 0x002ABD45
	public void RefreshPartByIndex(int index)
	{
		this.LoopScrollView.RefreshGridProxy(index);
	}

	// Token: 0x0600BD7E RID: 48510 RVA: 0x002ADB53 File Offset: 0x002ABD53
	public void RefreshAllByDisplay()
	{
		this.LoopScrollView.RefreshAllGridProxies();
	}

	// Token: 0x0600BD7F RID: 48511 RVA: 0x002ADB60 File Offset: 0x002ABD60
	private void InitSelectedData(List<ISelectedData> selectedDataList)
	{
		if (selectedDataList != null)
		{
			this.SelectedDataList = selectedDataList;
		}
		else
		{
			this.SelectedDataList = new List<ISelectedData>();
		}
		if (this.Data.IsSingleSelected && selectedDataList != null && selectedDataList.Count > 0)
		{
			this.SetLastAddData(selectedDataList[0]);
		}
	}

	// Token: 0x0600BD80 RID: 48512 RVA: 0x002ADB9F File Offset: 0x002ABD9F
	public List<ISelectedData> GetCurrentSelectedData()
	{
		return this.SelectedDataList;
	}

	// Token: 0x0600BD81 RID: 48513 RVA: 0x002ADBA8 File Offset: 0x002ABDA8
	public void UpdateDataList(List<T> dataList)
	{
		this.ItemDataList = dataList;
		this.LoopScrollView.ReloadProxyData(new Func<int, SelectablePropData>(this.GetPropScrollViewData), this.ItemDataList.Count, true, false);
		if (this.ItemDataList.Count > 0)
		{
			this.LoopScrollView.ScrollToGridIndex(this.LastSelectedIndex, true);
		}
	}

	// Token: 0x0600BD82 RID: 48514 RVA: 0x002ADC00 File Offset: 0x002ABE00
	public void RefreshByData(List<T> dataList, bool keepContentPosition = false, [Nullable(2)] Action callBack = null)
	{
		this.ItemDataList = dataList;
		List<SelectablePropData> list = new List<SelectablePropData>();
		foreach (T t in this.ItemDataList)
		{
			SelectablePropData selectablePropData = SelectablePropDataUtil.GetSelectablePropData(t);
			if (selectablePropData != null)
			{
				int selectedDataCount = this.GetSelectedDataCount(selectablePropData);
				selectablePropData.SelectedCount = selectedDataCount;
				selectablePropData.OnlyGold = this.OnlyGold;
				selectablePropData.IsSelectFrameFollowClick = this.IsSelectFrameFollowClick;
				list.Add(selectablePropData);
			}
		}
		this.LoopScrollView.RefreshByData(list, keepContentPosition, callBack, false);
	}

	// Token: 0x0600BD83 RID: 48515 RVA: 0x002ADCA4 File Offset: 0x002ABEA4
	public void UpdateChangeItemSelectList()
	{
		Action<List<ISelectedData>, SelectableExpData> onChangeSelectedFunction = this.Data.OnChangeSelectedFunction;
		if (onChangeSelectedFunction == null)
		{
			return;
		}
		onChangeSelectedFunction(this.SelectedDataList, this.SelectableExpData);
	}

	// Token: 0x0600BD84 RID: 48516 RVA: 0x002ADCC8 File Offset: 0x002ABEC8
	private SelectablePropData GetPropScrollViewData(int gridIndex)
	{
		SelectablePropData selectablePropData = SelectablePropDataUtil.GetSelectablePropData(this.ItemDataList[gridIndex]);
		if (selectablePropData == null)
		{
			return new SelectablePropData();
		}
		int selectedDataCount = this.GetSelectedDataCount(selectablePropData);
		selectablePropData.SelectedCount = selectedDataCount;
		selectablePropData.OnlyGold = this.OnlyGold;
		selectablePropData.IsSelectFrameFollowClick = this.IsSelectFrameFollowClick;
		return selectablePropData;
	}

	// Token: 0x0600BD85 RID: 48517 RVA: 0x002ADD1D File Offset: 0x002ABF1D
	[NullableContext(2)]
	public ISelectedData GetFirstOperationItem()
	{
		return this.FirstOperationData;
	}

	// Token: 0x0600BD86 RID: 48518 RVA: 0x002ADD25 File Offset: 0x002ABF25
	public void SetFirstOperationData(ISelectedData data)
	{
		this.FirstOperationData = data;
	}

	// Token: 0x0600BD87 RID: 48519 RVA: 0x002ADD2E File Offset: 0x002ABF2E
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x0600BD88 RID: 48520 RVA: 0x002ADD30 File Offset: 0x002ABF30
	protected virtual SelectablePropMediumItemGrid InitItem()
	{
		SelectablePropMediumItemGrid selectablePropMediumItemGrid = new SelectablePropMediumItemGrid();
		selectablePropMediumItemGrid.BindLongPress(LongPressButtonItem.ELongPressConfigId.LongPressOne, delegate(bool _1, ItemGridBase _2, [Nullable(2)] object _3)
		{
			this.AddFunction(_1, _2, _3);
		}, new Func<ItemGridBase, object, bool>(this.CanItemLongPress));
		selectablePropMediumItemGrid.BindReduceLongPress(delegate(bool _1, MediumItemGrid _2, object _3)
		{
			this.ReduceFunction(_1, _2, _3);
		});
		selectablePropMediumItemGrid.BindAfterApply(new Action<SelectablePropMediumItemGrid>(this.OnAfterApplyMediumItemGrid));
		selectablePropMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnCanExecuteChange));
		return selectablePropMediumItemGrid;
	}

	// Token: 0x0600BD89 RID: 48521 RVA: 0x002ADD97 File Offset: 0x002ABF97
	protected void OnAfterApplyMediumItemGrid(SelectablePropMediumItemGrid selectablePropMediumItemGrid)
	{
	}

	// Token: 0x0600BD8A RID: 48522 RVA: 0x002ADD9C File Offset: 0x002ABF9C
	[NullableContext(2)]
	protected bool OnCanExecuteChange(object data, bool isForceSelected, EToggleState state)
	{
		SelectablePropData selectablePropData = data as SelectablePropData;
		return selectablePropData != null && this.CanAddMaterial(selectablePropData, false);
	}

	// Token: 0x0600BD8B RID: 48523 RVA: 0x002ADDC0 File Offset: 0x002ABFC0
	protected bool CanItemLongPress(ItemGridBase itemGrid, [Nullable(2)] object data)
	{
		SelectablePropData selectablePropData = data as SelectablePropData;
		return selectablePropData != null && this.CanAddMaterial(selectablePropData, false);
	}

	// Token: 0x0600BD8C RID: 48524 RVA: 0x002ADDE4 File Offset: 0x002ABFE4
	protected bool AddFunction(bool isShortPress, ItemGridBase itemGrid, [Nullable(2)] object data)
	{
		SelectablePropData selectablePropData = data as SelectablePropData;
		if (selectablePropData == null)
		{
			return false;
		}
		EventSystem.Instance.Emit<int, int>(EEventName.OnSelectItemAdd, selectablePropData.ItemId, selectablePropData.IncId);
		this.MoveSelectFrameTo(selectablePropData);
		this.SetPrevPropItemSelectedState(selectablePropData);
		if (!this.CanAddMaterial(selectablePropData, true))
		{
			return false;
		}
		if (this.Data.IsSingleSelected)
		{
			this.DeleteLastData(selectablePropData);
			this.CancelPropItemSelected(selectablePropData);
		}
		this.SetLastAddData(selectablePropData);
		this.AddData(selectablePropData);
		this.UpdateExp();
		this.OnChangeItemSelectList();
		SelectablePropMediumItemGrid selectablePropMediumItemGrid = itemGrid as SelectablePropMediumItemGrid;
		if (selectablePropMediumItemGrid == null)
		{
			return false;
		}
		ISelectedData selectedData = this.GetSelectedData(selectablePropData);
		if (selectedData != null)
		{
			selectablePropData.SelectedCount = selectedData.SelectedCount;
		}
		selectablePropMediumItemGrid.RefreshCostCount();
		CSharpScript.Game.Module.Common.MediumItemGrid.LongPressButton reduceButton = new CSharpScript.Game.Module.Common.MediumItemGrid.LongPressButton
		{
			IsVisible = new bool?(selectablePropData.SelectedCount > 0),
			LongPressConfigId = new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne)
		};
		SelectableComponentData data2 = this.Data;
		if (data2 != null && data2.IsNumSelectable)
		{
			selectablePropMediumItemGrid.SetReduceButton(reduceButton);
		}
		this.RefreshSelectFrame(selectablePropMediumItemGrid, selectablePropData.SelectedCount > 0);
		return true;
	}

	// Token: 0x0600BD8D RID: 48525 RVA: 0x002ADEE4 File Offset: 0x002AC0E4
	protected bool ReduceFunction(bool isShortPress, MediumItemGrid mediumItemGrid, [Nullable(2)] object data)
	{
		SelectablePropData selectablePropData = data as SelectablePropData;
		if (selectablePropData == null)
		{
			return false;
		}
		this.MoveSelectFrameTo(selectablePropData);
		this.SetPrevPropItemSelectedState(selectablePropData);
		ISelectedData selectedData = this.GetSelectedData(selectablePropData);
		if (selectedData == null)
		{
			return false;
		}
		int num = selectedData.SelectedCount;
		if (num == 0)
		{
			return false;
		}
		if (--num <= 0)
		{
			this.RemoveSelectedData(selectablePropData);
		}
		else
		{
			selectedData.SelectedCount = num;
		}
		selectablePropData.SelectedCount = num;
		if (this.Data.OtherFunction != null)
		{
			this.Data.OtherFunction();
		}
		this.UpdateExp();
		this.OnChangeItemSelectList();
		SelectablePropMediumItemGrid selectablePropMediumItemGrid = mediumItemGrid as SelectablePropMediumItemGrid;
		if (selectablePropMediumItemGrid == null)
		{
			return false;
		}
		selectablePropMediumItemGrid.RefreshCostCount();
		this.RefreshSelectFrame(selectablePropMediumItemGrid, num > 0);
		CSharpScript.Game.Module.Common.MediumItemGrid.LongPressButton reduceButton = new CSharpScript.Game.Module.Common.MediumItemGrid.LongPressButton
		{
			IsVisible = new bool?(selectablePropData.SelectedCount > 0),
			LongPressConfigId = new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne)
		};
		SelectableComponentData data2 = this.Data;
		if (data2 != null && data2.IsNumSelectable)
		{
			selectablePropMediumItemGrid.SetReduceButton(reduceButton);
		}
		return true;
	}

	// Token: 0x0600BD8E RID: 48526 RVA: 0x002ADFD0 File Offset: 0x002AC1D0
	protected void MoveSelectFrameTo(SelectablePropData propData)
	{
		if (!this.IsSelectFrameFollowClick)
		{
			return;
		}
		int loopScrollViewIndex = this.GetLoopScrollViewIndex(propData.IncId, propData.ItemId);
		if (loopScrollViewIndex < 0)
		{
			return;
		}
		this.LoopScrollView.SelectGridProxy(loopScrollViewIndex, true);
	}

	// Token: 0x0600BD8F RID: 48527 RVA: 0x002AE00B File Offset: 0x002AC20B
	protected void RefreshSelectFrame(SelectablePropMediumItemGrid grid, bool isSelected)
	{
		if (this.IsSelectFrameFollowClick)
		{
			return;
		}
		grid.SetSelected(isSelected, true);
	}

	// Token: 0x0600BD90 RID: 48528 RVA: 0x002AE020 File Offset: 0x002AC220
	protected void SetPrevPropItemSelectedState(SelectablePropData propData)
	{
		if (this.IsSelectFrameFollowClick)
		{
			return;
		}
		if (this.LastSelectedPropData == null || this.IsSameLastAddItemData(propData))
		{
			return;
		}
		if (this.LastAddData == null)
		{
			return;
		}
		int loopScrollViewIndex = this.GetLoopScrollViewIndex(this.LastAddData.IncId, this.LastAddData.ItemId);
		if (loopScrollViewIndex < 0)
		{
			return;
		}
		if (!this.LoopScrollView.IsGridDisplaying(loopScrollViewIndex))
		{
			return;
		}
		SelectablePropMediumItemGrid selectablePropMediumItemGrid = this.LoopScrollView.UnsafeGetGridProxy(loopScrollViewIndex, false);
		if (selectablePropMediumItemGrid == null)
		{
			return;
		}
		selectablePropMediumItemGrid.OnDeselected(false);
	}

	// Token: 0x0600BD91 RID: 48529 RVA: 0x002AE09C File Offset: 0x002AC29C
	protected virtual bool CanAddMaterial(SelectablePropData propData, bool isShowTip = false)
	{
		if (propData.GetIsLock())
		{
			if (isShowTip)
			{
				ScrollingTipsController.Instance.ShowTipsById("WeaponLockTipsText", Array.Empty<object>());
			}
			return false;
		}
		SelectableExpData selectableExpData = this.SelectableExpData;
		if (selectableExpData != null && selectableExpData.IsInMax())
		{
			if (isShowTip)
			{
				ScrollingTipsController.Instance.ShowTipsById("WeaponAddExpTipsText", Array.Empty<object>());
			}
			return false;
		}
		ISelectedData selectedData = this.GetSelectedData(propData);
		if (selectedData != null && selectedData.SelectedCount > 0 && selectedData.SelectedCount == propData.Count)
		{
			return false;
		}
		if (selectedData == null && this.SelectedDataList.Count >= this.MaxSize && !this.Data.IsSingleSelected)
		{
			if (isShowTip)
			{
				ScrollingTipsController.Instance.ShowTipsById("WeaponFullMaterialText", Array.Empty<object>());
			}
			return false;
		}
		return this.Data.CheckIfCanAddFunction == null || this.Data.CheckIfCanAddFunction(this.SelectedDataList, propData.IncId, propData.ItemId, 1);
	}

	// Token: 0x0600BD92 RID: 48530 RVA: 0x002AE18C File Offset: 0x002AC38C
	private bool IsSameLastAddItemData(ISelectedData selectedData)
	{
		if (this.LastAddData == null)
		{
			return false;
		}
		int incId = selectedData.IncId;
		if (incId > 0)
		{
			return this.LastAddData.IncId == incId;
		}
		return this.LastAddData.ItemId == selectedData.ItemId;
	}

	// Token: 0x0600BD93 RID: 48531 RVA: 0x002AE1D0 File Offset: 0x002AC3D0
	public int GetLoopScrollViewIndex(int incId, int configId)
	{
		if (incId > 0 || configId > 0)
		{
			int i = 0;
			int count = this.ItemDataList.Count;
			while (i < count)
			{
				T t = this.ItemDataList[i];
				if (incId > 0)
				{
					if (t.GetUniqueId() == incId)
					{
						return i;
					}
				}
				else if (t.GetConfigId() == configId)
				{
					return i;
				}
				i++;
			}
		}
		return -1;
	}

	// Token: 0x0600BD94 RID: 48532 RVA: 0x002AE22F File Offset: 0x002AC42F
	protected void DeleteLastData(SelectablePropData propData)
	{
		if (!this.IsSameLastAddItemData(propData))
		{
			this.RemoveSelectedData(this.LastAddData);
		}
	}

	// Token: 0x0600BD95 RID: 48533 RVA: 0x002AE248 File Offset: 0x002AC448
	private void RemoveSelectedData(ISelectedData selectedData)
	{
		if (selectedData == null)
		{
			return;
		}
		int incId = selectedData.IncId;
		if (incId > 0)
		{
			this.RemoveSelectedDataByIncId(incId);
			return;
		}
		this.RemoveSelectedDataByConfigId(selectedData.ItemId);
	}

	// Token: 0x0600BD96 RID: 48534 RVA: 0x002AE278 File Offset: 0x002AC478
	protected void RemoveSelectedDataByIncId(int incId)
	{
		for (int i = 0; i < this.SelectedDataList.Count; i++)
		{
			ISelectedData selectedData = this.SelectedDataList[i];
			if (selectedData.IncId == incId)
			{
				selectedData.SelectedCount = 0;
				this.SelectedDataList.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600BD97 RID: 48535 RVA: 0x002AE2C8 File Offset: 0x002AC4C8
	private void RemoveSelectedDataByConfigId(int configId)
	{
		for (int i = 0; i < this.SelectedDataList.Count; i++)
		{
			ISelectedData selectedData = this.SelectedDataList[i];
			if (selectedData.ItemId == configId)
			{
				selectedData.SelectedCount = 0;
				this.SelectedDataList.RemoveAt(i);
				return;
			}
		}
	}

	// Token: 0x0600BD98 RID: 48536 RVA: 0x002AE318 File Offset: 0x002AC518
	protected void CancelPropItemSelected(SelectablePropData propData)
	{
		if (this.LastAddData == null || this.IsSameLastAddItemData(propData))
		{
			return;
		}
		int loopScrollViewIndex = this.GetLoopScrollViewIndex(this.LastAddData.IncId, this.LastAddData.ItemId);
		if (loopScrollViewIndex < 0)
		{
			return;
		}
		if (!this.LoopScrollView.IsGridDisplaying(loopScrollViewIndex))
		{
			return;
		}
		SelectablePropMediumItemGrid selectablePropMediumItemGrid = this.LoopScrollView.UnsafeGetGridProxy(loopScrollViewIndex, false);
		if (selectablePropMediumItemGrid == null)
		{
			return;
		}
		selectablePropMediumItemGrid.Clear();
		this.RefreshSelectFrame(selectablePropMediumItemGrid, false);
		selectablePropMediumItemGrid.SetReduceButton(null);
	}

	// Token: 0x0600BD99 RID: 48537 RVA: 0x002AE390 File Offset: 0x002AC590
	private void SetLastAddData(ISelectedData selectedData)
	{
		this.LastAddData = selectedData;
		SelectablePropData selectablePropData = selectedData as SelectablePropData;
		if (selectablePropData != null)
		{
			this.LastSelectedPropData = selectablePropData;
		}
	}

	// Token: 0x0600BD9A RID: 48538 RVA: 0x002AE3B8 File Offset: 0x002AC5B8
	protected void AddData(SelectablePropData propData)
	{
		ISelectedData selectedData = this.GetSelectedData(propData);
		if (selectedData == null)
		{
			this.SelectedDataList.Add(propData);
			int selectedCount = propData.SelectedCount;
			propData.SelectedCount = selectedCount + 1;
		}
		else
		{
			this.AddSelectedData(selectedData);
		}
		if (this.Data.OtherFunction != null)
		{
			this.Data.OtherFunction();
		}
	}

	// Token: 0x0600BD9B RID: 48539 RVA: 0x002AE414 File Offset: 0x002AC614
	private void AddSelectedData(ISelectedData selectedData)
	{
		int count = this.SelectedDataList.Count;
		for (int i = 0; i < count; i++)
		{
			ISelectedData selectedData2 = this.SelectedDataList[i];
			if (selectedData2.IncId == 0 && selectedData2.ItemId == selectedData.ItemId)
			{
				selectedData2.SelectedCount++;
				return;
			}
		}
		this.SelectedDataList.Add(selectedData);
	}

	// Token: 0x0600BD9C RID: 48540 RVA: 0x002AE478 File Offset: 0x002AC678
	[return: Nullable(2)]
	protected ISelectedData GetSelectedData(ISelectedData selectedData)
	{
		if (selectedData == null)
		{
			return null;
		}
		int incId = selectedData.IncId;
		if (incId > 0)
		{
			foreach (ISelectedData selectedData2 in this.SelectedDataList)
			{
				if (selectedData2.IncId == incId)
				{
					return selectedData2;
				}
			}
			return null;
		}
		int itemId = selectedData.ItemId;
		if (itemId > 0)
		{
			foreach (ISelectedData selectedData3 in this.SelectedDataList)
			{
				if (selectedData3.ItemId == itemId)
				{
					return selectedData3;
				}
			}
		}
		return null;
	}

	// Token: 0x0600BD9D RID: 48541 RVA: 0x002AE540 File Offset: 0x002AC740
	private int GetSelectedDataCount(ISelectedData selectedData)
	{
		ISelectedData selectedData2 = this.GetSelectedData(selectedData);
		if (selectedData2 == null)
		{
			return 0;
		}
		return selectedData2.SelectedCount;
	}

	// Token: 0x0600BD9E RID: 48542 RVA: 0x002AE560 File Offset: 0x002AC760
	protected void UpdateExp()
	{
		CommonIntensifyPropExpData expData = this.ExpData;
		if (((expData != null) ? expData.GetItemExpFunction : null) != null)
		{
			int num = 0;
			foreach (ISelectedData selectedData in this.SelectedDataList)
			{
				num += this.ExpData.GetItemExpFunction(selectedData) * selectedData.SelectedCount;
			}
			this.SelectableExpData.UpdateExp(num);
		}
	}

	// Token: 0x0600BD9F RID: 48543 RVA: 0x002AE5EC File Offset: 0x002AC7EC
	private void OnChangeItemSelectList()
	{
		this.UpdateChangeItemSelectList();
	}

	// Token: 0x0600BDA0 RID: 48544 RVA: 0x002AE5F4 File Offset: 0x002AC7F4
	[NullableContext(2)]
	public UUIItem GetGridByDisplayIndex(int index)
	{
		LoopScrollView<SelectablePropMediumItemGrid, SelectablePropData> loopScrollView = this.LoopScrollView;
		if (loopScrollView == null)
		{
			return null;
		}
		return loopScrollView.GetGridByDisplayIndex(index);
	}

	// Token: 0x0400557E RID: 21886
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<SelectablePropMediumItemGrid, SelectablePropData> LoopScrollView;

	// Token: 0x0400557F RID: 21887
	[Nullable(2)]
	protected SelectableComponentData Data;

	// Token: 0x04005580 RID: 21888
	protected List<ISelectedData> SelectedDataList = new List<ISelectedData>();

	// Token: 0x04005581 RID: 21889
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<T> ItemDataList;

	// Token: 0x04005582 RID: 21890
	[Nullable(2)]
	protected ISelectedData LastAddData;

	// Token: 0x04005583 RID: 21891
	[Nullable(2)]
	protected SelectablePropData LastSelectedPropData;

	// Token: 0x04005584 RID: 21892
	protected int MaxSize = 20;

	// Token: 0x04005585 RID: 21893
	[Nullable(2)]
	protected SelectableExpData SelectableExpData;

	// Token: 0x04005586 RID: 21894
	[Nullable(2)]
	protected ISelectedData FirstOperationData;

	// Token: 0x04005587 RID: 21895
	[Nullable(2)]
	protected CommonIntensifyPropExpData ExpData;

	// Token: 0x04005588 RID: 21896
	protected int LastSelectedIndex;

	// Token: 0x04005589 RID: 21897
	protected bool OnlyGold;
}
