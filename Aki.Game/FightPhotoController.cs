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

// Token: 0x02000722 RID: 1826
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class FightPhotoController : ActivityControllerBase
{
	// Token: 0x0600543D RID: 21565 RVA: 0x001BC6E3 File Offset: 0x001BA8E3
	[NullableContext(2)]
	public BP_CameraShot_C GetCameraShotActor()
	{
		return this.CameraShotActor;
	}

	// Token: 0x0600543E RID: 21566 RVA: 0x001BC6EB File Offset: 0x001BA8EB
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PhotoFightResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTaskInfoUpdate));
		Net.Instance.Register(ENotifyMessageId.PhotoFightLevelInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLevelInfoUpdate));
	}

	// Token: 0x0600543F RID: 21567 RVA: 0x001BC725 File Offset: 0x001BA925
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PhotoFightResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.PhotoFightLevelInfoNotify);
	}

	// Token: 0x06005440 RID: 21568 RVA: 0x001BC748 File Offset: 0x001BA948
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06005441 RID: 21569 RVA: 0x001BC7AC File Offset: 0x001BA9AC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
		EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
	}

	// Token: 0x06005442 RID: 21570 RVA: 0x001BC80D File Offset: 0x001BAA0D
	protected override void OnOpenView(ActivityBaseData data)
	{
		throw new Exception("Method not implemented.");
	}

	// Token: 0x06005443 RID: 21571 RVA: 0x001BC819 File Offset: 0x001BAA19
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_ActivityBattlePhoto";
	}

	// Token: 0x06005444 RID: 21572 RVA: 0x001BC820 File Offset: 0x001BAA20
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new FightPhotoActivitySubView();
	}

	// Token: 0x06005445 RID: 21573 RVA: 0x001BC828 File Offset: 0x001BAA28
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		FightPhotoActivityData fightPhotoActivityData = new FightPhotoActivityData();
		this.FightPhotoActivityData = fightPhotoActivityData;
		return fightPhotoActivityData;
	}

	// Token: 0x06005446 RID: 21574 RVA: 0x001BC844 File Offset: 0x001BAA44
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

	// Token: 0x06005447 RID: 21575 RVA: 0x001BC896 File Offset: 0x001BAA96
	public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		UiManager.Instance.OpenView(EUiViewName.FightPhotoUnlockTipView, null, null);
	}

	// Token: 0x06005448 RID: 21576 RVA: 0x001BC8AC File Offset: 0x001BAAAC
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

	// Token: 0x06005449 RID: 21577 RVA: 0x001BC8F8 File Offset: 0x001BAAF8
	[NullableContext(2)]
	public FightPhotoActivityData GetActivityData()
	{
		if (this.FightPhotoActivityData == null)
		{
			Log.Instance.Error(ELogModule.FightPhotograph, ELogAuthor.CXJ, "战斗拍照活动数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return this.FightPhotoActivityData;
	}

	// Token: 0x0600544A RID: 21578 RVA: 0x001BC934 File Offset: 0x001BAB34
	[NullableContext(2)]
	private void OnTaskInfoUpdate(IMessage msg, Net.CallbackStatus status)
	{
		PhotoFightResultNotify photoFightResultNotify = (PhotoFightResultNotify)msg;
		this.FightPhotoActivityData.UpdateTaskData(photoFightResultNotify.Targets);
	}

	// Token: 0x0600544B RID: 21579 RVA: 0x001BC95C File Offset: 0x001BAB5C
	[NullableContext(2)]
	private void OnLevelInfoUpdate(IMessage msg, Net.CallbackStatus status)
	{
		PhotoFightLevelInfoNotify photoFightLevelInfoNotify = (PhotoFightLevelInfoNotify)msg;
		this.FightPhotoActivityData.UpdateLevelData(photoFightLevelInfoNotify.PhotoFightLevelInfos, false);
	}

	// Token: 0x0600544C RID: 21580 RVA: 0x001BC984 File Offset: 0x001BAB84
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

	// Token: 0x0600544D RID: 21581 RVA: 0x001BC9E8 File Offset: 0x001BABE8
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(photoFightTaskRewardResponse.ErrorCode, 20913, null, true, true);
				return;
			}
			activityData.UpdateTaskRewardStatus(photoFightTaskRewardResponse.Targets);
		}, 0);
	}

	// Token: 0x0600544E RID: 21582 RVA: 0x001BCA48 File Offset: 0x001BAC48
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(photoFightSettleResponse.ErrorCode, 26567, null, true, true);
			}
		}, 0);
	}

	// Token: 0x0600544F RID: 21583 RVA: 0x001BCA8C File Offset: 0x001BAC8C
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

	// Token: 0x06005450 RID: 21584 RVA: 0x001BCADC File Offset: 0x001BACDC
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

	// Token: 0x06005451 RID: 21585 RVA: 0x001BCB34 File Offset: 0x001BAD34
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

	// Token: 0x06005452 RID: 21586 RVA: 0x001BCC0F File Offset: 0x001BAE0F
	public void AddColorAdjustDuration(long time)
	{
		if (time > 0L)
		{
			this.ColorAdjustDurationMs += time;
		}
	}

	// Token: 0x06005453 RID: 21587 RVA: 0x001BCC24 File Offset: 0x001BAE24
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

	// Token: 0x06005454 RID: 21588 RVA: 0x001BCD8C File Offset: 0x001BAF8C
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

	// Token: 0x06005455 RID: 21589 RVA: 0x001BCE4C File Offset: 0x001BB04C
	private void AddMainViewSplashTask()
	{
		SplashScreenTask splashScreenTask = new SplashScreenTask(ESplashScreenSourceModuleType.None, ESplashScreenType.Other, delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.FightPhotoMainView, this.FightPhotoActivityData, null);
		});
		SplashScreenController.Instance.PushSplashScreenTask(splashScreenTask, false);
	}

	// Token: 0x06005456 RID: 21590 RVA: 0x001BCE79 File Offset: 0x001BB079
	private int GetCurrentStepCount()
	{
		return PhotographController.Instance.GetSavedFightPhotos().Count;
	}

	// Token: 0x06005457 RID: 21591 RVA: 0x001BCE8C File Offset: 0x001BB08C
	public void ShowFightPhotoTips(string textId)
	{
		if (Array.IndexOf<string>(this.StepTextIdList, textId) >= 0 && !UiManager.Instance.IsViewShow(EUiViewName.BattleView))
		{
			return;
		}
		TableTextArgNew mainTextObj = new TableTextArgNew(textId, Array.Empty<object>());
		GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.FightPhotoEventTip, mainTextObj, null, null, null, null, null, null, null, false, null);
	}

	// Token: 0x06005458 RID: 21592 RVA: 0x001BCEEC File Offset: 0x001BB0EC
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

	// Token: 0x17000B32 RID: 2866
	// (get) Token: 0x06005459 RID: 21593 RVA: 0x001BCF64 File Offset: 0x001BB164
	public static FightPhotoController Instance
	{
		get
		{
			return FightPhotoController._Instance;
		}
	}

	// Token: 0x0600545A RID: 21594 RVA: 0x001BCF6B File Offset: 0x001BB16B
	public static FightPhotoController GetOrCreateInstance()
	{
		if (FightPhotoController._Instance == null)
		{
			FightPhotoController.CreateInstance();
		}
		return FightPhotoController._Instance;
	}

	// Token: 0x0600545B RID: 21595 RVA: 0x001BCF7F File Offset: 0x001BB17F
	public static bool CreateInstance()
	{
		if (FightPhotoController._Instance != null)
		{
			return true;
		}
		FightPhotoController._Instance = new FightPhotoController();
		return true;
	}

	// Token: 0x0600545C RID: 21596 RVA: 0x001BCF95 File Offset: 0x001BB195
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600545D RID: 21597 RVA: 0x001BCF97 File Offset: 0x001BB197
	public static void ResetStaticDefaultValue()
	{
		FightPhotoController._Instance = null;
	}

	// Token: 0x0600545E RID: 21598 RVA: 0x001BCF9F File Offset: 0x001BB19F
	static FightPhotoController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FightPhotoController.CreateStaticDefaultValue), new Action(FightPhotoController.ResetStaticDefaultValue));
	}

	// Token: 0x06005461 RID: 21601 RVA: 0x001BD002 File Offset: 0x001BB202
	[CompilerGenerated]
	private void <OnActivityClose>g__confirmCallback|34_0()
	{
		this.LeaveInstanceDungeon(true);
	}

	// Token: 0x04003AEB RID: 15083
	public readonly string[] StepTextIdList = new string[]
	{
		"PhotographicTipMainText_01",
		"PhotographicTipMainText_02",
		"PhotographicTipMainText_03"
	};

	// Token: 0x04003AEC RID: 15084
	private const int MAX_STEP_NUM = 3;

	// Token: 0x04003AED RID: 15085
	[Nullable(2)]
	private FightPhotoActivityData FightPhotoActivityData;

	// Token: 0x04003AEE RID: 15086
	private int StepCount;

	// Token: 0x04003AEF RID: 15087
	private long EnterDungeonTimestampMs;

	// Token: 0x04003AF0 RID: 15088
	private long ColorAdjustDurationMs;

	// Token: 0x04003AF1 RID: 15089
	[Nullable(2)]
	private BP_CameraShot_C CameraShotActor;

	// Token: 0x04003AF2 RID: 15090
	[Nullable(2)]
	private static FightPhotoController _Instance;
}
