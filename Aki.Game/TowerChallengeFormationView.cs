using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200215C RID: 8540
[NullableContext(1)]
[Nullable(0)]
public class TowerChallengeFormationView : UiViewBase
{
	// Token: 0x06014F7B RID: 85883 RVA: 0x0061B6C3 File Offset: 0x006198C3
	public TowerChallengeFormationView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014F7C RID: 85884 RVA: 0x0061B6E0 File Offset: 0x006198E0
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

	// Token: 0x06014F7D RID: 85885 RVA: 0x0061B961 File Offset: 0x00619B61
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x06014F7E RID: 85886 RVA: 0x0061B97F File Offset: 0x00619B7F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x06014F7F RID: 85887 RVA: 0x0061B99D File Offset: 0x00619B9D
	protected override void OnBeforeShow()
	{
		this.RemoveSwitchedRoles();
	}

	// Token: 0x06014F80 RID: 85888 RVA: 0x0061B9A8 File Offset: 0x00619BA8
	protected override UniTask OnBeforeStartAsync()
	{
		TowerChallengeFormationView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TowerChallengeFormationView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014F81 RID: 85889 RVA: 0x0061B9EB File Offset: 0x00619BEB
	private void AddSelectOrder(int roleId)
	{
		this.SelectOrderList.Remove(roleId);
		this.SelectOrderList.Add(roleId);
	}

	// Token: 0x06014F82 RID: 85890 RVA: 0x0061BA06 File Offset: 0x00619C06
	private void RemoveSelectOrder(int roleId)
	{
		this.SelectOrderList.Remove(roleId);
	}

	// Token: 0x06014F83 RID: 85891 RVA: 0x0061BA18 File Offset: 0x00619C18
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

	// Token: 0x06014F84 RID: 85892 RVA: 0x0061BA64 File Offset: 0x00619C64
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

	// Token: 0x06014F85 RID: 85893 RVA: 0x0061BADC File Offset: 0x00619CDC
	public void ApplyRecommendFormation(List<int> roleIdList)
	{
		this.ApplyRoleIdListToTeam(roleIdList);
	}

	// Token: 0x06014F86 RID: 85894 RVA: 0x0061BAE8 File Offset: 0x00619CE8
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

	// Token: 0x06014F87 RID: 85895 RVA: 0x0061BBD0 File Offset: 0x00619DD0
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

	// Token: 0x06014F88 RID: 85896 RVA: 0x0061BC85 File Offset: 0x00619E85
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

	// Token: 0x06014F89 RID: 85897 RVA: 0x0061BCB8 File Offset: 0x00619EB8
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

	// Token: 0x06014F8A RID: 85898 RVA: 0x0061BDB4 File Offset: 0x00619FB4
	private void RefreshView()
	{
		TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(this.TowerId).Value;
		this.BuffShowLayout.RefreshByData(value.ShowBuffs(), null, false);
		this.MonsterLayout.RefreshByData(value.ShowMonsters(), null, false);
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

	// Token: 0x06014F8B RID: 85899 RVA: 0x0061BEF0 File Offset: 0x0061A0F0
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

	// Token: 0x06014F8C RID: 85900 RVA: 0x0061BFA4 File Offset: 0x0061A1A4
	private TowerBuffShowItem InitBuffItem()
	{
		return new TowerBuffShowItem();
	}

	// Token: 0x06014F8D RID: 85901 RVA: 0x0061BFAB File Offset: 0x0061A1AB
	private TowerStarsComplexItem InitTargetStarItem()
	{
		return new TowerStarsComplexItem();
	}

	// Token: 0x06014F8E RID: 85902 RVA: 0x0061BFB2 File Offset: 0x0061A1B2
	private TowerMonsterItem InitMonsterItem()
	{
		return new TowerMonsterItem();
	}

	// Token: 0x06014F8F RID: 85903 RVA: 0x0061BFBC File Offset: 0x0061A1BC
	private void OnClickRoleDetailBtn()
	{
		List<int> selectedRoleIdList = this.GetSelectedRoleIdList();
		TowerFormationTeamPanel teamPanel = this.TeamPanel;
		List<int> list = ((teamPanel != null) ? teamPanel.GetRoleIdList() : null) ?? new List<int>();
		if (list.Count == 0)
		{
			return;
		}
		HashSet<int> hashSet = new HashSet<int>(selectedRoleIdList);
		List<int> list2 = new List<int>(selectedRoleIdList);
		foreach (int item in list)
		{
			if (!hashSet.Contains(item))
			{
				list2.Add(item);
			}
		}
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

	// Token: 0x06014F90 RID: 85904 RVA: 0x0061C0BC File Offset: 0x0061A2BC
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

	// Token: 0x06014F91 RID: 85905 RVA: 0x0061C158 File Offset: 0x0061A358
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

	// Token: 0x06014F92 RID: 85906 RVA: 0x0061C1A0 File Offset: 0x0061A3A0
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

	// Token: 0x06014F93 RID: 85907 RVA: 0x0061C1EC File Offset: 0x0061A3EC
	private List<int> GetSelectedRoleIdList()
	{
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		List<int> list = new List<int>();
		List<int> list2 = new List<int>(roleIndexMap.Keys);
		list2.Sort();
		foreach (int key in list2)
		{
			list.Add(roleIndexMap[key].GetDataId());
		}
		return list;
	}

	// Token: 0x06014F94 RID: 85908 RVA: 0x0061C268 File Offset: 0x0061A468
	private void UpdateSkillBranchBtn()
	{
		bool uiactive = false;
		foreach (int num in this.GetSelectedRoleIdList())
		{
			if (num > 0 && RoleModel.Instance.IsRoleHasBranch(num))
			{
				uiactive = true;
				break;
			}
		}
		UUIButtonComponent button = base.GetButton(12);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06014F95 RID: 85909 RVA: 0x0061C2EC File Offset: 0x0061A4EC
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

	// Token: 0x06014F96 RID: 85910 RVA: 0x0061C310 File Offset: 0x0061A510
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

	// Token: 0x06014F97 RID: 85911 RVA: 0x0061C450 File Offset: 0x0061A650
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

	// Token: 0x0400B2B6 RID: 45750
	private int TowerId = -1;

	// Token: 0x0400B2B7 RID: 45751
	[Nullable(2)]
	private TowerTitleItem TitleItem;

	// Token: 0x0400B2B8 RID: 45752
	[Nullable(2)]
	private TowerElementLayoutItem ElementLayoutItem;

	// Token: 0x0400B2B9 RID: 45753
	[Nullable(2)]
	private TowerFormationTeamPanel TeamPanel;

	// Token: 0x0400B2BA RID: 45754
	[Nullable(2)]
	private TowerCurrentTeamRolePanel CurrentTeamRolePanel;

	// Token: 0x0400B2BB RID: 45755
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerBuffShowItem, long> BuffShowLayout;

	// Token: 0x0400B2BC RID: 45756
	[Nullable(new byte[]
	{
		2,
		1,
		0
	})]
	private GenericLayout<TowerStarsComplexItem, ValueTuple<bool, TowerTarget>> TargetStarLayout;

	// Token: 0x0400B2BD RID: 45757
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<TowerMonsterItem, int> MonsterLayout;

	// Token: 0x0400B2BE RID: 45758
	private readonly List<int> SelectOrderList = new List<int>();

	// Token: 0x020083DD RID: 33757
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A8D5 RID: 174293
		CaptionItem,
		// Token: 0x0402A8D6 RID: 174294
		TeamItem,
		// Token: 0x0402A8D7 RID: 174295
		LevelInfoItem,
		// Token: 0x0402A8D8 RID: 174296
		QuickPassItem,
		// Token: 0x0402A8D9 RID: 174297
		ElementItem,
		// Token: 0x0402A8DA RID: 174298
		ShowBuffLayout,
		// Token: 0x0402A8DB RID: 174299
		TargetStarLayout,
		// Token: 0x0402A8DC RID: 174300
		MonsterLayout,
		// Token: 0x0402A8DD RID: 174301
		CurrentTeamRoleItem,
		// Token: 0x0402A8DE RID: 174302
		CostText,
		// Token: 0x0402A8DF RID: 174303
		ChallengeBtn,
		// Token: 0x0402A8E0 RID: 174304
		RoleDetailBtn,
		// Token: 0x0402A8E1 RID: 174305
		BtnSkillBranch,
		// Token: 0x0402A8E2 RID: 174306
		BgTexture
	}
}
