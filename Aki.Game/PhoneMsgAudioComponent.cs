using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using UnrealEngine;

// Token: 0x020019E7 RID: 6631
[NullableContext(1)]
[Nullable(0)]
public class PhoneMsgAudioComponent
{
	// Token: 0x06010562 RID: 66914 RVA: 0x004C47ED File Offset: 0x004C29ED
	public void Init(PlotTextAudioComponentContext context)
	{
		this.OnAudioStartDelegate = context.OnAudioStartDelegate;
		this.OnAudioEndDelegate = context.OnAudioEndDelegate;
		this.OnAudioLoadTimeoutDelegate = context.OnAudioLoadTimeoutDelegate;
	}

	// Token: 0x06010563 RID: 66915 RVA: 0x004C4814 File Offset: 0x004C2A14
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

	// Token: 0x06010564 RID: 66916 RVA: 0x004C4900 File Offset: 0x004C2B00
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

	// Token: 0x06010565 RID: 66917 RVA: 0x004C4964 File Offset: 0x004C2B64
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

	// Token: 0x06010566 RID: 66918 RVA: 0x004C49ED File Offset: 0x004C2BED
	private void RemoveAudioLoadTimeoutTimer()
	{
		if (this.AudioLoadTimeoutTimer != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AudioLoadTimeoutTimer);
			this.AudioLoadTimeoutTimer = null;
		}
	}

	// Token: 0x06010567 RID: 66919 RVA: 0x004C4A10 File Offset: 0x004C2C10
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

	// Token: 0x06010568 RID: 66920 RVA: 0x004C4A4F File Offset: 0x004C2C4F
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

	// Token: 0x06010569 RID: 66921 RVA: 0x004C4A6F File Offset: 0x004C2C6F
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

	// Token: 0x0601056A RID: 66922 RVA: 0x004C4A95 File Offset: 0x004C2C95
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

	// Token: 0x040090AB RID: 37035
	private const float MAX_LOAD_AUDIO_TIME = 3f;

	// Token: 0x040090AC RID: 37036
	public const string PLOT_PHONE_MESSAGE_AUDIO_EVENT = "play_vo_external_phone_message";

	// Token: 0x040090AD RID: 37037
	public const string PLOT_PHONE_MESSAGE_EXTERNAL_SOURCE_NAME = "external_vo_phone_message";

	// Token: 0x040090AE RID: 37038
	public const string PLOT_SILENCE_AUDIO_EVENT = "play_external_silence";

	// Token: 0x040090AF RID: 37039
	public const string PLOT_SILENCE_EXTERNAL_SOURCE_NAME = "external_silence";

	// Token: 0x040090B0 RID: 37040
	private int UniqueId;

	// Token: 0x040090B1 RID: 37041
	private int PlotPlayEventResult;

	// Token: 0x040090B2 RID: 37042
	private bool IsPlaying;

	// Token: 0x040090B3 RID: 37043
	private bool IsLoading;

	// Token: 0x040090B4 RID: 37044
	[Nullable(2)]
	private TimerHandle AudioLoadTimeoutTimer;

	// Token: 0x040090B5 RID: 37045
	[Nullable(2)]
	private Action OnAudioStartDelegate;

	// Token: 0x040090B6 RID: 37046
	[Nullable(2)]
	private Action OnAudioEndDelegate;

	// Token: 0x040090B7 RID: 37047
	[Nullable(2)]
	private Action OnAudioLoadTimeoutDelegate;
}
