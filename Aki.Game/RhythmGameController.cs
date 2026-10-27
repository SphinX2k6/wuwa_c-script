using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Gameplay.RhythmGame;
using AkiClient.Game.Aki.Data.Level.PlaneYinyou.BP;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001085 RID: 4229
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class RhythmGameController : UiControllerBase
{
	// Token: 0x06006DBB RID: 28091 RVA: 0x001634DE File Offset: 0x001616DE
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x06006DBC RID: 28092 RVA: 0x001634FC File Offset: 0x001616FC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x06006DBD RID: 28093 RVA: 0x0016351C File Offset: 0x0016171C
	private void OnWorldDone()
	{
		this.FeverTimes = 0;
		InstanceDungeon? instanceDungeon;
		if (((GameModeModel.Instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().InstSubType) : null).GetValueOrDefault() != 53)
		{
			this.IsEnterRhythmGame = false;
			this.ClearCache();
			return;
		}
		this.IsEnterRhythmGame = true;
		this.ClearCache();
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		GameModeController.Instance.AddWorldDoneBlocker(delegate
		{
			RhythmGameController.<<OnWorldDone>b__32_0>d <<OnWorldDone>b__32_0>d;
			<<OnWorldDone>b__32_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<OnWorldDone>b__32_0>d.<>4__this = this;
			<<OnWorldDone>b__32_0>d.<>1__state = -1;
			<<OnWorldDone>b__32_0>d.<>t__builder.Start<RhythmGameController.<<OnWorldDone>b__32_0>d>(ref <<OnWorldDone>b__32_0>d);
			return <<OnWorldDone>b__32_0>d.<>t__builder.Task;
		}, 60000);
	}

	// Token: 0x06006DBE RID: 28094 RVA: 0x001635D8 File Offset: 0x001617D8
	protected override bool OnLeaveLevel()
	{
		if (!this.IsEnterRhythmGame)
		{
			return base.OnLeaveLevel();
		}
		if (this.MusicEventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.MusicEventHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
			this.MusicEventHandle = 0;
		}
		if (this.HoldNoteEventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.HoldNoteEventHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
			this.HoldNoteEventHandle = 0;
		}
		if (this.FeverLoopEventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.FeverLoopEventHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
			this.FeverLoopEventHandle = 0;
		}
		if (EventSystem.Instance.Has<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView)))
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		}
		if (EventSystem.Instance.Has<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView)))
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}
		this.IsEnterRhythmGame = false;
		return base.OnLeaveLevel();
	}

	// Token: 0x06006DBF RID: 28095 RVA: 0x00163718 File Offset: 0x00161918
	private UniTask StartRhythmGame()
	{
		RhythmGameController.<StartRhythmGame>d__34 <StartRhythmGame>d__;
		<StartRhythmGame>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<StartRhythmGame>d__.<>4__this = this;
		<StartRhythmGame>d__.<>1__state = -1;
		<StartRhythmGame>d__.<>t__builder.Start<RhythmGameController.<StartRhythmGame>d__34>(ref <StartRhythmGame>d__);
		return <StartRhythmGame>d__.<>t__builder.Task;
	}

	// Token: 0x06006DC0 RID: 28096 RVA: 0x0016375C File Offset: 0x0016195C
	private UniTask LoadRhythmGameItemAsync()
	{
		RhythmGameController.<LoadRhythmGameItemAsync>d__35 <LoadRhythmGameItemAsync>d__;
		<LoadRhythmGameItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadRhythmGameItemAsync>d__.<>4__this = this;
		<LoadRhythmGameItemAsync>d__.<>1__state = -1;
		<LoadRhythmGameItemAsync>d__.<>t__builder.Start<RhythmGameController.<LoadRhythmGameItemAsync>d__35>(ref <LoadRhythmGameItemAsync>d__);
		return <LoadRhythmGameItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006DC1 RID: 28097 RVA: 0x001637A0 File Offset: 0x001619A0
	[NullableContext(0)]
	private UniTask<bool> LoadShipActorAsync()
	{
		RhythmGameController.<LoadShipActorAsync>d__36 <LoadShipActorAsync>d__;
		<LoadShipActorAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadShipActorAsync>d__.<>4__this = this;
		<LoadShipActorAsync>d__.<>1__state = -1;
		<LoadShipActorAsync>d__.<>t__builder.Start<RhythmGameController.<LoadShipActorAsync>d__36>(ref <LoadShipActorAsync>d__);
		return <LoadShipActorAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006DC2 RID: 28098 RVA: 0x001637E4 File Offset: 0x001619E4
	[NullableContext(0)]
	private UniTask<bool> LoadRhythmGameConfigAsync()
	{
		RhythmGameController.<LoadRhythmGameConfigAsync>d__37 <LoadRhythmGameConfigAsync>d__;
		<LoadRhythmGameConfigAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadRhythmGameConfigAsync>d__.<>1__state = -1;
		<LoadRhythmGameConfigAsync>d__.<>t__builder.Start<RhythmGameController.<LoadRhythmGameConfigAsync>d__37>(ref <LoadRhythmGameConfigAsync>d__);
		return <LoadRhythmGameConfigAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006DC3 RID: 28099 RVA: 0x00163820 File Offset: 0x00161A20
	private void StartRhythmGameInternal(int roleId)
	{
		Log.Instance.Info(ELogModule.RhythmGame, ELogAuthor.CH, "----[StartRhythmGameInternal]----", default(ReadOnlySpan<ValueTuple<string, object>>));
		Log.Instance.Info(ELogModule.RhythmGame, ELogAuthor.CH, "----InitTimerSystem----", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.InitTimerSystem();
		Log.Instance.Info(ELogModule.RhythmGame, ELogAuthor.CH, "----InitializeRhythmGameShipController----", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.ShipActor != null)
		{
			RhythmGameShipController.Instance.Initialize(this.ShipActor);
		}
		Log.Instance.Info(ELogModule.RhythmGame, ELogAuthor.CH, "----FindSplineEntity----", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.SplineActor = (ActorSystem.Instance.Get(TsGameSplineActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as TsGameSplineActor);
		this.SplineComp = GameSplineUtils.InitGameSplineBySplineEntity(229800000, this.SplineActor);
		RhythmGameModel.Instance.CurSplineComponent = this.SplineComp;
		global::Vector splineLocation = RhythmGameModel.Instance.SplineLocation;
		FVectorDouble fvectorDouble = this.SplineActor.D_K2_GetActorLocation();
		splineLocation.FromUeVector(fvectorDouble);
		Log.Instance.Info(ELogModule.RhythmGame, ELogAuthor.CH, "----FindRhythmGameManagerActor----", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.RhythmGameManager = (UKuroRenderingRuntimeBPPluginBPLibrary.GetSubsystem(GlobalData.World, UKuroRhythmGameManager.StaticClass()) as UKuroRhythmGameManager);
		RhythmGameModel.Instance.RhythmGameConfig.Config.GlobalTimeOffset += (float)(RhythmShipModel.Instance.LocalCalibrationValue / 1000);
		Log.Instance.Info(ELogModule.RhythmGame, ELogAuthor.CH, "----StartRhythmGame----", default(ReadOnlySpan<ValueTuple<string, object>>));
		TArray<FKuroRhythmSkillEffectParam> rhythmGameSkillEffectParam = RhythmGameUtil.GetRhythmGameSkillEffectParam(roleId);
		UKuroRhythmGameManager rhythmGameManager = this.RhythmGameManager;
		if (rhythmGameManager != null)
		{
			FKuroRhythmGameConfig config = RhythmGameModel.Instance.RhythmGameConfig.Config;
			rhythmGameManager.InitializeGame(config, ref rhythmGameSkillEffectParam, this.ShipActor, this.SplineComp);
		}
		RhythmGameModel.Instance.ForceTargetActor = this.ShipActor;
		CameraController.Instance.MainModel.FightCamera.LogicComponent.EnterSpecialGameplayCamera(2);
		this.ChangedCamera = true;
		UKuroRhythmGameManager rhythmGameManager2 = this.RhythmGameManager;
		if (rhythmGameManager2 != null)
		{
			rhythmGameManager2.SetShipMovementSpeed(RhythmGameModel.Instance.GetCurrentSpeedLevelConfig().Speed);
		}
		Log.Instance.Info(ELogModule.RhythmGame, ELogAuthor.CH, "----LoadMusicGameConfig----", default(ReadOnlySpan<ValueTuple<string, object>>));
		RhythmSubLevel? config2 = ConfigRhythmSubLevelById.GetConfig(RhythmShipModel.Instance.RhythmShipSubLevelId, true);
		MusicGameData? config3 = ConfigMusicGameDataById.GetConfig((config2 != null) ? config2.GetValueOrDefault().JsonId : 10, true);
		this.GuideIds = (((config2 != null) ? config2.GetValueOrDefault().Guide() : null) ?? Array.Empty<int>());
		RhythmGamePerformanceCameraConfig startCameraConfig = RhythmGameModel.Instance.RhythmGameConfig.StartCameraConfig;
		EventSystem.Instance.Emit<RhythmGamePerformanceCameraConfig>(EEventName.OnRhythmGameStartPhase, startCameraConfig);
		this.TotalOffset = -((config3 != null) ? config3.GetValueOrDefault().BgmOffset : 0f) + startCameraConfig.Time;
		this.RhythmGameManager.NoteEventTimeOffset = startCameraConfig.Time;
		FKuroRhythmChartData rhythmGameData = new FKuroRhythmChartData();
		UKuroRhythmGameManager rhythmGameManager3 = this.RhythmGameManager;
		if (rhythmGameManager3 != null)
		{
			rhythmGameManager3.ParseChartDataFromJson(((config3 != null) ? config3.GetValueOrDefault().Data : null) ?? "", ref rhythmGameData);
		}
		this.RhythmGameData = rhythmGameData;
		Log.Instance.Info(ELogModule.RhythmGame, ELogAuthor.CH, "----StartRhythmGame End----", default(ReadOnlySpan<ValueTuple<string, object>>));
		Log.Instance.Info(ELogModule.RhythmGame, ELogAuthor.CH, "----AddGameEvent----", default(ReadOnlySpan<ValueTuple<string, object>>));
		UKuroRhythmGameManager rhythmGameManager4 = this.RhythmGameManager;
		if (rhythmGameManager4 != null)
		{
			rhythmGameManager4.OnNoteResult.Add(new Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat>(this.OnNoteResult));
		}
		UKuroRhythmGameManager rhythmGameManager5 = this.RhythmGameManager;
		if (rhythmGameManager5 != null)
		{
			rhythmGameManager5.OnAllNotesFinished.Add(new Action(this.AllNotesFinished));
		}
		UKuroRhythmGameManager rhythmGameManager6 = this.RhythmGameManager;
		if (rhythmGameManager6 != null)
		{
			rhythmGameManager6.OnFeverStateChanged.Add(new Action<bool>(this.OnFeverStateChanged));
		}
		UKuroRhythmGameManager rhythmGameManager7 = this.RhythmGameManager;
		if (rhythmGameManager7 != null)
		{
			rhythmGameManager7.OnHiddenScoreLevelChanged.Add(new Action<int, int>(this.OnHiddenScoreLevelChanged));
		}
		UKuroRhythmGameManager rhythmGameManager8 = this.RhythmGameManager;
		if (rhythmGameManager8 != null)
		{
			rhythmGameManager8.OnFeverScoreChanged.Add(new Action<int, int>(this.OnFeverScoreChanged));
		}
		UKuroRhythmGameManager rhythmGameManager9 = this.RhythmGameManager;
		if (rhythmGameManager9 != null)
		{
			rhythmGameManager9.OnJumpEvent.Add(new Action<float>(this.OnJumpEvent));
		}
		UKuroRhythmGameManager rhythmGameManager10 = this.RhythmGameManager;
		if (rhythmGameManager10 != null)
		{
			rhythmGameManager10.OnTrackSwitched.Add(new Action<int, int>(this.OnTrackSwitched));
		}
		UKuroRhythmGameManager rhythmGameManager11 = this.RhythmGameManager;
		if (rhythmGameManager11 != null)
		{
			rhythmGameManager11.OnHoldScoreUpdated.Add(new Action<int, int>(this.OnHoldScoreUpdated));
		}
		UKuroRhythmGameManager rhythmGameManager12 = this.RhythmGameManager;
		if (rhythmGameManager12 != null)
		{
			rhythmGameManager12.OnGameEvent.Add(new Action<EKuroRhythmChartEventType>(this.OnGameEvent));
		}
		UKuroRhythmGameManager rhythmGameManager13 = this.RhythmGameManager;
		if (rhythmGameManager13 != null)
		{
			UKuroRhythmGameJudgement judgementSystem = rhythmGameManager13.JudgementSystem;
			if (judgementSystem != null)
			{
				judgementSystem.OnTunnelFlickSwitch.Add(new Action<bool>(this.OnTunnelFlickSwitch));
			}
		}
		UKuroRhythmGameManager rhythmGameManager14 = this.RhythmGameManager;
		if (rhythmGameManager14 != null)
		{
			UKuroRhythmGameJudgement judgementSystem2 = rhythmGameManager14.JudgementSystem;
			if (judgementSystem2 != null)
			{
				judgementSystem2.OnLineHitTrigger.Add(new Action(this.OnLineHitTrigger));
			}
		}
		UKuroRhythmGameManager rhythmGameManager15 = this.RhythmGameManager;
		if (rhythmGameManager15 != null)
		{
			UKuroRhythmGameJudgement judgementSystem3 = rhythmGameManager15.JudgementSystem;
			if (judgementSystem3 != null)
			{
				judgementSystem3.OnAutoJudgeCountChange.Add(new Action<int>(this.OnAutoJudgeCountChange));
			}
		}
		UKuroRhythmGameManager rhythmGameManager16 = this.RhythmGameManager;
		if (rhythmGameManager16 != null)
		{
			UKuroRhythmGameJudgement judgementSystem4 = rhythmGameManager16.JudgementSystem;
			if (judgementSystem4 != null)
			{
				judgementSystem4.OnHoldNoteInputReleased.Add(new Action(this.OnHoldNoteStop));
			}
		}
		UKuroRhythmGameManager rhythmGameManager17 = this.RhythmGameManager;
		if (rhythmGameManager17 != null)
		{
			UKuroRhythmGameJudgement judgementSystem5 = rhythmGameManager17.JudgementSystem;
			if (judgementSystem5 != null)
			{
				judgementSystem5.OnHoldNoteTimeout.Add(new Action(this.OnHoldNoteStop));
			}
		}
		UKuroRhythmGameManager rhythmGameManager18 = this.RhythmGameManager;
		if (rhythmGameManager18 != null)
		{
			UKuroRhythmGameJudgement judgementSystem6 = rhythmGameManager18.JudgementSystem;
			if (judgementSystem6 != null)
			{
				judgementSystem6.OnHoldNoteTimeout.Add(new Action(this.OnHoldNoteTimeout));
			}
		}
		UKuroRhythmGameManager rhythmGameManager19 = this.RhythmGameManager;
		bool? flag;
		if (rhythmGameManager19 == null)
		{
			flag = null;
		}
		else
		{
			UKuroRhythmGameJudgement judgementSystem7 = rhythmGameManager19.JudgementSystem;
			flag = ((judgementSystem7 != null) ? new bool?(judgementSystem7.IsDisableRecordUpLoad()) : null);
		}
		bool? flag2 = flag;
		this.IsDisableRecordUpLoad = flag2.GetValueOrDefault();
		this.SpawnStartEffect();
		this.RhythmGameManagerTickId = TickSystem.Instance.Add(new Action<float>(this.RhythmGameManagerTick), "RhythmGameManager", ETickingGroup.TG_PrePhysics, true, 0, false).Id;
		int remainUpgradeRatingCount = this.RhythmGameManager.JudgementSystem.GetRemainUpgradeRatingCount();
		UiManager.Instance.OpenView(EUiViewName.RhythmShipGameView, new RhythmShipGameViewOpenParam
		{
			RoleId = roleId,
			AutoJudgeCount = remainUpgradeRatingCount
		}, null);
		this.LoadMusicAndPause();
		AudioSystem.Instance.PostEvent("play_ui_rhythmship_gameship_start");
		this.PlayStartingCameraAnim();
	}

	// Token: 0x06006DC4 RID: 28100 RVA: 0x00163EBA File Offset: 0x001620BA
	private void InitTimerSystem()
	{
		if (this.RhythmGameTimerSystem != null)
		{
			this.RhythmGameTimerSystem.Clear();
		}
		this.RhythmGameTimerSystem = new TimerSystemInstance();
	}

	// Token: 0x06006DC5 RID: 28101 RVA: 0x00163EDA File Offset: 0x001620DA
	private void ClearTimerSystem()
	{
		if (this.RhythmGameTimerSystem != null)
		{
			this.RhythmGameTimerSystem.Clear();
			this.RhythmGameTimerSystem = null;
		}
	}

	// Token: 0x06006DC6 RID: 28102 RVA: 0x00163EF8 File Offset: 0x001620F8
	public unsafe void GetOffsetFromMusic()
	{
		if (!this.IsBeginPlayMusic || this.MusicEventHandle == 0 || this.IsPause)
		{
			return;
		}
		float num = this.CurrentPlayedTime() * 1000f;
		int? sourcePlayPositionWithExtrapolation = AudioSystem.Instance.GetSourcePlayPositionWithExtrapolation(this.MusicEventHandle, true);
		if (sourcePlayPositionWithExtrapolation == null)
		{
			Log.Instance.Warn(ELogModule.RhythmGame, ELogAuthor.CH, "audioTime is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		float num2 = (float)sourcePlayPositionWithExtrapolation.Value - num;
		if (Math.Abs(num2) > 500f)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RhythmGame;
			ELogAuthor author = ELogAuthor.CH;
			string message = "GetOffsetFromMusic Offset too large";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Offset", num2);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.CachedTimeOffset = 0f;
			this.IsAccumulatingTimeOffset = false;
			this.RhythmGameManager.GameplayTimeOffset += num2 / 1000f;
		}
		else
		{
			this.ApplyAudioTimeOffset(num2);
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.RhythmGame;
		ELogAuthor author2 = ELogAuthor.CH;
		string message2 = "MusicSyncBeat";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GameMusicTime", num);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("AudioTime", sourcePlayPositionWithExtrapolation.Value);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Offset", num2);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x06006DC7 RID: 28103 RVA: 0x00164065 File Offset: 0x00162265
	public UKuroRhythmGameShipController GetRhythmGameShipController()
	{
		UKuroRhythmGameManager rhythmGameManager = this.RhythmGameManager;
		if (rhythmGameManager == null)
		{
			return null;
		}
		return rhythmGameManager.ShipController;
	}

	// Token: 0x06006DC8 RID: 28104 RVA: 0x00164078 File Offset: 0x00162278
	public void OnPlayerInputDown(EKuroRhythmGameInputType type)
	{
		if (type == EKuroRhythmGameInputType.Line)
		{
			this.LineHoldKeyPressed = true;
		}
		if (!this.PlayerCanInput)
		{
			return;
		}
		UKuroRhythmGameManager rhythmGameManager = this.RhythmGameManager;
		if (rhythmGameManager == null)
		{
			return;
		}
		rhythmGameManager.OnPlayerInputDown(type);
	}

	// Token: 0x06006DC9 RID: 28105 RVA: 0x0016409F File Offset: 0x0016229F
	public void OnPlayerInputUp(EKuroRhythmGameInputType type)
	{
		if (type == EKuroRhythmGameInputType.Line)
		{
			this.LineHoldKeyPressed = false;
		}
		if (!this.PlayerCanInput)
		{
			return;
		}
		UKuroRhythmGameManager rhythmGameManager = this.RhythmGameManager;
		if (rhythmGameManager == null)
		{
			return;
		}
		rhythmGameManager.OnPlayerInputUp(type);
	}

	// Token: 0x06006DCA RID: 28106 RVA: 0x001640C8 File Offset: 0x001622C8
	private unsafe void OnGameEvent(EKuroRhythmChartEventType eventType)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RhythmGame;
		ELogAuthor author = ELogAuthor.CH;
		string message = "OnGameEvent";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("event", eventType);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		switch (eventType)
		{
		case EKuroRhythmChartEventType.Road:
		case EKuroRhythmChartEventType.Tunnel:
			RhythmGameShipController.Instance.SpawnLockIcon();
			EventSystem.Instance.Emit<bool>(EEventName.OnRhythmGameFreePhase, false);
			RhythmGameModel.Instance.OnRoadMode = (eventType == EKuroRhythmChartEventType.Road);
			break;
		case EKuroRhythmChartEventType.Jump:
			break;
		case EKuroRhythmChartEventType.Guide:
		{
			if (this.CurrentGuideId < this.GuideIds.Length)
			{
				GuideController instance2 = GuideController.Instance;
				int[] guideIds = this.GuideIds;
				int currentGuideId = this.CurrentGuideId;
				this.CurrentGuideId = currentGuideId + 1;
				instance2.TryStartGuide(guideIds[currentGuideId]);
				return;
			}
			Log instance3 = Log.Instance;
			ELogModule module2 = ELogModule.RhythmGame;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "OnGameEvent out of range";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GuideId length", this.GuideIds.Length);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentGuideId", this.CurrentGuideId);
			instance3.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		case EKuroRhythmChartEventType.KuroFreefly:
			RhythmGameShipController.Instance.StopLockIconEffect();
			EventSystem.Instance.Emit<bool>(EEventName.OnRhythmGameFreePhase, true);
			RhythmGameModel.Instance.OnRoadMode = false;
			return;
		default:
			return;
		}
	}

	// Token: 0x06006DCB RID: 28107 RVA: 0x00164214 File Offset: 0x00162414
	private void SpawnStartEffect()
	{
		RhythmGamePerformanceCameraConfig startCameraConfig = RhythmGameModel.Instance.RhythmGameConfig.StartCameraConfig;
		float distance = startCameraConfig.Time * RhythmGameModel.Instance.GetCurrentSpeedLevelConfig().Speed;
		FVectorDouble fvectorDouble = this.SplineComp.D_GetLocationAtDistanceAlongSpline(distance, ESplineCoordinateSpace.World);
		FTransformDouble value = new FTransformDouble();
		value.SetLocation(fvectorDouble);
		FQuat fquat = this.SplineComp.GetRotationAtDistanceAlongSpline(distance, ESplineCoordinateSpace.World).Quaternion();
		value.SetRotation(fquat);
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = new FTransformDouble?(value);
		this.StartEffectHandle = instance.SpawnEffect(world, ftransformDouble, "/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Start.DA_Fx_Group_Start", "[RhythmGameController] Spawn Start Effect", null, EEffectType.Scene, null, null, null, false, false);
		this.RhythmGameTimerSystem.Delay(delegate(float _)
		{
			RhythmGameShipController.Instance.SpawnStartTrailEffect();
			this.PlayerCanInput = true;
		}, startCameraConfig.Time * 1000f, null, null, true, 1f);
		this.RhythmGameTimerSystem.Delay(delegate(float _)
		{
			if (this.StartEffectHandle != -1)
			{
				EffectSystem.Instance.StopEffectById(this.StartEffectHandle, "[RhythmGameController] Stop Start Effect", false, null);
				this.StartEffectHandle = -1;
			}
		}, (startCameraConfig.Time + 2f) * 1000f, null, null, true, 1f);
	}

	// Token: 0x06006DCC RID: 28108 RVA: 0x00164318 File Offset: 0x00162518
	private void LoadMusicAndPause()
	{
		if (this.MusicEvent != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RhythmGame;
			ELogAuthor author = ELogAuthor.CH;
			string message = "PlayMusic";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("curLevelConfig.Music", this.MusicEvent);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.MusicEventHandle = AudioSystem.Instance.PostEvent(this.MusicEvent, null, new PostEventArgs?(new PostEventArgs
			{
				CallbackMask = new ECallbackMask?(ECallbackMask.MusicPlayStarted),
				CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo _)
				{
					if (callbackType == EAkCallbackType.MusicPlayStarted && !this.IsBeginPlayMusic)
					{
						AudioSystem.Instance.ExecuteAction(this.MusicEventHandle, EAudioActionType.Pause, new ExecuteActionArgs?(new ExecuteActionArgs
						{
							TransitionDuration = new int?(0)
						}));
						AudioSystem.Instance.SeekOnEvent(this.MusicEvent, 0, new SeekOnEventArgs?(new SeekOnEventArgs
						{
							Handle = new int?(this.MusicEventHandle)
						}));
					}
				}
			}));
		}
	}

	// Token: 0x06006DCD RID: 28109 RVA: 0x001643A5 File Offset: 0x001625A5
	private void PlayStartingCameraAnim()
	{
		UKuroRhythmGameManager rhythmGameManager = this.RhythmGameManager;
		if (rhythmGameManager != null)
		{
			rhythmGameManager.StartGame();
		}
		this.RhythmGameTimerSystem.Delay(delegate(float _)
		{
			AudioSystem.Instance.ExecuteAction(this.MusicEventHandle, EAudioActionType.Resume, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
			this.IsBeginPlayMusic = true;
		}, this.TotalOffset * 1000f, null, null, true, 1f);
	}

	// Token: 0x06006DCE RID: 28110 RVA: 0x001643E4 File Offset: 0x001625E4
	private void ClearCache()
	{
		if (this.SplineActor != null && this.SplineActor.IsValid())
		{
			ActorSystem.Instance.Put("RhythmGameController.ClearCacheSpline", this.SplineActor, null);
			this.SplineActor = null;
		}
		if (this.ShipActor != null && this.ShipActor.IsValid())
		{
			ActorSystem.Instance.Put("RhythmGameController.ClearCacheShip", this.ShipActor, null);
			this.ShipActor = null;
		}
		if (this.SplineComp != null && this.SplineComp.IsValid())
		{
			this.SplineComp = null;
		}
		if (this.RhythmGameManager != null && this.RhythmGameManager.IsValid())
		{
			this.RhythmGameManager.OnNoteResult.Remove(new Action<int, EKuroRhythmGameNoteType, EKuroRhythmGameRating, FVectorDouble, FQuat>(this.OnNoteResult));
			this.RhythmGameManager.OnAllNotesFinished.Remove(new Action(this.AllNotesFinished));
			this.RhythmGameManager.OnFeverStateChanged.Remove(new Action<bool>(this.OnFeverStateChanged));
			this.RhythmGameManager.OnHiddenScoreLevelChanged.Remove(new Action<int, int>(this.OnHiddenScoreLevelChanged));
			this.RhythmGameManager.OnFeverScoreChanged.Remove(new Action<int, int>(this.OnFeverScoreChanged));
			this.RhythmGameManager.OnJumpEvent.Remove(new Action<float>(this.OnJumpEvent));
			this.RhythmGameManager.OnTrackSwitched.Remove(new Action<int, int>(this.OnTrackSwitched));
			this.RhythmGameManager.OnHoldScoreUpdated.Remove(new Action<int, int>(this.OnHoldScoreUpdated));
			this.RhythmGameManager.OnGameEvent.Remove(new Action<EKuroRhythmChartEventType>(this.OnGameEvent));
			UKuroRhythmGameJudgement judgementSystem = this.RhythmGameManager.JudgementSystem;
			if (judgementSystem != null)
			{
				judgementSystem.OnTunnelFlickSwitch.Remove(new Action<bool>(this.OnTunnelFlickSwitch));
			}
			UKuroRhythmGameJudgement judgementSystem2 = this.RhythmGameManager.JudgementSystem;
			if (judgementSystem2 != null)
			{
				judgementSystem2.OnLineHitTrigger.Remove(new Action(this.OnLineHitTrigger));
			}
			UKuroRhythmGameJudgement judgementSystem3 = this.RhythmGameManager.JudgementSystem;
			if (judgementSystem3 != null)
			{
				judgementSystem3.OnAutoJudgeCountChange.Remove(new Action<int>(this.OnAutoJudgeCountChange));
			}
			UKuroRhythmGameJudgement judgementSystem4 = this.RhythmGameManager.JudgementSystem;
			if (judgementSystem4 != null)
			{
				judgementSystem4.OnHoldNoteInputReleased.Remove(new Action(this.OnHoldNoteStop));
			}
			UKuroRhythmGameJudgement judgementSystem5 = this.RhythmGameManager.JudgementSystem;
			if (judgementSystem5 != null)
			{
				judgementSystem5.OnHoldNoteTimeout.Remove(new Action(this.OnHoldNoteStop));
			}
			UKuroRhythmGameJudgement judgementSystem6 = this.RhythmGameManager.JudgementSystem;
			if (judgementSystem6 != null)
			{
				judgementSystem6.OnHoldNoteTimeout.Remove(new Action(this.OnHoldNoteTimeout));
			}
			this.RhythmGameManager.Cleanup();
			this.RhythmGameManager = null;
		}
		if (this.ChangedCamera)
		{
			CameraController.Instance.MainModel.FightCamera.LogicComponent.ExitSpecialGameplayCamera();
			this.ChangedCamera = false;
		}
		if (this.StartEffectHandle != -1)
		{
			EffectSystem.Instance.StopEffectById(this.StartEffectHandle, "[RhythmGameController] Stop Start Effect", false, null);
			this.StartEffectHandle = -1;
		}
		if (this.RhythmGameManagerTickId != -1)
		{
			TickSystem.Instance.Remove(this.RhythmGameManagerTickId);
			this.RhythmGameManagerTickId = -1;
		}
		RhythmGameShipController.Instance.Release();
		this.IsBeginPlayMusic = false;
		RhythmGameModel.Instance.CurSpeedLevelConfigIndex = 0;
		this.ClearTimerSystem();
		this.StopRoleFeverAudio();
		this.IsPause = false;
		this.GuideIds = Array.Empty<int>();
		this.CurrentGuideId = 0;
		this.IsAccumulatingTimeOffset = false;
		this.CachedTimeOffset = 0f;
	}

	// Token: 0x06006DCF RID: 28111 RVA: 0x00164754 File Offset: 0x00162954
	private void RhythmGameManagerTick(float deltaTime)
	{
		if (this.IsPause)
		{
			return;
		}
		this.GetOffsetFromMusic();
		if (this.IsAccumulatingTimeOffset && this.CachedTimeOffset != 0f)
		{
			UKuroRhythmGameManager rhythmGameManager = this.RhythmGameManager;
			if (rhythmGameManager != null && rhythmGameManager.IsValid())
			{
				float num = Math.Min(Math.Abs(this.CachedTimeOffset), this.TimeOffsetApplySpeed * deltaTime / 1000f) * (float)Math.Sign(this.CachedTimeOffset);
				this.RhythmGameManager.GameplayTimeOffset += num;
				this.CachedTimeOffset -= num;
				if (Math.Abs(this.CachedTimeOffset) < 0.0001f)
				{
					this.CachedTimeOffset = 0f;
					this.IsAccumulatingTimeOffset = false;
				}
			}
		}
		UKuroRhythmGameManager rhythmGameManager2 = this.RhythmGameManager;
		if (rhythmGameManager2 != null && rhythmGameManager2.IsValid())
		{
			this.RhythmGameManager.Tick(deltaTime);
		}
		if (this.RhythmGameTimerSystem != null)
		{
			this.RhythmGameTimerSystem.Tick((double)deltaTime);
		}
	}

	// Token: 0x06006DD0 RID: 28112 RVA: 0x00164848 File Offset: 0x00162A48
	private unsafe void OnNoteResult(int noteIndex, EKuroRhythmGameNoteType noteType, EKuroRhythmGameRating result, FVectorDouble worldPosition, FQuat rotation)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RhythmGame;
		ELogAuthor author = ELogAuthor.CH;
		string message = "OnNoteResult: ";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("noteIndex", noteIndex);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("noteType", noteType);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("result", result);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		EventSystem instance2 = EventSystem.Instance;
		EEventName name = EEventName.OnRhythmGameNoteResultUpdate;
		EKuroRhythmGameRating? p = new EKuroRhythmGameRating?(result);
		UKuroRhythmGameManager rhythmGameManager = this.RhythmGameManager;
		instance2.Emit<EKuroRhythmGameRating?, FKuroRhythmGameStatistics>(name, p, (rhythmGameManager != null) ? rhythmGameManager.Statistics : null);
		if (result != EKuroRhythmGameRating.Miss)
		{
			this.PlayHitResultEffect(noteType, new FVectorDouble?(worldPosition), new FQuat?(rotation));
			if (noteType == EKuroRhythmGameNoteType.KuroTapLeft || noteType == EKuroRhythmGameNoteType.KuroTapRight)
			{
				RhythmGameShipController.Instance.TriggerTunnelTranslationAnim(noteType == EKuroRhythmGameNoteType.KuroTapLeft);
			}
			RhythmGameShipController.Instance.TriggerHitLockEffect();
			this.PlayHitAudioEvent(noteType);
		}
	}

	// Token: 0x06006DD1 RID: 28113 RVA: 0x0016493C File Offset: 0x00162B3C
	private void PlayHitAudioEvent(EKuroRhythmGameNoteType noteType)
	{
		double hitTime = Time.Instance.Now;
		Action<EAkCallbackType, UAkCallbackInfo> <>9__1;
		Func<string, int> func = delegate(string eventName)
		{
			AudioSystem instance = AudioSystem.Instance;
			AActor target = null;
			PostEventArgs value = default(PostEventArgs);
			value.CallbackMask = new ECallbackMask?(ECallbackMask.Duration);
			Action<EAkCallbackType, UAkCallbackInfo> callbackHandler;
			if ((callbackHandler = <>9__1) == null)
			{
				callbackHandler = (<>9__1 = delegate(EAkCallbackType callbackType, UAkCallbackInfo _)
				{
					if (callbackType == EAkCallbackType.Duration)
					{
						double now = Time.Instance.Now;
						double hitTime = hitTime;
					}
				});
			}
			value.CallbackHandler = callbackHandler;
			return instance.PostEvent(eventName, target, new PostEventArgs?(value));
		};
		switch (noteType)
		{
		case EKuroRhythmGameNoteType.Kuro3DFlickLeft:
		case EKuroRhythmGameNoteType.Kuro3DFlickRight:
			func("play_ui_rhythmship_gamenote_spin");
			return;
		case EKuroRhythmGameNoteType.KuroLine:
			func("play_ui_rhythmship_gamenote_line");
			return;
		case EKuroRhythmGameNoteType.KuroLineHold:
			if (this.HoldNoteEventHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.HoldNoteEventHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(0)
				}));
			}
			this.HoldNoteEventHandle = func("play_ui_rhythmship_gamenote_line_loop");
			return;
		case EKuroRhythmGameNoteType.KuroLineHit:
			func("play_ui_rhythmship_gamenote_air");
			return;
		default:
			func("play_ui_rhythmship_gamenote_normal");
			return;
		}
	}

	// Token: 0x06006DD2 RID: 28114 RVA: 0x00164A04 File Offset: 0x00162C04
	private void OnHoldNoteStop()
	{
		if (this.HoldNoteEventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.HoldNoteEventHandle, EAudioActionType.Stop, null);
			this.HoldNoteEventHandle = 0;
		}
	}

	// Token: 0x06006DD3 RID: 28115 RVA: 0x00164A3A File Offset: 0x00162C3A
	private void OnHoldNoteTimeout()
	{
		AudioSystem.Instance.PostEvent("play_ui_rhythmship_gamenote_line");
	}

	// Token: 0x06006DD4 RID: 28116 RVA: 0x00164A4C File Offset: 0x00162C4C
	private void OnFeverStateChanged(bool bFeverActive)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RhythmGame;
		ELogAuthor author = ELogAuthor.CH;
		string message = "OnFeverStateChanged";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bFeverActive", bFeverActive);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		EventSystem.Instance.Emit<bool>(EEventName.OnRhythmGameFeverModeChanged, bFeverActive);
		if (bFeverActive)
		{
			if (this.FeverLoopEventHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.FeverLoopEventHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(0)
				}));
			}
			this.FeverLoopEventHandle = AudioSystem.Instance.PostEvent("play_ui_rhythmship_gamefever_start_loop");
			this.FeverTimes++;
			return;
		}
		if (this.FeverLoopEventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.FeverLoopEventHandle, EAudioActionType.Stop, null);
		}
		AudioSystem.Instance.PostEvent("play_ui_rhythmship_gamefever_end");
	}

	// Token: 0x06006DD5 RID: 28117 RVA: 0x00164B28 File Offset: 0x00162D28
	private unsafe void OnHiddenScoreLevelChanged(int newLevel, int oldLevel)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RhythmGame;
		ELogAuthor author = ELogAuthor.CH;
		string message = "OnHiddenScoreLevelChanged: ";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("newLevel", newLevel - 1);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("oldLevel", oldLevel - 1);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		RhythmGameModel.Instance.CurSpeedLevelConfigIndex = newLevel - 1;
		if (newLevel > oldLevel)
		{
			AudioSystem.Instance.PostEvent("play_ui_rhythmship_gamespeedlevel_up");
			return;
		}
		AudioSystem.Instance.PostEvent("play_ui_rhythmship_gamespeedlevel_down");
	}

	// Token: 0x06006DD6 RID: 28118 RVA: 0x00164BCC File Offset: 0x00162DCC
	private unsafe void OnFeverScoreChanged(int newScore, int oldScore)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RhythmGame;
		ELogAuthor author = ELogAuthor.CH;
		string message = "OnFeverScoreChanged: ";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("newScore", newScore);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("oldScore", oldScore);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		EventSystem.Instance.Emit<int, int>(EEventName.OnRhythmGameFeverScoreChanged, newScore, oldScore);
	}

	// Token: 0x06006DD7 RID: 28119 RVA: 0x00164C4C File Offset: 0x00162E4C
	private void AllNotesFinished()
	{
		RhythmGamePerformanceCameraConfig endCameraConfig = RhythmGameModel.Instance.RhythmGameConfig.EndCameraConfig;
		EventSystem.Instance.Emit<RhythmGamePerformanceCameraConfig>(EEventName.OnRhythmGameEndPhase, endCameraConfig);
		this.IsBeginPlayMusic = false;
		this.RhythmGameTimerSystem.Delay(delegate(float _)
		{
			this.PlayerCanInput = false;
		}, 300f, null, null, true, 1f);
		if (endCameraConfig.Time > 0.02f)
		{
			this.RhythmGameTimerSystem.Delay(delegate(float _)
			{
				this.OnStopRhythmGame(false);
			}, endCameraConfig.Time * 1000f, null, null, true, 1f);
			return;
		}
		this.OnStopRhythmGame(false);
	}

	// Token: 0x06006DD8 RID: 28120 RVA: 0x00164CE8 File Offset: 0x00162EE8
	public void OnStopRhythmGame(bool isQuit = false)
	{
		Log.Instance.Info(ELogModule.RhythmGame, ELogAuthor.CH, "OnAllNotesFinished", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.FeverLoopEventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.FeverLoopEventHandle, EAudioActionType.Stop, null);
		}
		RhythmResultPayload payload = RhythmResultPayload.Create();
		UKuroRhythmGameManager rhythmGameManager = this.RhythmGameManager;
		FKuroRhythmGameStatistics fkuroRhythmGameStatistics = (rhythmGameManager != null) ? rhythmGameManager.Statistics : null;
		payload.Score = ((fkuroRhythmGameStatistics != null) ? fkuroRhythmGameStatistics.TotalScore : 0);
		int num = (fkuroRhythmGameStatistics != null) ? fkuroRhythmGameStatistics.PerfectCount : 0;
		int num2 = (fkuroRhythmGameStatistics != null) ? fkuroRhythmGameStatistics.GreatCount : 0;
		int num3 = (fkuroRhythmGameStatistics != null) ? fkuroRhythmGameStatistics.GoodCount : 0;
		int num4 = (fkuroRhythmGameStatistics != null) ? fkuroRhythmGameStatistics.BadCount : 0;
		int num5 = (fkuroRhythmGameStatistics != null) ? fkuroRhythmGameStatistics.MissCount : 0;
		foreach (int item in new int[]
		{
			num,
			num2,
			num3,
			num4,
			num5
		})
		{
			payload.JudgementCount.Add(item);
		}
		payload.MaxCombo = ((fkuroRhythmGameStatistics != null) ? fkuroRhythmGameStatistics.MaxCombo : 0);
		payload.CostSecond = (int)this.CurrentPlayedTime();
		payload.FeverCount = this.FeverTimes;
		RhythmSubLevel? config = ConfigRhythmSubLevelById.GetConfig(RhythmShipModel.Instance.RhythmShipSubLevelId, true);
		int[] array2 = (config != null) ? config.GetValueOrDefault().GetRatingJudNewArray() : null;
		if (array2 == null || array2.Length == 0)
		{
			payload.Rank = RhythmShipRank.Sss;
		}
		else
		{
			int j = 0;
			bool flag = false;
			while (j < array2.Length)
			{
				if (payload.Score >= array2[j])
				{
					flag = true;
					break;
				}
				j++;
			}
			if (flag)
			{
				payload.Rank = j + RhythmShipRank.Sss;
			}
			else
			{
				payload.Rank = RhythmShipRank.B;
			}
		}
		int num6 = num + num2 + num3 + num4;
		FKuroRhythmChartData rhythmGameData = this.RhythmGameData;
		int? num7;
		if (rhythmGameData == null)
		{
			num7 = null;
		}
		else
		{
			TArray<FKuroRhythmGameNote> notes = rhythmGameData.Notes;
			num7 = ((notes != null) ? new int?(notes.Count) : null);
		}
		int? num8 = num7;
		int valueOrDefault = num8.GetValueOrDefault(1);
		int num9 = (int)Math.Round((double)((float)num6 / (float)valueOrDefault * 10000f));
		payload.Accuracy = (int)Math.Round((double)((float)num6 / (float)valueOrDefault * 10000f));
		payload.Completion = num9;
		Dictionary<ERhythmShipSettlementType, int> settlementItemMap = new Dictionary<ERhythmShipSettlementType, int>
		{
			{
				ERhythmShipSettlementType.Miss,
				num5
			},
			{
				ERhythmShipSettlementType.OK,
				num4
			},
			{
				ERhythmShipSettlementType.Good,
				num3
			},
			{
				ERhythmShipSettlementType.Great,
				num2
			},
			{
				ERhythmShipSettlementType.Perfect,
				num
			}
		};
		bool isFp = num == valueOrDefault;
		bool isFc = payload.MaxCombo == valueOrDefault;
		if (isQuit)
		{
			RhythmShipController.Instance.RhythmSettleRequest(RhythmShipModel.Instance.RhythmShipSubLevelId, RhythmSettleReasonPb.Quit, payload, settlementItemMap, this.IsDisableRecordUpLoad, isQuit);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.RhythmShipGameEndTipView, new RhythmShipGameEndTipViewOpenParam
		{
			Level = (int)payload.Rank,
			IsFp = isFp,
			IsFc = isFc,
			Accuracy = (float)num9 / 100f,
			Callback = delegate()
			{
				RhythmShipController.Instance.RhythmSettleRequest(RhythmShipModel.Instance.RhythmShipSubLevelId, RhythmSettleReasonPb.Complete, payload, settlementItemMap, this.IsDisableRecordUpLoad, false);
			}
		}, null);
	}

	// Token: 0x06006DD9 RID: 28121 RVA: 0x00165038 File Offset: 0x00163238
	private void OnTunnelFlickSwitch(bool bToLeft)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RhythmGame;
		ELogAuthor author = ELogAuthor.CH;
		string message = "OnTunnelFlickSwitch";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bToLeft", bToLeft);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		RhythmGameShipController.Instance.TriggerRollAnim(bToLeft);
	}

	// Token: 0x06006DDA RID: 28122 RVA: 0x00165080 File Offset: 0x00163280
	private void OnLineHitTrigger()
	{
		Log.Instance.Info(ELogModule.RhythmGame, ELogAuthor.CH, "OnLineHitTrigger", default(ReadOnlySpan<ValueTuple<string, object>>));
		RhythmGameShipController.Instance.TriggerLineHit();
	}

	// Token: 0x06006DDB RID: 28123 RVA: 0x001650B8 File Offset: 0x001632B8
	private void OnJumpEvent(float beatDurationMs)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RhythmGame;
		ELogAuthor author = ELogAuthor.CH;
		string message = "OnJumpEvent";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("beatDurationMs", beatDurationMs);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		RhythmGameShipController.Instance.TriggerJumpAnim();
	}

	// Token: 0x06006DDC RID: 28124 RVA: 0x00165100 File Offset: 0x00163300
	private unsafe void OnTrackSwitched(int newTrackIndex, int oldTrackIndex)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RhythmGame;
		ELogAuthor author = ELogAuthor.CH;
		string message = "OnTrackSwitched";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("newTrackIndex", newTrackIndex);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("oldTrackIndex", oldTrackIndex);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		RhythmGameShipController.Instance.TriggerTranslationAnim(newTrackIndex < oldTrackIndex);
	}

	// Token: 0x06006DDD RID: 28125 RVA: 0x0016517C File Offset: 0x0016337C
	private unsafe void OnHoldScoreUpdated(int newHoldScore, int oldHoldScore)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RhythmGame;
		ELogAuthor author = ELogAuthor.CH;
		string message = "OnHoldScoreUpdated";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("newHoldScore", newHoldScore);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("oldHoldScore", oldHoldScore);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		EventSystem instance2 = EventSystem.Instance;
		EEventName name = EEventName.OnRhythmGameNoteResultUpdate;
		EKuroRhythmGameRating? p = null;
		UKuroRhythmGameManager rhythmGameManager = this.RhythmGameManager;
		instance2.Emit<EKuroRhythmGameRating?, FKuroRhythmGameStatistics>(name, p, (rhythmGameManager != null) ? rhythmGameManager.Statistics : null);
	}

	// Token: 0x06006DDE RID: 28126 RVA: 0x00165214 File Offset: 0x00163414
	private unsafe void PlayHitResultEffect(EKuroRhythmGameNoteType noteType, FVectorDouble? worldPosition, FQuat? rotation)
	{
		IReadOnlyList<string> readOnlyList2;
		if (!RhythmGameModelDefine.RhythmGameHitResultEffect.ContainsKey(noteType))
		{
			IReadOnlyList<string> readOnlyList = new string[0];
			readOnlyList2 = readOnlyList;
		}
		else
		{
			readOnlyList2 = RhythmGameModelDefine.RhythmGameHitResultEffect[noteType];
		}
		IReadOnlyList<string> readOnlyList3 = readOnlyList2;
		if (!RhythmGameModel.Instance.OnRoadMode && noteType == EKuroRhythmGameNoteType.KuroLine)
		{
			readOnlyList3 = new string[]
			{
				"/Game/Aki/Effect/DataAsset/Niagara/Scene/3_2/3_2YinYou/DA_FX_Yinyou_Rectangle_Sparks_02.DA_FX_Yinyou_Rectangle_Sparks_02"
			};
		}
		string text = RhythmGameModelDefine.RhythmGameHitResultExternalEffect.ContainsKey(noteType) ? RhythmGameModelDefine.RhythmGameHitResultExternalEffect[noteType] : "";
		if (readOnlyList3.Count == 0 && StringUtils.IsBlank(text))
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RhythmGame;
		ELogAuthor author = ELogAuthor.CH;
		string message = "PlayHitResultEffect";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("worldPosition", worldPosition);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("rotation", rotation);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("effectPath", readOnlyList3);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		FTransformDouble value = new FTransformDouble();
		FVectorDouble fvectorDouble = worldPosition ?? new FVectorDouble();
		value.SetLocation(fvectorDouble);
		FQuat fquat = rotation ?? new FQuat();
		value.SetRotation(fquat);
		foreach (string text2 in readOnlyList3)
		{
			if (!StringUtils.IsBlank(text2))
			{
				EffectSystem instance2 = EffectSystem.Instance;
				UObject world = GlobalData.World;
				FTransformDouble? ftransformDouble = new FTransformDouble?(value);
				instance2.SpawnEffect(world, ftransformDouble, text2, "PlayHitResultEffect", null, EEffectType.Scene, null, null, null, false, false);
			}
		}
		if (!StringUtils.IsBlank(text))
		{
			EffectSystem instance3 = EffectSystem.Instance;
			UObject world2 = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(value);
			int id = instance3.SpawnEffect(world2, ftransformDouble, text, "PlayHitResultEffect", null, EEffectType.Scene, null, null, null, false, false);
			EffectSystem.Instance.GetEffectActor(id).K2_AttachToComponent(this.ShipActor.SkeletalMesh, null, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false);
		}
	}

	// Token: 0x06006DDF RID: 28127 RVA: 0x00165428 File Offset: 0x00163628
	private void OnAutoJudgeCountChange(int autoJudgeCount)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RhythmGame;
		ELogAuthor author = ELogAuthor.BB;
		string message = "OnAutoJudgeCountChange";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("autoJudgeCount", autoJudgeCount);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		EventSystem.Instance.Emit<int>(EEventName.OnRhythmGameAutoJudgeCountChanged, autoJudgeCount);
	}

	// Token: 0x06006DE0 RID: 28128 RVA: 0x00165475 File Offset: 0x00163675
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.RhythmShipPauseView || viewName == EUiViewName.GuideTutorialView || viewName == EUiViewName.GuideTutorialPopView)
		{
			this.PauseGame();
		}
	}

	// Token: 0x06006DE1 RID: 28129 RVA: 0x001654A4 File Offset: 0x001636A4
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.RhythmShipPauseView || viewName == EUiViewName.GuideTutorialView || viewName == EUiViewName.GuideTutorialPopView)
		{
			this.ResumeGame();
		}
	}

	// Token: 0x06006DE2 RID: 28130 RVA: 0x001654D3 File Offset: 0x001636D3
	public int GetCurrentBeatDurationMs()
	{
		return (int)Math.Round((double)(60f / this.RhythmGameManager.CurrentBPM * 1000f));
	}

	// Token: 0x06006DE3 RID: 28131 RVA: 0x001654F4 File Offset: 0x001636F4
	public void StopRhythmGame()
	{
		this.OnStopRhythmGame(false);
		if (this.MusicEventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.MusicEventHandle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
			this.MusicEventHandle = 0;
		}
	}

	// Token: 0x06006DE4 RID: 28132 RVA: 0x00165543 File Offset: 0x00163743
	public void SetShipSpeed(float speed)
	{
		UKuroRhythmGameManager rhythmGameManager = this.RhythmGameManager;
		if (rhythmGameManager == null)
		{
			return;
		}
		rhythmGameManager.SetShipMovementSpeed(speed);
	}

	// Token: 0x06006DE5 RID: 28133 RVA: 0x00165558 File Offset: 0x00163758
	public void PauseGame()
	{
		EventSystem.Instance.Emit(EEventName.OnRhythmGameEndCoolDown);
		this.IsPause = true;
		this.PlayerCanInput = false;
		this.LineHoldKeyPressed = false;
		UKuroRhythmGameManager rhythmGameManager = this.RhythmGameManager;
		if (rhythmGameManager != null)
		{
			rhythmGameManager.PauseGame();
		}
		this.PauseRoleFeverAudio();
		if (this.MusicEventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.MusicEventHandle, EAudioActionType.Pause, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
		}
		if (this.HoldNoteEventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.HoldNoteEventHandle, EAudioActionType.Pause, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
		}
		if (this.FeverLoopEventHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.FeverLoopEventHandle, EAudioActionType.Pause, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
		}
	}

	// Token: 0x06006DE6 RID: 28134 RVA: 0x0016563D File Offset: 0x0016383D
	public void ResumeGame()
	{
		EventSystem.Instance.Emit<TTimerAction>(EEventName.OnRhythmGameStartCoolDown, delegate(float _)
		{
			this.IsPause = false;
			this.PlayerCanInput = true;
			UKuroRhythmGameManager rhythmGameManager = this.RhythmGameManager;
			if (rhythmGameManager != null)
			{
				rhythmGameManager.ResumeGame();
			}
			this.ResumeRoleFeverAudio();
			if (this.MusicEventHandle != 0)
			{
				AudioSystem.Instance.SeekOnEvent(this.MusicEvent, (int)(this.CurrentPlayedTime() * 1000f), new SeekOnEventArgs?(new SeekOnEventArgs
				{
					Handle = new int?(this.MusicEventHandle)
				}));
				AudioSystem.Instance.ExecuteAction(this.MusicEventHandle, EAudioActionType.Resume, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(0)
				}));
			}
			if (this.HoldNoteEventHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.HoldNoteEventHandle, EAudioActionType.Resume, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(0)
				}));
			}
			if (this.FeverLoopEventHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.FeverLoopEventHandle, EAudioActionType.Resume, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(0)
				}));
			}
			if (!this.LineHoldKeyPressed)
			{
				UKuroRhythmGameManager rhythmGameManager2 = this.RhythmGameManager;
				if (rhythmGameManager2 != null && rhythmGameManager2.bLineKeyPressed)
				{
					UKuroRhythmGameManager rhythmGameManager3 = this.RhythmGameManager;
					if (rhythmGameManager3 == null)
					{
						return;
					}
					rhythmGameManager3.OnPlayerInputUp(EKuroRhythmGameInputType.Line);
				}
			}
		});
	}

	// Token: 0x06006DE7 RID: 28135 RVA: 0x0016565C File Offset: 0x0016385C
	public float CurrentPlayedTime()
	{
		UKuroRhythmGameManager rhythmGameManager = this.RhythmGameManager;
		float num = (rhythmGameManager != null) ? rhythmGameManager.GetGameplayTime() : 0f;
		if (num < this.TotalOffset)
		{
			return 0f;
		}
		return num - this.TotalOffset;
	}

	// Token: 0x06006DE8 RID: 28136 RVA: 0x00165697 File Offset: 0x00163897
	public void ApplyAudioTimeOffset(float offset)
	{
		this.CachedTimeOffset = offset / 1000f;
		this.IsAccumulatingTimeOffset = true;
	}

	// Token: 0x06006DE9 RID: 28137 RVA: 0x001656AD File Offset: 0x001638AD
	public TsGameSplineActor GetSplineActor()
	{
		return this.SplineActor;
	}

	// Token: 0x06006DEA RID: 28138 RVA: 0x001656B8 File Offset: 0x001638B8
	public void SetRhythmGameStatistics(int score, int accuracy, int perfectCount, int greatCount, int goodCount, int badCount, int missCount, int maxCombo)
	{
		UKuroRhythmGameManager rhythmGameManager = this.RhythmGameManager;
		FKuroRhythmGameStatistics fkuroRhythmGameStatistics = (rhythmGameManager != null) ? rhythmGameManager.Statistics : null;
		if (fkuroRhythmGameStatistics != null)
		{
			fkuroRhythmGameStatistics.TotalScore = score;
			fkuroRhythmGameStatistics.Accuracy = (float)accuracy;
			fkuroRhythmGameStatistics.PerfectCount = perfectCount;
			fkuroRhythmGameStatistics.GreatCount = greatCount;
			fkuroRhythmGameStatistics.GoodCount = goodCount;
			fkuroRhythmGameStatistics.BadCount = badCount;
			fkuroRhythmGameStatistics.MissCount = missCount;
			fkuroRhythmGameStatistics.MaxCombo = maxCombo;
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnRhythmGameNoteResultUpdate;
			EKuroRhythmGameRating? p = null;
			UKuroRhythmGameManager rhythmGameManager2 = this.RhythmGameManager;
			instance.Emit<EKuroRhythmGameRating?, FKuroRhythmGameStatistics>(name, p, (rhythmGameManager2 != null) ? rhythmGameManager2.Statistics : null);
		}
	}

	// Token: 0x06006DEB RID: 28139 RVA: 0x0016574C File Offset: 0x0016394C
	[NullableContext(1)]
	public void PlayRoleFeverAudio(string musicEvent)
	{
		this.StopRoleFeverAudio();
		int handleId = -1;
		handleId = AudioSystem.Instance.PostEvent(musicEvent, null, new PostEventArgs?(new PostEventArgs
		{
			CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
			CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo _)
			{
				if (callbackType == EAkCallbackType.EndOfEvent && this.RoleFeverAudioHandle == handleId)
				{
					this.StopRoleFeverAudio();
				}
			}
		}));
		this.RoleFeverAudioHandle = handleId;
	}

	// Token: 0x06006DEC RID: 28140 RVA: 0x001657C0 File Offset: 0x001639C0
	private void StopRoleFeverAudio()
	{
		if (this.RoleFeverAudioHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.RoleFeverAudioHandle, EAudioActionType.Stop, null);
			this.RoleFeverAudioHandle = 0;
		}
	}

	// Token: 0x06006DED RID: 28141 RVA: 0x001657F8 File Offset: 0x001639F8
	private void PauseRoleFeverAudio()
	{
		if (this.RoleFeverAudioHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.RoleFeverAudioHandle, EAudioActionType.Pause, null);
		}
	}

	// Token: 0x06006DEE RID: 28142 RVA: 0x00165828 File Offset: 0x00163A28
	private void ResumeRoleFeverAudio()
	{
		if (this.RoleFeverAudioHandle != 0)
		{
			AudioSystem.Instance.ExecuteAction(this.RoleFeverAudioHandle, EAudioActionType.Resume, null);
		}
	}

	// Token: 0x06006DEF RID: 28143 RVA: 0x00165857 File Offset: 0x00163A57
	public bool GetIsPause()
	{
		return this.IsPause;
	}

	// Token: 0x17000920 RID: 2336
	// (get) Token: 0x06006DF0 RID: 28144 RVA: 0x0016585F File Offset: 0x00163A5F
	[Nullable(1)]
	public static RhythmGameController Instance
	{
		[NullableContext(1)]
		get
		{
			return RhythmGameController._Instance;
		}
	}

	// Token: 0x06006DF1 RID: 28145 RVA: 0x00165866 File Offset: 0x00163A66
	[NullableContext(1)]
	public static RhythmGameController GetOrCreateInstance()
	{
		if (RhythmGameController._Instance == null)
		{
			RhythmGameController.CreateInstance();
		}
		return RhythmGameController._Instance;
	}

	// Token: 0x06006DF2 RID: 28146 RVA: 0x0016587A File Offset: 0x00163A7A
	public static bool CreateInstance()
	{
		if (RhythmGameController._Instance != null)
		{
			return true;
		}
		RhythmGameController._Instance = new RhythmGameController();
		return true;
	}

	// Token: 0x06006DF3 RID: 28147 RVA: 0x00165890 File Offset: 0x00163A90
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006DF4 RID: 28148 RVA: 0x00165892 File Offset: 0x00163A92
	public static void ResetStaticDefaultValue()
	{
		RhythmGameController._Instance = null;
	}

	// Token: 0x06006DF5 RID: 28149 RVA: 0x0016589A File Offset: 0x00163A9A
	static RhythmGameController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RhythmGameController.CreateStaticDefaultValue), new Action(RhythmGameController.ResetStaticDefaultValue));
	}

	// Token: 0x040032AF RID: 12975
	private const int SplineEntityId = 229800000;

	// Token: 0x040032B0 RID: 12976
	[Nullable(1)]
	private const string RhythmGameConfigPath = "/Game/Aki/Data/Gameplay/RhythmGame/DefaultRhythmGameConfig.DefaultRhythmGameConfig";

	// Token: 0x040032B1 RID: 12977
	private const int LockInputAfterFinishTime = 300;

	// Token: 0x040032B2 RID: 12978
	private BP_Plane_C ShipActor;

	// Token: 0x040032B3 RID: 12979
	private TsGameSplineActor SplineActor;

	// Token: 0x040032B4 RID: 12980
	private USplineComponent SplineComp;

	// Token: 0x040032B5 RID: 12981
	private UKuroRhythmGameManager RhythmGameManager;

	// Token: 0x040032B6 RID: 12982
	private bool ChangedCamera;

	// Token: 0x040032B7 RID: 12983
	private int RhythmGameManagerTickId = -1;

	// Token: 0x040032B8 RID: 12984
	private FKuroRhythmChartData RhythmGameData;

	// Token: 0x040032B9 RID: 12985
	private string MusicEvent;

	// Token: 0x040032BA RID: 12986
	private int StartEffectHandle = -1;

	// Token: 0x040032BB RID: 12987
	private float TotalOffset;

	// Token: 0x040032BC RID: 12988
	private bool IsPause;

	// Token: 0x040032BD RID: 12989
	private bool IsDisableRecordUpLoad;

	// Token: 0x040032BE RID: 12990
	private bool IsBeginPlayMusic;

	// Token: 0x040032BF RID: 12991
	[Nullable(1)]
	private int[] GuideIds = Array.Empty<int>();

	// Token: 0x040032C0 RID: 12992
	public bool PlayerCanInput;

	// Token: 0x040032C1 RID: 12993
	private bool LineHoldKeyPressed;

	// Token: 0x040032C2 RID: 12994
	private int MusicEventHandle;

	// Token: 0x040032C3 RID: 12995
	private int CurrentGuideId;

	// Token: 0x040032C4 RID: 12996
	private int HoldNoteEventHandle;

	// Token: 0x040032C5 RID: 12997
	private int FeverLoopEventHandle;

	// Token: 0x040032C6 RID: 12998
	private float CachedTimeOffset;

	// Token: 0x040032C7 RID: 12999
	private bool IsAccumulatingTimeOffset;

	// Token: 0x040032C8 RID: 13000
	private readonly float TimeOffsetApplySpeed = 0.3f;

	// Token: 0x040032C9 RID: 13001
	private int FeverTimes;

	// Token: 0x040032CA RID: 13002
	public TimerSystemInstance RhythmGameTimerSystem;

	// Token: 0x040032CB RID: 13003
	private int RoleFeverAudioHandle;

	// Token: 0x040032CC RID: 13004
	private bool IsEnterRhythmGame;

	// Token: 0x040032CD RID: 13005
	private static RhythmGameController _Instance;
}
