using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.Module.Plot.TipsTalk;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200403C RID: 16444
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotViewManager
	{
		// Token: 0x06029ABF RID: 170687 RVA: 0x00BC73D8 File Offset: 0x00BC55D8
		public void RegisterEvent()
		{
			EventSystem.Instance.Add<EUiViewName, bool>(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotViewChange));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Add<bool>(EEventName.OnTutorialTipExistChanged, new Action<bool>(this.InterruptHud));
			EventSystem.Instance.Add<EUiViewName>(EEventName.OpenViewFail, new Action<EUiViewName>(this.OpenViewFail));
			EventSystem.Instance.Add<bool>(EEventName.BattleUiSlowTimeVisibleChanged, new Action<bool>(this.OnBattleUiSlowTimeVisibleChanged));
		}

		// Token: 0x06029AC0 RID: 170688 RVA: 0x00BC7484 File Offset: 0x00BC5684
		public void UnRegisterEvent()
		{
			EventSystem.Instance.Remove<EUiViewName, bool>(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotViewChange));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove<bool>(EEventName.OnTutorialTipExistChanged, new Action<bool>(this.InterruptHud));
			EventSystem.Instance.Remove<EUiViewName>(EEventName.OpenViewFail, new Action<EUiViewName>(this.OpenViewFail));
			EventSystem.Instance.Remove<bool>(EEventName.BattleUiSlowTimeVisibleChanged, new Action<bool>(this.OnBattleUiSlowTimeVisibleChanged));
		}

		// Token: 0x06029AC1 RID: 170689 RVA: 0x00BC7530 File Offset: 0x00BC5730
		private unsafe void OnPlotViewChange(EUiViewName name, bool isShow)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[PlotView] ViewChange";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("name", name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isShow", isShow);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (this.IsSwitching && this.SwitchToView != name)
			{
				return;
			}
			if (this.CurrentView != name)
			{
				return;
			}
			if (isShow && !this.ViewEnable)
			{
				return;
			}
			this.IsShowing = isShow;
			if (this.IsShowing)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Plot;
				ELogAuthor author2 = ELogAuthor.FZX;
				string message2 = "[PlotView] 界面显示，打开完成";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("open", this.CurrentView);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.HandleCurrentViewShown().Forget();
			}
		}

		// Token: 0x06029AC2 RID: 170690 RVA: 0x00BC7643 File Offset: 0x00BC5843
		public EUiViewName? GetCurrentViewName()
		{
			return this.CurrentView;
		}

		// Token: 0x06029AC3 RID: 170691 RVA: 0x00BC764B File Offset: 0x00BC584B
		private void OnOpenView(EUiViewName viewName, int viewId)
		{
		}

		// Token: 0x06029AC4 RID: 170692 RVA: 0x00BC764D File Offset: 0x00BC584D
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			this.ViewCloseCheck(viewName);
		}

		// Token: 0x06029AC5 RID: 170693 RVA: 0x00BC7658 File Offset: 0x00BC5858
		private void OpenViewFail(EUiViewName viewName)
		{
			if (!this.ViewEnable || viewName != this.CurrentView)
			{
				return;
			}
			global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.FZX, "[PlotView] 剧情界面打开失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.CurrentView = null;
			this.CurrentViewOwnerId = null;
			this.IsShowing = false;
			this.ViewEnable = false;
			this.IsLock = true;
			this.FinishSwitching();
			this.DoCallback(false);
			this.CancelPendingViewOperations();
			FlowController.Instance.BackgroundFlow("剧情界面打开失败 跳过剧情", false, false, false);
			this.CheckPending();
		}

		// Token: 0x06029AC6 RID: 170694 RVA: 0x00BC7706 File Offset: 0x00BC5906
		public void OnUpdateSubtitle(ITalkItem talkItem)
		{
			PlotModel.Instance.CurTalkItem = talkItem;
			EventSystem.Instance.Emit<ITalkItem, bool>(EEventName.PlotShowTalk, talkItem, true);
			FlowController.Instance.RecordTalkItem(talkItem);
		}

		// Token: 0x06029AC7 RID: 170695 RVA: 0x00BC7730 File Offset: 0x00BC5930
		public bool UpdateTipsSubtitle(ITalkItem talkItem)
		{
			if (this.TipsView == null)
			{
				return false;
			}
			this.OnUpdateSubtitle(talkItem);
			this.TipsView.RefreshSubtitle(talkItem);
			return true;
		}

		// Token: 0x06029AC8 RID: 170696 RVA: 0x00BC7750 File Offset: 0x00BC5950
		public void OnSubmitSubtitle()
		{
			EventSystem.Instance.Emit<ITalkItem, bool>(EEventName.PlotShowTalk, PlotModel.Instance.CurTalkItem, false);
			PlotModel.Instance.CurTalkItem = null;
		}

		// Token: 0x06029AC9 RID: 170697 RVA: 0x00BC7778 File Offset: 0x00BC5978
		public void OnShowOptions()
		{
			PlotModel.Instance.InOptions = true;
		}

		// Token: 0x06029ACA RID: 170698 RVA: 0x00BC7788 File Offset: 0x00BC5988
		public void UpdatePlotSubtitle(ITalkItem talkItem)
		{
			PlotViewManager.<>c__DisplayClass24_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass24_0();
			CS$<>8__locals1.talkItem = talkItem;
			this.OnUpdateSubtitle(CS$<>8__locals1.talkItem);
			this.RunWhenCurrentViewReady("UpdatePlotSubtitle", delegate
			{
				PlotViewManager.<>c__DisplayClass24_0.<<UpdatePlotSubtitle>b__0>d <<UpdatePlotSubtitle>b__0>d;
				<<UpdatePlotSubtitle>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<UpdatePlotSubtitle>b__0>d.<>4__this = CS$<>8__locals1;
				<<UpdatePlotSubtitle>b__0>d.<>1__state = -1;
				<<UpdatePlotSubtitle>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass24_0.<<UpdatePlotSubtitle>b__0>d>(ref <<UpdatePlotSubtitle>b__0>d);
				return <<UpdatePlotSubtitle>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06029ACB RID: 170699 RVA: 0x00BC77CB File Offset: 0x00BC59CB
		public void ShowPlotSubtitleOptions()
		{
			this.OnShowOptions();
			this.RunWhenCurrentViewReady("ShowPlotSubtitleOptions", delegate
			{
				PlotViewManager.<>c.<<ShowPlotSubtitleOptions>b__25_0>d <<ShowPlotSubtitleOptions>b__25_0>d;
				<<ShowPlotSubtitleOptions>b__25_0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<ShowPlotSubtitleOptions>b__25_0>d.<>1__state = -1;
				<<ShowPlotSubtitleOptions>b__25_0>d.<>t__builder.Start<PlotViewManager.<>c.<<ShowPlotSubtitleOptions>b__25_0>d>(ref <<ShowPlotSubtitleOptions>b__25_0>d);
				return <<ShowPlotSubtitleOptions>b__25_0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06029ACC RID: 170700 RVA: 0x00BC7804 File Offset: 0x00BC5A04
		public void EmitPlotStartShowTalk(ShowTalk showTalk)
		{
			PlotViewManager.<>c__DisplayClass26_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass26_0();
			CS$<>8__locals1.showTalk = showTalk;
			this.RunWhenCurrentViewReady("PlotStartShowTalk", delegate
			{
				PlotViewManager.<>c__DisplayClass26_0.<<EmitPlotStartShowTalk>b__0>d <<EmitPlotStartShowTalk>b__0>d;
				<<EmitPlotStartShowTalk>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<EmitPlotStartShowTalk>b__0>d.<>4__this = CS$<>8__locals1;
				<<EmitPlotStartShowTalk>b__0>d.<>1__state = -1;
				<<EmitPlotStartShowTalk>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass26_0.<<EmitPlotStartShowTalk>b__0>d>(ref <<EmitPlotStartShowTalk>b__0>d);
				return <<EmitPlotStartShowTalk>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06029ACD RID: 170701 RVA: 0x00BC783C File Offset: 0x00BC5A3C
		public void UpdatePortraitVisible(SetHeadIconVisible config, Action callback)
		{
			PlotViewManager.<>c__DisplayClass27_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass27_0();
			CS$<>8__locals1.config = config;
			CS$<>8__locals1.callback = callback;
			this.RunWhenCurrentViewReady("UpdatePortraitVisible", delegate
			{
				PlotViewManager.<>c__DisplayClass27_0.<<UpdatePortraitVisible>b__0>d <<UpdatePortraitVisible>b__0>d;
				<<UpdatePortraitVisible>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<UpdatePortraitVisible>b__0>d.<>4__this = CS$<>8__locals1;
				<<UpdatePortraitVisible>b__0>d.<>1__state = -1;
				<<UpdatePortraitVisible>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass27_0.<<UpdatePortraitVisible>b__0>d>(ref <<UpdatePortraitVisible>b__0>d);
				return <<UpdatePortraitVisible>b__0>d.<>t__builder.Task;
			}, CS$<>8__locals1.callback).Forget<bool>();
		}

		// Token: 0x06029ACE RID: 170702 RVA: 0x00BC7880 File Offset: 0x00BC5A80
		public void StopPlotVoiceOnInterrupt(long ownerId)
		{
			if (!this.CheckOwner("StopPlotVoiceOnInterrupt", new long?(ownerId)))
			{
				return;
			}
			PlotConfig plotConfig = PlotModel.Instance.PlotConfig;
			IPlotAudioConfig audioConfig = plotConfig.AudioConfig;
			IPlotVoiceFadeOutOnInterrupt plotVoiceFadeOutOnInterrupt = (audioConfig != null) ? audioConfig.VoiceFadeOutOnInterrupt : null;
			if (plotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelD && plotVoiceFadeOutOnInterrupt != null)
			{
				PlotViewHud plotViewHud = this.GetCurrentView() as PlotViewHud;
				if (plotViewHud != null)
				{
					int value = float.IsFinite(plotVoiceFadeOutOnInterrupt.FadeDuration) ? ((int)Math.Clamp((double)plotVoiceFadeOutOnInterrupt.FadeDuration, 0.0, 2147483647.0)) : 0;
					EAudioFadeCurve value2 = (plotVoiceFadeOutOnInterrupt.FadeCurve != null) ? ((EAudioFadeCurve)plotVoiceFadeOutOnInterrupt.FadeCurve.Value) : EAudioFadeCurve.Linear;
					plotViewHud.StopVoiceOnInterrupt(new ExecuteActionArgs(new int?(value), new EAudioFadeCurve?(value2), null));
					return;
				}
			}
		}

		// Token: 0x06029ACF RID: 170703 RVA: 0x00BC794C File Offset: 0x00BC5B4C
		public void ClearPlotSubtitle(long? ownerId = null)
		{
			if (!this.CheckOwner("ClearPlotSubtitle", ownerId))
			{
				return;
			}
			this.RunWhenCurrentViewReady("ClearPlotSubtitle", delegate
			{
				PlotViewManager.<>c.<<ClearPlotSubtitle>b__29_0>d <<ClearPlotSubtitle>b__29_0>d;
				<<ClearPlotSubtitle>b__29_0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<ClearPlotSubtitle>b__29_0>d.<>1__state = -1;
				<<ClearPlotSubtitle>b__29_0>d.<>t__builder.Start<PlotViewManager.<>c.<<ClearPlotSubtitle>b__29_0>d>(ref <<ClearPlotSubtitle>b__29_0>d);
				return <<ClearPlotSubtitle>b__29_0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06029AD0 RID: 170704 RVA: 0x00BC7998 File Offset: 0x00BC5B98
		public void HidePlotUi(bool isHidden, long? ownerId = null)
		{
			PlotViewManager.<>c__DisplayClass30_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass30_0();
			CS$<>8__locals1.isHidden = isHidden;
			if (!this.CheckOwner("HidePlotUi", ownerId))
			{
				return;
			}
			this.RunWhenCurrentViewReady("HidePlotUi", delegate
			{
				PlotViewManager.<>c__DisplayClass30_0.<<HidePlotUi>b__0>d <<HidePlotUi>b__0>d;
				<<HidePlotUi>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<HidePlotUi>b__0>d.<>4__this = CS$<>8__locals1;
				<<HidePlotUi>b__0>d.<>1__state = -1;
				<<HidePlotUi>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass30_0.<<HidePlotUi>b__0>d>(ref <<HidePlotUi>b__0>d);
				return <<HidePlotUi>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06029AD1 RID: 170705 RVA: 0x00BC79E0 File Offset: 0x00BC5BE0
		[NullableContext(2)]
		public void PlotViewBgFadePhoto(bool isFadeIn, bool isFull, string path = null, Action callback = null)
		{
			PlotViewManager.<>c__DisplayClass31_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass31_0();
			CS$<>8__locals1.isFadeIn = isFadeIn;
			CS$<>8__locals1.isFull = isFull;
			CS$<>8__locals1.path = path;
			CS$<>8__locals1.callback = callback;
			this.RunWithPlotView("PlotViewBgFadePhoto", delegate(PlotView _)
			{
				PlotViewManager.<>c__DisplayClass31_0.<<PlotViewBgFadePhoto>b__0>d <<PlotViewBgFadePhoto>b__0>d;
				<<PlotViewBgFadePhoto>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<PlotViewBgFadePhoto>b__0>d.<>4__this = CS$<>8__locals1;
				<<PlotViewBgFadePhoto>b__0>d.<>1__state = -1;
				<<PlotViewBgFadePhoto>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass31_0.<<PlotViewBgFadePhoto>b__0>d>(ref <<PlotViewBgFadePhoto>b__0>d);
				return <<PlotViewBgFadePhoto>b__0>d.<>t__builder.Task;
			}, CS$<>8__locals1.callback).Forget<bool>();
		}

		// Token: 0x06029AD2 RID: 170706 RVA: 0x00BC7A34 File Offset: 0x00BC5C34
		[NullableContext(2)]
		public void PlotViewBgFadeBlackScreen(bool isFadeIn, Action callback = null)
		{
			PlotViewManager.<>c__DisplayClass32_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass32_0();
			CS$<>8__locals1.isFadeIn = isFadeIn;
			CS$<>8__locals1.callback = callback;
			this.RunWhenCurrentViewReady("PlotViewBgFadeBlackScreen", delegate
			{
				PlotViewManager.<>c__DisplayClass32_0.<<PlotViewBgFadeBlackScreen>b__0>d <<PlotViewBgFadeBlackScreen>b__0>d;
				<<PlotViewBgFadeBlackScreen>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<PlotViewBgFadeBlackScreen>b__0>d.<>4__this = CS$<>8__locals1;
				<<PlotViewBgFadeBlackScreen>b__0>d.<>1__state = -1;
				<<PlotViewBgFadeBlackScreen>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass32_0.<<PlotViewBgFadeBlackScreen>b__0>d>(ref <<PlotViewBgFadeBlackScreen>b__0>d);
				return <<PlotViewBgFadeBlackScreen>b__0>d.<>t__builder.Task;
			}, CS$<>8__locals1.callback).Forget<bool>();
		}

		// Token: 0x06029AD3 RID: 170707 RVA: 0x00BC7A78 File Offset: 0x00BC5C78
		public void PlotDoingTextShow(bool isShow)
		{
			PlotViewManager.<>c__DisplayClass33_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass33_0();
			CS$<>8__locals1.isShow = isShow;
			this.RunWithPlotSubtitleViewChecked("PlotDoingTextShow", delegate
			{
				PlotViewManager.<>c__DisplayClass33_0.<<PlotDoingTextShow>b__0>d <<PlotDoingTextShow>b__0>d;
				<<PlotDoingTextShow>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<PlotDoingTextShow>b__0>d.<>4__this = CS$<>8__locals1;
				<<PlotDoingTextShow>b__0>d.<>1__state = -1;
				<<PlotDoingTextShow>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass33_0.<<PlotDoingTextShow>b__0>d>(ref <<PlotDoingTextShow>b__0>d);
				return <<PlotDoingTextShow>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06029AD4 RID: 170708 RVA: 0x00BC7AB0 File Offset: 0x00BC5CB0
		[NullableContext(2)]
		public void EnableInteractPlot(bool enable, bool? includeSubtitleButton = null, string reason = null)
		{
			PlotViewManager.<>c__DisplayClass34_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass34_0();
			CS$<>8__locals1.enable = enable;
			CS$<>8__locals1.includeSubtitleButton = includeSubtitleButton;
			CS$<>8__locals1.reason = reason;
			this.RunWithPlotSubtitleViewChecked("EnableInteractPlot", delegate
			{
				PlotViewManager.<>c__DisplayClass34_0.<<EnableInteractPlot>b__0>d <<EnableInteractPlot>b__0>d;
				<<EnableInteractPlot>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<EnableInteractPlot>b__0>d.<>4__this = CS$<>8__locals1;
				<<EnableInteractPlot>b__0>d.<>1__state = -1;
				<<EnableInteractPlot>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass34_0.<<EnableInteractPlot>b__0>d>(ref <<EnableInteractPlot>b__0>d);
				return <<EnableInteractPlot>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06029AD5 RID: 170709 RVA: 0x00BC7AF8 File Offset: 0x00BC5CF8
		public void EnableSkipPlotByReason(bool enable, string reason)
		{
			PlotViewManager.<>c__DisplayClass35_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass35_0();
			CS$<>8__locals1.enable = enable;
			CS$<>8__locals1.reason = reason;
			this.RunWithPlotSubtitleViewChecked("EnableSkipPlotByReason", delegate
			{
				PlotViewManager.<>c__DisplayClass35_0.<<EnableSkipPlotByReason>b__0>d <<EnableSkipPlotByReason>b__0>d;
				<<EnableSkipPlotByReason>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<EnableSkipPlotByReason>b__0>d.<>4__this = CS$<>8__locals1;
				<<EnableSkipPlotByReason>b__0>d.<>1__state = -1;
				<<EnableSkipPlotByReason>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass35_0.<<EnableSkipPlotByReason>b__0>d>(ref <<EnableSkipPlotByReason>b__0>d);
				return <<EnableSkipPlotByReason>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06029AD6 RID: 170710 RVA: 0x00BC7B38 File Offset: 0x00BC5D38
		public void UpdateSeqSubtitle(PlotSubtitleConfig subtitle)
		{
			PlotViewManager.<>c__DisplayClass36_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass36_0();
			CS$<>8__locals1.subtitle = subtitle;
			this.RunWhenCurrentViewReady("UpdateSeqSubtitle", delegate
			{
				PlotViewManager.<>c__DisplayClass36_0.<<UpdateSeqSubtitle>b__0>d <<UpdateSeqSubtitle>b__0>d;
				<<UpdateSeqSubtitle>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<UpdateSeqSubtitle>b__0>d.<>4__this = CS$<>8__locals1;
				<<UpdateSeqSubtitle>b__0>d.<>1__state = -1;
				<<UpdateSeqSubtitle>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass36_0.<<UpdateSeqSubtitle>b__0>d>(ref <<UpdateSeqSubtitle>b__0>d);
				return <<UpdateSeqSubtitle>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06029AD7 RID: 170711 RVA: 0x00BC7B70 File Offset: 0x00BC5D70
		public void HandleSeqSubtitleEnd(int id, bool isSkip)
		{
			PlotViewManager.<>c__DisplayClass37_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass37_0();
			CS$<>8__locals1.id = id;
			CS$<>8__locals1.isSkip = isSkip;
			this.RunWhenCurrentViewReady("HandleSeqSubtitleEnd", delegate
			{
				PlotViewManager.<>c__DisplayClass37_0.<<HandleSeqSubtitleEnd>b__0>d <<HandleSeqSubtitleEnd>b__0>d;
				<<HandleSeqSubtitleEnd>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<HandleSeqSubtitleEnd>b__0>d.<>4__this = CS$<>8__locals1;
				<<HandleSeqSubtitleEnd>b__0>d.<>1__state = -1;
				<<HandleSeqSubtitleEnd>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass37_0.<<HandleSeqSubtitleEnd>b__0>d>(ref <<HandleSeqSubtitleEnd>b__0>d);
				return <<HandleSeqSubtitleEnd>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06029AD8 RID: 170712 RVA: 0x00BC7BB0 File Offset: 0x00BC5DB0
		public void HandlePlotOptionSelected(int option)
		{
			PlotViewManager.<>c__DisplayClass38_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass38_0();
			CS$<>8__locals1.option = option;
			this.RunWhenCurrentViewReady("HandlePlotOptionSelected", delegate
			{
				PlotViewManager.<>c__DisplayClass38_0.<<HandlePlotOptionSelected>b__0>d <<HandlePlotOptionSelected>b__0>d;
				<<HandlePlotOptionSelected>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<HandlePlotOptionSelected>b__0>d.<>4__this = CS$<>8__locals1;
				<<HandlePlotOptionSelected>b__0>d.<>1__state = -1;
				<<HandlePlotOptionSelected>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass38_0.<<HandlePlotOptionSelected>b__0>d>(ref <<HandlePlotOptionSelected>b__0>d);
				return <<HandlePlotOptionSelected>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06029AD9 RID: 170713 RVA: 0x00BC7BE7 File Offset: 0x00BC5DE7
		public void HandleSubSequenceStop()
		{
			this.RunWhenCurrentViewReady("HandleSubSequenceStop", delegate
			{
				PlotViewManager.<>c.<<HandleSubSequenceStop>b__39_0>d <<HandleSubSequenceStop>b__39_0>d;
				<<HandleSubSequenceStop>b__39_0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<HandleSubSequenceStop>b__39_0>d.<>1__state = -1;
				<<HandleSubSequenceStop>b__39_0>d.<>t__builder.Start<PlotViewManager.<>c.<<HandleSubSequenceStop>b__39_0>d>(ref <<HandleSubSequenceStop>b__39_0>d);
				return <<HandleSubSequenceStop>b__39_0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06029ADA RID: 170714 RVA: 0x00BC7C19 File Offset: 0x00BC5E19
		public void HangPlotViewHud(bool isHang)
		{
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, isHang);
		}

		// Token: 0x06029ADB RID: 170715 RVA: 0x00BC7C2C File Offset: 0x00BC5E2C
		[NullableContext(0)]
		public UniTask<bool> RunWithPlotView([Nullable(1)] string name, [Nullable(new byte[]
		{
			1,
			1,
			0,
			2
		})] Func<PlotView, UniTask<object>> operation, [Nullable(2)] Action onCancel = null)
		{
			PlotViewManager.<>c__DisplayClass41_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass41_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.name = name;
			CS$<>8__locals1.operation = operation;
			return this.RunWhenCurrentViewReady(CS$<>8__locals1.name, delegate
			{
				PlotViewManager.<>c__DisplayClass41_0.<<RunWithPlotView>b__0>d <<RunWithPlotView>b__0>d;
				<<RunWithPlotView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<RunWithPlotView>b__0>d.<>4__this = CS$<>8__locals1;
				<<RunWithPlotView>b__0>d.<>1__state = -1;
				<<RunWithPlotView>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass41_0.<<RunWithPlotView>b__0>d>(ref <<RunWithPlotView>b__0>d);
				return <<RunWithPlotView>b__0>d.<>t__builder.Task;
			}, onCancel);
		}

		// Token: 0x06029ADC RID: 170716 RVA: 0x00BC7C70 File Offset: 0x00BC5E70
		[return: Nullable(0)]
		public UniTask<bool> RunWithPlotSubtitleViewChecked(string name, PlotUiAsyncOperation operation, [Nullable(2)] Action onCancel = null)
		{
			PlotViewManager.<>c__DisplayClass42_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass42_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.name = name;
			CS$<>8__locals1.operation = operation;
			return this.RunWhenCurrentViewReady(CS$<>8__locals1.name, delegate
			{
				PlotViewManager.<>c__DisplayClass42_0.<<RunWithPlotSubtitleViewChecked>b__0>d <<RunWithPlotSubtitleViewChecked>b__0>d;
				<<RunWithPlotSubtitleViewChecked>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<RunWithPlotSubtitleViewChecked>b__0>d.<>4__this = CS$<>8__locals1;
				<<RunWithPlotSubtitleViewChecked>b__0>d.<>1__state = -1;
				<<RunWithPlotSubtitleViewChecked>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass42_0.<<RunWithPlotSubtitleViewChecked>b__0>d>(ref <<RunWithPlotSubtitleViewChecked>b__0>d);
				return <<RunWithPlotSubtitleViewChecked>b__0>d.<>t__builder.Task;
			}, onCancel);
		}

		// Token: 0x06029ADD RID: 170717 RVA: 0x00BC7CB4 File Offset: 0x00BC5EB4
		[NullableContext(0)]
		public UniTask<bool> RunWithPlotSubtitleView([Nullable(1)] string name, [Nullable(new byte[]
		{
			1,
			1,
			0,
			2
		})] Func<PlotSubtitleView, UniTask<object>> operation, [Nullable(2)] Action onCancel = null)
		{
			PlotViewManager.<>c__DisplayClass43_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass43_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.name = name;
			CS$<>8__locals1.operation = operation;
			return this.RunWhenCurrentViewReady(CS$<>8__locals1.name, delegate
			{
				PlotViewManager.<>c__DisplayClass43_0.<<RunWithPlotSubtitleView>b__0>d <<RunWithPlotSubtitleView>b__0>d;
				<<RunWithPlotSubtitleView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<RunWithPlotSubtitleView>b__0>d.<>4__this = CS$<>8__locals1;
				<<RunWithPlotSubtitleView>b__0>d.<>1__state = -1;
				<<RunWithPlotSubtitleView>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass43_0.<<RunWithPlotSubtitleView>b__0>d>(ref <<RunWithPlotSubtitleView>b__0>d);
				return <<RunWithPlotSubtitleView>b__0>d.<>t__builder.Task;
			}, onCancel);
		}

		// Token: 0x06029ADE RID: 170718 RVA: 0x00BC7CF8 File Offset: 0x00BC5EF8
		[return: Nullable(0)]
		public UniTask<bool> RunWithPlotSubtitleView(string name, Func<PlotSubtitleView, UniTask> operation, [Nullable(2)] Action onCancel = null)
		{
			PlotViewManager.<>c__DisplayClass44_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass44_0();
			CS$<>8__locals1.operation = operation;
			return this.RunWithPlotSubtitleView(name, delegate(PlotSubtitleView view)
			{
				PlotViewManager.<>c__DisplayClass44_0.<<RunWithPlotSubtitleView>b__0>d <<RunWithPlotSubtitleView>b__0>d;
				<<RunWithPlotSubtitleView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<RunWithPlotSubtitleView>b__0>d.<>4__this = CS$<>8__locals1;
				<<RunWithPlotSubtitleView>b__0>d.view = view;
				<<RunWithPlotSubtitleView>b__0>d.<>1__state = -1;
				<<RunWithPlotSubtitleView>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass44_0.<<RunWithPlotSubtitleView>b__0>d>(ref <<RunWithPlotSubtitleView>b__0>d);
				return <<RunWithPlotSubtitleView>b__0>d.<>t__builder.Task;
			}, onCancel);
		}

		// Token: 0x06029ADF RID: 170719 RVA: 0x00BC7D26 File Offset: 0x00BC5F26
		public void OnSelectedOptions()
		{
			PlotModel.Instance.InOptions = false;
		}

		// Token: 0x06029AE0 RID: 170720 RVA: 0x00BC7D34 File Offset: 0x00BC5F34
		private void InterruptHud(bool isHang)
		{
			if (isHang)
			{
				PlotModel.Instance.HangViewHud = true;
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "[PlotView] 引导界面打开挂起HUD剧情", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.HangPlotViewHud(true);
				return;
			}
			PlotModel.Instance.HangViewHud = false;
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "[PlotView] 引导界面解除挂起HUD剧情", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.HangPlotViewHud(false);
		}

		// Token: 0x06029AE1 RID: 170721 RVA: 0x00BC7DA4 File Offset: 0x00BC5FA4
		private void OnBattleUiSlowTimeVisibleChanged(bool visible)
		{
			if (this.GetCurrentViewName() == EUiViewName.PlotViewHUD)
			{
				PlotViewHud plotViewHud = UiManager.Instance.GetViewByName(EUiViewName.PlotViewHUD) as PlotViewHud;
				if (plotViewHud != null)
				{
					plotViewHud.SetEnableTranslucent(visible);
				}
			}
			PlotModel.Instance.TranslucentHud = visible;
		}

		// Token: 0x06029AE2 RID: 170722 RVA: 0x00BC7E04 File Offset: 0x00BC6004
		private void ViewCloseCheck(EUiViewName viewName)
		{
			if (this.IsSwitching && this.SwitchFromView == viewName)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[PlotView] 旧剧情界面按计划关闭";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", this.SwitchFromView);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.HandleSwitchFromViewClosed().Forget();
				return;
			}
			if (this.CurrentView != viewName)
			{
				return;
			}
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Plot;
			ELogAuthor author2 = ELogAuthor.FZX;
			string message2 = "[PlotView] 剧情界面关闭";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("viewName", this.CurrentView);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.CurrentView = null;
			this.CurrentViewOwnerId = null;
			this.IsShowing = false;
			this.CancelPendingViewOperations();
			if (this.ViewEnable)
			{
				global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.FZX, "[PlotView] 剧情界面意外关闭，跳过当前剧情", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ViewEnable = false;
				this.IsLock = true;
				this.FinishSwitching();
				this.DoCallback(false);
				FlowController.Instance.BackgroundFlow("剧情界面意外关闭 跳过剧情", false, false, false);
			}
			this.CheckPending();
		}

		// Token: 0x06029AE3 RID: 170723 RVA: 0x00BC7F4D File Offset: 0x00BC614D
		[NullableContext(2)]
		public void OpenPlotView(EUiViewName viewName, TCallback callback = null, UiParam uiParam = null, long? ownerId = null)
		{
			this.Open(viewName, uiParam, callback, ownerId);
		}

		// Token: 0x06029AE4 RID: 170724 RVA: 0x00BC7F5A File Offset: 0x00BC615A
		public void ClosePlotView(long? ownerId = null)
		{
			this.Close(ownerId);
		}

		// Token: 0x06029AE5 RID: 170725 RVA: 0x00BC7F64 File Offset: 0x00BC6164
		public UniTask OpenTipsView(EPromptStyle style, UiParam param)
		{
			PlotViewManager.<OpenTipsView>d__51 <OpenTipsView>d__;
			<OpenTipsView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenTipsView>d__.<>4__this = this;
			<OpenTipsView>d__.style = style;
			<OpenTipsView>d__.param = param;
			<OpenTipsView>d__.<>1__state = -1;
			<OpenTipsView>d__.<>t__builder.Start<PlotViewManager.<OpenTipsView>d__51>(ref <OpenTipsView>d__);
			return <OpenTipsView>d__.<>t__builder.Task;
		}

		// Token: 0x06029AE6 RID: 170726 RVA: 0x00BC7FB7 File Offset: 0x00BC61B7
		public void CloseTipsView()
		{
			if (this.TipsView != null)
			{
				this.TipsView.CloseAsync().Forget();
			}
			this.TipsView = null;
		}

		// Token: 0x06029AE7 RID: 170727 RVA: 0x00BC7FD8 File Offset: 0x00BC61D8
		[NullableContext(2)]
		private unsafe void Open(EUiViewName viewName, UiParam param = null, TCallback callback = null, long? ownerId = null)
		{
			PlotViewManager.<>c__DisplayClass53_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass53_0();
			CS$<>8__locals1.param = param;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[PlotView] 请求打开界面";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("new", viewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("current", this.CurrentView);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ownerId", ownerId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (this.IsLock)
			{
				this.AddPending(new ViewHandle(new EUiViewName?(viewName), CS$<>8__locals1.param, callback, ownerId));
				return;
			}
			if (this.CurrentView == viewName)
			{
				if (ownerId != null)
				{
					this.CurrentViewOwnerId = ownerId;
				}
				this.RunWhenCurrentViewReady("UpdatePlotUiParam", delegate
				{
					PlotViewManager.<>c__DisplayClass53_0.<<Open>b__0>d <<Open>b__0>d;
					<<Open>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
					<<Open>b__0>d.<>4__this = CS$<>8__locals1;
					<<Open>b__0>d.<>1__state = -1;
					<<Open>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass53_0.<<Open>b__0>d>(ref <<Open>b__0>d);
					return <<Open>b__0>d.<>t__builder.Task;
				}, null).Forget<bool>();
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.FZX, "[PlotView] 重复打开", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.WaitOpenCallback(callback);
				this.ContinuePendingAfterSkip();
				return;
			}
			if (this.CurrentView != null)
			{
				this.OpenBeforeClose(viewName, CS$<>8__locals1.param, callback, ownerId);
				return;
			}
			this.IsLock = true;
			this.ViewEnable = true;
			this.CurrentView = new EUiViewName?(viewName);
			this.CurrentViewOwnerId = ownerId;
			this.WaitOpenCallback(callback);
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Plot;
			ELogAuthor author2 = ELogAuthor.FZX;
			string message2 = "[PlotView] 打开";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("open", viewName);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.OpenViewByName(viewName, CS$<>8__locals1.param);
		}

		// Token: 0x06029AE8 RID: 170728 RVA: 0x00BC8194 File Offset: 0x00BC6394
		[NullableContext(2)]
		private unsafe void OpenBeforeClose(EUiViewName viewName, UiParam param = null, TCallback callback = null, long? ownerId = null)
		{
			if (this.IsSwitching)
			{
				this.AddPending(new ViewHandle(new EUiViewName?(viewName), param, callback, ownerId));
				return;
			}
			this.IsSwitching = true;
			this.SwitchFromView = this.CurrentView;
			this.SwitchToView = new EUiViewName?(viewName);
			this.IsLock = true;
			this.IsShowing = false;
			this.ViewEnable = true;
			this.CancelPendingViewOperations();
			this.CurrentView = new EUiViewName?(viewName);
			this.CurrentViewOwnerId = ownerId;
			this.WaitOpenCallback(callback);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[PlotView] 剧情界面切换，先开新后关旧";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("from", this.SwitchFromView);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("to", this.SwitchToView);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.OpenViewByName(viewName, param);
		}

		// Token: 0x06029AE9 RID: 170729 RVA: 0x00BC8284 File Offset: 0x00BC6484
		[NullableContext(2)]
		private unsafe void OpenViewByName(EUiViewName viewName, UiParam param = null)
		{
			int num = 3;
			List<EUiViewName> list = new List<EUiViewName>(num);
			CollectionsMarshal.SetCount<EUiViewName>(list, num);
			Span<EUiViewName> span = CollectionsMarshal.AsSpan<EUiViewName>(list);
			int num2 = 0;
			*span[num2] = EUiViewName.PlotViewHUD;
			num2++;
			*span[num2] = EUiViewName.PlotGiantSubtitleView;
			num2++;
			*span[num2] = EUiViewName.ActivityGamePlayPlotView;
			if (list.Contains(viewName))
			{
				UiManager.Instance.OpenView(viewName, param, null);
				return;
			}
			UiManager.Instance.OpenViewByPlot(viewName, param, null);
		}

		// Token: 0x06029AEA RID: 170730 RVA: 0x00BC830C File Offset: 0x00BC650C
		private unsafe void Close(long? ownerId = null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[PlotView] 请求关闭界面";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("current", this.CurrentView);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ownerId", ownerId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("currentOwnerId", this.CurrentViewOwnerId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (!this.CheckOwner("ClosePlotView", ownerId))
			{
				this.ContinuePendingAfterSkip();
				return;
			}
			if (this.IsLock)
			{
				this.AddPending(new ViewHandle(null, null, null, ownerId));
				return;
			}
			if (this.CurrentView == null)
			{
				this.ContinuePendingAfterSkip();
				return;
			}
			this.IsLock = true;
			this.ViewEnable = false;
			this.CancelPendingViewOperations();
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Plot;
			ELogAuthor author2 = ELogAuthor.FZX;
			string message2 = "[PlotView] 关闭";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("close", this.CurrentView);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			UiManager.Instance.CloseView(this.CurrentView.Value, null);
		}

		// Token: 0x06029AEB RID: 170731 RVA: 0x00BC8441 File Offset: 0x00BC6641
		[NullableContext(2)]
		public void WaitOpenCallback(TCallback callback = null)
		{
			if (callback == null)
			{
				return;
			}
			if (!this.ViewEnable)
			{
				callback(false);
				return;
			}
			if (!this.IsShowing)
			{
				this.Callbacks.Add(callback);
				return;
			}
			callback(true);
		}

		// Token: 0x06029AEC RID: 170732 RVA: 0x00BC8474 File Offset: 0x00BC6674
		[NullableContext(2)]
		public void RemoveCallback(TCallback callback = null)
		{
			if (callback == null)
			{
				return;
			}
			this.Callbacks.Remove(callback);
		}

		// Token: 0x06029AED RID: 170733 RVA: 0x00BC8488 File Offset: 0x00BC6688
		private void DoCallback(bool result)
		{
			HashSet<TCallback> callbacks = this.Callbacks;
			this.Callbacks = new HashSet<TCallback>();
			foreach (TCallback tcallback in callbacks)
			{
				if (tcallback != null)
				{
					tcallback(result);
				}
			}
		}

		// Token: 0x06029AEE RID: 170734 RVA: 0x00BC84EC File Offset: 0x00BC66EC
		private void CheckPending()
		{
			this.IsLock = false;
			if (this.PendingHandle.Size == 0)
			{
				return;
			}
			ViewHandle viewHandle = this.PendingHandle.Pop();
			if (viewHandle != null && viewHandle.ViewName != null)
			{
				this.Open(viewHandle.ViewName.Value, viewHandle.Param, viewHandle.Callback, viewHandle.OwnerId);
				return;
			}
			this.Close((viewHandle != null) ? viewHandle.OwnerId : null);
		}

		// Token: 0x06029AEF RID: 170735 RVA: 0x00BC856E File Offset: 0x00BC676E
		private void ContinuePendingAfterSkip()
		{
			if (this.IsLock)
			{
				return;
			}
			this.CheckPending();
		}

		// Token: 0x06029AF0 RID: 170736 RVA: 0x00BC8580 File Offset: 0x00BC6780
		private unsafe void AddPending(ViewHandle handle)
		{
			this.PendingHandle.Push(handle);
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "[PlotView] 操作进入缓存";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Handle";
			EUiViewName? viewName = handle.ViewName;
			ptr = new ValueTuple<string, object>(item, (viewName != null) ? viewName.GetValueOrDefault() : "CloseView");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ownerId", handle.OwnerId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06029AF1 RID: 170737 RVA: 0x00BC8618 File Offset: 0x00BC6818
		[return: Nullable(0)]
		public unsafe UniTask<bool> RunWhenCurrentViewReady(string name, PlotUiAsyncOperation operation, [Nullable(2)] Action onCancel = null)
		{
			CustomPromise<bool> customPromise = new CustomPromise<bool>();
			if (!this.CanQueueViewOperation())
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.FZX;
				string message = "[PlotView] 剧情界面不存在，操作取消";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("operation", name);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				if (onCancel != null)
				{
					onCancel();
				}
				customPromise.SetResult(false);
				return customPromise.Promise;
			}
			PlotUiOperationHandle plotUiOperationHandle = new PlotUiOperationHandle(name, this.CurrentView.Value, operation, customPromise, onCancel);
			if (this.CanRunViewOperation())
			{
				this.ExecuteViewOperation(plotUiOperationHandle).Forget();
				return customPromise.Promise;
			}
			this.PendingViewOperations.Add(plotUiOperationHandle);
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.Plot;
			ELogAuthor author2 = ELogAuthor.FZX;
			string message2 = "[PlotView] UI操作进入缓存";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("operation", name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("view", plotUiOperationHandle.TargetView);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return customPromise.Promise;
		}

		// Token: 0x06029AF2 RID: 170738 RVA: 0x00BC8710 File Offset: 0x00BC6910
		private UniTask HandleCurrentViewShown()
		{
			PlotViewManager.<HandleCurrentViewShown>d__64 <HandleCurrentViewShown>d__;
			<HandleCurrentViewShown>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleCurrentViewShown>d__.<>4__this = this;
			<HandleCurrentViewShown>d__.<>1__state = -1;
			<HandleCurrentViewShown>d__.<>t__builder.Start<PlotViewManager.<HandleCurrentViewShown>d__64>(ref <HandleCurrentViewShown>d__);
			return <HandleCurrentViewShown>d__.<>t__builder.Task;
		}

		// Token: 0x06029AF3 RID: 170739 RVA: 0x00BC8754 File Offset: 0x00BC6954
		private UniTask HandleSwitchFromViewClosed()
		{
			PlotViewManager.<HandleSwitchFromViewClosed>d__65 <HandleSwitchFromViewClosed>d__;
			<HandleSwitchFromViewClosed>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleSwitchFromViewClosed>d__.<>4__this = this;
			<HandleSwitchFromViewClosed>d__.<>1__state = -1;
			<HandleSwitchFromViewClosed>d__.<>t__builder.Start<PlotViewManager.<HandleSwitchFromViewClosed>d__65>(ref <HandleSwitchFromViewClosed>d__);
			return <HandleSwitchFromViewClosed>d__.<>t__builder.Task;
		}

		// Token: 0x06029AF4 RID: 170740 RVA: 0x00BC8797 File Offset: 0x00BC6997
		private bool CanQueueViewOperation()
		{
			return this.CurrentView != null;
		}

		// Token: 0x06029AF5 RID: 170741 RVA: 0x00BC87A4 File Offset: 0x00BC69A4
		private unsafe bool CheckOwner(string operation, long? ownerId = null)
		{
			if (ownerId != null)
			{
				long? num = ownerId;
				long? currentViewOwnerId = this.CurrentViewOwnerId;
				if (!(num.GetValueOrDefault() == currentViewOwnerId.GetValueOrDefault() & num != null == (currentViewOwnerId != null)))
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Plot;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "[PlotView] UI操作归属不匹配，操作跳过";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("operation", operation);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("current", this.CurrentView);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ownerId", ownerId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("currentOwnerId", this.CurrentViewOwnerId);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					return false;
				}
			}
			return true;
		}

		// Token: 0x06029AF6 RID: 170742 RVA: 0x00BC8885 File Offset: 0x00BC6A85
		private bool CanRunViewOperation()
		{
			return (!this.IsSwitching || this.SwitchFromView == null) && (this.ViewEnable && this.IsShowing) && this.GetCurrentView() != null;
		}

		// Token: 0x06029AF7 RID: 170743 RVA: 0x00BC88B9 File Offset: 0x00BC6AB9
		[NullableContext(2)]
		private object GetCurrentView()
		{
			if (this.CurrentView == null)
			{
				return null;
			}
			return UiManager.Instance.GetViewByName(this.CurrentView.Value);
		}

		// Token: 0x06029AF8 RID: 170744 RVA: 0x00BC88E0 File Offset: 0x00BC6AE0
		private UniTask FlushPendingViewOperations()
		{
			PlotViewManager.<FlushPendingViewOperations>d__70 <FlushPendingViewOperations>d__;
			<FlushPendingViewOperations>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushPendingViewOperations>d__.<>4__this = this;
			<FlushPendingViewOperations>d__.<>1__state = -1;
			<FlushPendingViewOperations>d__.<>t__builder.Start<PlotViewManager.<FlushPendingViewOperations>d__70>(ref <FlushPendingViewOperations>d__);
			return <FlushPendingViewOperations>d__.<>t__builder.Task;
		}

		// Token: 0x06029AF9 RID: 170745 RVA: 0x00BC8924 File Offset: 0x00BC6B24
		private UniTask ExecuteNextPendingViewOperation()
		{
			PlotViewManager.<ExecuteNextPendingViewOperation>d__71 <ExecuteNextPendingViewOperation>d__;
			<ExecuteNextPendingViewOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteNextPendingViewOperation>d__.<>4__this = this;
			<ExecuteNextPendingViewOperation>d__.<>1__state = -1;
			<ExecuteNextPendingViewOperation>d__.<>t__builder.Start<PlotViewManager.<ExecuteNextPendingViewOperation>d__71>(ref <ExecuteNextPendingViewOperation>d__);
			return <ExecuteNextPendingViewOperation>d__.<>t__builder.Task;
		}

		// Token: 0x06029AFA RID: 170746 RVA: 0x00BC8968 File Offset: 0x00BC6B68
		private UniTask ExecuteViewOperation(PlotUiOperationHandle handle)
		{
			PlotViewManager.<ExecuteViewOperation>d__72 <ExecuteViewOperation>d__;
			<ExecuteViewOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteViewOperation>d__.handle = handle;
			<ExecuteViewOperation>d__.<>1__state = -1;
			<ExecuteViewOperation>d__.<>t__builder.Start<PlotViewManager.<ExecuteViewOperation>d__72>(ref <ExecuteViewOperation>d__);
			return <ExecuteViewOperation>d__.<>t__builder.Task;
		}

		// Token: 0x06029AFB RID: 170747 RVA: 0x00BC89AB File Offset: 0x00BC6BAB
		private void CancelPendingViewOperations()
		{
			while (this.PendingViewOperations.Count > 0)
			{
				this.CancelViewOperation(this.PendingViewOperations[0]);
				this.PendingViewOperations.RemoveAt(0);
			}
		}

		// Token: 0x06029AFC RID: 170748 RVA: 0x00BC89DB File Offset: 0x00BC6BDB
		private void CancelViewOperation(PlotUiOperationHandle handle)
		{
			Action onCancel = handle.OnCancel;
			if (onCancel != null)
			{
				onCancel();
			}
			handle.ResultPromise.SetResult(false);
		}

		// Token: 0x06029AFD RID: 170749 RVA: 0x00BC89FA File Offset: 0x00BC6BFA
		private void FinishSwitching()
		{
			this.IsSwitching = false;
			this.SwitchFromView = null;
			this.SwitchToView = null;
		}

		// Token: 0x04016BE5 RID: 93157
		private EUiViewName? CurrentView;

		// Token: 0x04016BE6 RID: 93158
		private long? CurrentViewOwnerId;

		// Token: 0x04016BE7 RID: 93159
		private HashSet<TCallback> Callbacks = new HashSet<TCallback>();

		// Token: 0x04016BE8 RID: 93160
		private bool IsShowing;

		// Token: 0x04016BE9 RID: 93161
		private bool ViewEnable;

		// Token: 0x04016BEA RID: 93162
		private bool IsLock;

		// Token: 0x04016BEB RID: 93163
		private readonly Queue<ViewHandle> PendingHandle = new Queue<ViewHandle>(4);

		// Token: 0x04016BEC RID: 93164
		[Nullable(2)]
		private PlotTipsViewBase TipsView;

		// Token: 0x04016BED RID: 93165
		private readonly List<PlotUiOperationHandle> PendingViewOperations = new List<PlotUiOperationHandle>();

		// Token: 0x04016BEE RID: 93166
		private bool IsFlushingViewOperation;

		// Token: 0x04016BEF RID: 93167
		private EUiViewName? SwitchFromView;

		// Token: 0x04016BF0 RID: 93168
		private EUiViewName? SwitchToView;

		// Token: 0x04016BF1 RID: 93169
		private bool IsSwitching;
	}
}
