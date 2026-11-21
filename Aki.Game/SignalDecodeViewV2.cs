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

// Token: 0x02001F8B RID: 8075
[NullableContext(1)]
[Nullable(0)]
public class SignalDecodeViewV2 : UiTickViewBase
{
	// Token: 0x06013F7E RID: 81790 RVA: 0x005D24F8 File Offset: 0x005D06F8
	public SignalDecodeViewV2(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013F7F RID: 81791 RVA: 0x005D2564 File Offset: 0x005D0764
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

	// Token: 0x06013F80 RID: 81792 RVA: 0x005D274C File Offset: 0x005D094C
	protected override UniTask OnBeforeStartAsync()
	{
		SignalDecodeViewV2.<OnBeforeStartAsync>d__39 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SignalDecodeViewV2.<OnBeforeStartAsync>d__39>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013F81 RID: 81793 RVA: 0x005D2790 File Offset: 0x005D0990
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

	// Token: 0x06013F82 RID: 81794 RVA: 0x005D27DB File Offset: 0x005D09DB
	protected override void OnBeforeShow()
	{
		UUIButtonComponent button = base.GetButton(6);
		button.OnPointDownCallBack.Bind(new Action(this.OnCatchBtnDown));
		button.OnPointUpCallBack.Bind(new Action(this.OnCatchBtnUp));
	}

	// Token: 0x06013F83 RID: 81795 RVA: 0x005D2811 File Offset: 0x005D0A11
	protected override void OnAfterShow()
	{
		this.UpdateByStep(SignalDecodeViewV2.EGameplayStep.CountDown, false);
	}

	// Token: 0x06013F84 RID: 81796 RVA: 0x005D281B File Offset: 0x005D0A1B
	protected override void OnBeforeDestroy()
	{
		this.StopAllAudio();
		this.SuccessLoopNiagara = null;
		this.SuccessBurstNiagara = null;
		this.FailLoopNiagara = null;
		this.FailBurstNiagara = null;
	}

	// Token: 0x06013F85 RID: 81797 RVA: 0x005D2840 File Offset: 0x005D0A40
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

	// Token: 0x06013F86 RID: 81798 RVA: 0x005D2903 File Offset: 0x005D0B03
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

	// Token: 0x06013F87 RID: 81799 RVA: 0x005D2944 File Offset: 0x005D0B44
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnSignalCatchStart, new Action(this.OnSignalCatchStart));
		EventSystem.Instance.Add(EEventName.OnSignalCatchSuccess, new Action(this.OnSignalCatchSuccess));
		EventSystem.Instance.Add(EEventName.OnSignalCatchFailed, new Action(this.OnSignalCatchFailed));
		EventSystem.Instance.Add(EEventName.OnSignalCatchContinue, new Action(this.OnSignalCatchContinue));
		EventSystem.Instance.Add(EEventName.OnSignalCatchStartAgain, new Action(this.OnSignalCatchStartAgain));
	}

	// Token: 0x06013F88 RID: 81800 RVA: 0x005D29E0 File Offset: 0x005D0BE0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnSignalCatchStart, new Action(this.OnSignalCatchStart));
		EventSystem.Instance.Remove(EEventName.OnSignalCatchSuccess, new Action(this.OnSignalCatchSuccess));
		EventSystem.Instance.Remove(EEventName.OnSignalCatchFailed, new Action(this.OnSignalCatchFailed));
		EventSystem.Instance.Remove(EEventName.OnSignalCatchContinue, new Action(this.OnSignalCatchContinue));
		EventSystem.Instance.Remove(EEventName.OnSignalCatchStartAgain, new Action(this.OnSignalCatchStartAgain));
	}

	// Token: 0x06013F89 RID: 81801 RVA: 0x005D2A79 File Offset: 0x005D0C79
	private void OnSignalCatchStart()
	{
		UUINiagara uiNiagara = base.GetUiNiagara(12);
		uiNiagara.SetNiagaraSystem(this.SuccessLoopNiagara);
		uiNiagara.SetNiagaraUIActive(true, false);
		uiNiagara.ActivateSystem(true);
	}

	// Token: 0x06013F8A RID: 81802 RVA: 0x005D2AA0 File Offset: 0x005D0CA0
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

	// Token: 0x06013F8B RID: 81803 RVA: 0x005D2B08 File Offset: 0x005D0D08
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

	// Token: 0x06013F8C RID: 81804 RVA: 0x005D2BAF File Offset: 0x005D0DAF
	private void OnSignalCatchContinue()
	{
		this.PausePanel.Hide(null);
		this.UpdateByStep(SignalDecodeViewV2.EGameplayStep.Gameplay, false);
	}

	// Token: 0x06013F8D RID: 81805 RVA: 0x005D2BC5 File Offset: 0x005D0DC5
	private void OnSignalCatchStartAgain()
	{
		this.PausePanel.Hide(null);
		this.MovePanel.StartAgain();
		this.UpdateByStep(SignalDecodeViewV2.EGameplayStep.Gameplay, true);
	}

	// Token: 0x06013F8E RID: 81806 RVA: 0x005D2BE6 File Offset: 0x005D0DE6
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Counter")
		{
			this.UpdateByStep(SignalDecodeViewV2.EGameplayStep.Gameplay, true);
		}
	}

	// Token: 0x06013F8F RID: 81807 RVA: 0x005D2C00 File Offset: 0x005D0E00
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

	// Token: 0x06013F90 RID: 81808 RVA: 0x005D2C73 File Offset: 0x005D0E73
	protected override void OnTick(float delta)
	{
		if (this.CurrentStep == SignalDecodeViewV2.EGameplayStep.Gameplay)
		{
			this.UpdateGameplay(delta);
		}
	}

	// Token: 0x06013F91 RID: 81809 RVA: 0x005D2C85 File Offset: 0x005D0E85
	private void UpdateGameplay(float delta)
	{
		this.MovePanel.UpdateMove(delta);
		this.UpdateProgress();
	}

	// Token: 0x06013F92 RID: 81810 RVA: 0x005D2C9C File Offset: 0x005D0E9C
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

	// Token: 0x06013F93 RID: 81811 RVA: 0x005D2D20 File Offset: 0x005D0F20
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

	// Token: 0x06013F94 RID: 81812 RVA: 0x005D2D78 File Offset: 0x005D0F78
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

	// Token: 0x06013F95 RID: 81813 RVA: 0x005D2F6B File Offset: 0x005D116B
	private void InitMoveNode()
	{
		this.MovePanel.InitMoveNode();
	}

	// Token: 0x06013F96 RID: 81814 RVA: 0x005D2F78 File Offset: 0x005D1178
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

	// Token: 0x06013F97 RID: 81815 RVA: 0x005D2FFC File Offset: 0x005D11FC
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

	// Token: 0x06013F98 RID: 81816 RVA: 0x005D305C File Offset: 0x005D125C
	private void OnCatchBtnUp()
	{
		this.MovePanel.OnCatchBtnUp();
		this.DecisionSpriteToNormal();
		AudioController.Instance.PostEventByUi("SignalDecodeGame_stop_press_loop", this.CatchUpPlayResult, null, null);
	}

	// Token: 0x06013F99 RID: 81817 RVA: 0x005D3099 File Offset: 0x005D1299
	private void OnPauseBtnClick()
	{
		this.UpdateByStep(SignalDecodeViewV2.EGameplayStep.Pause, false);
	}

	// Token: 0x06013F9A RID: 81818 RVA: 0x005D30A3 File Offset: 0x005D12A3
	private void OnHelpBtnClick()
	{
	}

	// Token: 0x06013F9B RID: 81819 RVA: 0x005D30A8 File Offset: 0x005D12A8
	private void DecisionSpriteOnPress()
	{
		string key = (SignalDecodeModel.Instance.CurrentGameplayType == ESignalGameplayType.Send) ? "SP_SignalPointerGreen" : "SP_SignalPointerYellow";
		this.DecisionSpriteChange(key);
	}

	// Token: 0x06013F9C RID: 81820 RVA: 0x005D30D8 File Offset: 0x005D12D8
	private void DecisionSpriteToNormal()
	{
		this.DecisionSpriteChange("SP_SignalPointerNor");
	}

	// Token: 0x06013F9D RID: 81821 RVA: 0x005D30E5 File Offset: 0x005D12E5
	private void DecisionSpriteToRed()
	{
		this.DecisionSpriteChange("SP_SignalPointerRed");
	}

	// Token: 0x06013F9E RID: 81822 RVA: 0x005D30F4 File Offset: 0x005D12F4
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

	// Token: 0x0400AA19 RID: 43545
	private const string COUNTDOWN_SEQUENCENAME = "Counter";

	// Token: 0x0400AA1A RID: 43546
	private const string NIAGARA_ORANGE_COLOR = "FF400FFF";

	// Token: 0x0400AA1B RID: 43547
	private const string COUNTDOWN_AUDIO_EVENTNAME = "SignalDecodeGame_count_down";

	// Token: 0x0400AA1C RID: 43548
	private const string COUNTDOWNEND_AUDIO_EVENTNAME = "SignalDecodeGame_count_down_End";

	// Token: 0x0400AA1D RID: 43549
	private const string BG_NOISE_AUDIO_EVENTNAME = "SignalDecodeGame_play_base_noise";

	// Token: 0x0400AA1E RID: 43550
	private const string BG_NOISE_STOP_AUDIO_EVENTNAME = "SignalDecodeGame_stop_base_noise";

	// Token: 0x0400AA1F RID: 43551
	private const string BG_BGM_AUDIO_EVENTNAME = "SignalDecodeGame_music_play_BGM";

	// Token: 0x0400AA20 RID: 43552
	private const string BG_BGM_AUDIO_PAUSE_EVENTNAME = "SignalDecodeGame_music_pause_BGM";

	// Token: 0x0400AA21 RID: 43553
	private const string BG_BGM_AUDIO_RESUME_EVENTNAME = "SignalDecodeGame_music_resume_BGM";

	// Token: 0x0400AA22 RID: 43554
	private const string BG_BGM_STOP_AUDIO_EVENTNAME = "SignalDecodeGame_music_stop_BGM";

	// Token: 0x0400AA23 RID: 43555
	private const string PLAYER_CATCHDOWN_AUDIO_EVENTNAME = "SignalDecodeGame_play_press_loop";

	// Token: 0x0400AA24 RID: 43556
	private const string PLAYER_CATCHUP_AUDIO_EVENTNAME = "SignalDecodeGame_stop_press_loop";

	// Token: 0x0400AA25 RID: 43557
	private const string PLAYER_CATCHSUCCESS_AUDIO_EVENTNAME = "SignalDecodeGame_release_correct";

	// Token: 0x0400AA26 RID: 43558
	private const string PLAYER_CATCHFAILED_AUDIO_EVENTNAME = "SignalDecodeGame_release_error";

	// Token: 0x0400AA27 RID: 43559
	private const string PLAYER_CATCHFAILED2_AUDIO_EVENTNAME = "SignalDecodeGame_music_play_presserror";

	// Token: 0x0400AA28 RID: 43560
	[Nullable(2)]
	private SignalMovePanel MovePanel;

	// Token: 0x0400AA29 RID: 43561
	[Nullable(2)]
	private PausePanel PausePanel;

	// Token: 0x0400AA2A RID: 43562
	[Nullable(2)]
	private SuccessFinishPanel SuccessFinishPanel;

	// Token: 0x0400AA2B RID: 43563
	[Nullable(2)]
	private FailedFinishPanel FailedFinishPanel;

	// Token: 0x0400AA2C RID: 43564
	[Nullable(2)]
	private UNiagaraSystem SuccessBurstNiagara;

	// Token: 0x0400AA2D RID: 43565
	[Nullable(2)]
	private UNiagaraSystem SuccessLoopNiagara;

	// Token: 0x0400AA2E RID: 43566
	[Nullable(2)]
	private UNiagaraSystem FailBurstNiagara;

	// Token: 0x0400AA2F RID: 43567
	[Nullable(2)]
	private UNiagaraSystem FailLoopNiagara;

	// Token: 0x0400AA30 RID: 43568
	private readonly PlayResult CountDownPlayResult = new PlayResult();

	// Token: 0x0400AA31 RID: 43569
	private readonly PlayResult CountDownEndPlayResult = new PlayResult();

	// Token: 0x0400AA32 RID: 43570
	private readonly PlayResult BgNoisePlayResult = new PlayResult();

	// Token: 0x0400AA33 RID: 43571
	private readonly PlayResult BgStopNoisePlayResult = new PlayResult();

	// Token: 0x0400AA34 RID: 43572
	private readonly PlayResult CatchDownPlayResult = new PlayResult();

	// Token: 0x0400AA35 RID: 43573
	private readonly PlayResult CatchUpPlayResult = new PlayResult();

	// Token: 0x0400AA36 RID: 43574
	private readonly PlayResult CatchSuccessPlayResult = new PlayResult();

	// Token: 0x0400AA37 RID: 43575
	private readonly PlayResult CatchFailedPlayResult = new PlayResult();

	// Token: 0x0400AA38 RID: 43576
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400AA39 RID: 43577
	private SignalDecodeViewV2.EGameplayStep CurrentStep;

	// Token: 0x0400AA3A RID: 43578
	private bool LockChange;

	// Token: 0x0400AA3B RID: 43579
	private bool BlockFlag;

	// Token: 0x02008292 RID: 33426
	[NullableContext(0)]
	private enum EGameplayStep
	{
		// Token: 0x0402A283 RID: 172675
		None,
		// Token: 0x0402A284 RID: 172676
		CountDown,
		// Token: 0x0402A285 RID: 172677
		Gameplay,
		// Token: 0x0402A286 RID: 172678
		Pause,
		// Token: 0x0402A287 RID: 172679
		SuccessFinish,
		// Token: 0x0402A288 RID: 172680
		FailedFinish
	}

	// Token: 0x02008293 RID: 33427
	[NullableContext(0)]
	public static class EChildComponent
	{
		// Token: 0x0402A289 RID: 172681
		public const int CountDownNode = 0;

		// Token: 0x0402A28A RID: 172682
		public const int GamePlayRoot = 1;

		// Token: 0x0402A28B RID: 172683
		public const int CountDownText = 2;

		// Token: 0x0402A28C RID: 172684
		public const int PauseBtn = 3;

		// Token: 0x0402A28D RID: 172685
		public const int HelpBtn = 4;

		// Token: 0x0402A28E RID: 172686
		public const int SignalMoveNode = 5;

		// Token: 0x0402A28F RID: 172687
		public const int CatchButton = 6;

		// Token: 0x0402A290 RID: 172688
		public const int DecisionSprite = 7;

		// Token: 0x0402A291 RID: 172689
		public const int ProgressText = 8;

		// Token: 0x0402A292 RID: 172690
		public const int BottomBg = 9;

		// Token: 0x0402A293 RID: 172691
		public const int GameplayProgressSprite = 10;

		// Token: 0x0402A294 RID: 172692
		public const int BurstNiagara = 11;

		// Token: 0x0402A295 RID: 172693
		public const int PressNiagara = 12;

		// Token: 0x0402A296 RID: 172694
		public const int BtnClickNiagara = 13;

		// Token: 0x0402A297 RID: 172695
		public const int MatchText = 14;

		// Token: 0x0402A298 RID: 172696
		public const int DescribeText = 15;

		// Token: 0x0402A299 RID: 172697
		public const int BottomBgNiagaraL = 16;

		// Token: 0x0402A29A RID: 172698
		public const int BottomBgNiagaraR = 17;
	}
}
