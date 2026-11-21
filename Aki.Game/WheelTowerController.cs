using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x02000B0F RID: 2831
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class WheelTowerController : ActivityControllerBase
{
	// Token: 0x17000DAE RID: 3502
	// (get) Token: 0x06007484 RID: 29828 RVA: 0x00240206 File Offset: 0x0023E406
	// (set) Token: 0x06007485 RID: 29829 RVA: 0x0024020E File Offset: 0x0023E40E
	public bool IsShowOldView { get; set; }

	// Token: 0x06007486 RID: 29830 RVA: 0x00240217 File Offset: 0x0023E417
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06007487 RID: 29831 RVA: 0x00240219 File Offset: 0x0023E419
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		if (!this.IsShowOldView)
		{
			return "UiView_MowingTowerActivityMain32";
		}
		return "UiItem_WheelTowerActivity";
	}

	// Token: 0x06007488 RID: 29832 RVA: 0x0024022E File Offset: 0x0023E42E
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		if (!this.IsShowOldView)
		{
			return new WheelTowerNewSubView();
		}
		return new WheelTowerSubView();
	}

	// Token: 0x06007489 RID: 29833 RVA: 0x00240243 File Offset: 0x0023E443
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new WheelTowerData();
	}

	// Token: 0x0600748A RID: 29834 RVA: 0x0024024A File Offset: 0x0023E44A
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x0600748B RID: 29835 RVA: 0x00240250 File Offset: 0x0023E450
	[NullableContext(0)]
	protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
	{
		WheelTowerController.<OnOpenSubView>d__11 <OnOpenSubView>d__;
		<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnOpenSubView>d__.viewName = viewName;
		<OnOpenSubView>d__.<>1__state = -1;
		<OnOpenSubView>d__.<>t__builder.Start<WheelTowerController.<OnOpenSubView>d__11>(ref <OnOpenSubView>d__);
		return <OnOpenSubView>d__.<>t__builder.Task;
	}

	// Token: 0x0600748C RID: 29836 RVA: 0x00240293 File Offset: 0x0023E493
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.WheelTowerCycleChange, new Action(this.OnWheelTowerCycleChange));
	}

	// Token: 0x0600748D RID: 29837 RVA: 0x002402CD File Offset: 0x0023E4CD
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.WheelTowerCycleChange, new Action(this.OnWheelTowerCycleChange));
	}

	// Token: 0x0600748E RID: 29838 RVA: 0x00240308 File Offset: 0x0023E508
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.NewTowerResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewTowerResultNotify));
		Net.Instance.Register(ENotifyMessageId.NewTowerLevelUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewTowerLevelUnlockNotify));
		Net.Instance.Register(ENotifyMessageId.NewTowerTaskDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewTowerTaskDataUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.NewTowerUpdateRecordNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewTowerUpdateRecordNotify));
		Net.Instance.Register(ENotifyMessageId.NewTowerRoundUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewTowerRoundUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.NewTowerSeasonTaskDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewTowerSeasonTaskDataUpdateNotify));
	}

	// Token: 0x0600748F RID: 29839 RVA: 0x002403C0 File Offset: 0x0023E5C0
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NewTowerResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NewTowerLevelUnlockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NewTowerTaskDataUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NewTowerUpdateRecordNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NewTowerRoundUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NewTowerSeasonTaskDataUpdateNotify);
	}

	// Token: 0x06007490 RID: 29840 RVA: 0x00240430 File Offset: 0x0023E630
	private void OnWheelTowerCycleChange()
	{
		if (WheelTowerModel.Instance.CheckInInstanceDungeon())
		{
			this.ShowWheelTowerCycleChangeConfirmBox(delegate
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default);
			});
			return;
		}
		foreach (EUiViewName viewName in WheelTowerController.WheelTowerViewNameList)
		{
			if (UiManager.Instance.IsViewOpen(viewName))
			{
				this.ShowWheelTowerCycleChangeConfirmBox(delegate
				{
					UiManager.Instance.ResetToBattleView(null);
				});
				return;
			}
		}
	}

	// Token: 0x06007491 RID: 29841 RVA: 0x002404C0 File Offset: 0x0023E6C0
	public void ShowWheelTowerCycleChangeConfirmBox(Action confirmCallback)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityEnd);
		confirmBoxDataNew.FunctionMap[1] = confirmCallback;
		confirmBoxDataNew.FunctionMap[0] = confirmCallback;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06007492 RID: 29842 RVA: 0x002404FB File Offset: 0x0023E6FB
	private void OnWorldDone()
	{
		if (WheelTowerModel.Instance.CheckInInstanceDungeon())
		{
			this.SetBanTimeStop(true);
		}
	}

	// Token: 0x06007493 RID: 29843 RVA: 0x00240510 File Offset: 0x0023E710
	public void SetBanTimeStop(bool ban)
	{
		WheelTowerModel instance = WheelTowerModel.Instance;
		if (instance.IsTimeStopBanned == ban)
		{
			return;
		}
		instance.IsTimeStopBanned = ban;
		if (ban)
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag("WheelTower");
			return;
		}
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("WheelTower");
	}

	// Token: 0x06007494 RID: 29844 RVA: 0x00240558 File Offset: 0x0023E758
	[NullableContext(2)]
	private void OnNewTowerSeasonTaskDataUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		NewTowerSeasonTaskDataUpdateNotify newTowerSeasonTaskDataUpdateNotify = (NewTowerSeasonTaskDataUpdateNotify)msg;
		WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
		if (activityData != null)
		{
			activityData.UpdateSeasonTaskList(newTowerSeasonTaskDataUpdateNotify.SeasonTasks);
		}
		if (activityData != null)
		{
			activityData.UpdateSeasonTaskList(newTowerSeasonTaskDataUpdateNotify.Adds);
		}
		if (activityData != null)
		{
			activityData.RemoveSeasonTaskList(newTowerSeasonTaskDataUpdateNotify.Removes);
		}
		if (activityData != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
		}
	}

	// Token: 0x06007495 RID: 29845 RVA: 0x002405C0 File Offset: 0x0023E7C0
	[NullableContext(2)]
	private void OnNewTowerRoundUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		NewTowerRoundUpdateNotify newTowerRoundUpdateNotify = (NewTowerRoundUpdateNotify)msg;
		WheelTowerModel instance = WheelTowerModel.Instance;
		if (!instance.EndlessMode)
		{
			return;
		}
		if (instance.CachedRoundInProgress == newTowerRoundUpdateNotify.Round)
		{
			return;
		}
		instance.CachedRoundInProgress = newTowerRoundUpdateNotify.Round;
		UiManager.Instance.OpenView(EUiViewName.WheelTowerRoundTipsView, newTowerRoundUpdateNotify.Round, null);
	}

	// Token: 0x06007496 RID: 29846 RVA: 0x0024061C File Offset: 0x0023E81C
	[NullableContext(2)]
	private void OnNewTowerTaskDataUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		NewTowerTaskDataUpdateNotify newTowerTaskDataUpdateNotify = (NewTowerTaskDataUpdateNotify)msg;
		WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		activityData.OnTaskUpdateNotify(newTowerTaskDataUpdateNotify.ActivityTasks);
	}

	// Token: 0x06007497 RID: 29847 RVA: 0x0024064C File Offset: 0x0023E84C
	[NullableContext(2)]
	private void OnNewTowerUpdateRecordNotify(IMessage msg, Net.CallbackStatus _)
	{
		NewTowerUpdateRecordNotify newTowerUpdateRecordNotify = (NewTowerUpdateRecordNotify)msg;
		if (newTowerUpdateRecordNotify.Record != null)
		{
			WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			activityData.OnLevelRecordUpdateNotify(newTowerUpdateRecordNotify.Record);
		}
	}

	// Token: 0x06007498 RID: 29848 RVA: 0x00240684 File Offset: 0x0023E884
	[NullableContext(2)]
	private void OnNewTowerLevelUnlockNotify(IMessage msg, Net.CallbackStatus _)
	{
		NewTowerLevelUnlockNotify newTowerLevelUnlockNotify = (NewTowerLevelUnlockNotify)msg;
		if (newTowerLevelUnlockNotify.Record == null)
		{
			return;
		}
		NewTowerLevel? levelConfigById = WheelTowerConfig.Instance.GetLevelConfigById(newTowerLevelUnlockNotify.Record.LevelId);
		if (levelConfigById == null || levelConfigById.Value.Diff <= 0)
		{
			return;
		}
		if (WheelTowerModel.Instance.BlockEndlessUnlockTips)
		{
			WheelTowerModel.Instance.SetIsEndlessUnlockedInInstance(true);
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("WheelTower_EndlessModeUnlockTips", Array.Empty<object>());
	}

	// Token: 0x06007499 RID: 29849 RVA: 0x00240700 File Offset: 0x0023E900
	[NullableContext(2)]
	private void OnNewTowerResultNotify(IMessage msg, Net.CallbackStatus _)
	{
		NewTowerResultNotify newTowerResultNotify = (NewTowerResultNotify)msg;
		WheelTowerModel model = WheelTowerModel.Instance;
		int selectedRound = model.SelectedRound;
		bool flag = model.IsRoundChallenged(selectedRound, new bool?(model.EndlessMode));
		int count = model.GetRoundBossInfo(selectedRound, new bool?(model.EndlessMode)).Count;
		bool isEndlessUnlockedInInstance = model.GetIsEndlessUnlockedInInstance();
		if (!isEndlessUnlockedInInstance)
		{
			if (!flag)
			{
				WheelTowerData activityData = model.ActivityData;
				if (activityData != null)
				{
					activityData.OnAddNewRecord(newTowerResultNotify);
				}
			}
			else
			{
				int bossRound = 0;
				int num = 0;
				MonsterInfoPreview bossInfoByRound = model.GetBossInfoByRound(selectedRound, new bool?(model.EndlessMode));
				if (bossInfoByRound != null)
				{
					bossRound = bossInfoByRound.Round;
					NewTowerWave? waveConfigById = WheelTowerConfig.Instance.GetWaveConfigById(bossInfoByRound.WaveConfigId);
					if (waveConfigById != null)
					{
						num = waveConfigById.Value.Wave;
					}
				}
				int num2 = num % count;
				num = ((num2 != 0) ? num2 : count);
				int bossRound2 = 0;
				int num3 = 0;
				foreach (MonsterInfoPreview monsterInfoPreview in newTowerResultNotify.MonsterInfoPreviews)
				{
					bossRound2 = monsterInfoPreview.Round;
					NewTowerWave? waveConfigById2 = WheelTowerConfig.Instance.GetWaveConfigById(monsterInfoPreview.WaveConfigId);
					if (waveConfigById2 != null)
					{
						num3 = waveConfigById2.Value.Wave;
					}
				}
				num2 = num3 % count;
				num3 = ((num2 != 0) ? num2 : count);
				TeamChallengeInfo teamChallengeInfo = newTowerResultNotify.TeamChallengeInfo;
				if (teamChallengeInfo != null)
				{
					List<int> list = new List<int>();
					foreach (RoleSaveInfo roleSaveInfo in teamChallengeInfo.RoleSaveInfos)
					{
						list.Add(roleSaveInfo.RoleId);
					}
					List<int> roundSelectBuffList = model.GetRoundSelectBuffList(selectedRound);
					int buffId = (roundSelectBuffList.Count > 0) ? roundSelectBuffList[0] : 0;
					int buffId2 = (teamChallengeInfo.BuffIds.Count > 0) ? teamChallengeInfo.BuffIds[0] : 0;
					WheelTowerCoverRecordViewData recordPopupData = new WheelTowerCoverRecordViewData
					{
						BeforeData = new WheelTowerCoverRecordData
						{
							TotalScore = model.GetRoundTotalScore(selectedRound),
							TeamScore = newTowerResultNotify.BeforeTeamScore,
							BossRound = bossRound,
							BossWave = num,
							NeedChallengeBossWaveNum = count,
							AddTeamScore = 0,
							TeamRoleIdList = model.GetRoundSelectRoleIdList(selectedRound),
							BuffId = buffId
						},
						AfterData = new WheelTowerCoverRecordData
						{
							TotalScore = newTowerResultNotify.AfterLevelScore,
							TeamScore = newTowerResultNotify.AfterTeamScore,
							BossRound = bossRound2,
							BossWave = num3,
							NeedChallengeBossWaveNum = count,
							AddTeamScore = newTowerResultNotify.AfterTeamScore - newTowerResultNotify.BeforeTeamScore,
							TeamRoleIdList = list,
							BuffId = buffId2
						},
						IsEndless = model.EndlessMode,
						TeamNum = selectedRound + 1
					};
					model.SetRecordPopupData(recordPopupData);
				}
			}
		}
		List<IBossItemData> list2 = new List<IBossItemData>();
		for (int i = 0; i < newTowerResultNotify.MonsterInfoPreviews.Count; i++)
		{
			MonsterInfoPreview monsterInfoPreview2 = newTowerResultNotify.MonsterInfoPreviews[i];
			NewTowerWave? waveConfigById3 = WheelTowerConfig.Instance.GetWaveConfigById(monsterInfoPreview2.WaveConfigId);
			if (waveConfigById3 != null && waveConfigById3.Value.IsShowInView)
			{
				float value = (list2.Count == 0) ? ((float)model.GetRecordPrevBossHpPercentage(selectedRound - 1, monsterInfoPreview2.WaveConfigId, monsterInfoPreview2.Round)) : 100f;
				list2.Add(new BossItemData
				{
					BossInfo = new BossInfo
					{
						WaveConfigId = monsterInfoPreview2.WaveConfigId,
						Round = monsterInfoPreview2.Round,
						HpPercentage = model.GetBossHpPercentage(monsterInfoPreview2)
					},
					StartPercent = new float?(value),
					ShowBossRound = new bool?(model.EndlessMode)
				});
			}
		}
		TeamChallengeInfo teamChallengeInfo2 = newTowerResultNotify.TeamChallengeInfo;
		if (teamChallengeInfo2 == null)
		{
			this.SetBanTimeStop(false);
			model.CachedRoundInProgress = -1;
			return;
		}
		List<RoleDataWithBranch> list3 = new List<RoleDataWithBranch>();
		foreach (RoleSaveInfo roleSaveInfo2 in teamChallengeInfo2.RoleSaveInfos)
		{
			list3.Add(new RoleDataWithBranch(roleSaveInfo2.RoleId, roleSaveInfo2.SkillBranchId));
		}
		List<int> list4 = new List<int>();
		foreach (int item in newTowerResultNotify.CompletedSeasonTaskIds)
		{
			list4.Add(item);
		}
		WheelTowerSettlementViewData param = new WheelTowerSettlementViewData
		{
			EndlessMode = model.EndlessMode,
			TotalRound = model.GetLastChallengeRound(null) + 1,
			CurrentRound = model.SelectedRound + 1,
			CurrentScore = newTowerResultNotify.AfterTeamScore,
			TotalScore = newTowerResultNotify.AfterLevelScore,
			BossInfoList = list2,
			MaxBossWaveNum = count,
			RoleList = list3,
			FinishedSeasonTaskIds = list4
		};
		WheelTowerSettlementViewData param2 = param;
		WheelTowerSettlementViewButtonData wheelTowerSettlementViewButtonData = new WheelTowerSettlementViewButtonData();
		wheelTowerSettlementViewButtonData.Name = "WheelTower_Result_Back";
		wheelTowerSettlementViewButtonData.OnClick = delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.WheelTowerPrepareView, null, null);
		};
		param2.LeftButtonData = wheelTowerSettlementViewButtonData;
		WheelTowerSettlementViewButtonData wheelTowerSettlementViewButtonData2 = new WheelTowerSettlementViewButtonData
		{
			Name = "WheelTower_Result_Retry",
			OnClick = new Action(this.RequestSelectedRoundChallenge),
			ConfirmBoxId = new EConfirmBoxConfigId?(EConfirmBoxConfigId.WheelTowerInstanceRetryConfirm)
		};
		WheelTowerSettlementViewButtonData rightButtonData = new WheelTowerSettlementViewButtonData
		{
			Name = "WheelTower_Result_Next",
			OnClick = delegate
			{
				int round = model.SelectedRound + 1;
				model.UpdateSelectRound(round, false);
				UiManager.Instance.OpenView(EUiViewName.WheelTowerPrepareView, null, null);
			}
		};
		WheelTowerSettlementViewButtonData rightButtonData2 = new WheelTowerSettlementViewButtonData
		{
			Name = "WheelTower_Result_Endless",
			OnClick = delegate
			{
				model.SetEndlessMode(true);
				UiManager.Instance.OpenView(EUiViewName.WheelTowerModeDetailView, null, null);
			}
		};
		if (model.EndlessMode)
		{
			param.CenterButtonData = wheelTowerSettlementViewButtonData2;
			param.RightButtonData = rightButtonData;
		}
		else if (isEndlessUnlockedInInstance)
		{
			param.CenterButtonData = wheelTowerSettlementViewButtonData2;
			param.RightButtonData = rightButtonData2;
			param.ShowEndlessUnlockTips = new bool?(true);
		}
		else
		{
			MonsterInfoPreview lastMonsterInfoPreview = teamChallengeInfo2.LastMonsterInfoPreview;
			if (lastMonsterInfoPreview != null && (model.GetBossHpPercentage(lastMonsterInfoPreview) <= 0.0 || model.IsLastRoundCheckLimit(newTowerResultNotify.LevelId, selectedRound)))
			{
				param.RightButtonData = wheelTowerSettlementViewButtonData2;
			}
			else
			{
				param.CenterButtonData = wheelTowerSettlementViewButtonData2;
				param.RightButtonData = rightButtonData;
			}
		}
		TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			UiManager.Instance.OpenView(EUiViewName.WheelTowerSettlementView, param, null);
			this.SetBanTimeStop(false);
		}, 0.5f * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
		model.CachedRoundInProgress = -1;
		this.RequestMedalInfo().Forget();
	}

	// Token: 0x0600749A RID: 29850 RVA: 0x00240E54 File Offset: 0x0023F054
	[NullableContext(2)]
	public void TryOpenOverridePopupView(Action confirmCallback = null)
	{
		IWheelTowerCoverRecordViewData recordPopupData = WheelTowerModel.Instance.GetRecordPopupData();
		if (recordPopupData == null)
		{
			return;
		}
		WheelTowerModel.Instance.DeleteRecordPopupData();
		Action <>9__1;
		recordPopupData.OnClickConfirm = delegate()
		{
			WheelTowerController <>4__this = this;
			Action finishCallback;
			if ((finishCallback = <>9__1) == null)
			{
				finishCallback = (<>9__1 = delegate()
				{
					Action confirmCallback2 = confirmCallback;
					if (confirmCallback2 == null)
					{
						return;
					}
					confirmCallback2();
				});
			}
			<>4__this.TryOverrideLevelRecord(finishCallback).Forget();
		};
		UiManager.Instance.OpenView(EUiViewName.WheelTowerCoverRecordPopupView, recordPopupData, null);
	}

	// Token: 0x0600749B RID: 29851 RVA: 0x00240EB4 File Offset: 0x0023F0B4
	public UniTask TryOverrideLevelRecord(Action finishCallback)
	{
		WheelTowerController.<TryOverrideLevelRecord>d__27 <TryOverrideLevelRecord>d__;
		<TryOverrideLevelRecord>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryOverrideLevelRecord>d__.finishCallback = finishCallback;
		<TryOverrideLevelRecord>d__.<>1__state = -1;
		<TryOverrideLevelRecord>d__.<>t__builder.Start<WheelTowerController.<TryOverrideLevelRecord>d__27>(ref <TryOverrideLevelRecord>d__);
		return <TryOverrideLevelRecord>d__.<>t__builder.Task;
	}

	// Token: 0x0600749C RID: 29852 RVA: 0x00240EF8 File Offset: 0x0023F0F8
	public void RequestSelectedRoundChallenge()
	{
		NewTowerClimbingLevelRecord currentLevelRecord = WheelTowerModel.Instance.GetCurrentLevelRecord(null);
		this.RequestChallenge(currentLevelRecord.LevelId, WheelTowerModel.Instance.SelectedRound, new List<int>
		{
			WheelTowerModel.Instance.SelectedBuff
		}, new List<int>(WheelTowerModel.Instance.SelectedRoleList));
	}

	// Token: 0x0600749D RID: 29853 RVA: 0x00240F54 File Offset: 0x0023F154
	public void RequestChallenge(int levelId, int round, IList<int> buffIdList, IList<int> roleIdList)
	{
		NewTowerCycleStartParam newTowerCycleStartParam = new NewTowerCycleStartParam
		{
			LevelId = levelId,
			Index = round
		};
		newTowerCycleStartParam.BuffIds.Add(buffIdList);
		WheelTowerModel instance = WheelTowerModel.Instance;
		foreach (int roleId in roleIdList)
		{
			RoleSaveInfo roleSaveInfo = new RoleSaveInfo();
			if (instance.IsTemplateRole(roleId))
			{
				roleSaveInfo.RoleId = roleId;
				roleSaveInfo.SkillBranchId = RoleModel.Instance.GetRoleSkillBranchIdInGamePlay(roleId, ESkillBranchCacheType.WheeTowerLoading);
			}
			else
			{
				IRoleInfo roleInfo = instance.GetRoleInfo(roleId);
				roleSaveInfo.RoleId = roleId;
				roleSaveInfo.WeaponIncId = roleInfo.Weapon;
				roleSaveInfo.PhantomIncId.Add(roleInfo.Phantom);
				roleSaveInfo.SkillBranchId = RoleModel.Instance.GetRoleSkillBranchIdInGamePlay(roleId, ESkillBranchCacheType.WheeTowerLoading);
			}
			newTowerCycleStartParam.RoleSaveInfos.Add(roleSaveInfo);
		}
		NewTowerClimbingCtx newTowerClimbingCtx = new NewTowerClimbingCtx
		{
			Param = newTowerCycleStartParam
		};
		InstanceDungeonModel.Instance.InstanceEnterContentText.NewTowerClimbingCtx = newTowerClimbingCtx;
		NewTowerLevel? levelConfigById = WheelTowerConfig.Instance.GetLevelConfigById(levelId);
		if (levelConfigById != null)
		{
			InstanceDungeonController.Instance.PrewarTeamFightRequest(levelConfigById.Value.InstId, new List<int>(roleIdList), 0, 0, null, null);
		}
		WheelTowerModel.Instance.BlockEndlessUnlockTips = true;
		WheelTowerModel.Instance.DeleteRecordPopupData();
	}

	// Token: 0x0600749E RID: 29854 RVA: 0x002410BC File Offset: 0x0023F2BC
	public UniTask RequestRoleEnergyUpdate()
	{
		WheelTowerController.<RequestRoleEnergyUpdate>d__30 <RequestRoleEnergyUpdate>d__;
		<RequestRoleEnergyUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRoleEnergyUpdate>d__.<>1__state = -1;
		<RequestRoleEnergyUpdate>d__.<>t__builder.Start<WheelTowerController.<RequestRoleEnergyUpdate>d__30>(ref <RequestRoleEnergyUpdate>d__);
		return <RequestRoleEnergyUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x0600749F RID: 29855 RVA: 0x002410F8 File Offset: 0x0023F2F8
	public UniTask RequestTaskReceive(bool isEndless)
	{
		WheelTowerController.<RequestTaskReceive>d__31 <RequestTaskReceive>d__;
		<RequestTaskReceive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestTaskReceive>d__.isEndless = isEndless;
		<RequestTaskReceive>d__.<>1__state = -1;
		<RequestTaskReceive>d__.<>t__builder.Start<WheelTowerController.<RequestTaskReceive>d__31>(ref <RequestTaskReceive>d__);
		return <RequestTaskReceive>d__.<>t__builder.Task;
	}

	// Token: 0x060074A0 RID: 29856 RVA: 0x0024113C File Offset: 0x0023F33C
	public UniTask RequestSeasonTaskReceive()
	{
		WheelTowerController.<RequestSeasonTaskReceive>d__32 <RequestSeasonTaskReceive>d__;
		<RequestSeasonTaskReceive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSeasonTaskReceive>d__.<>1__state = -1;
		<RequestSeasonTaskReceive>d__.<>t__builder.Start<WheelTowerController.<RequestSeasonTaskReceive>d__32>(ref <RequestSeasonTaskReceive>d__);
		return <RequestSeasonTaskReceive>d__.<>t__builder.Task;
	}

	// Token: 0x060074A1 RID: 29857 RVA: 0x00241178 File Offset: 0x0023F378
	public UniTask RequestSeasonTaskProgress()
	{
		WheelTowerController.<RequestSeasonTaskProgress>d__33 <RequestSeasonTaskProgress>d__;
		<RequestSeasonTaskProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSeasonTaskProgress>d__.<>1__state = -1;
		<RequestSeasonTaskProgress>d__.<>t__builder.Start<WheelTowerController.<RequestSeasonTaskProgress>d__33>(ref <RequestSeasonTaskProgress>d__);
		return <RequestSeasonTaskProgress>d__.<>t__builder.Task;
	}

	// Token: 0x060074A2 RID: 29858 RVA: 0x002411B4 File Offset: 0x0023F3B4
	public UniTask RequestMedalInfo()
	{
		WheelTowerController.<RequestMedalInfo>d__34 <RequestMedalInfo>d__;
		<RequestMedalInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestMedalInfo>d__.<>1__state = -1;
		<RequestMedalInfo>d__.<>t__builder.Start<WheelTowerController.<RequestMedalInfo>d__34>(ref <RequestMedalInfo>d__);
		return <RequestMedalInfo>d__.<>t__builder.Task;
	}

	// Token: 0x060074A3 RID: 29859 RVA: 0x002411F0 File Offset: 0x0023F3F0
	public UniTask RequestSeasonScoreReceive()
	{
		WheelTowerController.<RequestSeasonScoreReceive>d__35 <RequestSeasonScoreReceive>d__;
		<RequestSeasonScoreReceive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSeasonScoreReceive>d__.<>1__state = -1;
		<RequestSeasonScoreReceive>d__.<>t__builder.Start<WheelTowerController.<RequestSeasonScoreReceive>d__35>(ref <RequestSeasonScoreReceive>d__);
		return <RequestSeasonScoreReceive>d__.<>t__builder.Task;
	}

	// Token: 0x060074A4 RID: 29860 RVA: 0x0024122C File Offset: 0x0023F42C
	public UniTask RequestResetLevelRecord(int levelId)
	{
		WheelTowerController.<RequestResetLevelRecord>d__36 <RequestResetLevelRecord>d__;
		<RequestResetLevelRecord>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestResetLevelRecord>d__.levelId = levelId;
		<RequestResetLevelRecord>d__.<>1__state = -1;
		<RequestResetLevelRecord>d__.<>t__builder.Start<WheelTowerController.<RequestResetLevelRecord>d__36>(ref <RequestResetLevelRecord>d__);
		return <RequestResetLevelRecord>d__.<>t__builder.Task;
	}

	// Token: 0x060074A5 RID: 29861 RVA: 0x00241270 File Offset: 0x0023F470
	public UniTask RequestRecommendInfo()
	{
		WheelTowerController.<RequestRecommendInfo>d__37 <RequestRecommendInfo>d__;
		<RequestRecommendInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRecommendInfo>d__.<>1__state = -1;
		<RequestRecommendInfo>d__.<>t__builder.Start<WheelTowerController.<RequestRecommendInfo>d__37>(ref <RequestRecommendInfo>d__);
		return <RequestRecommendInfo>d__.<>t__builder.Task;
	}

	// Token: 0x060074A6 RID: 29862 RVA: 0x002412AC File Offset: 0x0023F4AC
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<NewTowerCycleRecordPb> RequestLastCycleReviewInfo()
	{
		WheelTowerController.<RequestLastCycleReviewInfo>d__38 <RequestLastCycleReviewInfo>d__;
		<RequestLastCycleReviewInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<NewTowerCycleRecordPb>.Create();
		<RequestLastCycleReviewInfo>d__.<>1__state = -1;
		<RequestLastCycleReviewInfo>d__.<>t__builder.Start<WheelTowerController.<RequestLastCycleReviewInfo>d__38>(ref <RequestLastCycleReviewInfo>d__);
		return <RequestLastCycleReviewInfo>d__.<>t__builder.Task;
	}

	// Token: 0x060074A7 RID: 29863 RVA: 0x002412E8 File Offset: 0x0023F4E8
	public void RequestEndChallenge(Action callback)
	{
		Net.Instance.Call(ERequestMessageId.NewTowerCycleStartRequest, new NewTowerCycleStartRequest(), delegate(IMessage msg, Net.CallbackStatus _)
		{
			NewTowerCycleStartResponse newTowerCycleStartResponse = (NewTowerCycleStartResponse)msg;
			if (newTowerCycleStartResponse == null)
			{
				return;
			}
			if (newTowerCycleStartResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(newTowerCycleStartResponse.ErrorCode, EResponseMessageId.NewTowerCycleStartResponse, null, true, true);
				return;
			}
			callback();
		}, 0);
	}

	// Token: 0x060074A8 RID: 29864 RVA: 0x00241324 File Offset: 0x0023F524
	public void OpenSeasonMedalView(int seasonId = 0, bool autoShare = false)
	{
		bool hideAllSeasonBtn = UiManager.Instance.GetViewByName(EUiViewName.WheelTowerSeasonMedalView) != null;
		int num;
		if (seasonId == 0)
		{
			WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
			num = ((activityData != null) ? activityData.SeasonId : 0);
		}
		else
		{
			num = seasonId;
		}
		int seasonId2 = num;
		WheelTowerSeasonMedalViewData param = new WheelTowerSeasonMedalViewData
		{
			SeasonId = seasonId2,
			HideAllSeasonBtn = hideAllSeasonBtn,
			AutoShare = autoShare
		};
		UiManager.Instance.OpenView(EUiViewName.WheelTowerSeasonMedalView, param, null);
	}

	// Token: 0x17000DAF RID: 3503
	// (get) Token: 0x060074A9 RID: 29865 RVA: 0x0024138D File Offset: 0x0023F58D
	public static WheelTowerController Instance
	{
		get
		{
			return WheelTowerController._Instance;
		}
	}

	// Token: 0x060074AA RID: 29866 RVA: 0x00241394 File Offset: 0x0023F594
	public static WheelTowerController GetOrCreateInstance()
	{
		if (WheelTowerController._Instance == null)
		{
			WheelTowerController.CreateInstance();
		}
		return WheelTowerController._Instance;
	}

	// Token: 0x060074AB RID: 29867 RVA: 0x002413A8 File Offset: 0x0023F5A8
	public static bool CreateInstance()
	{
		if (WheelTowerController._Instance != null)
		{
			return true;
		}
		WheelTowerController._Instance = new WheelTowerController();
		return true;
	}

	// Token: 0x060074AC RID: 29868 RVA: 0x002413BE File Offset: 0x0023F5BE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060074AD RID: 29869 RVA: 0x002413C0 File Offset: 0x0023F5C0
	public static void ResetStaticDefaultValue()
	{
		WheelTowerController._Instance = null;
	}

	// Token: 0x060074AE RID: 29870 RVA: 0x002413C8 File Offset: 0x0023F5C8
	static WheelTowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WheelTowerController.CreateStaticDefaultValue), new Action(WheelTowerController.ResetStaticDefaultValue));
	}

	// Token: 0x040049E6 RID: 18918
	private const string TAG_WAIT = "WheelTower";

	// Token: 0x040049E7 RID: 18919
	[StaticVariableRuleIgnore]
	private static readonly EUiViewName[] WheelTowerViewNameList = new EUiViewName[]
	{
		EUiViewName.WheelTowerModeSelectView,
		EUiViewName.WheelTowerRoundSelectView,
		EUiViewName.WheelTowerBuffSelectView,
		EUiViewName.WheelTowerMainView,
		EUiViewName.WheelTowerModeDetailView,
		EUiViewName.WheelTowerPrepareView,
		EUiViewName.WheelTowerEnhanceRoleView,
		EUiViewName.WheelTowerRecordView,
		EUiViewName.WheelTowerScoreLevelRuleView,
		EUiViewName.WheelTowerRecommendView,
		EUiViewName.WheelTowerBossBuffTip,
		EUiViewName.WheelTowerSettlementView,
		EUiViewName.WheelTowerBossHandBookView,
		EUiViewName.WheelTowerLimitRewardView,
		EUiViewName.WheelTowerSeasonRewardView,
		EUiViewName.WheelTowerCoverRecordPopupView,
		EUiViewName.WheelTowerMedalDetailView,
		EUiViewName.WheelTowerSeasonMedalView,
		EUiViewName.WheelTowerSeasonOverviewView,
		EUiViewName.WheelTowerSeasonReviewView
	};

	// Token: 0x040049E9 RID: 18921
	[Nullable(2)]
	private static WheelTowerController _Instance;
}
