using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020018CC RID: 6348
[NullableContext(1)]
[Nullable(0)]
public class ItemSelectView : UiViewBase
{
	// Token: 0x0600BA3E RID: 47678 RVA: 0x002A2D73 File Offset: 0x002A0F73
	public ItemSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BA3F RID: 47679 RVA: 0x002A2D7C File Offset: 0x002A0F7C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickMask))
		};
	}

	// Token: 0x0600BA40 RID: 47680 RVA: 0x002A2E3C File Offset: 0x002A103C
	protected override UniTask OnBeforeStartAsync()
	{
		ItemSelectView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemSelectView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600BA41 RID: 47681 RVA: 0x002A2E80 File Offset: 0x002A1080
	protected override void OnStart()
	{
		this.SelectComponent = new CommonItemSelectView<ItemDataBase>(base.GetItem(0));
		this.SortEntrance = new SortEntrance<ItemDataBase>(base.GetItem(5), new TUpdateDataListFunction<ItemDataBase>(this.OnFilterRefresh));
		this.FilterEntrance = new FilterEntrance<ItemDataBase>(base.GetItem(4), new TUpdateDataListFunction<ItemDataBase>(this.OnFilterRefresh));
	}

	// Token: 0x0600BA42 RID: 47682 RVA: 0x002A2EDB File Offset: 0x002A10DB
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnSelectItem));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
	}

	// Token: 0x0600BA43 RID: 47683 RVA: 0x002A2F15 File Offset: 0x002A1115
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnSelectItem));
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
	}

	// Token: 0x0600BA44 RID: 47684 RVA: 0x002A2F50 File Offset: 0x002A1150
	protected override void OnBeforeShow()
	{
		CommonItemSelectViewOpenViewData<ItemDataBase> commonItemSelectViewOpenViewData = this.OpenParam as CommonItemSelectViewOpenViewData<ItemDataBase>;
		this.SelectComponent.UpdateSelectableComponent(commonItemSelectViewOpenViewData.SelectableComponentType, commonItemSelectViewOpenViewData.ItemDataBaseList, commonItemSelectViewOpenViewData.SelectedDataList, commonItemSelectViewOpenViewData.SelectableComponentData, commonItemSelectViewOpenViewData.ExpData);
		this.SortEntrance.SetSortToggleState(commonItemSelectViewOpenViewData.InitSortToggleState);
		this.UpdateFilterComponent(commonItemSelectViewOpenViewData.UseWayId, commonItemSelectViewOpenViewData.ItemDataBaseList);
	}

	// Token: 0x0600BA45 RID: 47685 RVA: 0x002A2FB5 File Offset: 0x002A11B5
	private void OnClickMask()
	{
		base.GetItem(3).SetUIActive(false);
		base.CloseMe(null);
	}

	// Token: 0x0600BA46 RID: 47686 RVA: 0x002A2FCC File Offset: 0x002A11CC
	private void OnSelectItem(int itemId, int incId)
	{
		ItemTipsData tipsDataById = ItemTipsComponentUtilTool.GetTipsDataById(itemId, new int?(incId), null);
		if (tipsDataById == null)
		{
			return;
		}
		this.ItemTipsComponentContentComponent.Refresh(tipsDataById);
		base.GetItem(3).SetUIActive(true);
	}

	// Token: 0x0600BA47 RID: 47687 RVA: 0x002A3004 File Offset: 0x002A1204
	private void OnFilterRefresh(List<ItemDataBase> dataList, bool isOutSideChange, EFilterSortType operationType)
	{
		this.SelectComponent.UpdateByDataList(dataList);
	}

	// Token: 0x0600BA48 RID: 47688 RVA: 0x002A3014 File Offset: 0x002A1214
	public void UpdateFilterComponent(EFilterSortGroupId useWayId, List<ItemDataBase> list)
	{
		bool flag = false;
		bool flag2 = false;
		if (useWayId != EFilterSortGroupId.None)
		{
			if (SortConfig.Instance.GetSortId(useWayId) > 0)
			{
				flag = true;
			}
			if (FilterConfig.Instance.GetFilterId(useWayId) > 0)
			{
				flag2 = true;
			}
		}
		this.SortEntrance.GetRootItem().SetUIActive(flag);
		this.FilterEntrance.GetRootItem().SetUIActive(flag2);
		if (!flag && !flag2)
		{
			this.SelectComponent.UpdateByDataList(list);
			return;
		}
		if (flag)
		{
			this.SortEntrance.UpdateData(useWayId, list, Array.Empty<object>());
			int uniqueIdByGroupId = this.SortEntrance.GetUniqueIdByGroupId(useWayId);
			this.FilterEntrance.SetSortUniqueId(uniqueIdByGroupId);
		}
		if (flag2)
		{
			this.FilterEntrance.UpdateData(useWayId, list, Array.Empty<object>());
			int uniqueIdByGroupId2 = this.FilterEntrance.GetUniqueIdByGroupId(useWayId);
			this.SortEntrance.SetFilterUniqueId(uniqueIdByGroupId2);
		}
	}

	// Token: 0x0600BA49 RID: 47689 RVA: 0x002A30D9 File Offset: 0x002A12D9
	protected override void OnBeforeDestroy()
	{
		this.SelectComponent.Destroy(null);
		this.ItemTipsComponentContentComponent.Destroy(null);
	}

	// Token: 0x0600BA4A RID: 47690 RVA: 0x002A30F4 File Offset: 0x002A12F4
	private void OnItemFuncValueChange(int uniqueId)
	{
		CommonItemSelectViewOpenViewData<ItemDataBase> commonItemSelectViewOpenViewData = this.OpenParam as CommonItemSelectViewOpenViewData<ItemDataBase>;
		if (commonItemSelectViewOpenViewData == null || commonItemSelectViewOpenViewData.ItemDataBaseList == null)
		{
			return;
		}
		int num = commonItemSelectViewOpenViewData.ItemDataBaseList.FindIndex((ItemDataBase itemData) => itemData.GetUniqueId() == uniqueId);
		if (num < 0)
		{
			return;
		}
		bool isLock = commonItemSelectViewOpenViewData.ItemDataBaseList[num].GetIsLock();
		if (commonItemSelectViewOpenViewData.SelectedDataList != null && isLock)
		{
			int num2 = commonItemSelectViewOpenViewData.SelectedDataList.FindIndex((ISelectedData selectData) => selectData.IncId == uniqueId);
			if (num2 >= 0)
			{
				commonItemSelectViewOpenViewData.SelectedDataList.RemoveAt(num2);
			}
		}
		this.SelectComponent.UpdateSelectableComponent(commonItemSelectViewOpenViewData.SelectableComponentType, commonItemSelectViewOpenViewData.ItemDataBaseList, commonItemSelectViewOpenViewData.SelectedDataList, commonItemSelectViewOpenViewData.SelectableComponentData, commonItemSelectViewOpenViewData.ExpData);
		this.SelectComponent.RefreshPartByIndex(num);
		this.SelectComponent.UpdateChangeItemSelectList();
	}

	// Token: 0x0400545E RID: 21598
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonItemSelectView<ItemDataBase> SelectComponent;

	// Token: 0x0400545F RID: 21599
	[Nullable(2)]
	private ItemTipsComponentContentComponent ItemTipsComponentContentComponent;

	// Token: 0x04005460 RID: 21600
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SortEntrance<ItemDataBase> SortEntrance;

	// Token: 0x04005461 RID: 21601
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterEntrance<ItemDataBase> FilterEntrance;

	// Token: 0x02007E53 RID: 32339
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029572 RID: 169330
		Pad,
		// Token: 0x04029573 RID: 169331
		TipsPos,
		// Token: 0x04029574 RID: 169332
		Mask,
		// Token: 0x04029575 RID: 169333
		ItemTips,
		// Token: 0x04029576 RID: 169334
		FilterItem,
		// Token: 0x04029577 RID: 169335
		SortItem
	}
}
