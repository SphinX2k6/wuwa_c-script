using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A10 RID: 10768
[NullableContext(1)]
[Nullable(0)]
public class SignalDecodeViewV2 : UiTickViewBase
{
	// Token: 0x06016577 RID: 91511 RVA: 0x005A7520 File Offset: 0x005A5720
	public SignalDecodeViewV2(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016578 RID: 91512 RVA: 0x005A758C File Offset: 0x005A578C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUISprite)),
			new ValueTuple<int, Type>(11, typeof(UUINiagara)),
			new ValueTuple<int, Type>(12, typeof(UUINiagara)),
			new ValueTuple<int, Type>(13, typeof(UUINiagara)),
			new ValueTuple<int, Type>(14, typeof(UUIText)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUINiagara)),
			new ValueTuple<int, Type>(17, typeof(UUINiagara))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnPauseBtnClick)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnHelpBtnClick))
		};
	}

	// Token: 0x06016579 RID: 91513 RVA: 0x005A7774 File Offset: 0x005A5974
	protected override UniTask OnBeforeStartAsync()
	{
		SignalDecodeViewV2.<OnBeforeStartAsync>d__39 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SignalDecodeViewV2.<OnBeforeStartAsync>d__39>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601657A RID: 91514 RVA: 0x005A77B8 File Offset: 0x005A59B8
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private UniTask<UNiagaraSystem> WaitLoadNiagaraSystem(string pathKey)
	{
		SignalDecodeViewV2.<WaitLoadNiagaraSystem>d__40 <WaitLoadNiagaraSystem>d__;
		<WaitLoadNiagaraSystem>d__.<>t__builder = AsyncUniTaskMethodBuilder<UNiagaraSystem>.Create();
		<WaitLoadNiagaraSystem>d__.<>4__this = this;
		<WaitLoadNiagaraSystem>d__.pathKey = pathKey;
		<WaitLoadNiagaraSystem>d__.<>1__state = -1;
		<WaitLoadNiagaraSystem>d__.<>t__builder.Start<SignalDecodeViewV2.<WaitLoadNiagaraSystem>d__40>(ref <WaitLoadNiagaraSystem>d__);
		return <WaitLoadNiagaraSystem>d__.<>t__builder.Task;
	}

	// Token: 0x0601657B RID: 91515 RVA: 0x005A7803 File Offset: 0x005A5A03
	protected override void OnBeforeShow()
	{
		UUIButtonComponent button = base.GetButton(6);
		button.OnPointDownCallBack.Bind(new Action(this.OnCatchBtnDown));
		button.OnPointUpCallBack.Bind(new Action(this.OnCatchBtnUp));
	}

	// Token: 0x0601657C RID: 91516 RVA: 0x005A7839 File Offset: 0x005A5A39
	protected override void OnAfterShow()
	{
		this.UpdateByStep(SignalDecodeViewV2.EGameplayStep.CountDown, false);
	}

	// Token: 0x0601657D RID: 91517 RVA: 0x005A7843 File Offset: 0x005A5A43
	protected override void OnBeforeDestroy()
	{
		this.StopAllAudio();
		this.SuccessLoopNiagara = null;
		this.SuccessBurstNiagara = null;
		this.FailLoopNiagara = null;
		this.FailBurstNiagara = null;
	}

	// Token: 0x0601657E RID: 91518 RVA: 0x005A7868 File Offset: 0x005A5A68
	private void StopAllAudio()
	{
		AudioController.Instance.StopEvent(this.CountDownPlayResult, true, null);
		AudioController.Instance.StopEvent(this.CountDownEndPlayResult, true, null);
		AudioController.Instance.StopEvent(this.BgNoisePlayResult, true, null);
		AudioController.Instance.StopEvent(this.BgStopNoisePlayResult, true, null);
		AudioController.Instance.StopEvent(this.CatchDownPlayResult, true, null);
		AudioController.Instance.StopEvent(this.CatchSuccessPlayResult, true, null);
		AudioController.Instance.StopEvent(this.CatchFailedPlayResult, true, null);
	}

	// Token: 0x0601657F RID: 91519 RVA: 0x005A792B File Offset: 0x005A5B2B
	private void DisableAllNiagara()
	{
		UUINiagara uiNiagara = base.GetUiNiagara(13);
		if (uiNiagara != null)
		{
			uiNiagara.SetNiagaraUIActive(false, false);
		}
		UUINiagara uiNiagara2 = base.GetUiNiagara(12);
		if (uiNiagara2 != null)
		{
			uiNiagara2.SetNiagaraUIActive(false, false);
		}
		UUINiagara uiNiagara3 = base.GetUiNiagara(11);
		if (uiNiagara3 == null)
		{
			return;
		}
		uiNiagara3.SetNiagaraUIActive(false, false);
	}

	// Token: 0x06016580 RID: 91520 RVA: 0x005A796C File Offset: 0x005A5B6C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnSignalCatchStart, new Action(this.OnSignalCatchStart));
		EventSystem.Instance.Add(EEventName.OnSignalCatchSuccess, new Action(this.OnSignalCatchSuccess));
		EventSystem.Instance.Add(EEventName.OnSignalCatchFailed, new Action(this.OnSignalCatchFailed));
		EventSystem.Instance.Add(EEventName.OnSignalCatchContinue, new Action(this.OnSignalCatchContinue));
		EventSystem.Instance.Add(EEventName.OnSignalCatchStartAgain, new Action(this.OnSignalCatchStartAgain));
	}

	// Token: 0x06016581 RID: 91521 RVA: 0x005A7A08 File Offset: 0x005A5C08
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSignalCatchStart, new Action(this.OnSignalCatchStart));
		EventSystem.Instance.Remove(EEventName.OnSignalCatchSuccess, new Action(this.OnSignalCatchSuccess));
		EventSystem.Instance.Remove(EEventName.OnSignalCatchFailed, new Action(this.OnSignalCatchFailed));
		EventSystem.Instance.Remove(EEventName.OnSignalCatchContinue, new Action(this.OnSignalCatchContinue));
		EventSystem.Instance.Remove(EEventName.OnSignalCatchStartAgain, new Action(this.OnSignalCatchStartAgain));
	}

	// Token: 0x06016582 RID: 91522 RVA: 0x005A7AA1 File Offset: 0x005A5CA1
	private void OnSignalCatchStart()
	{
		UUINiagara uiNiagara = base.GetUiNiagara(12);
		uiNiagara.SetNiagaraSystem(this.SuccessLoopNiagara);
		uiNiagara.SetNiagaraUIActive(true, false);
		uiNiagara.ActivateSystem(true);
	}

	// Token: 0x06016583 RID: 91523 RVA: 0x005A7AC8 File Offset: 0x005A5CC8
	private void OnSignalCatchSuccess()
	{
		this.DecisionSpriteToNormal();
		UUINiagara uiNiagara = base.GetUiNiagara(12);
		uiNiagara.SetNiagaraSystem(this.SuccessLoopNiagara);
		uiNiagara.SetNiagaraUIActive(false, false);
		uiNiagara.DeactivateSystem();
		UUINiagara uiNiagara2 = base.GetUiNiagara(11);
		uiNiagara2.SetNiagaraSystem(this.SuccessBurstNiagara);
		uiNiagara2.SetNiagaraUIActive(true, false);
		uiNiagara2.ActivateSystem(true);
		this.PlayAudio("SignalDecodeGame_release_correct", this.CatchSuccessPlayResult);
	}

	// Token: 0x06016584 RID: 91524 RVA: 0x005A7B30 File Offset: 0x005A5D30
	private void OnSignalCatchFailed()
	{
		this.DecisionSpriteToRed();
		this.LockChange = true;
		UUINiagara uiNiagara = base.GetUiNiagara(12);
		uiNiagara.SetNiagaraSystem(this.FailLoopNiagara);
		uiNiagara.SetNiagaraUIActive(false, false);
		uiNiagara.DeactivateSystem();
		UUINiagara uiNiagara2 = base.GetUiNiagara(11);
		uiNiagara2.SetNiagaraSystem(this.FailBurstNiagara);
		uiNiagara2.SetNiagaraUIActive(true, false);
		uiNiagara2.ActivateSystem(true);
		TimerSystem.Instance.Delay(delegate(float _)
		{
			this.LockChange = false;
			this.DecisionSpriteToNormal();
		}, 1000f, null, null, true, 1f);
		string name = "SignalDecodeGame_release_error";
		if (SignalDecodeModel.Instance.CurrentGameplayType == ESignalGameplayType.DrawSword)
		{
			name = "SignalDecodeGame_music_play_presserror";
		}
		this.PlayAudio(name, this.CatchFailedPlayResult);
	}

	// Token: 0x06016585 RID: 91525 RVA: 0x005A7BD7 File Offset: 0x005A5DD7
	private void OnSignalCatchContinue()
	{
		this.PausePanel.Hide(null);
		this.UpdateByStep(SignalDecodeViewV2.EGameplayStep.Gameplay, false);
	}

	// Token: 0x06016586 RID: 91526 RVA: 0x005A7BED File Offset: 0x005A5DED
	private void OnSignalCatchStartAgain()
	{
		this.PausePanel.Hide(null);
		this.MovePanel.StartAgain();
		this.UpdateByStep(SignalDecodeViewV2.EGameplayStep.Gameplay, true);
	}

	// Token: 0x06016587 RID: 91527 RVA: 0x005A7C0E File Offset: 0x005A5E0E
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Counter")
		{
			this.UpdateByStep(SignalDecodeViewV2.EGameplayStep.Gameplay, true);
		}
	}

	// Token: 0x06016588 RID: 91528 RVA: 0x005A7C28 File Offset: 0x005A5E28
	private void SequenceEvent(string sequenceName, string eventName)
	{
		if (sequenceName != "Counter")
		{
			return;
		}
		UUIText text = base.GetText(2);
		if (eventName == "开始")
		{
			string textById = TextConfig.Instance.GetTextById("Start");
			text.SetText(textById, true);
			this.PlayAudio("SignalDecodeGame_count_down_End", this.CountDownEndPlayResult);
			return;
		}
		text.SetText(eventName, true);
		this.PlayAudio("SignalDecodeGame_count_down", this.CountDownPlayResult);
	}

	// Token: 0x06016589 RID: 91529 RVA: 0x005A7C9B File Offset: 0x005A5E9B
	protected override void OnTick(float delta)
	{
		if (this.CurrentStep == SignalDecodeViewV2.EGameplayStep.Gameplay)
		{
			this.UpdateGameplay(delta);
		}
	}

	// Token: 0x0601658A RID: 91530 RVA: 0x005A7CAD File Offset: 0x005A5EAD
	private void UpdateGameplay(float delta)
	{
		this.MovePanel.UpdateMove(delta);
		this.UpdateProgress();
	}

	// Token: 0x0601658B RID: 91531 RVA: 0x005A7CC4 File Offset: 0x005A5EC4
	private void UpdateProgress()
	{
		float num = this.MovePanel.GetCompleteness();
		num = (float)Math.Floor((double)(num * 100f));
		UUIText text = base.GetText(8);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>((int)num);
		defaultInterpolatedStringHandler.AppendLiteral("%");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		float progress = this.MovePanel.GetProgress();
		base.GetSprite(10).SetFillAmount(progress);
		if (progress >= 1f)
		{
			this.GameOver((int)num);
		}
	}

	// Token: 0x0601658C RID: 91532 RVA: 0x005A7D48 File Offset: 0x005A5F48
	private void GameOver(int completeness)
	{
		if (this.BlockFlag)
		{
			return;
		}
		this.BlockFlag = true;
		TimerSystem.Instance.Delay(delegate(float _)
		{
			SignalDecodeViewV2.EGameplayStep step = (completeness >= SignalDecodeModel.Instance.TargetCompletion) ? SignalDecodeViewV2.EGameplayStep.SuccessFinish : SignalDecodeViewV2.EGameplayStep.FailedFinish;
			this.UpdateByStep(step, false);
			this.BlockFlag = false;
		}, 1000f, null, null, true, 1f);
	}

	// Token: 0x0601658D RID: 91533 RVA: 0x005A7DA0 File Offset: 0x005A5FA0
	private void UpdateByStep(SignalDecodeViewV2.EGameplayStep step, bool reStart = false)
	{
		if (this.CurrentStep == step)
		{
			return;
		}
		switch (step)
		{
		case SignalDecodeViewV2.EGameplayStep.CountDown:
		{
			base.GetItem(1).SetUIActive(false);
			base.GetItem(0).SetUIActive(true);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText("3", true);
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Counter", false, null, false);
			}
			break;
		}
		case SignalDecodeViewV2.EGameplayStep.Gameplay:
		{
			this.DisableAllNiagara();
			base.GetItem(0).SetUIActive(false);
			base.GetItem(1).SetUIActive(true);
			if (reStart)
			{
				this.InitMoveNode();
			}
			string text2 = "SignalDecodeGame_play_base_noise";
			if (SignalDecodeModel.Instance.CurrentGameplayType == ESignalGameplayType.DrawSword)
			{
				text2 = (reStart ? "SignalDecodeGame_music_play_BGM" : "SignalDecodeGame_music_resume_BGM");
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "BGM事件";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("eventName", text2);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.PlayAudio(text2, this.BgNoisePlayResult);
			break;
		}
		case SignalDecodeViewV2.EGameplayStep.Pause:
		{
			this.StopAllAudio();
			base.GetItem(1).SetUIActive(false);
			this.PausePanel.Show(null);
			string text2 = "SignalDecodeGame_stop_base_noise";
			if (SignalDecodeModel.Instance.CurrentGameplayType == ESignalGameplayType.DrawSword)
			{
				text2 = "SignalDecodeGame_music_pause_BGM";
			}
			this.PlayAudio(text2, this.BgStopNoisePlayResult);
			break;
		}
		case SignalDecodeViewV2.EGameplayStep.SuccessFinish:
		{
			this.StopAllAudio();
			base.GetItem(1).SetUIActive(false);
			this.SuccessFinishPanel.Open();
			string text2 = "SignalDecodeGame_stop_base_noise";
			if (SignalDecodeModel.Instance.CurrentGameplayType == ESignalGameplayType.DrawSword)
			{
				text2 = "SignalDecodeGame_music_stop_BGM";
			}
			this.PlayAudio(text2, this.BgStopNoisePlayResult);
			break;
		}
		case SignalDecodeViewV2.EGameplayStep.FailedFinish:
		{
			this.StopAllAudio();
			base.GetItem(1).SetUIActive(false);
			this.FailedFinishPanel.Open();
			string text2 = "SignalDecodeGame_stop_base_noise";
			if (SignalDecodeModel.Instance.CurrentGameplayType == ESignalGameplayType.DrawSword)
			{
				text2 = "SignalDecodeGame_music_stop_BGM";
			}
			this.PlayAudio(text2, this.BgStopNoisePlayResult);
			break;
		}
		}
		this.CurrentStep = step;
	}

	// Token: 0x0601658E RID: 91534 RVA: 0x005A7F93 File Offset: 0x005A6193
	private void InitMoveNode()
	{
		this.MovePanel.InitMoveNode();
	}

	// Token: 0x0601658F RID: 91535 RVA: 0x005A7FA0 File Offset: 0x005A61A0
	private void PlayAudio(string name, PlayResult result)
	{
		Audio? audioPath = AudioConfig.Instance.GetAudioPath(name);
		if (audioPath == null || string.IsNullOrEmpty(audioPath.Value.Path))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "获取Audio配表信息错误！请检查Audio的配置是否存在！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", name);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		AudioController.Instance.PostEventByUi(audioPath.Value.Path, result, null, null);
	}

	// Token: 0x06016590 RID: 91536 RVA: 0x005A8024 File Offset: 0x005A6224
	private void OnCatchBtnDown()
	{
		this.MovePanel.OnCatchBtnDown();
		UUINiagara uiNiagara = base.GetUiNiagara(13);
		if (uiNiagara != null)
		{
			uiNiagara.SetNiagaraUIActive(true, false);
		}
		if (uiNiagara != null)
		{
			uiNiagara.ActivateSystem(true);
		}
		this.DecisionSpriteOnPress();
		AudioController.Instance.PostEventByUi("SignalDecodeGame_play_press_loop", this.CatchDownPlayResult, null, null);
	}

	// Token: 0x06016591 RID: 91537 RVA: 0x005A8084 File Offset: 0x005A6284
	private void OnCatchBtnUp()
	{
		this.MovePanel.OnCatchBtnUp();
		this.DecisionSpriteToNormal();
		AudioController.Instance.PostEventByUi("SignalDecodeGame_stop_press_loop", this.CatchUpPlayResult, null, null);
	}

	// Token: 0x06016592 RID: 91538 RVA: 0x005A80C1 File Offset: 0x005A62C1
	private void OnPauseBtnClick()
	{
		this.UpdateByStep(SignalDecodeViewV2.EGameplayStep.Pause, false);
	}

	// Token: 0x06016593 RID: 91539 RVA: 0x005A80CB File Offset: 0x005A62CB
	private void OnHelpBtnClick()
	{
	}

	// Token: 0x06016594 RID: 91540 RVA: 0x005A80D0 File Offset: 0x005A62D0
	private void DecisionSpriteOnPress()
	{
		string key = (SignalDecodeModel.Instance.CurrentGameplayType == ESignalGameplayType.Send) ? "SP_SignalPointerGreen" : "SP_SignalPointerYellow";
		this.DecisionSpriteChange(key);
	}

	// Token: 0x06016595 RID: 91541 RVA: 0x005A8100 File Offset: 0x005A6300
	private void DecisionSpriteToNormal()
	{
		this.DecisionSpriteChange("SP_SignalPointerNor");
	}

	// Token: 0x06016596 RID: 91542 RVA: 0x005A810D File Offset: 0x005A630D
	private void DecisionSpriteToRed()
	{
		this.DecisionSpriteChange("SP_SignalPointerRed");
	}

	// Token: 0x06016597 RID: 91543 RVA: 0x005A811C File Offset: 0x005A631C
	private void DecisionSpriteChange(string key)
	{
		if (this.LockChange)
		{
			return;
		}
		UUISprite sprite = base.GetSprite(7);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(key);
		this.SetSpriteByPath(resourcePath, sprite, false, null, null);
	}

	// Token: 0x0400A62F RID: 42543
	private const string COUNTDOWN_SEQUENCENAME = "Counter";

	// Token: 0x0400A630 RID: 42544
	private const string NIAGARA_ORANGE_COLOR = "FF400FFF";

	// Token: 0x0400A631 RID: 42545
	private const string COUNTDOWN_AUDIO_EVENTNAME = "SignalDecodeGame_count_down";

	// Token: 0x0400A632 RID: 42546
	private const string COUNTDOWNEND_AUDIO_EVENTNAME = "SignalDecodeGame_count_down_End";

	// Token: 0x0400A633 RID: 42547
	private const string BG_NOISE_AUDIO_EVENTNAME = "SignalDecodeGame_play_base_noise";

	// Token: 0x0400A634 RID: 42548
	private const string BG_NOISE_STOP_AUDIO_EVENTNAME = "SignalDecodeGame_stop_base_noise";

	// Token: 0x0400A635 RID: 42549
	private const string BG_BGM_AUDIO_EVENTNAME = "SignalDecodeGame_music_play_BGM";

	// Token: 0x0400A636 RID: 42550
	private const string BG_BGM_AUDIO_PAUSE_EVENTNAME = "SignalDecodeGame_music_pause_BGM";

	// Token: 0x0400A637 RID: 42551
	private const string BG_BGM_AUDIO_RESUME_EVENTNAME = "SignalDecodeGame_music_resume_BGM";

	// Token: 0x0400A638 RID: 42552
	private const string BG_BGM_STOP_AUDIO_EVENTNAME = "SignalDecodeGame_music_stop_BGM";

	// Token: 0x0400A639 RID: 42553
	private const string PLAYER_CATCHDOWN_AUDIO_EVENTNAME = "SignalDecodeGame_play_press_loop";

	// Token: 0x0400A63A RID: 42554
	private const string PLAYER_CATCHUP_AUDIO_EVENTNAME = "SignalDecodeGame_stop_press_loop";

	// Token: 0x0400A63B RID: 42555
	private const string PLAYER_CATCHSUCCESS_AUDIO_EVENTNAME = "SignalDecodeGame_release_correct";

	// Token: 0x0400A63C RID: 42556
	private const string PLAYER_CATCHFAILED_AUDIO_EVENTNAME = "SignalDecodeGame_release_error";

	// Token: 0x0400A63D RID: 42557
	private const string PLAYER_CATCHFAILED2_AUDIO_EVENTNAME = "SignalDecodeGame_music_play_presserror";

	// Token: 0x0400A63E RID: 42558
	[Nullable(2)]
	private SignalMovePanel MovePanel;

	// Token: 0x0400A63F RID: 42559
	[Nullable(2)]
	private PausePanel PausePanel;

	// Token: 0x0400A640 RID: 42560
	[Nullable(2)]
	private SuccessFinishPanel SuccessFinishPanel;

	// Token: 0x0400A641 RID: 42561
	[Nullable(2)]
	private FailedFinishPanel FailedFinishPanel;

	// Token: 0x0400A642 RID: 42562
	[Nullable(2)]
	private UNiagaraSystem SuccessBurstNiagara;

	// Token: 0x0400A643 RID: 42563
	[Nullable(2)]
	private UNiagaraSystem SuccessLoopNiagara;

	// Token: 0x0400A644 RID: 42564
	[Nullable(2)]
	private UNiagaraSystem FailBurstNiagara;

	// Token: 0x0400A645 RID: 42565
	[Nullable(2)]
	private UNiagaraSystem FailLoopNiagara;

	// Token: 0x0400A646 RID: 42566
	private readonly PlayResult CountDownPlayResult = new PlayResult();

	// Token: 0x0400A647 RID: 42567
	private readonly PlayResult CountDownEndPlayResult = new PlayResult();

	// Token: 0x0400A648 RID: 42568
	private readonly PlayResult BgNoisePlayResult = new PlayResult();

	// Token: 0x0400A649 RID: 42569
	private readonly PlayResult BgStopNoisePlayResult = new PlayResult();

	// Token: 0x0400A64A RID: 42570
	private readonly PlayResult CatchDownPlayResult = new PlayResult();

	// Token: 0x0400A64B RID: 42571
	private readonly PlayResult CatchUpPlayResult = new PlayResult();

	// Token: 0x0400A64C RID: 42572
	private readonly PlayResult CatchSuccessPlayResult = new PlayResult();

	// Token: 0x0400A64D RID: 42573
	private readonly PlayResult CatchFailedPlayResult = new PlayResult();

	// Token: 0x0400A64E RID: 42574
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400A64F RID: 42575
	private SignalDecodeViewV2.EGameplayStep CurrentStep;

	// Token: 0x0400A650 RID: 42576
	private bool LockChange;

	// Token: 0x0400A651 RID: 42577
	private bool BlockFlag;

	// Token: 0x0200904B RID: 36939
	[NullableContext(0)]
	private enum EGameplayStep
	{
		// Token: 0x0402EB8B RID: 191371
		None,
		// Token: 0x0402EB8C RID: 191372
		CountDown,
		// Token: 0x0402EB8D RID: 191373
		Gameplay,
		// Token: 0x0402EB8E RID: 191374
		Pause,
		// Token: 0x0402EB8F RID: 191375
		SuccessFinish,
		// Token: 0x0402EB90 RID: 191376
		FailedFinish
	}

	// Token: 0x0200904C RID: 36940
	[NullableContext(0)]
	public static class EChildComponent
	{
		// Token: 0x0402EB91 RID: 191377
		public const int CountDownNode = 0;

		// Token: 0x0402EB92 RID: 191378
		public const int GamePlayRoot = 1;

		// Token: 0x0402EB93 RID: 191379
		public const int CountDownText = 2;

		// Token: 0x0402EB94 RID: 191380
		public const int PauseBtn = 3;

		// Token: 0x0402EB95 RID: 191381
		public const int HelpBtn = 4;

		// Token: 0x0402EB96 RID: 191382
		public const int SignalMoveNode = 5;

		// Token: 0x0402EB97 RID: 191383
		public const int CatchButton = 6;

		// Token: 0x0402EB98 RID: 191384
		public const int DecisionSprite = 7;

		// Token: 0x0402EB99 RID: 191385
		public const int ProgressText = 8;

		// Token: 0x0402EB9A RID: 191386
		public const int BottomBg = 9;

		// Token: 0x0402EB9B RID: 191387
		public const int GameplayProgressSprite = 10;

		// Token: 0x0402EB9C RID: 191388
		public const int BurstNiagara = 11;

		// Token: 0x0402EB9D RID: 191389
		public const int PressNiagara = 12;

		// Token: 0x0402EB9E RID: 191390
		public const int BtnClickNiagara = 13;

		// Token: 0x0402EB9F RID: 191391
		public const int MatchText = 14;

		// Token: 0x0402EBA0 RID: 191392
		public const int DescribeText = 15;

		// Token: 0x0402EBA1 RID: 191393
		public const int BottomBgNiagaraL = 16;

		// Token: 0x0402EBA2 RID: 191394
		public const int BottomBgNiagaraR = 17;
	}
}
