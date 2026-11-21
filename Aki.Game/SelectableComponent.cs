using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000E15 RID: 3605
[NullableContext(1)]
[Nullable(0)]
public class SelectableComponent<[Nullable(0)] T> : UiPanelBase where T : ItemDataBase
{
	// Token: 0x17000FF9 RID: 4089
	// (get) Token: 0x06009179 RID: 37241 RVA: 0x002B88FF File Offset: 0x002B6AFF
	protected bool IsSelectFrameFollowClick
	{
		get
		{
			SelectableComponentData data = this.Data;
			return data != null && data.IsSelectFrameFollowClick;
		}
	}

	// Token: 0x0600917A RID: 37242 RVA: 0x002B8912 File Offset: 0x002B6B12
	public void InitLoopScroller(UUILoopScrollViewComponent loopComponent, UUIItem templateActor, SelectableComponentData data)
	{
		this.LoopScrollView = new LoopScrollView<SelectablePropMediumItemGrid, SelectablePropData>(loopComponent, templateActor.GetOwner() as AUIBaseActor, new Func<SelectablePropMediumItemGrid>(this.InitItem), false);
		this.SetData(data);
	}

	// Token: 0x0600917B RID: 37243 RVA: 0x002B8940 File Offset: 0x002B6B40
	protected void SetData(SelectableComponentData data)
	{
		this.Data = data;
	}

	// Token: 0x0600917C RID: 37244 RVA: 0x002B8949 File Offset: 0x002B6B49
	public void SetExpData(CommonIntensifyPropExpData expData)
	{
		this.SelectableExpData = SelectableExpData.PhraseData(expData);
	}

	// Token: 0x0600917D RID: 37245 RVA: 0x002B8957 File Offset: 0x002B6B57
	public void SetMaxSize(int size)
	{
		this.MaxSize = size;
	}

	// Token: 0x0600917E RID: 37246 RVA: 0x002B8960 File Offset: 0x002B6B60
	public void SetOnlyGold(bool onlyGold)
	{
		this.OnlyGold = onlyGold;
	}

	// Token: 0x0600917F RID: 37247 RVA: 0x002B8969 File Offset: 0x002B6B69
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

	// Token: 0x06009180 RID: 37248 RVA: 0x002B8989 File Offset: 0x002B6B89
	public void RefreshPartByIndex(int index)
	{
		this.LoopScrollView.RefreshGridProxy(index);
	}

	// Token: 0x06009181 RID: 37249 RVA: 0x002B8997 File Offset: 0x002B6B97
	public void RefreshAllByDisplay()
	{
		this.LoopScrollView.RefreshAllGridProxies();
	}

	// Token: 0x06009182 RID: 37250 RVA: 0x002B89A4 File Offset: 0x002B6BA4
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

	// Token: 0x06009183 RID: 37251 RVA: 0x002B89E3 File Offset: 0x002B6BE3
	public List<ISelectedData> GetCurrentSelectedData()
	{
		return this.SelectedDataList;
	}

	// Token: 0x06009184 RID: 37252 RVA: 0x002B89EC File Offset: 0x002B6BEC
	public void UpdateDataList(List<T> dataList)
	{
		this.ItemDataList = dataList;
		this.LoopScrollView.ReloadProxyData(new Func<int, SelectablePropData>(this.GetPropScrollViewData), this.ItemDataList.Count, true, false);
		if (this.ItemDataList.Count > 0)
		{
			this.LoopScrollView.ScrollToGridIndex(this.LastSelectedIndex, true);
		}
	}

	// Token: 0x06009185 RID: 37253 RVA: 0x002B8A44 File Offset: 0x002B6C44
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

	// Token: 0x06009186 RID: 37254 RVA: 0x002B8AE8 File Offset: 0x002B6CE8
	public void UpdateChangeItemSelectList()
	{
		Action<List<ISelectedData>, SelectableExpData> onChangeSelectedFunction = this.Data.OnChangeSelectedFunction;
		if (onChangeSelectedFunction == null)
		{
			return;
		}
		onChangeSelectedFunction(this.SelectedDataList, this.SelectableExpData);
	}

	// Token: 0x06009187 RID: 37255 RVA: 0x002B8B0C File Offset: 0x002B6D0C
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

	// Token: 0x06009188 RID: 37256 RVA: 0x002B8B61 File Offset: 0x002B6D61
	[NullableContext(2)]
	public ISelectedData GetFirstOperationItem()
	{
		return this.FirstOperationData;
	}

	// Token: 0x06009189 RID: 37257 RVA: 0x002B8B69 File Offset: 0x002B6D69
	public void SetFirstOperationData(ISelectedData data)
	{
		this.FirstOperationData = data;
	}

	// Token: 0x0600918A RID: 37258 RVA: 0x002B8B72 File Offset: 0x002B6D72
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x0600918B RID: 37259 RVA: 0x002B8B74 File Offset: 0x002B6D74
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

	// Token: 0x0600918C RID: 37260 RVA: 0x002B8BDB File Offset: 0x002B6DDB
	protected void OnAfterApplyMediumItemGrid(SelectablePropMediumItemGrid selectablePropMediumItemGrid)
	{
	}

	// Token: 0x0600918D RID: 37261 RVA: 0x002B8BE0 File Offset: 0x002B6DE0
	[NullableContext(2)]
	protected bool OnCanExecuteChange(object data, bool isForceSelected, EToggleState state)
	{
		SelectablePropData selectablePropData = data as SelectablePropData;
		return selectablePropData != null && this.CanAddMaterial(selectablePropData, false);
	}

	// Token: 0x0600918E RID: 37262 RVA: 0x002B8C04 File Offset: 0x002B6E04
	protected bool CanItemLongPress(ItemGridBase itemGrid, [Nullable(2)] object data)
	{
		SelectablePropData selectablePropData = data as SelectablePropData;
		return selectablePropData != null && this.CanAddMaterial(selectablePropData, false);
	}

	// Token: 0x0600918F RID: 37263 RVA: 0x002B8C28 File Offset: 0x002B6E28
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

	// Token: 0x06009190 RID: 37264 RVA: 0x002B8D28 File Offset: 0x002B6F28
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

	// Token: 0x06009191 RID: 37265 RVA: 0x002B8E14 File Offset: 0x002B7014
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

	// Token: 0x06009192 RID: 37266 RVA: 0x002B8E4F File Offset: 0x002B704F
	protected void RefreshSelectFrame(SelectablePropMediumItemGrid grid, bool isSelected)
	{
		if (this.IsSelectFrameFollowClick)
		{
			return;
		}
		grid.SetSelected(isSelected, true);
	}

	// Token: 0x06009193 RID: 37267 RVA: 0x002B8E64 File Offset: 0x002B7064
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

	// Token: 0x06009194 RID: 37268 RVA: 0x002B8EE0 File Offset: 0x002B70E0
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

	// Token: 0x06009195 RID: 37269 RVA: 0x002B8FD0 File Offset: 0x002B71D0
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

	// Token: 0x06009196 RID: 37270 RVA: 0x002B9014 File Offset: 0x002B7214
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

	// Token: 0x06009197 RID: 37271 RVA: 0x002B9073 File Offset: 0x002B7273
	protected void DeleteLastData(SelectablePropData propData)
	{
		if (!this.IsSameLastAddItemData(propData))
		{
			this.RemoveSelectedData(this.LastAddData);
		}
	}

	// Token: 0x06009198 RID: 37272 RVA: 0x002B908C File Offset: 0x002B728C
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

	// Token: 0x06009199 RID: 37273 RVA: 0x002B90BC File Offset: 0x002B72BC
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

	// Token: 0x0600919A RID: 37274 RVA: 0x002B910C File Offset: 0x002B730C
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

	// Token: 0x0600919B RID: 37275 RVA: 0x002B915C File Offset: 0x002B735C
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

	// Token: 0x0600919C RID: 37276 RVA: 0x002B91D4 File Offset: 0x002B73D4
	private void SetLastAddData(ISelectedData selectedData)
	{
		this.LastAddData = selectedData;
		SelectablePropData selectablePropData = selectedData as SelectablePropData;
		if (selectablePropData != null)
		{
			this.LastSelectedPropData = selectablePropData;
		}
	}

	// Token: 0x0600919D RID: 37277 RVA: 0x002B91FC File Offset: 0x002B73FC
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

	// Token: 0x0600919E RID: 37278 RVA: 0x002B9258 File Offset: 0x002B7458
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

	// Token: 0x0600919F RID: 37279 RVA: 0x002B92BC File Offset: 0x002B74BC
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

	// Token: 0x060091A0 RID: 37280 RVA: 0x002B9384 File Offset: 0x002B7584
	private int GetSelectedDataCount(ISelectedData selectedData)
	{
		ISelectedData selectedData2 = this.GetSelectedData(selectedData);
		if (selectedData2 == null)
		{
			return 0;
		}
		return selectedData2.SelectedCount;
	}

	// Token: 0x060091A1 RID: 37281 RVA: 0x002B93A4 File Offset: 0x002B75A4
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

	// Token: 0x060091A2 RID: 37282 RVA: 0x002B9430 File Offset: 0x002B7630
	private void OnChangeItemSelectList()
	{
		this.UpdateChangeItemSelectList();
	}

	// Token: 0x060091A3 RID: 37283 RVA: 0x002B9438 File Offset: 0x002B7638
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

	// Token: 0x0400562B RID: 22059
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<SelectablePropMediumItemGrid, SelectablePropData> LoopScrollView;

	// Token: 0x0400562C RID: 22060
	[Nullable(2)]
	protected SelectableComponentData Data;

	// Token: 0x0400562D RID: 22061
	protected List<ISelectedData> SelectedDataList = new List<ISelectedData>();

	// Token: 0x0400562E RID: 22062
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<T> ItemDataList;

	// Token: 0x0400562F RID: 22063
	[Nullable(2)]
	protected ISelectedData LastAddData;

	// Token: 0x04005630 RID: 22064
	[Nullable(2)]
	protected SelectablePropData LastSelectedPropData;

	// Token: 0x04005631 RID: 22065
	protected int MaxSize = 20;

	// Token: 0x04005632 RID: 22066
	[Nullable(2)]
	protected SelectableExpData SelectableExpData;

	// Token: 0x04005633 RID: 22067
	[Nullable(2)]
	protected ISelectedData FirstOperationData;

	// Token: 0x04005634 RID: 22068
	[Nullable(2)]
	protected CommonIntensifyPropExpData ExpData;

	// Token: 0x04005635 RID: 22069
	protected int LastSelectedIndex;

	// Token: 0x04005636 RID: 22070
	protected bool OnlyGold;
}
