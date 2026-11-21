using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000C12 RID: 3090
[NullableContext(1)]
[Nullable(0)]
public class VisionRecoveryChoosePanel<[Nullable(0)] T> : UiPanelBase where T : ItemDataBase
{
	// Token: 0x060080CE RID: 32974 RVA: 0x0027824C File Offset: 0x0027644C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickMask)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickCloseBtn)),
			new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnClickSelectAllToggle)),
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickManageBtn))
		};
	}

	// Token: 0x060080CF RID: 32975 RVA: 0x00278397 File Offset: 0x00276597
	protected override void OnBeforeCreateImplement()
	{
		this.UiViewSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiViewSequence);
	}

	// Token: 0x060080D0 RID: 32976 RVA: 0x002783B4 File Offset: 0x002765B4
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecoveryChoosePanel<T>.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecoveryChoosePanel<T>.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060080D1 RID: 32977 RVA: 0x002783F8 File Offset: 0x002765F8
	protected override void OnStart()
	{
		base.SetButtonUiActive(9, true);
		this.SelectComponent = new CommonItemSelectView<T>(base.GetItem(0));
		this.SortEntrance = new SortEntrance<T>(base.GetItem(5), new TUpdateDataListFunction<T>(this.OnFilterRefresh));
		this.FilterEntrance = new FilterEntrance<T>(base.GetItem(4), new TUpdateDataListFunction<T>(this.OnFilterRefresh));
	}

	// Token: 0x060080D2 RID: 32978 RVA: 0x0027845C File Offset: 0x0027665C
	protected override void OnAfterShow()
	{
		this.OnAddEventListener();
	}

	// Token: 0x060080D3 RID: 32979 RVA: 0x00278464 File Offset: 0x00276664
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnSelectItem));
	}

	// Token: 0x060080D4 RID: 32980 RVA: 0x00278484 File Offset: 0x00276684
	public void RefreshUi(CommonItemSelectViewOpenViewData<T> data)
	{
		this.SelectComponent.UpdateSelectableComponent(data.SelectableComponentType, data.ItemDataBaseList, data.SelectedDataList, data.SelectableComponentData, data.ExpData);
		this.SortEntrance.SetSortToggleState(data.InitSortToggleState);
		this.UpdateFilterComponent(data.UseWayId, data.ItemDataBaseList);
		if (data.SelectedDataList.Count <= 0)
		{
			base.GetExtendToggle(7).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x060080D5 RID: 32981 RVA: 0x002784FC File Offset: 0x002766FC
	public void UpdateFilterComponent(EFilterSortGroupId useWayId, List<T> list)
	{
		bool flag = false;
		bool flag2 = false;
		if (useWayId != EFilterSortGroupId.None)
		{
			int? num = new int?(SortConfig.Instance.GetSortId(useWayId));
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (num2.GetValueOrDefault() > num3 & num2 != null)
				{
					flag = true;
				}
			}
			int? num4 = new int?(FilterConfig.Instance.GetFilterId(useWayId));
			if (num4 != null)
			{
				int? num2 = num4;
				int num3 = 0;
				if (num2.GetValueOrDefault() > num3 & num2 != null)
				{
					flag2 = true;
				}
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
			int uniqueIdByGroupId = this.FilterEntrance.GetUniqueIdByGroupId(useWayId);
			this.SortEntrance.SetFilterUniqueId(uniqueIdByGroupId);
			this.SortEntrance.UpdateData(useWayId, list, Array.Empty<object>());
			int uniqueIdByGroupId2 = this.SortEntrance.GetUniqueIdByGroupId(useWayId);
			this.FilterEntrance.SetSortUniqueId(uniqueIdByGroupId2);
		}
		if (flag2)
		{
			int uniqueIdByGroupId3 = this.SortEntrance.GetUniqueIdByGroupId(useWayId);
			this.FilterEntrance.SetSortUniqueId(uniqueIdByGroupId3);
			this.FilterEntrance.UpdateData(useWayId, list, Array.Empty<object>());
			int uniqueIdByGroupId4 = this.FilterEntrance.GetUniqueIdByGroupId(useWayId);
			this.SortEntrance.SetFilterUniqueId(uniqueIdByGroupId4);
		}
	}

	// Token: 0x060080D6 RID: 32982 RVA: 0x0027864C File Offset: 0x0027684C
	public void SetAllSelectToggleVisible(bool state)
	{
		base.GetExtendToggle(7).RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x060080D7 RID: 32983 RVA: 0x00278673 File Offset: 0x00276873
	public void UpdatePartByIndex(int index)
	{
		this.SelectComponent.RefreshPartByIndex(index);
	}

	// Token: 0x060080D8 RID: 32984 RVA: 0x00278681 File Offset: 0x00276881
	public void BindClickCloseCallBack(Action callback)
	{
		this.OnClickCloseCallBack = callback;
	}

	// Token: 0x060080D9 RID: 32985 RVA: 0x0027868A File Offset: 0x0027688A
	public void BindClickSelectAllToggleCallback(Action<EToggleState> callback)
	{
		this.OnClickSelectAllToggleCallBack = callback;
	}

	// Token: 0x060080DA RID: 32986 RVA: 0x00278693 File Offset: 0x00276893
	public void BindFilterSortRefresh(Action<List<T>> callback)
	{
		this.OnFilterSortRefreshCallBack = callback;
	}

	// Token: 0x060080DB RID: 32987 RVA: 0x0027869C File Offset: 0x0027689C
	public void ShowTipsComponent(ItemTipsData data)
	{
		this.TipsComponent.Refresh(data);
		base.GetItem(3).SetUIActive(true);
		base.GetButton(2).RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x060080DC RID: 32988 RVA: 0x002786DC File Offset: 0x002768DC
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x060080DD RID: 32989 RVA: 0x002786E4 File Offset: 0x002768E4
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnSelectItem));
	}

	// Token: 0x060080DE RID: 32990 RVA: 0x00278702 File Offset: 0x00276902
	protected override void OnBeforeDestroy()
	{
		this.SelectComponent.Destroy(null);
		this.TipsComponent.Destroy(null);
	}

	// Token: 0x060080DF RID: 32991 RVA: 0x0027871C File Offset: 0x0027691C
	protected void OnClickMask()
	{
		base.GetItem(3).SetUIActive(false);
		base.GetButton(2).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x060080E0 RID: 32992 RVA: 0x00278750 File Offset: 0x00276950
	protected void OnClickCloseBtn()
	{
		if (this.OnClickCloseCallBack != null)
		{
			this.OnClickCloseCallBack();
			return;
		}
		this.SetActive(false);
	}

	// Token: 0x060080E1 RID: 32993 RVA: 0x0027876D File Offset: 0x0027696D
	protected void OnClickSelectAllToggle(EToggleState state)
	{
		if (this.OnClickSelectAllToggleCallBack != null)
		{
			this.OnClickSelectAllToggleCallBack(state);
		}
	}

	// Token: 0x060080E2 RID: 32994 RVA: 0x00278784 File Offset: 0x00276984
	private void OnSelectItem(int itemId, int incId)
	{
		ItemTipsData tipsDataById = ItemTipsComponentUtilTool.GetTipsDataById(itemId, new int?(incId), null);
		TipsVisionData tipsVisionData = tipsDataById as TipsVisionData;
		if (tipsVisionData != null)
		{
			int selectedCount = 0;
			foreach (ISelectedData selectedData in this.SelectComponent.GetCurrentSelectedData())
			{
				if (selectedData.IncId == incId)
				{
					selectedCount = selectedData.SelectedCount;
					break;
				}
			}
			tipsVisionData.SelectedCount = selectedCount;
		}
		this.ShowTipsComponent(tipsDataById);
	}

	// Token: 0x060080E3 RID: 32995 RVA: 0x00278814 File Offset: 0x00276A14
	private void OnFilterRefresh(List<T> list, bool _1, EFilterSortType _2)
	{
		this.SelectComponent.UpdateByDataList(list);
		this.TipsComponent.SetActive(false);
		if (this.OnFilterSortRefreshCallBack != null)
		{
			this.OnFilterSortRefreshCallBack(list);
		}
	}

	// Token: 0x060080E4 RID: 32996 RVA: 0x00278842 File Offset: 0x00276A42
	private void OnClickManageBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.PhantomManageView, null, null);
	}

	// Token: 0x060080E5 RID: 32997 RVA: 0x00278855 File Offset: 0x00276A55
	public UUIItem GetFilterToggleItem()
	{
		return this.FilterEntrance.GetFilterToggleItem();
	}

	// Token: 0x04004F51 RID: 20305
	[Nullable(2)]
	public UiBehaviorLevelSequence UiViewSequence;

	// Token: 0x04004F52 RID: 20306
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonItemSelectView<T> SelectComponent;

	// Token: 0x04004F53 RID: 20307
	[Nullable(2)]
	private ItemTipsComponentContentComponent TipsComponent;

	// Token: 0x04004F54 RID: 20308
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SortEntrance<T> SortEntrance;

	// Token: 0x04004F55 RID: 20309
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterEntrance<T> FilterEntrance;

	// Token: 0x04004F56 RID: 20310
	[Nullable(2)]
	private Action OnClickCloseCallBack;

	// Token: 0x04004F57 RID: 20311
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<List<T>> OnFilterSortRefreshCallBack;

	// Token: 0x04004F58 RID: 20312
	[Nullable(2)]
	private Action<EToggleState> OnClickSelectAllToggleCallBack;

	// Token: 0x02006EC4 RID: 28356
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024354 RID: 148308
		Pad,
		// Token: 0x04024355 RID: 148309
		TipsPos,
		// Token: 0x04024356 RID: 148310
		Mask,
		// Token: 0x04024357 RID: 148311
		ItemTips,
		// Token: 0x04024358 RID: 148312
		FilterItem,
		// Token: 0x04024359 RID: 148313
		SortItem,
		// Token: 0x0402435A RID: 148314
		CloseBtn,
		// Token: 0x0402435B RID: 148315
		SelectAllToggle,
		// Token: 0x0402435C RID: 148316
		BtnPhantomManage = 9
	}
}
