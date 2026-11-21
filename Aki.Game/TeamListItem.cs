using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200083D RID: 2109
[NullableContext(1)]
[Nullable(0)]
internal class TeamListItem : UiPanelBase
{
	// Token: 0x06005FB2 RID: 24498 RVA: 0x001E9144 File Offset: 0x001E7344
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton))
		};
	}

	// Token: 0x06005FB3 RID: 24499 RVA: 0x001E921C File Offset: 0x001E741C
	private void OnClickButton()
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.QuickRoleSelectView))
		{
			UiManager.Instance.OpenView(EUiViewName.QuickRoleSelectView, this.GetRoleSelectViewData(), delegate(bool isSuccess, int viewId)
			{
				if (isSuccess)
				{
					UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.MowingTowerMainView);
					if (viewByName == null)
					{
						return;
					}
					viewByName.AddChildViewById(viewId);
				}
			});
		}
	}

	// Token: 0x06005FB4 RID: 24500 RVA: 0x001E9270 File Offset: 0x001E7470
	private QuickRoleSelectViewData GetRoleSelectViewData()
	{
		MowingTowerLevelDetailInfo levelInfo = this.CurrentTeamInfo.LevelInfo;
		InstanceDungeon? instanceDungeon = (levelInfo != null) ? levelInfo.GetInstanceDungeonConfig(this.BelongTo) : null;
		int fightFormationId = (instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().FightFormationId : 0;
		FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(fightFormationId);
		List<RoleDataBase> list = new List<RoleDataBase>();
		foreach (RoleInstance roleInstance in RoleModel.Instance.GetRoleList())
		{
			if (roleInstance.GetRoleId() != 0)
			{
				list.Add(roleInstance);
			}
		}
		foreach (int id in fightFormationConfig.Value.GetTrialRoleArray())
		{
			TrialRoleInfo? trialRoleConfigByGroupId = RoleConfig.Instance.GetTrialRoleConfigByGroupId(id);
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleConfigByGroupId.Value.Id, true);
			list.Add(roleDataById);
		}
		ValueTuple<List<int>, List<int>> currentTeamMembers = this.CurrentTeamInfo.GetCurrentTeamMembers();
		List<int> list2 = (this.BelongTo == ETeamBelong.FirstPart) ? currentTeamMembers.Item1 : currentTeamMembers.Item2;
		QuickRoleSelectViewData quickRoleSelectViewData = new QuickRoleSelectViewData(EFilterSortGroupId.EditFormation, list2.ToArray(), list);
		MowingTowerModel.Instance.CurrentOptionArea = (int)this.BelongTo;
		MowingTowerModel.Instance.OtherHalfAreaRoleList = ((this.BelongTo == ETeamBelong.FirstPart) ? currentTeamMembers.Item2 : currentTeamMembers.Item1);
		MowingTowerLevelDetailInfo levelInfo2 = this.CurrentTeamInfo.LevelInfo;
		MowTowerLevelsRe? mowTowerLevelsRe = (levelInfo2 != null) ? levelInfo2.GetConfig() : null;
		MowingTowerModel instance = MowingTowerModel.Instance;
		int[] addLevel;
		if (mowTowerLevelsRe == null)
		{
			int[] array = new int[2];
			array[0] = -1;
			addLevel = array;
			array[1] = -1;
		}
		else
		{
			addLevel = mowTowerLevelsRe.Value.GetMowTowerLevelArray();
		}
		instance.AddLevel = addLevel;
		quickRoleSelectViewData.OnHideFinish = delegate()
		{
			MowingTowerModel.Instance.CurrentOptionArea = -1;
			MowingTowerModel.Instance.OtherHalfAreaRoleList = new List<int>();
			MowingTowerModel.Instance.AddLevel = new int[]
			{
				-1,
				-1
			};
		};
		quickRoleSelectViewData.OnConfirm = new Action<int[]>(this.OnEnsureFormation);
		List<int> list3 = list2;
		List<int> list4 = new List<int>();
		for (int k = 0; k < list3.Count; k++)
		{
			int num = list3[k];
			if (num != 0)
			{
				list4.Add(num);
			}
		}
		quickRoleSelectViewData.SelectedRoleList = list4.ToArray();
		MowingTowerLevelDetailInfo levelInfo3 = this.CurrentTeamInfo.LevelInfo;
		InstanceDungeon? instanceDungeon2 = (levelInfo3 != null) ? levelInfo3.GetInstanceDungeonConfig(this.BelongTo) : null;
		BattleTeamModel.Instance.Context.SetInstanceDungeonId(new int?((instanceDungeon2 != null) ? instanceDungeon2.GetValueOrDefault().Id : 0));
		return quickRoleSelectViewData;
	}

	// Token: 0x06005FB5 RID: 24501 RVA: 0x001E9504 File Offset: 0x001E7704
	private void OnEnsureFormation(int[] roleIdList)
	{
		for (int i = 0; i < TeamListItem.ROLE_TEAM_SIZE; i++)
		{
			this.CurrentTeamInfo.SetIndexTeamMembers(this.BelongTo, i, 0);
		}
		for (int j = 0; j < roleIdList.Length; j++)
		{
			int roleId = roleIdList[j];
			this.CurrentTeamInfo.SetIndexTeamMembers(this.BelongTo, j, roleId);
		}
		this.CurrentTeamInfo.ReSortTeamMembers(this.BelongTo);
		this.OnSelectTeamRole();
	}

	// Token: 0x06005FB6 RID: 24502 RVA: 0x001E9570 File Offset: 0x001E7770
	protected override UniTask OnBeforeStartAsync()
	{
		TeamListItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TeamListItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005FB7 RID: 24503 RVA: 0x001E95B3 File Offset: 0x001E77B3
	private TeamRoleItem CreateTeamRoleItem()
	{
		return new TeamRoleItem();
	}

	// Token: 0x06005FB8 RID: 24504 RVA: 0x001E95BC File Offset: 0x001E77BC
	public void RefreshTeamRole(MowingTowerTeamInfo teamInfo, ETeamBelong belongTo)
	{
		this.CurrentTeamInfo = teamInfo;
		this.BelongTo = belongTo;
		ValueTuple<List<int>, List<int>> currentTeamMembers = teamInfo.GetCurrentTeamMembers();
		List<int> list = (belongTo == ETeamBelong.FirstPart) ? currentTeamMembers.Item1 : currentTeamMembers.Item2;
		int num = 3;
		List<TeamData> list2 = new List<TeamData>();
		for (int i = 0; i < list.Count; i++)
		{
			int roleId = list[i];
			list2.Add(new TeamData
			{
				RoleId = roleId,
				TeamInfo = teamInfo,
				BelongTo = belongTo,
				OnSelectRole = new Action(this.OnSelectTeamRole)
			});
		}
		while (list2.Count < num)
		{
			list2.Add(new TeamData
			{
				RoleId = 0,
				TeamInfo = teamInfo,
				BelongTo = belongTo,
				OnSelectRole = new Action(this.OnSelectTeamRole)
			});
		}
		this.TeamLayout.RefreshByData(list2, null, false);
		this.RefreshElementItem();
		this.RefreshLevelText();
	}

	// Token: 0x06005FB9 RID: 24505 RVA: 0x001E96A4 File Offset: 0x001E78A4
	private void RefreshElementItem()
	{
		for (int i = 0; i < this.ElementItemArray.Count; i++)
		{
			this.ElementItemArray[i].SetActive(false);
		}
		int[] recommendElementIdArray = this.CurrentTeamInfo.GetCurrentSelectLevel().GetRecommendElementIdArray(this.BelongTo);
		for (int j = 0; j < recommendElementIdArray.Length; j++)
		{
			if (recommendElementIdArray[j] != 0)
			{
				this.ElementItemArray[j].SetActive(true);
				this.ElementItemArray[j].Refresh(recommendElementIdArray[j], false, j);
			}
		}
		string textStringId = (recommendElementIdArray.Length != 0) ? "BossRushRecommendElement" : "BossRushRecommendElementNone";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId, Array.Empty<object>());
	}

	// Token: 0x06005FBA RID: 24506 RVA: 0x001E9754 File Offset: 0x001E7954
	private void RefreshLevelText()
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BossRushRecommendLevel", new <>z__ReadOnlySingleElementList<object>(this.CurrentTeamInfo.GetRecommendLevel().ToString()));
	}

	// Token: 0x06005FBB RID: 24507 RVA: 0x001E978F File Offset: 0x001E798F
	private void OnSelectTeamRole()
	{
		Action refreshLowLevelTips = this.RefreshLowLevelTips;
		if (refreshLowLevelTips != null)
		{
			refreshLowLevelTips();
		}
		this.RefreshTeamRole(this.CurrentTeamInfo, this.BelongTo);
	}

	// Token: 0x06005FBC RID: 24508 RVA: 0x001E97B4 File Offset: 0x001E79B4
	public void BindRefreshLowLevelTips(Action func)
	{
		this.RefreshLowLevelTips = func;
	}

	// Token: 0x04003EBC RID: 16060
	[Nullable(2)]
	private MowingTowerTeamInfo CurrentTeamInfo;

	// Token: 0x04003EBD RID: 16061
	private ETeamBelong BelongTo;

	// Token: 0x04003EBE RID: 16062
	[Nullable(2)]
	private CommonElementItem ElementItem1;

	// Token: 0x04003EBF RID: 16063
	[Nullable(2)]
	private CommonElementItem ElementItem2;

	// Token: 0x04003EC0 RID: 16064
	private readonly List<CommonElementItem> ElementItemArray = new List<CommonElementItem>();

	// Token: 0x04003EC1 RID: 16065
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TeamRoleItem, TeamData> TeamLayout;

	// Token: 0x04003EC2 RID: 16066
	[Nullable(2)]
	private Action RefreshLowLevelTips;

	// Token: 0x04003EC3 RID: 16067
	[StaticVariableRuleIgnore]
	private static int ROLE_TEAM_SIZE = 3;
}
