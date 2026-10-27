using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001657 RID: 5719
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class WheelTowerController : ActivityControllerBase
{
	// Token: 0x17000D8D RID: 3469
	// (get) Token: 0x0600A0A6 RID: 41126 RVA: 0x0023635A File Offset: 0x0023455A
	// (set) Token: 0x0600A0A7 RID: 41127 RVA: 0x00236362 File Offset: 0x00234562
	public bool IsShowOldView { get; set; }

	// Token: 0x0600A0A8 RID: 41128 RVA: 0x0023636B File Offset: 0x0023456B
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x0600A0A9 RID: 41129 RVA: 0x0023636D File Offset: 0x0023456D
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		if (!this.IsShowOldView)
		{
			return "UiView_MowingTowerActivityMain32";
		}
		return "UiItem_WheelTowerActivity";
	}

	// Token: 0x0600A0AA RID: 41130 RVA: 0x00236382 File Offset: 0x00234582
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		if (!this.IsShowOldView)
		{
			return new WheelTowerNewSubView();
		}
		return new WheelTowerSubView();
	}

	// Token: 0x0600A0AB RID: 41131 RVA: 0x00236397 File Offset: 0x00234597
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return new WheelTowerData();
	}

	// Token: 0x0600A0AC RID: 41132 RVA: 0x0023639E File Offset: 0x0023459E
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return false;
	}

	// Token: 0x0600A0AD RID: 41133 RVA: 0x002363A4 File Offset: 0x002345A4
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

	// Token: 0x0600A0AE RID: 41134 RVA: 0x002363E7 File Offset: 0x002345E7
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.WheelTowerCycleChange, new Action(this.OnWheelTowerCycleChange));
	}

	// Token: 0x0600A0AF RID: 41135 RVA: 0x00236421 File Offset: 0x00234621
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.WheelTowerCycleChange, new Action(this.OnWheelTowerCycleChange));
	}

	// Token: 0x0600A0B0 RID: 41136 RVA: 0x0023645C File Offset: 0x0023465C
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.NewTowerResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewTowerResultNotify));
		Net.Instance.Register(ENotifyMessageId.NewTowerLevelUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewTowerLevelUnlockNotify));
		Net.Instance.Register(ENotifyMessageId.NewTowerTaskDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewTowerTaskDataUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.NewTowerUpdateRecordNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewTowerUpdateRecordNotify));
		Net.Instance.Register(ENotifyMessageId.NewTowerRoundUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewTowerRoundUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.NewTowerSeasonTaskDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewTowerSeasonTaskDataUpdateNotify));
	}

	// Token: 0x0600A0B1 RID: 41137 RVA: 0x00236514 File Offset: 0x00234714
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.NewTowerResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NewTowerLevelUnlockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NewTowerTaskDataUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NewTowerUpdateRecordNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NewTowerRoundUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.NewTowerSeasonTaskDataUpdateNotify);
	}

	// Token: 0x0600A0B2 RID: 41138 RVA: 0x00236584 File Offset: 0x00234784
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

	// Token: 0x0600A0B3 RID: 41139 RVA: 0x00236614 File Offset: 0x00234814
	public void ShowWheelTowerCycleChangeConfirmBox(Action confirmCallback)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ActivityEnd);
		confirmBoxDataNew.FunctionMap[1] = confirmCallback;
		confirmBoxDataNew.FunctionMap[0] = confirmCallback;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600A0B4 RID: 41140 RVA: 0x0023664F File Offset: 0x0023484F
	private void OnWorldDone()
	{
		if (WheelTowerModel.Instance.CheckInInstanceDungeon())
		{
			this.SetBanTimeStop(true);
		}
	}

	// Token: 0x0600A0B5 RID: 41141 RVA: 0x00236664 File Offset: 0x00234864
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

	// Token: 0x0600A0B6 RID: 41142 RVA: 0x002366AC File Offset: 0x002348AC
	[NullableContext(2)]
	private void OnNewTowerSeasonTaskDataUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		NewTowerSeasonTaskDataUpdateNotify newTowerSeasonTaskDataUpdateNotify = (NewTowerSeasonTaskDataUpdateNotify)msg;
		WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
		if (activityData != null)
		{
			activityData.UpdateSeasonTaskList(newTowerSeasonTaskDataUpdateNotify.SeasonTasks.ToList<ActivityTask>());
		}
		if (activityData != null)
		{
			activityData.UpdateSeasonTaskList(newTowerSeasonTaskDataUpdateNotify.Adds.ToList<ActivityTask>());
		}
		if (activityData != null)
		{
			activityData.RemoveSeasonTaskList(newTowerSeasonTaskDataUpdateNotify.Removes.ToList<int>());
		}
		if (activityData != null)
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityData.Id);
		}
	}

	// Token: 0x0600A0B7 RID: 41143 RVA: 0x00236720 File Offset: 0x00234920
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

	// Token: 0x0600A0B8 RID: 41144 RVA: 0x0023677C File Offset: 0x0023497C
	[NullableContext(2)]
	private void OnNewTowerTaskDataUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		NewTowerTaskDataUpdateNotify newTowerTaskDataUpdateNotify = (NewTowerTaskDataUpdateNotify)msg;
		WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		activityData.OnTaskUpdateNotify(newTowerTaskDataUpdateNotify.ActivityTasks.ToList<ActivityTask>());
	}

	// Token: 0x0600A0B9 RID: 41145 RVA: 0x002367B0 File Offset: 0x002349B0
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

	// Token: 0x0600A0BA RID: 41146 RVA: 0x002367E8 File Offset: 0x002349E8
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

	// Token: 0x0600A0BB RID: 41147 RVA: 0x00236864 File Offset: 0x00234A64
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

	// Token: 0x0600A0BC RID: 41148 RVA: 0x00236FB8 File Offset: 0x002351B8
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

	// Token: 0x0600A0BD RID: 41149 RVA: 0x00237018 File Offset: 0x00235218
	public UniTask TryOverrideLevelRecord(Action finishCallback)
	{
		WheelTowerController.<TryOverrideLevelRecord>d__27 <TryOverrideLevelRecord>d__;
		<TryOverrideLevelRecord>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<TryOverrideLevelRecord>d__.finishCallback = finishCallback;
		<TryOverrideLevelRecord>d__.<>1__state = -1;
		<TryOverrideLevelRecord>d__.<>t__builder.Start<WheelTowerController.<TryOverrideLevelRecord>d__27>(ref <TryOverrideLevelRecord>d__);
		return <TryOverrideLevelRecord>d__.<>t__builder.Task;
	}

	// Token: 0x0600A0BE RID: 41150 RVA: 0x0023705C File Offset: 0x0023525C
	public void RequestSelectedRoundChallenge()
	{
		NewTowerClimbingLevelRecord currentLevelRecord = WheelTowerModel.Instance.GetCurrentLevelRecord(null);
		this.RequestChallenge(currentLevelRecord.LevelId, WheelTowerModel.Instance.SelectedRound, new List<int>
		{
			WheelTowerModel.Instance.SelectedBuff
		}, WheelTowerModel.Instance.SelectedRoleList.ToList<int>());
	}

	// Token: 0x0600A0BF RID: 41151 RVA: 0x002370B8 File Offset: 0x002352B8
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
			InstanceDungeonController.Instance.PrewarTeamFightRequest(levelConfigById.Value.InstId, roleIdList.ToList<int>(), 0, 0, null, null);
		}
		WheelTowerModel.Instance.BlockEndlessUnlockTips = true;
		WheelTowerModel.Instance.DeleteRecordPopupData();
	}

	// Token: 0x0600A0C0 RID: 41152 RVA: 0x00237220 File Offset: 0x00235420
	public UniTask RequestRoleEnergyUpdate()
	{
		WheelTowerController.<RequestRoleEnergyUpdate>d__30 <RequestRoleEnergyUpdate>d__;
		<RequestRoleEnergyUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRoleEnergyUpdate>d__.<>1__state = -1;
		<RequestRoleEnergyUpdate>d__.<>t__builder.Start<WheelTowerController.<RequestRoleEnergyUpdate>d__30>(ref <RequestRoleEnergyUpdate>d__);
		return <RequestRoleEnergyUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x0600A0C1 RID: 41153 RVA: 0x0023725C File Offset: 0x0023545C
	public UniTask RequestTaskReceive(bool isEndless)
	{
		WheelTowerController.<RequestTaskReceive>d__31 <RequestTaskReceive>d__;
		<RequestTaskReceive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestTaskReceive>d__.isEndless = isEndless;
		<RequestTaskReceive>d__.<>1__state = -1;
		<RequestTaskReceive>d__.<>t__builder.Start<WheelTowerController.<RequestTaskReceive>d__31>(ref <RequestTaskReceive>d__);
		return <RequestTaskReceive>d__.<>t__builder.Task;
	}

	// Token: 0x0600A0C2 RID: 41154 RVA: 0x002372A0 File Offset: 0x002354A0
	public UniTask RequestSeasonTaskReceive()
	{
		WheelTowerController.<RequestSeasonTaskReceive>d__32 <RequestSeasonTaskReceive>d__;
		<RequestSeasonTaskReceive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSeasonTaskReceive>d__.<>1__state = -1;
		<RequestSeasonTaskReceive>d__.<>t__builder.Start<WheelTowerController.<RequestSeasonTaskReceive>d__32>(ref <RequestSeasonTaskReceive>d__);
		return <RequestSeasonTaskReceive>d__.<>t__builder.Task;
	}

	// Token: 0x0600A0C3 RID: 41155 RVA: 0x002372DC File Offset: 0x002354DC
	public UniTask RequestSeasonTaskProgress()
	{
		WheelTowerController.<RequestSeasonTaskProgress>d__33 <RequestSeasonTaskProgress>d__;
		<RequestSeasonTaskProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSeasonTaskProgress>d__.<>1__state = -1;
		<RequestSeasonTaskProgress>d__.<>t__builder.Start<WheelTowerController.<RequestSeasonTaskProgress>d__33>(ref <RequestSeasonTaskProgress>d__);
		return <RequestSeasonTaskProgress>d__.<>t__builder.Task;
	}

	// Token: 0x0600A0C4 RID: 41156 RVA: 0x00237318 File Offset: 0x00235518
	public UniTask RequestMedalInfo()
	{
		WheelTowerController.<RequestMedalInfo>d__34 <RequestMedalInfo>d__;
		<RequestMedalInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestMedalInfo>d__.<>1__state = -1;
		<RequestMedalInfo>d__.<>t__builder.Start<WheelTowerController.<RequestMedalInfo>d__34>(ref <RequestMedalInfo>d__);
		return <RequestMedalInfo>d__.<>t__builder.Task;
	}

	// Token: 0x0600A0C5 RID: 41157 RVA: 0x00237354 File Offset: 0x00235554
	public UniTask RequestSeasonScoreReceive()
	{
		WheelTowerController.<RequestSeasonScoreReceive>d__35 <RequestSeasonScoreReceive>d__;
		<RequestSeasonScoreReceive>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSeasonScoreReceive>d__.<>1__state = -1;
		<RequestSeasonScoreReceive>d__.<>t__builder.Start<WheelTowerController.<RequestSeasonScoreReceive>d__35>(ref <RequestSeasonScoreReceive>d__);
		return <RequestSeasonScoreReceive>d__.<>t__builder.Task;
	}

	// Token: 0x0600A0C6 RID: 41158 RVA: 0x00237390 File Offset: 0x00235590
	public UniTask RequestResetLevelRecord(int levelId)
	{
		WheelTowerController.<RequestResetLevelRecord>d__36 <RequestResetLevelRecord>d__;
		<RequestResetLevelRecord>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestResetLevelRecord>d__.levelId = levelId;
		<RequestResetLevelRecord>d__.<>1__state = -1;
		<RequestResetLevelRecord>d__.<>t__builder.Start<WheelTowerController.<RequestResetLevelRecord>d__36>(ref <RequestResetLevelRecord>d__);
		return <RequestResetLevelRecord>d__.<>t__builder.Task;
	}

	// Token: 0x0600A0C7 RID: 41159 RVA: 0x002373D4 File Offset: 0x002355D4
	public UniTask RequestRecommendInfo()
	{
		WheelTowerController.<RequestRecommendInfo>d__37 <RequestRecommendInfo>d__;
		<RequestRecommendInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestRecommendInfo>d__.<>1__state = -1;
		<RequestRecommendInfo>d__.<>t__builder.Start<WheelTowerController.<RequestRecommendInfo>d__37>(ref <RequestRecommendInfo>d__);
		return <RequestRecommendInfo>d__.<>t__builder.Task;
	}

	// Token: 0x0600A0C8 RID: 41160 RVA: 0x00237410 File Offset: 0x00235610
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

	// Token: 0x0600A0C9 RID: 41161 RVA: 0x0023744C File Offset: 0x0023564C
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

	// Token: 0x0600A0CA RID: 41162 RVA: 0x00237488 File Offset: 0x00235688
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

	// Token: 0x17000D8E RID: 3470
	// (get) Token: 0x0600A0CB RID: 41163 RVA: 0x002374F1 File Offset: 0x002356F1
	public static WheelTowerController Instance
	{
		get
		{
			return WheelTowerController._Instance;
		}
	}

	// Token: 0x0600A0CC RID: 41164 RVA: 0x002374F8 File Offset: 0x002356F8
	public static WheelTowerController GetOrCreateInstance()
	{
		if (WheelTowerController._Instance == null)
		{
			WheelTowerController.CreateInstance();
		}
		return WheelTowerController._Instance;
	}

	// Token: 0x0600A0CD RID: 41165 RVA: 0x0023750C File Offset: 0x0023570C
	public static bool CreateInstance()
	{
		if (WheelTowerController._Instance != null)
		{
			return true;
		}
		WheelTowerController._Instance = new WheelTowerController();
		return true;
	}

	// Token: 0x0600A0CE RID: 41166 RVA: 0x00237522 File Offset: 0x00235722
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A0CF RID: 41167 RVA: 0x00237524 File Offset: 0x00235724
	public static void ResetStaticDefaultValue()
	{
		WheelTowerController._Instance = null;
	}

	// Token: 0x0600A0D0 RID: 41168 RVA: 0x0023752C File Offset: 0x0023572C
	static WheelTowerController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WheelTowerController.CreateStaticDefaultValue), new Action(WheelTowerController.ResetStaticDefaultValue));
	}

	// Token: 0x04004940 RID: 18752
	private const string TAG_WAIT = "WheelTower";

	// Token: 0x04004941 RID: 18753
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

	// Token: 0x04004943 RID: 18755
	[Nullable(2)]
	private static WheelTowerController _Instance;
}
