using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using UnrealEngine;

// Token: 0x02002500 RID: 9472
[NullableContext(1)]
[Nullable(0)]
public class PhoneMsgAudioComponent
{
	// Token: 0x060130A3 RID: 77987 RVA: 0x004B6B5D File Offset: 0x004B4D5D
	public void Init(PlotTextAudioComponentContext context)
	{
		this.OnAudioStartDelegate = context.OnAudioStartDelegate;
		this.OnAudioEndDelegate = context.OnAudioEndDelegate;
		this.OnAudioLoadTimeoutDelegate = context.OnAudioLoadTimeoutDelegate;
	}

	// Token: 0x060130A4 RID: 77988 RVA: 0x004B6B84 File Offset: 0x004B4D84
	public bool TryPlayPhoneMessageVoice(ITalkItem talkItem)
	{
		if (this.IsPlaying || this.IsLoading)
		{
			return false;
		}
		PlotAudio? plotAudio = talkItem.PlayVoice.GetValueOrDefault() ? ConfigPlotAudioById.GetConfig(talkItem.TidTalk, true) : null;
		if (plotAudio == null)
		{
			return false;
		}
		string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(plotAudio.Value);
		this.IsLoading = true;
		int id = this.UniqueId;
		AActor target = null;
		this.PlotPlayEventResult = AudioSystem.Instance.PostEvent("play_vo_external_phone_message", target, new PostEventArgs?(new PostEventArgs
		{
			ExternalSourceName = "external_vo_phone_message",
			ExternalSourceMediaName = externalSourcesMediaName,
			CallbackMask = new ECallbackMask?((ECallbackMask)9),
			CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
			{
				this.OnAudioPlayCallback(id, callbackType, callbackInfo);
			}
		}));
		this.AddAudioLoadTimeoutTimer();
		return true;
	}

	// Token: 0x060130A5 RID: 77989 RVA: 0x004B6C70 File Offset: 0x004B4E70
	public void StopAudio()
	{
		this.RemoveAudioLoadTimeoutTimer();
		this.UniqueId++;
		AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
		{
			TransitionDuration = new int?(0)
		}));
		this.PlotPlayEventResult = 0;
		this.IsPlaying = false;
		this.IsLoading = false;
	}

	// Token: 0x060130A6 RID: 77990 RVA: 0x004B6CD4 File Offset: 0x004B4ED4
	private void AddAudioLoadTimeoutTimer()
	{
		if (this.AudioLoadTimeoutTimer != null)
		{
			return;
		}
		if (this.IsLoading)
		{
			global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.LZK, "[PlotAudioComponent] 正在加载音频，无法添加音频加载超时定时器", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.IsPlaying)
		{
			global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.LZK, "[PlotAudioComponent] 正在播放音频，无法添加音频加载超时定时器", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.AudioLoadTimeoutTimer = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.OnAudioLoadTimeout), 3f, null, null, true, 1f);
	}

	// Token: 0x060130A7 RID: 77991 RVA: 0x004B6D5D File Offset: 0x004B4F5D
	private void RemoveAudioLoadTimeoutTimer()
	{
		if (this.AudioLoadTimeoutTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AudioLoadTimeoutTimer);
			this.AudioLoadTimeoutTimer = null;
		}
	}

	// Token: 0x060130A8 RID: 77992 RVA: 0x004B6D80 File Offset: 0x004B4F80
	private void OnAudioLoadTimeout(float delta)
	{
		global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.LZK, "[PlotAudioComponent] 音频加载超时", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.StopAudio();
		Action onAudioLoadTimeoutDelegate = this.OnAudioLoadTimeoutDelegate;
		if (onAudioLoadTimeoutDelegate == null)
		{
			return;
		}
		onAudioLoadTimeoutDelegate();
	}

	// Token: 0x060130A9 RID: 77993 RVA: 0x004B6DBF File Offset: 0x004B4FBF
	[NullableContext(2)]
	private void OnAudioPlayCallback(int id, EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
	{
		if (id != this.UniqueId)
		{
			return;
		}
		if (callbackType == EAkCallbackType.EndOfEvent)
		{
			this.OnAudioEnd();
			return;
		}
		if (callbackType == EAkCallbackType.Duration)
		{
			this.OnAudioStart();
		}
	}

	// Token: 0x060130AA RID: 77994 RVA: 0x004B6DDF File Offset: 0x004B4FDF
	private void OnAudioStart()
	{
		this.IsLoading = false;
		this.IsPlaying = true;
		this.RemoveAudioLoadTimeoutTimer();
		Action onAudioStartDelegate = this.OnAudioStartDelegate;
		if (onAudioStartDelegate == null)
		{
			return;
		}
		onAudioStartDelegate();
	}

	// Token: 0x060130AB RID: 77995 RVA: 0x004B6E05 File Offset: 0x004B5005
	private void OnAudioEnd()
	{
		this.IsPlaying = false;
		this.UniqueId++;
		Action onAudioEndDelegate = this.OnAudioEndDelegate;
		if (onAudioEndDelegate == null)
		{
			return;
		}
		onAudioEndDelegate();
	}

	// Token: 0x04008F61 RID: 36705
	private const float MAX_LOAD_AUDIO_TIME = 3f;

	// Token: 0x04008F62 RID: 36706
	public const string PLOT_PHONE_MESSAGE_AUDIO_EVENT = "play_vo_external_phone_message";

	// Token: 0x04008F63 RID: 36707
	public const string PLOT_PHONE_MESSAGE_EXTERNAL_SOURCE_NAME = "external_vo_phone_message";

	// Token: 0x04008F64 RID: 36708
	public const string PLOT_SILENCE_AUDIO_EVENT = "play_external_silence";

	// Token: 0x04008F65 RID: 36709
	public const string PLOT_SILENCE_EXTERNAL_SOURCE_NAME = "external_silence";

	// Token: 0x04008F66 RID: 36710
	private int UniqueId;

	// Token: 0x04008F67 RID: 36711
	private int PlotPlayEventResult;

	// Token: 0x04008F68 RID: 36712
	private bool IsPlaying;

	// Token: 0x04008F69 RID: 36713
	private bool IsLoading;

	// Token: 0x04008F6A RID: 36714
	[Nullable(2)]
	private TimerHandle AudioLoadTimeoutTimer;

	// Token: 0x04008F6B RID: 36715
	[Nullable(2)]
	private Action OnAudioStartDelegate;

	// Token: 0x04008F6C RID: 36716
	[Nullable(2)]
	private Action OnAudioEndDelegate;

	// Token: 0x04008F6D RID: 36717
	[Nullable(2)]
	private Action OnAudioLoadTimeoutDelegate;
}
