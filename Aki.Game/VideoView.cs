using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.GameSettings;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200224B RID: 8779
[NullableContext(1)]
[Nullable(0)]
public class VideoView : UiTickViewBase
{
	// Token: 0x06015AEA RID: 88810 RVA: 0x00648964 File Offset: 0x00646B64
	public VideoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015AEB RID: 88811 RVA: 0x006489F4 File Offset: 0x00646BF4
	public void SetSkipButtonVisible(bool visible)
	{
		if (this.SkipComp != null)
		{
			this.SkipComp.EnableSkipButton(visible);
			return;
		}
		UUIButtonComponent skipButton = this.SkipButton;
		if (skipButton == null)
		{
			return;
		}
		skipButton.RootUIComp.Get().SetUIActive(visible);
	}

	// Token: 0x06015AEC RID: 88812 RVA: 0x00648A34 File Offset: 0x00646C34
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
	}

	// Token: 0x06015AED RID: 88813 RVA: 0x00648AD0 File Offset: 0x00646CD0
	protected override UniTask OnBeforeStartAsync()
	{
		VideoView.<OnBeforeStartAsync>d__45 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<VideoView.<OnBeforeStartAsync>d__45>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015AEE RID: 88814 RVA: 0x00648B14 File Offset: 0x00646D14
	protected override void OnAddEventListener()
	{
		Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.ResumeVideo));
		Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillDeactivateDelegate, new Action(this.PauseVideo));
		EventSystem.Instance.Add<IVideoParamHub>(EEventName.PlayVideo, new Action<IVideoParamHub>(this.OnPlayVideo));
		EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnUiViewPortSizeChanged));
	}

	// Token: 0x06015AEF RID: 88815 RVA: 0x00648B84 File Offset: 0x00646D84
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		VideoView.<OnPlayingStartSequenceAsync>d__47 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<VideoView.<OnPlayingStartSequenceAsync>d__47>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015AF0 RID: 88816 RVA: 0x00648BC7 File Offset: 0x00646DC7
	protected override void OnAfterShow()
	{
		EventSystem.Instance.Emit(EEventName.VideoViewShow);
		LoadModeManager.Instance.SetLoadModeByReason(ELoadMode.ForceInGame, ELoadModeReason.VideoView);
		this.IsViewClosed = false;
		this.OnShowVideo();
	}

	// Token: 0x06015AF1 RID: 88817 RVA: 0x00648BF2 File Offset: 0x00646DF2
	protected override void OnTick(float delta)
	{
		if (this.RunningState)
		{
			this.TickPlayback();
		}
		this.TickAspectTransition(delta);
	}

	// Token: 0x06015AF2 RID: 88818 RVA: 0x00648C0C File Offset: 0x00646E0C
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Emit<bool>(EEventName.VideoViewHide, this.IsPlayToEnd);
		foreach (CommonQteContextBase commonQteContextBase in this.CurrentQte)
		{
			CommonQteController.Instance.StopQte(commonQteContextBase.HandleId);
		}
		this.CurrentQte.Clear();
		LoadModeManager.Instance.ResetLoadModeByReason(ELoadModeReason.VideoView);
		this.SetSkipButtonVisible(false);
		GameModeModel.Instance.Mp4FadeInScreenColor = null;
		GameModeModel.Instance.Mp4FadeOutScreenColor = null;
		this.BackgroundColor = null;
	}

	// Token: 0x06015AF3 RID: 88819 RVA: 0x00648CD0 File Offset: 0x00646ED0
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		VideoView.<OnPlayingCloseSequenceAsync>d__51 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<VideoView.<OnPlayingCloseSequenceAsync>d__51>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015AF4 RID: 88820 RVA: 0x00648D14 File Offset: 0x00646F14
	protected override void OnRemoveEventListener()
	{
		Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.ResumeVideo));
		Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillDeactivateDelegate, new Action(this.PauseVideo));
		EventSystem.Instance.Remove<IVideoParamHub>(EEventName.PlayVideo, new Action<IVideoParamHub>(this.OnPlayVideo));
		EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnUiViewPortSizeChanged));
	}

	// Token: 0x06015AF5 RID: 88821 RVA: 0x00648D84 File Offset: 0x00646F84
	protected override void OnBeforeDestroy()
	{
		if (!this.IsViewClosed)
		{
			this.RenderSetup(false);
			this.TryExecuteBlendAnim();
		}
		this.CleanVideo();
		IVideoParamHub videoParamHub = this.OpenParam as IVideoParamHub;
		Action action = (videoParamHub != null) ? videoParamHub.VideoCloseCb : null;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06015AF6 RID: 88822 RVA: 0x00648DC2 File Offset: 0x00646FC2
	protected override void OnAfterDestroy()
	{
		if (this.HasTriggerBlendOut)
		{
			UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("VideoView.TriggerBlendOut");
		}
		this.ReleaseSeamlessEndTimeDilationTag();
	}

	// Token: 0x06015AF7 RID: 88823 RVA: 0x00648DE4 File Offset: 0x00646FE4
	private bool TryInitializeCgTexture()
	{
		this.CgTexture = (base.GetButton(0).GetOwner().GetComponentByClass(UUITexture.StaticClass()) as UUITexture);
		if (this.CgTexture != null)
		{
			return true;
		}
		global::Log.Instance.Error(ELogModule.Video, ELogAuthor.ZWY, "获取CgTexture异常！！", default(ReadOnlySpan<ValueTuple<string, object>>));
		return false;
	}

	// Token: 0x06015AF8 RID: 88824 RVA: 0x00648E44 File Offset: 0x00647044
	[NullableContext(2)]
	private UniTask PrepareVisualResourcesAsync(IVideoParamHub param)
	{
		VideoView.<PrepareVisualResourcesAsync>d__56 <PrepareVisualResourcesAsync>d__;
		<PrepareVisualResourcesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PrepareVisualResourcesAsync>d__.<>4__this = this;
		<PrepareVisualResourcesAsync>d__.param = param;
		<PrepareVisualResourcesAsync>d__.<>1__state = -1;
		<PrepareVisualResourcesAsync>d__.<>t__builder.Start<VideoView.<PrepareVisualResourcesAsync>d__56>(ref <PrepareVisualResourcesAsync>d__);
		return <PrepareVisualResourcesAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015AF9 RID: 88825 RVA: 0x00648E90 File Offset: 0x00647090
	[NullableContext(2)]
	private UniTask LoadReplaceMaterialAsync(IProgramSpecialConfigBase config)
	{
		if (config == null || config.Type > EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial)
		{
			return UniTask.CompletedTask;
		}
		UniTaskCompletionSource promise = new UniTaskCompletionSource();
		ResourceSystem.Instance.LoadAsync<UMaterialInterface>(((IMp4UiReplaceMaterial)config).Mp4UiReplaceMaterial, delegate([Nullable(2)] UMaterialInterface material, string _)
		{
			if (material != null)
			{
				this.CgTexture.SetCustomUIMaterial(material);
			}
			promise.TrySetResult();
		}, ResourceSystem.EResourceLoadPriority.Ui, this.MemoryTag);
		return promise.Task;
	}

	// Token: 0x06015AFA RID: 88826 RVA: 0x00648F04 File Offset: 0x00647104
	private void InitializeSkip()
	{
		this.ClearSkip();
		this.SkipButton = base.GetButton(1);
		this.SkipButton.RootUIComp.Get().SetUIActive(false);
		IVideoParamHub videoParamHub = this.OpenParam as IVideoParamHub;
		if (videoParamHub != null && videoParamHub.SkipType == EVideoSkipType.Normal)
		{
			this.InitializeNormalSkip();
			return;
		}
		this.InitializePlotSkip();
	}

	// Token: 0x06015AFB RID: 88827 RVA: 0x00648F66 File Offset: 0x00647166
	private void InitializeNormalSkip()
	{
		this.SkipButton.OnClickCallBack.Bind(new Action(this.OnSkipCg));
		this.SetSkipButtonVisible(false);
	}

	// Token: 0x06015AFC RID: 88828 RVA: 0x00648F8C File Offset: 0x0064718C
	private void InitializePlotSkip()
	{
		this.SkipComp = new PlotSkipComponent(this.SkipButton, new Action(this.OnSkipCg), null, this, null, null, null);
		this.SkipComp.AddEventListener();
		this.SetSkipButtonVisible(false);
	}

	// Token: 0x06015AFD RID: 88829 RVA: 0x00648FD8 File Offset: 0x006471D8
	private UMediaTexture InitializeMediaPlayer()
	{
		UMediaTexture umediaTexture = this.CgTexture.GetTexture() as UMediaTexture;
		umediaTexture.AutoClear = false;
		this.MediaPlayer = ((umediaTexture != null) ? umediaTexture.GetMediaPlayer() : null);
		if (this.MediaPlayer == null)
		{
			global::Log.Instance.Error(ELogModule.Video, ELogAuthor.ZWY, "获取MediaPlayer异常！！", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		return umediaTexture;
	}

	// Token: 0x06015AFE RID: 88830 RVA: 0x00649038 File Offset: 0x00647238
	[NullableContext(2)]
	private void ApplyPlaybackConfig(IVideoParamHub param)
	{
		this.BackgroundColor = null;
		this.Mp4FadeOutTime = ((param != null) ? param.Mp4FadeOutTime : null).GetValueOrDefault() * 1000f;
		this.BlackBorderFadeOutTime = ((param != null) ? param.BlackBorderFadeOutTime : null).GetValueOrDefault() * 1000f;
		if (((param != null) ? param.Mp4BlendAnim : null) != null)
		{
			PlotBlendController.Instance.SetupInfo(param.Mp4BlendAnim, param.VideoDataConf.CgName);
		}
	}

	// Token: 0x06015AFF RID: 88831 RVA: 0x006490D0 File Offset: 0x006472D0
	private void ApplyBackgroundColor(UMediaTexture mediaTexture, [Nullable(2)] IVideoParamHub param)
	{
		EMovieBackgroundType? emovieBackgroundType2;
		if (GameModeModel.Instance.Mp4FadeInScreenColor != null)
		{
			this.BackgroundColor = GameModeModel.Instance.Mp4FadeInScreenColor;
		}
		else
		{
			EMovieBackgroundType? emovieBackgroundType;
			if (param == null)
			{
				emovieBackgroundType = null;
			}
			else
			{
				IMovieBackgroundFadeData backgroundColor = param.BackgroundColor;
				emovieBackgroundType = ((backgroundColor != null) ? new EMovieBackgroundType?(backgroundColor.FadeInBackgroundType) : null);
			}
			emovieBackgroundType2 = emovieBackgroundType;
			this.BackgroundColor = new EMovieBackgroundType?(emovieBackgroundType2.GetValueOrDefault(EMovieBackgroundType.Black));
		}
		FLinearColor? flinearColor = null;
		emovieBackgroundType2 = this.BackgroundColor;
		if (emovieBackgroundType2 != null)
		{
			EMovieBackgroundType valueOrDefault = emovieBackgroundType2.GetValueOrDefault();
			if (valueOrDefault == EMovieBackgroundType.White)
			{
				flinearColor = new FLinearColor?(new FLinearColor(1f, 1f, 1f, 1f));
				goto IL_D2;
			}
			if (valueOrDefault != EMovieBackgroundType.Black)
			{
			}
		}
		flinearColor = new FLinearColor?(new FLinearColor(0f, 0f, 0f, 1f));
		IL_D2:
		this.HasChangeColor = !mediaTexture.ClearColor.Equals(flinearColor);
		mediaTexture.ClearColor = flinearColor.Value;
	}

	// Token: 0x06015B00 RID: 88832 RVA: 0x006491E0 File Offset: 0x006473E0
	private void InitializeAspectTransition()
	{
		float num = UiLayer.Instance.UiRootItem.GetWidth() / UiLayer.Instance.UiRootItem.GetHeight();
		if (PlotModel.Instance.LastPlotAspect != -1f && num > 1f)
		{
			this.LastAspect = PlotModel.Instance.LastPlotAspect;
			if ((double)this.LastAspect < 2.3)
			{
				this.LastAspect = num;
			}
			this.SetAspect(this.LastAspect);
		}
		this.LerpFullTime = (float)ConfigCommonParamById.GetIntConfig("VideoViewLerpFullTime").GetValueOrDefault(4000);
		this.LerpWaitTime = (float)ConfigCommonParamById.GetIntConfig("VideoViewLerpWaitTime").GetValueOrDefault(1000);
	}

	// Token: 0x06015B01 RID: 88833 RVA: 0x00649297 File Offset: 0x00647497
	private void ResetPlaybackState()
	{
		this.CurrentQte.Clear();
		this.HasTriggerBlendOut = false;
		this.HasHandledVideoEnd = false;
		this.RemoveSeamlessEndDelayHandle();
	}

	// Token: 0x06015B02 RID: 88834 RVA: 0x006492B8 File Offset: 0x006474B8
	private void SetAspect(float videoAspect)
	{
		float num = UiLayer.Instance.UiRootItem.GetWidth() / UiLayer.Instance.UiRootItem.GetHeight();
		if (videoAspect < num)
		{
			float width = UiLayer.Instance.UiRootItem.GetHeight() * videoAspect;
			this.CgTexture.SetWidth(width);
			this.CgTexture.SetHeight(UiLayer.Instance.UiRootItem.GetHeight());
			return;
		}
		if (videoAspect > num)
		{
			float height = UiLayer.Instance.UiRootItem.GetWidth() / videoAspect;
			this.CgTexture.SetHeight(height);
			this.CgTexture.SetWidth(UiLayer.Instance.UiRootItem.GetWidth());
			return;
		}
		this.CgTexture.SetWidth(UiLayer.Instance.UiRootItem.GetWidth());
		this.CgTexture.SetHeight(UiLayer.Instance.UiRootItem.GetHeight());
	}

	// Token: 0x06015B03 RID: 88835 RVA: 0x00649393 File Offset: 0x00647593
	private void CleanVideo()
	{
		this.ClearPlaybackResources();
		this.ClearAudio();
		this.ClearCaptionLines();
		this.ClearSkip();
	}

	// Token: 0x06015B04 RID: 88836 RVA: 0x006493B0 File Offset: 0x006475B0
	private void ClearPlaybackResources()
	{
		if (this.CaptionTimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.CaptionTimerId);
			this.CaptionTimerId = null;
		}
		if (this.LoadHandle != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadHandle);
			this.LoadHandle = -1;
		}
		(this.CgTexture.GetTexture() as UMediaTexture).AutoClear = true;
		this.VideoName = null;
		UMediaPlayer mediaPlayer = this.MediaPlayer;
		if (mediaPlayer != null)
		{
			mediaPlayer.OnEndReached.Remove(new Action(this.OnVideoEnd));
		}
		UMediaPlayer mediaPlayer2 = this.MediaPlayer;
		if (mediaPlayer2 != null)
		{
			mediaPlayer2.OnMediaOpened.Remove(new Action<string>(this.OnMediaOpen));
		}
		UMediaPlayer mediaPlayer3 = this.MediaPlayer;
		if (mediaPlayer3 != null)
		{
			mediaPlayer3.OnMediaOpenFailed.Remove(new Action<string>(this.OnVideoOpenFailed));
		}
		UMediaPlayer mediaPlayer4 = this.MediaPlayer;
		if (mediaPlayer4 != null)
		{
			mediaPlayer4.Close();
		}
		this.MediaPlayer = null;
		this.CaptionDataList = null;
		this.VideoPauseTime = null;
		this.RunningState = false;
		this.RemoveSeamlessEndDelayHandle();
	}

	// Token: 0x06015B05 RID: 88837 RVA: 0x006494B4 File Offset: 0x006476B4
	private void ClearAudio()
	{
		if (!this.IsPlayToEnd)
		{
			foreach (VideoSoundPlay videoSoundPlay in this.VideoSoundPlays)
			{
				AudioSystem.Instance.ExecuteAction(videoSoundPlay.Handle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(0)
				}));
			}
			this.StopAllSubtitleVoices();
		}
		this.VideoSoundPlays.Clear();
		this.PendingVideoSounds.Clear();
		this.SubtitleVoicePlays.Clear();
		AudioSystem.Instance.SetState("plot_video", "none", true);
	}

	// Token: 0x06015B06 RID: 88838 RVA: 0x00649570 File Offset: 0x00647770
	private void ClearSkip()
	{
		this.SetSkipButtonVisible(false);
		PlotSkipComponent skipComp = this.SkipComp;
		if (skipComp != null)
		{
			skipComp.OnClear();
		}
		PlotSkipComponent skipComp2 = this.SkipComp;
		if (skipComp2 != null)
		{
			skipComp2.RemoveEventListener();
		}
		UUIButtonComponent skipButton = this.SkipButton;
		if (skipButton != null)
		{
			skipButton.OnClickCallBack.Unbind();
		}
		this.SkipComp = null;
		this.SkipButton = null;
	}

	// Token: 0x06015B07 RID: 88839 RVA: 0x006495CC File Offset: 0x006477CC
	private void OnSkipCg()
	{
		IVideoParamHub videoParamHub = this.OpenParam as IVideoParamHub;
		if (videoParamHub == null || videoParamHub.SkipType != EVideoSkipType.Normal)
		{
			FlowController.Instance.BackgroundFlow("UI点击跳过(VideoView)", true, false, false);
			return;
		}
		Action skipCallback = videoParamHub.SkipCallback;
		if (skipCallback == null)
		{
			return;
		}
		skipCallback();
	}

	// Token: 0x06015B08 RID: 88840 RVA: 0x00649614 File Offset: 0x00647814
	private void OnPlayVideo(IVideoParamHub param)
	{
		this.OpenParam = param;
		this.InitializeSkip();
		UMediaTexture mediaTexture = this.InitializeMediaPlayer();
		this.ClearCaptionLines();
		this.ApplyPlaybackConfig(param);
		this.ApplyBackgroundColor(mediaTexture, param);
		this.InitializeAspectTransition();
		this.ResetPlaybackState();
		this.IsViewClosed = false;
		this.OnShowVideo();
	}

	// Token: 0x06015B09 RID: 88841 RVA: 0x00649664 File Offset: 0x00647864
	private void OnUiViewPortSizeChanged()
	{
		if (!this.RunningState || this.IsViewClosed || this.MediaPlayer == null || this.CgTexture == null || this.VideoName == null)
		{
			return;
		}
		this.SizeSelfAdaption();
		this.BlendOutRatio = this.CgTexture.GetWidth() / this.CgTexture.GetHeight();
	}

	// Token: 0x06015B0A RID: 88842 RVA: 0x006496C0 File Offset: 0x006478C0
	private void ResumeVideo()
	{
		this.RunningState = true;
		if (this.VideoPauseTime != null)
		{
			if (Info.Instance.PlatformType != ESourcePlatformType.Android && Info.Instance.PlatformType != ESourcePlatformType.OpenHarmony && Info.Instance.PlatformType != ESourcePlatformType.PS5)
			{
				UMediaPlayer mediaPlayer = this.MediaPlayer;
				if (mediaPlayer != null)
				{
					mediaPlayer.Seek(this.VideoPauseTime);
				}
			}
			UMediaPlayer mediaPlayer2 = this.MediaPlayer;
			if (mediaPlayer2 != null)
			{
				mediaPlayer2.Play();
			}
			this.VideoPauseTime = null;
		}
		if (this.VideoName == null || this.VideoPauseTime == null)
		{
			return;
		}
		global::Log.Instance.Info(ELogModule.Audio, ELogAuthor.YJY, "[VideoView] ResumeVideo 当前只绑定返回应用，全部音频已在CPP的返回应用时处理，跳过此处的音频 Resume", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.CaptionTimerId != null && TimerSystem.GameplayTimeInstance.IsPause(this.CaptionTimerId))
		{
			TimerSystem.GameplayTimeInstance.Resume(this.CaptionTimerId);
		}
	}

	// Token: 0x06015B0B RID: 88843 RVA: 0x0064979C File Offset: 0x0064799C
	private void PauseVideo()
	{
		UMediaPlayer mediaPlayer = this.MediaPlayer;
		this.VideoPauseTime = ((mediaPlayer != null) ? mediaPlayer.GetTime() : null);
		this.RunningState = false;
		if (Info.Instance.PlatformType != ESourcePlatformType.Android && Info.Instance.PlatformType != ESourcePlatformType.OpenHarmony && Info.Instance.PlatformType != ESourcePlatformType.PS5)
		{
			UMediaPlayer mediaPlayer2 = this.MediaPlayer;
			if (mediaPlayer2 != null)
			{
				mediaPlayer2.Pause();
			}
		}
		if (string.IsNullOrEmpty(this.VideoName) || this.VideoSoundPlays.Count == 0)
		{
			return;
		}
		global::Log.Instance.Info(ELogModule.Audio, ELogAuthor.YJY, "[VideoView] PauseVideo 当前只绑定切换后台，全部音频已在CPP的切换后台时处理，跳过此处的音频 Pause", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.CaptionTimerId != null && !TimerSystem.GameplayTimeInstance.IsPause(this.CaptionTimerId))
		{
			TimerSystem.GameplayTimeInstance.Pause(this.CaptionTimerId, null);
		}
	}

	// Token: 0x06015B0C RID: 88844 RVA: 0x00649868 File Offset: 0x00647A68
	private void CloseMeInternal()
	{
		bool? remainViewWhenEnd = (this.OpenParam as IVideoParamHub).RemainViewWhenEnd;
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Video;
		ELogAuthor author = ELogAuthor.ZWY;
		string message = "开始关闭VideoView";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bRemain", remainViewWhenEnd);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (!this.HasTriggerBlendOut)
		{
			this.RenderSetup(false);
			this.TryExecuteBlendAnim();
		}
		if (this.PlayStateTimeCheckHandle != null)
		{
			global::Log.Instance.Info(ELogModule.Video, ELogAuthor.ZWY, "MediaPlayer还在倒计时检查状态中,提前移除TimeTimer", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.PlayStateTimeCheckHandle.Remove();
			this.PlayStateTimeCheckHandle = null;
		}
		if (this.PlayStateFrameCheckHandle != null)
		{
			global::Log.Instance.Info(ELogModule.Video, ELogAuthor.ZWY, "MediaPlayer还在倒计时检查状态中,提前移除FrameTimer", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.PlayStateFrameCheckHandle.Remove();
			this.PlayStateFrameCheckHandle = null;
		}
		if (this.PlayLerpHandle != null)
		{
			this.PlayLerpHandle.Remove();
			this.PlayLerpHandle = null;
		}
		this.SetBackgroundColorOut();
		if (!remainViewWhenEnd.GetValueOrDefault())
		{
			if (!this.IsViewClosed)
			{
				base.CloseMe(null);
			}
			this.IsViewClosed = true;
			LevelLoadingController.Instance.CloseLoading(ELoadingReason.CG, null, null, null);
			return;
		}
		this.CleanVideo();
		this.ReleaseSeamlessEndTimeDilationTag();
		IVideoParamHub videoParamHub = this.OpenParam as IVideoParamHub;
		Action action = (videoParamHub != null) ? videoParamHub.VideoCloseCb : null;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x06015B0D RID: 88845 RVA: 0x006499C4 File Offset: 0x00647BC4
	private unsafe void HandleVideoEnd(string source, float? playTime = null)
	{
		if (this.HasHandledVideoEnd)
		{
			return;
		}
		this.HasHandledVideoEnd = true;
		this.IsPlayToEnd = true;
		UMediaPlayer mediaPlayer = this.MediaPlayer;
		if (mediaPlayer != null)
		{
			mediaPlayer.OnEndReached.Remove(new Action(this.OnVideoEnd));
		}
		this.CloseMeInternal();
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Video;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "视频播放结束";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("视频名称", this.VideoName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("source", source);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("playTime", playTime);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x06015B0E RID: 88846 RVA: 0x00649A88 File Offset: 0x00647C88
	private void OnVideoEnd()
	{
		IVideoParamHub videoParamHub = this.OpenParam as IVideoParamHub;
		if (videoParamHub != null && videoParamHub.SeamlessEndOnTick.GetValueOrDefault())
		{
			this.DelaySeamlessEndAfterTimeDilationRelease("OnEndReachedDelayFrame");
			return;
		}
		this.HandleVideoEnd("OnEndReached", null);
	}

	// Token: 0x06015B0F RID: 88847 RVA: 0x00649AD8 File Offset: 0x00647CD8
	private void OnVideoOpenFailed(string _)
	{
		global::Log.Instance.Error(ELogModule.Video, ELogAuthor.ZWY, "视频文件打开失败,可能需要修复修复系统文件", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.CloseMeInternal();
	}

	// Token: 0x06015B10 RID: 88848 RVA: 0x00649B0C File Offset: 0x00647D0C
	private void OnShowVideo()
	{
		if (this.VideoName != null)
		{
			global::Log.Instance.Error(ELogModule.Video, ELogAuthor.ZWY, "必须等上个视频放完才能放下一个", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CloseMeInternal();
			return;
		}
		if (this.OpenParam == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Video;
			ELogAuthor author = ELogAuthor.ZWY;
			string message = "事件被错误触发了";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("名称", EEventName.ShowVideo);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.CloseMeInternal();
			return;
		}
		VideoData videoData = (this.OpenParam as IVideoParamHub).VideoDataConf;
		float aspect = videoData.Aspect;
		float num = UiLayer.Instance.UiRootItem.GetWidth() / UiLayer.Instance.UiRootItem.GetHeight();
		float lastPlotAspect = PlotModel.Instance.LastPlotAspect;
		int lastPlotColor = PlotModel.Instance.LastPlotColor;
		int? currentValue = GameSettingsManager.Instance.GetCurrentValue(EFunction.FlowAdaptation, true, true);
		if (num > 1f && lastPlotAspect != -1f && (double)aspect > 2.3 != (double)lastPlotAspect > 2.3 && lastPlotColor == 0)
		{
			EMovieBackgroundType? backgroundColor = this.BackgroundColor;
			EMovieBackgroundType emovieBackgroundType = EMovieBackgroundType.White;
			if ((backgroundColor.GetValueOrDefault() == emovieBackgroundType & backgroundColor != null) && currentValue != null)
			{
				this.NowAspect = aspect;
				if ((double)this.NowAspect < 2.3)
				{
					this.NowAspect = num;
				}
				this.IsLerp = true;
				this.LerpNowTime = 0f;
				this.PlayLerpHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					this.PlayLerpHandle = null;
					this.PlayVideo(videoData);
				}, this.LerpFullTime, null, null, true, 1f);
				return;
			}
		}
		this.PlayVideo(videoData);
	}

	// Token: 0x06015B11 RID: 88849 RVA: 0x00649CD4 File Offset: 0x00647ED4
	private unsafe void PlayVideo(VideoData videoData)
	{
		if (GameModeModel.Instance.NeedOpenBlackScreenWhenTeleportDungeon)
		{
			LevelLoadingController instance = LevelLoadingController.Instance;
			ELoadingReason reason = ELoadingReason.Common;
			ELoadingPerform perform = ELoadingPerform.CameraFade;
			string context = "PlayVideo_" + videoData.CgName;
			Action callback = null;
			object[] array = new object[6];
			array[0] = 1f;
			int num = 1;
			EMovieBackgroundType? mp4FadeOutScreenColor = GameModeModel.Instance.Mp4FadeOutScreenColor;
			EMovieBackgroundType emovieBackgroundType = EMovieBackgroundType.White;
			array[num] = ((mp4FadeOutScreenColor.GetValueOrDefault() == emovieBackgroundType & mp4FadeOutScreenColor != null) ? EFadeInScreenShowType.White : EFadeInScreenShowType.Black);
			array[2] = false;
			array[3] = false;
			array[5] = true;
			instance.OpenLoading<ELoadingPerform>(reason, perform, context, callback, array);
		}
		this.RenderSetup(true);
		this.IsLerp = false;
		TTimerAction <>9__3;
		this.LoadHandle = ResourceSystem.Instance.LoadAsync<UMediaSource>(videoData.CgFile, delegate([Nullable(2)] UMediaSource mediaSource, string _)
		{
			this.LoadHandle = -1;
			if (mediaSource == null)
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module2 = ELogModule.Video;
				ELogAuthor author2 = ELogAuthor.ZWY;
				string message2 = "mediaSource加载失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("配置名称", videoData.CgName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("视频路径", videoData.CgFile);
				instance3.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				this.CloseMeInternal();
				return;
			}
			this.VideoName = videoData.CgName;
			this.ClearCaptionLines();
			IVideoParamHub videoParamHub = this.OpenParam as IVideoParamHub;
			bool flag = !GameModeModel.Instance.PlayTravelMp4 && (PlotModel.Instance.IsGmCanSkip || videoData.CanSkip);
			if (videoParamHub != null && videoParamHub.SkipType == EVideoSkipType.Normal)
			{
				this.SetSkipButtonVisible(flag);
			}
			else
			{
				FlowController.Instance.EnableSkip(flag);
			}
			this.CaptionDataList = new List<VideoSubtitle>(VideoConfig.Instance.GetVideoCaptions(this.VideoName, LanguageSystem.Instance.PackageAudio));
			this.CaptionDataList.Sort((VideoSubtitle a, VideoSubtitle b) => b.ShowMoment.CompareTo(a.ShowMoment));
			this.QteDataList = new List<VideoQteConfig>(VideoConfig.Instance.GetVideoQte(this.VideoName, LanguageSystem.Instance.PackageAudio));
			this.QteDataList.Sort((VideoQteConfig a, VideoQteConfig b) => b.ShowMoment.CompareTo(a.ShowMoment));
			this.MediaPlayer.OnEndReached.Add(new Action(this.OnVideoEnd));
			this.MediaPlayer.OnMediaOpened.Add(new Action<string>(this.OnMediaOpen));
			this.MediaPlayer.OnMediaOpenFailed.Add(new Action<string>(this.OnVideoOpenFailed));
			bool flag2 = PreloadModelNew.Instance.PlotAssetManager.HasPreloadVideo(videoData.CgFile);
			if (flag2)
			{
				if (this.MediaPlayer.Play())
				{
					this.OnMediaOpen(null);
				}
				else
				{
					global::Log instance4 = global::Log.Instance;
					ELogModule module3 = ELogModule.Video;
					ELogAuthor author3 = ELogAuthor.ZWY;
					string message3 = "预加载的视频播放失败，等待Open回调";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("配置名称", videoData.CgName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("视频路径", videoData.CgFile);
					instance4.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				}
			}
			else
			{
				this.MediaPlayer.PlayOnOpen = false;
				if (!this.MediaPlayer.OpenSource(mediaSource))
				{
					global::Log instance5 = global::Log.Instance;
					ELogModule module4 = ELogModule.Video;
					ELogAuthor author4 = ELogAuthor.ZWY;
					string message4 = "打开视频失败";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("配置名称", videoData.CgName);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("视频路径", videoData.CgFile);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("hasPreload", flag2);
					instance5.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
					this.CloseMeInternal();
					return;
				}
			}
			AudioSystem.Instance.SetState("plot_video", "playing", true);
			EventSystem.Instance.Emit<string>(EEventName.VideoStart, this.VideoName);
			int frameTime = Time.Instance.Frame;
			VideoView <>4__this = this;
			TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
			TTimerAction action;
			if ((action = <>9__3) == null)
			{
				action = (<>9__3 = delegate(float _)
				{
					TimerHandle playStateTimeCheckHandle = this.PlayStateTimeCheckHandle;
					if (playStateTimeCheckHandle != null)
					{
						playStateTimeCheckHandle.Remove();
					}
					this.PlayStateTimeCheckHandle = null;
					if (this.MediaPlayer == null)
					{
						global::Log.Instance.Warn(ELogModule.Video, ELogAuthor.ZWY, "MediaPlayer已经没有了", default(ReadOnlySpan<ValueTuple<string, object>>));
						return;
					}
					if (this.MediaPlayer.IsPlaying() || this.MediaPlayer.IsPaused())
					{
						if (this.PlayStateFrameCheckHandle == null)
						{
							this.SetBackgroundColorOut();
						}
						return;
					}
					if (this.PlayStateFrameCheckHandle == null)
					{
						global::Log instance6 = global::Log.Instance;
						ELogModule module5 = ELogModule.Video;
						ELogAuthor author5 = ELogAuthor.JYS;
						string message5 = "MediaPlayer加载了5秒超时，强制关闭CG界面";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("配置名称", videoData.CgName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("视频路径", videoData.CgFile);
						instance6.Warn(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 2));
						this.CloseMeInternal();
					}
				});
			}
			<>4__this.PlayStateTimeCheckHandle = gameplayTimeInstance.Delay(action, 5000f, null, null, true, 1f);
			this.PlayStateFrameCheckHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				if (Time.Instance.Frame - frameTime >= 30)
				{
					TimerHandle playStateFrameCheckHandle = this.PlayStateFrameCheckHandle;
					if (playStateFrameCheckHandle != null)
					{
						playStateFrameCheckHandle.Remove();
					}
					this.PlayStateFrameCheckHandle = null;
					if (this.MediaPlayer == null)
					{
						global::Log.Instance.Warn(ELogModule.Video, ELogAuthor.ZWY, "MediaPlayer已经没有了", default(ReadOnlySpan<ValueTuple<string, object>>));
						return;
					}
					if (this.MediaPlayer.IsPlaying() || this.MediaPlayer.IsPaused())
					{
						if (this.PlayStateTimeCheckHandle == null)
						{
							this.SetBackgroundColorOut();
						}
						return;
					}
					if (this.PlayStateTimeCheckHandle == null)
					{
						global::Log instance6 = global::Log.Instance;
						ELogModule module5 = ELogModule.Video;
						ELogAuthor author5 = ELogAuthor.JYS;
						string message5 = "MediaPlayer加载了5秒超时，强制关闭CG界面";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("配置名称", videoData.CgName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("视频路径", videoData.CgFile);
						instance6.Warn(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 2));
						this.CloseMeInternal();
					}
				}
			}, 1000f, 1f, null, null, true);
		}, 100, "js_undefined");
		if (this.LoadHandle < 0)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module = ELogModule.Video;
			ELogAuthor author = ELogAuthor.ZWY;
			string message = "mediaSource加载失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("配置名称", videoData.CgName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("视频路径", videoData.CgFile);
			instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.CloseMeInternal();
		}
	}

	// Token: 0x06015B12 RID: 88850 RVA: 0x00649E34 File Offset: 0x00648034
	[NullableContext(2)]
	private void OnMediaOpen(string _)
	{
		this.VideoSoundPlays.Clear();
		this.PendingVideoSounds.Clear();
		this.SubtitleVoicePlays.Clear();
		if (this.VideoName != null)
		{
			foreach (VideoSound soundConf in VideoConfig.Instance.GetVideoSounds(this.VideoName))
			{
				if (soundConf.StartMoment == 0f)
				{
					this.PlayVideoSound(soundConf);
				}
				else
				{
					this.PendingVideoSounds.Add(new PendingVideoSound(soundConf, (double)(soundConf.StartMoment * 1000f)));
				}
			}
			this.PendingVideoSounds.Sort(delegate(PendingVideoSound a, PendingVideoSound b)
			{
				if (b.StartMomentMs - a.StartMomentMs <= 0.0)
				{
					return -1;
				}
				return 1;
			});
		}
		this.SizeSelfAdaption();
		this.SourceLength = UKismetMathLibrary.GetTotalMilliseconds(this.MediaPlayer.GetDuration());
		this.BlendOutRatio = this.CgTexture.GetWidth() / this.CgTexture.GetHeight();
		this.RunningState = true;
		this.MediaPlayer.Play();
		this.TickPlayback();
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Video;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "监听到Open回调，视频播放开始";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("视频名称", this.VideoName);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06015B13 RID: 88851 RVA: 0x00649F94 File Offset: 0x00648194
	private void PlayVideoSound(VideoSound soundConf)
	{
		string eventName = AudioSystem.Instance.parseAudioEventPath(soundConf.EventPath);
		if (string.IsNullOrEmpty(eventName))
		{
			return;
		}
		int startMomentMs = (soundConf.StartMoment < 0f) ? 0 : ((int)(soundConf.StartMoment * 1000f));
		bool hasSynced = false;
		int handle = 0;
		handle = AudioSystem.Instance.PostEvent(eventName, null, new PostEventArgs?(new PostEventArgs
		{
			CallbackMask = new ECallbackMask?(ECallbackMask.Duration),
			CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
			{
				if (callbackType != EAkCallbackType.Duration | hasSynced)
				{
					return;
				}
				hasSynced = true;
				this.SyncVideoSoundOnce(eventName, handle, startMomentMs, ((UAkDurationCallbackInfo)callbackInfo).Duration);
			}
		}));
		if (handle == 0)
		{
			return;
		}
		int num = (soundConf.EndMoment < 0f) ? -1 : ((int)(soundConf.EndMoment * 1000f));
		this.VideoSoundPlays.Add(new VideoSoundPlay(handle, (double)num));
		this.VideoSoundPlays.Sort(delegate(VideoSoundPlay a, VideoSoundPlay b)
		{
			if (b.EndMomentMs - a.EndMomentMs <= 0.0)
			{
				return -1;
			}
			return 1;
		});
	}

	// Token: 0x06015B14 RID: 88852 RVA: 0x0064A0B8 File Offset: 0x006482B8
	private unsafe void SyncVideoSoundOnce(string eventName, int handle, int startMomentMs, float audioDurationMs)
	{
		if (this.IsViewClosed || !this.RunningState || this.MediaPlayer == null)
		{
			return;
		}
		float totalMilliseconds = UKismetMathLibrary.GetTotalMilliseconds(this.MediaPlayer.GetTime());
		float num = totalMilliseconds - (float)startMomentMs;
		if (num < 200f)
		{
			return;
		}
		if (audioDurationMs > 0f && num >= audioDurationMs)
		{
			return;
		}
		AudioSystem.Instance.SeekOnEvent(eventName, (int)num, new SeekOnEventArgs?(new SeekOnEventArgs
		{
			Handle = new int?(handle)
		}));
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Video;
		ELogAuthor author = ELogAuthor.FZX;
		string message = "视频主音轨起播延迟，已Seek对齐";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("eventName", eventName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("delayMs", num);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("playTime", totalMilliseconds);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x06015B15 RID: 88853 RVA: 0x0064A1AC File Offset: 0x006483AC
	private unsafe void TryPlaySubtitleVoice(VideoSubtitle caption)
	{
		if (!caption.IsPlaySubtitleVoice)
		{
			return;
		}
		PlotAudio? config = ConfigPlotAudioById.GetConfig(caption.CaptionText, true);
		if (config == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Video;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "字幕跟随语音找不到剧情语音配置";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("captionId", caption.CaptionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("captionText", caption.CaptionText);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(config.Value);
		int handle = 0;
		handle = AudioSystem.Instance.PostEvent("play_external_vo_video_subtitle_level_b", null, new PostEventArgs?(new PostEventArgs
		{
			ExternalSourceName = "vo_video_subtitle_level_b",
			ExternalSourceMediaName = externalSourcesMediaName,
			CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
			CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo _)
			{
				if (callbackType == EAkCallbackType.EndOfEvent)
				{
					int num = this.SubtitleVoicePlays.IndexOf(handle);
					if (num >= 0)
					{
						this.SubtitleVoicePlays.RemoveAt(num);
					}
				}
			}
		}));
		if (handle == 0)
		{
			return;
		}
		this.SubtitleVoicePlays.Add(handle);
	}

	// Token: 0x06015B16 RID: 88854 RVA: 0x0064A2D8 File Offset: 0x006484D8
	private void StopAllSubtitleVoices()
	{
		foreach (int handle in this.SubtitleVoicePlays)
		{
			AudioSystem.Instance.ExecuteAction(handle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
			{
				TransitionDuration = new int?(0)
			}));
		}
		this.SubtitleVoicePlays.Clear();
	}

	// Token: 0x06015B17 RID: 88855 RVA: 0x0064A358 File Offset: 0x00648558
	private void SizeSelfAdaption()
	{
		float videoTrackAspectRatio = this.MediaPlayer.GetVideoTrackAspectRatio(0, 0);
		float num = UiLayer.Instance.UiRootItem.GetWidth() / UiLayer.Instance.UiRootItem.GetHeight();
		int? currentValue = GameSettingsManager.Instance.GetCurrentValue(EFunction.FlowAdaptation, true, true);
		if (videoTrackAspectRatio < num)
		{
			float height = UiLayer.Instance.UiRootItem.GetWidth() / videoTrackAspectRatio;
			this.CgTexture.SetHeight(height);
			this.CgTexture.SetWidth(UiLayer.Instance.UiRootItem.GetWidth());
			if ((double)num > 2.38 && currentValue != null)
			{
				float width = UiLayer.Instance.UiRootItem.GetHeight() * videoTrackAspectRatio;
				this.CgTexture.SetWidth(width);
				this.CgTexture.SetHeight(UiLayer.Instance.UiRootItem.GetHeight());
			}
		}
		else if (videoTrackAspectRatio > num)
		{
			float width2 = UiLayer.Instance.UiRootItem.GetHeight() * videoTrackAspectRatio;
			this.CgTexture.SetWidth(width2);
			this.CgTexture.SetHeight(UiLayer.Instance.UiRootItem.GetHeight());
		}
		else
		{
			this.CgTexture.SetWidth(UiLayer.Instance.UiRootItem.GetWidth());
			this.CgTexture.SetHeight(UiLayer.Instance.UiRootItem.GetHeight());
		}
		if ((double)videoTrackAspectRatio > 2.3 && currentValue != null)
		{
			if (videoTrackAspectRatio < num)
			{
				float width3 = UiLayer.Instance.UiRootItem.GetHeight() * videoTrackAspectRatio;
				this.CgTexture.SetWidth(width3);
				this.CgTexture.SetHeight(UiLayer.Instance.UiRootItem.GetHeight());
			}
			else if (videoTrackAspectRatio > num)
			{
				float height2 = UiLayer.Instance.UiRootItem.GetWidth() / videoTrackAspectRatio;
				this.CgTexture.SetHeight(height2);
				this.CgTexture.SetWidth(UiLayer.Instance.UiRootItem.GetWidth());
			}
		}
		PlotModel.Instance.LastPlotAspect = videoTrackAspectRatio;
		if (currentValue != null)
		{
			BlackScreenFadeController.Instance.ChangeAspect(PlotModel.Instance.LastPlotAspect, new bool?(true));
		}
		PlotModel instance = PlotModel.Instance;
		EMovieBackgroundType? backgroundColor = this.BackgroundColor;
		EMovieBackgroundType emovieBackgroundType = EMovieBackgroundType.White;
		instance.LastPlotColor = ((!(backgroundColor.GetValueOrDefault() == emovieBackgroundType & backgroundColor != null)) ? 1 : 0);
	}

	// Token: 0x06015B18 RID: 88856 RVA: 0x0064A5A4 File Offset: 0x006487A4
	private void ClearCaptionLines()
	{
		for (int i = 0; i < this.CaptionLines.Length; i++)
		{
			this.CaptionLines[i] = null;
			UUIText text = base.GetText((int)this.CaptionLineComponents[i]);
			if (text != null)
			{
				text.SetUIActive(false);
			}
		}
	}

	// Token: 0x06015B19 RID: 88857 RVA: 0x0064A5E8 File Offset: 0x006487E8
	private void ShowCaptionTick(float playTime)
	{
		for (int i = 0; i < this.CaptionLines.Length; i++)
		{
			VideoSubtitle videoSubtitle = this.CaptionLines[i];
			if (videoSubtitle != null)
			{
				float num = (float)(videoSubtitle.ShowMoment + videoSubtitle.Duration) * VideoUtils.MillisecondPerFrame;
				if (playTime > num)
				{
					this.CaptionLines[i] = null;
					base.GetText((int)this.CaptionLineComponents[i]).SetUIActive(false);
				}
			}
		}
		if (this.CaptionDataList == null || this.CaptionDataList.Count == 0)
		{
			return;
		}
		while (this.CaptionDataList.Count > 0)
		{
			VideoSubtitle videoSubtitle2 = this.CaptionDataList[this.CaptionDataList.Count - 1];
			float num2 = (float)(videoSubtitle2.ShowMoment + videoSubtitle2.Duration) * VideoUtils.MillisecondPerFrame;
			if (playTime > num2)
			{
				this.CaptionDataList.RemoveAt(this.CaptionDataList.Count - 1);
			}
			else
			{
				float num3 = (float)videoSubtitle2.ShowMoment * VideoUtils.MillisecondPerFrame;
				if (playTime < num3)
				{
					break;
				}
				int num4 = Array.IndexOf<VideoSubtitle>(this.CaptionLines, null);
				if (num4 < 0)
				{
					num4 = ((this.CaptionLines[0].ShowMoment > this.CaptionLines[1].ShowMoment) ? 1 : 0);
				}
				this.CaptionDataList.RemoveAt(this.CaptionDataList.Count - 1);
				this.CaptionLines[num4] = videoSubtitle2;
				UUIText text = base.GetText((int)this.CaptionLineComponents[num4]);
				string videoCaptionText = VideoConfig.Instance.GetVideoCaptionText(videoSubtitle2);
				text.SetUIActive(true);
				text.SetText(videoCaptionText, true);
				this.TryPlaySubtitleVoice(videoSubtitle2);
			}
		}
	}

	// Token: 0x06015B1A RID: 88858 RVA: 0x0064A764 File Offset: 0x00648964
	private void ShowQte(float playTime)
	{
		if (this.QteDataList == null || this.QteDataList.Count == 0)
		{
			return;
		}
		while (this.QteDataList.Count > 0)
		{
			VideoQteConfig videoQteConfig = this.QteDataList[this.QteDataList.Count - 1];
			float num = (float)videoQteConfig.ShowMoment * VideoUtils.MillisecondPerFrame;
			if (playTime < num)
			{
				break;
			}
			CommonQteContextBase commonQteContextBase = CommonQteController.Instance.StartQte(videoQteConfig.QteId, new TCommonQteCallback(this.OnQteEnd), new TCommonQteCallback(this.OnQteEnd), EQteSource.CG, null);
			if (commonQteContextBase != null)
			{
				this.CurrentQte.Add(commonQteContextBase);
				float timeDilation = commonQteContextBase.Config.BaseConfig.TimeDilation;
				this.MediaPlayer.SetRate(timeDilation);
			}
			this.QteDataList.RemoveAt(this.QteDataList.Count - 1);
		}
	}

	// Token: 0x06015B1B RID: 88859 RVA: 0x0064A83A File Offset: 0x00648A3A
	[NullableContext(2)]
	private void OnQteEnd(CommonQteContextBase context = null)
	{
		UMediaPlayer mediaPlayer = this.MediaPlayer;
		if (mediaPlayer != null)
		{
			mediaPlayer.SetRate(1f);
		}
		if (context != null)
		{
			this.CurrentQte.Remove(context);
		}
	}

	// Token: 0x06015B1C RID: 88860 RVA: 0x0064A864 File Offset: 0x00648A64
	private void SetBackgroundColorOut()
	{
		if (GameModeModel.Instance.Mp4FadeOutScreenColor != null)
		{
			this.BackgroundColor = GameModeModel.Instance.Mp4FadeOutScreenColor;
		}
		else
		{
			IVideoParamHub videoParamHub = this.OpenParam as IVideoParamHub;
			EMovieBackgroundType? backgroundColor;
			if (videoParamHub == null)
			{
				backgroundColor = null;
			}
			else
			{
				IMovieBackgroundFadeData backgroundColor2 = videoParamHub.BackgroundColor;
				backgroundColor = ((backgroundColor2 != null) ? new EMovieBackgroundType?(backgroundColor2.FadeOutBackgroundType) : null);
			}
			this.BackgroundColor = backgroundColor;
		}
		FLinearColor? flinearColor = null;
		bool flag = true;
		EMovieBackgroundType? backgroundColor3 = this.BackgroundColor;
		if (backgroundColor3 != null)
		{
			EMovieBackgroundType valueOrDefault = backgroundColor3.GetValueOrDefault();
			if (valueOrDefault == EMovieBackgroundType.White)
			{
				flinearColor = new FLinearColor?(new FLinearColor(1f, 1f, 1f, 1f));
				flag = LevelLoadingController.Instance.CameraFade.SetColor(EFadeInScreenShowType.White);
				goto IL_115;
			}
			if (valueOrDefault == EMovieBackgroundType.Black)
			{
				flinearColor = new FLinearColor?(new FLinearColor(0f, 0f, 0f, 1f));
				flag = LevelLoadingController.Instance.CameraFade.SetColor(EFadeInScreenShowType.Black);
				goto IL_115;
			}
		}
		flinearColor = new FLinearColor?(new FLinearColor(0f, 0f, 0f, 1f));
		IL_115:
		if (!flag)
		{
			global::Log.Instance.Warn(ELogModule.Video, ELogAuthor.FZX, "[VideoView] 当前未开启黑幕界面，继承颜色失败", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		(this.CgTexture.GetTexture() as UMediaTexture).ClearColor = flinearColor.Value;
	}

	// Token: 0x06015B1D RID: 88861 RVA: 0x0064A9C8 File Offset: 0x00648BC8
	private unsafe void DelaySeamlessEndAfterTimeDilationRelease(string endSource)
	{
		if (this.HasHandledVideoEnd)
		{
			return;
		}
		this.RunningState = false;
		UMediaPlayer mediaPlayer = this.MediaPlayer;
		if (mediaPlayer != null)
		{
			mediaPlayer.OnEndReached.Remove(new Action(this.OnVideoEnd));
		}
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("VideoView.SeamlessEnd");
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Video;
		ELogAuthor author = ELogAuthor.FZX;
		string message = "无缝视频结束时补偿恢复时停";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("source", endSource);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("sourceLength", this.SourceLength);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.HasSeamlessReleasedTimeDilation = true;
		this.SeamlessEndDelayHandle = TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			this.SeamlessEndDelayHandle = null;
			this.HandleVideoEnd(endSource, new float?(0f));
		}, null, null);
	}

	// Token: 0x06015B1E RID: 88862 RVA: 0x0064AAB4 File Offset: 0x00648CB4
	private void RemoveSeamlessEndDelayHandle()
	{
		if (this.SeamlessEndDelayHandle != null && TimerSystem.GameplayTimeInstance.Has(this.SeamlessEndDelayHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.SeamlessEndDelayHandle);
		}
		this.SeamlessEndDelayHandle = null;
	}

	// Token: 0x06015B1F RID: 88863 RVA: 0x0064AAE8 File Offset: 0x00648CE8
	private void ReleaseSeamlessEndTimeDilationTag()
	{
		if (!this.HasSeamlessReleasedTimeDilation)
		{
			return;
		}
		this.HasSeamlessReleasedTimeDilation = false;
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("VideoView.SeamlessEnd");
	}

	// Token: 0x06015B20 RID: 88864 RVA: 0x0064AB0C File Offset: 0x00648D0C
	private void TickPlayback()
	{
		float totalMilliseconds = UKismetMathLibrary.GetTotalMilliseconds(this.MediaPlayer.GetTime());
		this.ShowCaptionTick(totalMilliseconds);
		this.ShowQte(totalMilliseconds);
		this.TickVideoSounds(totalMilliseconds);
		this.TickFadeOut(totalMilliseconds);
		VideoLauncher.OnCheckFrameEvent((int)totalMilliseconds);
	}

	// Token: 0x06015B21 RID: 88865 RVA: 0x0064AB50 File Offset: 0x00648D50
	private void TickVideoSounds(float playTime)
	{
		while (this.PendingVideoSounds.Count > 0)
		{
			PendingVideoSound pendingVideoSound = this.PendingVideoSounds[this.PendingVideoSounds.Count - 1];
			if ((double)playTime < pendingVideoSound.StartMomentMs)
			{
				IL_CF:
				while (this.VideoSoundPlays.Count > 0)
				{
					List<VideoSoundPlay> videoSoundPlays = this.VideoSoundPlays;
					VideoSoundPlay videoSoundPlay = videoSoundPlays[videoSoundPlays.Count - 1];
					if (videoSoundPlay.EndMomentMs < 0.0 || (double)playTime < videoSoundPlay.EndMomentMs)
					{
						break;
					}
					AudioSystem.Instance.ExecuteAction(videoSoundPlay.Handle, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
					{
						TransitionDuration = new int?(0)
					}));
					this.VideoSoundPlays.RemoveAt(this.VideoSoundPlays.Count - 1);
				}
				return;
			}
			this.PendingVideoSounds.RemoveAt(this.PendingVideoSounds.Count - 1);
			this.PlayVideoSound(pendingVideoSound.SoundConf);
		}
		goto IL_CF;
	}

	// Token: 0x06015B22 RID: 88866 RVA: 0x0064AC40 File Offset: 0x00648E40
	private void TickFadeOut(float playTime)
	{
		if (this.Mp4FadeOutTime > 0f && this.SourceLength - playTime <= this.Mp4FadeOutTime)
		{
			this.TriggerBlendOut();
			base.GetRootItem().SetAlpha(MathUtils.Instance.GetRangePct(0f, this.Mp4FadeOutTime, this.SourceLength - playTime));
		}
	}

	// Token: 0x06015B23 RID: 88867 RVA: 0x0064AC98 File Offset: 0x00648E98
	private void TickAspectTransition(float delta)
	{
		if (this.IsLerp)
		{
			this.LerpNowTime += delta;
			if (this.LerpNowTime > this.LerpWaitTime)
			{
				float rangePct = MathUtils.Instance.GetRangePct(0f, this.LerpFullTime - this.LerpWaitTime, this.LerpNowTime - this.LerpWaitTime);
				float aspect = this.LastAspect + (this.NowAspect - this.LastAspect) * rangePct;
				this.SetAspect(aspect);
			}
		}
	}

	// Token: 0x06015B24 RID: 88868 RVA: 0x0064AD14 File Offset: 0x00648F14
	private void TriggerBlendOut()
	{
		if (this.HasTriggerBlendOut)
		{
			return;
		}
		this.HasTriggerBlendOut = true;
		PlotModel.Instance.PlotAspectTransformView.SetAspectRatio(this.BlendOutRatio);
		GameSettingsDeviceRender.Instance.CancelAllPerformanceLimit();
		EventSystem.Instance.Emit<string>(EEventName.VideoTriggerBlendOut, this.VideoName);
		this.RenderSetup(false);
		this.TryExecuteBlendAnim();
		LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, "VideoView_TriggerBlendOut", delegate
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag("VideoView.TriggerBlendOut");
		}, new float?(0f));
	}

	// Token: 0x06015B25 RID: 88869 RVA: 0x0064ADAC File Offset: 0x00648FAC
	private void TryExecuteBlendAnim()
	{
		if (PlotBlendController.Instance.HasBlendInfo)
		{
			IVideoParamHub videoParamHub = this.OpenParam as IVideoParamHub;
			if (videoParamHub != null && videoParamHub != null)
			{
				VideoData videoDataConf = videoParamHub.VideoDataConf;
				PlotBlendController.Instance.TryExecuteBlend(videoParamHub.VideoDataConf.CgName).Forget<bool>();
			}
		}
	}

	// Token: 0x06015B26 RID: 88870 RVA: 0x0064ADFC File Offset: 0x00648FFC
	private void RenderSetup(bool isApply)
	{
		bool flag;
		if (GameSettingsManager.Instance.GetCurrentValue(EFunction.RayTracing, true, true) == null)
		{
			flag = false;
		}
		else
		{
			int? currentValue = GameSettingsManager.Instance.GetCurrentValue(EFunction.RayTracing, true, true);
			int num = 0;
			flag = (currentValue.GetValueOrDefault() > num & currentValue != null);
		}
		bool flag2 = flag;
		if (isApply)
		{
			if (flag2)
			{
				GameSettingsUtils.ApplyRayTracedGI(0);
				GameSettingsUtils.ApplyRayTracedReflection(0);
				GameSettingsUtils.ApplyRayTracedShadow(0);
				return;
			}
		}
		else if (flag2)
		{
			GameSettingsManager.Instance.ReApply(EFunction.RayTracedGI, EGameSettingsApplyReason.AnyTime, true);
			GameSettingsManager.Instance.ReApply(EFunction.RayTracedReflection, EGameSettingsApplyReason.AnyTime, true);
			GameSettingsManager.Instance.ReApply(EFunction.RayTracedShadow, EGameSettingsApplyReason.AnyTime, true);
		}
	}

	// Token: 0x0400B700 RID: 46848
	private const string SeamlessEndTimeDilationTag = "VideoView.SeamlessEnd";

	// Token: 0x0400B701 RID: 46849
	private const string SubtitleVoiceEvent = "play_external_vo_video_subtitle_level_b";

	// Token: 0x0400B702 RID: 46850
	private const string SubtitleVoiceExternalSourceName = "vo_video_subtitle_level_b";

	// Token: 0x0400B703 RID: 46851
	private const int VIDEO_SOUND_SYNC_MIN_DELAY_MS = 200;

	// Token: 0x0400B704 RID: 46852
	[Nullable(2)]
	private UUITexture CgTexture;

	// Token: 0x0400B705 RID: 46853
	[Nullable(2)]
	private UMediaPlayer MediaPlayer;

	// Token: 0x0400B706 RID: 46854
	[Nullable(2)]
	private UUIButtonComponent SkipButton;

	// Token: 0x0400B707 RID: 46855
	[Nullable(2)]
	private PlotSkipComponent SkipComp;

	// Token: 0x0400B708 RID: 46856
	private int LoadHandle = -1;

	// Token: 0x0400B709 RID: 46857
	[Nullable(2)]
	private string VideoName;

	// Token: 0x0400B70A RID: 46858
	[Nullable(2)]
	private FTimespan VideoPauseTime;

	// Token: 0x0400B70B RID: 46859
	private float SourceLength;

	// Token: 0x0400B70C RID: 46860
	private bool RunningState;

	// Token: 0x0400B70D RID: 46861
	private bool IsPlayToEnd;

	// Token: 0x0400B70E RID: 46862
	private bool HasHandledVideoEnd;

	// Token: 0x0400B70F RID: 46863
	private bool IsViewClosed = true;

	// Token: 0x0400B710 RID: 46864
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<VideoSubtitle> CaptionDataList;

	// Token: 0x0400B711 RID: 46865
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<VideoQteConfig> QteDataList;

	// Token: 0x0400B712 RID: 46866
	private readonly EVideoView[] CaptionLineComponents = new EVideoView[]
	{
		EVideoView.CaptionText,
		EVideoView.CaptionText2
	};

	// Token: 0x0400B713 RID: 46867
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly VideoSubtitle[] CaptionLines = new VideoSubtitle[2];

	// Token: 0x0400B714 RID: 46868
	private readonly HashSet<CommonQteContextBase> CurrentQte = new HashSet<CommonQteContextBase>();

	// Token: 0x0400B715 RID: 46869
	[Nullable(2)]
	private TimerHandle CaptionTimerId;

	// Token: 0x0400B716 RID: 46870
	private List<VideoSoundPlay> VideoSoundPlays = new List<VideoSoundPlay>();

	// Token: 0x0400B717 RID: 46871
	private List<PendingVideoSound> PendingVideoSounds = new List<PendingVideoSound>();

	// Token: 0x0400B718 RID: 46872
	private readonly List<int> SubtitleVoicePlays = new List<int>();

	// Token: 0x0400B719 RID: 46873
	[Nullable(2)]
	private TimerHandle PlayStateTimeCheckHandle;

	// Token: 0x0400B71A RID: 46874
	[Nullable(2)]
	private TimerHandle PlayStateFrameCheckHandle;

	// Token: 0x0400B71B RID: 46875
	[Nullable(2)]
	private TimerHandle PlayLerpHandle;

	// Token: 0x0400B71C RID: 46876
	[Nullable(2)]
	private TimerHandle SeamlessEndDelayHandle;

	// Token: 0x0400B71D RID: 46877
	private float LerpFullTime = 4000f;

	// Token: 0x0400B71E RID: 46878
	private float LerpWaitTime = 1000f;

	// Token: 0x0400B71F RID: 46879
	private float LerpNowTime;

	// Token: 0x0400B720 RID: 46880
	private bool IsLerp;

	// Token: 0x0400B721 RID: 46881
	private float NowAspect;

	// Token: 0x0400B722 RID: 46882
	private float LastAspect;

	// Token: 0x0400B723 RID: 46883
	private EMovieBackgroundType? BackgroundColor = new EMovieBackgroundType?(EMovieBackgroundType.Black);

	// Token: 0x0400B724 RID: 46884
	protected float Mp4FadeOutTime;

	// Token: 0x0400B725 RID: 46885
	protected float BlackBorderFadeOutTime;

	// Token: 0x0400B726 RID: 46886
	private float BlendOutRatio;

	// Token: 0x0400B727 RID: 46887
	private bool HasTriggerBlendOut;

	// Token: 0x0400B728 RID: 46888
	private bool HasChangeColor;

	// Token: 0x0400B729 RID: 46889
	private bool HasSeamlessReleasedTimeDilation;
}
