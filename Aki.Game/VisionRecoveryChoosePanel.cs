using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001759 RID: 5977
[NullableContext(1)]
[Nullable(0)]
public class VisionRecoveryChoosePanel<[Nullable(0)] T> : UiPanelBase where T : ItemDataBase
{
	// Token: 0x0600ACE7 RID: 44263 RVA: 0x0026DDD0 File Offset: 0x0026BFD0
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

	// Token: 0x0600ACE8 RID: 44264 RVA: 0x0026DF1B File Offset: 0x0026C11B
	protected override void OnBeforeCreateImplement()
	{
		this.UiViewSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiViewSequence);
	}

	// Token: 0x0600ACE9 RID: 44265 RVA: 0x0026DF38 File Offset: 0x0026C138
	protected override UniTask OnBeforeStartAsync()
	{
		VisionRecoveryChoosePanel<T>.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VisionRecoveryChoosePanel<T>.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600ACEA RID: 44266 RVA: 0x0026DF7C File Offset: 0x0026C17C
	protected override void OnStart()
	{
		base.SetButtonUiActive(9, true);
		this.SelectComponent = new CommonItemSelectView<T>(base.GetItem(0));
		this.SortEntrance = new SortEntrance<T>(base.GetItem(5), new TUpdateDataListFunction<T>(this.OnFilterRefresh));
		this.FilterEntrance = new FilterEntrance<T>(base.GetItem(4), new TUpdateDataListFunction<T>(this.OnFilterRefresh));
	}

	// Token: 0x0600ACEB RID: 44267 RVA: 0x0026DFE0 File Offset: 0x0026C1E0
	protected override void OnAfterShow()
	{
		this.OnAddEventListener();
	}

	// Token: 0x0600ACEC RID: 44268 RVA: 0x0026DFE8 File Offset: 0x0026C1E8
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add<int, int>(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnSelectItem));
	}

	// Token: 0x0600ACED RID: 44269 RVA: 0x0026E008 File Offset: 0x0026C208
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

	// Token: 0x0600ACEE RID: 44270 RVA: 0x0026E080 File Offset: 0x0026C280
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

	// Token: 0x0600ACEF RID: 44271 RVA: 0x0026E1D0 File Offset: 0x0026C3D0
	public void SetAllSelectToggleVisible(bool state)
	{
		base.GetExtendToggle(7).RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x0600ACF0 RID: 44272 RVA: 0x0026E1F7 File Offset: 0x0026C3F7
	public void UpdatePartByIndex(int index)
	{
		this.SelectComponent.RefreshPartByIndex(index);
	}

	// Token: 0x0600ACF1 RID: 44273 RVA: 0x0026E205 File Offset: 0x0026C405
	public void BindClickCloseCallBack(Action callback)
	{
		this.OnClickCloseCallBack = callback;
	}

	// Token: 0x0600ACF2 RID: 44274 RVA: 0x0026E20E File Offset: 0x0026C40E
	public void BindClickSelectAllToggleCallback(Action<EToggleState> callback)
	{
		this.OnClickSelectAllToggleCallBack = callback;
	}

	// Token: 0x0600ACF3 RID: 44275 RVA: 0x0026E217 File Offset: 0x0026C417
	public void BindFilterSortRefresh(Action<List<T>> callback)
	{
		this.OnFilterSortRefreshCallBack = callback;
	}

	// Token: 0x0600ACF4 RID: 44276 RVA: 0x0026E220 File Offset: 0x0026C420
	public void ShowTipsComponent(ItemTipsData data)
	{
		this.TipsComponent.Refresh(data);
		base.GetItem(3).SetUIActive(true);
		base.GetButton(2).RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x0600ACF5 RID: 44277 RVA: 0x0026E260 File Offset: 0x0026C460
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x0600ACF6 RID: 44278 RVA: 0x0026E268 File Offset: 0x0026C468
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSelectItemAdd, new Action<int, int>(this.OnSelectItem));
	}

	// Token: 0x0600ACF7 RID: 44279 RVA: 0x0026E286 File Offset: 0x0026C486
	protected override void OnBeforeDestroy()
	{
		this.SelectComponent.Destroy(null);
		this.TipsComponent.Destroy(null);
	}

	// Token: 0x0600ACF8 RID: 44280 RVA: 0x0026E2A0 File Offset: 0x0026C4A0
	protected void OnClickMask()
	{
		base.GetItem(3).SetUIActive(false);
		base.GetButton(2).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0600ACF9 RID: 44281 RVA: 0x0026E2D4 File Offset: 0x0026C4D4
	protected void OnClickCloseBtn()
	{
		if (this.OnClickCloseCallBack != null)
		{
			this.OnClickCloseCallBack();
			return;
		}
		this.SetActive(false);
	}

	// Token: 0x0600ACFA RID: 44282 RVA: 0x0026E2F1 File Offset: 0x0026C4F1
	protected void OnClickSelectAllToggle(EToggleState state)
	{
		if (this.OnClickSelectAllToggleCallBack != null)
		{
			this.OnClickSelectAllToggleCallBack(state);
		}
	}

	// Token: 0x0600ACFB RID: 44283 RVA: 0x0026E308 File Offset: 0x0026C508
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

	// Token: 0x0600ACFC RID: 44284 RVA: 0x0026E398 File Offset: 0x0026C598
	private void OnFilterRefresh(List<T> list, bool _1, EFilterSortType _2)
	{
		this.SelectComponent.UpdateByDataList(list);
		this.TipsComponent.SetActive(false);
		if (this.OnFilterSortRefreshCallBack != null)
		{
			this.OnFilterSortRefreshCallBack(list);
		}
	}

	// Token: 0x0600ACFD RID: 44285 RVA: 0x0026E3C6 File Offset: 0x0026C5C6
	private void OnClickManageBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.PhantomManageView, null, null);
	}

	// Token: 0x0600ACFE RID: 44286 RVA: 0x0026E3D9 File Offset: 0x0026C5D9
	public UUIItem GetFilterToggleItem()
	{
		return this.FilterEntrance.GetFilterToggleItem();
	}

	// Token: 0x04004EA8 RID: 20136
	[Nullable(2)]
	public UiBehaviorLevelSequence UiViewSequence;

	// Token: 0x04004EA9 RID: 20137
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonItemSelectView<T> SelectComponent;

	// Token: 0x04004EAA RID: 20138
	[Nullable(2)]
	private ItemTipsComponentContentComponent TipsComponent;

	// Token: 0x04004EAB RID: 20139
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private SortEntrance<T> SortEntrance;

	// Token: 0x04004EAC RID: 20140
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterEntrance<T> FilterEntrance;

	// Token: 0x04004EAD RID: 20141
	[Nullable(2)]
	private Action OnClickCloseCallBack;

	// Token: 0x04004EAE RID: 20142
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<List<T>> OnFilterSortRefreshCallBack;

	// Token: 0x04004EAF RID: 20143
	[Nullable(2)]
	private Action<EToggleState> OnClickSelectAllToggleCallBack;

	// Token: 0x02007D3E RID: 32062
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029029 RID: 167977
		Pad,
		// Token: 0x0402902A RID: 167978
		TipsPos,
		// Token: 0x0402902B RID: 167979
		Mask,
		// Token: 0x0402902C RID: 167980
		ItemTips,
		// Token: 0x0402902D RID: 167981
		FilterItem,
		// Token: 0x0402902E RID: 167982
		SortItem,
		// Token: 0x0402902F RID: 167983
		CloseBtn,
		// Token: 0x04029030 RID: 167984
		SelectAllToggle,
		// Token: 0x04029031 RID: 167985
		BtnPhantomManage = 9
	}
}
