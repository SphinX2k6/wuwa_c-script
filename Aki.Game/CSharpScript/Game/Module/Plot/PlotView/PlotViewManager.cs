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

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200506C RID: 20588
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotViewManager
	{
		// Token: 0x06034BCB RID: 216011 RVA: 0x00C7A0CC File Offset: 0x00C782CC
		public void RegisterEvent()
		{
			EventSystem.Instance.Add<EUiViewName, bool>(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotViewChange));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Add<bool>(EEventName.OnTutorialTipExistChanged, new Action<bool>(this.InterruptHud));
			EventSystem.Instance.Add<EUiViewName>(EEventName.OpenViewFail, new Action<EUiViewName>(this.OpenViewFail));
			EventSystem.Instance.Add<bool>(EEventName.BattleUiSlowTimeVisibleChanged, new Action<bool>(this.OnBattleUiSlowTimeVisibleChanged));
		}

		// Token: 0x06034BCC RID: 216012 RVA: 0x00C7A178 File Offset: 0x00C78378
		public void UnRegisterEvent()
		{
			EventSystem.Instance.Remove<EUiViewName, bool>(EEventName.PlotViewChange, new Action<EUiViewName, bool>(this.OnPlotViewChange));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove<bool>(EEventName.OnTutorialTipExistChanged, new Action<bool>(this.InterruptHud));
			EventSystem.Instance.Remove<EUiViewName>(EEventName.OpenViewFail, new Action<EUiViewName>(this.OpenViewFail));
			EventSystem.Instance.Remove<bool>(EEventName.BattleUiSlowTimeVisibleChanged, new Action<bool>(this.OnBattleUiSlowTimeVisibleChanged));
		}

		// Token: 0x06034BCD RID: 216013 RVA: 0x00C7A224 File Offset: 0x00C78424
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

		// Token: 0x06034BCE RID: 216014 RVA: 0x00C7A337 File Offset: 0x00C78537
		public EUiViewName? GetCurrentViewName()
		{
			return this.CurrentView;
		}

		// Token: 0x06034BCF RID: 216015 RVA: 0x00C7A33F File Offset: 0x00C7853F
		private void OnOpenView(EUiViewName viewName, int viewId)
		{
		}

		// Token: 0x06034BD0 RID: 216016 RVA: 0x00C7A341 File Offset: 0x00C78541
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			this.ViewCloseCheck(viewName);
		}

		// Token: 0x06034BD1 RID: 216017 RVA: 0x00C7A34C File Offset: 0x00C7854C
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

		// Token: 0x06034BD2 RID: 216018 RVA: 0x00C7A3FA File Offset: 0x00C785FA
		public void OnUpdateSubtitle(ITalkItem talkItem)
		{
			PlotModel.Instance.CurTalkItem = talkItem;
			EventSystem.Instance.Emit<ITalkItem, bool>(EEventName.PlotShowTalk, talkItem, true);
			FlowController.Instance.RecordTalkItem(talkItem);
		}

		// Token: 0x06034BD3 RID: 216019 RVA: 0x00C7A424 File Offset: 0x00C78624
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

		// Token: 0x06034BD4 RID: 216020 RVA: 0x00C7A444 File Offset: 0x00C78644
		public void OnSubmitSubtitle()
		{
			EventSystem.Instance.Emit<ITalkItem, bool>(EEventName.PlotShowTalk, PlotModel.Instance.CurTalkItem, false);
			PlotModel.Instance.CurTalkItem = null;
		}

		// Token: 0x06034BD5 RID: 216021 RVA: 0x00C7A46C File Offset: 0x00C7866C
		public void OnShowOptions()
		{
			PlotModel.Instance.InOptions = true;
		}

		// Token: 0x06034BD6 RID: 216022 RVA: 0x00C7A47C File Offset: 0x00C7867C
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

		// Token: 0x06034BD7 RID: 216023 RVA: 0x00C7A4BF File Offset: 0x00C786BF
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

		// Token: 0x06034BD8 RID: 216024 RVA: 0x00C7A4F8 File Offset: 0x00C786F8
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

		// Token: 0x06034BD9 RID: 216025 RVA: 0x00C7A530 File Offset: 0x00C78730
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

		// Token: 0x06034BDA RID: 216026 RVA: 0x00C7A574 File Offset: 0x00C78774
		public void ClearPlotSubtitle(long? ownerId = null)
		{
			if (!this.CheckOwner("ClearPlotSubtitle", ownerId))
			{
				return;
			}
			this.RunWhenCurrentViewReady("ClearPlotSubtitle", delegate
			{
				PlotViewManager.<>c.<<ClearPlotSubtitle>b__28_0>d <<ClearPlotSubtitle>b__28_0>d;
				<<ClearPlotSubtitle>b__28_0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<ClearPlotSubtitle>b__28_0>d.<>1__state = -1;
				<<ClearPlotSubtitle>b__28_0>d.<>t__builder.Start<PlotViewManager.<>c.<<ClearPlotSubtitle>b__28_0>d>(ref <<ClearPlotSubtitle>b__28_0>d);
				return <<ClearPlotSubtitle>b__28_0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06034BDB RID: 216027 RVA: 0x00C7A5C0 File Offset: 0x00C787C0
		public void HidePlotUi(bool isHidden, long? ownerId = null)
		{
			PlotViewManager.<>c__DisplayClass29_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass29_0();
			CS$<>8__locals1.isHidden = isHidden;
			if (!this.CheckOwner("HidePlotUi", ownerId))
			{
				return;
			}
			this.RunWhenCurrentViewReady("HidePlotUi", delegate
			{
				PlotViewManager.<>c__DisplayClass29_0.<<HidePlotUi>b__0>d <<HidePlotUi>b__0>d;
				<<HidePlotUi>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<HidePlotUi>b__0>d.<>4__this = CS$<>8__locals1;
				<<HidePlotUi>b__0>d.<>1__state = -1;
				<<HidePlotUi>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass29_0.<<HidePlotUi>b__0>d>(ref <<HidePlotUi>b__0>d);
				return <<HidePlotUi>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06034BDC RID: 216028 RVA: 0x00C7A608 File Offset: 0x00C78808
		[NullableContext(2)]
		public void PlotViewBgFadePhoto(bool isFadeIn, bool isFull, string path = null, Action callback = null)
		{
			PlotViewManager.<>c__DisplayClass30_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass30_0();
			CS$<>8__locals1.isFadeIn = isFadeIn;
			CS$<>8__locals1.isFull = isFull;
			CS$<>8__locals1.path = path;
			CS$<>8__locals1.callback = callback;
			this.RunWithPlotView("PlotViewBgFadePhoto", delegate(PlotView _)
			{
				PlotViewManager.<>c__DisplayClass30_0.<<PlotViewBgFadePhoto>b__0>d <<PlotViewBgFadePhoto>b__0>d;
				<<PlotViewBgFadePhoto>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<PlotViewBgFadePhoto>b__0>d.<>4__this = CS$<>8__locals1;
				<<PlotViewBgFadePhoto>b__0>d.<>1__state = -1;
				<<PlotViewBgFadePhoto>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass30_0.<<PlotViewBgFadePhoto>b__0>d>(ref <<PlotViewBgFadePhoto>b__0>d);
				return <<PlotViewBgFadePhoto>b__0>d.<>t__builder.Task;
			}, CS$<>8__locals1.callback).Forget<bool>();
		}

		// Token: 0x06034BDD RID: 216029 RVA: 0x00C7A65C File Offset: 0x00C7885C
		[NullableContext(2)]
		public void PlotViewBgFadeBlackScreen(bool isFadeIn, Action callback = null)
		{
			PlotViewManager.<>c__DisplayClass31_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass31_0();
			CS$<>8__locals1.isFadeIn = isFadeIn;
			CS$<>8__locals1.callback = callback;
			this.RunWhenCurrentViewReady("PlotViewBgFadeBlackScreen", delegate
			{
				PlotViewManager.<>c__DisplayClass31_0.<<PlotViewBgFadeBlackScreen>b__0>d <<PlotViewBgFadeBlackScreen>b__0>d;
				<<PlotViewBgFadeBlackScreen>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<PlotViewBgFadeBlackScreen>b__0>d.<>4__this = CS$<>8__locals1;
				<<PlotViewBgFadeBlackScreen>b__0>d.<>1__state = -1;
				<<PlotViewBgFadeBlackScreen>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass31_0.<<PlotViewBgFadeBlackScreen>b__0>d>(ref <<PlotViewBgFadeBlackScreen>b__0>d);
				return <<PlotViewBgFadeBlackScreen>b__0>d.<>t__builder.Task;
			}, CS$<>8__locals1.callback).Forget<bool>();
		}

		// Token: 0x06034BDE RID: 216030 RVA: 0x00C7A6A0 File Offset: 0x00C788A0
		public void PlotDoingTextShow(bool isShow)
		{
			PlotViewManager.<>c__DisplayClass32_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass32_0();
			CS$<>8__locals1.isShow = isShow;
			this.RunWithPlotSubtitleViewChecked("PlotDoingTextShow", delegate
			{
				PlotViewManager.<>c__DisplayClass32_0.<<PlotDoingTextShow>b__0>d <<PlotDoingTextShow>b__0>d;
				<<PlotDoingTextShow>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<PlotDoingTextShow>b__0>d.<>4__this = CS$<>8__locals1;
				<<PlotDoingTextShow>b__0>d.<>1__state = -1;
				<<PlotDoingTextShow>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass32_0.<<PlotDoingTextShow>b__0>d>(ref <<PlotDoingTextShow>b__0>d);
				return <<PlotDoingTextShow>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06034BDF RID: 216031 RVA: 0x00C7A6D8 File Offset: 0x00C788D8
		[NullableContext(2)]
		public void EnableInteractPlot(bool enable, bool? includeSubtitleButton = null, string reason = null)
		{
			PlotViewManager.<>c__DisplayClass33_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass33_0();
			CS$<>8__locals1.enable = enable;
			CS$<>8__locals1.includeSubtitleButton = includeSubtitleButton;
			CS$<>8__locals1.reason = reason;
			this.RunWithPlotSubtitleViewChecked("EnableInteractPlot", delegate
			{
				PlotViewManager.<>c__DisplayClass33_0.<<EnableInteractPlot>b__0>d <<EnableInteractPlot>b__0>d;
				<<EnableInteractPlot>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<EnableInteractPlot>b__0>d.<>4__this = CS$<>8__locals1;
				<<EnableInteractPlot>b__0>d.<>1__state = -1;
				<<EnableInteractPlot>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass33_0.<<EnableInteractPlot>b__0>d>(ref <<EnableInteractPlot>b__0>d);
				return <<EnableInteractPlot>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06034BE0 RID: 216032 RVA: 0x00C7A720 File Offset: 0x00C78920
		public void EnableSkipPlotByReason(bool enable, string reason)
		{
			PlotViewManager.<>c__DisplayClass34_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass34_0();
			CS$<>8__locals1.enable = enable;
			CS$<>8__locals1.reason = reason;
			this.RunWithPlotSubtitleViewChecked("EnableSkipPlotByReason", delegate
			{
				PlotViewManager.<>c__DisplayClass34_0.<<EnableSkipPlotByReason>b__0>d <<EnableSkipPlotByReason>b__0>d;
				<<EnableSkipPlotByReason>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<EnableSkipPlotByReason>b__0>d.<>4__this = CS$<>8__locals1;
				<<EnableSkipPlotByReason>b__0>d.<>1__state = -1;
				<<EnableSkipPlotByReason>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass34_0.<<EnableSkipPlotByReason>b__0>d>(ref <<EnableSkipPlotByReason>b__0>d);
				return <<EnableSkipPlotByReason>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06034BE1 RID: 216033 RVA: 0x00C7A760 File Offset: 0x00C78960
		public void UpdateSeqSubtitle(PlotSubtitleConfig subtitle)
		{
			PlotViewManager.<>c__DisplayClass35_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass35_0();
			CS$<>8__locals1.subtitle = subtitle;
			this.RunWhenCurrentViewReady("UpdateSeqSubtitle", delegate
			{
				PlotViewManager.<>c__DisplayClass35_0.<<UpdateSeqSubtitle>b__0>d <<UpdateSeqSubtitle>b__0>d;
				<<UpdateSeqSubtitle>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<UpdateSeqSubtitle>b__0>d.<>4__this = CS$<>8__locals1;
				<<UpdateSeqSubtitle>b__0>d.<>1__state = -1;
				<<UpdateSeqSubtitle>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass35_0.<<UpdateSeqSubtitle>b__0>d>(ref <<UpdateSeqSubtitle>b__0>d);
				return <<UpdateSeqSubtitle>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06034BE2 RID: 216034 RVA: 0x00C7A798 File Offset: 0x00C78998
		public void HandleSeqSubtitleEnd(int id, bool isSkip)
		{
			PlotViewManager.<>c__DisplayClass36_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass36_0();
			CS$<>8__locals1.id = id;
			CS$<>8__locals1.isSkip = isSkip;
			this.RunWhenCurrentViewReady("HandleSeqSubtitleEnd", delegate
			{
				PlotViewManager.<>c__DisplayClass36_0.<<HandleSeqSubtitleEnd>b__0>d <<HandleSeqSubtitleEnd>b__0>d;
				<<HandleSeqSubtitleEnd>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<HandleSeqSubtitleEnd>b__0>d.<>4__this = CS$<>8__locals1;
				<<HandleSeqSubtitleEnd>b__0>d.<>1__state = -1;
				<<HandleSeqSubtitleEnd>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass36_0.<<HandleSeqSubtitleEnd>b__0>d>(ref <<HandleSeqSubtitleEnd>b__0>d);
				return <<HandleSeqSubtitleEnd>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06034BE3 RID: 216035 RVA: 0x00C7A7D8 File Offset: 0x00C789D8
		public void HandlePlotOptionSelected(int option)
		{
			PlotViewManager.<>c__DisplayClass37_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass37_0();
			CS$<>8__locals1.option = option;
			this.RunWhenCurrentViewReady("HandlePlotOptionSelected", delegate
			{
				PlotViewManager.<>c__DisplayClass37_0.<<HandlePlotOptionSelected>b__0>d <<HandlePlotOptionSelected>b__0>d;
				<<HandlePlotOptionSelected>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<HandlePlotOptionSelected>b__0>d.<>4__this = CS$<>8__locals1;
				<<HandlePlotOptionSelected>b__0>d.<>1__state = -1;
				<<HandlePlotOptionSelected>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass37_0.<<HandlePlotOptionSelected>b__0>d>(ref <<HandlePlotOptionSelected>b__0>d);
				return <<HandlePlotOptionSelected>b__0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06034BE4 RID: 216036 RVA: 0x00C7A80F File Offset: 0x00C78A0F
		public void HandleSubSequenceStop()
		{
			this.RunWhenCurrentViewReady("HandleSubSequenceStop", delegate
			{
				PlotViewManager.<>c.<<HandleSubSequenceStop>b__38_0>d <<HandleSubSequenceStop>b__38_0>d;
				<<HandleSubSequenceStop>b__38_0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<HandleSubSequenceStop>b__38_0>d.<>1__state = -1;
				<<HandleSubSequenceStop>b__38_0>d.<>t__builder.Start<PlotViewManager.<>c.<<HandleSubSequenceStop>b__38_0>d>(ref <<HandleSubSequenceStop>b__38_0>d);
				return <<HandleSubSequenceStop>b__38_0>d.<>t__builder.Task;
			}, null).Forget<bool>();
		}

		// Token: 0x06034BE5 RID: 216037 RVA: 0x00C7A841 File Offset: 0x00C78A41
		public void HangPlotViewHud(bool isHang)
		{
			EventSystem.Instance.Emit<bool>(EEventName.HangPlotViewHud, isHang);
		}

		// Token: 0x06034BE6 RID: 216038 RVA: 0x00C7A854 File Offset: 0x00C78A54
		[NullableContext(0)]
		public UniTask<bool> RunWithPlotView([Nullable(1)] string name, [Nullable(new byte[]
		{
			1,
			1,
			0,
			2
		})] Func<PlotView, UniTask<object>> operation, [Nullable(2)] Action onCancel = null)
		{
			PlotViewManager.<>c__DisplayClass40_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass40_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.name = name;
			CS$<>8__locals1.operation = operation;
			return this.RunWhenCurrentViewReady(CS$<>8__locals1.name, delegate
			{
				PlotViewManager.<>c__DisplayClass40_0.<<RunWithPlotView>b__0>d <<RunWithPlotView>b__0>d;
				<<RunWithPlotView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<RunWithPlotView>b__0>d.<>4__this = CS$<>8__locals1;
				<<RunWithPlotView>b__0>d.<>1__state = -1;
				<<RunWithPlotView>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass40_0.<<RunWithPlotView>b__0>d>(ref <<RunWithPlotView>b__0>d);
				return <<RunWithPlotView>b__0>d.<>t__builder.Task;
			}, onCancel);
		}

		// Token: 0x06034BE7 RID: 216039 RVA: 0x00C7A898 File Offset: 0x00C78A98
		[return: Nullable(0)]
		public UniTask<bool> RunWithPlotSubtitleViewChecked(string name, PlotUiAsyncOperation operation, [Nullable(2)] Action onCancel = null)
		{
			PlotViewManager.<>c__DisplayClass41_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass41_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.name = name;
			CS$<>8__locals1.operation = operation;
			return this.RunWhenCurrentViewReady(CS$<>8__locals1.name, delegate
			{
				PlotViewManager.<>c__DisplayClass41_0.<<RunWithPlotSubtitleViewChecked>b__0>d <<RunWithPlotSubtitleViewChecked>b__0>d;
				<<RunWithPlotSubtitleViewChecked>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<RunWithPlotSubtitleViewChecked>b__0>d.<>4__this = CS$<>8__locals1;
				<<RunWithPlotSubtitleViewChecked>b__0>d.<>1__state = -1;
				<<RunWithPlotSubtitleViewChecked>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass41_0.<<RunWithPlotSubtitleViewChecked>b__0>d>(ref <<RunWithPlotSubtitleViewChecked>b__0>d);
				return <<RunWithPlotSubtitleViewChecked>b__0>d.<>t__builder.Task;
			}, onCancel);
		}

		// Token: 0x06034BE8 RID: 216040 RVA: 0x00C7A8DC File Offset: 0x00C78ADC
		[NullableContext(0)]
		public UniTask<bool> RunWithPlotSubtitleView([Nullable(1)] string name, [Nullable(new byte[]
		{
			1,
			1,
			0,
			2
		})] Func<PlotSubtitleView, UniTask<object>> operation, [Nullable(2)] Action onCancel = null)
		{
			PlotViewManager.<>c__DisplayClass42_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass42_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.name = name;
			CS$<>8__locals1.operation = operation;
			return this.RunWhenCurrentViewReady(CS$<>8__locals1.name, delegate
			{
				PlotViewManager.<>c__DisplayClass42_0.<<RunWithPlotSubtitleView>b__0>d <<RunWithPlotSubtitleView>b__0>d;
				<<RunWithPlotSubtitleView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<RunWithPlotSubtitleView>b__0>d.<>4__this = CS$<>8__locals1;
				<<RunWithPlotSubtitleView>b__0>d.<>1__state = -1;
				<<RunWithPlotSubtitleView>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass42_0.<<RunWithPlotSubtitleView>b__0>d>(ref <<RunWithPlotSubtitleView>b__0>d);
				return <<RunWithPlotSubtitleView>b__0>d.<>t__builder.Task;
			}, onCancel);
		}

		// Token: 0x06034BE9 RID: 216041 RVA: 0x00C7A920 File Offset: 0x00C78B20
		[return: Nullable(0)]
		public UniTask<bool> RunWithPlotSubtitleView(string name, Func<PlotSubtitleView, UniTask> operation, [Nullable(2)] Action onCancel = null)
		{
			PlotViewManager.<>c__DisplayClass43_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass43_0();
			CS$<>8__locals1.operation = operation;
			return this.RunWithPlotSubtitleView(name, delegate(PlotSubtitleView view)
			{
				PlotViewManager.<>c__DisplayClass43_0.<<RunWithPlotSubtitleView>b__0>d <<RunWithPlotSubtitleView>b__0>d;
				<<RunWithPlotSubtitleView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
				<<RunWithPlotSubtitleView>b__0>d.<>4__this = CS$<>8__locals1;
				<<RunWithPlotSubtitleView>b__0>d.view = view;
				<<RunWithPlotSubtitleView>b__0>d.<>1__state = -1;
				<<RunWithPlotSubtitleView>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass43_0.<<RunWithPlotSubtitleView>b__0>d>(ref <<RunWithPlotSubtitleView>b__0>d);
				return <<RunWithPlotSubtitleView>b__0>d.<>t__builder.Task;
			}, onCancel);
		}

		// Token: 0x06034BEA RID: 216042 RVA: 0x00C7A94E File Offset: 0x00C78B4E
		public void OnSelectedOptions()
		{
			PlotModel.Instance.InOptions = false;
		}

		// Token: 0x06034BEB RID: 216043 RVA: 0x00C7A95C File Offset: 0x00C78B5C
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

		// Token: 0x06034BEC RID: 216044 RVA: 0x00C7A9CC File Offset: 0x00C78BCC
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

		// Token: 0x06034BED RID: 216045 RVA: 0x00C7AA2C File Offset: 0x00C78C2C
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

		// Token: 0x06034BEE RID: 216046 RVA: 0x00C7AB75 File Offset: 0x00C78D75
		[NullableContext(2)]
		public void OpenPlotView(EUiViewName viewName, TCallback callback = null, UiParam uiParam = null, long? ownerId = null)
		{
			this.Open(viewName, uiParam, callback, ownerId);
		}

		// Token: 0x06034BEF RID: 216047 RVA: 0x00C7AB82 File Offset: 0x00C78D82
		public void ClosePlotView(long? ownerId = null)
		{
			this.Close(ownerId);
		}

		// Token: 0x06034BF0 RID: 216048 RVA: 0x00C7AB8C File Offset: 0x00C78D8C
		public UniTask OpenTipsView(EPromptStyle style, UiParam param)
		{
			PlotViewManager.<OpenTipsView>d__50 <OpenTipsView>d__;
			<OpenTipsView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenTipsView>d__.<>4__this = this;
			<OpenTipsView>d__.style = style;
			<OpenTipsView>d__.param = param;
			<OpenTipsView>d__.<>1__state = -1;
			<OpenTipsView>d__.<>t__builder.Start<PlotViewManager.<OpenTipsView>d__50>(ref <OpenTipsView>d__);
			return <OpenTipsView>d__.<>t__builder.Task;
		}

		// Token: 0x06034BF1 RID: 216049 RVA: 0x00C7ABDF File Offset: 0x00C78DDF
		public void CloseTipsView()
		{
			if (this.TipsView != null)
			{
				this.TipsView.CloseAsync().Forget();
			}
			this.TipsView = null;
		}

		// Token: 0x06034BF2 RID: 216050 RVA: 0x00C7AC00 File Offset: 0x00C78E00
		[NullableContext(2)]
		private unsafe void Open(EUiViewName viewName, UiParam param = null, TCallback callback = null, long? ownerId = null)
		{
			PlotViewManager.<>c__DisplayClass52_0 CS$<>8__locals1 = new PlotViewManager.<>c__DisplayClass52_0();
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
					PlotViewManager.<>c__DisplayClass52_0.<<Open>b__0>d <<Open>b__0>d;
					<<Open>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder<object>.Create();
					<<Open>b__0>d.<>4__this = CS$<>8__locals1;
					<<Open>b__0>d.<>1__state = -1;
					<<Open>b__0>d.<>t__builder.Start<PlotViewManager.<>c__DisplayClass52_0.<<Open>b__0>d>(ref <<Open>b__0>d);
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

		// Token: 0x06034BF3 RID: 216051 RVA: 0x00C7ADBC File Offset: 0x00C78FBC
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

		// Token: 0x06034BF4 RID: 216052 RVA: 0x00C7AEAC File Offset: 0x00C790AC
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

		// Token: 0x06034BF5 RID: 216053 RVA: 0x00C7AF34 File Offset: 0x00C79134
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

		// Token: 0x06034BF6 RID: 216054 RVA: 0x00C7B069 File Offset: 0x00C79269
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

		// Token: 0x06034BF7 RID: 216055 RVA: 0x00C7B09C File Offset: 0x00C7929C
		[NullableContext(2)]
		public void RemoveCallback(TCallback callback = null)
		{
			if (callback == null)
			{
				return;
			}
			this.Callbacks.Remove(callback);
		}

		// Token: 0x06034BF8 RID: 216056 RVA: 0x00C7B0B0 File Offset: 0x00C792B0
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

		// Token: 0x06034BF9 RID: 216057 RVA: 0x00C7B114 File Offset: 0x00C79314
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

		// Token: 0x06034BFA RID: 216058 RVA: 0x00C7B196 File Offset: 0x00C79396
		private void ContinuePendingAfterSkip()
		{
			if (this.IsLock)
			{
				return;
			}
			this.CheckPending();
		}

		// Token: 0x06034BFB RID: 216059 RVA: 0x00C7B1A8 File Offset: 0x00C793A8
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

		// Token: 0x06034BFC RID: 216060 RVA: 0x00C7B240 File Offset: 0x00C79440
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

		// Token: 0x06034BFD RID: 216061 RVA: 0x00C7B338 File Offset: 0x00C79538
		private UniTask HandleCurrentViewShown()
		{
			PlotViewManager.<HandleCurrentViewShown>d__63 <HandleCurrentViewShown>d__;
			<HandleCurrentViewShown>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleCurrentViewShown>d__.<>4__this = this;
			<HandleCurrentViewShown>d__.<>1__state = -1;
			<HandleCurrentViewShown>d__.<>t__builder.Start<PlotViewManager.<HandleCurrentViewShown>d__63>(ref <HandleCurrentViewShown>d__);
			return <HandleCurrentViewShown>d__.<>t__builder.Task;
		}

		// Token: 0x06034BFE RID: 216062 RVA: 0x00C7B37C File Offset: 0x00C7957C
		private UniTask HandleSwitchFromViewClosed()
		{
			PlotViewManager.<HandleSwitchFromViewClosed>d__64 <HandleSwitchFromViewClosed>d__;
			<HandleSwitchFromViewClosed>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleSwitchFromViewClosed>d__.<>4__this = this;
			<HandleSwitchFromViewClosed>d__.<>1__state = -1;
			<HandleSwitchFromViewClosed>d__.<>t__builder.Start<PlotViewManager.<HandleSwitchFromViewClosed>d__64>(ref <HandleSwitchFromViewClosed>d__);
			return <HandleSwitchFromViewClosed>d__.<>t__builder.Task;
		}

		// Token: 0x06034BFF RID: 216063 RVA: 0x00C7B3BF File Offset: 0x00C795BF
		private bool CanQueueViewOperation()
		{
			return this.CurrentView != null;
		}

		// Token: 0x06034C00 RID: 216064 RVA: 0x00C7B3CC File Offset: 0x00C795CC
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

		// Token: 0x06034C01 RID: 216065 RVA: 0x00C7B4AD File Offset: 0x00C796AD
		private bool CanRunViewOperation()
		{
			return (!this.IsSwitching || this.SwitchFromView == null) && (this.ViewEnable && this.IsShowing) && this.GetCurrentView() != null;
		}

		// Token: 0x06034C02 RID: 216066 RVA: 0x00C7B4E1 File Offset: 0x00C796E1
		[NullableContext(2)]
		private object GetCurrentView()
		{
			if (this.CurrentView == null)
			{
				return null;
			}
			return UiManager.Instance.GetViewByName(this.CurrentView.Value);
		}

		// Token: 0x06034C03 RID: 216067 RVA: 0x00C7B508 File Offset: 0x00C79708
		private UniTask FlushPendingViewOperations()
		{
			PlotViewManager.<FlushPendingViewOperations>d__69 <FlushPendingViewOperations>d__;
			<FlushPendingViewOperations>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushPendingViewOperations>d__.<>4__this = this;
			<FlushPendingViewOperations>d__.<>1__state = -1;
			<FlushPendingViewOperations>d__.<>t__builder.Start<PlotViewManager.<FlushPendingViewOperations>d__69>(ref <FlushPendingViewOperations>d__);
			return <FlushPendingViewOperations>d__.<>t__builder.Task;
		}

		// Token: 0x06034C04 RID: 216068 RVA: 0x00C7B54C File Offset: 0x00C7974C
		private UniTask ExecuteNextPendingViewOperation()
		{
			PlotViewManager.<ExecuteNextPendingViewOperation>d__70 <ExecuteNextPendingViewOperation>d__;
			<ExecuteNextPendingViewOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteNextPendingViewOperation>d__.<>4__this = this;
			<ExecuteNextPendingViewOperation>d__.<>1__state = -1;
			<ExecuteNextPendingViewOperation>d__.<>t__builder.Start<PlotViewManager.<ExecuteNextPendingViewOperation>d__70>(ref <ExecuteNextPendingViewOperation>d__);
			return <ExecuteNextPendingViewOperation>d__.<>t__builder.Task;
		}

		// Token: 0x06034C05 RID: 216069 RVA: 0x00C7B590 File Offset: 0x00C79790
		private UniTask ExecuteViewOperation(PlotUiOperationHandle handle)
		{
			PlotViewManager.<ExecuteViewOperation>d__71 <ExecuteViewOperation>d__;
			<ExecuteViewOperation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteViewOperation>d__.handle = handle;
			<ExecuteViewOperation>d__.<>1__state = -1;
			<ExecuteViewOperation>d__.<>t__builder.Start<PlotViewManager.<ExecuteViewOperation>d__71>(ref <ExecuteViewOperation>d__);
			return <ExecuteViewOperation>d__.<>t__builder.Task;
		}

		// Token: 0x06034C06 RID: 216070 RVA: 0x00C7B5D3 File Offset: 0x00C797D3
		private void CancelPendingViewOperations()
		{
			while (this.PendingViewOperations.Count > 0)
			{
				this.CancelViewOperation(this.PendingViewOperations[0]);
				this.PendingViewOperations.RemoveAt(0);
			}
		}

		// Token: 0x06034C07 RID: 216071 RVA: 0x00C7B603 File Offset: 0x00C79803
		private void CancelViewOperation(PlotUiOperationHandle handle)
		{
			Action onCancel = handle.OnCancel;
			if (onCancel != null)
			{
				onCancel();
			}
			handle.ResultPromise.SetResult(false);
		}

		// Token: 0x06034C08 RID: 216072 RVA: 0x00C7B622 File Offset: 0x00C79822
		private void FinishSwitching()
		{
			this.IsSwitching = false;
			this.SwitchFromView = null;
			this.SwitchToView = null;
		}

		// Token: 0x0401C1BA RID: 115130
		private EUiViewName? CurrentView;

		// Token: 0x0401C1BB RID: 115131
		private long? CurrentViewOwnerId;

		// Token: 0x0401C1BC RID: 115132
		private HashSet<TCallback> Callbacks = new HashSet<TCallback>();

		// Token: 0x0401C1BD RID: 115133
		private bool IsShowing;

		// Token: 0x0401C1BE RID: 115134
		private bool ViewEnable;

		// Token: 0x0401C1BF RID: 115135
		private bool IsLock;

		// Token: 0x0401C1C0 RID: 115136
		private readonly Queue<ViewHandle> PendingHandle = new Queue<ViewHandle>(4);

		// Token: 0x0401C1C1 RID: 115137
		[Nullable(2)]
		private PlotTipsViewBase TipsView;

		// Token: 0x0401C1C2 RID: 115138
		private readonly List<PlotUiOperationHandle> PendingViewOperations = new List<PlotUiOperationHandle>();

		// Token: 0x0401C1C3 RID: 115139
		private bool IsFlushingViewOperation;

		// Token: 0x0401C1C4 RID: 115140
		private EUiViewName? SwitchFromView;

		// Token: 0x0401C1C5 RID: 115141
		private EUiViewName? SwitchToView;

		// Token: 0x0401C1C6 RID: 115142
		private bool IsSwitching;
	}
}
