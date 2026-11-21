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

// Token: 0x02001F54 RID: 8020
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerTeamPanel : UiPanelBase
{
	// Token: 0x06013D20 RID: 81184 RVA: 0x005C8008 File Offset: 0x005C6208
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

	// Token: 0x06013D21 RID: 81185 RVA: 0x005C805C File Offset: 0x005C625C
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

	// Token: 0x06013D22 RID: 81186 RVA: 0x005C8108 File Offset: 0x005C6308
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerTeamPanel.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerTeamPanel.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013D23 RID: 81187 RVA: 0x005C814C File Offset: 0x005C634C
	private void TeamTabFinish()
	{
		foreach (KeyValuePair<int, ShipTowerTeamTabItem> keyValuePair in this.TabComponent.GetTabItemMap())
		{
			int key = keyValuePair.Key;
			keyValuePair.Value.UpdateName(this.TeamTabList[key].Title);
		}
		this.TabComponent.SelectToggleByIndex(0, true, true);
	}

	// Token: 0x06013D24 RID: 81188 RVA: 0x005C81D0 File Offset: 0x005C63D0
	protected override void OnBeforeShow()
	{
		this.ToggleTwoTabCallBack(this.CurSelectTabIndex);
	}

	// Token: 0x06013D25 RID: 81189 RVA: 0x005C81DE File Offset: 0x005C63DE
	protected override void OnAfterShow()
	{
		EventSystem.Instance.Emit(EEventName.ShipTowerTeamPanelShown);
	}

	// Token: 0x06013D26 RID: 81190 RVA: 0x005C81F0 File Offset: 0x005C63F0
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

	// Token: 0x06013D27 RID: 81191 RVA: 0x005C8215 File Offset: 0x005C6415
	protected override void OnBeforeDestroy()
	{
		this.TabComponent = null;
		this.FilterComponent = null;
	}

	// Token: 0x06013D28 RID: 81192 RVA: 0x005C8225 File Offset: 0x005C6425
	private ShipTowerTeamTabItem TabItemProxyCreate([Nullable(2)] UUIItem item, int? index)
	{
		return new ShipTowerTeamTabItem();
	}

	// Token: 0x06013D29 RID: 81193 RVA: 0x005C822C File Offset: 0x005C642C
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

	// Token: 0x06013D2A RID: 81194 RVA: 0x005C8294 File Offset: 0x005C6494
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

	// Token: 0x06013D2B RID: 81195 RVA: 0x005C82FC File Offset: 0x005C64FC
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

	// Token: 0x06013D2C RID: 81196 RVA: 0x005C8370 File Offset: 0x005C6570
	public void UpdateRoleListFilter()
	{
		int filterId = FilterConfig.Instance.GetFilterId(EFilterSortGroupId.ShipTower);
		EventSystem.Instance.Emit<int>(EEventName.OnFilterDataUpdate, filterId);
	}

	// Token: 0x06013D2D RID: 81197 RVA: 0x005C839C File Offset: 0x005C659C
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

	// Token: 0x06013D2E RID: 81198 RVA: 0x005C8432 File Offset: 0x005C6632
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

	// Token: 0x06013D2F RID: 81199 RVA: 0x005C845E File Offset: 0x005C665E
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

	// Token: 0x06013D30 RID: 81200 RVA: 0x005C848C File Offset: 0x005C668C
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

	// Token: 0x06013D31 RID: 81201 RVA: 0x005C84EB File Offset: 0x005C66EB
	private ShipTowerRoleGrid OnGridProxyCreate()
	{
		ShipTowerRoleGrid shipTowerRoleGrid = new ShipTowerRoleGrid();
		shipTowerRoleGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		shipTowerRoleGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return shipTowerRoleGrid;
	}

	// Token: 0x06013D32 RID: 81202 RVA: 0x005C8516 File Offset: 0x005C6716
	private ShipTowerRoleTeamItem OnTeamGridProxyCreate()
	{
		return new ShipTowerRoleTeamItem
		{
			OnClickCallback = this.TeamSelectCallBack,
			StageData = this.StageData
		};
	}

	// Token: 0x06013D33 RID: 81203 RVA: 0x005C8538 File Offset: 0x005C6738
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

	// Token: 0x06013D34 RID: 81204 RVA: 0x005C8674 File Offset: 0x005C6874
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

	// Token: 0x06013D35 RID: 81205 RVA: 0x005C86C0 File Offset: 0x005C68C0
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

	// Token: 0x06013D36 RID: 81206 RVA: 0x005C86FC File Offset: 0x005C68FC
	public List<int> GetRoleIdList()
	{
		List<int> list = new List<int>();
		for (int i = 0; i < this.RoleList.Count; i++)
		{
			list.Add(this.RoleList[i].GetDataId());
		}
		return list;
	}

	// Token: 0x06013D37 RID: 81207 RVA: 0x005C8740 File Offset: 0x005C6940
	private void OnTeamEditClick()
	{
		bool flag = false;
		FormationController.Instance.OpenFormationView(flag, null);
	}

	// Token: 0x06013D38 RID: 81208 RVA: 0x005C8760 File Offset: 0x005C6960
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

	// Token: 0x06013D39 RID: 81209 RVA: 0x005C87BC File Offset: 0x005C69BC
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

	// Token: 0x0400A920 RID: 43296
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<ShipTowerTeamTabItem> TabComponent;

	// Token: 0x0400A921 RID: 43297
	private int CurSelectTabIndex;

	// Token: 0x0400A922 RID: 43298
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterComponent;

	// Token: 0x0400A923 RID: 43299
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ShipTowerRoleGrid, RoleDataBase> RoleScrollView;

	// Token: 0x0400A924 RID: 43300
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ShipTowerRoleTeamItem, FormationData> TeamScrollView;

	// Token: 0x0400A925 RID: 43301
	private List<RoleDataBase> RoleList = new List<RoleDataBase>();

	// Token: 0x0400A926 RID: 43302
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FormationData> TeamList;

	// Token: 0x0400A927 RID: 43303
	private ShipTowerStageData StageData;

	// Token: 0x0400A928 RID: 43304
	private List<ShipTowerTeamTab> TeamTabList;

	// Token: 0x0400A929 RID: 43305
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<RoleDataBase> RoleSelectCallBack;

	// Token: 0x0400A92A RID: 43306
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FormationData> TeamSelectCallBack;

	// Token: 0x0400A92B RID: 43307
	[Nullable(2)]
	private ShipTowerTeamData CurTeamData;

	// Token: 0x0400A92C RID: 43308
	[Nullable(2)]
	public UUIItem EmptyStateItem;

	// Token: 0x0400A92D RID: 43309
	[Nullable(2)]
	public Action RoleListUpdateCallback;

	// Token: 0x0200824A RID: 33354
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A114 RID: 172308
		public const int ItemTabComponent = 0;

		// Token: 0x0402A115 RID: 172309
		public const int ScrollBarTeam = 1;

		// Token: 0x0402A116 RID: 172310
		public const int ScrollBarRole = 2;

		// Token: 0x0402A117 RID: 172311
		public const int ItemFilter = 3;

		// Token: 0x0402A118 RID: 172312
		public const int TeamEditButton = 4;
	}
}
