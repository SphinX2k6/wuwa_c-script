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

// Token: 0x020010B7 RID: 4279
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
	// Token: 0x0600A986 RID: 43398 RVA: 0x0031E42C File Offset: 0x0031C62C
	public BattleTeam2D(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x170011C0 RID: 4544
	// (get) Token: 0x0600A987 RID: 43399 RVA: 0x0031E4A4 File Offset: 0x0031C6A4
	protected override BattleTeamDataProvider Provider { get; } = new BattleTeamDataProvider();

	// Token: 0x170011C1 RID: 4545
	// (get) Token: 0x0600A988 RID: 43400 RVA: 0x0031E4AC File Offset: 0x0031C6AC
	protected override BattleTeamContextValidator Validator { get; } = new BattleTeamContextValidator();

	// Token: 0x170011C2 RID: 4546
	// (get) Token: 0x0600A989 RID: 43401 RVA: 0x0031E4B4 File Offset: 0x0031C6B4
	protected override SlotPresenter2D Presenter { get; } = new SlotPresenter2D();

	// Token: 0x170011C3 RID: 4547
	// (get) Token: 0x0600A98A RID: 43402 RVA: 0x0031E4BC File Offset: 0x0031C6BC
	protected override FormationViewKeys Keys { get; } = new FormationViewKeys
	{
		Close = 3,
		Tab = 11,
		Confirm = 4,
		QuickSelect = 19,
		Loading = 28,
		ConfirmText = 5
	};

	// Token: 0x0600A98B RID: 43403 RVA: 0x0031E4C4 File Offset: 0x0031C6C4
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

	// Token: 0x0600A98C RID: 43404 RVA: 0x0031EA3C File Offset: 0x0031CC3C
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

	// Token: 0x0600A98D RID: 43405 RVA: 0x0031EA9C File Offset: 0x0031CC9C
	protected override UniTask OnBeforeStartAsync()
	{
		BattleTeam2D.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BattleTeam2D.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A98E RID: 43406 RVA: 0x0031EAE0 File Offset: 0x0031CCE0
	private void InitViewParam()
	{
		IEditBattleTeamViewParam editBattleTeamViewParam = this.OpenParam as IEditBattleTeamViewParam;
		BattleTeamModel instance = BattleTeamModel.Instance;
		bool isMultiInstanceDungeon = instance.Context.IsMultiInstanceDungeon;
		this.CanUseSpecialTrailRole = ((editBattleTeamViewParam == null || editBattleTeamViewParam.CanUseSpecialTrailRole) && !isMultiInstanceDungeon);
		instance.CanUseSpecialTrialRole = this.CanUseSpecialTrailRole;
	}

	// Token: 0x0600A98F RID: 43407 RVA: 0x0031EB30 File Offset: 0x0031CD30
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

	// Token: 0x0600A990 RID: 43408 RVA: 0x0031EBCC File Offset: 0x0031CDCC
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

	// Token: 0x0600A991 RID: 43409 RVA: 0x0031EC24 File Offset: 0x0031CE24
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

	// Token: 0x0600A992 RID: 43410 RVA: 0x0031ECAC File Offset: 0x0031CEAC
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

	// Token: 0x0600A993 RID: 43411 RVA: 0x0031EDC4 File Offset: 0x0031CFC4
	protected UniTask CreateAllSlotsAsync()
	{
		BattleTeam2D.<CreateAllSlotsAsync>d__27 <CreateAllSlotsAsync>d__;
		<CreateAllSlotsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAllSlotsAsync>d__.<>4__this = this;
		<CreateAllSlotsAsync>d__.<>1__state = -1;
		<CreateAllSlotsAsync>d__.<>t__builder.Start<BattleTeam2D.<CreateAllSlotsAsync>d__27>(ref <CreateAllSlotsAsync>d__);
		return <CreateAllSlotsAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A994 RID: 43412 RVA: 0x0031EE07 File Offset: 0x0031D007
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

	// Token: 0x0600A995 RID: 43413 RVA: 0x0031EE34 File Offset: 0x0031D034
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

	// Token: 0x0600A996 RID: 43414 RVA: 0x0031EF24 File Offset: 0x0031D124
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

	// Token: 0x0600A997 RID: 43415 RVA: 0x0031EF64 File Offset: 0x0031D164
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

	// Token: 0x0600A998 RID: 43416 RVA: 0x0031F084 File Offset: 0x0031D284
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

	// Token: 0x0600A999 RID: 43417 RVA: 0x0031F208 File Offset: 0x0031D408
	private void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshBattleRoleSlot, new Action<ERefreshRoleSlotReason>(this.OnRefreshBattleRoleSlot));
	}

	// Token: 0x0600A99A RID: 43418 RVA: 0x0031F226 File Offset: 0x0031D426
	private void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshBattleRoleSlot, new Action<ERefreshRoleSlotReason>(this.OnRefreshBattleRoleSlot));
	}

	// Token: 0x0600A99B RID: 43419 RVA: 0x0031F244 File Offset: 0x0031D444
	private void OnRefreshBattleRoleSlot(ERefreshRoleSlotReason reason)
	{
		this.OnRefreshRoleView(null);
	}

	// Token: 0x0600A99C RID: 43420 RVA: 0x0031F24D File Offset: 0x0031D44D
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

	// Token: 0x0600A99D RID: 43421 RVA: 0x0031F277 File Offset: 0x0031D477
	protected override bool IsAllowClose()
	{
		return true;
	}

	// Token: 0x0600A99E RID: 43422 RVA: 0x0031F27C File Offset: 0x0031D47C
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

	// Token: 0x0600A99F RID: 43423 RVA: 0x0031F34C File Offset: 0x0031D54C
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

	// Token: 0x0600A9A0 RID: 43424 RVA: 0x0031F474 File Offset: 0x0031D674
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

	// Token: 0x0600A9A1 RID: 43425 RVA: 0x0031F5FC File Offset: 0x0031D7FC
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

	// Token: 0x0600A9A2 RID: 43426 RVA: 0x0031F650 File Offset: 0x0031D850
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

	// Token: 0x0600A9A3 RID: 43427 RVA: 0x0031F810 File Offset: 0x0031DA10
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

	// Token: 0x0600A9A4 RID: 43428 RVA: 0x0031FA10 File Offset: 0x0031DC10
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

	// Token: 0x0600A9A5 RID: 43429 RVA: 0x0031FAF4 File Offset: 0x0031DCF4
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

	// Token: 0x0600A9A6 RID: 43430 RVA: 0x0031FB4C File Offset: 0x0031DD4C
	private void OnCloseSelectedRoleView()
	{
		base.SetCloseButtonVisible(true);
	}

	// Token: 0x0600A9A7 RID: 43431 RVA: 0x0031FB58 File Offset: 0x0031DD58
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

	// Token: 0x0600A9A8 RID: 43432 RVA: 0x0031FBD5 File Offset: 0x0031DDD5
	private void OnAddPlayerButtonClicked()
	{
		MultiPlayerViewExtension multiPlayerExt = this.MultiPlayerExt;
		if (multiPlayerExt == null)
		{
			return;
		}
		multiPlayerExt.OnClickAddPlayer();
	}

	// Token: 0x0600A9A9 RID: 43433 RVA: 0x0031FBE7 File Offset: 0x0031DDE7
	private void OnInviteButtonClicked()
	{
		MultiPlayerViewExtension multiPlayerExt = this.MultiPlayerExt;
		if (multiPlayerExt == null)
		{
			return;
		}
		multiPlayerExt.OnClickInvite();
	}

	// Token: 0x0600A9AA RID: 43434 RVA: 0x0031FBF9 File Offset: 0x0031DDF9
	private void OnClickChat()
	{
		MultiPlayerViewExtension multiPlayerExt = this.MultiPlayerExt;
		if (multiPlayerExt == null)
		{
			return;
		}
		multiPlayerExt.OnClickChat();
	}

	// Token: 0x0600A9AB RID: 43435 RVA: 0x0031FC0B File Offset: 0x0031DE0B
	private void OnClickTowerDetailsBtn()
	{
		TowerViewExtension towerExt = this.TowerExt;
		if (towerExt == null)
		{
			return;
		}
		towerExt.OnClickTowerDetails();
	}

	// Token: 0x0600A9AC RID: 43436 RVA: 0x0031FC1D File Offset: 0x0031DE1D
	private void OnClickTowerRecommendBtn()
	{
		TowerViewExtension towerExt = this.TowerExt;
		if (towerExt == null)
		{
			return;
		}
		towerExt.OnClickTowerRecommend();
	}

	// Token: 0x0600A9AD RID: 43437 RVA: 0x0031FC2F File Offset: 0x0031DE2F
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

	// Token: 0x0600A9AE RID: 43438 RVA: 0x0031FC50 File Offset: 0x0031DE50
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

	// Token: 0x0600A9AF RID: 43439 RVA: 0x0031FCBE File Offset: 0x0031DEBE
	protected override bool IsCurrentTab(int formationId)
	{
		return false;
	}

	// Token: 0x0600A9B0 RID: 43440 RVA: 0x0031FCC4 File Offset: 0x0031DEC4
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

	// Token: 0x0600A9B1 RID: 43441 RVA: 0x0031FE18 File Offset: 0x0031E018
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

	// Token: 0x0600A9B2 RID: 43442 RVA: 0x0031FF67 File Offset: 0x0031E167
	private void UpdateRecommendLevel()
	{
		RecommendElementComponent recommendElement = this.RecommendElement;
		if (recommendElement == null)
		{
			return;
		}
		recommendElement.UpdateRecommendLevel(this.CanShowLowLevelTips());
	}

	// Token: 0x0600A9B3 RID: 43443 RVA: 0x0031FF80 File Offset: 0x0031E180
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

	// Token: 0x0600A9B4 RID: 43444 RVA: 0x0031FFDF File Offset: 0x0031E1DF
	private bool CanShowLowLevelTips()
	{
		return !TowerDefenseController.Instance.CheckInUiFlow() || !TowerDefenseController.Instance.CheckNeedSurvivalWarning();
	}

	// Token: 0x0600A9B5 RID: 43445 RVA: 0x0031FFFC File Offset: 0x0031E1FC
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

	// Token: 0x04006294 RID: 25236
	private bool IsTabInit;

	// Token: 0x04006295 RID: 25237
	[Nullable(2)]
	private RecommendElementComponent RecommendElement;

	// Token: 0x04006296 RID: 25238
	[Nullable(2)]
	private MultiPlayerViewExtension MultiPlayerExt;

	// Token: 0x04006297 RID: 25239
	[Nullable(2)]
	private TowerViewExtension TowerExt;

	// Token: 0x04006298 RID: 25240
	private List<IViewExtension> ViewExtensions = new List<IViewExtension>();

	// Token: 0x02007322 RID: 29474
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040257A3 RID: 153507
		RoleSlot1,
		// Token: 0x040257A4 RID: 153508
		RoleSlot2,
		// Token: 0x040257A5 RID: 153509
		RoleSlot3,
		// Token: 0x040257A6 RID: 153510
		CloseButton,
		// Token: 0x040257A7 RID: 153511
		EnterButton,
		// Token: 0x040257A8 RID: 153512
		EnterButtonText,
		// Token: 0x040257A9 RID: 153513
		AddPlayerButton,
		// Token: 0x040257AA RID: 153514
		InviteButton,
		// Token: 0x040257AB RID: 153515
		ChatButton,
		// Token: 0x040257AC RID: 153516
		ChatInfoItem,
		// Token: 0x040257AD RID: 153517
		ChatInfoText,
		// Token: 0x040257AE RID: 153518
		TabComponent,
		// Token: 0x040257AF RID: 153519
		TabItem,
		// Token: 0x040257B0 RID: 153520
		TowerItem,
		// Token: 0x040257B1 RID: 153521
		TowerDetailsBtn,
		// Token: 0x040257B2 RID: 153522
		TowerRecommendBtn,
		// Token: 0x040257B3 RID: 153523
		BattleTitleText,
		// Token: 0x040257B4 RID: 153524
		BattleIcon,
		// Token: 0x040257B5 RID: 153525
		TitleText,
		// Token: 0x040257B6 RID: 153526
		QuickSelectButton,
		// Token: 0x040257B7 RID: 153527
		ElementContent,
		// Token: 0x040257B8 RID: 153528
		ElementItem,
		// Token: 0x040257B9 RID: 153529
		RecommendElementItem,
		// Token: 0x040257BA RID: 153530
		LowLevelItem,
		// Token: 0x040257BB RID: 153531
		TitleItem,
		// Token: 0x040257BC RID: 153532
		DragItem,
		// Token: 0x040257BD RID: 153533
		DragRoleItem,
		// Token: 0x040257BE RID: 153534
		BtnTipsItem,
		// Token: 0x040257BF RID: 153535
		LoadingItem,
		// Token: 0x040257C0 RID: 153536
		WarningTipsSprite = 31,
		// Token: 0x040257C1 RID: 153537
		WarningTipsText
	}
}
