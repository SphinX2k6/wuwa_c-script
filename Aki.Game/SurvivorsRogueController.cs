using System;
using System.Collections.Generic;
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

// Token: 0x020020FD RID: 8445
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class SurvivorsRogueController : UiControllerBase
{
	// Token: 0x06014B5D RID: 84829 RVA: 0x00608198 File Offset: 0x00606398
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

	// Token: 0x06014B5E RID: 84830 RVA: 0x0060826C File Offset: 0x0060646C
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

	// Token: 0x06014B5F RID: 84831 RVA: 0x006082E9 File Offset: 0x006064E9
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
	}

	// Token: 0x06014B60 RID: 84832 RVA: 0x00608323 File Offset: 0x00606523
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove<int, int>(EEventName.OnInstanceChange, new Action<int, int>(this.OnInstanceChange));
	}

	// Token: 0x06014B61 RID: 84833 RVA: 0x0060835D File Offset: 0x0060655D
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.SurvivorsTabMainView, new Func<EUiViewName, object, bool>(this.CanOpenSurvivorsTabMainView), "SurvivorsRogueController.CanOpenSurvivorsTabMainView");
	}

	// Token: 0x06014B62 RID: 84834 RVA: 0x0060837F File Offset: 0x0060657F
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.SurvivorsTabMainView, new Func<EUiViewName, object, bool>(this.CanOpenSurvivorsTabMainView));
	}

	// Token: 0x06014B63 RID: 84835 RVA: 0x0060839C File Offset: 0x0060659C
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

	// Token: 0x06014B64 RID: 84836 RVA: 0x006083E8 File Offset: 0x006065E8
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

	// Token: 0x06014B65 RID: 84837 RVA: 0x00608468 File Offset: 0x00606668
	private void OnSurvivorsVarRecordNotify(IMessage msg, Net.CallbackStatus status)
	{
		SurvivorsVarRecordNotify survivorsVarRecordNotify = (SurvivorsVarRecordNotify)msg;
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (KeyValuePair<string, string> keyValuePair in survivorsVarRecordNotify.VariableKeyNames)
		{
			dictionary[keyValuePair.Key] = keyValuePair.Value;
		}
		SurvivorsRogueModel.Instance.BattleData.SetBehaviorTreeVar(dictionary);
	}

	// Token: 0x06014B66 RID: 84838 RVA: 0x006084E0 File Offset: 0x006066E0
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

	// Token: 0x06014B67 RID: 84839 RVA: 0x0060857C File Offset: 0x0060677C
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

	// Token: 0x06014B68 RID: 84840 RVA: 0x00608630 File Offset: 0x00606830
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

	// Token: 0x06014B69 RID: 84841 RVA: 0x00608668 File Offset: 0x00606868
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

	// Token: 0x06014B6A RID: 84842 RVA: 0x006086B8 File Offset: 0x006068B8
	private void OnSurvivorsComboParamUpdateNotify(IMessage msg, Net.CallbackStatus status)
	{
		SurvivorsComboParamUpdateNotify survivorsComboParamUpdateNotify = (SurvivorsComboParamUpdateNotify)msg;
		SurvivorsRogueModel.Instance.InitComboEnhanceCfg(survivorsComboParamUpdateNotify.ComboParamInfos);
	}

	// Token: 0x06014B6B RID: 84843 RVA: 0x006086DC File Offset: 0x006068DC
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

	// Token: 0x06014B6C RID: 84844 RVA: 0x0060871C File Offset: 0x0060691C
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

	// Token: 0x06014B6D RID: 84845 RVA: 0x0060877C File Offset: 0x0060697C
	private void AddMainViewSplashTask()
	{
		SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.None, ESplashScreenType.Other, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.SurvivorsRogueMainView, null, null);
		});
		SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, false);
	}

	// Token: 0x06014B6E RID: 84846 RVA: 0x006087BC File Offset: 0x006069BC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(survivorsStepAdvanceResponse.ErrCode, 23962, null, true, true);
			}
		}, 0);
	}

	// Token: 0x06014B6F RID: 84847 RVA: 0x00608820 File Offset: 0x00606A20
	[NullableContext(1)]
	public void RequestCommandOperation(int commandIncId, IEnumerable<int> operationIds, [Nullable(2)] Action<bool> callback = null)
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(survivorsOpDoneResponse.ErrCode, 18127, null, true, true);
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

	// Token: 0x06014B70 RID: 84848 RVA: 0x00608870 File Offset: 0x00606A70
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(survivorsLockResponse.ErrCode, 24428, null, true, true);
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

	// Token: 0x06014B71 RID: 84849 RVA: 0x006088C4 File Offset: 0x00606AC4
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

	// Token: 0x06014B72 RID: 84850 RVA: 0x00608974 File Offset: 0x00606B74
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(survivorsResultResponse.ErrCode, 24240, null, true, true);
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

	// Token: 0x06014B73 RID: 84851 RVA: 0x006089B4 File Offset: 0x00606BB4
	public UniTask RequestWeaponInfoUpdate()
	{
		SurvivorsRogueController.<RequestWeaponInfoUpdate>d__22 <RequestWeaponInfoUpdate>d__;
		<RequestWeaponInfoUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestWeaponInfoUpdate>d__.<>1__state = -1;
		<RequestWeaponInfoUpdate>d__.<>t__builder.Start<SurvivorsRogueController.<RequestWeaponInfoUpdate>d__22>(ref <RequestWeaponInfoUpdate>d__);
		return <RequestWeaponInfoUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x06014B74 RID: 84852 RVA: 0x006089F0 File Offset: 0x00606BF0
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

	// Token: 0x06014B75 RID: 84853 RVA: 0x00608A2C File Offset: 0x00606C2C
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

	// Token: 0x06014B76 RID: 84854 RVA: 0x00608A90 File Offset: 0x00606C90
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

	// Token: 0x06014B77 RID: 84855 RVA: 0x00608AE4 File Offset: 0x00606CE4
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

	// Token: 0x06014B78 RID: 84856 RVA: 0x00608B3D File Offset: 0x00606D3D
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

	// Token: 0x06014B79 RID: 84857 RVA: 0x00608B70 File Offset: 0x00606D70
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

	// Token: 0x06014B7A RID: 84858 RVA: 0x00608BCC File Offset: 0x00606DCC
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

	// Token: 0x06014B7B RID: 84859 RVA: 0x00608C84 File Offset: 0x00606E84
	[NullableContext(0)]
	public UniTask<bool> TryOpenWeaponUnlockView()
	{
		SurvivorsRogueController.<TryOpenWeaponUnlockView>d__30 <TryOpenWeaponUnlockView>d__;
		<TryOpenWeaponUnlockView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<TryOpenWeaponUnlockView>d__.<>1__state = -1;
		<TryOpenWeaponUnlockView>d__.<>t__builder.Start<SurvivorsRogueController.<TryOpenWeaponUnlockView>d__30>(ref <TryOpenWeaponUnlockView>d__);
		return <TryOpenWeaponUnlockView>d__.<>t__builder.Task;
	}

	// Token: 0x17001F1F RID: 7967
	// (get) Token: 0x06014B7C RID: 84860 RVA: 0x00608CBF File Offset: 0x00606EBF
	[Nullable(1)]
	public static SurvivorsRogueController Instance
	{
		[NullableContext(1)]
		get
		{
			return SurvivorsRogueController._Instance;
		}
	}

	// Token: 0x06014B7D RID: 84861 RVA: 0x00608CC6 File Offset: 0x00606EC6
	[NullableContext(1)]
	public static SurvivorsRogueController GetOrCreateInstance()
	{
		if (SurvivorsRogueController._Instance == null)
		{
			SurvivorsRogueController.CreateInstance();
		}
		return SurvivorsRogueController._Instance;
	}

	// Token: 0x06014B7E RID: 84862 RVA: 0x00608CDA File Offset: 0x00606EDA
	public static bool CreateInstance()
	{
		if (SurvivorsRogueController._Instance != null)
		{
			return true;
		}
		SurvivorsRogueController._Instance = new SurvivorsRogueController();
		return true;
	}

	// Token: 0x06014B7F RID: 84863 RVA: 0x00608CF0 File Offset: 0x00606EF0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014B80 RID: 84864 RVA: 0x00608CF2 File Offset: 0x00606EF2
	public static void ResetStaticDefaultValue()
	{
		SurvivorsRogueController._Instance = null;
	}

	// Token: 0x06014B81 RID: 84865 RVA: 0x00608CFA File Offset: 0x00606EFA
	static SurvivorsRogueController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SurvivorsRogueController.CreateStaticDefaultValue), new Action(SurvivorsRogueController.ResetStaticDefaultValue));
	}

	// Token: 0x0400B0B9 RID: 45241
	private static SurvivorsRogueController _Instance;
}
