using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004034 RID: 16436
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTransitionView : UiViewBase
	{
		// Token: 0x060299BE RID: 170430 RVA: 0x00BC0AC3 File Offset: 0x00BBECC3
		[NullableContext(1)]
		public PlotTransitionView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060299BF RID: 170431 RVA: 0x00BC0AF8 File Offset: 0x00BBECF8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBtnSkipClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060299C0 RID: 170432 RVA: 0x00BC0C24 File Offset: 0x00BBEE24
		protected override void OnStart()
		{
			string text = this.OpenParam as string;
			this.TextPlayTweenComp = (base.GetText(0).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			this.TexturePlayTweenComp = (base.GetTexture(1).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			this.TextAnimDataComp = (base.GetText(0).GetOwner().GetComponentByClass(UUIEffectTextAnimation.StaticClass()) as UUIEffectTextAnimation);
			this.TextPlayTweenEndCb = DelegateUtils.ToManualReleaseDelegate<FLGUIPlayTweenCompleteDynamicDelegate>(new Action(this.OnMultiLineTextPlayTweenEnd));
			this.TextPlayTweenEndCbWrapper = this.TextPlayTweenComp.GetPlayTween().RegisterOnComplete(this.TextPlayTweenEndCb);
			base.GetTexture(2).SetUIActive(false);
			if (GameModeModel.Instance.UseShowCenterText)
			{
				base.GetItem(5).SetUIActive(true);
				this.SetNextPageButtonActive(false);
			}
			else if (TeleportModel.Instance.IsTeleport || GameModeModel.Instance.PlayTravelMp4)
			{
				base.GetItem(5).SetUIActive(true);
				this.SetNextPageButtonActive(false);
				base.GetText(0).SetUIActive(false);
			}
			else
			{
				base.GetItem(5).SetUIActive(false);
			}
			if (!string.IsNullOrEmpty(text))
			{
				string newText = ConfigMultiTextLang.GetLocalTextNew(text, null) ?? text;
				UUIText text2 = base.GetText(0);
				text2.SetText(newText, true);
				text2.SetAnchorVAlign(UIAnchorVerticalAlign.Middle);
				text2.SetPivot(Vector2D.Create(0.5, 0.5).ToUeVector2D(false));
				text2.SetParagraphHorizontalAlignment(UITextParagraphHorizontalAlign.Center);
				text2.SetAnchorOffsetX(0f);
				text2.SetAnchorOffsetY(0f);
				float centerTextFontSizeMiddle = PlotModel.Instance.PlotGlobalConfig.CenterTextFontSizeMiddle;
				if (centerTextFontSizeMiddle > 0f)
				{
					text2.SetFontSize(centerTextFontSizeMiddle);
				}
				this.TextAnimDataComp.SetSelectorOffset(0f);
				text2.SetUIActive(true);
				this.SetNextPageButtonActive(false);
			}
		}

		// Token: 0x060299C1 RID: 170433 RVA: 0x00BC0E08 File Offset: 0x00BBF008
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			PlotTransitionView.<OnPlayingStartSequenceAsync>d__31 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PlotTransitionView.<OnPlayingStartSequenceAsync>d__31>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060299C2 RID: 170434 RVA: 0x00BC0E4C File Offset: 0x00BBF04C
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			PlotTransitionView.<OnPlayingCloseSequenceAsync>d__32 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PlotTransitionView.<OnPlayingCloseSequenceAsync>d__32>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060299C3 RID: 170435 RVA: 0x00BC0E8F File Offset: 0x00BBF08F
		public void ExecuteCallBack()
		{
			if (this.Callback != null)
			{
				Action callback = this.Callback;
				this.Callback = null;
				callback();
			}
		}

		// Token: 0x060299C4 RID: 170436 RVA: 0x00BC0EAC File Offset: 0x00BBF0AC
		private void OnTextPlayTweenEnd()
		{
			if (this.AnimMode == PlotTransitionView.ETextAnimMode.MultiLineFade || this.AnimMode == PlotTransitionView.ETextAnimMode.MultiLineTypeWriter)
			{
				return;
			}
			float? textTime = this.TextTime;
			float num = 0f;
			float textTimer = (!(textTime.GetValueOrDefault() == num & textTime != null) && this.TextTime != null) ? this.TextTime.Value : PlotModel.Instance.PlotGlobalConfig.EndWaitTimeCenterText;
			this.SetTextTimer(textTimer);
		}

		// Token: 0x060299C5 RID: 170437 RVA: 0x00BC0F20 File Offset: 0x00BBF120
		private void OnMultiLineTextPlayTweenEnd()
		{
			if (this.AnimMode != PlotTransitionView.ETextAnimMode.MultiLineFade && this.AnimMode != PlotTransitionView.ETextAnimMode.MultiLineTypeWriter)
			{
				return;
			}
			float endWaitTimeCenterText = PlotModel.Instance.PlotGlobalConfig.EndWaitTimeCenterText;
			this.SetTextTimer(endWaitTimeCenterText);
		}

		// Token: 0x060299C6 RID: 170438 RVA: 0x00BC0F58 File Offset: 0x00BBF158
		private void SetTextTimer(float delayTime)
		{
			if (this.TextShowDelayId != null)
			{
				TimerSystem.Instance.Remove(this.TextShowDelayId);
			}
			this.TextShowDelayId = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.TextShowDelayId = null;
				this.ClearAudio();
				base.GetText(0).SetUIActive(false);
				base.GetTexture(2).SetUIActive(false);
				this.ExecuteCallBack();
			}, (float)TimeUtil.Instance.SetTimeMillisecond((double)delayTime), null, null, true, 1f);
		}

		// Token: 0x060299C7 RID: 170439 RVA: 0x00BC0FAF File Offset: 0x00BBF1AF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPlotTransitionRemoveCallback, new Action(this.RemoveCallback));
			EventSystem.Instance.Add(EEventName.UpdatePlotCenterText, new Action(this.OnUpdatePlotCenterText));
		}

		// Token: 0x060299C8 RID: 170440 RVA: 0x00BC0FE9 File Offset: 0x00BBF1E9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPlotTransitionRemoveCallback, new Action(this.RemoveCallback));
			EventSystem.Instance.Remove(EEventName.UpdatePlotCenterText, new Action(this.OnUpdatePlotCenterText));
		}

		// Token: 0x060299C9 RID: 170441 RVA: 0x00BC1023 File Offset: 0x00BBF223
		protected override void OnBeforeHide()
		{
			this.SetNextPageButtonActive(false);
		}

		// Token: 0x060299CA RID: 170442 RVA: 0x00BC102C File Offset: 0x00BBF22C
		private void RemoveCallback()
		{
			this.Callback = null;
		}

		// Token: 0x060299CB RID: 170443 RVA: 0x00BC1038 File Offset: 0x00BBF238
		private void OnUpdatePlotCenterText()
		{
			PlotCenterText centerText = PlotModel.Instance.CenterText;
			this.CenterText = centerText;
			if (!string.IsNullOrEmpty(centerText.Text))
			{
				string text = PlotModel.Instance.PlotTextReplacer.Replace(centerText.Text, false);
				UUIText text2 = base.GetText(0);
				text2.SetText(text, true);
				text2.SetUIActive(true);
				this.SetTextOverflowType();
				this.SetTextAlign();
				this.SetTextFontSize();
				this.SetTextAnimMode(text.Length);
			}
			else
			{
				UUIText text3 = base.GetText(0);
				if (text3 != null)
				{
					text3.SetUIActive(false);
				}
			}
			string text4 = "";
			float num = 0f;
			bool? isManualNext = new bool?(false);
			if (centerText.Config != null)
			{
				if (centerText.Config.Value.IsT1)
				{
					text4 = centerText.Config.Value.AsT1.BgImageId;
					num = centerText.Config.Value.AsT1.TotalTime.GetValueOrDefault();
					isManualNext = centerText.Config.Value.AsT1.IsManualNext;
				}
				else if (centerText.Config.Value.IsT2)
				{
					text4 = centerText.Config.Value.AsT2.BgImageId;
					num = centerText.Config.Value.AsT2.TotalTime.GetValueOrDefault();
					isManualNext = centerText.Config.Value.AsT2.IsManualNext;
				}
			}
			if (!string.IsNullOrEmpty(text4))
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(text4);
				ResourceSystem.Instance.LoadAsync<UTexture>(resourcePath, delegate([Nullable(2)] UTexture loadObject, string _)
				{
					if (loadObject == null || !loadObject.IsValid())
					{
						return;
					}
					base.GetTexture(2).SetTexture(loadObject);
					base.GetTexture(2).SetUIActive(true);
				}, 100, "js_undefined");
			}
			if (GameModeModel.Instance.UseShowCenterText)
			{
				this.TextTime = new float?(999f);
				this.PlayAudio();
				base.GetTexture(2).SetUIActive(true);
				this.Callback = centerText.Callback;
				if (centerText.Config != null && num > 0f)
				{
					this.TextTime = new float?(num);
					this.OnTextPlayTweenEnd();
				}
				else
				{
					this.ExecuteCallBack();
				}
				PlotModel.Instance.CenterText.Clear();
				return;
			}
			this.SetNextPageButtonActive(isManualNext.GetValueOrDefault());
			this.ExecuteCallBack();
			this.Callback = centerText.Callback;
			if (centerText.AutoClose)
			{
				if (this.TextTime == null)
				{
					this.TextTime = new float?(num);
				}
				this.OnTextPlayTweenEnd();
			}
			if (!string.IsNullOrEmpty(this.CenterText.AudioId))
			{
				this.PlayAudio();
			}
			else
			{
				this.PlayTone();
			}
			this.PlayAkEvent(this.CenterText.TalkAkEvent);
			this.TalkEndAkEvent = this.CenterText.TalkEndAkEvent;
			PlotModel.Instance.CenterText.Clear();
		}

		// Token: 0x060299CC RID: 170444 RVA: 0x00BC130C File Offset: 0x00BBF50C
		private unsafe void PlayTone()
		{
			PlotCenterText centerText = this.CenterText;
			if (((centerText != null) ? centerText.UniversalTone : null) != null)
			{
				int valueOrDefault = this.CenterText.UniversalTone.TimberId.GetValueOrDefault();
				int universalToneId = this.CenterText.UniversalTone.UniversalToneId;
				if (valueOrDefault > 0 && universalToneId > 0)
				{
					Interjection? config = ConfigInterjectionByTimberIdAndUniversalToneId.GetConfig(valueOrDefault, universalToneId, true);
					if (config != null)
					{
						this.PlayTalkInterjection(config.Value);
						return;
					}
				}
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "通用语气配置无法获取，策划检查配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("timberId", valueOrDefault);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("universalToneId", universalToneId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x060299CD RID: 170445 RVA: 0x00BC13E0 File Offset: 0x00BBF5E0
		private void PlayTalkInterjection(Interjection config)
		{
			AudioController.Instance.PostEventByUi(config.AkEvent, this.PlotPlayEventResult, new int?(8), null);
		}

		// Token: 0x060299CE RID: 170446 RVA: 0x00BC1400 File Offset: 0x00BBF600
		private void PlayAkEvent(IPostAkEventType config)
		{
			if (config == null)
			{
				return;
			}
			string text = "";
			switch (config.Type)
			{
			case EPostAkEvent.Global:
				text = ((IPostAkEventGlobal)config).AkEvent;
				break;
			case EPostAkEvent.Target:
				text = ((IPostAkEventTargeted)config).AkEvent;
				break;
			case EPostAkEvent.Map:
				text = ((IPostAkEventMap)config).AkEvent;
				break;
			case EPostAkEvent.MusicSubtitle:
				text = ((IPostAkEventMusicSubtitle)config).AkEvent;
				break;
			}
			text = AudioSystem.Instance.parseAudioEventPath(text);
			if (config.Type == EPostAkEvent.Global)
			{
				AudioSystem.Instance.PostEvent(text);
				return;
			}
			if (config.Type == EPostAkEvent.Target)
			{
				int entityId = (config as IPostAkEventTargeted).EntityId;
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(entityId);
				if (entityByPbDataId == null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Event;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "实体不存在";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
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
		}

		// Token: 0x060299CF RID: 170447 RVA: 0x00BC1550 File Offset: 0x00BBF750
		protected override void OnBeforeDestroy()
		{
			this.SetNextPageButtonActive(false);
			this.TextPlayTweenComp.GetPlayTween().UnregisterOnComplete(this.TextPlayTweenEndCbWrapper);
			DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnMultiLineTextPlayTweenEnd));
			this.TextPlayTweenEndCb = null;
			if (this.TextShowDelayId != null)
			{
				TimerSystem.Instance.Remove(this.TextShowDelayId);
				this.TextShowDelayId = null;
			}
			if (this.TextAnimDelayId != null)
			{
				TimerSystem.Instance.Remove(this.TextAnimDelayId);
				this.TextAnimDelayId = null;
			}
			if (this.WaitingSkipTimerId != null)
			{
				TimerSystem.Instance.Remove(this.WaitingSkipTimerId);
				this.WaitingSkipTimerId = null;
			}
			this.ExecuteCallBack();
			this.CenterText = null;
			this.LineNumArray = null;
			this.TalkEndAkEvent = null;
		}

		// Token: 0x060299D0 RID: 170448 RVA: 0x00BC1610 File Offset: 0x00BBF810
		private void SetTweenAndPlay(bool isReverse, float time)
		{
			ULGUIPlayTween_Float ulguiplayTween_Float = this.TextPlayTweenComp.GetPlayTween() as ULGUIPlayTween_Float;
			ulguiplayTween_Float.from = (isReverse ? 1f : 0f);
			ulguiplayTween_Float.to = (isReverse ? 0f : 1f);
			ulguiplayTween_Float.duration = time;
			this.TextPlayTweenComp.Play();
		}

		// Token: 0x060299D1 RID: 170449 RVA: 0x00BC1668 File Offset: 0x00BBF868
		private void SetTweenPauseOrResume(bool isPause)
		{
			ULGUIPlayTween_Float ulguiplayTween_Float = this.TextPlayTweenComp.GetPlayTween() as ULGUIPlayTween_Float;
			ULTweener ultweener = (ulguiplayTween_Float != null) ? ulguiplayTween_Float.GetTweener() : null;
			if (ultweener == null)
			{
				return;
			}
			if (isPause)
			{
				ultweener.Pause();
				this.PauseOrResumeAudio(true);
				return;
			}
			ultweener.Resume();
			this.PauseOrResumeAudio(false);
		}

		// Token: 0x060299D2 RID: 170450 RVA: 0x00BC16B4 File Offset: 0x00BBF8B4
		private void Fade(bool isReverse, float fadeTime)
		{
			ULGUIPlayTween_Float ulguiplayTween_Float = this.TexturePlayTweenComp.GetPlayTween() as ULGUIPlayTween_Float;
			ulguiplayTween_Float.from = (isReverse ? base.GetTexture(1).GetAlpha() : 0f);
			ulguiplayTween_Float.to = (isReverse ? 0f : 1f);
			ulguiplayTween_Float.duration = fadeTime;
			this.TexturePlayTweenComp.Play();
		}

		// Token: 0x060299D3 RID: 170451 RVA: 0x00BC1714 File Offset: 0x00BBF914
		private void PlayAudio()
		{
			PlotAudio? plotAudio = string.IsNullOrEmpty(this.CenterText.AudioId) ? null : ConfigPlotAudioById.GetConfig(this.CenterText.AudioId, true);
			if (plotAudio == null)
			{
				return;
			}
			this.PlayAudioInner(plotAudio.Value);
		}

		// Token: 0x060299D4 RID: 170452 RVA: 0x00BC1768 File Offset: 0x00BBF968
		private void PlayAudioInner(PlotAudio config)
		{
			ExternalSourceSetting? config2 = ConfigExternalSourceSettingById.GetConfig(config.ExternalSourceSetting, true);
			string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(config);
			AudioController.Instance.PostEventByExternalSourcesByUi(config2.Value.SubtitleEvent, externalSourcesMediaName, config2.Value.SubtitleSrc, this.PlotPlayEventResult, null, new int?(8), null);
		}

		// Token: 0x060299D5 RID: 170453 RVA: 0x00BC17C8 File Offset: 0x00BBF9C8
		private void PauseOrResumeAudio(bool isPause)
		{
			if (this.PlotPlayEventResult == null)
			{
				return;
			}
			if (isPause)
			{
				using (List<int>.Enumerator enumerator = this.PlotPlayEventResult.PlayingIds.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						int playId = enumerator.Current;
						AudioController.Instance.PauseAudioByPlayId(playId);
					}
					return;
				}
			}
			foreach (int playId2 in this.PlotPlayEventResult.PlayingIds)
			{
				AudioController.Instance.ResumeAudioByPlayId(playId2);
			}
		}

		// Token: 0x060299D6 RID: 170454 RVA: 0x00BC187C File Offset: 0x00BBFA7C
		private void ClearAudio()
		{
			this.PlayAkEvent(this.TalkEndAkEvent);
			this.TalkEndAkEvent = null;
			AudioController.Instance.StopEvent(this.PlotPlayEventResult, true, null);
		}

		// Token: 0x060299D7 RID: 170455 RVA: 0x00BC18B8 File Offset: 0x00BBFAB8
		private void SetTextAlign()
		{
			PlotCenterText centerText = this.CenterText;
			UUIText text = base.GetText(0);
			ETextAlign? etextAlign = null;
			ETextHorizontal? etextHorizontal = null;
			PlotCenterText plotCenterText = centerText;
			if (plotCenterText.Config != null && plotCenterText.Config.GetValueOrDefault().IsT1)
			{
				ITextStyle textStyle = centerText.Config.Value.AsT1.TextStyle;
				etextAlign = ((textStyle != null) ? textStyle.TextAlign : null);
				ITextStyle textStyle2 = centerText.Config.Value.AsT1.TextStyle;
				etextHorizontal = ((textStyle2 != null) ? textStyle2.TextHorizontal : null);
			}
			else
			{
				PlotCenterText plotCenterText2 = centerText;
				if (plotCenterText2.Config != null && plotCenterText2.Config.GetValueOrDefault().IsT2)
				{
					ITextStyle textStyle3 = centerText.Config.Value.AsT2.TextStyle;
					etextAlign = ((textStyle3 != null) ? textStyle3.TextAlign : null);
					ITextStyle textStyle4 = centerText.Config.Value.AsT2.TextStyle;
					etextHorizontal = ((textStyle4 != null) ? textStyle4.TextHorizontal : null);
				}
			}
			if (etextAlign.GetValueOrDefault() == ETextAlign.Bottom)
			{
				text.SetAnchorVAlign(UIAnchorVerticalAlign.Bottom);
				text.SetPivot(Vector2D.Create(0.5, -1.0).ToUeVector2D(false));
			}
			else
			{
				ETextAlign? etextAlign2 = etextAlign;
				ETextAlign etextAlign3 = ETextAlign.Top;
				if (etextAlign2.GetValueOrDefault() == etextAlign3 & etextAlign2 != null)
				{
					text.SetAnchorVAlign(UIAnchorVerticalAlign.Top);
					text.SetPivot(Vector2D.Create(0.5, 2.0).ToUeVector2D(false));
				}
				else
				{
					text.SetAnchorVAlign(UIAnchorVerticalAlign.Middle);
					text.SetPivot(Vector2D.Create(0.5, 0.5).ToUeVector2D(false));
				}
			}
			ETextHorizontal? etextHorizontal2 = etextHorizontal;
			ETextHorizontal etextHorizontal3 = ETextHorizontal.Left;
			if (etextHorizontal2.GetValueOrDefault() == etextHorizontal3 & etextHorizontal2 != null)
			{
				text.SetParagraphHorizontalAlignment(UITextParagraphHorizontalAlign.Left);
			}
			else if (etextHorizontal.GetValueOrDefault() == ETextHorizontal.Right)
			{
				text.SetParagraphHorizontalAlignment(UITextParagraphHorizontalAlign.Right);
			}
			else
			{
				text.SetParagraphHorizontalAlignment(UITextParagraphHorizontalAlign.Center);
			}
			text.SetAnchorOffsetX(0f);
			text.SetAnchorOffsetY(0f);
		}

		// Token: 0x060299D8 RID: 170456 RVA: 0x00BC1AE4 File Offset: 0x00BBFCE4
		private void SetTextFontSize()
		{
			PlotCenterText centerText = this.CenterText;
			EFontSize? efontSize = null;
			PlotCenterText plotCenterText = centerText;
			if (plotCenterText.Config != null && plotCenterText.Config.GetValueOrDefault().IsT1)
			{
				ITextStyle textStyle = centerText.Config.Value.AsT1.TextStyle;
				efontSize = ((textStyle != null) ? textStyle.FontSize : null);
			}
			else
			{
				PlotCenterText plotCenterText2 = centerText;
				if (plotCenterText2.Config != null && plotCenterText2.Config.GetValueOrDefault().IsT2)
				{
					ITextStyle textStyle2 = centerText.Config.Value.AsT2.TextStyle;
					efontSize = ((textStyle2 != null) ? textStyle2.FontSize : null);
				}
			}
			if (efontSize == null)
			{
				return;
			}
			UUIText text = base.GetText(0);
			float num = -1f;
			if (efontSize.GetValueOrDefault() == EFontSize.Big)
			{
				num = PlotModel.Instance.PlotGlobalConfig.CenterTextFontSizeBig;
			}
			else if (efontSize.GetValueOrDefault() == EFontSize.Middle)
			{
				num = PlotModel.Instance.PlotGlobalConfig.CenterTextFontSizeMiddle;
			}
			else
			{
				EFontSize? efontSize2 = efontSize;
				EFontSize efontSize3 = EFontSize.Small;
				if (efontSize2.GetValueOrDefault() == efontSize3 & efontSize2 != null)
				{
					num = PlotModel.Instance.PlotGlobalConfig.CenterTextFontSizeSmall;
				}
			}
			if (num > 0f)
			{
				text.SetFontSize(num);
			}
		}

		// Token: 0x060299D9 RID: 170457 RVA: 0x00BC1C30 File Offset: 0x00BBFE30
		private void SetTextAnimMode(int textLength)
		{
			if (this.TextAnimDelayId != null)
			{
				TimerSystem.Instance.Remove(this.TextAnimDelayId);
			}
			PlotCenterText centerText = this.CenterText;
			ICenterTextShowType centerTextShowType = null;
			bool flag = false;
			PlotCenterText plotCenterText = centerText;
			if (plotCenterText.Config != null && plotCenterText.Config.GetValueOrDefault().IsT1)
			{
				ITextStyle textStyle = centerText.Config.Value.AsT1.TextStyle;
				centerTextShowType = ((textStyle != null) ? textStyle.ShowAnim : null);
				flag = centerText.Config.Value.AsT1.IsMulLine.GetValueOrDefault();
			}
			else
			{
				PlotCenterText plotCenterText2 = centerText;
				if (plotCenterText2.Config != null && plotCenterText2.Config.GetValueOrDefault().IsT2)
				{
					ITextStyle textStyle2 = centerText.Config.Value.AsT2.TextStyle;
					centerTextShowType = ((textStyle2 != null) ? textStyle2.ShowAnim : null);
					flag = centerText.Config.Value.AsT2.IsMulLine.GetValueOrDefault();
				}
			}
			if (centerTextShowType == null)
			{
				this.TextAnimDataComp.SetSelectorOffset(0f);
				return;
			}
			this.TextTime = null;
			this.TextAnimDataComp.SetSelectorOffset(1f);
			UUIEffectTextAnimation_RangeSelector uuieffectTextAnimation_RangeSelector = this.TextAnimDataComp.GetSelector() as UUIEffectTextAnimation_RangeSelector;
			uuieffectTextAnimation_RangeSelector.lineByLine = (flag && centerTextShowType.Type == ECenterTextShowAnim.FadeOut);
			uuieffectTextAnimation_RangeSelector.flipDirection = !uuieffectTextAnimation_RangeSelector.lineByLine;
			uuieffectTextAnimation_RangeSelector.SetRange((centerTextShowType.Type == ECenterTextShowAnim.FadeOut) ? 9999f : 0.01f);
			if (flag && centerTextShowType.Type == ECenterTextShowAnim.TypeWriter)
			{
				this.AnimMode = PlotTransitionView.ETextAnimMode.MultiLineTypeWriter;
				IICenterTextTypeWriter iicenterTextTypeWriter = centerTextShowType as IICenterTextTypeWriter;
				float num = (iicenterTextTypeWriter.TextCountPerSecond > 0) ? ((float)iicenterTextTypeWriter.TextCountPerSecond) : PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedSeq;
				float time = (float)textLength / num;
				this.SetTweenAndPlay(true, time);
				int lineNum = this.GetLineNum();
				this.Speed = num;
				if (lineNum > 1)
				{
					this.CurLine = 1;
					this.OneLineTime = (float)this.LineNumArray[this.CurLine - 1] / this.Speed;
					this.LineCount = lineNum;
					this.SetMultiLineTextAnimTimer();
					return;
				}
			}
			else if (flag && centerTextShowType.Type == ECenterTextShowAnim.FadeOut)
			{
				this.TextAnimDataComp.SetSelectorOffset(0f);
				this.AnimMode = PlotTransitionView.ETextAnimMode.MultiLineFade;
				IICenterTextFadeOut iicenterTextFadeOut = centerTextShowType as IICenterTextFadeOut;
				float fadeInTime = iicenterTextFadeOut.FadeInTime;
				int lineNum2 = this.GetLineNum();
				this.SetTweenAndPlay(false, fadeInTime * (float)lineNum2);
				if (lineNum2 > 1)
				{
					this.CurLine = 1;
					this.OneLineTime = fadeInTime;
					this.FadeOutTime = iicenterTextFadeOut.FadeOutTime;
					this.LineCount = lineNum2;
					this.SetMultiLineTextAnimTimer();
					return;
				}
			}
			else
			{
				if (centerTextShowType.Type == ECenterTextShowAnim.TypeWriter)
				{
					this.AnimMode = PlotTransitionView.ETextAnimMode.TypeWriter;
					IICenterTextTypeWriter iicenterTextTypeWriter2 = centerTextShowType as IICenterTextTypeWriter;
					float num2 = (iicenterTextTypeWriter2.TextCountPerSecond > 0) ? ((float)iicenterTextTypeWriter2.TextCountPerSecond) : PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedSeq;
					float num3 = (float)textLength / num2;
					this.SetTweenAndPlay(true, num3);
					float num4 = 0f;
					if (centerText != null)
					{
						PlotCenterText plotCenterText3 = centerText;
						if (((plotCenterText3.Config != null) ? new bool?(plotCenterText3.Config.GetValueOrDefault().IsT1) : null).GetValueOrDefault())
						{
							num4 = centerText.Config.Value.AsT1.TotalTime.GetValueOrDefault();
							goto IL_3C1;
						}
					}
					if (centerText != null)
					{
						PlotCenterText plotCenterText4 = centerText;
						if (((plotCenterText4.Config != null) ? new bool?(plotCenterText4.Config.GetValueOrDefault().IsT2) : null).GetValueOrDefault())
						{
							num4 = centerText.Config.Value.AsT2.TotalTime.GetValueOrDefault();
						}
					}
					IL_3C1:
					this.TextTime = new float?(num4 + num3);
					return;
				}
				if (centerTextShowType.Type == ECenterTextShowAnim.FadeOut)
				{
					this.AnimMode = PlotTransitionView.ETextAnimMode.Fade;
					IICenterTextFadeOut iicenterTextFadeOut2 = centerTextShowType as IICenterTextFadeOut;
					float fadeInTime2 = iicenterTextFadeOut2.FadeInTime;
					float fadeOutTime = iicenterTextFadeOut2.FadeOutTime;
					this.SetTweenAndPlay(true, fadeInTime2);
					float num5 = 0f;
					bool? flag2;
					if (centerText == null)
					{
						flag2 = null;
					}
					else
					{
						PlotCenterText plotCenterText5 = centerText;
						flag2 = ((plotCenterText5.Config != null) ? new bool?(plotCenterText5.Config.GetValueOrDefault().IsT1) : null);
					}
					bool? flag3 = flag2;
					if (flag3.GetValueOrDefault())
					{
						num5 = centerText.Config.Value.AsT1.TotalTime.GetValueOrDefault();
					}
					else
					{
						bool? flag4;
						if (centerText == null)
						{
							flag4 = null;
						}
						else
						{
							PlotCenterText plotCenterText6 = centerText;
							flag4 = ((plotCenterText6.Config != null) ? new bool?(plotCenterText6.Config.GetValueOrDefault().IsT2) : null);
						}
						flag3 = flag4;
						if (flag3.GetValueOrDefault())
						{
							num5 = centerText.Config.Value.AsT2.TotalTime.GetValueOrDefault();
						}
					}
					this.TextAnimDelayId = TimerSystem.Instance.Delay(delegate(float _)
					{
						this.SetTweenAndPlay(false, fadeOutTime);
						this.TextAnimDelayId = null;
					}, (float)TimeUtil.Instance.SetTimeMillisecond((double)(fadeInTime2 + num5)), null, null, true, 1f);
					this.TextTime = new float?(fadeInTime2 + num5 + fadeOutTime);
					return;
				}
				this.TextAnimDataComp.SetSelectorOffset(0f);
			}
		}

		// Token: 0x060299DA RID: 170458 RVA: 0x00BC2188 File Offset: 0x00BC0388
		private void SetTextOverflowType()
		{
			PlotCenterText centerText = this.CenterText;
			bool flag = false;
			bool? flag2;
			if (centerText == null)
			{
				flag2 = null;
			}
			else
			{
				PlotCenterText plotCenterText = centerText;
				flag2 = ((plotCenterText.Config != null) ? new bool?(plotCenterText.Config.GetValueOrDefault().IsT1) : null);
			}
			bool? flag3 = flag2;
			if (flag3.GetValueOrDefault())
			{
				flag = centerText.Config.Value.AsT1.IsCancelAutoLine.GetValueOrDefault();
			}
			else
			{
				bool? flag4;
				if (centerText == null)
				{
					flag4 = null;
				}
				else
				{
					PlotCenterText plotCenterText2 = centerText;
					flag4 = ((plotCenterText2.Config != null) ? new bool?(plotCenterText2.Config.GetValueOrDefault().IsT2) : null);
				}
				flag3 = flag4;
				if (flag3.GetValueOrDefault())
				{
					flag = centerText.Config.Value.AsT2.IsCancelAutoLine.GetValueOrDefault();
				}
			}
			UITextOverflowType overflowType = flag ? UITextOverflowType.HorizontalOverflow : UITextOverflowType.VerticalOverflow;
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetOverflowType(overflowType);
			}
		}

		// Token: 0x060299DB RID: 170459 RVA: 0x00BC2290 File Offset: 0x00BC0490
		private void OnBtnSkipClick()
		{
			if (this.FadeDelayId != null)
			{
				return;
			}
			if (this.WaitingSkipTimerId != null)
			{
				this.WaitingSkipTimerId = null;
				this.ResumeNextLine();
			}
			if (this.TextShowDelayId == null)
			{
				return;
			}
			if (this.AnimMode == PlotTransitionView.ETextAnimMode.TypeWriter || this.AnimMode == PlotTransitionView.ETextAnimMode.Fade)
			{
				if (this.TextShowDelayId != null)
				{
					TimerSystem.Instance.Remove(this.TextShowDelayId);
				}
				this.TextShowDelayId = null;
				this.ClearAudio();
				base.GetText(0).SetUIActive(false);
				base.GetTexture(2).SetUIActive(false);
				this.ExecuteCallBack();
			}
		}

		// Token: 0x060299DC RID: 170460 RVA: 0x00BC231C File Offset: 0x00BC051C
		private void SetNextPageButtonActive(bool isActive)
		{
			base.GetButton(3).GetRootComponent().SetUIActive(isActive);
			this.HandleFullClickContinueBinding(isActive);
		}

		// Token: 0x060299DD RID: 170461 RVA: 0x00BC2338 File Offset: 0x00BC0538
		private void HandleFullClickContinueBinding(bool bind)
		{
			if (bind)
			{
				if (this.HasBindFullClickContinue)
				{
					return;
				}
				InputDistributeController.Instance.BindActionIgnoreLimit("全量点击继续", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputFullClickContinue));
				this.HasBindFullClickContinue = true;
				return;
			}
			else
			{
				if (!this.HasBindFullClickContinue)
				{
					return;
				}
				InputDistributeController.Instance.UnBindActionIgnoreLimit("全量点击继续", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputFullClickContinue));
				this.HasBindFullClickContinue = false;
				return;
			}
		}

		// Token: 0x060299DE RID: 170462 RVA: 0x00BC239F File Offset: 0x00BC059F
		[NullableContext(1)]
		private void OnInputFullClickContinue(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			this.OnBtnSkipClick();
		}

		// Token: 0x060299DF RID: 170463 RVA: 0x00BC23A8 File Offset: 0x00BC05A8
		private void SetMultiLineTextAnimTimer()
		{
			if (this.CurLine >= this.LineCount)
			{
				return;
			}
			this.TextAnimDelayId = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.SetTweenPauseOrResume(true);
				this.TextAnimDelayId = null;
				this.SetMultiLineWaitingSkipTimer();
			}, (float)TimeUtil.Instance.SetTimeMillisecond((double)this.OneLineTime), null, null, true, 1f);
		}

		// Token: 0x060299E0 RID: 170464 RVA: 0x00BC23FC File Offset: 0x00BC05FC
		private void SetMultiLineWaitingSkipTimer()
		{
			this.WaitingSkipTimerId = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.WaitingSkipTimerId = null;
				this.ResumeNextLine();
			}, (float)TimeUtil.Instance.SetTimeMillisecond((double)PlotModel.Instance.PlotGlobalConfig.EndWaitTimeCenterText), null, null, true, 1f);
		}

		// Token: 0x060299E1 RID: 170465 RVA: 0x00BC2448 File Offset: 0x00BC0648
		private void ResumeNextLine()
		{
			this.SetTweenPauseOrResume(false);
			this.CurLine++;
			if (this.AnimMode == PlotTransitionView.ETextAnimMode.MultiLineTypeWriter)
			{
				this.OneLineTime = (float)this.LineNumArray[this.CurLine - 1] / this.Speed;
			}
			this.SetMultiLineTextAnimTimer();
		}

		// Token: 0x060299E2 RID: 170466 RVA: 0x00BC249C File Offset: 0x00BC069C
		private int GetLineNum()
		{
			if (this.LineNumArray != null)
			{
				return this.LineNumArray.Count;
			}
			UUIText text = base.GetText(0);
			TArray<int> tarray = new TArray<int>();
			text.GetTextLineNumArray(ref tarray);
			this.LineNumArray = new List<int>();
			for (int i = 0; i < tarray.Num(); i++)
			{
				int item = tarray.Get(i);
				this.LineNumArray.Add(item);
			}
			return this.LineNumArray.Count;
		}

		// Token: 0x060299E3 RID: 170467 RVA: 0x00BC250C File Offset: 0x00BC070C
		[NullableContext(1)]
		public void FadeInScreen([Nullable(2)] FadeInScreen inParam, Action callback)
		{
			this.SetNextPageButtonActive(false);
			float num;
			if (inParam != null)
			{
				IEaseData ease = inParam.Ease;
				bool flag;
				if (ease == null)
				{
					flag = false;
				}
				else
				{
					float duration = ease.Duration;
					flag = true;
				}
				if (flag)
				{
					num = MathUtils.Instance.Clamp(inParam.Ease.Duration, 0f, 30f);
					goto IL_46;
				}
			}
			num = 1f;
			IL_46:
			float num2 = num;
			EFadeInScreenShowType? efadeInScreenShowType = (inParam != null) ? inParam.ScreenType : null;
			EFadeInScreenShowType efadeInScreenShowType2 = EFadeInScreenShowType.White;
			if (efadeInScreenShowType.GetValueOrDefault() == efadeInScreenShowType2 & efadeInScreenShowType != null)
			{
				base.GetTexture(1).SetColor(ColorUtils.ColorWhile);
			}
			this.Fade(false, num2);
			this.ExecuteCallBack();
			this.Callback = callback;
			if (this.FadeDelayId != null)
			{
				TimerSystem.Instance.Remove(this.FadeDelayId);
			}
			this.FadeDelayId = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.ExecuteCallBack();
				this.FadeDelayId = null;
			}, (float)TimeUtil.Instance.SetTimeMillisecond((double)num2), null, null, true, 1f);
		}

		// Token: 0x060299E4 RID: 170468 RVA: 0x00BC25FC File Offset: 0x00BC07FC
		[NullableContext(1)]
		public void FadeOutScreen([Nullable(2)] FadeOutScreen inParam, Action callback)
		{
			this.SetNextPageButtonActive(false);
			float num;
			if (inParam != null)
			{
				IEaseData ease = inParam.Ease;
				bool flag;
				if (ease == null)
				{
					flag = false;
				}
				else
				{
					float duration = ease.Duration;
					flag = true;
				}
				if (flag)
				{
					num = MathUtils.Instance.Clamp(inParam.Ease.Duration, 0f, 30f);
					goto IL_46;
				}
			}
			num = 1f;
			IL_46:
			float num2 = num;
			this.Fade(true, num2);
			this.ExecuteCallBack();
			this.Callback = callback;
			if (this.FadeDelayId != null)
			{
				TimerSystem.Instance.Remove(this.FadeDelayId);
			}
			this.FadeDelayId = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.ExecuteCallBack();
				this.FadeDelayId = null;
			}, (float)TimeUtil.Instance.SetTimeMillisecond((double)num2), null, null, true, 1f);
		}

		// Token: 0x04016B73 RID: 93043
		private const float TYPEWRITERRANGE = 0.01f;

		// Token: 0x04016B74 RID: 93044
		private const float FADEOUTRANGE = 9999f;

		// Token: 0x04016B75 RID: 93045
		private const float FADEMAXTIME = 30f;

		// Token: 0x04016B76 RID: 93046
		private const int PLAY_FLAG = 8;

		// Token: 0x04016B77 RID: 93047
		private UUIEffectTextAnimation TextAnimDataComp;

		// Token: 0x04016B78 RID: 93048
		private ULGUIPlayTweenComponent TextPlayTweenComp;

		// Token: 0x04016B79 RID: 93049
		private ULGUIPlayTweenComponent TexturePlayTweenComp;

		// Token: 0x04016B7A RID: 93050
		private TimerHandle TextShowDelayId;

		// Token: 0x04016B7B RID: 93051
		private TimerHandle TextAnimDelayId;

		// Token: 0x04016B7C RID: 93052
		private TimerHandle FadeDelayId;

		// Token: 0x04016B7D RID: 93053
		private float? TextTime = new float?(0f);

		// Token: 0x04016B7E RID: 93054
		private PlotCenterText CenterText;

		// Token: 0x04016B7F RID: 93055
		private Action Callback;

		// Token: 0x04016B80 RID: 93056
		[Nullable(1)]
		private readonly PlayResult PlotPlayEventResult = new PlayResult();

		// Token: 0x04016B81 RID: 93057
		private PlotTransitionView.ETextAnimMode AnimMode;

		// Token: 0x04016B82 RID: 93058
		private float OneLineTime;

		// Token: 0x04016B83 RID: 93059
		private float FadeOutTime;

		// Token: 0x04016B84 RID: 93060
		private int CurLine = 1;

		// Token: 0x04016B85 RID: 93061
		private int LineCount = 1;

		// Token: 0x04016B86 RID: 93062
		private float Speed;

		// Token: 0x04016B87 RID: 93063
		private List<int> LineNumArray;

		// Token: 0x04016B88 RID: 93064
		private TimerHandle WaitingSkipTimerId;

		// Token: 0x04016B89 RID: 93065
		private FLGUIPlayTweenCompleteDynamicDelegate TextPlayTweenEndCb;

		// Token: 0x04016B8A RID: 93066
		private FLGUIDelegateHandleWrapper TextPlayTweenEndCbWrapper;

		// Token: 0x04016B8B RID: 93067
		private IPostAkEventType TalkEndAkEvent;

		// Token: 0x04016B8C RID: 93068
		private bool HasBindFullClickContinue;

		// Token: 0x02009C07 RID: 39943
		[NullableContext(0)]
		private enum ETextAnimMode
		{
			// Token: 0x04030900 RID: 198912
			None,
			// Token: 0x04030901 RID: 198913
			TypeWriter,
			// Token: 0x04030902 RID: 198914
			Fade,
			// Token: 0x04030903 RID: 198915
			MultiLineTypeWriter,
			// Token: 0x04030904 RID: 198916
			MultiLineFade
		}

		// Token: 0x02009C08 RID: 39944
		[NullableContext(0)]
		private class EPlotTransitionView
		{
			// Token: 0x04030905 RID: 198917
			public const int Text = 0;

			// Token: 0x04030906 RID: 198918
			public const int TexBg = 1;

			// Token: 0x04030907 RID: 198919
			public const int TexContent = 2;

			// Token: 0x04030908 RID: 198920
			public const int BtnNextPage = 3;

			// Token: 0x04030909 RID: 198921
			public const int PnlFull = 4;

			// Token: 0x0403090A RID: 198922
			public const int PnlState = 5;
		}
	}
}
