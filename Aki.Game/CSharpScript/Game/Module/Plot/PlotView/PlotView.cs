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
	// Token: 0x02005065 RID: 20581
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotView : UiTickViewBase, ISimulatePlot
	{
		// Token: 0x06034AF8 RID: 215800 RVA: 0x00C75428 File Offset: 0x00C73628
		[NullableContext(1)]
		public PlotView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17008032 RID: 32818
		// (get) Token: 0x06034AF9 RID: 215801 RVA: 0x00C7547E File Offset: 0x00C7367E
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

		// Token: 0x17008033 RID: 32819
		// (get) Token: 0x06034AFA RID: 215802 RVA: 0x00C75491 File Offset: 0x00C73691
		public ITalkItem CurrentSubtitle
		{
			get
			{
				return this.CommonLogic.CurrentContent;
			}
		}

		// Token: 0x17008034 RID: 32820
		// (get) Token: 0x06034AFB RID: 215803 RVA: 0x00C7549E File Offset: 0x00C7369E
		public bool HasOptions
		{
			get
			{
				return this.CurrentSubtitle != null && this.CurrentSubtitle.Options != null && this.CurrentSubtitle.Options.Count != 0;
			}
		}

		// Token: 0x06034AFC RID: 215804 RVA: 0x00C754CC File Offset: 0x00C736CC
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

		// Token: 0x06034AFD RID: 215805 RVA: 0x00C75C9C File Offset: 0x00C73E9C
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

		// Token: 0x06034AFE RID: 215806 RVA: 0x00C75FC4 File Offset: 0x00C741C4
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

		// Token: 0x06034AFF RID: 215807 RVA: 0x00C76024 File Offset: 0x00C74224
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

		// Token: 0x06034B00 RID: 215808 RVA: 0x00C76076 File Offset: 0x00C74276
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

		// Token: 0x06034B01 RID: 215809 RVA: 0x00C76094 File Offset: 0x00C74294
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

		// Token: 0x06034B02 RID: 215810 RVA: 0x00C760F8 File Offset: 0x00C742F8
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			PlotView.<OnPlayingStartSequenceAsync>d__69 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PlotView.<OnPlayingStartSequenceAsync>d__69>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034B03 RID: 215811 RVA: 0x00C7613C File Offset: 0x00C7433C
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			PlotView.<OnPlayingCloseSequenceAsync>d__70 <OnPlayingCloseSequenceAsync>d__;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
			<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
			<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PlotView.<OnPlayingCloseSequenceAsync>d__70>(ref <OnPlayingCloseSequenceAsync>d__);
			return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034B04 RID: 215812 RVA: 0x00C7617F File Offset: 0x00C7437F
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

		// Token: 0x06034B05 RID: 215813 RVA: 0x00C761B7 File Offset: 0x00C743B7
		private void InitButtonsVisibilityByImmersiveMode()
		{
			if (InputManager.Instance.IsImmersiveMouseModeEnabled())
			{
				this.ImmersiveInputWakeState = InputManager.Instance.IsShowMouseCursor();
				this.UpdatePlotButtonsVisibility(this.ImmersiveInputWakeState);
			}
		}

		// Token: 0x06034B06 RID: 215814 RVA: 0x00C761E4 File Offset: 0x00C743E4
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

		// Token: 0x06034B07 RID: 215815 RVA: 0x00C7628C File Offset: 0x00C7448C
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

		// Token: 0x06034B08 RID: 215816 RVA: 0x00C762F8 File Offset: 0x00C744F8
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

		// Token: 0x06034B09 RID: 215817 RVA: 0x00C76688 File Offset: 0x00C74888
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

		// Token: 0x06034B0A RID: 215818 RVA: 0x00C769CC File Offset: 0x00C74BCC
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

		// Token: 0x06034B0B RID: 215819 RVA: 0x00C769F8 File Offset: 0x00C74BF8
		private void OnTermExplanationViewOpen(ETermExplanationViewType _)
		{
			this.MuteAutoPlay(true);
		}

		// Token: 0x06034B0C RID: 215820 RVA: 0x00C76A01 File Offset: 0x00C74C01
		private void OnTermExplanationViewClose()
		{
			this.MuteAutoPlay(false);
		}

		// Token: 0x06034B0D RID: 215821 RVA: 0x00C76A0C File Offset: 0x00C74C0C
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

		// Token: 0x06034B0E RID: 215822 RVA: 0x00C76A68 File Offset: 0x00C74C68
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

		// Token: 0x06034B0F RID: 215823 RVA: 0x00C76ACC File Offset: 0x00C74CCC
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

		// Token: 0x06034B10 RID: 215824 RVA: 0x00C76B4F File Offset: 0x00C74D4F
		private void ClearPendingImmersiveSleep()
		{
			this.PendingImmersiveSleep = false;
			if (this.PendingImmersiveSleepTimerId != null && TimerSystem.Instance.Has(this.PendingImmersiveSleepTimerId))
			{
				TimerSystem.Instance.Remove(this.PendingImmersiveSleepTimerId);
			}
			this.PendingImmersiveSleepTimerId = null;
		}

		// Token: 0x06034B11 RID: 215825 RVA: 0x00C76B8C File Offset: 0x00C74D8C
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

		// Token: 0x06034B12 RID: 215826 RVA: 0x00C76C00 File Offset: 0x00C74E00
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

		// Token: 0x06034B13 RID: 215827 RVA: 0x00C76C5C File Offset: 0x00C74E5C
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

		// Token: 0x06034B14 RID: 215828 RVA: 0x00C76CB8 File Offset: 0x00C74EB8
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

		// Token: 0x06034B15 RID: 215829 RVA: 0x00C76DDC File Offset: 0x00C74FDC
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

		// Token: 0x06034B16 RID: 215830 RVA: 0x00C76EE6 File Offset: 0x00C750E6
		private void OnEnableSkipPlotRestoreTween(bool _)
		{
			this.RestorePlotButtonsVisibility();
		}

		// Token: 0x06034B17 RID: 215831 RVA: 0x00C76EF0 File Offset: 0x00C750F0
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

		// Token: 0x06034B18 RID: 215832 RVA: 0x00C76FFC File Offset: 0x00C751FC
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

		// Token: 0x06034B19 RID: 215833 RVA: 0x00C77014 File Offset: 0x00C75214
		private void OnNavigationTriggerPlotForward(float value)
		{
			InputController.Instance.InputAxis(EInputAxis.LookUp, value, true);
		}

		// Token: 0x06034B1A RID: 215834 RVA: 0x00C77027 File Offset: 0x00C75227
		private void OnNavigationTriggerPlotRight(float value)
		{
			InputController.Instance.InputAxis(EInputAxis.Turn, value, true);
		}

		// Token: 0x06034B1B RID: 215835 RVA: 0x00C7703C File Offset: 0x00C7523C
		private void OnNavigationTriggerPlotZoom(float value)
		{
			if (value == 0f)
			{
				return;
			}
			float num = value * 1.2f;
			InputController.Instance.InputAxis(EInputAxis.Zoom, -num, true);
		}

		// Token: 0x06034B1C RID: 215836 RVA: 0x00C7706C File Offset: 0x00C7526C
		private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!PlotModel.Instance.CanControlView)
			{
				return;
			}
			this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		}

		// Token: 0x06034B1D RID: 215837 RVA: 0x00C7708C File Offset: 0x00C7528C
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

		// Token: 0x06034B1E RID: 215838 RVA: 0x00C7714D File Offset: 0x00C7534D
		private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!PlotModel.Instance.CanControlView)
			{
				return;
			}
			this.CurrentDragPosition = null;
		}

		// Token: 0x06034B1F RID: 215839 RVA: 0x00C77168 File Offset: 0x00C75368
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

		// Token: 0x06034B20 RID: 215840 RVA: 0x00C77194 File Offset: 0x00C75394
		public void SimulateClickSubtitle()
		{
			if (Info.Instance.IsBuildShipping)
			{
				return;
			}
			this.OnBtnSubtitleSkipClick(null);
		}

		// Token: 0x06034B21 RID: 215841 RVA: 0x00C771AC File Offset: 0x00C753AC
		public void SimulateClickOption()
		{
			if (Info.Instance.IsBuildShipping)
			{
				return;
			}
			for (int i = this.Options.Length - 1; i >= 0; i--)
			{
				PlotOptionItem plotOptionItem = this.Options[i];
				if (!plotOptionItem.CheckToggleGray())
				{
					plotOptionItem.OptionClick(new bool?(true));
				}
			}
		}

		// Token: 0x06034B22 RID: 215842 RVA: 0x00C771F8 File Offset: 0x00C753F8
		private void OnSkip()
		{
			this.MuteAutoPlay(false);
			this.ShowUiExceptPhoto();
			FlowController.Instance.BackgroundFlow("UI点击跳过(PlotView)", true, false, true);
		}

		// Token: 0x06034B23 RID: 215843 RVA: 0x00C7721C File Offset: 0x00C7541C
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

		// Token: 0x06034B24 RID: 215844 RVA: 0x00C772E0 File Offset: 0x00C754E0
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

		// Token: 0x06034B25 RID: 215845 RVA: 0x00C7745A File Offset: 0x00C7565A
		private void ShowOptions()
		{
			this.UpdatePnlLayout02Offset();
			this.CommonLogic.ShowOptions();
		}

		// Token: 0x06034B26 RID: 215846 RVA: 0x00C7746D File Offset: 0x00C7566D
		private void ClearOptions()
		{
			this.CommonLogic.ClearOptions();
		}

		// Token: 0x06034B27 RID: 215847 RVA: 0x00C7747A File Offset: 0x00C7567A
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

		// Token: 0x06034B28 RID: 215848 RVA: 0x00C774A3 File Offset: 0x00C756A3
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

		// Token: 0x06034B29 RID: 215849 RVA: 0x00C774CC File Offset: 0x00C756CC
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

		// Token: 0x06034B2A RID: 215850 RVA: 0x00C77540 File Offset: 0x00C75740
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

		// Token: 0x06034B2B RID: 215851 RVA: 0x00C775A6 File Offset: 0x00C757A6
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

		// Token: 0x06034B2C RID: 215852 RVA: 0x00C775D3 File Offset: 0x00C757D3
		[NullableContext(1)]
		private void HandlePortraitVisible(SetHeadIconVisible headIconInfo, Action callback)
		{
			this.CommonLogic.HandlePortraitVisible(this.RootItem, headIconInfo, callback);
		}

		// Token: 0x06034B2D RID: 215853 RVA: 0x00C775E8 File Offset: 0x00C757E8
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

		// Token: 0x06034B2E RID: 215854 RVA: 0x00C7765C File Offset: 0x00C7585C
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

		// Token: 0x06034B2F RID: 215855 RVA: 0x00C778AD File Offset: 0x00C75AAD
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

		// Token: 0x06034B30 RID: 215856 RVA: 0x00C778E8 File Offset: 0x00C75AE8
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

		// Token: 0x06034B31 RID: 215857 RVA: 0x00C779D0 File Offset: 0x00C75BD0
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

		// Token: 0x06034B32 RID: 215858 RVA: 0x00C77A1E File Offset: 0x00C75C1E
		private void TryAutoPlayNextTalk()
		{
			if (!this.IsSubtitleFinishDelay || !this.IsAudioFinishDelay || PlotModel.Instance.PlotConfig.AutoPlayState == EAutoPlayState.Manual)
			{
				return;
			}
			this.SkipSubtitleTipItemActive(false);
			this.HandleSubtitleActions();
		}

		// Token: 0x06034B33 RID: 215859 RVA: 0x00C77A50 File Offset: 0x00C75C50
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

		// Token: 0x06034B34 RID: 215860 RVA: 0x00C77AAC File Offset: 0x00C75CAC
		private void InitInteractOptions()
		{
			this.CommonLogic.InitInteractOptions();
		}

		// Token: 0x06034B35 RID: 215861 RVA: 0x00C77ABC File Offset: 0x00C75CBC
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

		// Token: 0x06034B36 RID: 215862 RVA: 0x00C77B38 File Offset: 0x00C75D38
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

		// Token: 0x06034B37 RID: 215863 RVA: 0x00C77C98 File Offset: 0x00C75E98
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

		// Token: 0x06034B38 RID: 215864 RVA: 0x00C77D1A File Offset: 0x00C75F1A
		private void OnSkipPop()
		{
			this.MuteAutoPlay(true);
			this.HideUiExceptPhoto();
		}

		// Token: 0x06034B39 RID: 215865 RVA: 0x00C77D29 File Offset: 0x00C75F29
		private void OnSkipCancel()
		{
			this.MuteAutoPlay(false);
			this.ShowUiExceptPhoto();
		}

		// Token: 0x06034B3A RID: 215866 RVA: 0x00C77D38 File Offset: 0x00C75F38
		private void OnBtnHideClick()
		{
			this.HideUiExceptPhoto();
			this.IsVisible = false;
			this.MuteAutoPlay(true);
		}

		// Token: 0x06034B3B RID: 215867 RVA: 0x00C77D4E File Offset: 0x00C75F4E
		private void OnBtnReviewClick()
		{
			if (FlowController.Instance.OpenPlotReviewView())
			{
				this.HideUiExceptPhoto();
				this.MuteAutoPlay(true);
			}
		}

		// Token: 0x06034B3C RID: 215868 RVA: 0x00C77D69 File Offset: 0x00C75F69
		private void OnOpenView(EUiViewName viewName, int _)
		{
			if (viewName == EUiViewName.PlotReviewView)
			{
				AudioSystem.Instance.PostEvent("plot_review_enter");
			}
		}

		// Token: 0x06034B3D RID: 215869 RVA: 0x00C77D88 File Offset: 0x00C75F88
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

		// Token: 0x06034B3E RID: 215870 RVA: 0x00C77DC4 File Offset: 0x00C75FC4
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

		// Token: 0x06034B3F RID: 215871 RVA: 0x00C77E28 File Offset: 0x00C76028
		private void ShowWaitingPoint(bool enable)
		{
			bool uiactive = enable && !PlotModel.Instance.IsNewSubtitleStyleActive();
			base.GetItem(20).SetUIActive(uiactive);
		}

		// Token: 0x06034B40 RID: 215872 RVA: 0x00C77E57 File Offset: 0x00C76057
		[NullableContext(1)]
		private void OnMovieModeAspectOffsetChanged(IMovieModeAspectOffset _)
		{
			this.UpdatePlotTextOffset();
		}

		// Token: 0x06034B41 RID: 215873 RVA: 0x00C77E5F File Offset: 0x00C7605F
		private void OnMovieModeAspectOffsetChanged(bool _, IMovieModeAspectOffset __)
		{
			this.UpdatePlotTextOffset();
		}

		// Token: 0x06034B42 RID: 215874 RVA: 0x00C77E68 File Offset: 0x00C76068
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

		// Token: 0x06034B43 RID: 215875 RVA: 0x00C77EB7 File Offset: 0x00C760B7
		private void RemoveDelayTimer()
		{
			if (TimerSystem.Instance.Has(this.DelayId))
			{
				TimerSystem.Instance.Remove(this.DelayId);
			}
			this.DelayId = null;
		}

		// Token: 0x06034B44 RID: 215876 RVA: 0x00C77EE3 File Offset: 0x00C760E3
		private void RemoveAudioEndDelayTimer()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.AudioEndDelayId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.AudioEndDelayId);
			}
			this.AudioEndDelayId = null;
		}

		// Token: 0x06034B45 RID: 215877 RVA: 0x00C77F0F File Offset: 0x00C7610F
		public void RemoveWaitSkipTimer()
		{
			if (TimerSystem.Instance.Has(this.WaitingSkipTimerId))
			{
				TimerSystem.Instance.Remove(this.WaitingSkipTimerId);
			}
			this.WaitingSkipTimerId = null;
		}

		// Token: 0x06034B46 RID: 215878 RVA: 0x00C77F3B File Offset: 0x00C7613B
		private void HideAll(bool isHidden)
		{
			this.RootItem.SetUIActive(!isHidden);
		}

		// Token: 0x06034B47 RID: 215879 RVA: 0x00C77F4C File Offset: 0x00C7614C
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

		// Token: 0x06034B48 RID: 215880 RVA: 0x00C77F75 File Offset: 0x00C76175
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

		// Token: 0x06034B49 RID: 215881 RVA: 0x00C77F9C File Offset: 0x00C7619C
		private void OnPlotViewBgFadePhoto(bool isFadeIn, bool isFull, string path, Action callback)
		{
			this.DoOnPlotViewBgFadePhoto(isFadeIn, isFull, path, callback);
		}

		// Token: 0x06034B4A RID: 215882 RVA: 0x00C77FAC File Offset: 0x00C761AC
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

		// Token: 0x06034B4B RID: 215883 RVA: 0x00C78010 File Offset: 0x00C76210
		private void OnPlotViewBgFadeBlackScreen(bool isFadeIn, Action callback)
		{
			this.DoOnPlotViewBgFadeBlackScreen(isFadeIn, callback);
		}

		// Token: 0x06034B4C RID: 215884 RVA: 0x00C7801C File Offset: 0x00C7621C
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

		// Token: 0x06034B4D RID: 215885 RVA: 0x00C7806F File Offset: 0x00C7626F
		private void ClearPlotSubtitle()
		{
			this.ClearPlotView();
			this.CommonLogic.ClearPlotContent(false);
		}

		// Token: 0x06034B4E RID: 215886 RVA: 0x00C78084 File Offset: 0x00C76284
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

		// Token: 0x06034B4F RID: 215887 RVA: 0x00C780E0 File Offset: 0x00C762E0
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

		// Token: 0x06034B50 RID: 215888 RVA: 0x00C78141 File Offset: 0x00C76341
		public void RemoveScreenEffectPlotRoot()
		{
			AUIContainerActor screenEffectPlotRoot = this.ScreenEffectPlotRoot;
			if (screenEffectPlotRoot != null && screenEffectPlotRoot.IsValid())
			{
				this.ScreenEffectPlotRoot.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
			}
			this.ScreenEffectPlotRoot = null;
		}

		// Token: 0x06034B51 RID: 215889 RVA: 0x00C7816C File Offset: 0x00C7636C
		private void AddTickPhoto()
		{
			this.TickPhotoFade = true;
		}

		// Token: 0x06034B52 RID: 215890 RVA: 0x00C78175 File Offset: 0x00C76375
		private void RemoveTickPhoto()
		{
			this.TickPhotoFade = false;
		}

		// Token: 0x06034B53 RID: 215891 RVA: 0x00C78180 File Offset: 0x00C76380
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

		// Token: 0x06034B54 RID: 215892 RVA: 0x00C781F4 File Offset: 0x00C763F4
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

		// Token: 0x06034B55 RID: 215893 RVA: 0x00C7824C File Offset: 0x00C7644C
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

		// Token: 0x06034B56 RID: 215894 RVA: 0x00C78330 File Offset: 0x00C76530
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

		// Token: 0x06034B57 RID: 215895 RVA: 0x00C7855C File Offset: 0x00C7675C
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

		// Token: 0x06034B58 RID: 215896 RVA: 0x00C785B0 File Offset: 0x00C767B0
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

		// Token: 0x06034B59 RID: 215897 RVA: 0x00C785FC File Offset: 0x00C767FC
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

		// Token: 0x06034B5A RID: 215898 RVA: 0x00C78650 File Offset: 0x00C76850
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

		// Token: 0x06034B5B RID: 215899 RVA: 0x00C7869B File Offset: 0x00C7689B
		private void AddTickBlackScreen()
		{
			this.TickBlackScreenFade = true;
		}

		// Token: 0x06034B5C RID: 215900 RVA: 0x00C786A4 File Offset: 0x00C768A4
		private void RemoveTickBlackScreen()
		{
			this.TickBlackScreenFade = false;
		}

		// Token: 0x06034B5D RID: 215901 RVA: 0x00C786B0 File Offset: 0x00C768B0
		private float GetCurrentPercentBlackScreen()
		{
			float rangePct = MathUtils.Instance.GetRangePct(0f, 1000f, this.FadeTimeBlackScreen);
			this.BlackBgWidget.SetAlpha(rangePct);
			return rangePct;
		}

		// Token: 0x06034B5E RID: 215902 RVA: 0x00C786E8 File Offset: 0x00C768E8
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

		// Token: 0x06034B5F RID: 215903 RVA: 0x00C7877C File Offset: 0x00C7697C
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

		// Token: 0x06034B60 RID: 215904 RVA: 0x00C78824 File Offset: 0x00C76A24
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

		// Token: 0x06034B61 RID: 215905 RVA: 0x00C78870 File Offset: 0x00C76A70
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

		// Token: 0x06034B62 RID: 215906 RVA: 0x00C788BC File Offset: 0x00C76ABC
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

		// Token: 0x06034B63 RID: 215907 RVA: 0x00C78910 File Offset: 0x00C76B10
		public UniTask CloseChildView()
		{
			PlotView.<CloseChildView>d__169 <CloseChildView>d__;
			<CloseChildView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseChildView>d__.<>4__this = this;
			<CloseChildView>d__.<>1__state = -1;
			<CloseChildView>d__.<>t__builder.Start<PlotView.<CloseChildView>d__169>(ref <CloseChildView>d__);
			return <CloseChildView>d__.<>t__builder.Task;
		}

		// Token: 0x0401C162 RID: 115042
		private const int FADE_TIME = 1000;

		// Token: 0x0401C163 RID: 115043
		private const float ROTATE_RATE_X = 0.06f;

		// Token: 0x0401C164 RID: 115044
		private const float ROTATE_RATE_Y = 0.03f;

		// Token: 0x0401C165 RID: 115045
		private const float ZOOM_RATE = 1.2f;

		// Token: 0x0401C166 RID: 115046
		[Nullable(1)]
		private const string DEFAULT_PATH = "/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI";

		// Token: 0x0401C167 RID: 115047
		[Nullable(1)]
		private const string CLICK_AUDIO_EVENT = "play_ui_ia_spl_plot_next";

		// Token: 0x0401C168 RID: 115048
		private const float PLOT_AUTO_HIDE_MOUSE_DELAY = 3000f;

		// Token: 0x0401C169 RID: 115049
		[Nullable(1)]
		private const string AUTO_SELECT_TEXT_HALF_AUTO = "HotKeyText_HalfAutoPlot_Name";

		// Token: 0x0401C16A RID: 115050
		[Nullable(1)]
		private const string AUTO_SELECT_TEXT_AUTO = "HotKeyText_AutoPlot_Name";

		// Token: 0x0401C16B RID: 115051
		[Nullable(1)]
		private const string AUTO_SELECT_TEXT_CANCEL_AUTO = "HotKeyText_CancelAutoPlot_Name";

		// Token: 0x0401C16C RID: 115052
		[Nullable(1)]
		public List<PlotOption> CurOption = new List<PlotOption>();

		// Token: 0x0401C16D RID: 115053
		private TimerHandle DelayId;

		// Token: 0x0401C16E RID: 115054
		private TimerHandle WaitingSkipTimerId;

		// Token: 0x0401C16F RID: 115055
		public PawnInteractController InteractController;

		// Token: 0x0401C170 RID: 115056
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ITalkItem> PreTalkItems;

		// Token: 0x0401C171 RID: 115057
		private int PreTalkIndex;

		// Token: 0x0401C172 RID: 115058
		private bool CanJumpToNextTalk;

		// Token: 0x0401C173 RID: 115059
		private UUIItem SkipSubtitleTipItem;

		// Token: 0x0401C174 RID: 115060
		private UUIItem SkipSubtitleTipItemNew;

		// Token: 0x0401C175 RID: 115061
		private float PlotTextInitialAnchorY;

		// Token: 0x0401C176 RID: 115062
		private AUIContainerActor ScreenEffectPlotRoot;

		// Token: 0x0401C177 RID: 115063
		private PlotSkipComponent SkipComp;

		// Token: 0x0401C178 RID: 115064
		private PlotReviewComponent ReviewComp;

		// Token: 0x0401C179 RID: 115065
		private PlotTextCommonLogic CommonLogic;

		// Token: 0x0401C17A RID: 115066
		private bool ImmersiveInputWakeState;

		// Token: 0x0401C17B RID: 115067
		private bool? MainButtonsTweenShown;

		// Token: 0x0401C17C RID: 115068
		private bool? SkipTweenShown;

		// Token: 0x0401C17D RID: 115069
		private bool? ReviewTweenShown;

		// Token: 0x0401C17E RID: 115070
		private bool PendingImmersiveSleep;

		// Token: 0x0401C17F RID: 115071
		private TimerHandle PendingImmersiveSleepTimerId;

		// Token: 0x0401C180 RID: 115072
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap;

		// Token: 0x0401C181 RID: 115073
		private bool TickBlackScreenFade;

		// Token: 0x0401C182 RID: 115074
		private bool TickPhotoFade;

		// Token: 0x0401C183 RID: 115075
		private UUITexture BgWidget;

		// Token: 0x0401C184 RID: 115076
		private UUITexture BgWidgetFront;

		// Token: 0x0401C185 RID: 115077
		private UUITexture WidgetMiddle;

		// Token: 0x0401C186 RID: 115078
		private UUISprite BgWidgetMiddle;

		// Token: 0x0401C187 RID: 115079
		private UUISprite BlackBgWidget;

		// Token: 0x0401C188 RID: 115080
		private CustomPromise<bool> PlotFadeShowPromise;

		// Token: 0x0401C189 RID: 115081
		private CustomPromise<bool> PlotFadeHidePromise;

		// Token: 0x0401C18A RID: 115082
		private Action<ITalkItem> PlotViewPhotoCallback;

		// Token: 0x0401C18B RID: 115083
		private Action<ITalkItem> PlotViewBlackScreenCallback;

		// Token: 0x0401C18C RID: 115084
		private float FadeTimePhoto;

		// Token: 0x0401C18D RID: 115085
		private float FadeTimeBlackScreen;

		// Token: 0x0401C18E RID: 115086
		private bool IsFadeInPhoto;

		// Token: 0x0401C18F RID: 115087
		private bool IsFadeInBlackScreen;

		// Token: 0x0401C190 RID: 115088
		private bool IsVisible = true;

		// Token: 0x0401C191 RID: 115089
		private bool IsAlreadyHavePhoto;

		// Token: 0x0401C192 RID: 115090
		private bool? IsFullPhoto;

		// Token: 0x0401C193 RID: 115091
		private bool IsShowBlackBg;

		// Token: 0x0401C194 RID: 115092
		private FVector? CurrentDragPosition;

		// Token: 0x0401C195 RID: 115093
		private TimerHandle StartDelayTimer;

		// Token: 0x0401C196 RID: 115094
		private bool IsSubtitleFinishDelay;

		// Token: 0x0401C197 RID: 115095
		private bool IsAudioFinishDelay;

		// Token: 0x0401C198 RID: 115096
		private TimerHandle AudioEndDelayId;

		// Token: 0x0401C199 RID: 115097
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

		// Token: 0x0401C19A RID: 115098
		private PlotChildView ChildView;

		// Token: 0x0401C19B RID: 115099
		[Nullable(1)]
		private string ChildViewName = "";

		// Token: 0x0200B1D2 RID: 45522
		[NullableContext(0)]
		private enum EPlotChildCom
		{
			// Token: 0x04035EC1 RID: 220865
			BtnAuto,
			// Token: 0x04035EC2 RID: 220866
			BtnNextPage,
			// Token: 0x04035EC3 RID: 220867
			BtnSkip,
			// Token: 0x04035EC4 RID: 220868
			PlotText,
			// Token: 0x04035EC5 RID: 220869
			NPCName,
			// Token: 0x04035EC6 RID: 220870
			TxtList,
			// Token: 0x04035EC7 RID: 220871
			OptionItem,
			// Token: 0x04035EC8 RID: 220872
			OptionLayout,
			// Token: 0x04035EC9 RID: 220873
			TextList,
			// Token: 0x04035ECA RID: 220874
			PlotBg,
			// Token: 0x04035ECB RID: 220875
			PlotTextUHD,
			// Token: 0x04035ECC RID: 220876
			PanelLine,
			// Token: 0x04035ECD RID: 220877
			TxtFloat,
			// Token: 0x04035ECE RID: 220878
			ScreenEffect,
			// Token: 0x04035ECF RID: 220879
			AutoPlayManualItem,
			// Token: 0x04035ED0 RID: 220880
			AutoPlaySemiAutoItem,
			// Token: 0x04035ED1 RID: 220881
			AutoPlayAutoItem,
			// Token: 0x04035ED2 RID: 220882
			NPCTitle,
			// Token: 0x04035ED3 RID: 220883
			BtnHide,
			// Token: 0x04035ED4 RID: 220884
			NextIcon,
			// Token: 0x04035ED5 RID: 220885
			WaitingPoint,
			// Token: 0x04035ED6 RID: 220886
			BlackScreenBg,
			// Token: 0x04035ED7 RID: 220887
			PhotoScreenBg,
			// Token: 0x04035ED8 RID: 220888
			PhotoScreenBgFront,
			// Token: 0x04035ED9 RID: 220889
			DoingText,
			// Token: 0x04035EDA RID: 220890
			PhotoScreenMiddle,
			// Token: 0x04035EDB RID: 220891
			PhotoScreenBgMiddle,
			// Token: 0x04035EDC RID: 220892
			TextScrollView,
			// Token: 0x04035EDD RID: 220893
			OptionAdjustItem,
			// Token: 0x04035EDE RID: 220894
			PnlBg,
			// Token: 0x04035EDF RID: 220895
			PnlInfo,
			// Token: 0x04035EE0 RID: 220896
			SonUi,
			// Token: 0x04035EE1 RID: 220897
			BlockOption,
			// Token: 0x04035EE2 RID: 220898
			BtnReview,
			// Token: 0x04035EE3 RID: 220899
			OptionLimitBar,
			// Token: 0x04035EE4 RID: 220900
			VideoLayout,
			// Token: 0x04035EE5 RID: 220901
			AniSkipIn,
			// Token: 0x04035EE6 RID: 220902
			AniSkipOut,
			// Token: 0x04035EE7 RID: 220903
			AniReviewIn,
			// Token: 0x04035EE8 RID: 220904
			AniReviewOut,
			// Token: 0x04035EE9 RID: 220905
			AniAutoHideIn,
			// Token: 0x04035EEA RID: 220906
			AniAutoHideOut,
			// Token: 0x04035EEB RID: 220907
			TextDebugInfo,
			// Token: 0x04035EEC RID: 220908
			FullscreenAdaptAnchor,
			// Token: 0x04035EED RID: 220909
			ImportantList,
			// Token: 0x04035EEE RID: 220910
			PnlLayout02,
			// Token: 0x04035EEF RID: 220911
			TextScrollViewCopy,
			// Token: 0x04035EF0 RID: 220912
			ImportantOptionTipsIcon,
			// Token: 0x04035EF1 RID: 220913
			ImportantOptionTipsText,
			// Token: 0x04035EF2 RID: 220914
			AutoSelectTimeBar,
			// Token: 0x04035EF3 RID: 220915
			AutoSelectText,
			// Token: 0x04035EF4 RID: 220916
			AniAutoTextIn,
			// Token: 0x04035EF5 RID: 220917
			AniAutoTextOut,
			// Token: 0x04035EF6 RID: 220918
			NextIconNew
		}
	}
}
