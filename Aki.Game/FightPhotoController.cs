using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x0200126E RID: 4718
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FightPhotoController : ActivityControllerBase
{
	// Token: 0x060080A6 RID: 32934 RVA: 0x001B3A13 File Offset: 0x001B1C13
	[NullableContext(2)]
	public BP_CameraShot_C GetCameraShotActor()
	{
		return this.CameraShotActor;
	}

	// Token: 0x060080A7 RID: 32935 RVA: 0x001B3A1B File Offset: 0x001B1C1B
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PhotoFightResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTaskInfoUpdate));
		Net.Instance.Register(ENotifyMessageId.PhotoFightLevelInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLevelInfoUpdate));
	}

	// Token: 0x060080A8 RID: 32936 RVA: 0x001B3A55 File Offset: 0x001B1C55
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PhotoFightResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhotoFightLevelInfoNotify);
	}

	// Token: 0x060080A9 RID: 32937 RVA: 0x001B3A78 File Offset: 0x001B1C78
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x060080AA RID: 32938 RVA: 0x001B3ADC File Offset: 0x001B1CDC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x060080AB RID: 32939 RVA: 0x001B3B3D File Offset: 0x001B1D3D
	protected override void OnOpenView(ActivityBaseData data)
	{
		throw new Exception("Method not implemented.");
	}

	// Token: 0x060080AC RID: 32940 RVA: 0x001B3B49 File Offset: 0x001B1D49
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityBattlePhoto";
	}

	// Token: 0x060080AD RID: 32941 RVA: 0x001B3B50 File Offset: 0x001B1D50
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new FightPhotoActivitySubView();
	}

	// Token: 0x060080AE RID: 32942 RVA: 0x001B3B58 File Offset: 0x001B1D58
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		FightPhotoActivityData fightPhotoActivityData = new FightPhotoActivityData();
		this.FightPhotoActivityData = fightPhotoActivityData;
		return fightPhotoActivityData;
	}

	// Token: 0x060080AF RID: 32943 RVA: 0x001B3B74 File Offset: 0x001B1D74
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		foreach (EUiViewName viewName in new EUiViewName[]
		{
			EUiViewName.FightPhotoMainView,
			EUiViewName.FightPhotoRewardView
		})
		{
			if (UiManager.Instance.IsViewOpen(viewName))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060080B0 RID: 32944 RVA: 0x001B3BC6 File Offset: 0x001B1DC6
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.FightPhotoUnlockTipView, null, null);
	}

	// Token: 0x060080B1 RID: 32945 RVA: 0x001B3BDC File Offset: 0x001B1DDC
	[NullableContext(0)]
	protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
	{
		FightPhotoController.<OnOpenSubView>d__18 <OnOpenSubView>d__;
		<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnOpenSubView>d__.<>4__this = this;
		<OnOpenSubView>d__.viewName = viewName;
		<OnOpenSubView>d__.<>1__state = -1;
		<OnOpenSubView>d__.<>t__builder.Start<FightPhotoController.<OnOpenSubView>d__18>(ref <OnOpenSubView>d__);
		return <OnOpenSubView>d__.<>t__builder.Task;
	}

	// Token: 0x060080B2 RID: 32946 RVA: 0x001B3C28 File Offset: 0x001B1E28
	[NullableContext(2)]
	public FightPhotoActivityData GetActivityData()
	{
		if (this.FightPhotoActivityData == null)
		{
			Log.Instance.Error(ELogModule.FightPhotograph, ELogAuthor.CXJ, "战斗拍照活动数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return this.FightPhotoActivityData;
	}

	// Token: 0x060080B3 RID: 32947 RVA: 0x001B3C64 File Offset: 0x001B1E64
	[NullableContext(2)]
	private void OnTaskInfoUpdate(IMessage msg, Net.CallbackStatus status)
	{
		PhotoFightResultNotify photoFightResultNotify = (PhotoFightResultNotify)msg;
		this.FightPhotoActivityData.UpdateTaskData(photoFightResultNotify.Targets);
	}

	// Token: 0x060080B4 RID: 32948 RVA: 0x001B3C8C File Offset: 0x001B1E8C
	[NullableContext(2)]
	private void OnLevelInfoUpdate(IMessage msg, Net.CallbackStatus status)
	{
		PhotoFightLevelInfoNotify photoFightLevelInfoNotify = (PhotoFightLevelInfoNotify)msg;
		this.FightPhotoActivityData.UpdateLevelData(photoFightLevelInfoNotify.PhotoFightLevelInfos, false);
	}

	// Token: 0x060080B5 RID: 32949 RVA: 0x001B3CB4 File Offset: 0x001B1EB4
	public UniTask EnterFightPhotoDungeonDirectly(int activityId, int levelId, int instanceId, int[] roleIds)
	{
		FightPhotoController.<EnterFightPhotoDungeonDirectly>d__22 <EnterFightPhotoDungeonDirectly>d__;
		<EnterFightPhotoDungeonDirectly>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<EnterFightPhotoDungeonDirectly>d__.<>4__this = this;
		<EnterFightPhotoDungeonDirectly>d__.activityId = activityId;
		<EnterFightPhotoDungeonDirectly>d__.levelId = levelId;
		<EnterFightPhotoDungeonDirectly>d__.instanceId = instanceId;
		<EnterFightPhotoDungeonDirectly>d__.roleIds = roleIds;
		<EnterFightPhotoDungeonDirectly>d__.<>1__state = -1;
		<EnterFightPhotoDungeonDirectly>d__.<>t__builder.Start<FightPhotoController.<EnterFightPhotoDungeonDirectly>d__22>(ref <EnterFightPhotoDungeonDirectly>d__);
		return <EnterFightPhotoDungeonDirectly>d__.<>t__builder.Task;
	}

	// Token: 0x060080B6 RID: 32950 RVA: 0x001B3D18 File Offset: 0x001B1F18
	public void RequestTaskReward(int[] taskIds)
	{
		FightPhotoActivityData activityData = this.GetActivityData();
		PhotoFightTaskRewardRequest photoFightTaskRewardRequest = PhotoFightTaskRewardRequest.Create();
		photoFightTaskRewardRequest.TargetIds.AddRange(taskIds);
		photoFightTaskRewardRequest.ActivityId = activityData.Id;
		Net.Instance.Call(ERequestMessageId.PhotoFightTaskRewardRequest, photoFightTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhotoFightTaskRewardResponse photoFightTaskRewardResponse = (PhotoFightTaskRewardResponse)msg;
			if (photoFightTaskRewardResponse == null)
			{
				return;
			}
			if (photoFightTaskRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(photoFightTaskRewardResponse.ErrorCode, 22692, null, true, true);
				return;
			}
			activityData.UpdateTaskRewardStatus(photoFightTaskRewardResponse.Targets);
		}, 0);
	}

	// Token: 0x060080B7 RID: 32951 RVA: 0x001B3D78 File Offset: 0x001B1F78
	public void RequestInstanceSettle()
	{
		PhotoFightSettleRequest message = PhotoFightSettleRequest.Create();
		Net.Instance.Call(ERequestMessageId.PhotoFightSettleRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			PhotoFightSettleResponse photoFightSettleResponse = (PhotoFightSettleResponse)msg;
			if (photoFightSettleResponse == null)
			{
				return;
			}
			if (photoFightSettleResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(photoFightSettleResponse.ErrorCode, 20695, null, true, true);
			}
		}, 0);
	}

	// Token: 0x060080B8 RID: 32952 RVA: 0x001B3DBC File Offset: 0x001B1FBC
	public bool CheckInFightPhotoDungeon()
	{
		if (GameModeController.Instance.IsInInstance())
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			return config != null && config.GetValueOrDefault().InstSubType == 42;
		}
		return false;
	}

	// Token: 0x060080B9 RID: 32953 RVA: 0x001B3E0C File Offset: 0x001B200C
	private void OnActiveBattleView()
	{
		if (this.FightPhotoActivityData == null)
		{
			return;
		}
		if (this.CheckInFightPhotoDungeon())
		{
			UiManager.Instance.OpenView(EUiViewName.FightPhotoFocusView, null, null);
			int currentStepCount = this.GetCurrentStepCount();
			if (currentStepCount < 3 && this.StepCount < currentStepCount)
			{
				this.StepCount = currentStepCount;
				this.ShowFightPhotoTips(this.StepTextIdList[currentStepCount]);
			}
		}
	}

	// Token: 0x060080BA RID: 32954 RVA: 0x001B3E64 File Offset: 0x001B2064
	public void LeaveInstanceDungeon(bool needRequestLeave = true)
	{
		if (this.CheckInFightPhotoDungeon())
		{
			if (this.EnterDungeonTimestampMs > 0L)
			{
				this.ReportFightPhotoDuration();
				this.EnterDungeonTimestampMs = 0L;
			}
			PhotographModel.Instance.SetPhotographTimeDilation(1f);
			AudioSystem.Instance.SetState("game_sys_fightphoto", "none", true);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ForceNoPerBoneMotionBlur 0", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "fx.Niagara.FixScaleZeroProblem 0", null);
			PhotographController.Instance.ClearAllSavedFightPhotos();
			if (this.CameraShotActor != null)
			{
				ActorSystem.Instance.Put("FightPhotoController.LeaveInstanceDungeon", this.CameraShotActor, null);
				this.CameraShotActor = null;
			}
			if (needRequestLeave)
			{
				if (this.FightPhotoActivityData != null && !this.FightPhotoActivityData.CheckIfClose())
				{
					this.FightPhotoActivityData.IsNeedShowFightPhotoMainView = true;
				}
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeonRequest(LeaveInstWay.Default);
			}
			this.StepCount = 0;
		}
	}

	// Token: 0x060080BB RID: 32955 RVA: 0x001B3F3F File Offset: 0x001B213F
	public void AddColorAdjustDuration(long time)
	{
		if (time > 0L)
		{
			this.ColorAdjustDurationMs += time;
		}
	}

	// Token: 0x060080BC RID: 32956 RVA: 0x001B3F54 File Offset: 0x001B2154
	private void ReportFightPhotoDuration()
	{
		FightPhotoActivityData activityData = this.GetActivityData();
		FightPhotoLevelData fightPhotoLevelData = (activityData != null) ? activityData.GetCurrentLevelData(true) : null;
		if (fightPhotoLevelData == null)
		{
			return;
		}
		FightPhotoDurationLogEvent fightPhotoDurationLogEvent = new FightPhotoDurationLogEvent();
		fightPhotoDurationLogEvent.i_total_duration = (int)Math.Floor((double)(DateTimeOffset.Now.ToUnixTimeMilliseconds() - this.EnterDungeonTimestampMs) / 1000.0);
		fightPhotoDurationLogEvent.i_add_time = (int)Math.Floor((double)this.ColorAdjustDurationMs / 1000.0);
		List<int> roleIdList = fightPhotoLevelData.GetRoleIdList();
		fightPhotoDurationLogEvent.o_team_character = new List<int>(roleIdList);
		Span<int> trialRoleList = fightPhotoLevelData.TrialRoleList;
		List<FightPhotoTeamSkinData> list = new List<FightPhotoTeamSkinData>();
		foreach (int num in roleIdList)
		{
			list.Add(new FightPhotoTeamSkinData
			{
				skin_id = RoleSkinModel.Instance.GetRoleSkinIdByRoleId(num),
				is_trial = ((trialRoleList.Contains(num) > false) ? 1 : 0)
			});
		}
		fightPhotoDurationLogEvent.o_team_suit = list;
		fightPhotoDurationLogEvent.i_result = PhotographController.Instance.GetSavedFightPhotos().Count;
		fightPhotoDurationLogEvent.i_inst_id = fightPhotoLevelData.InstanceId;
		fightPhotoDurationLogEvent.i_inst_diff = ((fightPhotoLevelData.IsDifficulty > false) ? 1 : 0);
		fightPhotoDurationLogEvent.s_trace_id = CreatureModel.Instance.GetSceneTraceId().ToString();
		LogReportController.Instance.LogReport(fightPhotoDurationLogEvent);
	}

	// Token: 0x060080BD RID: 32957 RVA: 0x001B40BC File Offset: 0x001B22BC
	private void OnWorldDone()
	{
		if (this.FightPhotoActivityData != null && this.FightPhotoActivityData.IsNeedShowFightPhotoMainView)
		{
			this.AddMainViewSplashTask();
		}
		if (this.CheckInFightPhotoDungeon())
		{
			this.EnterDungeonTimestampMs = DateTimeOffset.Now.ToUnixTimeMilliseconds();
			this.ColorAdjustDurationMs = 0L;
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.ForceNoPerBoneMotionBlur 1", null);
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "fx.Niagara.FixScaleZeroProblem 1", null);
			FightPhotoModel.Instance.InitDefaultSetupOption();
			if (this.CameraShotActor != null)
			{
				ActorSystem.Instance.Put("FightPhotoController.OnWorldDone", this.CameraShotActor, null);
				this.CameraShotActor = null;
			}
			this.CameraShotActor = (ActorSystem.Instance.Get(BP_CameraShot_C.StaticClass(), new FTransformDouble(), null, true) as BP_CameraShot_C);
		}
	}

	// Token: 0x060080BE RID: 32958 RVA: 0x001B417C File Offset: 0x001B237C
	private void AddMainViewSplashTask()
	{
		SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.None, ESplashScreenType.Other, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.FightPhotoMainView, this.FightPhotoActivityData, null);
		});
		SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, false);
	}

	// Token: 0x060080BF RID: 32959 RVA: 0x001B41A9 File Offset: 0x001B23A9
	private int GetCurrentStepCount()
	{
		return PhotographController.Instance.GetSavedFightPhotos().Count;
	}

	// Token: 0x060080C0 RID: 32960 RVA: 0x001B41BC File Offset: 0x001B23BC
	public void ShowFightPhotoTips(string textId)
	{
		if (Array.IndexOf<string>(this.StepTextIdList, textId) >= 0 && !UiManager.Instance.IsViewShow(EUiViewName.BattleView))
		{
			return;
		}
		TableTextArgNew mainTextObj = new TableTextArgNew(textId, Array.Empty<object>());
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FightPhotoEventTip, mainTextObj, null, null, null, null, null, null, null, false, null);
	}

	// Token: 0x060080C1 RID: 32961 RVA: 0x001B421C File Offset: 0x001B241C
	private void OnActivityClose(IReadOnlySet<int> closeActivities)
	{
		if (this.FightPhotoActivityData == null)
		{
			return;
		}
		if (closeActivities.Contains(this.FightPhotoActivityData.Id) && this.CheckInFightPhotoDungeon())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FightPhotoActivityEnd);
			confirmBoxDataNew.FunctionMap[1] = new Action(this.<OnActivityClose>g__confirmCallback|34_0);
			confirmBoxDataNew.FunctionMap[0] = new Action(this.<OnActivityClose>g__confirmCallback|34_0);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
	}

	// Token: 0x17000B12 RID: 2834
	// (get) Token: 0x060080C2 RID: 32962 RVA: 0x001B4294 File Offset: 0x001B2494
	public static FightPhotoController Instance
	{
		get
		{
			return FightPhotoController._Instance;
		}
	}

	// Token: 0x060080C3 RID: 32963 RVA: 0x001B429B File Offset: 0x001B249B
	public static FightPhotoController GetOrCreateInstance()
	{
		if (FightPhotoController._Instance == null)
		{
			FightPhotoController.CreateInstance();
		}
		return FightPhotoController._Instance;
	}

	// Token: 0x060080C4 RID: 32964 RVA: 0x001B42AF File Offset: 0x001B24AF
	public static bool CreateInstance()
	{
		if (FightPhotoController._Instance != null)
		{
			return true;
		}
		FightPhotoController._Instance = new FightPhotoController();
		return true;
	}

	// Token: 0x060080C5 RID: 32965 RVA: 0x001B42C5 File Offset: 0x001B24C5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060080C6 RID: 32966 RVA: 0x001B42C7 File Offset: 0x001B24C7
	public static void ResetStaticDefaultValue()
	{
		FightPhotoController._Instance = null;
	}

	// Token: 0x060080C7 RID: 32967 RVA: 0x001B42CF File Offset: 0x001B24CF
	static FightPhotoController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FightPhotoController.CreateStaticDefaultValue), new Action(FightPhotoController.ResetStaticDefaultValue));
	}

	// Token: 0x060080CA RID: 32970 RVA: 0x001B4332 File Offset: 0x001B2532
	[CompilerGenerated]
	private void <OnActivityClose>g__confirmCallback|34_0()
	{
		this.LeaveInstanceDungeon(true);
	}

	// Token: 0x04003A53 RID: 14931
	public readonly string[] StepTextIdList = new string[]
	{
		"PhotographicTipMainText_01",
		"PhotographicTipMainText_02",
		"PhotographicTipMainText_03"
	};

	// Token: 0x04003A54 RID: 14932
	private const int MAX_STEP_NUM = 3;

	// Token: 0x04003A55 RID: 14933
	[Nullable(2)]
	private FightPhotoActivityData FightPhotoActivityData;

	// Token: 0x04003A56 RID: 14934
	private int StepCount;

	// Token: 0x04003A57 RID: 14935
	private long EnterDungeonTimestampMs;

	// Token: 0x04003A58 RID: 14936
	private long ColorAdjustDurationMs;

	// Token: 0x04003A59 RID: 14937
	[Nullable(2)]
	private BP_CameraShot_C CameraShotActor;

	// Token: 0x04003A5A RID: 14938
	[Nullable(2)]
	private static FightPhotoController _Instance;
}
