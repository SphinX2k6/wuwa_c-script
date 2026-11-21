using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000D85 RID: 3461
[NullableContext(1)]
[Nullable(0)]
public class ItemSelectView : UiViewBase
{
	// Token: 0x06008E27 RID: 36391 RVA: 0x002AD4CB File Offset: 0x002AB6CB
	public ItemSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008E28 RID: 36392 RVA: 0x002AD4D4 File Offset: 0x002AB6D4
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

	// Token: 0x06008E29 RID: 36393 RVA: 0x002AD594 File Offset: 0x002AB794
	protected override UniTask OnBeforeStartAsync()
	{
		ItemSelectView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemSelectView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008E2A RID: 36394 RVA: 0x002AD5D8 File Offset: 0x002AB7D8
	protected override void OnStart()
	{
		this.SelectComponent = new CommonItemSelectView<ItemDataBase>(base.GetItem(0));
		this.SortEntrance = new SortEntrance<ItemDataBase>(base.GetItem(5), new TUpdateDataListFunction<ItemDataBase>(this.OnFilterRefresh));
		this.FilterEntrance = new FilterEntrance<ItemDataBase>(base.GetItem(4), new TUpdateDataListFunction<ItemDataBase>(this.OnFilterRefresh));
	}

	// Token: 0x06008E2B RID: 36395 RVA: 0x002AD633 File Offset: 0x002AB833
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnSelectItem));
		EventSystem.Instance.Add<int>(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
	}

	// Token: 0x06008E2C RID: 36396 RVA: 0x002AD66D File Offset: 0x002AB86D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnSelectItem));
		EventSystem.Instance.Remove(EEventName.OnItemFuncValueChange, new Action<int>(this.OnItemFuncValueChange));
	}

	// Token: 0x06008E2D RID: 36397 RVA: 0x002AD6A8 File Offset: 0x002AB8A8
	protected override void OnBeforeShow()
	{
		CommonItemSelectViewOpenViewData<ItemDataBase> commonItemSelectViewOpenViewData = this.OpenParam as CommonItemSelectViewOpenViewData<ItemDataBase>;
		this.SelectComponent.UpdateSelectableComponent(commonItemSelectViewOpenViewData.SelectableComponentType, commonItemSelectViewOpenViewData.ItemDataBaseList, commonItemSelectViewOpenViewData.SelectedDataList, commonItemSelectViewOpenViewData.SelectableComponentData, commonItemSelectViewOpenViewData.ExpData);
		this.SortEntrance.SetSortToggleState(commonItemSelectViewOpenViewData.InitSortToggleState);
		this.UpdateFilterComponent(commonItemSelectViewOpenViewData.UseWayId, commonItemSelectViewOpenViewData.ItemDataBaseList);
	}

	// Token: 0x06008E2E RID: 36398 RVA: 0x002AD70D File Offset: 0x002AB90D
	private void OnClickMask()
	{
		base.GetItem(3).SetUIActive(false);
		base.CloseMe(null);
	}

	// Token: 0x06008E2F RID: 36399 RVA: 0x002AD724 File Offset: 0x002AB924
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

	// Token: 0x06008E30 RID: 36400 RVA: 0x002AD75C File Offset: 0x002AB95C
	private void OnFilterRefresh(List<ItemDataBase> dataList, bool isOutSideChange, EFilterSortType operationType)
	{
		this.SelectComponent.UpdateByDataList(dataList);
	}

	// Token: 0x06008E31 RID: 36401 RVA: 0x002AD76C File Offset: 0x002AB96C
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

	// Token: 0x06008E32 RID: 36402 RVA: 0x002AD831 File Offset: 0x002ABA31
	protected override void OnBeforeDestroy()
	{
		this.SelectComponent.Destroy(null);
		this.ItemTipsComponentContentComponent.Destroy(null);
	}

	// Token: 0x06008E33 RID: 36403 RVA: 0x002AD84C File Offset: 0x002ABA4C
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

	// Token: 0x04005509 RID: 21769
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonItemSelectView<ItemDataBase> SelectComponent;

	// Token: 0x0400550A RID: 21770
	[Nullable(2)]
	private ItemTipsComponentContentComponent ItemTipsComponentContentComponent;

	// Token: 0x0400550B RID: 21771
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SortEntrance<ItemDataBase> SortEntrance;

	// Token: 0x0400550C RID: 21772
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterEntrance<ItemDataBase> FilterEntrance;

	// Token: 0x02006FDA RID: 28634
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402489F RID: 149663
		Pad,
		// Token: 0x040248A0 RID: 149664
		TipsPos,
		// Token: 0x040248A1 RID: 149665
		Mask,
		// Token: 0x040248A2 RID: 149666
		ItemTips,
		// Token: 0x040248A3 RID: 149667
		FilterItem,
		// Token: 0x040248A4 RID: 149668
		SortItem
	}
}
