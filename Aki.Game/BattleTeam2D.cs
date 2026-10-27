using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BF8 RID: 7160
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1,
	1
})]
public class BattleTeam2D : FormationViewBase<BattleTeamDataProvider, BattleTeamContextValidator, SlotPresenter2D>, IUiViewResource
{
	// Token: 0x0600D573 RID: 54643 RVA: 0x00313130 File Offset: 0x00311330
	public BattleTeam2D(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x1700119B RID: 4507
	// (get) Token: 0x0600D574 RID: 54644 RVA: 0x003131A8 File Offset: 0x003113A8
	protected override BattleTeamDataProvider Provider { get; } = new BattleTeamDataProvider();

	// Token: 0x1700119C RID: 4508
	// (get) Token: 0x0600D575 RID: 54645 RVA: 0x003131B0 File Offset: 0x003113B0
	protected override BattleTeamContextValidator Validator { get; } = new BattleTeamContextValidator();

	// Token: 0x1700119D RID: 4509
	// (get) Token: 0x0600D576 RID: 54646 RVA: 0x003131B8 File Offset: 0x003113B8
	protected override SlotPresenter2D Presenter { get; } = new SlotPresenter2D();

	// Token: 0x1700119E RID: 4510
	// (get) Token: 0x0600D577 RID: 54647 RVA: 0x003131C0 File Offset: 0x003113C0
	protected override FormationViewKeys Keys { get; } = new FormationViewKeys
	{
		Close = 3,
		Tab = 11,
		Confirm = 4,
		QuickSelect = 19,
		Loading = 28,
		ConfirmText = 5
	};

	// Token: 0x0600D578 RID: 54648 RVA: 0x003131C8 File Offset: 0x003113C8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 31;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(31, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 8;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickConfirm));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickClose));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(19, new Action(this.OnClickQuickSelect));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnAddPlayerButtonClicked));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnInviteButtonClicked));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickChat));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnClickTowerDetailsBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnClickTowerRecommendBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D579 RID: 54649 RVA: 0x00313740 File Offset: 0x00311940
	public string GetExtraResourceId([Nullable(2)] object param = null)
	{
		int? instanceDungeonId = BattleTeamModel.Instance.Context.InstanceDungeonId;
		if (instanceDungeonId != null)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceDungeonId.Value);
			if (config != null && config.Value.InstSubType == 33)
			{
				return "UiView_CelebrationBattleTeam";
			}
		}
		return "UiView_BattleTeam";
	}

	// Token: 0x0600D57A RID: 54650 RVA: 0x003137A0 File Offset: 0x003119A0
	protected override UniTask OnBeforeStartAsync()
	{
		BattleTeam2D.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BattleTeam2D.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D57B RID: 54651 RVA: 0x003137E4 File Offset: 0x003119E4
	private void InitViewParam()
	{
		IEditBattleTeamViewParam editBattleTeamViewParam = this.OpenParam as IEditBattleTeamViewParam;
		BattleTeamModel instance = BattleTeamModel.Instance;
		bool isMultiInstanceDungeon = instance.Context.IsMultiInstanceDungeon;
		this.CanUseSpecialTrailRole = ((editBattleTeamViewParam == null || editBattleTeamViewParam.CanUseSpecialTrailRole) && !isMultiInstanceDungeon);
		instance.CanUseSpecialTrialRole = this.CanUseSpecialTrailRole;
	}

	// Token: 0x0600D57C RID: 54652 RVA: 0x00313834 File Offset: 0x00311A34
	private void RefreshQuickSelectButton()
	{
		UUIButtonComponent button = base.GetButton(19);
		if (button == null)
		{
			return;
		}
		BattleTeamModel instance = BattleTeamModel.Instance;
		int? instanceDungeonId = instance.Context.InstanceDungeonId;
		if (instanceDungeonId != null)
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceDungeonId.Value);
			if (config != null && config.Value.InstSubType == 33)
			{
				button.RootUIComp.Get().SetUIActive(false);
				return;
			}
		}
		button.RootUIComp.Get().SetUIActive(!instance.Context.IsMultiInstanceDungeon);
	}

	// Token: 0x0600D57D RID: 54653 RVA: 0x003138D0 File Offset: 0x00311AD0
	protected override void OnBeforeShow()
	{
		this.Presenter.ActivateDragData();
		if (UiManager.Instance.IsViewOpen(EUiViewName.OnlineInstanceMatchTips))
		{
			UiManager.Instance.CloseView(EUiViewName.OnlineInstanceMatchTips, null);
		}
		UUIItem item = base.GetItem(27);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(MultiMotorModel.Instance.CheckInMultiMotorEditFormationState());
	}

	// Token: 0x0600D57E RID: 54654 RVA: 0x00313928 File Offset: 0x00311B28
	protected override void OnStart()
	{
		if (this.TabComponent != null)
		{
			int index = FormationModel.Instance.CurrentFormationId.GetValueOrDefault(1) - 1;
			this.TabComponent.SelectToggleByIndex(index, false);
			this.TabComponent.ScrollToToggleByIndex(index);
			EditFormationTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
			if (tabItemByIndex != null)
			{
				tabItemByIndex.ShowTeamBattleTips(true);
			}
			this.TabComponent.SetCanChange((int _) => FormationViewDragController.DraggingIndex <= 0);
		}
	}

	// Token: 0x0600D57F RID: 54655 RVA: 0x003139B0 File Offset: 0x00311BB0
	protected override void OnBeforeDestroy()
	{
		RecommendElementComponent recommendElement = this.RecommendElement;
		if (recommendElement != null)
		{
			recommendElement.Destroy();
		}
		this.RecommendElement = null;
		ViewExtensionRegistry.DetachAll(this.ViewExtensions);
		this.ViewExtensions = new List<IViewExtension>();
		this.MultiPlayerExt = null;
		this.TowerExt = null;
		InstanceDungeonEntranceModel.Instance.SetEditBattleTeamMatching(false);
		InstanceDungeonModel instance = InstanceDungeonModel.Instance;
		MatchTeamInfo matchTeamInfo = (instance != null) ? instance.GetMatchTeamInfo() : null;
		if (matchTeamInfo != null && matchTeamInfo.TeamState != MatchTeamState.EnterInstStart)
		{
			InstanceDungeonEntranceController.Instance.LeaveMatchTeamRequest();
		}
		BattleTeamModel instance2 = BattleTeamModel.Instance;
		bool flag = TowerModel.Instance.CheckInTower();
		if (!instance2.Context.IsMultiInstanceDungeon && !flag)
		{
			InstanceDungeonEntranceController.Instance.RevertEntranceFlowStep();
			instance2.Context.SetInstanceDungeonId(null);
		}
		InstanceDungeonEntranceController.Instance.OnEditBattleViewClose();
		if (instance2.Context.IsMultiEntry)
		{
			instance2.Context.SetMultiEntry(false);
		}
		instance2.CanUseSpecialTrialRole = false;
		this.RemoveEvents();
		this.IsTabInit = false;
		if (instance2.IsFormTeleportAction)
		{
			instance2.IsFormTeleportAction = false;
			InstanceDungeonController.Instance.TeleportDungeonRequest(new List<int>(), false);
		}
		base.OnBeforeDestroy();
	}

	// Token: 0x0600D580 RID: 54656 RVA: 0x00313AC8 File Offset: 0x00311CC8
	protected UniTask CreateAllSlotsAsync()
	{
		BattleTeam2D.<CreateAllSlotsAsync>d__27 <CreateAllSlotsAsync>d__;
		<CreateAllSlotsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAllSlotsAsync>d__.<>4__this = this;
		<CreateAllSlotsAsync>d__.<>1__state = -1;
		<CreateAllSlotsAsync>d__.<>t__builder.Start<BattleTeam2D.<CreateAllSlotsAsync>d__27>(ref <CreateAllSlotsAsync>d__);
		return <CreateAllSlotsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D581 RID: 54657 RVA: 0x00313B0B File Offset: 0x00311D0B
	[NullableContext(2)]
	protected override void OnRefreshRoleView(int[] needRefreshPosition = null)
	{
		if (base.IsDestroyOrDestroying)
		{
			return;
		}
		this.RefreshAllRoleView(this.EditFormationId, needRefreshPosition);
		this.RefreshConfirmButton();
		this.RefreshEnterButtonEnable();
		this.UpdateRecommendLevel();
	}

	// Token: 0x0600D582 RID: 54658 RVA: 0x00313B38 File Offset: 0x00311D38
	[NullableContext(2)]
	protected override void RefreshAllRoleView(int formationId, int[] needRefreshPosition = null)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		instance.RefreshAllEmptySlotData();
		List<BattleRoleSlotData> allSlots = instance.GetAllSlots();
		if (allSlots.Count == 0)
		{
			return;
		}
		for (int i = 1; i <= 4; i++)
		{
			BattleRoleSlotData battleRoleSlotData = (i - 1 < allSlots.Count) ? allSlots[i - 1] : null;
			if (battleRoleSlotData != null)
			{
				FormationRoleSlot byPosition = this.Presenter.GetByPosition(i);
				if (byPosition != null)
				{
					if (battleRoleSlotData.IsProhibit)
					{
						this.Presenter.Reset(i);
						byPosition.SetCanAddRole(false);
					}
					else if (needRefreshPosition == null || Array.IndexOf<int>(needRefreshPosition, i) != -1)
					{
						byPosition.SetCanAddRole(true);
						this.RefreshRoleView(formationId, i);
						if (instance.Context.IsMultiInstanceDungeon)
						{
							FormationRoleSlot formationRoleSlot = byPosition;
							BattleRoleData roleData = battleRoleSlotData.RoleData;
							formationRoleSlot.RefreshThirdPartyItem((roleData != null) ? roleData.ThirdPartyOnlineId : null);
							byPosition.RefreshPrepareState(null);
						}
					}
				}
			}
		}
		this.UpdateRecommendLevel();
		ViewExtensionRegistry.InvokeViewRefresh(this.ViewExtensions);
	}

	// Token: 0x0600D583 RID: 54659 RVA: 0x00313C28 File Offset: 0x00311E28
	protected override void RefreshRoleView(int formationId, int position)
	{
		IRoleSlotDisplayData roleSlotDisplayData = this.Provider.BuildSlotDisplayData(position);
		if (roleSlotDisplayData.ConfigId <= 0)
		{
			this.Presenter.Reset(position);
			return;
		}
		this.Presenter.Refresh(position, roleSlotDisplayData);
	}

	// Token: 0x0600D584 RID: 54660 RVA: 0x00313C68 File Offset: 0x00311E68
	protected override void RefreshConfirmButton()
	{
		UUIText text = base.GetText(5);
		UUIItem uuiitem = base.GetButton(6).RootUIComp.Get();
		UUIItem uuiitem2 = base.GetButton(7).RootUIComp.Get();
		BattleTeamModel instance = BattleTeamModel.Instance;
		if (!instance.Context.IsMultiInstanceDungeon)
		{
			LguiUtil.Instance.SetLocalText(text, "MatchingButtonLeader", Array.Empty<object>());
			uuiitem.SetUIActive(false);
			uuiitem2.SetUIActive(false);
			return;
		}
		InstanceDungeonModel instance2 = InstanceDungeonModel.Instance;
		if (!instance2.IsMatchTeamHost())
		{
			string textTableId = instance.IsSelfReady ? "MatchingButtonMemberCancel" : "MatchingButtonMember";
			LguiUtil.Instance.SetLocalText(text, textTableId, Array.Empty<object>());
			uuiitem.SetUIActive(false);
			uuiitem2.SetUIActive(false);
			return;
		}
		bool editBattleTeamMatching = InstanceDungeonEntranceModel.Instance.EditBattleTeamMatching;
		string textTableId2 = editBattleTeamMatching ? "EditBattleTeamCancelMatch" : "MatchingButtonLeader";
		LguiUtil.Instance.SetLocalText(text, textTableId2, Array.Empty<object>());
		bool uiactive = instance2.IsTeamNotFull() && !editBattleTeamMatching;
		uuiitem.SetUIActive(uiactive);
		bool uiactive2 = !instance2.IsAllPlayerInMatchTeam();
		uuiitem2.SetUIActive(uiactive2);
	}

	// Token: 0x0600D585 RID: 54661 RVA: 0x00313D88 File Offset: 0x00311F88
	private void RefreshEnterButtonEnable()
	{
		this.RefreshTowerDefenceWarningTips();
		UUIButtonComponent button = base.GetButton(4);
		BattleTeamModel instance = BattleTeamModel.Instance;
		if (instance.Context.IsMultiInstanceDungeon && InstanceDungeonModel.Instance.IsMatchTeamHost())
		{
			if (InstanceDungeonEntranceModel.Instance.EditBattleTeamMatching)
			{
				button.SetSelfInteractive(true);
				return;
			}
			if (!instance.IsAllReady)
			{
				Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "[BattleTeam2D] 有玩家未准备", default(ReadOnlySpan<ValueTuple<string, object>>));
				button.SetSelfInteractive(false);
				return;
			}
			if (!ViewExtensionRegistry.CollectEnterGate(this.ViewExtensions).Ok)
			{
				button.SetSelfInteractive(false);
				return;
			}
			button.SetSelfInteractive(true);
			return;
		}
		else
		{
			if (!LordGymController.Instance.IsInLordGymDungeon() && !TowerModel.Instance.IsOpenFloorFormation() && instance.IsAllRoleDie)
			{
				Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "[BattleTeam2D] 全角色已死亡", default(ReadOnlySpan<ValueTuple<string, object>>));
				button.SetSelfInteractive(false);
				return;
			}
			if (!instance.GetAllRoleCanAddToTeam().Item1)
			{
				Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "[BattleTeam2D] 未通过副本条件检测", default(ReadOnlySpan<ValueTuple<string, object>>));
				button.SetSelfInteractive(false);
				return;
			}
			int roleCountInRoleSlot = instance.RoleCountInRoleSlot;
			if ((instance.Context.IsMultiInstanceDungeon || TowerDefenseController.Instance.CheckInUiFlow()) && !instance.Context.IsInLimitRoleCount(roleCountInRoleSlot))
			{
				Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "[BattleTeam2D] 角色人数不符合要求", default(ReadOnlySpan<ValueTuple<string, object>>));
				button.SetSelfInteractive(false);
				return;
			}
			if (!ViewExtensionRegistry.CollectEnterGate(this.ViewExtensions).Ok)
			{
				button.SetSelfInteractive(false);
				return;
			}
			button.SetSelfInteractive(true);
			return;
		}
	}

	// Token: 0x0600D586 RID: 54662 RVA: 0x00313F0C File Offset: 0x0031210C
	private void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshBattleRoleSlot, new Action<ERefreshRoleSlotReason>(this.OnRefreshBattleRoleSlot));
	}

	// Token: 0x0600D587 RID: 54663 RVA: 0x00313F2A File Offset: 0x0031212A
	private void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshBattleRoleSlot, new Action<ERefreshRoleSlotReason>(this.OnRefreshBattleRoleSlot));
	}

	// Token: 0x0600D588 RID: 54664 RVA: 0x00313F48 File Offset: 0x00312148
	private void OnRefreshBattleRoleSlot(ERefreshRoleSlotReason reason)
	{
		this.OnRefreshRoleView(null);
	}

	// Token: 0x0600D589 RID: 54665 RVA: 0x00313F51 File Offset: 0x00312151
	protected override void OnClickConfirm()
	{
		BattleTeamEnterFlow.Execute(new IBattleTeamEnterContext
		{
			CanUseSpecialTrialRole = this.CanUseSpecialTrailRole,
			RefreshConfirm = delegate()
			{
				this.RefreshConfirmButton();
			}
		});
	}

	// Token: 0x0600D58A RID: 54666 RVA: 0x00313F7B File Offset: 0x0031217B
	protected override bool IsAllowClose()
	{
		return true;
	}

	// Token: 0x0600D58B RID: 54667 RVA: 0x00313F80 File Offset: 0x00312180
	protected override void OnClickClose()
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		if (!instance.Context.IsMultiInstanceDungeon)
		{
			bool flag = TowerModel.Instance.CheckInTower();
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.TowerFloorView);
			if (flag && viewByName == null)
			{
				TowerConfig? towerInfo = TowerClimbConfig.Instance.GetTowerInfo(TowerModel.Instance.CurrentSelectFloor);
				UiManager.Instance.OpenView(EUiViewName.TowerFloorView, towerInfo.Value.AreaNum, null);
			}
			FormationController.Instance.ExitBattleTeam(true);
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(instance.IsLeaderSelf ? EConfirmBoxConfigId.EditBattleTeamDisband : EConfirmBoxConfigId.EditBattleTeamExit);
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			FormationController.Instance.ExitBattleTeam(true);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600D58C RID: 54668 RVA: 0x00314050 File Offset: 0x00312250
	protected override void OnClickQuickSelect()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.QuickRoleSelectView))
		{
			return;
		}
		BattleTeamModel instance = BattleTeamModel.Instance;
		List<int> list = new List<int>();
		foreach (BattleRoleSlotData battleRoleSlotData in instance.GetAllSlots())
		{
			BattleRoleData roleData = battleRoleSlotData.RoleData;
			if (roleData != null)
			{
				list.Add(roleData.ConfigId);
			}
		}
		List<RoleDataBase> roleList = instance.GetRoleList();
		QuickRoleSelectViewData quickRoleSelectViewData = new QuickRoleSelectViewData(this.GetUseWay(), list.ToArray(), roleList);
		quickRoleSelectViewData.OnConfirm = new Action<int[]>(this.OnQuickSelectConfirm);
		quickRoleSelectViewData.CanConfirm = new Func<int[], bool>(base.OnQuickSelectCanConfirm);
		quickRoleSelectViewData.CanSelectRole = new Func<int, int[], bool>(base.OnQuickSelectCanSelect);
		quickRoleSelectViewData.OnBack = new Action(this.OnCloseSelectedRoleView);
		quickRoleSelectViewData.OnHideFinish = new Action(this.OnRoleSelectionHideFinished);
		quickRoleSelectViewData.CanUseSpecialTrialRole = this.CanUseSpecialTrailRole;
		UiManager.Instance.OpenView(EUiViewName.QuickRoleSelectView, quickRoleSelectViewData, delegate(bool isSuccess, int viewId)
		{
			if (isSuccess)
			{
				base.AddChildViewById(viewId);
			}
		});
		base.SetCloseButtonVisible(false);
	}

	// Token: 0x0600D58D RID: 54669 RVA: 0x00314178 File Offset: 0x00312378
	protected override void OnAddRoleButtonClicked(int position)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		Aki.Config.FightFormation? fightFormation = instance.Context.GetFightFormation();
		if (fightFormation == null || !fightFormation.Value.ChooseRole)
		{
			ScrollingTipsController.Instance.ShowTipsById("NoChangeRole", Array.Empty<object>());
			return;
		}
		instance.SetCurrentEditPosition(position);
		this.EditPosition = position;
		BattleRoleSlotData slot = instance.GetSlot(position);
		if (slot == null)
		{
			return;
		}
		BattleRoleData selectedRoleData = slot.RoleData;
		if (selectedRoleData != null)
		{
			if (instance.Context.IsMultiInstanceDungeon && InstanceDungeonModel.Instance.IsMatchTeamHost() && !selectedRoleData.IsSelf)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MatchingKickOut);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					InstanceDungeonEntranceController.Instance.KickMatchTeamPlayerRequest(selectedRoleData.PlayerId);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			if (!slot.CanEditRoleSlot)
			{
				ScrollingTipsController.Instance.ShowTipsById("BattleTeamNotMyRole", Array.Empty<object>());
				return;
			}
			if (!instance.IsLeaderSelf && selectedRoleData.IsReady)
			{
				ScrollingTipsController.Instance.ShowTipsById("BattleTeamReadyRole", Array.Empty<object>());
				return;
			}
			this.OpenTeamSelectView(position);
		}
		else
		{
			if (instance.Context.IsMultiInstanceDungeon && !InstanceDungeonModel.Instance.IsMatchTeamHost())
			{
				ScrollingTipsController.Instance.ShowTipsById("BattleTeamNotMyRole", Array.Empty<object>());
				return;
			}
			if (slot.IsProhibit)
			{
				ScrollingTipsController.Instance.ShowTipsById("BattleTeamPositionCanNotEdit", Array.Empty<object>());
				return;
			}
			this.OpenTeamSelectView(position);
		}
		base.SetCloseButtonVisible(false);
	}

	// Token: 0x0600D58E RID: 54670 RVA: 0x00314300 File Offset: 0x00312500
	private void OpenTeamSelectView(int position)
	{
		if (UiManager.Instance.IsViewShow(EUiViewName.TeamRoleSelectView))
		{
			return;
		}
		if (BattleTeamModel.Instance.Context.IsMultiInstanceDungeon)
		{
			OnlineController.Instance.MatchChangePlayerUiStateRequest(EMatchPlayerUiState.Selecting);
		}
		UiManager.Instance.OpenView(EUiViewName.TeamRoleSelectView, this.GetRoleSelectViewData(), null);
	}

	// Token: 0x0600D58F RID: 54671 RVA: 0x00314354 File Offset: 0x00312554
	protected override TeamRoleSelectViewData GetRoleSelectViewData()
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		List<RoleDataBase> roleList = instance.GetRoleList();
		BattleRoleSlotData slot = instance.GetSlot(this.EditPosition);
		int? num;
		if (slot == null)
		{
			num = null;
		}
		else
		{
			BattleRoleData roleData = slot.RoleData;
			num = ((roleData != null) ? new int?(roleData.ConfigId) : null);
		}
		int? num2 = num;
		TeamRoleSelectViewData teamRoleSelectViewData = new TeamRoleSelectViewData(this.GetUseWay(), num2.GetValueOrDefault(), roleList, new Action<int>(this.OnEnsureFormation), new Action(this.OnCloseSelectedRoleView), new int?(this.EditPosition), null);
		teamRoleSelectViewData.SetGetConfirmButtonEnableFunction((int roleId) => this.Validator.IsConfirmButtonEnable(roleId, 0, this.EditPosition));
		teamRoleSelectViewData.SetGetConfirmButtonTextFunction((int roleId) => this.Validator.GetConfirmButtonTextId(roleId, 0, this.EditPosition));
		teamRoleSelectViewData.SetHideFinishCallBack(new Action(this.OnRoleSelectionHideFinished));
		if (instance.Context.IsMultiInstanceDungeon)
		{
			teamRoleSelectViewData.SetOtherTeamSlotData(BattleTeamModel.Instance.GetAllSlots());
		}
		teamRoleSelectViewData.SetConfirmCheckFunction((int roleId) => this.Validator.ConfirmCheck(roleId, 0, this.EditPosition));
		teamRoleSelectViewData.IsNeedRevive = ((int roleId) => this.Validator.IsNeedRevive(roleId, 0));
		teamRoleSelectViewData.CanJoinTeam = ((int roleId) => this.Validator.CanJoinTeam(roleId, 0));
		teamRoleSelectViewData.CanUseSpecialTrialRole = this.CanUseSpecialTrailRole;
		List<int> list = new List<int>();
		int playerId = CreatureModel.Instance.GetPlayerId();
		foreach (BattleRoleSlotData battleRoleSlotData in instance.GetAllSlots())
		{
			BattleRoleData roleData2 = battleRoleSlotData.RoleData;
			if (roleData2 != null && (!instance.Context.IsMultiInstanceDungeon || roleData2.PlayerId == playerId))
			{
				list.Add(roleData2.ConfigId);
			}
		}
		teamRoleSelectViewData.FormationRoleList = list.ToArray();
		return teamRoleSelectViewData;
	}

	// Token: 0x0600D590 RID: 54672 RVA: 0x00314514 File Offset: 0x00312714
	protected override void OnEnsureFormation(int roleId)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		BattleRoleSlotData currentEditRoleSlotData = instance.CurrentEditRoleSlotData;
		BattleRoleData battleRoleData = (currentEditRoleSlotData != null) ? currentEditRoleSlotData.RoleData : null;
		if (battleRoleData != null && !battleRoleData.IsSelf)
		{
			Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "[BattleTeam2D]无法改变别的玩家的角色", default(ReadOnlySpan<ValueTuple<string, object>>));
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamLastRole", Array.Empty<object>());
			return;
		}
		base.SetCloseButtonVisible(true);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (roleDataById == null)
		{
			return;
		}
		if (!roleDataById.IsTrialRole() && !instance.Context.CanAddRoleToEditTeam(roleId))
		{
			return;
		}
		switch (this.Validator.GetEditResultType(roleId))
		{
		case EEditResultType.GoDown:
			if (battleRoleData != null)
			{
				TowerDefenseModel.Instance.ResetPhantomOwnerDataByConfigId(battleRoleData.ConfigId);
			}
			currentEditRoleSlotData.ResetRoleData();
			break;
		case EEditResultType.InOtherSlot:
		{
			if (currentEditRoleSlotData == null)
			{
				ScrollingTipsController.Instance.ShowTipsById("IsInTeam", Array.Empty<object>());
				return;
			}
			BattleRoleSlotData slotDataByConfigId = instance.GetSlotDataByConfigId(roleId);
			if (slotDataByConfigId == null)
			{
				return;
			}
			BattleRoleData roleData = slotDataByConfigId.RoleData;
			if (roleData == null)
			{
				return;
			}
			BattleRoleData roleData2 = currentEditRoleSlotData.RoleData;
			if (roleData2 == null)
			{
				slotDataByConfigId.ResetRoleData();
				return;
			}
			slotDataByConfigId.SetRoleData(roleData2);
			currentEditRoleSlotData.SetRoleData(roleData);
			break;
		}
		case EEditResultType.SelectedNone:
			return;
		default:
		{
			RoleLevelData levelData = roleDataById.GetLevelData();
			BattleRoleData battleRoleData2 = currentEditRoleSlotData.RoleData;
			if (battleRoleData2 == null)
			{
				battleRoleData2 = instance.CreateRoleDataFromRoleInstance(roleDataById);
			}
			else
			{
				TowerDefenseModel.Instance.ResetPhantomOwnerDataByConfigId(battleRoleData2.ConfigId);
			}
			battleRoleData2.ConfigId = roleId;
			battleRoleData2.Level = levelData.GetLevel();
			battleRoleData2.SkinId = roleDataById.GetRoleSkinId();
			currentEditRoleSlotData.SetRoleData(battleRoleData2);
			break;
		}
		}
		if (instance.Context.IsMultiInstanceDungeon)
		{
			ValueTuple<List<int>, List<int>> ownRoleConfigIdList = instance.OwnRoleConfigIdList;
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Formation;
			ELogAuthor author = ELogAuthor.SYB;
			string message = "[BattleTeam2D]请求改变战前编队角色:RoleConfigList";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RoleConfigList", ownRoleConfigIdList);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			InstanceDungeonEntranceController.Instance.MatchChangeRoleRequest(instance.OwnRoleConfigIdList.Item1);
			return;
		}
		this.RefreshEnterButtonEnable();
		EventSystem.Instance.Emit<ERefreshRoleSlotReason>(EEventName.OnRefreshBattleRoleSlot, ERefreshRoleSlotReason.ClickConfirmTeam);
	}

	// Token: 0x0600D591 RID: 54673 RVA: 0x00314714 File Offset: 0x00312914
	protected override void OnQuickSelectConfirm(int[] roleIdList)
	{
		base.SetCloseButtonVisible(true);
		BattleTeamModel instance = BattleTeamModel.Instance;
		foreach (int num in instance.SelfRoleSlotDataRoleIdList)
		{
			if (Array.IndexOf<int>(roleIdList, num) == -1)
			{
				TowerDefenseModel.Instance.ResetPhantomOwnerDataByConfigId(num);
			}
		}
		for (int i = 1; i <= 4; i++)
		{
			BattleRoleSlotData slot = instance.GetSlot(i);
			if (slot.IsProhibit)
			{
				slot.ResetRoleData();
			}
			else if (i > roleIdList.Length)
			{
				slot.ResetRoleData();
			}
			else
			{
				int id = roleIdList[i - 1];
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(id, true);
				BattleRoleData roleData = instance.CreateRoleDataFromRoleInstance(roleDataById);
				slot.SetRoleData(roleData);
			}
		}
		this.RefreshEnterButtonEnable();
		EventSystem.Instance.Emit<ERefreshRoleSlotReason>(EEventName.OnRefreshBattleRoleSlot, ERefreshRoleSlotReason.ClickConfirmTeam);
	}

	// Token: 0x0600D592 RID: 54674 RVA: 0x003147F8 File Offset: 0x003129F8
	private void OnRoleSelectionHideFinished()
	{
		base.SetCloseButtonVisible(true);
		this.OnRefreshRoleView(null);
		BattleTeamModel instance = BattleTeamModel.Instance;
		if (instance.Context.IsMultiInstanceDungeon && instance.LeaderPlayerId != null)
		{
			OnlineController.Instance.MatchChangePlayerUiStateRequest(InstanceDungeonEntranceModel.Instance.EditBattleTeamMatching ? EMatchPlayerUiState.Matching : EMatchPlayerUiState.Wait);
		}
	}

	// Token: 0x0600D593 RID: 54675 RVA: 0x00314850 File Offset: 0x00312A50
	private void OnCloseSelectedRoleView()
	{
		base.SetCloseButtonVisible(true);
	}

	// Token: 0x0600D594 RID: 54676 RVA: 0x0031485C File Offset: 0x00312A5C
	private void ExchangeRoleCallBack(int position1, int position2, int roleId1, int roleId2)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		for (int i = 1; i <= 4; i++)
		{
			BattleRoleSlotData slot = instance.GetSlot(i);
			if (slot.IsProhibit)
			{
				slot.ResetRoleData();
			}
			else
			{
				int num = 0;
				if (i == position1)
				{
					num = roleId1;
				}
				if (i == position2)
				{
					num = roleId2;
				}
				if (num != 0)
				{
					RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num, true);
					BattleRoleData roleData = instance.CreateRoleDataFromRoleInstance(roleDataById);
					slot.SetRoleData(roleData);
				}
			}
		}
		this.OnRefreshRoleView(new int[]
		{
			position1,
			position2
		});
	}

	// Token: 0x0600D595 RID: 54677 RVA: 0x003148D9 File Offset: 0x00312AD9
	private void OnAddPlayerButtonClicked()
	{
		MultiPlayerViewExtension multiPlayerExt = this.MultiPlayerExt;
		if (multiPlayerExt == null)
		{
			return;
		}
		multiPlayerExt.OnClickAddPlayer();
	}

	// Token: 0x0600D596 RID: 54678 RVA: 0x003148EB File Offset: 0x00312AEB
	private void OnInviteButtonClicked()
	{
		MultiPlayerViewExtension multiPlayerExt = this.MultiPlayerExt;
		if (multiPlayerExt == null)
		{
			return;
		}
		multiPlayerExt.OnClickInvite();
	}

	// Token: 0x0600D597 RID: 54679 RVA: 0x003148FD File Offset: 0x00312AFD
	private void OnClickChat()
	{
		MultiPlayerViewExtension multiPlayerExt = this.MultiPlayerExt;
		if (multiPlayerExt == null)
		{
			return;
		}
		multiPlayerExt.OnClickChat();
	}

	// Token: 0x0600D598 RID: 54680 RVA: 0x0031490F File Offset: 0x00312B0F
	private void OnClickTowerDetailsBtn()
	{
		TowerViewExtension towerExt = this.TowerExt;
		if (towerExt == null)
		{
			return;
		}
		towerExt.OnClickTowerDetails();
	}

	// Token: 0x0600D599 RID: 54681 RVA: 0x00314921 File Offset: 0x00312B21
	private void OnClickTowerRecommendBtn()
	{
		TowerViewExtension towerExt = this.TowerExt;
		if (towerExt == null)
		{
			return;
		}
		towerExt.OnClickTowerRecommend();
	}

	// Token: 0x0600D59A RID: 54682 RVA: 0x00314933 File Offset: 0x00312B33
	private EFilterSortGroupId GetUseWay()
	{
		if (TowerModel.Instance.IsOpenFloorFormation())
		{
			return EFilterSortGroupId.TowerFormation;
		}
		if (WeeklyRogueModel.Instance.IsWeeklyRogueOpen())
		{
			return EFilterSortGroupId.WeeklyRogueEditFormation;
		}
		return EFilterSortGroupId.EditBattleTeam;
	}

	// Token: 0x0600D59B RID: 54683 RVA: 0x00314954 File Offset: 0x00312B54
	private bool IfNeedHideMultiFormationTab()
	{
		BattleTeamDungeonContext context = BattleTeamModel.Instance.Context;
		InstanceDungeon? dungeonConfig = context.GetDungeonConfig();
		if (dungeonConfig != null && dungeonConfig.Value.InstSubType == 33)
		{
			return true;
		}
		Aki.Config.FightFormation? fightFormation = context.GetFightFormation();
		return GameModeModel.Instance.IsMulti || fightFormation == null || !fightFormation.Value.ChooseRole;
	}

	// Token: 0x0600D59C RID: 54684 RVA: 0x003149C2 File Offset: 0x00312BC2
	protected override bool IsCurrentTab(int formationId)
	{
		return false;
	}

	// Token: 0x0600D59D RID: 54685 RVA: 0x003149C8 File Offset: 0x00312BC8
	protected override void OnFormationButtonClicked(int index)
	{
		if (this.IsTabInit)
		{
			this.IsTabInit = false;
			return;
		}
		int num = index + 1;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Formation;
		ELogAuthor author = ELogAuthor.SYB;
		string message = "[BattleTeam2D] 当点击编队按钮时";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("formationId", num);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		BattleTeamModel instance2 = BattleTeamModel.Instance;
		RoleModel instance3 = RoleModel.Instance;
		FormationData formationData = FormationModel.Instance.GetFormationData(num);
		List<int> list = (formationData != null) ? formationData.RoleIdList : null;
		foreach (int configId in instance2.SelfRoleSlotDataRoleIdList)
		{
			TowerDefenseModel.Instance.ResetPhantomOwnerDataByConfigId(configId);
		}
		for (int i = 1; i <= 4; i++)
		{
			BattleRoleSlotData slot = instance2.GetSlot(i);
			if (list == null)
			{
				slot.ResetRoleData();
			}
			else if (slot.IsProhibit)
			{
				slot.ResetRoleData();
			}
			else
			{
				int num2 = (i - 1 < list.Count) ? list[i - 1] : 0;
				if (num2 == 0)
				{
					slot.ResetRoleData();
				}
				else
				{
					RoleDataBase roleDataById = instance3.GetRoleDataById(num2, true);
					BattleRoleData roleData = instance2.CreateRoleDataFromRoleInstance(roleDataById);
					slot.SetRoleData(roleData);
				}
			}
		}
		this.OnRefreshRoleView(null);
		EventSystem.Instance.Emit<ERefreshRoleSlotReason>(EEventName.OnRefreshBattleRoleSlot, ERefreshRoleSlotReason.ChangeTeamOffline);
	}

	// Token: 0x0600D59E RID: 54686 RVA: 0x00314B1C File Offset: 0x00312D1C
	private void RefreshTitle(bool isInTower)
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		UUIText text = base.GetText(16);
		int[] elementList = null;
		IEditBattleTeamViewParam editBattleTeamViewParam = this.OpenParam as IEditBattleTeamViewParam;
		if (editBattleTeamViewParam != null && editBattleTeamViewParam.IsHideTitle)
		{
			base.GetItem(24).SetUIActive(false);
			return;
		}
		if (isInTower)
		{
			int currentSelectFloor = TowerModel.Instance.CurrentSelectFloor;
			TowerConfig value = TowerClimbConfig.Instance.GetTowerInfo(currentSelectFloor).Value;
			string towerAreaName = TowerClimbConfig.Instance.GetTowerAreaName(currentSelectFloor);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(16), "Text_TowerAreaFloor_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				towerAreaName,
				value.Floor
			}));
			elementList = value.GetRecommendElementArray();
		}
		else
		{
			InstanceDungeon? dungeonConfig = instance.Context.GetDungeonConfig();
			if (dungeonConfig != null)
			{
				string text2 = ConfigMultiTextLang.GetLocalTextNew(dungeonConfig.Value.MapName, null) ?? "";
				elementList = dungeonConfig.Value.GetRecommendElementArray();
				if (GameModeModel.Instance.IsMulti)
				{
					text2 += OnlineModel.Instance.GetMultiInstanceRecommendLevelText(dungeonConfig.Value.Id);
				}
				if (text != null)
				{
					text.SetText(text2, true);
				}
			}
		}
		RecommendElementComponent recommendElement = this.RecommendElement;
		if (recommendElement == null)
		{
			return;
		}
		recommendElement.RefreshElements(elementList);
	}

	// Token: 0x0600D59F RID: 54687 RVA: 0x00314C6B File Offset: 0x00312E6B
	private void UpdateRecommendLevel()
	{
		RecommendElementComponent recommendElement = this.RecommendElement;
		if (recommendElement == null)
		{
			return;
		}
		recommendElement.UpdateRecommendLevel(this.CanShowLowLevelTips());
	}

	// Token: 0x0600D5A0 RID: 54688 RVA: 0x00314C84 File Offset: 0x00312E84
	private void RefreshTowerDefenceWarningTips()
	{
		UUISprite sprite = base.GetSprite(31);
		if (sprite == null)
		{
			return;
		}
		if (!TowerDefenseController.Instance.CheckInUiFlow())
		{
			sprite.SetUIActive(false);
			return;
		}
		bool flag = TowerDefenseController.Instance.CheckNeedSurvivalWarning();
		sprite.SetUIActive(flag);
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(32), "TowerDefence_Survive_WarnText", Array.Empty<object>());
		}
	}

	// Token: 0x0600D5A1 RID: 54689 RVA: 0x00314CE3 File Offset: 0x00312EE3
	private bool CanShowLowLevelTips()
	{
		return !TowerDefenseController.Instance.CheckInUiFlow() || !TowerDefenseController.Instance.CheckNeedSurvivalWarning();
	}

	// Token: 0x0600D5A2 RID: 54690 RVA: 0x00314D00 File Offset: 0x00312F00
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 1)
		{
			return null;
		}
		string text = configParams[0];
		if (text.Contains("FirstSelf"))
		{
			BattleTeamModel instance = BattleTeamModel.Instance;
			int i = 0;
			while (i < 4)
			{
				BattleRoleSlotData slot = instance.GetSlot(i + 1);
				bool flag;
				if (slot == null)
				{
					flag = false;
				}
				else
				{
					BattleRoleData roleData = slot.RoleData;
					flag = ((roleData != null) ? new bool?(roleData.IsSelf) : null).GetValueOrDefault();
				}
				if (flag)
				{
					FormationRoleSlot formationRoleSlot = this.Presenter.RoleSlots[i];
					if (formationRoleSlot == null)
					{
						return null;
					}
					return formationRoleSlot.GetGuideUiItemAndUiItemForShowEx(configParams);
				}
				else
				{
					i++;
				}
			}
		}
		if (!text.Contains("FirstDangoSlot"))
		{
			return null;
		}
		FormationRoleSlot formationRoleSlot2 = this.Presenter.RoleSlots[0];
		if (formationRoleSlot2 == null)
		{
			return null;
		}
		return formationRoleSlot2.GetGuideUiItemAndUiItemForShowEx(configParams);
	}

	// Token: 0x040061C2 RID: 25026
	private bool IsTabInit;

	// Token: 0x040061C3 RID: 25027
	[Nullable(2)]
	private RecommendElementComponent RecommendElement;

	// Token: 0x040061C4 RID: 25028
	[Nullable(2)]
	private MultiPlayerViewExtension MultiPlayerExt;

	// Token: 0x040061C5 RID: 25029
	[Nullable(2)]
	private TowerViewExtension TowerExt;

	// Token: 0x040061C6 RID: 25030
	private List<IViewExtension> ViewExtensions = new List<IViewExtension>();

	// Token: 0x02008196 RID: 33174
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A475 RID: 173173
		RoleSlot1,
		// Token: 0x0402A476 RID: 173174
		RoleSlot2,
		// Token: 0x0402A477 RID: 173175
		RoleSlot3,
		// Token: 0x0402A478 RID: 173176
		CloseButton,
		// Token: 0x0402A479 RID: 173177
		EnterButton,
		// Token: 0x0402A47A RID: 173178
		EnterButtonText,
		// Token: 0x0402A47B RID: 173179
		AddPlayerButton,
		// Token: 0x0402A47C RID: 173180
		InviteButton,
		// Token: 0x0402A47D RID: 173181
		ChatButton,
		// Token: 0x0402A47E RID: 173182
		ChatInfoItem,
		// Token: 0x0402A47F RID: 173183
		ChatInfoText,
		// Token: 0x0402A480 RID: 173184
		TabComponent,
		// Token: 0x0402A481 RID: 173185
		TabItem,
		// Token: 0x0402A482 RID: 173186
		TowerItem,
		// Token: 0x0402A483 RID: 173187
		TowerDetailsBtn,
		// Token: 0x0402A484 RID: 173188
		TowerRecommendBtn,
		// Token: 0x0402A485 RID: 173189
		BattleTitleText,
		// Token: 0x0402A486 RID: 173190
		BattleIcon,
		// Token: 0x0402A487 RID: 173191
		TitleText,
		// Token: 0x0402A488 RID: 173192
		QuickSelectButton,
		// Token: 0x0402A489 RID: 173193
		ElementContent,
		// Token: 0x0402A48A RID: 173194
		ElementItem,
		// Token: 0x0402A48B RID: 173195
		RecommendElementItem,
		// Token: 0x0402A48C RID: 173196
		LowLevelItem,
		// Token: 0x0402A48D RID: 173197
		TitleItem,
		// Token: 0x0402A48E RID: 173198
		DragItem,
		// Token: 0x0402A48F RID: 173199
		DragRoleItem,
		// Token: 0x0402A490 RID: 173200
		BtnTipsItem,
		// Token: 0x0402A491 RID: 173201
		LoadingItem,
		// Token: 0x0402A492 RID: 173202
		WarningTipsSprite = 31,
		// Token: 0x0402A493 RID: 173203
		WarningTipsText
	}
}
