using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002BE1 RID: 11233
[NullableContext(1)]
[Nullable(0)]
public class TowerChallengeFormationView : UiViewBase
{
	// Token: 0x0601754A RID: 95562 RVA: 0x005EEB83 File Offset: 0x005ECD83
	public TowerChallengeFormationView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601754B RID: 95563 RVA: 0x005EEBA0 File Offset: 0x005ECDA0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIGridLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickRoleDetailBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickChallengeBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickSkillBranchBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601754C RID: 95564 RVA: 0x005EEE21 File Offset: 0x005ED021
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x0601754D RID: 95565 RVA: 0x005EEE3F File Offset: 0x005ED03F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x0601754E RID: 95566 RVA: 0x005EEE5D File Offset: 0x005ED05D
	protected override void OnBeforeShow()
	{
		this.RemoveSwitchedRoles();
	}

	// Token: 0x0601754F RID: 95567 RVA: 0x005EEE68 File Offset: 0x005ED068
	protected override UniTask OnBeforeStartAsync()
	{
		TowerChallengeFormationView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TowerChallengeFormationView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06017550 RID: 95568 RVA: 0x005EEEAB File Offset: 0x005ED0AB
	private void AddSelectOrder(int roleId)
	{
		this.SelectOrderList.Remove(roleId);
		this.SelectOrderList.Add(roleId);
	}

	// Token: 0x06017551 RID: 95569 RVA: 0x005EEEC6 File Offset: 0x005ED0C6
	private void RemoveSelectOrder(int roleId)
	{
		this.SelectOrderList.Remove(roleId);
	}

	// Token: 0x06017552 RID: 95570 RVA: 0x005EEED8 File Offset: 0x005ED0D8
	private int GetLastSelectedRoleId()
	{
		HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
		for (int i = this.SelectOrderList.Count - 1; i >= 0; i--)
		{
			int num = this.SelectOrderList[i];
			if (selectedRoleSet.Contains(num))
			{
				return num;
			}
		}
		return 0;
	}

	// Token: 0x06017553 RID: 95571 RVA: 0x005EEF24 File Offset: 0x005ED124
	private void ApplyPresetTeam(FormationData formationData)
	{
		List<int> roleIdListWithTrial = formationData.GetRoleIdListWithTrial(false);
		RoleModel instance = RoleModel.Instance;
		foreach (int roleId in roleIdListWithTrial)
		{
			if (instance.IsRoleHasBranch(roleId))
			{
				int roleCurrentBranchId = instance.GetRoleCurrentBranchId(roleId);
				instance.SetRoleSkillBranchGamePlayCache(roleId, roleCurrentBranchId, ESkillBranchCacheType.Tower);
			}
		}
		this.ApplyRoleIdListToTeam(roleIdListWithTrial);
	}

	// Token: 0x06017554 RID: 95572 RVA: 0x005EEF9C File Offset: 0x005ED19C
	public void ApplyRecommendFormation(List<int> roleIdList)
	{
		this.ApplyRoleIdListToTeam(roleIdList);
	}

	// Token: 0x06017555 RID: 95573 RVA: 0x005EEFA8 File Offset: 0x005ED1A8
	private void ApplyRoleIdListToTeam(List<int> roleIdList)
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
		RoleSelectModel.Instance.ClearData();
		this.SelectOrderList.Clear();
		int num = 1;
		foreach (int num2 in roleIdList)
		{
			if (num > 3)
			{
				break;
			}
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num2, true);
			if (roleDataById != null)
			{
				roleIndexMap[num] = roleDataById;
				selectedRoleSet.Add(num2);
				this.AddSelectOrder(num2);
				num++;
			}
		}
		TowerFormationTeamPanel teamPanel = this.TeamPanel;
		if (teamPanel != null)
		{
			teamPanel.RefreshRoleList();
		}
		TowerFormationTeamPanel teamPanel2 = this.TeamPanel;
		if (teamPanel2 != null)
		{
			teamPanel2.RefreshPresetRoleState();
		}
		TowerCurrentTeamRolePanel currentTeamRolePanel = this.CurrentTeamRolePanel;
		if (currentTeamRolePanel != null)
		{
			currentTeamRolePanel.Refresh();
		}
		this.UpdateSkillBranchBtn();
	}

	// Token: 0x06017556 RID: 95574 RVA: 0x005EF090 File Offset: 0x005ED290
	protected override void OnStart()
	{
		this.TitleItem = new TowerTitleItem(base.GetItem(0), delegate()
		{
			bool flag = TowerModel.Instance.CheckInTower();
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.TowerFloorView);
			if (flag && viewByName == null)
			{
				TowerConfig? towerInfo = TowerClimbConfig.Instance.GetTowerInfo(TowerModel.Instance.CurrentSelectFloor);
				UiManager.Instance.OpenView(EUiViewName.TowerFloorView, towerInfo.Value.AreaNum, null);
			}
			base.CloseMe(null);
		});
		this.TitleItem.SetTitleText(TowerModel.Instance.GetFloorNameById(this.TowerId));
		this.BuffShowLayout = new GenericLayout<TowerBuffShowItem, long>(base.GetVerticalLayout(5), new Func<TowerBuffShowItem>(this.InitBuffItem), null, false, true);
		this.TargetStarLayout = new GenericLayout<TowerStarsComplexItem, ValueTuple<bool, TowerTarget>>(base.GetVerticalLayout(6), new Func<TowerStarsComplexItem>(this.InitTargetStarItem), null, false, true);
		this.MonsterLayout = new GenericLayout<TowerMonsterItem, int>(base.GetGridLayout(7), new Func<TowerMonsterItem>(this.InitMonsterItem), null, false, true);
		this.RefreshView();
		this.AddHomeBtnExtraCallback();
	}

	// Token: 0x06017557 RID: 95575 RVA: 0x005EF145 File Offset: 0x005ED345
	private void AddHomeBtnExtraCallback()
	{
		UiBehaviourHomeBtn uiBehaviourHomeBtn = this.UiBehaviourHomeBtn;
		if (uiBehaviourHomeBtn == null)
		{
			return;
		}
		uiBehaviourHomeBtn.AddExtraAsyncCallback(delegate
		{
			TowerChallengeFormationView.<>c.<<AddHomeBtnExtraCallback>b__23_0>d <<AddHomeBtnExtraCallback>b__23_0>d;
			<<AddHomeBtnExtraCallback>b__23_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<AddHomeBtnExtraCallback>b__23_0>d.<>1__state = -1;
			<<AddHomeBtnExtraCallback>b__23_0>d.<>t__builder.Start<TowerChallengeFormationView.<>c.<<AddHomeBtnExtraCallback>b__23_0>d>(ref <<AddHomeBtnExtraCallback>b__23_0>d);
			return <<AddHomeBtnExtraCallback>b__23_0>d.<>t__builder.Task;
		});
	}

	// Token: 0x06017558 RID: 95576 RVA: 0x005EF178 File Offset: 0x005ED378
	private void FillSelectByClearRecord()
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
		RoleSelectModel.Instance.ClearData();
		this.SelectOrderList.Clear();
		List<int> floorFormation = TowerModel.Instance.GetFloorFormation(this.TowerId);
		List<int> currentTowerFormation = TowerModel.Instance.CurrentTowerFormation;
		List<int> list = (floorFormation.Count > 0) ? floorFormation : ((TowerModel.Instance.CheckInTower() && currentTowerFormation != null && currentTowerFormation.Count > 0) ? currentTowerFormation : new List<int>());
		int num = 1;
		foreach (int num2 in list)
		{
			if (num > 3)
			{
				break;
			}
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num2, true);
			if (roleDataById != null)
			{
				roleIndexMap[num] = roleDataById;
				selectedRoleSet.Add(num2);
				this.AddSelectOrder(num2);
				num++;
			}
		}
	}

	// Token: 0x06017559 RID: 95577 RVA: 0x005EF274 File Offset: 0x005ED474
	private void RefreshView()
	{
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(this.TowerId).Value;
		this.BuffShowLayout.RefreshByData(value.ShowBuffs().ToList<long>(), null, false);
		this.MonsterLayout.RefreshByData(value.ShowMonsters().ToList<int>(), null, false);
		this.ElementLayoutItem.Refresh(value.RecommendElement());
		List<ValueTuple<bool, TowerTarget>> list = new List<ValueTuple<bool, TowerTarget>>();
		List<int> floorStarsIndex = TowerModel.Instance.GetFloorStarsIndex(this.TowerId);
		IReadOnlyList<int> readOnlyList = value.TargetConfig();
		for (int i = 0; i < 3; i++)
		{
			if (i < readOnlyList.Count)
			{
				TowerTarget? targetConfig = TowerClimbConfig.Instance.GetTargetConfig(readOnlyList[i]);
				ValueTuple<bool, TowerTarget> item = new ValueTuple<bool, TowerTarget>(floorStarsIndex != null && floorStarsIndex.Contains(i), targetConfig.Value);
				list.Add(item);
			}
		}
		this.TargetStarLayout.RefreshByData(list, null, false);
		base.GetText(9).SetText(value.Cost.ToString() ?? "", true);
		TowerFloorInfo floorData = TowerModel.Instance.GetFloorData(this.TowerId);
		base.GetItem(3).SetUIActive(floorData != null && floorData.IsQuickPass);
		this.UpdateSkillBranchBtn();
	}

	// Token: 0x0601755A RID: 95578 RVA: 0x005EF3B8 File Offset: 0x005ED5B8
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRoleDetailViewClose));
		RoleSelectModel.Instance.ClearData();
		this.SelectOrderList.Clear();
		TowerTitleItem titleItem = this.TitleItem;
		if (titleItem != null)
		{
			titleItem.Destroy(null);
		}
		this.TitleItem = null;
		TowerElementLayoutItem elementLayoutItem = this.ElementLayoutItem;
		if (elementLayoutItem != null)
		{
			elementLayoutItem.Destroy(null);
		}
		this.ElementLayoutItem = null;
		TowerFormationTeamPanel teamPanel = this.TeamPanel;
		if (teamPanel != null)
		{
			teamPanel.Destroy(null);
		}
		this.TeamPanel = null;
		TowerCurrentTeamRolePanel currentTeamRolePanel = this.CurrentTeamRolePanel;
		if (currentTeamRolePanel != null)
		{
			currentTeamRolePanel.Destroy(null);
		}
		this.CurrentTeamRolePanel = null;
		this.BuffShowLayout = null;
		this.TargetStarLayout = null;
		this.MonsterLayout = null;
	}

	// Token: 0x0601755B RID: 95579 RVA: 0x005EF46C File Offset: 0x005ED66C
	private TowerBuffShowItem InitBuffItem()
	{
		return new TowerBuffShowItem();
	}

	// Token: 0x0601755C RID: 95580 RVA: 0x005EF473 File Offset: 0x005ED673
	private TowerStarsComplexItem InitTargetStarItem()
	{
		return new TowerStarsComplexItem();
	}

	// Token: 0x0601755D RID: 95581 RVA: 0x005EF47A File Offset: 0x005ED67A
	private TowerMonsterItem InitMonsterItem()
	{
		return new TowerMonsterItem();
	}

	// Token: 0x0601755E RID: 95582 RVA: 0x005EF484 File Offset: 0x005ED684
	private void OnClickRoleDetailBtn()
	{
		List<int> selectedRoleIdList = this.GetSelectedRoleIdList();
		TowerFormationTeamPanel teamPanel = this.TeamPanel;
		List<int> list = ((teamPanel != null) ? teamPanel.GetRoleIdList() : null) ?? new List<int>();
		if (list.Count == 0)
		{
			return;
		}
		HashSet<int> selectedSet = new HashSet<int>(selectedRoleIdList);
		List<int> list2 = new List<int>(selectedRoleIdList);
		list2.AddRange(from roleId in list
		where !selectedSet.Contains(roleId)
		select roleId);
		RoleModel.Instance.StartGamePlayRoleEdit(ESkillBranchCacheType.Tower);
		RoleModel.Instance.StartRecordRoleSkillBranchChangeRequest();
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRoleDetailViewClose));
		RoleController.Instance.OpenRoleMainViewByParam(new OpenRoleMainViewData
		{
			AgentType = ERoleAgentType.Normal,
			RoleIdList = list2,
			SelectRoleId = new int?(this.GetLastSelectedRoleId()),
			TeamPositionType = new ETeamPositionType?(ETeamPositionType.EditFormation)
		});
	}

	// Token: 0x0601755F RID: 95583 RVA: 0x005EF558 File Offset: 0x005ED758
	private void OnRoleDetailViewClose(EUiViewName viewName, int _)
	{
		if (viewName != EUiViewName.RoleRootView)
		{
			return;
		}
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnRoleDetailViewClose));
		List<int> list = RoleModel.Instance.StopRecordRoleSkillBranchChangeRequest();
		foreach (int roleId in list)
		{
			this.OnRoleSkillBranchChanged(roleId);
		}
		if (list.Count > 0)
		{
			TowerFormationTeamPanel teamPanel = this.TeamPanel;
			if (teamPanel == null)
			{
				return;
			}
			teamPanel.RefreshPresetRoleState();
		}
	}

	// Token: 0x06017560 RID: 95584 RVA: 0x005EF5F4 File Offset: 0x005ED7F4
	private void OnClickChallengeBtn()
	{
		List<int> selectedRoleIdList = this.GetSelectedRoleIdList();
		if (selectedRoleIdList.Count == 0)
		{
			ScrollingTipsController.Instance.ShowTipsById("NoRole", Array.Empty<object>());
			return;
		}
		TowerController.Instance.TowerStartRequest(this.TowerId, selectedRoleIdList, true).Forget();
	}

	// Token: 0x06017561 RID: 95585 RVA: 0x005EF63C File Offset: 0x005ED83C
	private void OnClickSkillBranchBtn()
	{
		List<int> selectedRoleIdList = this.GetSelectedRoleIdList();
		if (selectedRoleIdList.Count == 0)
		{
			return;
		}
		RoleSkillBranchPopViewParams roleSkillBranchPopViewParams = new RoleSkillBranchPopViewParams();
		roleSkillBranchPopViewParams.Load(new int[][]
		{
			selectedRoleIdList.ToArray()
		});
		UiManager.Instance.OpenView(EUiViewName.RoleSkillBranchPopView, roleSkillBranchPopViewParams, null);
	}

	// Token: 0x06017562 RID: 95586 RVA: 0x005EF688 File Offset: 0x005ED888
	private List<int> GetSelectedRoleIdList()
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		List<int> list = new List<int>();
		foreach (int key in from k in roleIndexMap.Keys
		orderby k
		select k)
		{
			list.Add(roleIndexMap[key].GetDataId());
		}
		return list;
	}

	// Token: 0x06017563 RID: 95587 RVA: 0x005EF718 File Offset: 0x005ED918
	private void UpdateSkillBranchBtn()
	{
		bool uiactive = this.GetSelectedRoleIdList().Any((int roleId) => roleId > 0 && RoleModel.Instance.IsRoleHasBranch(roleId));
		UUIButtonComponent button = base.GetButton(12);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06017564 RID: 95588 RVA: 0x005EF770 File Offset: 0x005ED970
	private void OnRoleSkillBranchChanged(int roleId)
	{
		TowerFormationTeamPanel teamPanel = this.TeamPanel;
		if (teamPanel != null)
		{
			teamPanel.RefreshRole(roleId);
		}
		TowerCurrentTeamRolePanel currentTeamRolePanel = this.CurrentTeamRolePanel;
		if (currentTeamRolePanel == null)
		{
			return;
		}
		currentTeamRolePanel.Refresh();
	}

	// Token: 0x06017565 RID: 95589 RVA: 0x005EF794 File Offset: 0x005ED994
	private void RemoveSwitchedRoles()
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (RoleInstance roleInstance in RoleModel.Instance.GetRoleList())
		{
			hashSet.Add(roleInstance.GetDataId());
		}
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, RoleDataBase> keyValuePair in roleIndexMap)
		{
			int dataId = keyValuePair.Value.GetDataId();
			if (!hashSet.Contains(dataId))
			{
				list.Add(dataId);
			}
		}
		if (list.Count == 0)
		{
			TowerFormationTeamPanel teamPanel = this.TeamPanel;
			if (teamPanel == null || !teamPanel.IsRoleListStale())
			{
				return;
			}
		}
		foreach (int roleId in list)
		{
			this.BenchRole(roleId);
		}
		TowerFormationTeamPanel teamPanel2 = this.TeamPanel;
		if (teamPanel2 != null)
		{
			teamPanel2.RebuildRoleList();
		}
		TowerFormationTeamPanel teamPanel3 = this.TeamPanel;
		if (teamPanel3 != null)
		{
			teamPanel3.RefreshPresetRoleState();
		}
		TowerCurrentTeamRolePanel currentTeamRolePanel = this.CurrentTeamRolePanel;
		if (currentTeamRolePanel != null)
		{
			currentTeamRolePanel.Refresh();
		}
		this.UpdateSkillBranchBtn();
	}

	// Token: 0x06017566 RID: 95590 RVA: 0x005EF8D4 File Offset: 0x005EDAD4
	private void BenchRole(int roleId)
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		HashSet<int> selectedRoleSet = RoleSelectModel.Instance.SelectedRoleSet;
		foreach (KeyValuePair<int, RoleDataBase> keyValuePair in roleIndexMap)
		{
			if (keyValuePair.Value.GetDataId() == roleId)
			{
				roleIndexMap.Remove(keyValuePair.Key);
				selectedRoleSet.Remove(roleId);
				break;
			}
		}
		this.RemoveSelectOrder(roleId);
	}

	// Token: 0x0400AEB1 RID: 44721
	private int TowerId = -1;

	// Token: 0x0400AEB2 RID: 44722
	[Nullable(2)]
	private TowerTitleItem TitleItem;

	// Token: 0x0400AEB3 RID: 44723
	[Nullable(2)]
	private TowerElementLayoutItem ElementLayoutItem;

	// Token: 0x0400AEB4 RID: 44724
	[Nullable(2)]
	private TowerFormationTeamPanel TeamPanel;

	// Token: 0x0400AEB5 RID: 44725
	[Nullable(2)]
	private TowerCurrentTeamRolePanel CurrentTeamRolePanel;

	// Token: 0x0400AEB6 RID: 44726
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerBuffShowItem, long> BuffShowLayout;

	// Token: 0x0400AEB7 RID: 44727
	[Nullable(new byte[]
	{
		2,
		1,
		0
	})]
	private GenericLayout<TowerStarsComplexItem, ValueTuple<bool, TowerTarget>> TargetStarLayout;

	// Token: 0x0400AEB8 RID: 44728
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerMonsterItem, int> MonsterLayout;

	// Token: 0x0400AEB9 RID: 44729
	private readonly List<int> SelectOrderList = new List<int>();

	// Token: 0x02009199 RID: 37273
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402F1D0 RID: 192976
		CaptionItem,
		// Token: 0x0402F1D1 RID: 192977
		TeamItem,
		// Token: 0x0402F1D2 RID: 192978
		LevelInfoItem,
		// Token: 0x0402F1D3 RID: 192979
		QuickPassItem,
		// Token: 0x0402F1D4 RID: 192980
		ElementItem,
		// Token: 0x0402F1D5 RID: 192981
		ShowBuffLayout,
		// Token: 0x0402F1D6 RID: 192982
		TargetStarLayout,
		// Token: 0x0402F1D7 RID: 192983
		MonsterLayout,
		// Token: 0x0402F1D8 RID: 192984
		CurrentTeamRoleItem,
		// Token: 0x0402F1D9 RID: 192985
		CostText,
		// Token: 0x0402F1DA RID: 192986
		ChallengeBtn,
		// Token: 0x0402F1DB RID: 192987
		RoleDetailBtn,
		// Token: 0x0402F1DC RID: 192988
		BtnSkillBranch,
		// Token: 0x0402F1DD RID: 192989
		BgTexture
	}
}
