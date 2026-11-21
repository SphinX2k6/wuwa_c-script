using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.MovieMode;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004035 RID: 16437
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotView : UiTickViewBase, ISimulatePlot
	{
		// Token: 0x060299EB RID: 170475 RVA: 0x00BC274C File Offset: 0x00BC094C
		[NullableContext(1)]
		public PlotView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x170053F2 RID: 21490
		// (get) Token: 0x060299EC RID: 170476 RVA: 0x00BC27A2 File Offset: 0x00BC09A2
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public PlotOptionItem[] Options
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				PlotTextCommonLogic commonLogic = this.CommonLogic;
				if (commonLogic == null)
				{
					return null;
				}
				return commonLogic.Options;
			}
		}

		// Token: 0x170053F3 RID: 21491
		// (get) Token: 0x060299ED RID: 170477 RVA: 0x00BC27B5 File Offset: 0x00BC09B5
		public ITalkItem CurrentSubtitle
		{
			get
			{
				return this.CommonLogic.CurrentContent;
			}
		}

		// Token: 0x170053F4 RID: 21492
		// (get) Token: 0x060299EE RID: 170478 RVA: 0x00BC27C2 File Offset: 0x00BC09C2
		public bool HasOptions
		{
			get
			{
				return this.CurrentSubtitle != null && this.CurrentSubtitle.Options != null && this.CurrentSubtitle.Options.Count != 0;
			}
		}

		// Token: 0x060299EF RID: 170479 RVA: 0x00BC27F0 File Offset: 0x00BC09F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 54;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(33, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(34, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(35, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(36, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(37, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(38, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(39, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(40, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(41, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(42, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(43, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(44, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(45, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(46, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(47, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(48, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(49, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(50, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(51, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(52, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(53, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnAutoClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(18, new Action(this.OnBtnHideClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(33, new Action(this.OnBtnReviewClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060299F0 RID: 170480 RVA: 0x00BC2FC0 File Offset: 0x00BC11C0
		protected override void OnStart()
		{
			base.GetRootItem().GetRenderCanvas().bPostTickUpdate = false;
			UUIScrollViewComponent scrollView = base.GetScrollView(27);
			if (scrollView != null)
			{
				scrollView.SetCanScroll(false);
			}
			if (scrollView != null)
			{
				scrollView.SetRayCastTargetForScrollView(false);
			}
			UUIText text = base.GetText(42);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			this.CommonLogic = new PlotTextCommonLogic(base.GetItem(3), base.GetText(4), base.GetText(17), base.GetText(5), base.GetItem(11), scrollView, this, base.GetLayoutBase(7), base.GetItem(6), base.GetSlider(34), this.UiViewSequence, base.GetItem(32), base.GetItem(28), base.GetItem(44), base.GetTexture(47), base.GetText(48), delegate(string path, UUITexture texture)
			{
				base.SetTextureByPath(path, texture, null, null);
			}, base.GetSlider(49), delegate()
			{
				this.UpdateAutoPlayButton();
			}, base.GetItem(45));
			this.CommonLogic.SetPlotContentAnimFinishCallback(new Action(this.HandleSubtitleAnimFinished));
			this.CommonLogic.SetPlotAudioEndCallback(new Action<float>(this.HandlePlotAudioEnd));
			base.GetButton(2).RootUIComp.Get().SetUIActive(false);
			this.SkipComp = new PlotSkipComponent(base.GetButton(2), new Action(this.OnSkip), new Action(this.OnSkipPop), null, new Action(this.OnSkipCancel), null, null);
			this.SkipComp.EnableSkipButton(false);
			base.GetButton(33).RootUIComp.Get().SetUIActive(false);
			this.ReviewComp = new PlotReviewComponent(base.GetButton(33), new Action(this.OnBtnReviewClick));
			this.ReviewComp.EnableReviewButton(false);
			this.SkipSubtitleTipItem = base.GetItem(19);
			this.SkipSubtitleTipItemNew = base.GetItem(53);
			this.PlotTextInitialAnchorY = base.GetItem(3).GetAnchorOffsetY();
			this.SkipSubtitleTipItemActive(false);
			this.ShowWaitingPoint(false);
			this.UpdateByPlotConfig();
			this.AddScreenEffectPlotRoot();
			this.InitTweenAnim(36);
			this.InitTweenAnim(37);
			this.InitTweenAnim(38);
			this.InitTweenAnim(39);
			this.InitTweenAnim(40);
			this.InitTweenAnim(41);
			this.InitTweenAnim(51);
			this.InitTweenAnim(52);
			this.FadeTimePhoto = 0f;
			this.FadeTimeBlackScreen = 0f;
			this.BgWidget = base.GetTexture(22);
			if (this.BgWidget != null)
			{
				this.BgWidget.SetAlpha(0f);
			}
			this.BgWidgetFront = base.GetTexture(23);
			if (this.BgWidgetFront != null)
			{
				this.BgWidgetFront.SetAlpha(0f);
			}
			this.WidgetMiddle = base.GetTexture(25);
			if (this.WidgetMiddle != null)
			{
				this.WidgetMiddle.SetAlpha(0f);
			}
			this.BgWidgetMiddle = base.GetSprite(26);
			if (this.BgWidgetMiddle != null)
			{
				this.BgWidgetMiddle.SetUIActive(false);
			}
			this.BlackBgWidget = base.GetSprite(21);
			if (this.BlackBgWidget != null)
			{
				this.BlackBgWidget.SetAlpha(0f);
			}
			this.IsVisible = true;
		}

		// Token: 0x060299F1 RID: 170481 RVA: 0x00BC32E8 File Offset: 0x00BC14E8
		private void ShowBlackBg(bool isShow, bool useAnim = true)
		{
			if (isShow == this.IsShowBlackBg)
			{
				return;
			}
			this.IsShowBlackBg = isShow;
			if (isShow)
			{
				base.GetSprite(9).SetUIActive(true);
				if (useAnim)
				{
					base.PlaySequence("PlotStart", null, false);
					return;
				}
			}
			else
			{
				if (useAnim)
				{
					base.PlaySequence("PlotClose", null, false);
					return;
				}
				base.GetSprite(9).SetUIActive(false);
			}
		}

		// Token: 0x060299F2 RID: 170482 RVA: 0x00BC3348 File Offset: 0x00BC1548
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			this.UpdateAutoSelectText();
			EPlotLevel? subtitleLevel = PlotModel.Instance.PlotConfig.SubtitleLevel;
			if (subtitleLevel.GetValueOrDefault() != EPlotLevel.LevelC || !PlotModel.Instance.IsUseNewLevelBStyle())
			{
				return;
			}
			UUIItem item = base.GetItem(45);
			if (item != null)
			{
				item.SetAnchorOffsetY(PlotView.GetPnlLayout02OffsetY(now));
			}
		}

		// Token: 0x060299F3 RID: 170483 RVA: 0x00BC339A File Offset: 0x00BC159A
		private static float GetPnlLayout02OffsetY(EInputControllerMainType type)
		{
			if (type == EInputControllerMainType.Gamepad)
			{
				return -60f;
			}
			if (type == EInputControllerMainType.Touch)
			{
				return 0f;
			}
			return -80f;
		}

		// Token: 0x060299F4 RID: 170484 RVA: 0x00BC33B8 File Offset: 0x00BC15B8
		private void UpdatePnlLayout02Offset()
		{
			EPlotLevel? subtitleLevel = PlotModel.Instance.PlotConfig.SubtitleLevel;
			UUIItem item = base.GetItem(45);
			if (subtitleLevel.GetValueOrDefault() == EPlotLevel.LevelC && PlotModel.Instance.IsUseNewLevelBStyle())
			{
				if (item != null)
				{
					item.SetAnchorOffsetY(PlotView.GetPnlLayout02OffsetY(Info.Instance.InputControllerMainType));
					return;
				}
			}
			else if (item != null)
			{
				item.SetAnchorOffsetY(0f);
			}
		}

		// Token: 0x060299F5 RID: 170485 RVA: 0x00BC341C File Offset: 0x00BC161C
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			PlotView.<OnPlayingStartSequenceAsync>d__69 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PlotView.<OnPlayingStartSequenceAsync>d__69>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060299F6 RID: 170486 RVA: 0x00BC3460 File Offset: 0x00BC1660
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			PlotView.<OnPlayingCloseSequenceAsync>d__70 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PlotView.<OnPlayingCloseSequenceAsync>d__70>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060299F7 RID: 170487 RVA: 0x00BC34A3 File Offset: 0x00BC16A3
		protected override void OnAfterShow()
		{
			EventSystem.Instance.Emit<EUiViewName, bool>(EEventName.PlotViewChange, this.ViewInfo.Name, true);
			PlotSkipComponent skipComp = this.SkipComp;
			if (skipComp == null)
			{
				return;
			}
			skipComp.EnableSkipButton(FlowController.Instance.IsSkipEnabled());
		}

		// Token: 0x060299F8 RID: 170488 RVA: 0x00BC34DB File Offset: 0x00BC16DB
		private void InitButtonsVisibilityByImmersiveMode()
		{
			if (InputManager.Instance.IsImmersiveMouseModeEnabled())
			{
				this.ImmersiveInputWakeState = InputManager.Instance.IsShowMouseCursor();
				this.UpdatePlotButtonsVisibility(this.ImmersiveInputWakeState);
			}
		}

		// Token: 0x060299F9 RID: 170489 RVA: 0x00BC3508 File Offset: 0x00BC1708
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Emit<EUiViewName, bool>(EEventName.PlotViewChange, this.ViewInfo.Name, false);
			PlotModel.Instance.OptionEnable = true;
			this.IsAlreadyHavePhoto = false;
			this.FadeTimePhoto = 0f;
			this.FadeTimeBlackScreen = 0f;
			this.RemoveTickPhoto();
			this.RemoveTickBlackScreen();
			this.CommonLogic.OnBeforeHide();
			this.ClearPlotView();
			TimerHandle startDelayTimer = this.StartDelayTimer;
			if (startDelayTimer != null)
			{
				startDelayTimer.Remove();
			}
			this.StartDelayTimer = null;
			base.GetItem(32).SetUIActive(false);
			this.CloseChildView().Forget();
			this.ClearPendingImmersiveSleep();
		}

		// Token: 0x060299FA RID: 170490 RVA: 0x00BC35B0 File Offset: 0x00BC17B0
		protected override void OnBeforeDestroy()
		{
			this.CommonLogic.Clear();
			this.ClearPendingImmersiveSleep();
			this.RemoveScreenEffectPlotRoot();
			this.InteractController = null;
			this.PlotFadeShowPromise = null;
			this.PlotFadeHidePromise = null;
			PlotSkipComponent skipComp = this.SkipComp;
			if (skipComp != null)
			{
				skipComp.OnClear();
			}
			this.SkipComp = null;
			PlotReviewComponent reviewComp = this.ReviewComp;
			if (reviewComp != null)
			{
				reviewComp.OnClear();
			}
			this.ReviewComp = null;
		}

		// Token: 0x060299FB RID: 170491 RVA: 0x00BC361C File Offset: 0x00BC181C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PlotConfigChanged, new Action(this.UpdateByPlotConfig));
			EventSystem.Instance.Add<ITalkItem>(EEventName.UpdatePlotSubtitle, new Action<ITalkItem>(this.UpdateSeqSubtitle));
			EventSystem.Instance.Add(EEventName.ShowPlotSubtitleOptions, new Action(this.ShowOptions));
			EventSystem.Instance.Add<SetHeadIconVisible, Action>(EEventName.UpdatePortraitVisible, new Action<SetHeadIconVisible, Action>(this.HandlePortraitVisible));
			EventSystem.Instance.Add(EEventName.ClearPlotSubtitle, new Action(this.ClearPlotSubtitle));
			EventSystem.Instance.Add<PawnInteractController>(EEventName.TriggerPlotInteraction, new Action<PawnInteractController>(this.TriggerPlotInteraction));
			EventSystem.Instance.Add<bool>(EEventName.HidePlotUi, new Action<bool>(this.HideAll));
			EventSystem.Instance.Add<bool, FKey>(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
			EventSystem.Instance.Add<bool, bool, string, Action>(EEventName.PlotViewBgFadePhoto, new Action<bool, bool, string, Action>(this.OnPlotViewBgFadePhoto));
			EventSystem.Instance.Add<bool, Action>(EEventName.PlotViewBgFadeBlackScreen, new Action<bool, Action>(this.OnPlotViewBgFadeBlackScreen));
			EventSystem.Instance.Add<ShowTalk>(EEventName.PlotStartShowTalk, new Action<ShowTalk>(this.OnShowTalkStart));
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerPlotForward, new Action<float>(this.OnNavigationTriggerPlotForward));
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerPlotRight, new Action<float>(this.OnNavigationTriggerPlotRight));
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerPlotZoom, new Action<float>(this.OnNavigationTriggerPlotZoom));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Add<ETermExplanationViewType>(EEventName.OnTermExplanationViewOpening, new Action<ETermExplanationViewType>(this.OnTermExplanationViewOpen));
			EventSystem.Instance.Add(EEventName.OnTermExplanationViewClosed, new Action(this.OnTermExplanationViewClose));
			EventSystem.Instance.Add<EInputControllerMainType, bool>(EEventName.OnImmersiveInputStateChange, new Action<EInputControllerMainType, bool>(this.OnImmersiveInputStateChange));
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnSizeChanged));
			EventSystem.Instance.Add<IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetUpdate, new Action<IMovieModeAspectOffset>(this.OnMovieModeAspectOffsetChanged));
			EventSystem.Instance.Add<bool, IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetApply, new Action<bool, IMovieModeAspectOffset>(this.OnMovieModeAspectOffsetChanged));
			InputDistributeController.Instance.BindTouch(0, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouchPlotVisible));
			this.SkipComp.AddEventListener();
			EventSystem.Instance.Add<bool>(EEventName.EnableSkipPlot, new Action<bool>(this.OnEnableSkipPlotRestoreTween));
			UUIDraggableComponent uuidraggableComponent = base.GetButton(1).RootUIComp.Get().GetOwner().GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent;
			if (uuidraggableComponent != null)
			{
				uuidraggableComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDragCallBack));
				uuidraggableComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
				uuidraggableComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndDragCallBack));
				uuidraggableComponent.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnBtnSubtitleSkipClick));
				uuidraggableComponent.OnPointerScrollCallBack.Bind(this.OnPointerScrollCallBack);
			}
			UUIItem item = base.GetItem(3);
			TermExplanationController.Instance.RegisterTextHyperlink(base.GetText(5), ETermExplanationViewType.Center, ETermExplanationReportType.Plot, ETermExplanationViewAttachDirection.Up, item, null, null, ETermExplanationGroup.Default, 0, ETermExplanationViewStyle.Default);
		}

		// Token: 0x060299FC RID: 170492 RVA: 0x00BC39AC File Offset: 0x00BC1BAC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PlotConfigChanged, new Action(this.UpdateByPlotConfig));
			EventSystem.Instance.Remove<ITalkItem>(EEventName.UpdatePlotSubtitle, new Action<ITalkItem>(this.UpdateSeqSubtitle));
			EventSystem.Instance.Remove(EEventName.ShowPlotSubtitleOptions, new Action(this.ShowOptions));
			EventSystem.Instance.Remove<SetHeadIconVisible, Action>(EEventName.UpdatePortraitVisible, new Action<SetHeadIconVisible, Action>(this.HandlePortraitVisible));
			EventSystem.Instance.Remove(EEventName.ClearPlotSubtitle, new Action(this.ClearPlotSubtitle));
			EventSystem.Instance.Remove<PawnInteractController>(EEventName.TriggerPlotInteraction, new Action<PawnInteractController>(this.TriggerPlotInteraction));
			EventSystem.Instance.Remove<bool>(EEventName.HidePlotUi, new Action<bool>(this.HideAll));
			EventSystem.Instance.Remove<bool, FKey>(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
			EventSystem.Instance.Remove<bool, bool, string, Action>(EEventName.PlotViewBgFadePhoto, new Action<bool, bool, string, Action>(this.OnPlotViewBgFadePhoto));
			EventSystem.Instance.Remove<bool, Action>(EEventName.PlotViewBgFadeBlackScreen, new Action<bool, Action>(this.OnPlotViewBgFadeBlackScreen));
			EventSystem.Instance.Remove<ShowTalk>(EEventName.PlotStartShowTalk, new Action<ShowTalk>(this.OnShowTalkStart));
			EventSystem.Instance.Remove<float>(EEventName.NavigationTriggerPlotForward, new Action<float>(this.OnNavigationTriggerPlotForward));
			EventSystem.Instance.Remove<float>(EEventName.NavigationTriggerPlotRight, new Action<float>(this.OnNavigationTriggerPlotRight));
			EventSystem.Instance.Remove<float>(EEventName.NavigationTriggerPlotZoom, new Action<float>(this.OnNavigationTriggerPlotZoom));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove<ETermExplanationViewType>(EEventName.OnTermExplanationViewOpening, new Action<ETermExplanationViewType>(this.OnTermExplanationViewOpen));
			EventSystem.Instance.Remove(EEventName.OnTermExplanationViewClosed, new Action(this.OnTermExplanationViewClose));
			EventSystem.Instance.Remove<EInputControllerMainType, bool>(EEventName.OnImmersiveInputStateChange, new Action<EInputControllerMainType, bool>(this.OnImmersiveInputStateChange));
			EventSystem.Instance.Remove<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnSizeChanged));
			EventSystem.Instance.Remove<IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetUpdate, new Action<IMovieModeAspectOffset>(this.OnMovieModeAspectOffsetChanged));
			EventSystem.Instance.Remove<bool, IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetApply, new Action<bool, IMovieModeAspectOffset>(this.OnMovieModeAspectOffsetChanged));
			PlotSkipComponent skipComp = this.SkipComp;
			if (skipComp != null)
			{
				skipComp.RemoveEventListener();
			}
			EventSystem.Instance.Remove<bool>(EEventName.EnableSkipPlot, new Action<bool>(this.OnEnableSkipPlotRestoreTween));
			InputDistributeController.Instance.UnBindTouch(0, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouchPlotVisible));
			UUIDraggableComponent uuidraggableComponent = base.GetButton(1).RootUIComp.Get().GetOwner().GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent;
			if (uuidraggableComponent != null)
			{
				uuidraggableComponent.OnPointerBeginDragCallBack.Unbind();
				uuidraggableComponent.OnPointerDragCallBack.Unbind();
				uuidraggableComponent.OnPointerEndDragCallBack.Unbind();
				uuidraggableComponent.OnPointerUpCallBack.Unbind();
				uuidraggableComponent.OnPointerScrollCallBack.Unbind();
			}
			TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(5));
		}

		// Token: 0x060299FD RID: 170493 RVA: 0x00BC3CF0 File Offset: 0x00BC1EF0
		private void OnSizeChanged()
		{
			base.GetRootItem().GetRenderCanvas().bPostTickUpdate = true;
			TimerSystem.Instance.Next(delegate(float _)
			{
				if (base.GetRootItem().IsValid())
				{
					base.GetRootItem().GetRenderCanvas().bPostTickUpdate = false;
				}
			}, null, null);
		}

		// Token: 0x060299FE RID: 170494 RVA: 0x00BC3D1C File Offset: 0x00BC1F1C
		private void OnTermExplanationViewOpen(ETermExplanationViewType _)
		{
			this.MuteAutoPlay(true);
		}

		// Token: 0x060299FF RID: 170495 RVA: 0x00BC3D25 File Offset: 0x00BC1F25
		private void OnTermExplanationViewClose()
		{
			this.MuteAutoPlay(false);
		}

		// Token: 0x06029A00 RID: 170496 RVA: 0x00BC3D30 File Offset: 0x00BC1F30
		private void OnImmersiveInputStateChange(EInputControllerMainType inputMainType, bool isWake)
		{
			if (!InputManager.Instance.IsImmersiveMouseModeEnabled())
			{
				return;
			}
			if (isWake)
			{
				this.ClearPendingImmersiveSleep();
			}
			else if (!this.IsVisible)
			{
				this.PendingImmersiveSleep = true;
				return;
			}
			if (!isWake && PlotModel.Instance.PlotConfig.AutoPlayState == EAutoPlayState.Manual)
			{
				return;
			}
			if (this.ImmersiveInputWakeState == isWake)
			{
				return;
			}
			this.ApplyImmersiveInputWakeState(isWake);
		}

		// Token: 0x06029A01 RID: 170497 RVA: 0x00BC3D8C File Offset: 0x00BC1F8C
		private void ApplyImmersiveInputWakeState(bool isWake)
		{
			this.ImmersiveInputWakeState = isWake;
			if (this.SkipComp != null)
			{
				this.SkipComp.UpdateImmersiveInputWakeState(this.ImmersiveInputWakeState);
			}
			if (this.ReviewComp != null)
			{
				this.ReviewComp.UpdateImmersiveInputWakeState(this.ImmersiveInputWakeState);
			}
			this.UpdatePlotButtonsVisibility(this.ImmersiveInputWakeState);
			PlotTextCommonLogic commonLogic = this.CommonLogic;
			if (commonLogic == null)
			{
				return;
			}
			commonLogic.OnImmersiveInputStateChange();
		}

		// Token: 0x06029A02 RID: 170498 RVA: 0x00BC3DF0 File Offset: 0x00BC1FF0
		private void TrySchedulePendingImmersiveSleep()
		{
			if (!this.PendingImmersiveSleep)
			{
				return;
			}
			this.PendingImmersiveSleep = false;
			if (PlotModel.Instance.PlotConfig.AutoPlayState == EAutoPlayState.Manual)
			{
				return;
			}
			if (this.PendingImmersiveSleepTimerId != null && TimerSystem.Instance.Has(this.PendingImmersiveSleepTimerId))
			{
				TimerSystem.Instance.Remove(this.PendingImmersiveSleepTimerId);
			}
			this.PendingImmersiveSleepTimerId = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.PendingImmersiveSleepTimerId = null;
				this.ApplyImmersiveInputWakeState(false);
			}, 3000f, null, null, true, 1f);
		}

		// Token: 0x06029A03 RID: 170499 RVA: 0x00BC3E73 File Offset: 0x00BC2073
		private void ClearPendingImmersiveSleep()
		{
			this.PendingImmersiveSleep = false;
			if (this.PendingImmersiveSleepTimerId != null && TimerSystem.Instance.Has(this.PendingImmersiveSleepTimerId))
			{
				TimerSystem.Instance.Remove(this.PendingImmersiveSleepTimerId);
			}
			this.PendingImmersiveSleepTimerId = null;
		}

		// Token: 0x06029A04 RID: 170500 RVA: 0x00BC3EB0 File Offset: 0x00BC20B0
		private void InitTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>();
			TArray<UActorComponent> tarray = base.GetItem(componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				list.Add(tarray.Get(i) as ULGUIPlayTweenComponent);
			}
			if (this.TweenAnimMap == null)
			{
				this.TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();
			}
			this.TweenAnimMap.Add(componentType, list);
		}

		// Token: 0x06029A05 RID: 170501 RVA: 0x00BC3F24 File Offset: 0x00BC2124
		private void PlayTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Play();
				}
			}
		}

		// Token: 0x06029A06 RID: 170502 RVA: 0x00BC3F80 File Offset: 0x00BC2180
		public void StopTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Stop();
				}
			}
		}

		// Token: 0x06029A07 RID: 170503 RVA: 0x00BC3FDC File Offset: 0x00BC21DC
		private void UpdatePlotButtonsVisibility(bool visible)
		{
			bool canPause = PlotModel.Instance.PlotConfig.CanPause;
			if (visible && canPause)
			{
				this.MainButtonsTweenShown = new bool?(true);
				this.StopTweenAnim(41);
				this.StopTweenAnim(52);
				this.PlayTweenAnim(40);
				this.PlayTweenAnim(51);
			}
			else
			{
				this.MainButtonsTweenShown = new bool?(false);
				this.StopTweenAnim(40);
				this.StopTweenAnim(51);
				this.PlayTweenAnim(41);
				this.PlayTweenAnim(52);
			}
			if (this.SkipComp != null)
			{
				bool flag = this.SkipComp.IsSkipButtonEnabled();
				if (visible && flag)
				{
					this.SkipTweenShown = new bool?(true);
					this.StopTweenAnim(37);
					this.PlayTweenAnim(36);
				}
				else
				{
					this.SkipTweenShown = new bool?(false);
					this.StopTweenAnim(36);
					this.PlayTweenAnim(37);
				}
			}
			if (this.ReviewComp != null)
			{
				bool flag2 = this.ReviewComp.IsReviewButtonEnabled();
				if (visible && flag2)
				{
					this.ReviewTweenShown = new bool?(true);
					this.StopTweenAnim(39);
					this.PlayTweenAnim(38);
					return;
				}
				this.ReviewTweenShown = new bool?(false);
				this.StopTweenAnim(38);
				this.PlayTweenAnim(39);
			}
		}

		// Token: 0x06029A08 RID: 170504 RVA: 0x00BC4100 File Offset: 0x00BC2300
		private void RestorePlotButtonsVisibility()
		{
			if (!this.ImmersiveInputWakeState)
			{
				return;
			}
			if (PlotModel.Instance.PlotConfig.CanPause)
			{
				bool? flag = this.MainButtonsTweenShown;
				bool flag2 = false;
				if (flag.GetValueOrDefault() == flag2 & flag != null)
				{
					this.MainButtonsTweenShown = new bool?(true);
					this.StopTweenAnim(41);
					this.StopTweenAnim(52);
					this.PlayTweenAnim(40);
					this.PlayTweenAnim(51);
				}
			}
			PlotSkipComponent skipComp = this.SkipComp;
			if (skipComp != null && skipComp.IsSkipButtonEnabled())
			{
				bool? flag = this.SkipTweenShown;
				bool flag2 = false;
				if (flag.GetValueOrDefault() == flag2 & flag != null)
				{
					this.SkipTweenShown = new bool?(true);
					this.StopTweenAnim(37);
					this.PlayTweenAnim(36);
				}
			}
			PlotReviewComponent reviewComp = this.ReviewComp;
			if (reviewComp != null && reviewComp.IsReviewButtonEnabled())
			{
				bool? flag = this.ReviewTweenShown;
				bool flag2 = false;
				if (flag.GetValueOrDefault() == flag2 & flag != null)
				{
					this.ReviewTweenShown = new bool?(true);
					this.StopTweenAnim(39);
					this.PlayTweenAnim(38);
				}
			}
		}

		// Token: 0x06029A09 RID: 170505 RVA: 0x00BC420A File Offset: 0x00BC240A
		private void OnEnableSkipPlotRestoreTween(bool _)
		{
			this.RestorePlotButtonsVisibility();
		}

		// Token: 0x06029A0A RID: 170506 RVA: 0x00BC4214 File Offset: 0x00BC2414
		private void MuteAutoPlay(bool isMute)
		{
			if (isMute)
			{
				this.CommonLogic.MuteTimeLimitedOption = true;
				PlotModel.Instance.PlotConfig.AutoPlayState = EAutoPlayState.Manual;
				TimerHandle delayId = this.DelayId;
				if (delayId != null)
				{
					delayId.Pause();
				}
				TimerHandle audioEndDelayId = this.AudioEndDelayId;
				if (audioEndDelayId != null)
				{
					audioEndDelayId.Pause();
				}
				this.UpdateAutoPlayButton();
				this.CommonLogic.OnAutoPlayStateChanged();
				return;
			}
			this.CommonLogic.MuteTimeLimitedOption = false;
			PlotConfig plotConfig = PlotModel.Instance.PlotConfig;
			plotConfig.AutoPlayState = plotConfig.AutoPlayStateCache;
			this.UpdateAutoPlayButton();
			this.CommonLogic.OnAutoPlayStateChanged();
			if (TimerSystem.Instance.Has(this.DelayId) && this.DelayId.IsPause())
			{
				TimerHandle delayId2 = this.DelayId;
				if (delayId2 != null)
				{
					delayId2.Resume();
				}
			}
			if (TimerSystem.GameplayTimeInstance.Has(this.AudioEndDelayId) && this.AudioEndDelayId.IsPause())
			{
				TimerHandle audioEndDelayId2 = this.AudioEndDelayId;
				if (audioEndDelayId2 != null)
				{
					audioEndDelayId2.Resume();
				}
			}
			if (plotConfig.AutoPlayState != EAutoPlayState.Manual && this.IsSubtitleFinishDelay)
			{
				this.TryAutoPlayNextTalk();
			}
		}

		// Token: 0x06029A0B RID: 170507 RVA: 0x00BC4320 File Offset: 0x00BC2520
		[NullableContext(1)]
		private void OnShowTalkStart(ShowTalk inShowTalk)
		{
			PlotSkipComponent skipComp = this.SkipComp;
			if (skipComp == null)
			{
				return;
			}
			skipComp.AddSummary(inShowTalk.TalkOutline);
		}

		// Token: 0x06029A0C RID: 170508 RVA: 0x00BC4338 File Offset: 0x00BC2538
		private void OnNavigationTriggerPlotForward(float value)
		{
			InputController.Instance.InputAxis(EInputAxis.LookUp, value, true);
		}

		// Token: 0x06029A0D RID: 170509 RVA: 0x00BC434B File Offset: 0x00BC254B
		private void OnNavigationTriggerPlotRight(float value)
		{
			InputController.Instance.InputAxis(EInputAxis.Turn, value, true);
		}

		// Token: 0x06029A0E RID: 170510 RVA: 0x00BC4360 File Offset: 0x00BC2560
		private void OnNavigationTriggerPlotZoom(float value)
		{
			if (value == 0f)
			{
				return;
			}
			float num = value * 1.2f;
			InputController.Instance.InputAxis(EInputAxis.Zoom, -num, true);
		}

		// Token: 0x06029A0F RID: 170511 RVA: 0x00BC4390 File Offset: 0x00BC2590
		private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!PlotModel.Instance.CanControlView)
			{
				return;
			}
			this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		}

		// Token: 0x06029A10 RID: 170512 RVA: 0x00BC43B0 File Offset: 0x00BC25B0
		private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!PlotModel.Instance.CanControlView)
			{
				return;
			}
			if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
			{
				this.CurrentDragPosition = null;
				return;
			}
			FVector? currentDragPosition = this.CurrentDragPosition;
			this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
			if (currentDragPosition == null)
			{
				return;
			}
			float num = (this.CurrentDragPosition.Value.Y - currentDragPosition.Value.Y) * 0.03f;
			float value = (this.CurrentDragPosition.Value.X - currentDragPosition.Value.X) * 0.06f;
			InputController.Instance.InputAxis(EInputAxis.Turn, value, true);
			InputController.Instance.InputAxis(EInputAxis.LookUp, -num, true);
		}

		// Token: 0x06029A11 RID: 170513 RVA: 0x00BC4471 File Offset: 0x00BC2671
		private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!PlotModel.Instance.CanControlView)
			{
				return;
			}
			this.CurrentDragPosition = null;
		}

		// Token: 0x06029A12 RID: 170514 RVA: 0x00BC448C File Offset: 0x00BC268C
		protected override void OnTick(float delta)
		{
			if (this.TickPhotoFade)
			{
				this.OnFadeTickPhoto(delta);
			}
			if (this.TickBlackScreenFade)
			{
				this.OnFadeTickBlackScreen(delta);
			}
			this.CommonLogic.OnTick(delta);
		}

		// Token: 0x06029A13 RID: 170515 RVA: 0x00BC44B8 File Offset: 0x00BC26B8
		public void SimulateClickSubtitle()
		{
		}

		// Token: 0x06029A14 RID: 170516 RVA: 0x00BC44BC File Offset: 0x00BC26BC
		public void SimulateClickOption()
		{
		}

		// Token: 0x06029A15 RID: 170517 RVA: 0x00BC44C9 File Offset: 0x00BC26C9
		private void OnSkip()
		{
			this.MuteAutoPlay(false);
			this.ShowUiExceptPhoto();
			FlowController.Instance.BackgroundFlow("UI点击跳过(PlotView)", true, false, true);
		}

		// Token: 0x06029A16 RID: 170518 RVA: 0x00BC44EC File Offset: 0x00BC26EC
		private void UpdateByPlotConfig()
		{
			this.SkipComp.EnableSkipButton(false);
			PlotConfig plotConfig = PlotModel.Instance.PlotConfig;
			this.ClearOptions();
			bool canPause = plotConfig.CanPause;
			UUIItem uuiitem = base.GetButton(0).RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(canPause);
			}
			base.GetButton(18).RootUIComp.Get().SetUIActive(canPause);
			this.ReviewComp.EnableReviewButton(canPause);
			UUIItem uuiitem2 = base.GetButton(1).RootUIComp.Get();
			if (uuiitem2 != null)
			{
				uuiitem2.SetUIActive(true);
			}
			this.UpdateAutoPlayButton();
			this.IsShowBlackBg = true;
			base.GetSprite(9).SetUIActive(this.IsShowBlackBg);
			this.RestorePlotButtonsVisibility();
			this.UpdatePlotTextOffset();
		}

		// Token: 0x06029A17 RID: 170519 RVA: 0x00BC45B0 File Offset: 0x00BC27B0
		[NullableContext(1)]
		private void UpdateSeqSubtitle(ITalkItem inPlotSubtitleInfo)
		{
			this.RemoveDelayTimer();
			this.RemoveAudioEndDelayTimer();
			this.IsSubtitleFinishDelay = false;
			this.IsAudioFinishDelay = false;
			this.CanJumpToNextTalk = false;
			TimerHandle startDelayTimer = this.StartDelayTimer;
			if (startDelayTimer != null)
			{
				startDelayTimer.Remove();
			}
			this.StartDelayTimer = null;
			ICaptionParam captionParams = inPlotSubtitleInfo.CaptionParams;
			float num = ((captionParams != null) ? captionParams.StartTime : null).GetValueOrDefault() * 1000f;
			bool flag = false;
			if (inPlotSubtitleInfo.Type.GetValueOrDefault() == ETalkItemType.SystemOption)
			{
				flag = (inPlotSubtitleInfo as ITalkItemSystemOption).OptionConfig.KeepPreTalkItem.GetValueOrDefault();
			}
			if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC && num > 20f)
			{
				if (!flag)
				{
					this.ShowBlackBg(false, true);
				}
				this.ClearOptions();
				this.StartDelayTimer = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.StartDelayTimer = null;
					this.CommonLogic.UpdatePlotSubtitle(inPlotSubtitleInfo);
					if (inPlotSubtitleInfo.Type.GetValueOrDefault() == ETalkItemType.Option || inPlotSubtitleInfo.Type.GetValueOrDefault() == ETalkItemType.SystemOption)
					{
						this.HandleSubtitleActions();
						return;
					}
					this.PlaySubtitle(inPlotSubtitleInfo);
				}, num, null, null, true, 1f);
				return;
			}
			this.CommonLogic.UpdatePlotSubtitle(inPlotSubtitleInfo);
			if (inPlotSubtitleInfo.Type.GetValueOrDefault() == ETalkItemType.Option || inPlotSubtitleInfo.Type.GetValueOrDefault() == ETalkItemType.SystemOption)
			{
				if (!flag)
				{
					this.ShowBlackBg(false, true);
				}
				this.ClearOptions();
				this.HandleSubtitleActions();
				return;
			}
			this.PlaySubtitle(inPlotSubtitleInfo);
		}

		// Token: 0x06029A18 RID: 170520 RVA: 0x00BC472A File Offset: 0x00BC292A
		private void ShowOptions()
		{
			this.UpdatePnlLayout02Offset();
			this.CommonLogic.ShowOptions();
		}

		// Token: 0x06029A19 RID: 170521 RVA: 0x00BC473D File Offset: 0x00BC293D
		private void ClearOptions()
		{
			this.CommonLogic.ClearOptions();
		}

		// Token: 0x06029A1A RID: 170522 RVA: 0x00BC474A File Offset: 0x00BC294A
		private void HideUiExceptPhoto()
		{
			UUIItem item = base.GetItem(29);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(30);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06029A1B RID: 170523 RVA: 0x00BC4773 File Offset: 0x00BC2973
		private void ShowUiExceptPhoto()
		{
			UUIItem item = base.GetItem(29);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(30);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(true);
		}

		// Token: 0x06029A1C RID: 170524 RVA: 0x00BC479C File Offset: 0x00BC299C
		private void UpdateAutoPlayButton()
		{
			PlotConfig plotConfig = PlotModel.Instance.PlotConfig;
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(plotConfig.AutoPlayState == EAutoPlayState.Manual);
			}
			UUIItem item2 = base.GetItem(15);
			if (item2 != null)
			{
				item2.SetUIActive(plotConfig.AutoPlayState == EAutoPlayState.SemiAuto);
			}
			UUIItem item3 = base.GetItem(16);
			if (item3 != null)
			{
				item3.SetUIActive(plotConfig.AutoPlayState == EAutoPlayState.Auto);
			}
			this.UpdateAutoSelectText();
		}

		// Token: 0x06029A1D RID: 170525 RVA: 0x00BC4810 File Offset: 0x00BC2A10
		private void UpdateAutoSelectText()
		{
			UUIText text = base.GetText(50);
			if (text == null)
			{
				return;
			}
			PlotConfig plotConfig = PlotModel.Instance.PlotConfig;
			bool flag = Info.Instance.IsInGamepad() && plotConfig.CanPause;
			text.SetUIActive(flag);
			if (!flag)
			{
				return;
			}
			string autoSelectTextKey = this.GetAutoSelectTextKey(plotConfig.AutoPlayState);
			text.SetText(ConfigMultiTextLang.GetLocalTextNew(autoSelectTextKey, null) ?? autoSelectTextKey, true);
		}

		// Token: 0x06029A1E RID: 170526 RVA: 0x00BC4876 File Offset: 0x00BC2A76
		[NullableContext(1)]
		private string GetAutoSelectTextKey(EAutoPlayState autoPlayState)
		{
			switch (autoPlayState)
			{
			case EAutoPlayState.Manual:
				return "HotKeyText_HalfAutoPlot_Name";
			case EAutoPlayState.SemiAuto:
				return "HotKeyText_AutoPlot_Name";
			case EAutoPlayState.Auto:
				return "HotKeyText_CancelAutoPlot_Name";
			default:
				return "HotKeyText_HalfAutoPlot_Name";
			}
		}

		// Token: 0x06029A1F RID: 170527 RVA: 0x00BC48A3 File Offset: 0x00BC2AA3
		[NullableContext(1)]
		private void HandlePortraitVisible(SetHeadIconVisible headIconInfo, Action callback)
		{
			this.CommonLogic.HandlePortraitVisible(this.RootItem, headIconInfo, callback);
		}

		// Token: 0x06029A20 RID: 170528 RVA: 0x00BC48B8 File Offset: 0x00BC2AB8
		[NullableContext(1)]
		private void TriggerPlotInteraction(PawnInteractController interactController)
		{
			this.CommonLogic.IsInteraction = true;
			this.InteractController = interactController;
			this.PreTalkItems = PlotController.Instance.GetTalkItemsOfFlow(this.InteractController.PreTalkConfigs);
			this.PreTalkIndex = -1;
			if (this.PreTalkItems != null)
			{
				PlotModel.Instance.FlowListName = this.InteractController.PreTalkConfigs.FlowListName;
				this.PlayNextPreTalk();
				return;
			}
			this.InitInteractOptions();
		}

		// Token: 0x06029A21 RID: 170529 RVA: 0x00BC492C File Offset: 0x00BC2B2C
		[NullableContext(1)]
		private void PlaySubtitle(ITalkItem currentContent)
		{
			this.ClearOptions();
			EPlotLevel? subtitleLevel = PlotModel.Instance.PlotConfig.SubtitleLevel;
			UUIItem item = base.GetItem(45);
			UUIScrollViewComponent scrollView = base.GetScrollView(27);
			object obj;
			if (scrollView == null)
			{
				obj = null;
			}
			else
			{
				UUIItem rootComponent = scrollView.GetRootComponent();
				if (rootComponent == null)
				{
					obj = null;
				}
				else
				{
					AActor owner = rootComponent.GetOwner();
					obj = ((owner != null) ? owner.GetComponentByClass(UUISizeControlByOther.StaticClass()) : null);
				}
			}
			UUISizeControlByOther uuisizeControlByOther = obj as UUISizeControlByOther;
			if (subtitleLevel.GetValueOrDefault() == EPlotLevel.LevelC && PlotModel.Instance.IsUseNewLevelBStyle())
			{
				this.ShowBlackBg(false, false);
				base.GetItem(3).SetAlpha(1f);
				if (uuisizeControlByOther != null)
				{
					uuisizeControlByOther.MinHeight = 60;
				}
				if (item != null)
				{
					item.SetAnchorOffsetY(PlotView.GetPnlLayout02OffsetY(Info.Instance.InputControllerMainType));
				}
			}
			else
			{
				this.ShowBlackBg(true, true);
				if (uuisizeControlByOther != null)
				{
					uuisizeControlByOther.MinHeight = 174;
				}
				if (item != null)
				{
					item.SetAnchorOffsetY(0f);
				}
			}
			this.UpdatePlotTextOffset();
			if (this.CommonLogic.IsInteraction || !PlotModel.Instance.PlotConfig.CanInteractive)
			{
				this.SkipSubtitleTipItemActive(true);
				this.ShowWaitingPoint(false);
				this.CanJumpToNextTalk = true;
				return;
			}
			float? waitTime = currentContent.WaitTime;
			if (waitTime == null)
			{
				waitTime = new float?(PlotModel.Instance.PlotGlobalConfig.JumpWaitTime);
				currentContent.WaitTime = new float?(waitTime.Value);
			}
			float? num = waitTime;
			double? num2 = (num != null) ? new double?((double)num.GetValueOrDefault()) : null;
			double minWaitingTime = PlotModel.Instance.PlotTemplate.MinWaitingTime;
			if (num2.GetValueOrDefault() < minWaitingTime & num2 != null)
			{
				waitTime = new float?((float)PlotModel.Instance.PlotTemplate.MinWaitingTime);
				currentContent.WaitTime = new float?(waitTime.Value);
			}
			waitTime = new float?((float)TimeUtil.Instance.SetTimeMillisecond((double)waitTime.Value));
			num = waitTime;
			float num3 = (float)20;
			if (num.GetValueOrDefault() < num3 & num != null)
			{
				this.SkipSubtitleTipItemActive(true);
				this.ShowWaitingPoint(false);
				this.CanJumpToNextTalk = true;
				return;
			}
			this.SkipSubtitleTipItemActive(false);
			this.ShowWaitingPoint(true);
			this.WaitingSkipTimerId = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.ShowWaitingPoint(false);
				this.WaitingSkipTimerId = null;
				this.CanJumpToNextTalk = true;
				if (!this.CommonLogic.IsTextAnimPlaying)
				{
					if (this.HasOptions)
					{
						this.HandleSubtitleActions();
						return;
					}
					this.DelayHandleSubtitleActions();
				}
				this.SkipSubtitleTipItemActive(true);
			}, waitTime.Value, null, null, true, 1f);
		}

		// Token: 0x06029A22 RID: 170530 RVA: 0x00BC4B7D File Offset: 0x00BC2D7D
		private void HandleSubtitleAnimFinished()
		{
			if (this.CommonLogic.IsInteraction)
			{
				this.DelayHandleSubtitleActions();
				return;
			}
			if (!this.CanJumpToNextTalk)
			{
				return;
			}
			if (this.HasOptions)
			{
				this.SkipSubtitleTipItemActive(false);
				this.HandleSubtitleActions();
				return;
			}
			this.DelayHandleSubtitleActions();
		}

		// Token: 0x06029A23 RID: 170531 RVA: 0x00BC4BB8 File Offset: 0x00BC2DB8
		private void DelayHandleSubtitleActions()
		{
			this.RemoveDelayTimer();
			float num = 1f;
			if (this.CommonLogic.IsInteraction)
			{
				num = PlotModel.Instance.PlotGlobalConfig.EndWaitTimeInteraction;
			}
			else if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC)
			{
				num = PlotModel.Instance.PlotGlobalConfig.EndWaitTimeLevelC;
			}
			if ((double)num < PlotModel.Instance.PlotTemplate.MinWaitingTime)
			{
				num = (float)PlotModel.Instance.PlotTemplate.MinWaitingTime;
			}
			num *= 1000f;
			TimerHandle delayId = null;
			delayId = TimerSystem.Instance.Delay(delegate(float _)
			{
				if (this.DelayId == delayId)
				{
					this.DelayId = null;
				}
				this.IsSubtitleFinishDelay = true;
				this.TryAutoPlayNextTalk();
			}, Math.Max(this.CommonLogic.PlayDelayTime.GetValueOrDefault(), num), null, null, true, 1f);
			this.DelayId = delayId;
		}

		// Token: 0x06029A24 RID: 170532 RVA: 0x00BC4CA0 File Offset: 0x00BC2EA0
		private void HandlePlotAudioEnd(float tailTime)
		{
			this.RemoveAudioEndDelayTimer();
			if (tailTime <= 20f)
			{
				this.IsAudioFinishDelay = true;
				this.TryAutoPlayNextTalk();
				return;
			}
			this.AudioEndDelayId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.AudioEndDelayId = null;
				this.IsAudioFinishDelay = true;
				this.TryAutoPlayNextTalk();
			}, tailTime, null, null, true, 1f);
		}

		// Token: 0x06029A25 RID: 170533 RVA: 0x00BC4CEE File Offset: 0x00BC2EEE
		private void TryAutoPlayNextTalk()
		{
			if (!this.IsSubtitleFinishDelay || !this.IsAudioFinishDelay || PlotModel.Instance.PlotConfig.AutoPlayState == EAutoPlayState.Manual)
			{
				return;
			}
			this.SkipSubtitleTipItemActive(false);
			this.HandleSubtitleActions();
		}

		// Token: 0x06029A26 RID: 170534 RVA: 0x00BC4D20 File Offset: 0x00BC2F20
		private void HandleSubtitleActions()
		{
			this.CanJumpToNextTalk = false;
			this.IsSubtitleFinishDelay = false;
			this.IsAudioFinishDelay = false;
			this.RemoveDelayTimer();
			this.RemoveAudioEndDelayTimer();
			if (this.CommonLogic.IsInteraction)
			{
				this.PlayNextPreTalk();
				return;
			}
			FlowController.Instance.FlowShowTalk.SubmitSubtitle(this.CommonLogic.CurrentContent);
		}

		// Token: 0x06029A27 RID: 170535 RVA: 0x00BC4D7C File Offset: 0x00BC2F7C
		private void InitInteractOptions()
		{
			this.CommonLogic.InitInteractOptions();
		}

		// Token: 0x06029A28 RID: 170536 RVA: 0x00BC4D8C File Offset: 0x00BC2F8C
		private void PlayNextPreTalk()
		{
			this.PreTalkIndex++;
			if (this.PreTalkIndex < this.PreTalkItems.Count)
			{
				this.CommonLogic.ClearPlotContent(false);
				ITalkItem talkItem = this.PreTalkItems[this.PreTalkIndex];
				this.CommonLogic.PlaySubtitle(talkItem);
				this.PlaySubtitle(talkItem);
				return;
			}
			if (this.PreTalkIndex == this.PreTalkItems.Count)
			{
				this.InitInteractOptions();
			}
		}

		// Token: 0x06029A29 RID: 170537 RVA: 0x00BC4E08 File Offset: 0x00BC3008
		protected unsafe void OnBtnSubtitleSkipClick(ULGUIPointerEventData eventData)
		{
			if (((eventData != null) ? eventData.dragComponent : null) != null && PlotModel.Instance.CanControlView)
			{
				return;
			}
			if (this.CommonLogic.IsInteraction)
			{
				if (this.PreTalkItems == null || this.PreTalkIndex >= this.PreTalkItems.Count)
				{
					return;
				}
			}
			else if (!FlowController.Instance.IsInShowTalk())
			{
				return;
			}
			if (!this.CanJumpToNextTalk)
			{
				if (this.WaitingSkipTimerId != null && this.CommonLogic.SubtitleAnimationTimer == null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.Plot;
					ELogAuthor author = ELogAuthor.FZX;
					string message = "当前字幕已显示完全，但等待时间未结束，无法点到下一句";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TalkId", this.CommonLogic.CurrentContent.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("WaitTime", this.CommonLogic.CurrentContent.WaitTime);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("AnimationTime", this.CommonLogic.GetPlotContentAnimDuration());
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
				return;
			}
			if (this.CommonLogic.SubtitleAnimationTimer != null)
			{
				this.CommonLogic.ForceSkipPlotContentAnim();
				return;
			}
			this.SkipSubtitleTipItemActive(false);
			this.HandleSubtitleActions();
			AudioSystem.Instance.PostEvent("play_ui_ia_spl_plot_next");
		}

		// Token: 0x06029A2A RID: 170538 RVA: 0x00BC4F68 File Offset: 0x00BC3168
		protected void OnBtnAutoClick()
		{
			EAutoPlayState eautoPlayState = EAutoPlayState.Manual;
			switch (PlotModel.Instance.PlotConfig.AutoPlayState)
			{
			case EAutoPlayState.Manual:
				eautoPlayState = EAutoPlayState.SemiAuto;
				break;
			case EAutoPlayState.SemiAuto:
				eautoPlayState = EAutoPlayState.Auto;
				break;
			case EAutoPlayState.Auto:
				eautoPlayState = EAutoPlayState.Manual;
				break;
			}
			PlotModel.Instance.PlotConfig.AutoPlayState = eautoPlayState;
			PlotModel.Instance.PlotConfig.AutoPlayStateCache = eautoPlayState;
			if (eautoPlayState > EAutoPlayState.Manual && this.IsSubtitleFinishDelay)
			{
				this.TryAutoPlayNextTalk();
			}
			this.CommonLogic.OnAutoPlayStateChanged();
			this.UpdateAutoPlayButton();
		}

		// Token: 0x06029A2B RID: 170539 RVA: 0x00BC4FEA File Offset: 0x00BC31EA
		private void OnSkipPop()
		{
			this.MuteAutoPlay(true);
			this.HideUiExceptPhoto();
		}

		// Token: 0x06029A2C RID: 170540 RVA: 0x00BC4FF9 File Offset: 0x00BC31F9
		private void OnSkipCancel()
		{
			this.MuteAutoPlay(false);
			this.ShowUiExceptPhoto();
		}

		// Token: 0x06029A2D RID: 170541 RVA: 0x00BC5008 File Offset: 0x00BC3208
		private void OnBtnHideClick()
		{
			this.HideUiExceptPhoto();
			this.IsVisible = false;
			this.MuteAutoPlay(true);
		}

		// Token: 0x06029A2E RID: 170542 RVA: 0x00BC501E File Offset: 0x00BC321E
		private void OnBtnReviewClick()
		{
			if (FlowController.Instance.OpenPlotReviewView())
			{
				this.HideUiExceptPhoto();
				this.MuteAutoPlay(true);
			}
		}

		// Token: 0x06029A2F RID: 170543 RVA: 0x00BC5039 File Offset: 0x00BC3239
		private void OnOpenView(EUiViewName viewName, int _)
		{
			if (viewName == EUiViewName.PlotReviewView)
			{
				AudioSystem.Instance.PostEvent("plot_review_enter");
			}
		}

		// Token: 0x06029A30 RID: 170544 RVA: 0x00BC5058 File Offset: 0x00BC3258
		private void OnCloseView(EUiViewName viewName, int _)
		{
			if (viewName == EUiViewName.PlotReviewView)
			{
				AudioSystem.Instance.PostEvent("plot_review_exit");
				this.IsVisible = true;
				this.ShowUiExceptPhoto();
				this.MuteAutoPlay(false);
				this.RestorePlotButtonsVisibility();
			}
		}

		// Token: 0x06029A31 RID: 170545 RVA: 0x00BC5094 File Offset: 0x00BC3294
		private void SkipSubtitleTipItemActive(bool value)
		{
			PlotModel.Instance.CanClick = value;
			bool flag = PlotModel.Instance.IsNewSubtitleStyleActive();
			UUIItem skipSubtitleTipItem = this.SkipSubtitleTipItem;
			if (skipSubtitleTipItem != null)
			{
				skipSubtitleTipItem.SetUIActive(value && !flag);
			}
			UUIItem skipSubtitleTipItemNew = this.SkipSubtitleTipItemNew;
			if (skipSubtitleTipItemNew != null)
			{
				skipSubtitleTipItemNew.SetUIActive(value && flag);
			}
			EventSystem.Instance.Emit<bool>(EEventName.NavigationRefreshPlotNextPage, value);
		}

		// Token: 0x06029A32 RID: 170546 RVA: 0x00BC50F8 File Offset: 0x00BC32F8
		private void ShowWaitingPoint(bool enable)
		{
			bool uiactive = enable && !PlotModel.Instance.IsNewSubtitleStyleActive();
			base.GetItem(20).SetUIActive(uiactive);
		}

		// Token: 0x06029A33 RID: 170547 RVA: 0x00BC5127 File Offset: 0x00BC3327
		[NullableContext(1)]
		private void OnMovieModeAspectOffsetChanged(IMovieModeAspectOffset _)
		{
			this.UpdatePlotTextOffset();
		}

		// Token: 0x06029A34 RID: 170548 RVA: 0x00BC512F File Offset: 0x00BC332F
		private void OnMovieModeAspectOffsetChanged(bool _, IMovieModeAspectOffset __)
		{
			this.UpdatePlotTextOffset();
		}

		// Token: 0x06029A35 RID: 170549 RVA: 0x00BC5138 File Offset: 0x00BC3338
		private void UpdatePlotTextOffset()
		{
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			bool flag = PlotModel.Instance.IsNewSubtitleStyleActive() && MovieModeController.Instance.IsHorizontalBlackBarsVisible();
			item.SetAnchorOffsetY(this.PlotTextInitialAnchorY + (flag ? -28f : 0f));
		}

		// Token: 0x06029A36 RID: 170550 RVA: 0x00BC5187 File Offset: 0x00BC3387
		private void RemoveDelayTimer()
		{
			if (TimerSystem.Instance.Has(this.DelayId))
			{
				TimerSystem.Instance.Remove(this.DelayId);
			}
			this.DelayId = null;
		}

		// Token: 0x06029A37 RID: 170551 RVA: 0x00BC51B3 File Offset: 0x00BC33B3
		private void RemoveAudioEndDelayTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.AudioEndDelayId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AudioEndDelayId);
			}
			this.AudioEndDelayId = null;
		}

		// Token: 0x06029A38 RID: 170552 RVA: 0x00BC51DF File Offset: 0x00BC33DF
		public void RemoveWaitSkipTimer()
		{
			if (TimerSystem.Instance.Has(this.WaitingSkipTimerId))
			{
				TimerSystem.Instance.Remove(this.WaitingSkipTimerId);
			}
			this.WaitingSkipTimerId = null;
		}

		// Token: 0x06029A39 RID: 170553 RVA: 0x00BC520B File Offset: 0x00BC340B
		private void HideAll(bool isHidden)
		{
			this.RootItem.SetUIActive(!isHidden);
		}

		// Token: 0x06029A3A RID: 170554 RVA: 0x00BC521C File Offset: 0x00BC341C
		[NullableContext(1)]
		private void OnInputAnyKey(bool bPress, FKey key)
		{
			if (!bPress)
			{
				return;
			}
			if (this.IsVisible)
			{
				return;
			}
			this.IsVisible = true;
			this.ShowUiExceptPhoto();
			this.MuteAutoPlay(false);
			this.TrySchedulePendingImmersiveSleep();
		}

		// Token: 0x06029A3B RID: 170555 RVA: 0x00BC5245 File Offset: 0x00BC3445
		[NullableContext(1)]
		private void OnTouchPlotVisible(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
		{
			if (touchData.TouchType != InputDistributeDefine.ETouchType.TouchBegin)
			{
				return;
			}
			if (this.IsVisible)
			{
				return;
			}
			this.IsVisible = true;
			this.ShowUiExceptPhoto();
			this.TrySchedulePendingImmersiveSleep();
		}

		// Token: 0x06029A3C RID: 170556 RVA: 0x00BC526C File Offset: 0x00BC346C
		private void OnPlotViewBgFadePhoto(bool isFadeIn, bool isFull, string path, Action callback)
		{
			this.DoOnPlotViewBgFadePhoto(isFadeIn, isFull, path, callback);
		}

		// Token: 0x06029A3D RID: 170557 RVA: 0x00BC527C File Offset: 0x00BC347C
		private UniTask DoOnPlotViewBgFadePhoto(bool isFadeIn, bool isFull, string path, Action callback)
		{
			PlotView.<DoOnPlotViewBgFadePhoto>d__142 <DoOnPlotViewBgFadePhoto>d__;
			<DoOnPlotViewBgFadePhoto>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DoOnPlotViewBgFadePhoto>d__.<>4__this = this;
			<DoOnPlotViewBgFadePhoto>d__.isFadeIn = isFadeIn;
			<DoOnPlotViewBgFadePhoto>d__.isFull = isFull;
			<DoOnPlotViewBgFadePhoto>d__.path = path;
			<DoOnPlotViewBgFadePhoto>d__.callback = callback;
			<DoOnPlotViewBgFadePhoto>d__.<>1__state = -1;
			<DoOnPlotViewBgFadePhoto>d__.<>t__builder.Start<PlotView.<DoOnPlotViewBgFadePhoto>d__142>(ref <DoOnPlotViewBgFadePhoto>d__);
			return <DoOnPlotViewBgFadePhoto>d__.<>t__builder.Task;
		}

		// Token: 0x06029A3E RID: 170558 RVA: 0x00BC52E0 File Offset: 0x00BC34E0
		private void OnPlotViewBgFadeBlackScreen(bool isFadeIn, Action callback)
		{
			this.DoOnPlotViewBgFadeBlackScreen(isFadeIn, callback);
		}

		// Token: 0x06029A3F RID: 170559 RVA: 0x00BC52EC File Offset: 0x00BC34EC
		private UniTask DoOnPlotViewBgFadeBlackScreen(bool isFadeIn, Action callback)
		{
			PlotView.<DoOnPlotViewBgFadeBlackScreen>d__144 <DoOnPlotViewBgFadeBlackScreen>d__;
			<DoOnPlotViewBgFadeBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DoOnPlotViewBgFadeBlackScreen>d__.<>4__this = this;
			<DoOnPlotViewBgFadeBlackScreen>d__.isFadeIn = isFadeIn;
			<DoOnPlotViewBgFadeBlackScreen>d__.callback = callback;
			<DoOnPlotViewBgFadeBlackScreen>d__.<>1__state = -1;
			<DoOnPlotViewBgFadeBlackScreen>d__.<>t__builder.Start<PlotView.<DoOnPlotViewBgFadeBlackScreen>d__144>(ref <DoOnPlotViewBgFadeBlackScreen>d__);
			return <DoOnPlotViewBgFadeBlackScreen>d__.<>t__builder.Task;
		}

		// Token: 0x06029A40 RID: 170560 RVA: 0x00BC533F File Offset: 0x00BC353F
		private void ClearPlotSubtitle()
		{
			this.ClearPlotView();
			this.CommonLogic.ClearPlotContent(false);
		}

		// Token: 0x06029A41 RID: 170561 RVA: 0x00BC5354 File Offset: 0x00BC3554
		private void ClearPlotView()
		{
			this.RemoveWaitSkipTimer();
			this.RemoveDelayTimer();
			this.RemoveAudioEndDelayTimer();
			this.ClearOptions();
			base.GetItem(3).SetUIActive(false);
			base.GetText(4).SetUIActive(false);
			base.GetText(17).SetUIActive(false);
			base.GetItem(11).SetUIActive(false);
		}

		// Token: 0x06029A42 RID: 170562 RVA: 0x00BC53B0 File Offset: 0x00BC35B0
		public void AddScreenEffectPlotRoot()
		{
			AUIContainerActor screenEffectPlotRoot = null;
			BP_ScreenEffectSystem_C instance = ScreenEffectSystem.GetInstance();
			if (!instance.IsValid())
			{
				return;
			}
			instance.GetScreenEffectPlotRoot(ref screenEffectPlotRoot);
			this.ScreenEffectPlotRoot = screenEffectPlotRoot;
			UUIItem item = base.GetItem(13);
			AUIContainerActor screenEffectPlotRoot2 = this.ScreenEffectPlotRoot;
			if (screenEffectPlotRoot2 != null && screenEffectPlotRoot2.IsValid())
			{
				this.ScreenEffectPlotRoot.K2_AttachRootComponentTo(item, default(FName), EAttachLocation.KeepRelativeOffset, true);
			}
		}

		// Token: 0x06029A43 RID: 170563 RVA: 0x00BC5411 File Offset: 0x00BC3611
		public void RemoveScreenEffectPlotRoot()
		{
			AUIContainerActor screenEffectPlotRoot = this.ScreenEffectPlotRoot;
			if (screenEffectPlotRoot != null && screenEffectPlotRoot.IsValid())
			{
				this.ScreenEffectPlotRoot.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
			}
			this.ScreenEffectPlotRoot = null;
		}

		// Token: 0x06029A44 RID: 170564 RVA: 0x00BC543C File Offset: 0x00BC363C
		private void AddTickPhoto()
		{
			this.TickPhotoFade = true;
		}

		// Token: 0x06029A45 RID: 170565 RVA: 0x00BC5445 File Offset: 0x00BC3645
		private void RemoveTickPhoto()
		{
			this.TickPhotoFade = false;
		}

		// Token: 0x06029A46 RID: 170566 RVA: 0x00BC5450 File Offset: 0x00BC3650
		private float GetCurrentPercentPhoto()
		{
			float rangePct = MathUtils.Instance.GetRangePct(0f, 1000f, this.FadeTimePhoto);
			if (this.IsAlreadyHavePhoto && this.IsFadeInPhoto)
			{
				this.BgWidgetFront.SetAlpha(rangePct);
			}
			else
			{
				if (!this.IsFadeInPhoto && this.BgWidget.GetAlpha() <= 0f)
				{
					return 0f;
				}
				this.BgWidget.SetAlpha(rangePct);
			}
			return rangePct;
		}

		// Token: 0x06029A47 RID: 170567 RVA: 0x00BC54C4 File Offset: 0x00BC36C4
		private float GetCurrentPercentPhotoMiddle()
		{
			float rangePct = MathUtils.Instance.GetRangePct(0f, 1000f, this.FadeTimePhoto);
			if (!this.IsFadeInPhoto && this.WidgetMiddle.GetAlpha() <= 0f)
			{
				return 0f;
			}
			this.WidgetMiddle.SetAlpha(rangePct);
			return rangePct;
		}

		// Token: 0x06029A48 RID: 170568 RVA: 0x00BC551C File Offset: 0x00BC371C
		private void OnFadeTickPhoto(float deltaTime)
		{
			if (this.FadeTimePhoto < 0f)
			{
				this.FadeTimePhoto = 0f;
			}
			if (this.FadeTimePhoto > 1000f)
			{
				this.FadeTimePhoto = 1000f;
			}
			if (this.IsFadeInPhoto)
			{
				this.FadeTimePhoto += deltaTime;
				if (this.IsFullPhoto.GetValueOrDefault())
				{
					if (this.GetCurrentPercentPhoto() > 1f)
					{
						this.RemoveTickPhoto();
						this.OnCloseEventPhoto();
						return;
					}
				}
				else if (this.GetCurrentPercentPhotoMiddle() > 1f)
				{
					this.RemoveTickPhoto();
					this.OnCloseEventPhoto();
					return;
				}
			}
			else
			{
				this.FadeTimePhoto -= deltaTime;
				if (this.IsFullPhoto.GetValueOrDefault())
				{
					if (this.GetCurrentPercentPhoto() <= 0f)
					{
						this.RemoveTickPhoto();
						this.OnCloseEventPhoto();
						return;
					}
				}
				else if (this.GetCurrentPercentPhotoMiddle() <= 0f)
				{
					this.RemoveTickPhoto();
					this.OnCloseEventPhoto();
				}
			}
		}

		// Token: 0x06029A49 RID: 170569 RVA: 0x00BC5600 File Offset: 0x00BC3800
		private void OnCloseEventPhoto()
		{
			if (this.IsFullPhoto.GetValueOrDefault())
			{
				if (this.IsFadeInPhoto && this.PlotFadeHidePromise != null)
				{
					global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "Plot图片FadeIn结束", default(ReadOnlySpan<ValueTuple<string, object>>));
					if (this.IsAlreadyHavePhoto)
					{
						this.BgWidget.SetTexture(this.BgWidgetFront.GetTexture());
						this.BgWidgetFront.SetAlpha(0f);
						CustomPromise<bool> plotFadeHidePromise = this.PlotFadeHidePromise;
						this.PlotFadeHidePromise = null;
						plotFadeHidePromise.SetResult(true);
					}
					else
					{
						CustomPromise<bool> plotFadeHidePromise2 = this.PlotFadeHidePromise;
						this.PlotFadeHidePromise = null;
						plotFadeHidePromise2.SetResult(true);
					}
					this.IsAlreadyHavePhoto = true;
				}
				else if (!this.IsFadeInPhoto && this.PlotFadeShowPromise != null)
				{
					global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "Plot图片FadeOut结束", default(ReadOnlySpan<ValueTuple<string, object>>));
					CustomPromise<bool> plotFadeShowPromise = this.PlotFadeShowPromise;
					this.PlotFadeShowPromise = null;
					plotFadeShowPromise.SetResult(true);
					base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI", this.BgWidget, null, null);
					this.IsAlreadyHavePhoto = false;
					PlotController.Instance.ResetViewControl();
				}
			}
			else if (this.IsFadeInPhoto && this.PlotFadeHidePromise != null)
			{
				global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "Plot Middle图片FadeIn结束", default(ReadOnlySpan<ValueTuple<string, object>>));
				if (this.IsAlreadyHavePhoto)
				{
					CustomPromise<bool> plotFadeHidePromise3 = this.PlotFadeHidePromise;
					this.PlotFadeHidePromise = null;
					plotFadeHidePromise3.SetResult(true);
				}
				else
				{
					CustomPromise<bool> plotFadeHidePromise4 = this.PlotFadeHidePromise;
					this.PlotFadeHidePromise = null;
					plotFadeHidePromise4.SetResult(true);
				}
				this.IsAlreadyHavePhoto = true;
			}
			else if (!this.IsFadeInPhoto && this.PlotFadeShowPromise != null)
			{
				global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "Plot Middle图片FadeOut结束", default(ReadOnlySpan<ValueTuple<string, object>>));
				UUISprite bgWidgetMiddle = this.BgWidgetMiddle;
				if (bgWidgetMiddle != null)
				{
					bgWidgetMiddle.SetUIActive(false);
				}
				CustomPromise<bool> plotFadeShowPromise2 = this.PlotFadeShowPromise;
				this.PlotFadeShowPromise = null;
				plotFadeShowPromise2.SetResult(true);
				base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI", this.WidgetMiddle, null, null);
				this.IsAlreadyHavePhoto = false;
				PlotController.Instance.ResetViewControl();
			}
			if (this.PlotViewPhotoCallback != null)
			{
				this.PlotViewPhotoCallback(null);
			}
		}

		// Token: 0x06029A4A RID: 170570 RVA: 0x00BC582C File Offset: 0x00BC3A2C
		public UniTask FadeInBgPhoto(string path = null, Action callback = null)
		{
			PlotView.<FadeInBgPhoto>d__155 <FadeInBgPhoto>d__;
			<FadeInBgPhoto>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FadeInBgPhoto>d__.<>4__this = this;
			<FadeInBgPhoto>d__.path = path;
			<FadeInBgPhoto>d__.callback = callback;
			<FadeInBgPhoto>d__.<>1__state = -1;
			<FadeInBgPhoto>d__.<>t__builder.Start<PlotView.<FadeInBgPhoto>d__155>(ref <FadeInBgPhoto>d__);
			return <FadeInBgPhoto>d__.<>t__builder.Task;
		}

		// Token: 0x06029A4B RID: 170571 RVA: 0x00BC5880 File Offset: 0x00BC3A80
		public UniTask FadeOutBgPhoto(Action callback = null)
		{
			PlotView.<FadeOutBgPhoto>d__156 <FadeOutBgPhoto>d__;
			<FadeOutBgPhoto>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FadeOutBgPhoto>d__.<>4__this = this;
			<FadeOutBgPhoto>d__.callback = callback;
			<FadeOutBgPhoto>d__.<>1__state = -1;
			<FadeOutBgPhoto>d__.<>t__builder.Start<PlotView.<FadeOutBgPhoto>d__156>(ref <FadeOutBgPhoto>d__);
			return <FadeOutBgPhoto>d__.<>t__builder.Task;
		}

		// Token: 0x06029A4C RID: 170572 RVA: 0x00BC58CC File Offset: 0x00BC3ACC
		public UniTask FadeInBgPhotoMiddle(string path = null, Action callback = null)
		{
			PlotView.<FadeInBgPhotoMiddle>d__157 <FadeInBgPhotoMiddle>d__;
			<FadeInBgPhotoMiddle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FadeInBgPhotoMiddle>d__.<>4__this = this;
			<FadeInBgPhotoMiddle>d__.path = path;
			<FadeInBgPhotoMiddle>d__.callback = callback;
			<FadeInBgPhotoMiddle>d__.<>1__state = -1;
			<FadeInBgPhotoMiddle>d__.<>t__builder.Start<PlotView.<FadeInBgPhotoMiddle>d__157>(ref <FadeInBgPhotoMiddle>d__);
			return <FadeInBgPhotoMiddle>d__.<>t__builder.Task;
		}

		// Token: 0x06029A4D RID: 170573 RVA: 0x00BC5920 File Offset: 0x00BC3B20
		public UniTask FadeOutBgPhotoMiddle(Action callback = null)
		{
			PlotView.<FadeOutBgPhotoMiddle>d__158 <FadeOutBgPhotoMiddle>d__;
			<FadeOutBgPhotoMiddle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FadeOutBgPhotoMiddle>d__.<>4__this = this;
			<FadeOutBgPhotoMiddle>d__.callback = callback;
			<FadeOutBgPhotoMiddle>d__.<>1__state = -1;
			<FadeOutBgPhotoMiddle>d__.<>t__builder.Start<PlotView.<FadeOutBgPhotoMiddle>d__158>(ref <FadeOutBgPhotoMiddle>d__);
			return <FadeOutBgPhotoMiddle>d__.<>t__builder.Task;
		}

		// Token: 0x06029A4E RID: 170574 RVA: 0x00BC596B File Offset: 0x00BC3B6B
		private void AddTickBlackScreen()
		{
			this.TickBlackScreenFade = true;
		}

		// Token: 0x06029A4F RID: 170575 RVA: 0x00BC5974 File Offset: 0x00BC3B74
		private void RemoveTickBlackScreen()
		{
			this.TickBlackScreenFade = false;
		}

		// Token: 0x06029A50 RID: 170576 RVA: 0x00BC5980 File Offset: 0x00BC3B80
		private float GetCurrentPercentBlackScreen()
		{
			float rangePct = MathUtils.Instance.GetRangePct(0f, 1000f, this.FadeTimeBlackScreen);
			this.BlackBgWidget.SetAlpha(rangePct);
			return rangePct;
		}

		// Token: 0x06029A51 RID: 170577 RVA: 0x00BC59B8 File Offset: 0x00BC3BB8
		private void OnFadeTickBlackScreen(float deltaTime)
		{
			if (this.FadeTimeBlackScreen < 0f)
			{
				this.FadeTimeBlackScreen = 0f;
			}
			if (this.FadeTimeBlackScreen > 1000f)
			{
				this.FadeTimeBlackScreen = 1000f;
			}
			if (this.IsFadeInBlackScreen)
			{
				this.FadeTimeBlackScreen += deltaTime;
				if (this.GetCurrentPercentBlackScreen() > 1f)
				{
					this.RemoveTickBlackScreen();
					this.OnCloseEventBlackScreen();
					return;
				}
			}
			else
			{
				this.FadeTimeBlackScreen -= deltaTime;
				if (this.GetCurrentPercentBlackScreen() < 0f)
				{
					this.RemoveTickBlackScreen();
					this.OnCloseEventBlackScreen();
				}
			}
		}

		// Token: 0x06029A52 RID: 170578 RVA: 0x00BC5A4C File Offset: 0x00BC3C4C
		private void OnCloseEventBlackScreen()
		{
			if (this.IsFadeInBlackScreen && this.PlotFadeHidePromise != null)
			{
				global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "Plot黑幕FadeIn结束", default(ReadOnlySpan<ValueTuple<string, object>>));
				CustomPromise<bool> plotFadeHidePromise = this.PlotFadeHidePromise;
				this.PlotFadeHidePromise = null;
				plotFadeHidePromise.SetResult(true);
			}
			else if (!this.IsFadeInBlackScreen && this.PlotFadeShowPromise != null)
			{
				global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "Plot黑幕FadeOut结束", default(ReadOnlySpan<ValueTuple<string, object>>));
				CustomPromise<bool> plotFadeShowPromise = this.PlotFadeShowPromise;
				this.PlotFadeShowPromise = null;
				plotFadeShowPromise.SetResult(true);
			}
			if (this.PlotViewBlackScreenCallback != null)
			{
				this.PlotViewBlackScreenCallback(null);
			}
		}

		// Token: 0x06029A53 RID: 170579 RVA: 0x00BC5AF4 File Offset: 0x00BC3CF4
		public UniTask FadeInBgBlackScreen(Action callback = null)
		{
			PlotView.<FadeInBgBlackScreen>d__164 <FadeInBgBlackScreen>d__;
			<FadeInBgBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FadeInBgBlackScreen>d__.<>4__this = this;
			<FadeInBgBlackScreen>d__.callback = callback;
			<FadeInBgBlackScreen>d__.<>1__state = -1;
			<FadeInBgBlackScreen>d__.<>t__builder.Start<PlotView.<FadeInBgBlackScreen>d__164>(ref <FadeInBgBlackScreen>d__);
			return <FadeInBgBlackScreen>d__.<>t__builder.Task;
		}

		// Token: 0x06029A54 RID: 170580 RVA: 0x00BC5B40 File Offset: 0x00BC3D40
		public UniTask FadeOutBgBlackScreen(Action callback = null)
		{
			PlotView.<FadeOutBgBlackScreen>d__165 <FadeOutBgBlackScreen>d__;
			<FadeOutBgBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FadeOutBgBlackScreen>d__.<>4__this = this;
			<FadeOutBgBlackScreen>d__.callback = callback;
			<FadeOutBgBlackScreen>d__.<>1__state = -1;
			<FadeOutBgBlackScreen>d__.<>t__builder.Start<PlotView.<FadeOutBgBlackScreen>d__165>(ref <FadeOutBgBlackScreen>d__);
			return <FadeOutBgBlackScreen>d__.<>t__builder.Task;
		}

		// Token: 0x06029A55 RID: 170581 RVA: 0x00BC5B8C File Offset: 0x00BC3D8C
		public UniTask OpenChildView(int id, bool isLoop)
		{
			PlotView.<OpenChildView>d__168 <OpenChildView>d__;
			<OpenChildView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenChildView>d__.<>4__this = this;
			<OpenChildView>d__.id = id;
			<OpenChildView>d__.isLoop = isLoop;
			<OpenChildView>d__.<>1__state = -1;
			<OpenChildView>d__.<>t__builder.Start<PlotView.<OpenChildView>d__168>(ref <OpenChildView>d__);
			return <OpenChildView>d__.<>t__builder.Task;
		}

		// Token: 0x06029A56 RID: 170582 RVA: 0x00BC5BE0 File Offset: 0x00BC3DE0
		public UniTask CloseChildView()
		{
			PlotView.<CloseChildView>d__169 <CloseChildView>d__;
			<CloseChildView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseChildView>d__.<>4__this = this;
			<CloseChildView>d__.<>1__state = -1;
			<CloseChildView>d__.<>t__builder.Start<PlotView.<CloseChildView>d__169>(ref <CloseChildView>d__);
			return <CloseChildView>d__.<>t__builder.Task;
		}

		// Token: 0x04016B8D RID: 93069
		private const int FADE_TIME = 1000;

		// Token: 0x04016B8E RID: 93070
		private const float ROTATE_RATE_X = 0.06f;

		// Token: 0x04016B8F RID: 93071
		private const float ROTATE_RATE_Y = 0.03f;

		// Token: 0x04016B90 RID: 93072
		private const float ZOOM_RATE = 1.2f;

		// Token: 0x04016B91 RID: 93073
		[Nullable(1)]
		private const string DEFAULT_PATH = "/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI";

		// Token: 0x04016B92 RID: 93074
		[Nullable(1)]
		private const string CLICK_AUDIO_EVENT = "play_ui_ia_spl_plot_next";

		// Token: 0x04016B93 RID: 93075
		private const float PLOT_AUTO_HIDE_MOUSE_DELAY = 3000f;

		// Token: 0x04016B94 RID: 93076
		[Nullable(1)]
		private const string AUTO_SELECT_TEXT_HALF_AUTO = "HotKeyText_HalfAutoPlot_Name";

		// Token: 0x04016B95 RID: 93077
		[Nullable(1)]
		private const string AUTO_SELECT_TEXT_AUTO = "HotKeyText_AutoPlot_Name";

		// Token: 0x04016B96 RID: 93078
		[Nullable(1)]
		private const string AUTO_SELECT_TEXT_CANCEL_AUTO = "HotKeyText_CancelAutoPlot_Name";

		// Token: 0x04016B97 RID: 93079
		[Nullable(1)]
		public List<PlotOption> CurOption = new List<PlotOption>();

		// Token: 0x04016B98 RID: 93080
		private TimerHandle DelayId;

		// Token: 0x04016B99 RID: 93081
		private TimerHandle WaitingSkipTimerId;

		// Token: 0x04016B9A RID: 93082
		public PawnInteractController InteractController;

		// Token: 0x04016B9B RID: 93083
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkItem> PreTalkItems;

		// Token: 0x04016B9C RID: 93084
		private int PreTalkIndex;

		// Token: 0x04016B9D RID: 93085
		private bool CanJumpToNextTalk;

		// Token: 0x04016B9E RID: 93086
		private UUIItem SkipSubtitleTipItem;

		// Token: 0x04016B9F RID: 93087
		private UUIItem SkipSubtitleTipItemNew;

		// Token: 0x04016BA0 RID: 93088
		private float PlotTextInitialAnchorY;

		// Token: 0x04016BA1 RID: 93089
		private AUIContainerActor ScreenEffectPlotRoot;

		// Token: 0x04016BA2 RID: 93090
		private PlotSkipComponent SkipComp;

		// Token: 0x04016BA3 RID: 93091
		private PlotReviewComponent ReviewComp;

		// Token: 0x04016BA4 RID: 93092
		private PlotTextCommonLogic CommonLogic;

		// Token: 0x04016BA5 RID: 93093
		private bool ImmersiveInputWakeState;

		// Token: 0x04016BA6 RID: 93094
		private bool? MainButtonsTweenShown;

		// Token: 0x04016BA7 RID: 93095
		private bool? SkipTweenShown;

		// Token: 0x04016BA8 RID: 93096
		private bool? ReviewTweenShown;

		// Token: 0x04016BA9 RID: 93097
		private bool PendingImmersiveSleep;

		// Token: 0x04016BAA RID: 93098
		private TimerHandle PendingImmersiveSleepTimerId;

		// Token: 0x04016BAB RID: 93099
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap;

		// Token: 0x04016BAC RID: 93100
		private bool TickBlackScreenFade;

		// Token: 0x04016BAD RID: 93101
		private bool TickPhotoFade;

		// Token: 0x04016BAE RID: 93102
		private UUITexture BgWidget;

		// Token: 0x04016BAF RID: 93103
		private UUITexture BgWidgetFront;

		// Token: 0x04016BB0 RID: 93104
		private UUITexture WidgetMiddle;

		// Token: 0x04016BB1 RID: 93105
		private UUISprite BgWidgetMiddle;

		// Token: 0x04016BB2 RID: 93106
		private UUISprite BlackBgWidget;

		// Token: 0x04016BB3 RID: 93107
		private CustomPromise<bool> PlotFadeShowPromise;

		// Token: 0x04016BB4 RID: 93108
		private CustomPromise<bool> PlotFadeHidePromise;

		// Token: 0x04016BB5 RID: 93109
		private Action<ITalkItem> PlotViewPhotoCallback;

		// Token: 0x04016BB6 RID: 93110
		private Action<ITalkItem> PlotViewBlackScreenCallback;

		// Token: 0x04016BB7 RID: 93111
		private float FadeTimePhoto;

		// Token: 0x04016BB8 RID: 93112
		private float FadeTimeBlackScreen;

		// Token: 0x04016BB9 RID: 93113
		private bool IsFadeInPhoto;

		// Token: 0x04016BBA RID: 93114
		private bool IsFadeInBlackScreen;

		// Token: 0x04016BBB RID: 93115
		private bool IsVisible = true;

		// Token: 0x04016BBC RID: 93116
		private bool IsAlreadyHavePhoto;

		// Token: 0x04016BBD RID: 93117
		private bool? IsFullPhoto;

		// Token: 0x04016BBE RID: 93118
		private bool IsShowBlackBg;

		// Token: 0x04016BBF RID: 93119
		private FVector? CurrentDragPosition;

		// Token: 0x04016BC0 RID: 93120
		private TimerHandle StartDelayTimer;

		// Token: 0x04016BC1 RID: 93121
		private bool IsSubtitleFinishDelay;

		// Token: 0x04016BC2 RID: 93122
		private bool IsAudioFinishDelay;

		// Token: 0x04016BC3 RID: 93123
		private TimerHandle AudioEndDelayId;

		// Token: 0x04016BC4 RID: 93124
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly Action<ULGUIPointerEventData> OnPointerScrollCallBack = delegate(ULGUIPointerEventData eventData)
		{
			if (!PlotModel.Instance.CanControlView)
			{
				return;
			}
			float value = eventData.scrollAxisValue * 1.2f;
			InputController.Instance.InputAxis(EInputAxis.Zoom, value, true);
		};

		// Token: 0x04016BC5 RID: 93125
		private PlotChildView ChildView;

		// Token: 0x04016BC6 RID: 93126
		[Nullable(1)]
		private string ChildViewName = "";

		// Token: 0x02009C0C RID: 39948
		[NullableContext(0)]
		private enum EPlotChildCom
		{
			// Token: 0x04030916 RID: 198934
			BtnAuto,
			// Token: 0x04030917 RID: 198935
			BtnNextPage,
			// Token: 0x04030918 RID: 198936
			BtnSkip,
			// Token: 0x04030919 RID: 198937
			PlotText,
			// Token: 0x0403091A RID: 198938
			NPCName,
			// Token: 0x0403091B RID: 198939
			TxtList,
			// Token: 0x0403091C RID: 198940
			OptionItem,
			// Token: 0x0403091D RID: 198941
			OptionLayout,
			// Token: 0x0403091E RID: 198942
			TextList,
			// Token: 0x0403091F RID: 198943
			PlotBg,
			// Token: 0x04030920 RID: 198944
			PlotTextUHD,
			// Token: 0x04030921 RID: 198945
			PanelLine,
			// Token: 0x04030922 RID: 198946
			TxtFloat,
			// Token: 0x04030923 RID: 198947
			ScreenEffect,
			// Token: 0x04030924 RID: 198948
			AutoPlayManualItem,
			// Token: 0x04030925 RID: 198949
			AutoPlaySemiAutoItem,
			// Token: 0x04030926 RID: 198950
			AutoPlayAutoItem,
			// Token: 0x04030927 RID: 198951
			NPCTitle,
			// Token: 0x04030928 RID: 198952
			BtnHide,
			// Token: 0x04030929 RID: 198953
			NextIcon,
			// Token: 0x0403092A RID: 198954
			WaitingPoint,
			// Token: 0x0403092B RID: 198955
			BlackScreenBg,
			// Token: 0x0403092C RID: 198956
			PhotoScreenBg,
			// Token: 0x0403092D RID: 198957
			PhotoScreenBgFront,
			// Token: 0x0403092E RID: 198958
			DoingText,
			// Token: 0x0403092F RID: 198959
			PhotoScreenMiddle,
			// Token: 0x04030930 RID: 198960
			PhotoScreenBgMiddle,
			// Token: 0x04030931 RID: 198961
			TextScrollView,
			// Token: 0x04030932 RID: 198962
			OptionAdjustItem,
			// Token: 0x04030933 RID: 198963
			PnlBg,
			// Token: 0x04030934 RID: 198964
			PnlInfo,
			// Token: 0x04030935 RID: 198965
			SonUi,
			// Token: 0x04030936 RID: 198966
			BlockOption,
			// Token: 0x04030937 RID: 198967
			BtnReview,
			// Token: 0x04030938 RID: 198968
			OptionLimitBar,
			// Token: 0x04030939 RID: 198969
			VideoLayout,
			// Token: 0x0403093A RID: 198970
			AniSkipIn,
			// Token: 0x0403093B RID: 198971
			AniSkipOut,
			// Token: 0x0403093C RID: 198972
			AniReviewIn,
			// Token: 0x0403093D RID: 198973
			AniReviewOut,
			// Token: 0x0403093E RID: 198974
			AniAutoHideIn,
			// Token: 0x0403093F RID: 198975
			AniAutoHideOut,
			// Token: 0x04030940 RID: 198976
			TextDebugInfo,
			// Token: 0x04030941 RID: 198977
			FullscreenAdaptAnchor,
			// Token: 0x04030942 RID: 198978
			ImportantList,
			// Token: 0x04030943 RID: 198979
			PnlLayout02,
			// Token: 0x04030944 RID: 198980
			TextScrollViewCopy,
			// Token: 0x04030945 RID: 198981
			ImportantOptionTipsIcon,
			// Token: 0x04030946 RID: 198982
			ImportantOptionTipsText,
			// Token: 0x04030947 RID: 198983
			AutoSelectTimeBar,
			// Token: 0x04030948 RID: 198984
			AutoSelectText,
			// Token: 0x04030949 RID: 198985
			AniAutoTextIn,
			// Token: 0x0403094A RID: 198986
			AniAutoTextOut,
			// Token: 0x0403094B RID: 198987
			NextIconNew
		}
	}
}
