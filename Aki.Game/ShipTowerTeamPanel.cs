using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029D9 RID: 10713
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerTeamPanel : UiPanelBase
{
	// Token: 0x0601631A RID: 90906 RVA: 0x0059D050 File Offset: 0x0059B250
	public UniTask Init(UUIItem item, ShipTowerStageData data)
	{
		ShipTowerTeamPanel.<Init>d__15 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.data = data;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ShipTowerTeamPanel.<Init>d__15>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0601631B RID: 90907 RVA: 0x0059D0A4 File Offset: 0x0059B2A4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnTeamEditClick))
		};
	}

	// Token: 0x0601631C RID: 90908 RVA: 0x0059D150 File Offset: 0x0059B350
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerTeamPanel.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerTeamPanel.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601631D RID: 90909 RVA: 0x0059D194 File Offset: 0x0059B394
	private void TeamTabFinish()
	{
		foreach (KeyValuePair<int, ShipTowerTeamTabItem> keyValuePair in this.TabComponent.GetTabItemMap())
		{
			int key = keyValuePair.Key;
			keyValuePair.Value.UpdateName(this.TeamTabList[key].Title);
		}
		this.TabComponent.SelectToggleByIndex(0, true, true);
	}

	// Token: 0x0601631E RID: 90910 RVA: 0x0059D218 File Offset: 0x0059B418
	protected override void OnBeforeShow()
	{
		this.ToggleTwoTabCallBack(this.CurSelectTabIndex);
	}

	// Token: 0x0601631F RID: 90911 RVA: 0x0059D226 File Offset: 0x0059B426
	protected override void OnAfterShow()
	{
		EventSystem.Instance.Emit(EEventName.ShipTowerTeamPanelShown);
	}

	// Token: 0x06016320 RID: 90912 RVA: 0x0059D238 File Offset: 0x0059B438
	public void UpdateViewAndShow(ShipTowerTeamData teamData)
	{
		this.CurTeamData = teamData;
		if (base.GetActive())
		{
			this.ToggleTwoTabCallBack(this.CurSelectTabIndex);
			return;
		}
		this.SetActive(true);
	}

	// Token: 0x06016321 RID: 90913 RVA: 0x0059D25D File Offset: 0x0059B45D
	protected override void OnBeforeDestroy()
	{
		this.TabComponent = null;
		this.FilterComponent = null;
	}

	// Token: 0x06016322 RID: 90914 RVA: 0x0059D26D File Offset: 0x0059B46D
	private ShipTowerTeamTabItem TabItemProxyCreate([Nullable(2)] UUIItem item, int? index)
	{
		return new ShipTowerTeamTabItem();
	}

	// Token: 0x06016323 RID: 90915 RVA: 0x0059D274 File Offset: 0x0059B474
	private void ToggleTwoTabCallBack(int index)
	{
		if (base.IsStartOrStarting)
		{
			return;
		}
		this.CurSelectTabIndex = index;
		Log.Instance.Info(ELogModule.ShipTower, ELogAuthor.CX, "二级页签点击回调: " + this.CurSelectTabIndex.ToString(), default(ReadOnlySpan<ValueTuple<string, object>>));
		int curSelectTabIndex = this.CurSelectTabIndex;
		if (curSelectTabIndex == 0)
		{
			this.UpdateRoleList();
			return;
		}
		if (curSelectTabIndex != 1)
		{
			return;
		}
		this.UpdateTeamList();
	}

	// Token: 0x06016324 RID: 90916 RVA: 0x0059D2DC File Offset: 0x0059B4DC
	public void UpdateRoleListByMainRoleChange()
	{
		RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
		List<RoleDataBase> list = new List<RoleDataBase>();
		foreach (RoleInstance item in roleList)
		{
			list.Add(item);
		}
		FilterSortEntrance<RoleDataBase> filterComponent = this.FilterComponent;
		if (filterComponent != null)
		{
			filterComponent.UpdateData(EFilterSortGroupId.ShipTower, list, Array.Empty<object>());
		}
		if (this.TeamList != null)
		{
			this.TeamList = ShipTowerModel.Instance.GetPlayerTeamList();
		}
	}

	// Token: 0x06016325 RID: 90917 RVA: 0x0059D344 File Offset: 0x0059B544
	private void UpdateRoleList()
	{
		base.GetScrollViewWithScrollbar(2).RootUIComp.Get().SetUIActive(true);
		base.GetScrollViewWithScrollbar(1).RootUIComp.Get().SetUIActive(false);
		FilterSortEntrance<RoleDataBase> filterComponent = this.FilterComponent;
		if (filterComponent != null)
		{
			filterComponent.SetActive(true);
		}
		base.GetButton(4).RootUIComp.Get().SetUIActive(false);
		this.UpdateRoleListFilter();
	}

	// Token: 0x06016326 RID: 90918 RVA: 0x0059D3B8 File Offset: 0x0059B5B8
	public void UpdateRoleListFilter()
	{
		int filterId = FilterConfig.Instance.GetFilterId(EFilterSortGroupId.ShipTower);
		EventSystem.Instance.Emit<int>(EEventName.OnFilterDataUpdate, filterId);
	}

	// Token: 0x06016327 RID: 90919 RVA: 0x0059D3E4 File Offset: 0x0059B5E4
	private void UpdateTeamList()
	{
		base.GetScrollViewWithScrollbar(2).RootUIComp.Get().SetUIActive(false);
		base.GetScrollViewWithScrollbar(1).RootUIComp.Get().SetUIActive(true);
		FilterSortEntrance<RoleDataBase> filterComponent = this.FilterComponent;
		if (filterComponent != null)
		{
			filterComponent.SetActive(false);
		}
		base.GetButton(4).RootUIComp.Get().SetUIActive(true);
		this.TeamList = ShipTowerModel.Instance.GetPlayerTeamList();
		GenericScrollViewNew<ShipTowerRoleTeamItem, FormationData> teamScrollView = this.TeamScrollView;
		if (teamScrollView != null)
		{
			teamScrollView.SelectGridProxy(-1, false);
		}
		this.OnlyUpdateTeamList();
	}

	// Token: 0x06016328 RID: 90920 RVA: 0x0059D47A File Offset: 0x0059B67A
	public void OnlyUpdateTeamList()
	{
		GenericScrollViewNew<ShipTowerRoleTeamItem, FormationData> teamScrollView = this.TeamScrollView;
		if (teamScrollView != null)
		{
			teamScrollView.RefreshByData(this.TeamList, null, false);
		}
		UUIItem emptyStateItem = this.EmptyStateItem;
		if (emptyStateItem == null)
		{
			return;
		}
		emptyStateItem.SetUIActive(false);
	}

	// Token: 0x06016329 RID: 90921 RVA: 0x0059D4A6 File Offset: 0x0059B6A6
	public void UpdateTeamListByIndex(int index)
	{
		GenericScrollViewNew<ShipTowerRoleTeamItem, FormationData> teamScrollView = this.TeamScrollView;
		if (teamScrollView == null)
		{
			return;
		}
		ShipTowerRoleTeamItem scrollItemByIndex = teamScrollView.GetScrollItemByIndex(index);
		if (scrollItemByIndex == null)
		{
			return;
		}
		scrollItemByIndex.Refresh(this.TeamList[index], false, index);
	}

	// Token: 0x0601632A RID: 90922 RVA: 0x0059D4D4 File Offset: 0x0059B6D4
	private void OnFilterSort(List<RoleDataBase> dataList, bool isOutSideChange, EFilterSortType operationType)
	{
		this.RoleList = dataList;
		GenericScrollViewNew<ShipTowerRoleGrid, RoleDataBase> roleScrollView = this.RoleScrollView;
		if (roleScrollView != null)
		{
			roleScrollView.RefreshByData(this.RoleList, null, false);
		}
		UUIItem emptyStateItem = this.EmptyStateItem;
		if (emptyStateItem != null)
		{
			emptyStateItem.SetUIActive(this.RoleList.Count <= 0);
		}
		Action roleListUpdateCallback = this.RoleListUpdateCallback;
		if (roleListUpdateCallback == null)
		{
			return;
		}
		roleListUpdateCallback();
	}

	// Token: 0x0601632B RID: 90923 RVA: 0x0059D533 File Offset: 0x0059B733
	private ShipTowerRoleGrid OnGridProxyCreate()
	{
		ShipTowerRoleGrid shipTowerRoleGrid = new ShipTowerRoleGrid();
		shipTowerRoleGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		shipTowerRoleGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return shipTowerRoleGrid;
	}

	// Token: 0x0601632C RID: 90924 RVA: 0x0059D55E File Offset: 0x0059B75E
	private ShipTowerRoleTeamItem OnTeamGridProxyCreate()
	{
		return new ShipTowerRoleTeamItem
		{
			OnClickCallback = this.TeamSelectCallBack,
			StageData = this.StageData
		};
	}

	// Token: 0x0601632D RID: 90925 RVA: 0x0059D580 File Offset: 0x0059B780
	protected void ToggleFunction(MediumItemGridExtendCallback params_)
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
		RoleDataBase roleDataBase = (RoleDataBase)params_.Data;
		bool flag = params_.State == EToggleState.ETT_Checked;
		if (flag)
		{
			for (int i = 1; i <= 3; i++)
			{
				int roleIndexInAllTeam = this.CurTeamData.GetRoleIndexInAllTeam(i);
				if (!roleIndexMap.ContainsKey(roleIndexInAllTeam))
				{
					roleIndexMap[roleIndexInAllTeam] = roleDataBase;
					selectedRoleSet.Add(roleDataBase.GetDataId());
					break;
				}
			}
		}
		else
		{
			int? num = null;
			foreach (KeyValuePair<int, RoleDataBase> keyValuePair in roleIndexMap)
			{
				if (keyValuePair.Value == roleDataBase)
				{
					num = new int?(keyValuePair.Key);
					break;
				}
			}
			if (num != null)
			{
				roleIndexMap.Remove(num.Value);
				selectedRoleSet.Remove(roleDataBase.GetDataId());
			}
		}
		int num2 = this.RoleList.IndexOf(roleDataBase);
		Action<RoleDataBase> roleSelectCallBack = this.RoleSelectCallBack;
		if (roleSelectCallBack != null)
		{
			roleSelectCallBack(roleDataBase);
		}
		ShipTowerRoleGrid scrollItemByIndex = this.RoleScrollView.GetScrollItemByIndex(num2);
		if (scrollItemByIndex == null)
		{
			return;
		}
		scrollItemByIndex.Refresh(roleDataBase, flag, num2);
	}

	// Token: 0x0601632E RID: 90926 RVA: 0x0059D6BC File Offset: 0x0059B8BC
	protected bool CanExecuteChangeFunction(object data, bool isForceSelected, EToggleState state)
	{
		RoleDataBase roleDataBase = (RoleDataBase)data;
		if (ShipTowerModel.Instance.IsOtherTeamRoleData(roleDataBase.GetDataId()))
		{
			return true;
		}
		if (state != EToggleState.ETT_UnChecked)
		{
			return true;
		}
		if (this.RoleIsFull())
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamRoleFull", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x0601632F RID: 90927 RVA: 0x0059D708 File Offset: 0x0059B908
	private bool RoleIsFull()
	{
		for (int i = 1; i <= 3; i++)
		{
			int roleIndexInAllTeam = this.CurTeamData.GetRoleIndexInAllTeam(i);
			if (!RoleSelectModel.Instance.RoleIndexMap.ContainsKey(roleIndexInAllTeam))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06016330 RID: 90928 RVA: 0x0059D744 File Offset: 0x0059B944
	public List<int> GetRoleIdList()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.RoleList.Count; i++)
		{
			list.Add(this.RoleList[i].GetDataId());
		}
		return list;
	}

	// Token: 0x06016331 RID: 90929 RVA: 0x0059D788 File Offset: 0x0059B988
	private void OnTeamEditClick()
	{
		bool flag = false;
		FormationController.Instance.OpenFormationView(flag, null);
	}

	// Token: 0x06016332 RID: 90930 RVA: 0x0059D7A8 File Offset: 0x0059B9A8
	public void RefreshRole(int roleId)
	{
		int num = this.RoleList.FindIndex((RoleDataBase roleData) => roleData.GetDataId() == roleId);
		if (num < 0)
		{
			return;
		}
		ShipTowerRoleGrid scrollItemByIndex = this.RoleScrollView.GetScrollItemByIndex(num);
		if (scrollItemByIndex == null)
		{
			return;
		}
		scrollItemByIndex.Refresh(this.RoleList[num], false, num);
	}

	// Token: 0x06016333 RID: 90931 RVA: 0x0059D804 File Offset: 0x0059BA04
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		TabComponent<ShipTowerTeamTabItem> tabComponent = this.TabComponent;
		ShipTowerTeamTabItem shipTowerTeamTabItem = (tabComponent != null) ? tabComponent.GetTabItemByIndex(1) : null;
		UUIItem uuiitem = (shipTowerTeamTabItem != null) ? shipTowerTeamTabItem.GetRootItem() : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x0400A536 RID: 42294
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<ShipTowerTeamTabItem> TabComponent;

	// Token: 0x0400A537 RID: 42295
	private int CurSelectTabIndex;

	// Token: 0x0400A538 RID: 42296
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterComponent;

	// Token: 0x0400A539 RID: 42297
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ShipTowerRoleGrid, RoleDataBase> RoleScrollView;

	// Token: 0x0400A53A RID: 42298
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ShipTowerRoleTeamItem, FormationData> TeamScrollView;

	// Token: 0x0400A53B RID: 42299
	private List<RoleDataBase> RoleList = new List<RoleDataBase>();

	// Token: 0x0400A53C RID: 42300
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FormationData> TeamList;

	// Token: 0x0400A53D RID: 42301
	private ShipTowerStageData StageData;

	// Token: 0x0400A53E RID: 42302
	private List<ShipTowerTeamTab> TeamTabList;

	// Token: 0x0400A53F RID: 42303
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleDataBase> RoleSelectCallBack;

	// Token: 0x0400A540 RID: 42304
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FormationData> TeamSelectCallBack;

	// Token: 0x0400A541 RID: 42305
	[Nullable(2)]
	private ShipTowerTeamData CurTeamData;

	// Token: 0x0400A542 RID: 42306
	[Nullable(2)]
	public UUIItem EmptyStateItem;

	// Token: 0x0400A543 RID: 42307
	[Nullable(2)]
	public Action RoleListUpdateCallback;

	// Token: 0x02009003 RID: 36867
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402EA1C RID: 191004
		public const int ItemTabComponent = 0;

		// Token: 0x0402EA1D RID: 191005
		public const int ScrollBarTeam = 1;

		// Token: 0x0402EA1E RID: 191006
		public const int ScrollBarRole = 2;

		// Token: 0x0402EA1F RID: 191007
		public const int ItemFilter = 3;

		// Token: 0x0402EA20 RID: 191008
		public const int TeamEditButton = 4;
	}
}
