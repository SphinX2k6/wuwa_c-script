using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C80 RID: 7296
[NullableContext(1)]
[Nullable(0)]
public class TeamRoleSelectView : UiViewBase
{
	// Token: 0x0601218C RID: 74124 RVA: 0x005531D7 File Offset: 0x005513D7
	public TeamRoleSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601218D RID: 74125 RVA: 0x005531E0 File Offset: 0x005513E0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIInteractionGroup)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUIMultiTemplateLayout)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIText)),
			new ValueTuple<int, Type>(22, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIText)),
			new ValueTuple<int, Type>(26, typeof(UUIItem)),
			new ValueTuple<int, Type>(27, typeof(UUIItem)),
			new ValueTuple<int, Type>(28, typeof(UUIItem)),
			new ValueTuple<int, Type>(29, typeof(UUIItem)),
			new ValueTuple<int, Type>(30, typeof(UUIItem)),
			new ValueTuple<int, Type>(31, typeof(UUIItem)),
			new ValueTuple<int, Type>(32, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.ConfirmClick)),
			new ValueTuple<int, Delegate>(4, new Action(this.BackClick)),
			new ValueTuple<int, Delegate>(9, new Action(this.OnDetailClick)),
			new ValueTuple<int, Delegate>(22, new Action<EToggleState>(this.OnSkillModeToggleClick))
		};
	}

	// Token: 0x0601218E RID: 74126 RVA: 0x00553554 File Offset: 0x00551754
	protected override UniTask OnBeforeStartAsync()
	{
		TeamRoleSelectView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TeamRoleSelectView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601218F RID: 74127 RVA: 0x00553598 File Offset: 0x00551798
	protected override void OnStart()
	{
		if (this.Data == null)
		{
			return;
		}
		this.RoleScrollView = new LoopScrollView<TeamRoleGridBase, RoleDataBase>(base.GetLoopScrollViewComponent(1), base.GetItem(7).GetOwner() as AUIBaseActor, new Func<TeamRoleGridBase>(this.OnGridProxyCreate), false);
		UUIItem item = base.GetItem(20);
		this.TeamRoleOne = new TeamPlayerSelectionComponent(item);
		UUIItem item2 = base.GetItem(21);
		this.TeamRoleTwo = new TeamPlayerSelectionComponent(item2);
		this.RefreshSkillModeToggle();
		this.SkillLayout = new GenericLayout<TeamRoleSkillItem, TeamRoleSkillData>(base.GetHorizontalLayout(13), new Func<TeamRoleSkillItem>(this.InitSkillItem), null, false, true);
		this.RoleTagLayout = new GenericLayout<RoleTagMediumIconItem, int>(base.GetMultiTemplateLayout(16), () => new RoleTagMediumIconItem(), null, false, true);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.RoleList = this.Data.RoleList;
		int? num = new int?(this.Data.CurrentRoleId);
		int[] formationRoleList = this.Data.FormationRoleList;
		RoleSelectModel.Instance.ClearData();
		Dictionary<int, RoleDataBase> roleIndexMap = RoleSelectModel.Instance.RoleIndexMap;
		if (formationRoleList != null && this.RoleList != null)
		{
			int num2 = 1;
			while (num2 <= 3 && num2 <= formationRoleList.Length)
			{
				int num3 = formationRoleList[num2 - 1];
				foreach (RoleDataBase roleDataBase in this.RoleList)
				{
					if (roleDataBase.GetDataId() == num3)
					{
						roleIndexMap[num2] = roleDataBase;
						break;
					}
				}
				num2++;
			}
		}
		UUIItem item3 = base.GetItem(5);
		this.FilterSortEntrance = new FilterSortEntrance<RoleDataBase>(item3, new TUpdateDataListFunction<RoleDataBase>(this.UpdateRoleList));
		if (this.RoleList != null)
		{
			foreach (RoleDataBase roleDataBase2 in this.RoleList)
			{
				int dataId = roleDataBase2.GetDataId();
				int? num4 = num;
				if (dataId == num4.GetValueOrDefault() & num4 != null)
				{
					this.CurSelectRole = roleDataBase2;
					break;
				}
			}
		}
		this.RefreshTeamItem(this.Data.BattleRoleSlotDataList);
		if (this.RoleList != null)
		{
			this.RoleList.Sort((RoleDataBase a, RoleDataBase b) => b.GetRoleConfig().Priority - a.GetRoleConfig().Priority);
		}
		if (this.Data.UseWay != null && this.RoleList != null)
		{
			FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
			if (filterSortEntrance == null)
			{
				return;
			}
			filterSortEntrance.UpdateData(this.Data.UseWay.Value, this.RoleList, Array.Empty<object>());
		}
	}

	// Token: 0x06012190 RID: 74128 RVA: 0x00553854 File Offset: 0x00551A54
	protected override void OnBeforeShow()
	{
		if (this.IsNeedRefreshTeamList)
		{
			this.RefreshRoleListAfterChangeRole();
			this.IsNeedRefreshTeamList = false;
		}
	}

	// Token: 0x06012191 RID: 74129 RVA: 0x0055386C File Offset: 0x00551A6C
	private void RefreshSkillModeToggle()
	{
		this.SkillDescType = RoleModel.Instance.GetRoleSkillDescType();
		UUIExtendToggle extendToggle = base.GetExtendToggle(22);
		if (extendToggle == null)
		{
			return;
		}
		if (this.SkillDescType == ERoleSkillDescType.MultiDesc)
		{
			EToggleState state = RoleModel.Instance.IsShowMultiSkillDesc ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleState(state, false, false, false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(25), "MultiplayerSkillDescription_text", Array.Empty<object>());
			return;
		}
		EToggleState state2 = RoleModel.Instance.IsShowSkillResume ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		extendToggle.SetToggleState(state2, false, false, false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(25), "SkillBriefDescription_text", Array.Empty<object>());
	}

	// Token: 0x06012192 RID: 74130 RVA: 0x00553910 File Offset: 0x00551B10
	private UniTask InitHonamiStoryInfoAsync()
	{
		TeamRoleSelectView.<InitHonamiStoryInfoAsync>d__24 <InitHonamiStoryInfoAsync>d__;
		<InitHonamiStoryInfoAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitHonamiStoryInfoAsync>d__.<>4__this = this;
		<InitHonamiStoryInfoAsync>d__.<>1__state = -1;
		<InitHonamiStoryInfoAsync>d__.<>t__builder.Start<TeamRoleSelectView.<InitHonamiStoryInfoAsync>d__24>(ref <InitHonamiStoryInfoAsync>d__);
		return <InitHonamiStoryInfoAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012193 RID: 74131 RVA: 0x00553954 File Offset: 0x00551B54
	protected override void OnBeforeDestroy()
	{
		TeamRoleSelectViewData data = this.Data;
		if (data != null)
		{
			Action onHideFinishCallBack = data.OnHideFinishCallBack;
			if (onHideFinishCallBack != null)
			{
				onHideFinishCallBack();
			}
		}
		FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
		if (filterSortEntrance != null)
		{
			filterSortEntrance.Destroy(null);
		}
		this.Data = null;
		this.CurSelectRole = null;
		FilterSortEntrance<RoleDataBase> filterSortEntrance2 = this.FilterSortEntrance;
		if (filterSortEntrance2 != null)
		{
			filterSortEntrance2.Destroy(null);
		}
		this.FilterSortEntrance = null;
		LoopScrollView<TeamRoleGridBase, RoleDataBase> roleScrollView = this.RoleScrollView;
		if (roleScrollView != null)
		{
			roleScrollView.ClearGridProxies();
		}
		this.RoleScrollView = null;
		List<RoleDataBase> roleList = this.RoleList;
		if (roleList != null)
		{
			roleList.Clear();
		}
		this.RoleList = null;
		TeamPlayerSelectionComponent teamRoleOne = this.TeamRoleOne;
		if (teamRoleOne != null)
		{
			teamRoleOne.Destroy(null);
		}
		this.TeamRoleOne = null;
		TeamPlayerSelectionComponent teamRoleTwo = this.TeamRoleTwo;
		if (teamRoleTwo != null)
		{
			teamRoleTwo.Destroy(null);
		}
		this.TeamRoleTwo = null;
		GenericLayout<TeamRoleSkillItem, TeamRoleSkillData> skillLayout = this.SkillLayout;
		if (skillLayout != null)
		{
			skillLayout.ClearChildren();
		}
		this.SkillLayout = null;
		List<TeamRoleSkillData> skillDataList = this.SkillDataList;
		if (skillDataList != null)
		{
			skillDataList.Clear();
		}
		this.SkillDataList = null;
		GenericLayout<RoleTagMediumIconItem, int> roleTagLayout = this.RoleTagLayout;
		if (roleTagLayout != null)
		{
			roleTagLayout.ClearChildren();
		}
		this.RoleTagLayout = null;
	}

	// Token: 0x06012194 RID: 74132 RVA: 0x00553A60 File Offset: 0x00551C60
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshBattleRoleSlot, new Action<ERefreshRoleSlotReason>(this.OnRefreshBattleRoleSlotData));
		EventSystem.Instance.Add<IReadOnlyDictionary<int, int>, IReadOnlyDictionary<int, int>>(EEventName.RoleRefreshAttribute, new Action<IReadOnlyDictionary<int, int>, IReadOnlyDictionary<int, int>>(this.OnRoleRefreshAttribute));
		EventSystem.Instance.Add<Entity>(EEventName.OnRevive, new Action<Entity>(this.OnRevive));
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		float valueOrDefault = ConfigCommonParamById.GetFloatConfig("TermExplanationViewOffsetOnTeamView").GetValueOrDefault();
		TermExplanationController.Instance.RegisterTextHyperlink(base.GetText(18), ETermExplanationViewType.Side, ETermExplanationReportType.Team, ETermExplanationViewAttachDirection.Left, null, null, new ValueTuple<float, float>?(new ValueTuple<float, float>(valueOrDefault, 0f)), ETermExplanationGroup.Default, 0, ETermExplanationViewStyle.Default);
	}

	// Token: 0x06012195 RID: 74133 RVA: 0x00553B38 File Offset: 0x00551D38
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshBattleRoleSlot, new Action<ERefreshRoleSlotReason>(this.OnRefreshBattleRoleSlotData));
		EventSystem.Instance.Remove(EEventName.RoleRefreshAttribute, new Action<IReadOnlyDictionary<int, int>, IReadOnlyDictionary<int, int>>(this.OnRoleRefreshAttribute));
		EventSystem.Instance.Remove(EEventName.OnRevive, new Action<Entity>(this.OnRevive));
		EventSystem.Instance.Remove(EEventName.OnRoleSkillBranchChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		EventSystem.Instance.Remove(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(18));
	}

	// Token: 0x06012196 RID: 74134 RVA: 0x00553BE4 File Offset: 0x00551DE4
	private void UpdateRoleList(List<RoleDataBase> list, bool isOutSideChange, EFilterSortType type)
	{
		if (this.Data == null)
		{
			return;
		}
		this.RoleList = list;
		bool flag = this.RoleList.Count > 0;
		base.GetItem(8).SetUIActive(!flag);
		base.GetLoopScrollViewComponent(1).RootUIComp.Get().SetUIActive(flag);
		base.GetItem(24).SetUIActive(flag);
		base.GetItem(10).SetUIActive(flag);
		if (!flag || this.RoleScrollView == null)
		{
			base.GetButton(3).RootUIComp.Get().SetUIActive(false);
			base.GetButton(9).RootUIComp.Get().SetUIActive(false);
			return;
		}
		RoleDataBase curSelectRole = this.CurSelectRole;
		int? num = (curSelectRole != null) ? new int?(curSelectRole.GetDataId()) : null;
		if (num != null)
		{
			RoleSelectModel.Instance.SelectedRoleSet.Remove(num.Value);
		}
		this.RoleScrollView.DeselectCurrentGridProxy(false);
		this.RoleScrollView.RefreshByData(this.RoleList, false, null, false);
		if (this.CurSelectRole == null)
		{
			foreach (RoleDataBase roleDataBase in this.RoleList)
			{
				this.CurSelectRole = roleDataBase;
				Func<int, bool> canJoinTeam = this.Data.CanJoinTeam;
				if (canJoinTeam != null && canJoinTeam(roleDataBase.GetDataId()))
				{
					break;
				}
			}
			this.SelectCurrentRole();
			return;
		}
		if (type == EFilterSortType.Sort && !isOutSideChange)
		{
			this.CurSelectRole = this.RoleList[0];
			this.SelectCurrentRole();
			return;
		}
		bool flag2 = false;
		foreach (RoleDataBase roleDataBase2 in this.RoleList)
		{
			int dataId = roleDataBase2.GetDataId();
			RoleDataBase curSelectRole2 = this.CurSelectRole;
			int? num2 = (curSelectRole2 != null) ? new int?(curSelectRole2.GetDataId()) : null;
			if (dataId == num2.GetValueOrDefault() & num2 != null)
			{
				flag2 = true;
				break;
			}
		}
		if (!flag2)
		{
			this.CurSelectRole = this.RoleList[0];
		}
		this.SelectCurrentRole();
	}

	// Token: 0x06012197 RID: 74135 RVA: 0x00553E28 File Offset: 0x00552028
	private void SelectCurrentRole()
	{
		if (this.CurSelectRole == null || this.RoleList == null || this.RoleScrollView == null)
		{
			return;
		}
		this.CheckCurRoleIsDead();
		int gridIndex = this.RoleList.IndexOf(this.CurSelectRole);
		this.RoleScrollView.SelectGridProxy(gridIndex, false);
		int dataId = this.CurSelectRole.GetDataId();
		RoleSelectModel.Instance.SelectedRoleSet.Add(dataId);
		this.RefreshConfirmText(dataId);
		this.RefreshConfirmButtonEnable(dataId);
		this.RefreshRoleInfo(dataId);
	}

	// Token: 0x06012198 RID: 74136 RVA: 0x00553EA8 File Offset: 0x005520A8
	private TeamRoleGridBase OnGridProxyCreate()
	{
		TeamRoleSelectViewData data = this.Data;
		TeamRoleGridBase teamRoleGridBase;
		if (((data != null) ? data.OverrideGridProxyCreate : null) != null)
		{
			teamRoleGridBase = this.Data.OverrideGridProxyCreate();
		}
		else
		{
			teamRoleGridBase = new TeamRoleGrid();
		}
		teamRoleGridBase.IsHighlightIndex = new Func<int, bool>(this.IsHighlightIndex);
		teamRoleGridBase.IsShowGray = new Func<int, bool>(this.IsShowGray);
		teamRoleGridBase.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		teamRoleGridBase.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunction));
		return teamRoleGridBase;
	}

	// Token: 0x06012199 RID: 74137 RVA: 0x00553F30 File Offset: 0x00552130
	protected bool IsHighlightIndex(int position)
	{
		TeamRoleSelectViewData data = this.Data;
		return position == ((data != null) ? data.Position : null).GetValueOrDefault(-1);
	}

	// Token: 0x0601219A RID: 74138 RVA: 0x00553F63 File Offset: 0x00552163
	protected bool IsShowGray(int roleId)
	{
		TeamRoleSelectViewData data = this.Data;
		return data == null || !data.CanUseSpecialTrialRole || !RoleUtils.IsSpecialTrialRole(roleId);
	}

	// Token: 0x0601219B RID: 74139 RVA: 0x00553F84 File Offset: 0x00552184
	protected void ToggleFunction(MediumItemGridExtendCallback @params)
	{
		if (@params.State != EToggleState.ETT_Checked)
		{
			return;
		}
		RoleDataBase curSelectRole = this.CurSelectRole;
		int? num = (curSelectRole != null) ? new int?(curSelectRole.GetDataId()) : null;
		if (num != null)
		{
			RoleSelectModel.Instance.SelectedRoleSet.Remove(num.Value);
		}
		RoleDataBase roleDataBase = @params.Data as RoleDataBase;
		if (roleDataBase == null)
		{
			return;
		}
		this.CurSelectRole = roleDataBase;
		this.CheckCurRoleIsDead();
		if (this.RoleList == null || this.RoleScrollView == null)
		{
			return;
		}
		int gridIndex = this.RoleList.IndexOf(roleDataBase);
		this.RoleScrollView.SelectGridProxy(gridIndex, false);
		int dataId = this.CurSelectRole.GetDataId();
		RoleSelectModel.Instance.SelectedRoleSet.Add(dataId);
		this.RefreshConfirmText(dataId);
		this.RefreshConfirmButtonEnable(dataId);
		this.RefreshRoleInfo(dataId);
		TeamRoleSelectViewData data = this.Data;
		if (data == null)
		{
			return;
		}
		Action<int> onRoleSelect = data.OnRoleSelect;
		if (onRoleSelect == null)
		{
			return;
		}
		onRoleSelect(dataId);
	}

	// Token: 0x0601219C RID: 74140 RVA: 0x00554074 File Offset: 0x00552274
	protected bool CanExecuteChangeFunction(object data, bool isForceSelected, EToggleState state)
	{
		TeamRoleSelectViewData data2 = this.Data;
		if (data2 == null || !data2.CanUseSpecialTrialRole)
		{
			RoleDataBase roleDataBase = data as RoleDataBase;
			if (roleDataBase == null)
			{
				return false;
			}
			int dataId = roleDataBase.GetDataId();
			if (RoleUtils.IsSpecialTrialRole(dataId))
			{
				TeamRoleSelectViewData data3 = this.Data;
				int[] array = (data3 != null) ? data3.FormationRoleList : null;
				if (array == null || Array.IndexOf<int>(array, dataId) < 0)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("PrefabTextItem_1024721374_Text", Array.Empty<object>());
					return false;
				}
			}
		}
		if (state == EToggleState.ETT_Checked)
		{
			RoleDataBase roleDataBase2 = data as RoleDataBase;
			if (roleDataBase2 != null)
			{
				return this.CurSelectRole != roleDataBase2;
			}
		}
		return true;
	}

	// Token: 0x0601219D RID: 74141 RVA: 0x00554108 File Offset: 0x00552308
	public void RefreshTeamItem([Nullable(new byte[]
	{
		2,
		1
	})] List<BattleRoleSlotData> dataList)
	{
		if (this.TeamRoleOne == null || this.TeamRoleTwo == null)
		{
			return;
		}
		if (dataList == null)
		{
			this.TeamRoleOne.SetActive(false);
			this.TeamRoleTwo.SetActive(false);
			return;
		}
		this.TeamRoleOne.SetActive(true);
		this.TeamRoleTwo.SetActive(true);
		this.TeamRoleOne.IsSet = false;
		this.TeamRoleTwo.IsSet = false;
		for (int i = 1; i <= 4; i++)
		{
			if (i <= dataList.Count)
			{
				BattleRoleSlotData battleRoleSlotData = dataList[i - 1];
				if (battleRoleSlotData != null && battleRoleSlotData.HasRole)
				{
					BattleRoleData roleData = battleRoleSlotData.RoleData;
					if (roleData == null || !roleData.IsSelf)
					{
						if (!this.TeamRoleOne.IsSet)
						{
							this.TeamRoleOne.SetRoleId(battleRoleSlotData.RoleData.ConfigId);
							this.TeamRoleOne.SetTeamNumber(battleRoleSlotData.RoleData.OnlineIndex.GetValueOrDefault());
							this.TeamRoleOne.RefreshItem();
						}
						else if (!this.TeamRoleTwo.IsSet)
						{
							this.TeamRoleTwo.SetRoleId(battleRoleSlotData.RoleData.ConfigId);
							this.TeamRoleTwo.SetTeamNumber(battleRoleSlotData.RoleData.OnlineIndex.GetValueOrDefault());
							this.TeamRoleTwo.RefreshItem();
						}
					}
				}
			}
		}
		this.TeamRoleOne.SetActive(this.TeamRoleOne.IsSet);
		this.TeamRoleTwo.SetActive(this.TeamRoleTwo.IsSet);
	}

	// Token: 0x0601219E RID: 74142 RVA: 0x00554288 File Offset: 0x00552488
	private void RefreshConfirmText(int roleId)
	{
		TeamRoleSelectViewData data = this.Data;
		string text;
		if (data == null)
		{
			text = null;
		}
		else
		{
			Func<int, string> getConfirmButtonTextCallBack = data.GetConfirmButtonTextCallBack;
			text = ((getConfirmButtonTextCallBack != null) ? getConfirmButtonTextCallBack(roleId) : null);
		}
		string text2 = text;
		if (text2 != null && !string.IsNullOrEmpty(text2))
		{
			string textContentIdById = TextConfig.Instance.GetTextContentIdById(text2);
			if (textContentIdById != null)
			{
				base.GetText(2).ShowTextNew(textContentIdById);
			}
		}
	}

	// Token: 0x0601219F RID: 74143 RVA: 0x005542DC File Offset: 0x005524DC
	private void RefreshConfirmButtonVisible()
	{
		TeamRoleSelectViewData data = this.Data;
		if (data != null && data.ForFunction == ETeamRoleUseFunction.HonamiStory)
		{
			bool flag = HonamiStoryUtil.CheckInHonamiStoryDungeon();
			bool flag2 = FunctionModel.Instance.IsOpen(10111);
			base.GetButton(3).RootUIComp.Get().SetUIActive(!flag && flag2);
			return;
		}
		base.GetButton(3).RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x060121A0 RID: 74144 RVA: 0x00554350 File Offset: 0x00552550
	private void RefreshDetailButtonVisible()
	{
		bool flag = false;
		TeamRoleSelectViewData data = this.Data;
		if (data != null && data.ForFunction == ETeamRoleUseFunction.HonamiStory)
		{
			flag = true;
		}
		if (flag)
		{
			base.GetButton(9).RootUIComp.Get().SetUIActive(false);
			return;
		}
		RoleDataBase curSelectRole = this.CurSelectRole;
		int? num = (curSelectRole != null) ? new int?(curSelectRole.GetDataId()) : null;
		TeamRoleSelectViewData data2 = this.Data;
		Func<int, bool> func = (data2 != null) ? data2.GetDetailButtonVisible : null;
		if (func != null)
		{
			base.GetButton(9).RootUIComp.Get().SetUIActive(func(num.Value));
			return;
		}
		base.GetButton(9).RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x060121A1 RID: 74145 RVA: 0x00554414 File Offset: 0x00552614
	private void RefreshLockPanel()
	{
		if (this.CurSelectRole == null || this.PanelLock == null)
		{
			return;
		}
		TeamRoleSelectViewData data = this.Data;
		bool? flag;
		if (data == null)
		{
			flag = null;
		}
		else
		{
			Func<int, bool> showLockPanel = data.ShowLockPanel;
			flag = ((showLockPanel != null) ? new bool?(showLockPanel(this.CurSelectRole.GetDataId())) : null);
		}
		bool? flag2 = flag;
		bool valueOrDefault = flag2.GetValueOrDefault();
		this.PanelLock.SetActive(valueOrDefault);
		if (valueOrDefault)
		{
			TeamRoleSelectViewData data2 = this.Data;
			string text;
			if (data2 == null)
			{
				text = null;
			}
			else
			{
				Func<int, string> getLockTextCallBack = data2.GetLockTextCallBack;
				text = ((getLockTextCallBack != null) ? getLockTextCallBack(this.CurSelectRole.GetDataId()) : null);
			}
			string textId = text ?? "";
			this.PanelLock.SetTextByTextId(textId, Array.Empty<string>());
		}
	}

	// Token: 0x060121A2 RID: 74146 RVA: 0x005544CC File Offset: 0x005526CC
	private void RefreshSkillBranch()
	{
		if (this.CurSelectRole == null)
		{
			return;
		}
		int dataId = this.CurSelectRole.GetDataId();
		if (!RoleModel.Instance.IsRoleHasBranch(dataId))
		{
			TeamRoleSelectSkillBranchItem skillBranchSwitchItem = this.SkillBranchSwitchItem;
			if (skillBranchSwitchItem != null)
			{
				skillBranchSwitchItem.SetUiActive(false);
			}
			base.GetItem(31).SetUIActive(false);
			return;
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.BattleTeam2DView) || UiManager.Instance.IsViewHide(EUiViewName.BattleTeam2DView))
		{
			InstanceDungeon? instanceDungeon;
			int? num = (BattleTeamModel.Instance.Context.GetDungeonConfig() != null) ? new int?(instanceDungeon.GetValueOrDefault().InstSubType) : null;
			if (num != null && RoleModel.Instance.IsInHideSkillBranchInstSubTypeList(num.Value))
			{
				TeamRoleSelectSkillBranchItem skillBranchSwitchItem2 = this.SkillBranchSwitchItem;
				if (skillBranchSwitchItem2 != null)
				{
					skillBranchSwitchItem2.SetUiActive(false);
				}
				base.GetItem(31).SetUIActive(false);
				return;
			}
		}
		TeamRoleSelectSkillBranchItem skillBranchSwitchItem3 = this.SkillBranchSwitchItem;
		if (skillBranchSwitchItem3 != null)
		{
			skillBranchSwitchItem3.SetUiActive(true);
		}
		base.GetItem(31).SetUIActive(true);
		TeamRoleSelectSkillBranchItem skillBranchSwitchItem4 = this.SkillBranchSwitchItem;
		if (skillBranchSwitchItem4 != null)
		{
			skillBranchSwitchItem4.SetActiveBranchIndex(RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(dataId));
		}
		TeamRoleSelectSkillBranchItem skillBranchSwitchItem5 = this.SkillBranchSwitchItem;
		if (skillBranchSwitchItem5 == null)
		{
			return;
		}
		skillBranchSwitchItem5.RefreshIcon(delegate(int index)
		{
			int dataId2 = this.CurSelectRole.GetDataId();
			int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(dataId2, index);
			SkillBranch? skillBranchConfigById = RoleConfig.Instance.GetSkillBranchConfigById(roleBranchIdByIndex);
			if (skillBranchConfigById != null)
			{
				return skillBranchConfigById.Value.Icon;
			}
			return string.Empty;
		});
	}

	// Token: 0x060121A3 RID: 74147 RVA: 0x00554614 File Offset: 0x00552814
	private void SwitchSkillBranchHandler(int skillBranch)
	{
		int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(this.CurSelectRole.GetDataId(), skillBranch);
		if (RoleModel.Instance.IsInGamePlayRoleEdit)
		{
			RoleController.Instance.ModifyRoleSkillBranchInCurrentGamePlay(this.CurSelectRole.GetDataId(), roleBranchIdByIndex, true);
			return;
		}
		RoleController.Instance.RequestRoleSkillBranchModify(this.CurSelectRole.GetDataId(), roleBranchIdByIndex);
	}

	// Token: 0x060121A4 RID: 74148 RVA: 0x00554674 File Offset: 0x00552874
	private void OnRoleSkillBranchChanged(int roleId)
	{
		int num = this.RoleList.FindIndex((RoleDataBase role) => role.GetDataId() == roleId);
		if (num < 0)
		{
			return;
		}
		this.RoleScrollView.RefreshGridProxy(num);
	}

	// Token: 0x060121A5 RID: 74149 RVA: 0x005546B8 File Offset: 0x005528B8
	private void RefreshConfirmButtonEnable(int roleId)
	{
		TeamRoleSelectViewData data = this.Data;
		if (((data != null) ? data.GetConfirmButtonEnableCallBack : null) == null)
		{
			return;
		}
		bool interactable = this.Data.GetConfirmButtonEnableCallBack(roleId);
		UUIInteractionGroup interactionGroup = base.GetInteractionGroup(0);
		if (interactionGroup == null)
		{
			return;
		}
		interactionGroup.SetInteractable(interactable);
	}

	// Token: 0x060121A6 RID: 74150 RVA: 0x00554700 File Offset: 0x00552900
	private void RefreshRoleInfo(int roleId)
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (((levelSequencePlayer != null) ? levelSequencePlayer.GetCurrentSequence() : null) == "Switch")
		{
			this.LevelSequencePlayer.ReplaySequenceByKey("Switch");
		}
		else
		{
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
			}
		}
		RoleSkinData roleSkinDataByRoleId = RoleSkinModel.Instance.GetRoleSkinDataByRoleId(roleId);
		if (roleSkinDataByRoleId != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), roleSkinDataByRoleId.GetName(), Array.Empty<object>());
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		if (roleConfig == null)
		{
			return;
		}
		TeamRoleSelectViewData data = this.Data;
		if (data != null && data.ForFunction == ETeamRoleUseFunction.HonamiStory && this.HonamiStoryPanel != null)
		{
			this.HonamiStoryPanel.SetData(roleConfig.Value.Id);
		}
		if (this.CurSelectRole != null && this.CurSelectRole.IsTrialRole())
		{
			RoleRobotData roleRobotData = this.CurSelectRole as RoleRobotData;
			if (roleRobotData != null)
			{
				int? num = new int?(roleRobotData.GetTrialRoleId());
				if (num != null)
				{
					this.RefreshTrialRoleExtension(num.Value);
				}
			}
		}
		else
		{
			RoleTrialLabelItem trialLabelItem = this.TrialLabelItem;
			if (trialLabelItem != null)
			{
				trialLabelItem.SetUiActive(false);
			}
		}
		IReadOnlyList<Aki.Config.Skill> skillList = RoleSkillConfig.Instance.GetSkillList(roleConfig.Value.SkillId);
		if (skillList == null || skillList.Count == 0)
		{
			return;
		}
		IReadOnlyList<Aki.Config.Skill> readOnlyList = null;
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (roleDataById != null)
		{
			RoleSkillData skillData = roleDataById.GetSkillData();
			if (skillData != null && skillData.HasAnySkillUpgrade())
			{
				readOnlyList = new List<Aki.Config.Skill>(skillList);
				for (int i = 0; i < readOnlyList.Count; i++)
				{
					int id = readOnlyList[i].Id;
					int skillIdAfterUpgrade = skillData.GetSkillIdAfterUpgrade(id);
					if (skillIdAfterUpgrade > 0)
					{
						Aki.Config.Skill? skillConfigById = RoleSkillConfig.Instance.GetSkillConfigById(skillIdAfterUpgrade);
						if (skillConfigById != null)
						{
							((List<Aki.Config.Skill>)readOnlyList)[i] = skillConfigById.Value;
						}
					}
				}
			}
		}
		if (readOnlyList == null)
		{
			readOnlyList = skillList;
		}
		List<TeamRoleSkillData> skillDataList = new List<TeamRoleSkillData>();
		TeamRoleSelectViewData data2 = this.Data;
		if (((data2 != null) ? data2.GetCustomSkillShowData : null) != null && this.CurSelectRole != null)
		{
			skillDataList.AddRange(this.Data.GetCustomSkillShowData(this.CurSelectRole.GetRoleId()));
		}
		else
		{
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("DisplaySkillTypes");
			if (intArrayConfig != null)
			{
				foreach (int num2 in intArrayConfig)
				{
					foreach (Aki.Config.Skill skill in readOnlyList)
					{
						if (skill.SkillType == num2)
						{
							TeamRoleSkillData teamRoleSkillData = new TeamRoleSkillData();
							teamRoleSkillData.SkillIcon = skill.Icon;
							teamRoleSkillData.SkillType = num2;
							teamRoleSkillData.SkillName = skill.SkillName;
							int[] array = skill.SkillTagList();
							if (array != null)
							{
								teamRoleSkillData.SkillTagList = (int[])array.Clone();
							}
							teamRoleSkillData.SkillDesc = skill.SkillDescribe;
							string[] array2 = skill.SkillDetailNum();
							if (array2 != null)
							{
								teamRoleSkillData.SkillDescNum = (string[])array2.Clone();
							}
							teamRoleSkillData.MultiSkillDesc = skill.MultiSkillDescribe;
							string[] array3 = skill.MultiSkillDetailNum();
							if (array3 != null)
							{
								teamRoleSkillData.MultiSkillDescNum = (string[])array3.Clone();
							}
							teamRoleSkillData.SkillResume = skill.SkillResume;
							string[] array4 = skill.SkillResumeNum();
							if (array4 != null)
							{
								teamRoleSkillData.SkillResumeNum = (string[])array4.Clone();
							}
							skillDataList.Add(teamRoleSkillData);
							break;
						}
					}
				}
			}
		}
		if (skillDataList.Count <= 0 || this.SkillLayout == null)
		{
			return;
		}
		this.SkillDataList = skillDataList;
		this.SkillLayout.DeselectCurrentGridProxy();
		this.SkillLayout.RefreshByData(skillDataList, delegate
		{
			this.SkillLayout.SelectGridProxy(0, false);
			this.OnSkillItemStateChanged(EToggleState.ETT_Checked, skillDataList[0]);
		}, false);
		int[] roleTagByRoleInfo = RoleModel.Instance.GetRoleTagByRoleInfo(roleConfig.Value);
		bool flag = roleTagByRoleInfo != null && roleTagByRoleInfo.Length != 0;
		base.GetMultiTemplateLayout(16).RootUIComp.Get().SetUIActive(flag);
		if (flag && roleTagByRoleInfo != null)
		{
			GenericLayout<RoleTagMediumIconItem, int> roleTagLayout = this.RoleTagLayout;
			if (roleTagLayout != null)
			{
				roleTagLayout.RefreshByData(roleTagByRoleInfo, null, false);
			}
		}
		this.RefreshConfirmButtonVisible();
		this.RefreshDetailButtonVisible();
		this.RefreshLockPanel();
		this.RefreshSkillBranch();
	}

	// Token: 0x060121A7 RID: 74151 RVA: 0x00554BC0 File Offset: 0x00552DC0
	private TeamRoleSkillItem InitSkillItem()
	{
		TeamRoleSkillItem teamRoleSkillItem = new TeamRoleSkillItem();
		teamRoleSkillItem.BindOnSkillStateChange(new Action<EToggleState, TeamRoleSkillData>(this.OnSkillItemStateChanged));
		return teamRoleSkillItem;
	}

	// Token: 0x060121A8 RID: 74152 RVA: 0x00554BDC File Offset: 0x00552DDC
	private void OnSkillItemStateChanged(EToggleState state, TeamRoleSkillData data)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		if (this.SkillDataList == null || this.SkillLayout == null)
		{
			return;
		}
		int gridIndex = this.SkillDataList.IndexOf(data);
		this.SkillLayout.SelectGridProxy(gridIndex, false);
		this.RefreshSkillInfo(data);
	}

	// Token: 0x060121A9 RID: 74153 RVA: 0x00554C20 File Offset: 0x00552E20
	private void RefreshSkillInfo(TeamRoleSkillData data)
	{
		if (this.Data == null)
		{
			return;
		}
		string[] array = new string[0];
		string text;
		if (this.SkillDescType == ERoleSkillDescType.MultiDesc)
		{
			if (RoleModel.Instance.IsShowMultiSkillDesc && !StringUtils.IsEmpty(data.MultiSkillDesc))
			{
				text = data.MultiSkillDesc;
				array = (data.MultiSkillDescNum ?? new string[0]);
			}
			else
			{
				text = data.SkillDesc;
				array = (data.SkillDescNum ?? new string[0]);
			}
		}
		else if (RoleModel.Instance.IsShowSkillResume && !StringUtils.IsEmpty(data.SkillResume))
		{
			text = data.SkillResume;
			array = (data.SkillResumeNum ?? new string[0]);
		}
		else
		{
			text = data.SkillDesc;
			array = (data.SkillDescNum ?? new string[0]);
		}
		string text2 = "";
		if (StringUtils.IsEmpty(data.SkillTypeText))
		{
			string skillTypeNameLocalText = RoleSkillConfig.Instance.GetSkillTypeNameLocalText(data.SkillType);
			if (skillTypeNameLocalText != null && !string.IsNullOrEmpty(skillTypeNameLocalText))
			{
				text2 = skillTypeNameLocalText;
			}
		}
		else
		{
			text2 = data.SkillTypeText;
		}
		if (this.Data.ForFunction == ETeamRoleUseFunction.HonamiStory && this.HonamiStoryPanel != null)
		{
			this.HonamiStoryPanel.RefreshSkillInfo(data.SkillName, text, text2, array);
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), data.SkillName, Array.Empty<object>());
		if (array.Length != 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(18), text, array);
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(18), text, Array.Empty<object>());
		}
		base.GetText(12).SetText(text2, true);
	}

	// Token: 0x060121AA RID: 74154 RVA: 0x00554DAC File Offset: 0x00552FAC
	private void CheckCurRoleIsDead()
	{
		UUIText text = base.GetText(6);
		if (TowerModel.Instance.IsOpenFloorFormation() || LordGymController.Instance.IsInLordGymDungeon())
		{
			text.SetUIActive(false);
			return;
		}
		if (this.CurSelectRole == null || this.RoleList == null || this.RoleScrollView == null)
		{
			return;
		}
		int dataId = this.CurSelectRole.GetDataId();
		int gridIndex = this.RoleList.IndexOf(this.CurSelectRole);
		this.RoleScrollView.RefreshGridProxy(gridIndex);
		TeamRoleSelectViewData data = this.Data;
		bool flag;
		if (data == null)
		{
			flag = false;
		}
		else
		{
			Func<int, bool> isNeedRevive = data.IsNeedRevive;
			flag = ((isNeedRevive != null) ? new bool?(isNeedRevive(dataId)) : null).GetValueOrDefault();
		}
		if (flag)
		{
			text.SetUIActive(true);
			LguiUtil.Instance.SetLocalText(text, "EditBattleTeamNeedRevive", Array.Empty<object>());
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x060121AB RID: 74155 RVA: 0x00554E7E File Offset: 0x0055307E
	private void OnRoleRefreshAttribute(IReadOnlyDictionary<int, int> baseAttr, IReadOnlyDictionary<int, int> addAttr)
	{
		this.OnRoleRefresh();
	}

	// Token: 0x060121AC RID: 74156 RVA: 0x00554E86 File Offset: 0x00553086
	private void OnRevive(Entity _)
	{
		this.OnRoleRefresh();
	}

	// Token: 0x060121AD RID: 74157 RVA: 0x00554E8E File Offset: 0x0055308E
	private void OnRoleRefresh()
	{
		if (this.CurSelectRole != null)
		{
			this.CheckCurRoleIsDead();
			this.RefreshConfirmText(this.CurSelectRole.GetDataId());
		}
	}

	// Token: 0x060121AE RID: 74158 RVA: 0x00554EAF File Offset: 0x005530AF
	private void OnRoleChangeEnd()
	{
		this.IsNeedRefreshTeamList = true;
	}

	// Token: 0x060121AF RID: 74159 RVA: 0x00554EB8 File Offset: 0x005530B8
	private void RefreshRoleListAfterChangeRole()
	{
		if (this.Data == null || this.RoleList == null)
		{
			return;
		}
		RoleSelectModel instance = RoleSelectModel.Instance;
		bool flag = false;
		using (List<RoleDataBase>.Enumerator enumerator = new List<RoleDataBase>(this.RoleList).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				RoleDataBase roleData = enumerator.Current;
				bool flag2 = this.CurSelectRole == roleData;
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleData.GetDataId(), true);
				if (roleDataById != null && roleDataById != roleData)
				{
					flag = true;
					List<RoleDataBase> roleList = this.Data.RoleList;
					int num = (roleList != null) ? roleList.FindIndex((RoleDataBase data) => data == roleData) : -1;
					if (num > -1 && this.Data.RoleList != null)
					{
						this.Data.RoleList[num] = roleDataById;
					}
					int roleIndex = instance.GetRoleIndex(roleData.GetDataId());
					if (roleIndex > 0)
					{
						instance.RoleIndexMap[roleIndex] = roleDataById;
					}
					if (flag2)
					{
						this.CurSelectRole = roleDataById;
					}
				}
			}
		}
		if (flag && this.Data.RoleList != null)
		{
			this.RoleList = this.Data.RoleList;
			this.RoleList.Sort((RoleDataBase a, RoleDataBase b) => b.GetRoleConfig().Priority - a.GetRoleConfig().Priority);
			if (this.Data.UseWay != null)
			{
				FilterSortEntrance<RoleDataBase> filterSortEntrance = this.FilterSortEntrance;
				if (filterSortEntrance == null)
				{
					return;
				}
				filterSortEntrance.UpdateData(this.Data.UseWay.Value, this.RoleList, Array.Empty<object>());
			}
		}
	}

	// Token: 0x060121B0 RID: 74160 RVA: 0x0055507C File Offset: 0x0055327C
	private void OnRefreshBattleRoleSlotData(ERefreshRoleSlotReason reason)
	{
		TeamRoleSelectViewData data = this.Data;
		if (((data != null) ? data.BattleRoleSlotDataList : null) == null)
		{
			return;
		}
		BattleRoleSlotData slot = BattleTeamModel.Instance.GetSlot(this.Data.Position.GetValueOrDefault());
		if (slot != null)
		{
			BattleRoleData roleData = slot.RoleData;
			int? num = (roleData != null) ? new int?(roleData.PlayerId) : null;
			int? id = PlayerInfoModel.Instance.GetId();
			if (num.GetValueOrDefault() == id.GetValueOrDefault() & num != null == (id != null))
			{
				List<BattleRoleSlotData> allSlots = BattleTeamModel.Instance.GetAllSlots();
				if (allSlots != null)
				{
					this.Data.SetOtherTeamSlotData(allSlots);
				}
				TeamRoleSelectViewData data2 = this.Data;
				this.RefreshTeamItem((data2 != null) ? data2.BattleRoleSlotDataList : null);
				return;
			}
		}
		TeamRoleSelectViewData data3 = this.Data;
		if (data3 != null)
		{
			Action backCallBack = data3.BackCallBack;
			if (backCallBack != null)
			{
				backCallBack();
			}
		}
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x060121B1 RID: 74161 RVA: 0x00555170 File Offset: 0x00553370
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		string a = configParams[0];
		if (!(a == "Dream"))
		{
			if (a == "Trial")
			{
				if (configParams.Length < 2)
				{
					return null;
				}
				int num;
				if (!int.TryParse(configParams[1], out num))
				{
					return null;
				}
				int? num2 = null;
				if (this.RoleList != null)
				{
					for (int i = 0; i < this.RoleList.Count; i++)
					{
						RoleDataBase roleDataBase = this.RoleList[i];
						if (roleDataBase.IsTrialRole())
						{
							TrialRoleInfo? trialRoleConfig = TrialRoleConfig.Instance.GetTrialRoleConfig(roleDataBase.GetRoleId());
							if (trialRoleConfig != null && trialRoleConfig.GetValueOrDefault().GroupId == num)
							{
								num2 = new int?(i);
								break;
							}
						}
					}
				}
				if (num2 != null && num2.Value >= 0)
				{
					LoopScrollView<TeamRoleGridBase, RoleDataBase> roleScrollView = this.RoleScrollView;
					UUIItem uuiitem = (roleScrollView != null) ? roleScrollView.GetGrid(num2.Value) : null;
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
			}
			int num3;
			if (configParams.Length != 0 && int.TryParse(configParams[0], out num3) && num3 != 0)
			{
				UUIItem scrollItemByRoleId = this.GetScrollItemByRoleId(num3);
				if (scrollItemByRoleId != null)
				{
					return new UUIItem[]
					{
						scrollItemByRoleId,
						scrollItemByRoleId
					};
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.JT;
			string message = "聚焦引导extraParam项配置有误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		if (this.SkillLayout == null || this.SkillDataList == null)
		{
			return null;
		}
		UUIItem itemByIndex = this.SkillLayout.GetItemByIndex(this.SkillDataList.Count - 1);
		if (itemByIndex == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			itemByIndex,
			itemByIndex
		};
	}

	// Token: 0x060121B2 RID: 74162 RVA: 0x0055531C File Offset: 0x0055351C
	[NullableContext(2)]
	private UUIItem GetScrollItemByRoleId(int roleId)
	{
		int index = 0;
		UUIItem result = null;
		if (this.RoleList != null)
		{
			foreach (RoleDataBase roleDataBase in this.RoleList)
			{
				if (roleDataBase.GetRoleId() == roleId)
				{
					index = this.RoleList.IndexOf(roleDataBase);
					LoopScrollView<TeamRoleGridBase, RoleDataBase> roleScrollView = this.RoleScrollView;
					result = ((roleScrollView != null) ? roleScrollView.GetGrid(index) : null);
					break;
				}
			}
		}
		TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			LoopScrollView<TeamRoleGridBase, RoleDataBase> roleScrollView2 = this.RoleScrollView;
			if (roleScrollView2 == null)
			{
				return;
			}
			roleScrollView2.ScrollToGridIndex(index, false);
		}, null, null);
		return result;
	}

	// Token: 0x060121B3 RID: 74163 RVA: 0x005553D8 File Offset: 0x005535D8
	private UniTask InitTrialRoleExtension()
	{
		TeamRoleSelectView.<InitTrialRoleExtension>d__57 <InitTrialRoleExtension>d__;
		<InitTrialRoleExtension>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTrialRoleExtension>d__.<>4__this = this;
		<InitTrialRoleExtension>d__.<>1__state = -1;
		<InitTrialRoleExtension>d__.<>t__builder.Start<TeamRoleSelectView.<InitTrialRoleExtension>d__57>(ref <InitTrialRoleExtension>d__);
		return <InitTrialRoleExtension>d__.<>t__builder.Task;
	}

	// Token: 0x060121B4 RID: 74164 RVA: 0x0055541C File Offset: 0x0055361C
	private void RefreshTrialRoleExtension(int roleId)
	{
		if (!RoleUtils.IsTrialRole(roleId))
		{
			RoleTrialLabelItem trialLabelItem = this.TrialLabelItem;
			if (trialLabelItem == null)
			{
				return;
			}
			trialLabelItem.SetUiActive(false);
			return;
		}
		else if (RoleUtils.GetTrialRoleType(roleId) == ETrialRoleType.None)
		{
			RoleTrialLabelItem trialLabelItem2 = this.TrialLabelItem;
			if (trialLabelItem2 == null)
			{
				return;
			}
			trialLabelItem2.SetUiActive(false);
			return;
		}
		else
		{
			RoleTrialLabelItem trialLabelItem3 = this.TrialLabelItem;
			if (trialLabelItem3 != null)
			{
				trialLabelItem3.SetUiActive(true);
			}
			RoleTrialLabelItem trialLabelItem4 = this.TrialLabelItem;
			if (trialLabelItem4 == null)
			{
				return;
			}
			trialLabelItem4.Refresh(roleId);
			return;
		}
	}

	// Token: 0x060121B5 RID: 74165 RVA: 0x00555480 File Offset: 0x00553680
	private void ConfirmClick()
	{
		RoleDataBase curSelectRole = this.CurSelectRole;
		int? num = (curSelectRole != null) ? new int?(curSelectRole.GetDataId()) : null;
		if (num == null)
		{
			return;
		}
		TeamRoleSelectViewData data = this.Data;
		Func<int, bool> func = (data != null) ? data.CanConfirmFunc : null;
		if (func != null && !func(num.Value))
		{
			return;
		}
		TeamRoleSelectViewData data2 = this.Data;
		if (data2 != null)
		{
			Action<int> confirmCallBack = data2.ConfirmCallBack;
			if (confirmCallBack != null)
			{
				confirmCallBack(num.Value);
			}
		}
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x060121B6 RID: 74166 RVA: 0x00555516 File Offset: 0x00553716
	private void BackClick()
	{
		TeamRoleSelectViewData data = this.Data;
		if (data != null)
		{
			Action backCallBack = data.BackCallBack;
			if (backCallBack != null)
			{
				backCallBack();
			}
		}
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x060121B7 RID: 74167 RVA: 0x0055554C File Offset: 0x0055374C
	private unsafe void OnDetailClick()
	{
		if (this.CurSelectRole == null)
		{
			return;
		}
		TeamRoleSelectViewData data = this.Data;
		if (((data != null) ? data.DetailCallback : null) != null)
		{
			this.Data.DetailCallback(this.CurSelectRole.GetDataId());
			return;
		}
		int dataId = this.CurSelectRole.GetDataId();
		List<int> list;
		if (dataId < 100000)
		{
			list = new List<int>();
		}
		else
		{
			int num = 1;
			List<int> list2 = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list2, num);
			list = list2;
			Span<int> span = CollectionsMarshal.AsSpan<int>(list2);
			int index = 0;
			*span[index] = dataId;
		}
		List<int> roleIdList = list;
		RoleModel.Instance.StartRecordRoleSkillBranchChangeRequest();
		RoleController.Instance.OpenRoleMainView(ERoleAgentType.Normal, dataId, roleIdList, null, null);
		EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x060121B8 RID: 74168 RVA: 0x0055562C File Offset: 0x0055382C
	private void OnCloseView(EUiViewName viewName, int i)
	{
		if (viewName == EUiViewName.RoleRootView)
		{
			EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			List<int> list = RoleModel.Instance.StopRecordRoleSkillBranchChangeRequest();
			if (list.Count > 0)
			{
				this.RefreshSkillBranch();
				foreach (int roleId in list)
				{
					this.OnRoleSkillBranchChanged(roleId);
				}
			}
		}
	}

	// Token: 0x060121B9 RID: 74169 RVA: 0x005556DC File Offset: 0x005538DC
	private void OnSkillModeToggleClick(EToggleState toggleState)
	{
		if (this.SkillDescType == ERoleSkillDescType.MultiDesc)
		{
			RoleModel.Instance.IsShowMultiSkillDesc = (toggleState == EToggleState.ETT_Checked);
		}
		else
		{
			RoleModel.Instance.IsShowSkillResume = (toggleState == EToggleState.ETT_Checked);
		}
		if (this.SkillLayout == null || this.SkillDataList == null)
		{
			return;
		}
		int selectedGridIndex = this.SkillLayout.GetSelectedGridIndex();
		if (selectedGridIndex < 0 || selectedGridIndex >= this.SkillDataList.Count)
		{
			return;
		}
		this.RefreshSkillInfo(this.SkillDataList[selectedGridIndex]);
	}

	// Token: 0x04009DE8 RID: 40424
	[Nullable(2)]
	private TeamRoleSelectViewData Data;

	// Token: 0x04009DE9 RID: 40425
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

	// Token: 0x04009DEA RID: 40426
	[Nullable(2)]
	protected RoleDataBase CurSelectRole;

	// Token: 0x04009DEB RID: 40427
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<TeamRoleGridBase, RoleDataBase> RoleScrollView;

	// Token: 0x04009DEC RID: 40428
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<RoleDataBase> RoleList;

	// Token: 0x04009DED RID: 40429
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TeamRoleSkillItem, TeamRoleSkillData> SkillLayout;

	// Token: 0x04009DEE RID: 40430
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<TeamRoleSkillData> SkillDataList;

	// Token: 0x04009DEF RID: 40431
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTagMediumIconItem, int> RoleTagLayout;

	// Token: 0x04009DF0 RID: 40432
	[Nullable(2)]
	private TeamPlayerSelectionComponent TeamRoleOne;

	// Token: 0x04009DF1 RID: 40433
	[Nullable(2)]
	private TeamPlayerSelectionComponent TeamRoleTwo;

	// Token: 0x04009DF2 RID: 40434
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04009DF3 RID: 40435
	private ERoleSkillDescType SkillDescType;

	// Token: 0x04009DF4 RID: 40436
	public bool IsNeedRefreshTeamList;

	// Token: 0x04009DF5 RID: 40437
	[Nullable(2)]
	private HonamiStoryRoleInfoPanel HonamiStoryPanel;

	// Token: 0x04009DF6 RID: 40438
	[Nullable(2)]
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x04009DF7 RID: 40439
	[Nullable(2)]
	private RoleTrialLabelItem TrialLabelItem;

	// Token: 0x04009DF8 RID: 40440
	[Nullable(2)]
	private TeamRoleSelectSkillBranchItem SkillBranchSwitchItem;

	// Token: 0x02007F7F RID: 32639
	[NullableContext(0)]
	private enum EComponentType
	{
		// Token: 0x0402941B RID: 168987
		ConfirmButtonInteractionGroup,
		// Token: 0x0402941C RID: 168988
		RoleScroll,
		// Token: 0x0402941D RID: 168989
		ConfirmText,
		// Token: 0x0402941E RID: 168990
		ConfirmButton,
		// Token: 0x0402941F RID: 168991
		CloseButton,
		// Token: 0x04029420 RID: 168992
		FilterSortEntrance,
		// Token: 0x04029421 RID: 168993
		TipsText,
		// Token: 0x04029422 RID: 168994
		RoleItem,
		// Token: 0x04029423 RID: 168995
		NoneRoleTips,
		// Token: 0x04029424 RID: 168996
		DetailButton,
		// Token: 0x04029425 RID: 168997
		RoleInfoContent,
		// Token: 0x04029426 RID: 168998
		RoleNameText,
		// Token: 0x04029427 RID: 168999
		SkillTypeNameText,
		// Token: 0x04029428 RID: 169000
		SkillContent,
		// Token: 0x04029429 RID: 169001
		SkillItem,
		// Token: 0x0402942A RID: 169002
		SkillNameText,
		// Token: 0x0402942B RID: 169003
		RoleTagContent,
		// Token: 0x0402942C RID: 169004
		SkillTagItem,
		// Token: 0x0402942D RID: 169005
		SkillInfoText,
		// Token: 0x0402942E RID: 169006
		TeamGroup,
		// Token: 0x0402942F RID: 169007
		TeamRoleOne,
		// Token: 0x04029430 RID: 169008
		TeamRoleTwo,
		// Token: 0x04029431 RID: 169009
		SkillModeToggle,
		// Token: 0x04029432 RID: 169010
		SkillModeItem,
		// Token: 0x04029433 RID: 169011
		TopItem,
		// Token: 0x04029434 RID: 169012
		SkillModeText,
		// Token: 0x04029435 RID: 169013
		HonamiStoryEffectNode,
		// Token: 0x04029436 RID: 169014
		NormalPanelNode,
		// Token: 0x04029437 RID: 169015
		HonamiStoryPanelNode,
		// Token: 0x04029438 RID: 169016
		LockPanel,
		// Token: 0x04029439 RID: 169017
		TrialRoleItem,
		// Token: 0x0402943A RID: 169018
		SkillBranchRootItem,
		// Token: 0x0402943B RID: 169019
		SkillBranchSwitchItem
	}
}
