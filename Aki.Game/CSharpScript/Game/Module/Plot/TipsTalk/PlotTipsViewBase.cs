using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.TipsTalk
{
	// Token: 0x02005010 RID: 20496
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTipsViewBase : UiPanelBase
	{
		// Token: 0x06034719 RID: 214809 RVA: 0x00C59BC4 File Offset: 0x00C57DC4
		[NullableContext(0)]
		public UniTask<bool> OpenAsync([Nullable(1)] UiParam param)
		{
			PlotTipsViewBase.<OpenAsync>d__18 <OpenAsync>d__;
			<OpenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenAsync>d__.<>4__this = this;
			<OpenAsync>d__.param = param;
			<OpenAsync>d__.<>1__state = -1;
			<OpenAsync>d__.<>t__builder.Start<PlotTipsViewBase.<OpenAsync>d__18>(ref <OpenAsync>d__);
			return <OpenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603471A RID: 214810 RVA: 0x00C59C0F File Offset: 0x00C57E0F
		protected virtual UUIItem GetParentItem()
		{
			return UiLayer.Instance.GetLayerRootUiItem(ELayerType.HUD);
		}

		// Token: 0x0603471B RID: 214811 RVA: 0x00C59C1C File Offset: 0x00C57E1C
		public UniTask CloseAsync()
		{
			PlotTipsViewBase.<CloseAsync>d__20 <CloseAsync>d__;
			<CloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseAsync>d__.<>4__this = this;
			<CloseAsync>d__.<>1__state = -1;
			<CloseAsync>d__.<>t__builder.Start<PlotTipsViewBase.<CloseAsync>d__20>(ref <CloseAsync>d__);
			return <CloseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603471C RID: 214812 RVA: 0x00C59C5F File Offset: 0x00C57E5F
		[NullableContext(1)]
		public void RefreshSubtitle(ITalkItem talkItem)
		{
			this.UpdatePlotSubtitle(talkItem);
		}

		// Token: 0x0603471D RID: 214813 RVA: 0x00C59C68 File Offset: 0x00C57E68
		protected virtual void OnInit()
		{
		}

		// Token: 0x0603471E RID: 214814 RVA: 0x00C59C6C File Offset: 0x00C57E6C
		private void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.UpdatePlotSubtitle, new Action<ITalkItem>(this.UpdatePlotSubtitle));
			EventSystem.Instance.Add(EEventName.HidePlotUi, new Action<bool>(this.HideAll));
			EventSystem.Instance.Add<bool>(EEventName.HangPlotViewHud, new Action<bool>(this.OnHangPlotViewHud));
			EventSystem.Instance.Add(EEventName.ClearPlotSubtitle, new Action(this.ClearPlotSubtitle));
		}

		// Token: 0x0603471F RID: 214815 RVA: 0x00C59CEC File Offset: 0x00C57EEC
		private void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.UpdatePlotSubtitle, new Action<ITalkItem>(this.UpdatePlotSubtitle));
			EventSystem.Instance.Remove(EEventName.HidePlotUi, new Action<bool>(this.HideAll));
			EventSystem.Instance.Remove(EEventName.HangPlotViewHud, new Action<bool>(this.OnHangPlotViewHud));
			EventSystem.Instance.Remove(EEventName.ClearPlotSubtitle, new Action(this.ClearPlotSubtitle));
		}

		// Token: 0x06034720 RID: 214816 RVA: 0x00C59D6C File Offset: 0x00C57F6C
		protected override UniTask OnCreateAsync()
		{
			PlotTipsViewBase.<OnCreateAsync>d__25 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<PlotTipsViewBase.<OnCreateAsync>d__25>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034721 RID: 214817 RVA: 0x00C59DB0 File Offset: 0x00C57FB0
		protected override void OnStart()
		{
			this.OnInit();
			if (PlotModel.Instance.CurTalkItem != null)
			{
				this.UpdatePlotSubtitle(PlotModel.Instance.CurTalkItem);
			}
			this.LevelSequencePlayer = new LevelSequencePlayer(this.GetOriginalItem());
			this.CurLang = LanguageSystem.Instance.PackageAudio;
		}

		// Token: 0x06034722 RID: 214818 RVA: 0x00C59E00 File Offset: 0x00C58000
		protected override void OnAfterShow()
		{
			this.OnAddEventListener();
			this.OnHang(PlotModel.Instance.HangViewHud, false);
		}

		// Token: 0x06034723 RID: 214819 RVA: 0x00C59E19 File Offset: 0x00C58019
		protected override void OnBeforeHide()
		{
			this.OnRemoveEventListener();
			if (!this.LastHide)
			{
				this.OnHang(true, false);
			}
		}

		// Token: 0x06034724 RID: 214820 RVA: 0x00C59E31 File Offset: 0x00C58031
		protected override void OnBeforeDestroy()
		{
			this.TextureCache.Clear();
			this.ClearPlotSubtitle();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			FlowController.Instance.CountDownSkip(false);
		}

		// Token: 0x06034725 RID: 214821 RVA: 0x00C59E60 File Offset: 0x00C58060
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PlotTipsViewBase.<OnShowAsyncImplementImplement>d__30 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PlotTipsViewBase.<OnShowAsyncImplementImplement>d__30>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06034726 RID: 214822 RVA: 0x00C59EA4 File Offset: 0x00C580A4
		protected override UniTask OnHideAsyncImplementImplement()
		{
			PlotTipsViewBase.<OnHideAsyncImplementImplement>d__31 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<PlotTipsViewBase.<OnHideAsyncImplementImplement>d__31>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06034727 RID: 214823 RVA: 0x00C59EE8 File Offset: 0x00C580E8
		[NullableContext(1)]
		protected UniTask PlaySequenceAsync(string sequenceName, bool blockClick = false, bool playReverse = false, float? playRate = null)
		{
			PlotTipsViewBase.<PlaySequenceAsync>d__32 <PlaySequenceAsync>d__;
			<PlaySequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceAsync>d__.<>4__this = this;
			<PlaySequenceAsync>d__.sequenceName = sequenceName;
			<PlaySequenceAsync>d__.blockClick = blockClick;
			<PlaySequenceAsync>d__.playReverse = playReverse;
			<PlaySequenceAsync>d__.playRate = playRate;
			<PlaySequenceAsync>d__.<>1__state = -1;
			<PlaySequenceAsync>d__.<>t__builder.Start<PlotTipsViewBase.<PlaySequenceAsync>d__32>(ref <PlaySequenceAsync>d__);
			return <PlaySequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034728 RID: 214824 RVA: 0x00C59F4C File Offset: 0x00C5814C
		[NullableContext(1)]
		private void UpdatePlotSubtitle(ITalkItem inPlotSubtitleInfo)
		{
			if (this.SubmitTimer != null)
			{
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "[PlotTips] 语音完成或没有语音，恢复提交字幕定时", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.SubmitTimer.Resume();
				return;
			}
			if (this.CurrentConfig != inPlotSubtitleInfo)
			{
				this.CurrentConfig = inPlotSubtitleInfo;
				this.PlayAkEvent();
				string flowConfigLocalText = PublicUtil.Instance.GetFlowConfigLocalText(this.CurrentConfig.TidTalk ?? string.Empty);
				string text = PlotModel.Instance.PlotTextReplacer.Replace(flowConfigLocalText, true) ?? string.Empty;
				UUIText subtitleItem = this.SubtitleItem;
				if (subtitleItem != null)
				{
					subtitleItem.SetText(text, true);
				}
				UTexture utexture = null;
				UTexture utexture2;
				if (this.CurrentConfig.WhoId != null && this.TextureCache.TryGetValue(this.CurrentConfig.WhoId.Value, out utexture2))
				{
					utexture = utexture2;
				}
				if (utexture != null)
				{
					UUITexture iconItem = this.IconItem;
					if (iconItem != null)
					{
						iconItem.SetTexture(utexture);
					}
				}
				else
				{
					FlowController.Instance.LogError("[PlotTips] 没有头像", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				string configTextByTable = PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerName, inPlotSubtitleInfo.WhoId);
				if (!StringUtils.IsEmpty(configTextByTable))
				{
					UUIText nameItem = this.NameItem;
					if (nameItem != null)
					{
						nameItem.SetText(configTextByTable, true);
					}
				}
				else
				{
					FlowController.Instance.LogError("[PlotTips] 没有对话人", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[PlotTips] 字幕:";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Text", text);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			if (this.CurLang != LanguageSystem.Instance.PackageAudio)
			{
				if (this.PlotPlayEventResult != 0)
				{
					this.CallbackEnableId++;
					AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Stop, new ExecuteActionArgs?(new ExecuteActionArgs
					{
						TransitionDuration = new int?(0)
					}));
					this.PlotPlayEventResult = 0;
				}
				this.CurLang = LanguageSystem.Instance.PackageAudio;
			}
			if (this.PlayTalkAudio() || this.PlayTone())
			{
				return;
			}
			ICaptionParam captionParams = this.CurrentConfig.CaptionParams;
			this.SubmitSubtitle(((captionParams != null) ? captionParams.TotalTime : null) ?? PlotModel.Instance.PlotGlobalConfig.DefaultDurationPrompt, false);
		}

		// Token: 0x06034729 RID: 214825 RVA: 0x00C5A1A0 File Offset: 0x00C583A0
		private unsafe void SubmitSubtitle(float delay, bool needPause = false)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[PlotTips] 开始延迟完成字幕";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("delay", delay);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isPause", needPause);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.SubmitTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				ITalkItem currentConfig = this.CurrentConfig;
				this.ClearPlotSubtitle();
				FlowController.Instance.FlowShowTalk.SubmitSubtitle(currentConfig);
			}, (float)((long)(delay * 1000f)), null, null, true, 1f);
			if (needPause)
			{
				this.SubmitTimer.Pause();
			}
		}

		// Token: 0x0603472A RID: 214826 RVA: 0x00C5A248 File Offset: 0x00C58448
		private void PauseSubtitle()
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "[PlotTips] 暂停字幕", default(ReadOnlySpan<ValueTuple<string, object>>));
			TimerHandle submitTimer = this.SubmitTimer;
			if (submitTimer != null)
			{
				submitTimer.Pause();
			}
			if (this.PlotPlayEventResult != 0)
			{
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "[PlotTips] 暂停音频播放", default(ReadOnlySpan<ValueTuple<string, object>>));
				AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Pause, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(1000)
				}));
			}
		}

		// Token: 0x0603472B RID: 214827 RVA: 0x00C5A2D7 File Offset: 0x00C584D7
		private void HideAll(bool isHidden)
		{
			base.SetUiActive(!isHidden);
		}

		// Token: 0x0603472C RID: 214828 RVA: 0x00C5A2E3 File Offset: 0x00C584E3
		private void OnHangPlotViewHud(bool isHang)
		{
			this.OnHang(isHang, true);
		}

		// Token: 0x0603472D RID: 214829 RVA: 0x00C5A2F0 File Offset: 0x00C584F0
		private void OnHang(bool isHang = false, bool bSetActive = true)
		{
			if (this.IsHangInternal == isHang)
			{
				return;
			}
			if (!isHang && base.IsHideOrHiding)
			{
				return;
			}
			this.IsHangInternal = isHang;
			if (isHang)
			{
				if (bSetActive)
				{
					base.SetUiActive(false);
				}
				this.PauseSubtitle();
				FlowController.Instance.CountDownSkip(true);
				return;
			}
			if (bSetActive)
			{
				base.SetUiActive(true);
			}
			if (PlotModel.Instance.CurTalkItem != null)
			{
				this.UpdatePlotSubtitle(PlotModel.Instance.CurTalkItem);
			}
			FlowController.Instance.CountDownSkip(false);
		}

		// Token: 0x0603472E RID: 214830 RVA: 0x00C5A36C File Offset: 0x00C5856C
		private void ClearPlotSubtitle()
		{
			TimerHandle submitTimer = this.SubmitTimer;
			if (submitTimer != null)
			{
				submitTimer.Remove();
			}
			this.SubmitTimer = null;
			this.CurrentConfig = null;
			if (this.PlotPlayEventResult != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Stop, null);
			}
			this.PlotPlayEventResult = 0;
			this.CallbackEnableId++;
		}

		// Token: 0x0603472F RID: 214831 RVA: 0x00C5A3D0 File Offset: 0x00C585D0
		private unsafe bool PlayTalkAudio()
		{
			ITalkItem currentConfig = this.CurrentConfig;
			PlotAudio? plotAudio = ((currentConfig != null) ? currentConfig.PlayVoice : null).GetValueOrDefault() ? ConfigPlotAudioById.GetConfig(this.CurrentConfig.TidTalk, true) : null;
			if (plotAudio == null)
			{
				return false;
			}
			ExternalSourceSetting? config = ConfigExternalSourceSettingById.GetConfig(plotAudio.Value.ExternalSourceSetting, true);
			string mediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(plotAudio.Value);
			string text = AudioSystem.Instance.parseAudioEventPath(config.Value.SubtitleEvent);
			if (this.PlotPlayEventResult == 0)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[PlotTips] 语音播放";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mediaName", mediaName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.CallbackEnableId++;
				int id = this.CallbackEnableId;
				AudioSystem instance2 = AudioSystem.Instance;
				string @event = this.OverrideAudioEventName ?? text;
				UiParam uiParam = this.UiParam;
				this.PlotPlayEventResult = instance2.PostEvent(@event, (uiParam != null) ? uiParam.AudioAttachActor : null, new PostEventArgs?(new PostEventArgs
				{
					ExternalSourceName = (this.OverrideAudioSrcName ?? config.Value.SubtitleSrc),
					ExternalSourceMediaName = mediaName,
					CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
					CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
					{
						global::Log instance4 = global::Log.Instance;
						ELogModule module3 = ELogModule.Plot;
						ELogAuthor author3 = ELogAuthor.FZX;
						string message3 = "[PlotTips] 语音播放完成回调";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("mediaName", mediaName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("callbackType", callbackType);
						instance4.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						if (callbackType != EAkCallbackType.EndOfEvent || id != this.CallbackEnableId)
						{
							return;
						}
						this.PlotPlayEventResult = 0;
						PlotTipsViewBase <>4__this = this;
						ICaptionParam captionParams = this.CurrentConfig.CaptionParams;
						<>4__this.SubmitSubtitle(((captionParams != null) ? captionParams.IntervalTime : null) ?? PlotModel.Instance.PlotGlobalConfig.AudioEndWaitTimePrompt, this.IsHangInternal);
					}
				}));
			}
			else
			{
				AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Resume, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(1000)
				}));
				global::Log instance3 = global::Log.Instance;
				ELogModule module2 = ELogModule.Plot;
				ELogAuthor author2 = ELogAuthor.FZX;
				string message2 = "[PlotTips] 恢复音频播放";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("mediaName", mediaName);
				instance3.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			return true;
		}

		// Token: 0x06034730 RID: 214832 RVA: 0x00C5A5C0 File Offset: 0x00C587C0
		private unsafe bool PlayTone()
		{
			ITalkItem currentConfig = this.CurrentConfig;
			if (((currentConfig != null) ? currentConfig.UniversalTone : null) == null)
			{
				return false;
			}
			int? timberId = this.CurrentConfig.UniversalTone.TimberId;
			Speaker? speaker;
			int? num = (timberId != null) ? timberId : ((ConfigSpeakerById.GetConfig(this.CurrentConfig.WhoId.Value, true) != null) ? new int?(speaker.GetValueOrDefault().TimberId) : null);
			int universalToneId = this.CurrentConfig.UniversalTone.UniversalToneId;
			if (num == null || universalToneId == 0)
			{
				FlowController.Instance.LogError("语气配置无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			Interjection? config = ConfigInterjectionByTimberIdAndUniversalToneId.GetConfig(num.Value, universalToneId, true);
			if (config == null)
			{
				FlowController instance = FlowController.Instance;
				string text = "无法获取语气配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("timberId", num.Value);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("tone", universalToneId);
				instance.LogError(text, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			string eventName = AudioSystem.Instance.parseAudioEventPath(config.Value.AkEvent);
			if (this.PlotPlayEventResult == 0)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[PlotTips] 语气播放";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("event", eventName);
				instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.CallbackEnableId++;
				int id = this.CallbackEnableId;
				this.PlotPlayEventResult = AudioSystem.Instance.PostEvent(eventName, null, new PostEventArgs?(new PostEventArgs
				{
					CallbackMask = new ECallbackMask?(ECallbackMask.EndOfEvent),
					CallbackHandler = delegate(EAkCallbackType callbackType, UAkCallbackInfo callbackInfo)
					{
						global::Log instance3 = global::Log.Instance;
						ELogModule module2 = ELogModule.Plot;
						ELogAuthor author2 = ELogAuthor.FZX;
						string message2 = "[PlotTips] 语气播放完成回调";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("event", eventName);
						instance3.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						if (callbackType != EAkCallbackType.EndOfEvent || id != this.CallbackEnableId)
						{
							return;
						}
						this.PlotPlayEventResult = 0;
						PlotTipsViewBase <>4__this = this;
						ICaptionParam captionParams = this.CurrentConfig.CaptionParams;
						<>4__this.SubmitSubtitle(((captionParams != null) ? captionParams.IntervalTime : null) ?? PlotModel.Instance.PlotGlobalConfig.AudioEndWaitTimePrompt, this.IsHangInternal);
					}
				}));
			}
			else
			{
				AudioSystem.Instance.ExecuteAction(this.PlotPlayEventResult, EAudioActionType.Resume, new ExecuteActionArgs?(new ExecuteActionArgs
				{
					TransitionDuration = new int?(1000)
				}));
			}
			return true;
		}

		// Token: 0x06034731 RID: 214833 RVA: 0x00C5A7F4 File Offset: 0x00C589F4
		private void PlayAkEvent()
		{
			IPostAkEventType talkAkEvent = this.CurrentConfig.TalkAkEvent;
			if (talkAkEvent == null)
			{
				return;
			}
			if (talkAkEvent.Type != EPostAkEvent.Global)
			{
				if (talkAkEvent.Type == EPostAkEvent.Target)
				{
					IPostAkEventTargeted postAkEventTargeted = talkAkEvent as IPostAkEventTargeted;
					string text = AudioSystem.Instance.parseAudioEventPath(postAkEventTargeted.AkEvent);
					if (string.IsNullOrEmpty(text))
					{
						return;
					}
					int entityId = postAkEventTargeted.EntityId;
					EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(entityId);
					if (entityByPbDataId == null)
					{
						global::Log instance = global::Log.Instance;
						ELogModule module = ELogModule.Event;
						ELogAuthor author = ELogAuthor.FZX;
						string message = "实体不存在";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
					BaseActorComponent component = entityByPbDataId.Entity.GetComponent<BaseActorComponent>();
					AActor aactor = (component != null) ? component.Owner : null;
					if (aactor == null || !aactor.IsValid())
					{
						global::Log instance2 = global::Log.Instance;
						ELogModule module2 = ELogModule.Event;
						ELogAuthor author2 = ELogAuthor.FZX;
						string message2 = "未能获取到该实体对应的有效Actor";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("entityId", entityId);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						return;
					}
					AudioSystem.Instance.PostEvent(text, aactor, null);
				}
				return;
			}
			IPostAkEventGlobal postAkEventGlobal = talkAkEvent as IPostAkEventGlobal;
			string text2 = AudioSystem.Instance.parseAudioEventPath(postAkEventGlobal.AkEvent);
			if (string.IsNullOrEmpty(text2))
			{
				return;
			}
			AudioSystem.Instance.PostEvent(text2);
		}

		// Token: 0x17007FF1 RID: 32753
		// (get) Token: 0x06034732 RID: 214834 RVA: 0x00C5A932 File Offset: 0x00C58B32
		protected bool IsHang
		{
			get
			{
				return this.IsHangInternal;
			}
		}

		// Token: 0x06034733 RID: 214835 RVA: 0x00C5A93C File Offset: 0x00C58B3C
		protected EUiViewName? GetViewName()
		{
			UiParam uiParam = this.UiParam;
			if (uiParam == null)
			{
				return null;
			}
			return uiParam.ViewName;
		}

		// Token: 0x0401BEF0 RID: 114416
		private const int BREAK_TIME = 1000;

		// Token: 0x0401BEF1 RID: 114417
		private UiParam UiParam;

		// Token: 0x0401BEF2 RID: 114418
		private ITalkItem CurrentConfig;

		// Token: 0x0401BEF3 RID: 114419
		private TimerHandle SubmitTimer;

		// Token: 0x0401BEF4 RID: 114420
		private bool IsHangInternal;

		// Token: 0x0401BEF5 RID: 114421
		private int PlotPlayEventResult;

		// Token: 0x0401BEF6 RID: 114422
		private int CallbackEnableId;

		// Token: 0x0401BEF7 RID: 114423
		[Nullable(1)]
		private readonly Dictionary<int, UTexture> TextureCache = new Dictionary<int, UTexture>();

		// Token: 0x0401BEF8 RID: 114424
		[Nullable(1)]
		private string CurLang = string.Empty;

		// Token: 0x0401BEF9 RID: 114425
		[Nullable(1)]
		protected string ResourceId = string.Empty;

		// Token: 0x0401BEFA RID: 114426
		protected UUITexture IconItem;

		// Token: 0x0401BEFB RID: 114427
		protected UUIText SubtitleItem;

		// Token: 0x0401BEFC RID: 114428
		protected UUIText NameItem;

		// Token: 0x0401BEFD RID: 114429
		protected string OverrideAudioEventName;

		// Token: 0x0401BEFE RID: 114430
		protected string OverrideAudioSrcName;

		// Token: 0x0401BEFF RID: 114431
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401BF00 RID: 114432
		public bool FirstShow;

		// Token: 0x0401BF01 RID: 114433
		public bool LastHide;
	}
}
