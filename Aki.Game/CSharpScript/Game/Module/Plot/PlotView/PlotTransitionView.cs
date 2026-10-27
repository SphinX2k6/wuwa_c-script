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
	// Token: 0x02005064 RID: 20580
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTransitionView : UiViewBase
	{
		// Token: 0x06034ACB RID: 215755 RVA: 0x00C7379F File Offset: 0x00C7199F
		[NullableContext(1)]
		public PlotTransitionView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06034ACC RID: 215756 RVA: 0x00C737D4 File Offset: 0x00C719D4
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

		// Token: 0x06034ACD RID: 215757 RVA: 0x00C73900 File Offset: 0x00C71B00
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

		// Token: 0x06034ACE RID: 215758 RVA: 0x00C73AE4 File Offset: 0x00C71CE4
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			PlotTransitionView.<OnPlayingStartSequenceAsync>d__31 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PlotTransitionView.<OnPlayingStartSequenceAsync>d__31>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034ACF RID: 215759 RVA: 0x00C73B28 File Offset: 0x00C71D28
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			PlotTransitionView.<OnPlayingCloseSequenceAsync>d__32 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PlotTransitionView.<OnPlayingCloseSequenceAsync>d__32>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034AD0 RID: 215760 RVA: 0x00C73B6B File Offset: 0x00C71D6B
		public void ExecuteCallBack()
		{
			if (this.Callback != null)
			{
				Action callback = this.Callback;
				this.Callback = null;
				callback();
			}
		}

		// Token: 0x06034AD1 RID: 215761 RVA: 0x00C73B88 File Offset: 0x00C71D88
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

		// Token: 0x06034AD2 RID: 215762 RVA: 0x00C73BFC File Offset: 0x00C71DFC
		private void OnMultiLineTextPlayTweenEnd()
		{
			if (this.AnimMode != PlotTransitionView.ETextAnimMode.MultiLineFade && this.AnimMode != PlotTransitionView.ETextAnimMode.MultiLineTypeWriter)
			{
				return;
			}
			float endWaitTimeCenterText = PlotModel.Instance.PlotGlobalConfig.EndWaitTimeCenterText;
			this.SetTextTimer(endWaitTimeCenterText);
		}

		// Token: 0x06034AD3 RID: 215763 RVA: 0x00C73C34 File Offset: 0x00C71E34
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

		// Token: 0x06034AD4 RID: 215764 RVA: 0x00C73C8B File Offset: 0x00C71E8B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPlotTransitionRemoveCallback, new Action(this.RemoveCallback));
			EventSystem.Instance.Add(EEventName.UpdatePlotCenterText, new Action(this.OnUpdatePlotCenterText));
		}

		// Token: 0x06034AD5 RID: 215765 RVA: 0x00C73CC5 File Offset: 0x00C71EC5
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPlotTransitionRemoveCallback, new Action(this.RemoveCallback));
			EventSystem.Instance.Remove(EEventName.UpdatePlotCenterText, new Action(this.OnUpdatePlotCenterText));
		}

		// Token: 0x06034AD6 RID: 215766 RVA: 0x00C73CFF File Offset: 0x00C71EFF
		protected override void OnBeforeHide()
		{
			this.SetNextPageButtonActive(false);
		}

		// Token: 0x06034AD7 RID: 215767 RVA: 0x00C73D08 File Offset: 0x00C71F08
		private void RemoveCallback()
		{
			this.Callback = null;
		}

		// Token: 0x06034AD8 RID: 215768 RVA: 0x00C73D14 File Offset: 0x00C71F14
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

		// Token: 0x06034AD9 RID: 215769 RVA: 0x00C73FE8 File Offset: 0x00C721E8
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

		// Token: 0x06034ADA RID: 215770 RVA: 0x00C740BC File Offset: 0x00C722BC
		private void PlayTalkInterjection(Interjection config)
		{
			AudioController.Instance.PostEventByUi(config.AkEvent, this.PlotPlayEventResult, new int?(8), null);
		}

		// Token: 0x06034ADB RID: 215771 RVA: 0x00C740DC File Offset: 0x00C722DC
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

		// Token: 0x06034ADC RID: 215772 RVA: 0x00C7422C File Offset: 0x00C7242C
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

		// Token: 0x06034ADD RID: 215773 RVA: 0x00C742EC File Offset: 0x00C724EC
		private void SetTweenAndPlay(bool isReverse, float time)
		{
			ULGUIPlayTween_Float ulguiplayTween_Float = this.TextPlayTweenComp.GetPlayTween() as ULGUIPlayTween_Float;
			ulguiplayTween_Float.from = (isReverse ? 1f : 0f);
			ulguiplayTween_Float.to = (isReverse ? 0f : 1f);
			ulguiplayTween_Float.duration = time;
			this.TextPlayTweenComp.Play();
		}

		// Token: 0x06034ADE RID: 215774 RVA: 0x00C74344 File Offset: 0x00C72544
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

		// Token: 0x06034ADF RID: 215775 RVA: 0x00C74390 File Offset: 0x00C72590
		private void Fade(bool isReverse, float fadeTime)
		{
			ULGUIPlayTween_Float ulguiplayTween_Float = this.TexturePlayTweenComp.GetPlayTween() as ULGUIPlayTween_Float;
			ulguiplayTween_Float.from = (isReverse ? base.GetTexture(1).GetAlpha() : 0f);
			ulguiplayTween_Float.to = (isReverse ? 0f : 1f);
			ulguiplayTween_Float.duration = fadeTime;
			this.TexturePlayTweenComp.Play();
		}

		// Token: 0x06034AE0 RID: 215776 RVA: 0x00C743F0 File Offset: 0x00C725F0
		private void PlayAudio()
		{
			PlotAudio? plotAudio = string.IsNullOrEmpty(this.CenterText.AudioId) ? null : ConfigPlotAudioById.GetConfig(this.CenterText.AudioId, true);
			if (plotAudio == null)
			{
				return;
			}
			this.PlayAudioInner(plotAudio.Value);
		}

		// Token: 0x06034AE1 RID: 215777 RVA: 0x00C74444 File Offset: 0x00C72644
		private void PlayAudioInner(PlotAudio config)
		{
			ExternalSourceSetting? config2 = ConfigExternalSourceSettingById.GetConfig(config.ExternalSourceSetting, true);
			string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(config);
			AudioController.Instance.PostEventByExternalSourcesByUi(config2.Value.SubtitleEvent, externalSourcesMediaName, config2.Value.SubtitleSrc, this.PlotPlayEventResult, null, new int?(8), null);
		}

		// Token: 0x06034AE2 RID: 215778 RVA: 0x00C744A4 File Offset: 0x00C726A4
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

		// Token: 0x06034AE3 RID: 215779 RVA: 0x00C74558 File Offset: 0x00C72758
		private void ClearAudio()
		{
			this.PlayAkEvent(this.TalkEndAkEvent);
			this.TalkEndAkEvent = null;
			AudioController.Instance.StopEvent(this.PlotPlayEventResult, true, null);
		}

		// Token: 0x06034AE4 RID: 215780 RVA: 0x00C74594 File Offset: 0x00C72794
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

		// Token: 0x06034AE5 RID: 215781 RVA: 0x00C747C0 File Offset: 0x00C729C0
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

		// Token: 0x06034AE6 RID: 215782 RVA: 0x00C7490C File Offset: 0x00C72B0C
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

		// Token: 0x06034AE7 RID: 215783 RVA: 0x00C74E64 File Offset: 0x00C73064
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

		// Token: 0x06034AE8 RID: 215784 RVA: 0x00C74F6C File Offset: 0x00C7316C
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

		// Token: 0x06034AE9 RID: 215785 RVA: 0x00C74FF8 File Offset: 0x00C731F8
		private void SetNextPageButtonActive(bool isActive)
		{
			base.GetButton(3).GetRootComponent().SetUIActive(isActive);
			this.HandleFullClickContinueBinding(isActive);
		}

		// Token: 0x06034AEA RID: 215786 RVA: 0x00C75014 File Offset: 0x00C73214
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

		// Token: 0x06034AEB RID: 215787 RVA: 0x00C7507B File Offset: 0x00C7327B
		[NullableContext(1)]
		private void OnInputFullClickContinue(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			this.OnBtnSkipClick();
		}

		// Token: 0x06034AEC RID: 215788 RVA: 0x00C75084 File Offset: 0x00C73284
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

		// Token: 0x06034AED RID: 215789 RVA: 0x00C750D8 File Offset: 0x00C732D8
		private void SetMultiLineWaitingSkipTimer()
		{
			this.WaitingSkipTimerId = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.WaitingSkipTimerId = null;
				this.ResumeNextLine();
			}, (float)TimeUtil.Instance.SetTimeMillisecond((double)PlotModel.Instance.PlotGlobalConfig.EndWaitTimeCenterText), null, null, true, 1f);
		}

		// Token: 0x06034AEE RID: 215790 RVA: 0x00C75124 File Offset: 0x00C73324
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

		// Token: 0x06034AEF RID: 215791 RVA: 0x00C75178 File Offset: 0x00C73378
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

		// Token: 0x06034AF0 RID: 215792 RVA: 0x00C751E8 File Offset: 0x00C733E8
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

		// Token: 0x06034AF1 RID: 215793 RVA: 0x00C752D8 File Offset: 0x00C734D8
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

		// Token: 0x0401C148 RID: 115016
		private const float TYPEWRITERRANGE = 0.01f;

		// Token: 0x0401C149 RID: 115017
		private const float FADEOUTRANGE = 9999f;

		// Token: 0x0401C14A RID: 115018
		private const float FADEMAXTIME = 30f;

		// Token: 0x0401C14B RID: 115019
		private const int PLAY_FLAG = 8;

		// Token: 0x0401C14C RID: 115020
		private UUIEffectTextAnimation TextAnimDataComp;

		// Token: 0x0401C14D RID: 115021
		private ULGUIPlayTweenComponent TextPlayTweenComp;

		// Token: 0x0401C14E RID: 115022
		private ULGUIPlayTweenComponent TexturePlayTweenComp;

		// Token: 0x0401C14F RID: 115023
		private TimerHandle TextShowDelayId;

		// Token: 0x0401C150 RID: 115024
		private TimerHandle TextAnimDelayId;

		// Token: 0x0401C151 RID: 115025
		private TimerHandle FadeDelayId;

		// Token: 0x0401C152 RID: 115026
		private float? TextTime = new float?(0f);

		// Token: 0x0401C153 RID: 115027
		private PlotCenterText CenterText;

		// Token: 0x0401C154 RID: 115028
		private Action Callback;

		// Token: 0x0401C155 RID: 115029
		[Nullable(1)]
		private readonly PlayResult PlotPlayEventResult = new PlayResult();

		// Token: 0x0401C156 RID: 115030
		private PlotTransitionView.ETextAnimMode AnimMode;

		// Token: 0x0401C157 RID: 115031
		private float OneLineTime;

		// Token: 0x0401C158 RID: 115032
		private float FadeOutTime;

		// Token: 0x0401C159 RID: 115033
		private int CurLine = 1;

		// Token: 0x0401C15A RID: 115034
		private int LineCount = 1;

		// Token: 0x0401C15B RID: 115035
		private float Speed;

		// Token: 0x0401C15C RID: 115036
		private List<int> LineNumArray;

		// Token: 0x0401C15D RID: 115037
		private TimerHandle WaitingSkipTimerId;

		// Token: 0x0401C15E RID: 115038
		private FLGUIPlayTweenCompleteDynamicDelegate TextPlayTweenEndCb;

		// Token: 0x0401C15F RID: 115039
		private FLGUIDelegateHandleWrapper TextPlayTweenEndCbWrapper;

		// Token: 0x0401C160 RID: 115040
		private IPostAkEventType TalkEndAkEvent;

		// Token: 0x0401C161 RID: 115041
		private bool HasBindFullClickContinue;

		// Token: 0x0200B1CD RID: 45517
		[NullableContext(0)]
		private enum ETextAnimMode
		{
			// Token: 0x04035EAB RID: 220843
			None,
			// Token: 0x04035EAC RID: 220844
			TypeWriter,
			// Token: 0x04035EAD RID: 220845
			Fade,
			// Token: 0x04035EAE RID: 220846
			MultiLineTypeWriter,
			// Token: 0x04035EAF RID: 220847
			MultiLineFade
		}

		// Token: 0x0200B1CE RID: 45518
		[NullableContext(0)]
		private class EPlotTransitionView
		{
			// Token: 0x04035EB0 RID: 220848
			public const int Text = 0;

			// Token: 0x04035EB1 RID: 220849
			public const int TexBg = 1;

			// Token: 0x04035EB2 RID: 220850
			public const int TexContent = 2;

			// Token: 0x04035EB3 RID: 220851
			public const int BtnNextPage = 3;

			// Token: 0x04035EB4 RID: 220852
			public const int PnlFull = 4;

			// Token: 0x04035EB5 RID: 220853
			public const int PnlState = 5;
		}
	}
}
