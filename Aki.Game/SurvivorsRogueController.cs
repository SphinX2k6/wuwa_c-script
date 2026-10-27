using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02002B81 RID: 11137
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class SurvivorsRogueController : UiControllerBase
{
	// Token: 0x0601712C RID: 94508 RVA: 0x005DB604 File Offset: 0x005D9804
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.SurvivorsInstGlobalDataNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsInstGlobalDataNotify));
		Net.Instance.Register(ENotifyMessageId.SurvivorsGainDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsGainDataUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.SurvivorsOpDataUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsOpDataUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.SurvivorsOpDataForceChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsOpDataForceChangeNotify));
		Net.Instance.Register(ENotifyMessageId.SurvivorsStepUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsStepUpdateNotify));
		Net.Instance.Register(ENotifyMessageId.SurvivorsVarRecordNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsVarRecordNotify));
		Net.Instance.Register(ENotifyMessageId.SurvivorsComboParamUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnSurvivorsComboParamUpdateNotify));
	}

	// Token: 0x0601712D RID: 94509 RVA: 0x005DB6D8 File Offset: 0x005D98D8
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsInstGlobalDataNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsGainDataUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsOpDataUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsOpDataForceChangeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsStepUpdateNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsVarRecordNotify);
		Net.Instance.UnRegister(ENotifyMessageId.SurvivorsComboParamUpdateNotify);
	}

	// Token: 0x0601712E RID: 94510 RVA: 0x005DB755 File Offset: 0x005D9955
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
	}

	// Token: 0x0601712F RID: 94511 RVA: 0x005DB78F File Offset: 0x005D998F
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
	}

	// Token: 0x06017130 RID: 94512 RVA: 0x005DB7C9 File Offset: 0x005D99C9
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.SurvivorsTabMainView, new Func<EUiViewName, object, bool>(this.CanOpenSurvivorsTabMainView), "SurvivorsRogueController.CanOpenSurvivorsTabMainView");
	}

	// Token: 0x06017131 RID: 94513 RVA: 0x005DB7EB File Offset: 0x005D99EB
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.SurvivorsTabMainView, new Func<EUiViewName, object, bool>(this.CanOpenSurvivorsTabMainView));
	}

	// Token: 0x06017132 RID: 94514 RVA: 0x005DB808 File Offset: 0x005D9A08
	private bool CanOpenSurvivorsTabMainView(EUiViewName viewName, object param)
	{
		KscSubModelBase curSubModel = KuroSimpleCombatController.Instance.CurSubModel;
		AKSC_Entity aksc_Entity = (curSubModel != null) ? curSubModel.KscPlayerEntity : null;
		if (aksc_Entity == null)
		{
			return false;
		}
		UKSC_SkillComp skillComp = aksc_Entity.GetSkillComp();
		bool result;
		if (skillComp == null)
		{
			result = (null != null);
		}
		else
		{
			UKSC_AttrSet attrSet_ = skillComp.AttrSet_;
			result = (((attrSet_ != null) ? attrSet_.Attrs_ : null) != null);
		}
		return result;
	}

	// Token: 0x06017133 RID: 94515 RVA: 0x005DB854 File Offset: 0x005D9A54
	private void OnSurvivorsInstGlobalDataNotify(IMessage msg, Net.CallbackStatus status)
	{
		SurvivorsInstGlobalDataNotify survivorsInstGlobalDataNotify = (SurvivorsInstGlobalDataNotify)msg;
		SurvivorsRogueModel.Instance.CurLevelId = survivorsInstGlobalDataNotify.LevelId;
		SurvivorsRogueModel.Instance.InitComboEnhanceCfg(survivorsInstGlobalDataNotify.ComboParamInfos);
		SurvivorsRogueModel.Instance.GainData.InitGain(survivorsInstGlobalDataNotify.SurvivorsGainDatas, survivorsInstGlobalDataNotify.WeaponMaxCount, survivorsInstGlobalDataNotify.UnlockWeaponWave);
		SurvivorsRogueModel.Instance.InitCommandQueue();
		SurvivorsRogueCommandQueue commandQueue = SurvivorsRogueModel.Instance.CommandQueue;
		commandQueue.SetForegroundIncId(survivorsInstGlobalDataNotify.ForceIncId);
		commandQueue.InitCommands(survivorsInstGlobalDataNotify.SurvivorsOpDatas);
	}

	// Token: 0x06017134 RID: 94516 RVA: 0x005DB8D4 File Offset: 0x005D9AD4
	private void OnSurvivorsVarRecordNotify(IMessage msg, Net.CallbackStatus status)
	{
		SurvivorsVarRecordNotify survivorsVarRecordNotify = (SurvivorsVarRecordNotify)msg;
		SurvivorsRogueModel.Instance.BattleData.SetBehaviorTreeVar(survivorsVarRecordNotify.VariableKeyNames.ToDictionary<string, string>());
	}

	// Token: 0x06017135 RID: 94517 RVA: 0x005DB904 File Offset: 0x005D9B04
	private void OnSurvivorsGainDataUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		SurvivorsGainDataUpdateNotify survivorsGainDataUpdateNotify = (SurvivorsGainDataUpdateNotify)msg;
		SurvivorsRogueGainData gainData = SurvivorsRogueModel.Instance.GainData;
		for (int i = 0; i < survivorsGainDataUpdateNotify.Adds.Count; i++)
		{
			gainData.AddGain(survivorsGainDataUpdateNotify.Adds[i]);
		}
		for (int j = 0; j < survivorsGainDataUpdateNotify.Updates.Count; j++)
		{
			gainData.UpdateGain(survivorsGainDataUpdateNotify.Updates[j]);
		}
		for (int k = 0; k < survivorsGainDataUpdateNotify.Removes.Count; k++)
		{
			gainData.RemoveGain(survivorsGainDataUpdateNotify.Removes[k]);
		}
	}

	// Token: 0x06017136 RID: 94518 RVA: 0x005DB9A0 File Offset: 0x005D9BA0
	private void OnSurvivorsOpDataUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		SurvivorsOpDataUpdateNotify survivorsOpDataUpdateNotify = (SurvivorsOpDataUpdateNotify)msg;
		SurvivorsRogueCommandQueue commandQueue = SurvivorsRogueModel.Instance.CommandQueue;
		if (commandQueue == null)
		{
			return;
		}
		commandQueue.SetForegroundIncId(survivorsOpDataUpdateNotify.ForceIncId);
		for (int i = 0; i < survivorsOpDataUpdateNotify.Adds.Count; i++)
		{
			commandQueue.AddCommand(survivorsOpDataUpdateNotify.Adds[i]);
		}
		for (int j = 0; j < survivorsOpDataUpdateNotify.Updates.Count; j++)
		{
			commandQueue.UpdateCommand(survivorsOpDataUpdateNotify.Updates[j]);
		}
		for (int k = 0; k < survivorsOpDataUpdateNotify.Removes.Count; k++)
		{
			commandQueue.RemoveCommand(survivorsOpDataUpdateNotify.Removes[k]);
		}
		commandQueue.StartForegroundCommand();
	}

	// Token: 0x06017137 RID: 94519 RVA: 0x005DBA54 File Offset: 0x005D9C54
	private void OnSurvivorsOpDataForceChangeNotify(IMessage msg, Net.CallbackStatus status)
	{
		SurvivorsOpDataForceChangeNotify survivorsOpDataForceChangeNotify = (SurvivorsOpDataForceChangeNotify)msg;
		SurvivorsRogueCommandQueue commandQueue = SurvivorsRogueModel.Instance.CommandQueue;
		if (commandQueue == null)
		{
			return;
		}
		commandQueue.SetForegroundIncId(survivorsOpDataForceChangeNotify.ForceIncId);
		commandQueue.StartForegroundCommand();
	}

	// Token: 0x06017138 RID: 94520 RVA: 0x005DBA8C File Offset: 0x005D9C8C
	private void OnSurvivorsStepUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		SurvivorsStepUpdateNotify survivorsStepUpdateNotify = (SurvivorsStepUpdateNotify)msg;
		if (survivorsStepUpdateNotify.PrepareStepPbData != null)
		{
			SurvivorsRogueModel.Instance.WaveTipsState = SurvivorsRogueModel.EWaveTipsState.PopWaveTips;
			return;
		}
		if (survivorsStepUpdateNotify.CombatStepPbData != null)
		{
			SurvivorsRogueModel.Instance.WaveTipsState = SurvivorsRogueModel.EWaveTipsState.ResidentWaveTips;
			return;
		}
		if (survivorsStepUpdateNotify.EndStepPbData != null)
		{
			SurvivorsRogueModel.Instance.WaveTipsState = SurvivorsRogueModel.EWaveTipsState.WaveCompleteTips;
		}
	}

	// Token: 0x06017139 RID: 94521 RVA: 0x005DBADC File Offset: 0x005D9CDC
	private void OnSurvivorsComboParamUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		SurvivorsComboParamUpdateNotify survivorsComboParamUpdateNotify = (SurvivorsComboParamUpdateNotify)msg;
		SurvivorsRogueModel.Instance.InitComboEnhanceCfg(survivorsComboParamUpdateNotify.ComboParamInfos);
	}

	// Token: 0x0601713A RID: 94522 RVA: 0x005DBB00 File Offset: 0x005D9D00
	private void OnWorldDone()
	{
		if (SurvivorsRogueModel.Instance.NeedOpenActivityMainView)
		{
			this.AddMainViewSplashTask();
		}
		if (!this.CheckInSurvivorsRogueInstance())
		{
			return;
		}
		SurvivorsRogueCommandQueue commandQueue = SurvivorsRogueModel.Instance.CommandQueue;
		if (commandQueue == null)
		{
			return;
		}
		commandQueue.StartForegroundCommand();
	}

	// Token: 0x0601713B RID: 94523 RVA: 0x005DBB40 File Offset: 0x005D9D40
	private void OnInstanceChange(int lastInstanceId, int newInstanceId)
	{
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(newInstanceId);
		if (config != null && config.Value.InstSubType == 41)
		{
			SkillButtonUiController.Instance.AddEventInterface(SurvivorsRogueModel.Instance.BattleData);
			return;
		}
		SkillButtonUiController.Instance.RemoveEventInterface(SurvivorsRogueModel.Instance.BattleData);
	}

	// Token: 0x0601713C RID: 94524 RVA: 0x005DBBA0 File Offset: 0x005D9DA0
	private void AddMainViewSplashTask()
	{
		SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.None, ESplashScreenType.Other, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.SurvivorsRogueMainView, null, null);
		});
		SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, false);
	}

	// Token: 0x0601713D RID: 94525 RVA: 0x005DBBE0 File Offset: 0x005D9DE0
	public void RequestEnterStep(ESurvivorsStepType stepType)
	{
		SurvivorsStepAdvanceRequest survivorsStepAdvanceRequest = SurvivorsStepAdvanceRequest.Create();
		if (stepType == ESurvivorsStepType.Prepare)
		{
			survivorsStepAdvanceRequest.PrepareStepPbData = SurvivorsPrepareStepPbData.Create();
		}
		else if (stepType == ESurvivorsStepType.End)
		{
			survivorsStepAdvanceRequest.EndStepPbData = SurvivorsEndStepPbData.Create();
		}
		Net.Instance.Call(ERequestMessageId.SurvivorsStepAdvanceRequest, survivorsStepAdvanceRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SurvivorsStepAdvanceResponse survivorsStepAdvanceResponse = (SurvivorsStepAdvanceResponse)msg;
			if (survivorsStepAdvanceResponse == null)
			{
				return;
			}
			if (survivorsStepAdvanceResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(survivorsStepAdvanceResponse.ErrCode, 18453, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0601713E RID: 94526 RVA: 0x005DBC44 File Offset: 0x005D9E44
	[NullableContext(1)]
	public void RequestCommandOperation(int commandIncId, List<int> operationIds, [Nullable(2)] Action<bool> callback = null)
	{
		SurvivorsOpDoneRequest survivorsOpDoneRequest = SurvivorsOpDoneRequest.Create();
		survivorsOpDoneRequest.IncId = commandIncId;
		survivorsOpDoneRequest.ClientSelectIds.AddRange(operationIds);
		Net.Instance.Call(ERequestMessageId.SurvivorsOpDoneRequest, survivorsOpDoneRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SurvivorsOpDoneResponse survivorsOpDoneResponse = (SurvivorsOpDoneResponse)msg;
			if (survivorsOpDoneResponse == null)
			{
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
				return;
			}
			else if (survivorsOpDoneResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(survivorsOpDoneResponse.ErrCode, 22698, null, true, true);
				Action<bool> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(false);
				return;
			}
			else
			{
				Action<bool> callback4 = callback;
				if (callback4 == null)
				{
					return;
				}
				callback4(true);
				return;
			}
		}, 0);
	}

	// Token: 0x0601713F RID: 94527 RVA: 0x005DBC94 File Offset: 0x005D9E94
	public void RequestDataLock(int commandIncId, int dataIncId, bool isLock, Action<bool> callback = null)
	{
		SurvivorsLockRequest survivorsLockRequest = SurvivorsLockRequest.Create();
		survivorsLockRequest.IncId = commandIncId;
		survivorsLockRequest.IsLock = isLock;
		survivorsLockRequest.ClientSelectId = dataIncId;
		Net.Instance.Call(ERequestMessageId.SurvivorsLockRequest, survivorsLockRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SurvivorsLockResponse survivorsLockResponse = (SurvivorsLockResponse)msg;
			if (survivorsLockResponse == null)
			{
				Action<bool> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(false);
				return;
			}
			else if (survivorsLockResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(survivorsLockResponse.ErrCode, 25907, null, true, true);
				Action<bool> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(false);
				return;
			}
			else
			{
				Action<bool> callback4 = callback;
				if (callback4 == null)
				{
					return;
				}
				callback4(true);
				return;
			}
		}, 0);
	}

	// Token: 0x06017140 RID: 94528 RVA: 0x005DBCE8 File Offset: 0x005D9EE8
	public void RequestEnterInst(int levelId, int survivorRoleId, int weaponId, bool isInfinite, bool isContinue)
	{
		SurvivorsLevel? survivorsLevel = SurvivorsRogueConfig.Instance.GetSurvivorsLevel(levelId);
		if (survivorsLevel == null)
		{
			return;
		}
		Aki.Config.SurvivorsRole? survivorsRole = SurvivorsRogueConfig.Instance.GetSurvivorsRole(survivorRoleId);
		if (survivorsRole == null)
		{
			return;
		}
		SurvivorsCtx survivorsCtx = SurvivorsCtx.Create();
		survivorsCtx.Continue = isContinue;
		survivorsCtx.LevelId = levelId;
		survivorsCtx.InfiniteMode = isInfinite;
		survivorsCtx.WeaponId = weaponId;
		survivorsCtx.RoleId = survivorRoleId;
		InstanceDungeonModel.Instance.InstanceEnterContentText.SurvivorsCtx = survivorsCtx;
		InstanceDungeonController.Instance.PrewarTeamFightRequest(survivorsLevel.Value.InstId, new List<int>
		{
			survivorsRole.Value.TrialRoleId
		}, 0, 0, null, null);
	}

	// Token: 0x06017141 RID: 94529 RVA: 0x005DBD98 File Offset: 0x005D9F98
	public void RequestInstSettle(bool openSettleView)
	{
		SurvivorsResultRequest message = SurvivorsResultRequest.Create();
		Net.Instance.Call(ERequestMessageId.SurvivorsResultRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SurvivorsResultResponse survivorsResultResponse = (SurvivorsResultResponse)msg;
			if (survivorsResultResponse == null)
			{
				EventSystem.Instance.Emit<bool>(EEventName.SurvivorsInstSettle, false);
				return;
			}
			if (survivorsResultResponse.ErrCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(survivorsResultResponse.ErrCode, 15576, null, true, true);
				EventSystem.Instance.Emit<bool>(EEventName.SurvivorsInstSettle, false);
				return;
			}
			if (openSettleView && survivorsResultResponse.ResultView != null)
			{
				UiManager.Instance.OpenView(EUiViewName.SurvivorsRogueSettleExternalView, survivorsResultResponse.ResultView, null);
				SurvivorsRogueModel.Instance.SelectLevelInfo = null;
			}
			EventSystem.Instance.Emit<bool>(EEventName.SurvivorsInstSettle, true);
		}, 0);
	}

	// Token: 0x06017142 RID: 94530 RVA: 0x005DBDD8 File Offset: 0x005D9FD8
	public UniTask RequestWeaponInfoUpdate()
	{
		SurvivorsRogueController.<RequestWeaponInfoUpdate>d__22 <RequestWeaponInfoUpdate>d__;
		<RequestWeaponInfoUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestWeaponInfoUpdate>d__.<>1__state = -1;
		<RequestWeaponInfoUpdate>d__.<>t__builder.Start<SurvivorsRogueController.<RequestWeaponInfoUpdate>d__22>(ref <RequestWeaponInfoUpdate>d__);
		return <RequestWeaponInfoUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x06017143 RID: 94531 RVA: 0x005DBE14 File Offset: 0x005DA014
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<SurvivorsActivityDefine.SurvivorsLevelInfo> RequestLastFile()
	{
		SurvivorsRogueController.<RequestLastFile>d__23 <RequestLastFile>d__;
		<RequestLastFile>d__.<>t__builder = AsyncUniTaskMethodBuilder<SurvivorsActivityDefine.SurvivorsLevelInfo>.Create();
		<RequestLastFile>d__.<>1__state = -1;
		<RequestLastFile>d__.<>t__builder.Start<SurvivorsRogueController.<RequestLastFile>d__23>(ref <RequestLastFile>d__);
		return <RequestLastFile>d__.<>t__builder.Task;
	}

	// Token: 0x06017144 RID: 94532 RVA: 0x005DBE50 File Offset: 0x005DA050
	public void RequestEnterInstByLevelInfo()
	{
		SurvivorsActivityDefine.SurvivorsLevelInfo selectLevelInfo = SurvivorsRogueModel.Instance.SelectLevelInfo;
		if (selectLevelInfo == null)
		{
			return;
		}
		Aki.Config.SurvivorsRole? survivorsRole = SurvivorsRogueConfig.Instance.GetSurvivorsRole(selectLevelInfo.RoleId);
		if (survivorsRole == null)
		{
			return;
		}
		this.RequestEnterInst(selectLevelInfo.LevelId, selectLevelInfo.RoleId, survivorsRole.Value.InitWeapon, selectLevelInfo.IsEndless, selectLevelInfo.IsSaveFile);
	}

	// Token: 0x06017145 RID: 94533 RVA: 0x005DBEB4 File Offset: 0x005DA0B4
	public bool CheckInSurvivorsRogueInstance()
	{
		if (!GameModeController.Instance.IsInInstance())
		{
			return false;
		}
		int instanceId = CreatureModel.Instance.GetInstanceId();
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		return config != null && config.Value.InstSubType == 41;
	}

	// Token: 0x06017146 RID: 94534 RVA: 0x005DBF08 File Offset: 0x005DA108
	public void OpenLeaveInstanceView()
	{
		int batch = SurvivorsRogueModel.Instance.BattleData.GetBatch();
		int maxBatch = SurvivorsRogueModel.Instance.BattleData.GetMaxBatch();
		SurvivorsExitViewParams param = new SurvivorsExitViewParams
		{
			IsExternal = false,
			Batch = batch,
			MaxBatch = maxBatch
		};
		UiManager.Instance.OpenView(EUiViewName.SurvivorsRogueExitView, param, null);
	}

	// Token: 0x06017147 RID: 94535 RVA: 0x005DBF61 File Offset: 0x005DA161
	public void LeaveRogueInstance()
	{
		InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default).ContinueWith(delegate(bool success)
		{
			if (success)
			{
				SurvivorsRogueModel.Instance.ClearGlobal();
			}
		});
	}

	// Token: 0x06017148 RID: 94536 RVA: 0x005DBF94 File Offset: 0x005DA194
	public void OpenRogueHelp()
	{
		SurvivorsActivityConfig? survivorsActivityConfig;
		int? num = (SurvivorsRogueModel.Instance.GetRogueActivityConfig() != null) ? new int?(survivorsActivityConfig.GetValueOrDefault().HelpId) : null;
		if (num == null)
		{
			return;
		}
		HelpController.Instance.OpenHelpById(num.Value);
	}

	// Token: 0x06017149 RID: 94537 RVA: 0x005DBFF0 File Offset: 0x005DA1F0
	public void OpenEnterInstConfirm()
	{
		if (SurvivorsRogueModel.Instance.ActivityData.NotTipsEnterInst)
		{
			this.RequestEnterInstByLevelInfo();
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SurvivorsEnterInstConfirm);
		confirmBoxDataNew.FunctionMap[1] = delegate()
		{
		};
		confirmBoxDataNew.FunctionMap[2] = new Action(this.RequestEnterInstByLevelInfo);
		confirmBoxDataNew.HasToggle = true;
		confirmBoxDataNew.ToggleTextKey = "SurvivorsRoleConfirmationDialog_PrompText";
		confirmBoxDataNew.SetToggleFunction(delegate(bool isSelectOn)
		{
			SurvivorsRogueModel.Instance.ActivityData.NotTipsEnterInst = isSelectOn;
		});
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0601714A RID: 94538 RVA: 0x005DC0A8 File Offset: 0x005DA2A8
	[NullableContext(0)]
	public UniTask<bool> TryOpenWeaponUnlockView()
	{
		SurvivorsRogueController.<TryOpenWeaponUnlockView>d__30 <TryOpenWeaponUnlockView>d__;
		<TryOpenWeaponUnlockView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<TryOpenWeaponUnlockView>d__.<>1__state = -1;
		<TryOpenWeaponUnlockView>d__.<>t__builder.Start<SurvivorsRogueController.<TryOpenWeaponUnlockView>d__30>(ref <TryOpenWeaponUnlockView>d__);
		return <TryOpenWeaponUnlockView>d__.<>t__builder.Task;
	}

	// Token: 0x17001EC7 RID: 7879
	// (get) Token: 0x0601714B RID: 94539 RVA: 0x005DC0E3 File Offset: 0x005DA2E3
	[Nullable(1)]
	public static SurvivorsRogueController Instance
	{
		[NullableContext(1)]
		get
		{
			return SurvivorsRogueController._Instance;
		}
	}

	// Token: 0x0601714C RID: 94540 RVA: 0x005DC0EA File Offset: 0x005DA2EA
	[NullableContext(1)]
	public static SurvivorsRogueController GetOrCreateInstance()
	{
		if (SurvivorsRogueController._Instance == null)
		{
			SurvivorsRogueController.CreateInstance();
		}
		return SurvivorsRogueController._Instance;
	}

	// Token: 0x0601714D RID: 94541 RVA: 0x005DC0FE File Offset: 0x005DA2FE
	public static bool CreateInstance()
	{
		if (SurvivorsRogueController._Instance != null)
		{
			return true;
		}
		SurvivorsRogueController._Instance = new SurvivorsRogueController();
		return true;
	}

	// Token: 0x0601714E RID: 94542 RVA: 0x005DC114 File Offset: 0x005DA314
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601714F RID: 94543 RVA: 0x005DC116 File Offset: 0x005DA316
	public static void ResetStaticDefaultValue()
	{
		SurvivorsRogueController._Instance = null;
	}

	// Token: 0x06017150 RID: 94544 RVA: 0x005DC11E File Offset: 0x005DA31E
	static SurvivorsRogueController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SurvivorsRogueController.CreateStaticDefaultValue), new Action(SurvivorsRogueController.ResetStaticDefaultValue));
	}

	// Token: 0x0400ACB2 RID: 44210
	private static SurvivorsRogueController _Instance;
}
