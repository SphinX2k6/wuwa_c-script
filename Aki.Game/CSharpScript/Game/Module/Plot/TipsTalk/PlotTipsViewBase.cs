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
	// Token: 0x02003FDA RID: 16346
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTipsViewBase : UiPanelBase
	{
		// Token: 0x060295BC RID: 169404 RVA: 0x00BA50C4 File Offset: 0x00BA32C4
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

		// Token: 0x060295BD RID: 169405 RVA: 0x00BA510F File Offset: 0x00BA330F
		protected virtual UUIItem GetParentItem()
		{
			return UiLayer.Instance.GetLayerRootUiItem(ELayerType.HUD);
		}

		// Token: 0x060295BE RID: 169406 RVA: 0x00BA511C File Offset: 0x00BA331C
		public UniTask CloseAsync()
		{
			PlotTipsViewBase.<CloseAsync>d__20 <CloseAsync>d__;
			<CloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseAsync>d__.<>4__this = this;
			<CloseAsync>d__.<>1__state = -1;
			<CloseAsync>d__.<>t__builder.Start<PlotTipsViewBase.<CloseAsync>d__20>(ref <CloseAsync>d__);
			return <CloseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060295BF RID: 169407 RVA: 0x00BA515F File Offset: 0x00BA335F
		[NullableContext(1)]
		public void RefreshSubtitle(ITalkItem talkItem)
		{
			this.UpdatePlotSubtitle(talkItem);
		}

		// Token: 0x060295C0 RID: 169408 RVA: 0x00BA5168 File Offset: 0x00BA3368
		protected virtual void OnInit()
		{
		}

		// Token: 0x060295C1 RID: 169409 RVA: 0x00BA516C File Offset: 0x00BA336C
		private void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.UpdatePlotSubtitle, new Action<ITalkItem>(this.UpdatePlotSubtitle));
			EventSystem.Instance.Add(EEventName.HidePlotUi, new Action<bool>(this.HideAll));
			EventSystem.Instance.Add<bool>(EEventName.HangPlotViewHud, new Action<bool>(this.OnHangPlotViewHud));
			EventSystem.Instance.Add(EEventName.ClearPlotSubtitle, new Action(this.ClearPlotSubtitle));
		}

		// Token: 0x060295C2 RID: 169410 RVA: 0x00BA51EC File Offset: 0x00BA33EC
		private void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.UpdatePlotSubtitle, new Action<ITalkItem>(this.UpdatePlotSubtitle));
			EventSystem.Instance.Remove(EEventName.HidePlotUi, new Action<bool>(this.HideAll));
			EventSystem.Instance.Remove(EEventName.HangPlotViewHud, new Action<bool>(this.OnHangPlotViewHud));
			EventSystem.Instance.Remove(EEventName.ClearPlotSubtitle, new Action(this.ClearPlotSubtitle));
		}

		// Token: 0x060295C3 RID: 169411 RVA: 0x00BA526C File Offset: 0x00BA346C
		protected override UniTask OnCreateAsync()
		{
			PlotTipsViewBase.<OnCreateAsync>d__25 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<PlotTipsViewBase.<OnCreateAsync>d__25>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060295C4 RID: 169412 RVA: 0x00BA52B0 File Offset: 0x00BA34B0
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

		// Token: 0x060295C5 RID: 169413 RVA: 0x00BA5300 File Offset: 0x00BA3500
		protected override void OnAfterShow()
		{
			this.OnAddEventListener();
			this.OnHang(PlotModel.Instance.HangViewHud, false);
		}

		// Token: 0x060295C6 RID: 169414 RVA: 0x00BA5319 File Offset: 0x00BA3519
		protected override void OnBeforeHide()
		{
			this.OnRemoveEventListener();
			if (!this.LastHide)
			{
				this.OnHang(true, false);
			}
		}

		// Token: 0x060295C7 RID: 169415 RVA: 0x00BA5331 File Offset: 0x00BA3531
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

		// Token: 0x060295C8 RID: 169416 RVA: 0x00BA5360 File Offset: 0x00BA3560
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PlotTipsViewBase.<OnShowAsyncImplementImplement>d__30 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PlotTipsViewBase.<OnShowAsyncImplementImplement>d__30>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060295C9 RID: 169417 RVA: 0x00BA53A4 File Offset: 0x00BA35A4
		protected override UniTask OnHideAsyncImplementImplement()
		{
			PlotTipsViewBase.<OnHideAsyncImplementImplement>d__31 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<PlotTipsViewBase.<OnHideAsyncImplementImplement>d__31>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060295CA RID: 169418 RVA: 0x00BA53E8 File Offset: 0x00BA35E8
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

		// Token: 0x060295CB RID: 169419 RVA: 0x00BA544C File Offset: 0x00BA364C
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

		// Token: 0x060295CC RID: 169420 RVA: 0x00BA56A0 File Offset: 0x00BA38A0
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

		// Token: 0x060295CD RID: 169421 RVA: 0x00BA5748 File Offset: 0x00BA3948
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

		// Token: 0x060295CE RID: 169422 RVA: 0x00BA57D7 File Offset: 0x00BA39D7
		private void HideAll(bool isHidden)
		{
			base.SetUiActive(!isHidden);
		}

		// Token: 0x060295CF RID: 169423 RVA: 0x00BA57E3 File Offset: 0x00BA39E3
		private void OnHangPlotViewHud(bool isHang)
		{
			this.OnHang(isHang, true);
		}

		// Token: 0x060295D0 RID: 169424 RVA: 0x00BA57F0 File Offset: 0x00BA39F0
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

		// Token: 0x060295D1 RID: 169425 RVA: 0x00BA586C File Offset: 0x00BA3A6C
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

		// Token: 0x060295D2 RID: 169426 RVA: 0x00BA58D0 File Offset: 0x00BA3AD0
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

		// Token: 0x060295D3 RID: 169427 RVA: 0x00BA5AC0 File Offset: 0x00BA3CC0
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

		// Token: 0x060295D4 RID: 169428 RVA: 0x00BA5CF4 File Offset: 0x00BA3EF4
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

		// Token: 0x170053A6 RID: 21414
		// (get) Token: 0x060295D5 RID: 169429 RVA: 0x00BA5E32 File Offset: 0x00BA4032
		protected bool IsHang
		{
			get
			{
				return this.IsHangInternal;
			}
		}

		// Token: 0x060295D6 RID: 169430 RVA: 0x00BA5E3C File Offset: 0x00BA403C
		protected EUiViewName? GetViewName()
		{
			UiParam uiParam = this.UiParam;
			if (uiParam == null)
			{
				return null;
			}
			return uiParam.ViewName;
		}

		// Token: 0x040168D9 RID: 92377
		private const int BREAK_TIME = 1000;

		// Token: 0x040168DA RID: 92378
		private UiParam UiParam;

		// Token: 0x040168DB RID: 92379
		private ITalkItem CurrentConfig;

		// Token: 0x040168DC RID: 92380
		private TimerHandle SubmitTimer;

		// Token: 0x040168DD RID: 92381
		private bool IsHangInternal;

		// Token: 0x040168DE RID: 92382
		private int PlotPlayEventResult;

		// Token: 0x040168DF RID: 92383
		private int CallbackEnableId;

		// Token: 0x040168E0 RID: 92384
		[Nullable(1)]
		private readonly Dictionary<int, UTexture> TextureCache = new Dictionary<int, UTexture>();

		// Token: 0x040168E1 RID: 92385
		[Nullable(1)]
		private string CurLang = string.Empty;

		// Token: 0x040168E2 RID: 92386
		[Nullable(1)]
		protected string ResourceId = string.Empty;

		// Token: 0x040168E3 RID: 92387
		protected UUITexture IconItem;

		// Token: 0x040168E4 RID: 92388
		protected UUIText SubtitleItem;

		// Token: 0x040168E5 RID: 92389
		protected UUIText NameItem;

		// Token: 0x040168E6 RID: 92390
		protected string OverrideAudioEventName;

		// Token: 0x040168E7 RID: 92391
		protected string OverrideAudioSrcName;

		// Token: 0x040168E8 RID: 92392
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040168E9 RID: 92393
		public bool FirstShow;

		// Token: 0x040168EA RID: 92394
		public bool LastHide;
	}
}
