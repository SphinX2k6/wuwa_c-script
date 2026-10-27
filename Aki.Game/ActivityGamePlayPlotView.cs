using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F39 RID: 3897
[NullableContext(2)]
[Nullable(0)]
public class ActivityGamePlayPlotView : UiTickViewBase, ISimulatePlot
{
	// Token: 0x06006307 RID: 25351 RVA: 0x00136478 File Offset: 0x00134678
	[NullableContext(1)]
	public ActivityGamePlayPlotView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x1700079B RID: 1947
	// (get) Token: 0x06006308 RID: 25352 RVA: 0x001364E6 File Offset: 0x001346E6
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

	// Token: 0x1700079C RID: 1948
	// (get) Token: 0x06006309 RID: 25353 RVA: 0x001364F9 File Offset: 0x001346F9
	public ITalkItem CurrentSubtitle
	{
		get
		{
			return this.CommonLogic.CurrentContent;
		}
	}

	// Token: 0x1700079D RID: 1949
	// (get) Token: 0x0600630A RID: 25354 RVA: 0x00136506 File Offset: 0x00134706
	public bool HasOptions
	{
		get
		{
			return this.CurrentSubtitle != null && this.CurrentSubtitle.Options != null && this.CurrentSubtitle.Options.Count != 0;
		}
	}

	// Token: 0x0600630B RID: 25355 RVA: 0x00136534 File Offset: 0x00134734
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUILayoutBase)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUISprite)),
			new ValueTuple<int, Type>(16, typeof(UUITexture)),
			new ValueTuple<int, Type>(17, typeof(UUITexture)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUITexture)),
			new ValueTuple<int, Type>(20, typeof(UUISprite)),
			new ValueTuple<int, Type>(21, typeof(UUIScrollViewComponent)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUIItem)),
			new ValueTuple<int, Type>(27, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(28, typeof(UUIItem))
		};
	}

	// Token: 0x0600630C RID: 25356 RVA: 0x001367E0 File Offset: 0x001349E0
	protected override void OnStart()
	{
		this.CaptionItem = new PopupCaptionItem(base.GetItem(28));
		UUIButtonComponent closeBtn = this.CaptionItem.GetCloseBtn();
		PlotConfig plotConfig = PlotModel.Instance.PlotConfig;
		if (plotConfig.ActivityGamePlayPlotConfig != null)
		{
			ActivityGamePlayPlot? config = ConfigActivityGamePlayPlotById.GetConfig(plotConfig.ActivityGamePlayPlotConfig.Value, true);
			if (config != null && config.Value.NeedClose)
			{
				this.SkipComp = new PlotSkipComponent(closeBtn, this.OnSkip, this.OnSkipPop, null, this.OnSkipCancel, null, null);
			}
		}
		UUIScrollViewComponent scrollView = base.GetScrollView(21);
		if (scrollView != null)
		{
			scrollView.SetCanScroll(false);
		}
		if (scrollView != null)
		{
			scrollView.SetRayCastTargetForScrollView(false);
		}
		this.CommonLogic = new PlotTextCommonLogic(base.GetItem(1), base.GetText(2), base.GetText(12), base.GetText(3), base.GetItem(9), scrollView, this, base.GetLayoutBase(5), base.GetItem(4), base.GetSlider(27), this.UiViewSequence, base.GetItem(26), base.GetItem(22), null, null, null, null, null, null, null);
		this.CommonLogic.SetPlotContentAnimFinishCallback(new Action(this.HandleSubtitleAnimFinished));
		this.SkipSubtitleTipItem = base.GetItem(13);
		this.SkipSubtitleTipItemActive(false);
		this.ShowWaitingPoint(false);
		this.UpdateByPlotConfig();
		this.AddScreenEffectPlotRoot();
		this.FadeTimePhoto = 0;
		this.FadeTimeBlackScreen = 0;
		this.BgWidget = base.GetTexture(16);
		if (this.BgWidget != null)
		{
			this.BgWidget.SetAlpha(0f);
		}
		this.BgWidgetFront = base.GetTexture(17);
		if (this.BgWidgetFront != null)
		{
			this.BgWidgetFront.SetAlpha(0f);
		}
		this.WidgetMiddle = base.GetTexture(19);
		if (this.WidgetMiddle != null)
		{
			this.WidgetMiddle.SetAlpha(0f);
		}
		this.BgWidgetMiddle = base.GetSprite(20);
		if (this.BgWidgetMiddle != null)
		{
			this.BgWidgetMiddle.SetUIActive(false);
		}
		this.BlackBgWidget = base.GetSprite(15);
		if (this.BlackBgWidget != null)
		{
			this.BlackBgWidget.SetAlpha(0f);
		}
		this.IsVisible = true;
	}

	// Token: 0x0600630D RID: 25357 RVA: 0x00136A15 File Offset: 0x00134C15
	private void ShowBlackBg(bool isShow)
	{
		if (isShow == this.IsShowBlackBg)
		{
			return;
		}
		this.IsShowBlackBg = isShow;
		base.PlaySequence(isShow ? "PlotStart" : "PlotClose", null, false);
	}

	// Token: 0x0600630E RID: 25358 RVA: 0x00136A40 File Offset: 0x00134C40
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		ActivityGamePlayPlotView.<OnPlayingStartSequenceAsync>d__50 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<ActivityGamePlayPlotView.<OnPlayingStartSequenceAsync>d__50>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600630F RID: 25359 RVA: 0x00136A84 File Offset: 0x00134C84
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		ActivityGamePlayPlotView.<OnPlayingCloseSequenceAsync>d__51 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<ActivityGamePlayPlotView.<OnPlayingCloseSequenceAsync>d__51>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006310 RID: 25360 RVA: 0x00136AC7 File Offset: 0x00134CC7
	protected override void OnAfterShow()
	{
		EventSystem.Instance.Emit<EUiViewName, bool>(EEventName.PlotViewChange, this.ViewInfo.Name, true);
	}

	// Token: 0x06006311 RID: 25361 RVA: 0x00136AE8 File Offset: 0x00134CE8
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Emit<EUiViewName, bool>(EEventName.PlotViewChange, this.ViewInfo.Name, false);
		PlotModel.Instance.OptionEnable = true;
		base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI", this.BgWidget, null, null);
		base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI", this.BgWidgetFront, null, null);
		base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI", this.WidgetMiddle, null, null);
		this.IsAlreadyHavePhoto = false;
		this.FadeTimePhoto = 0;
		this.FadeTimeBlackScreen = 0;
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
		base.GetItem(26).SetUIActive(false);
		this.CloseChildView().Forget();
	}

	// Token: 0x06006312 RID: 25362 RVA: 0x00136BDB File Offset: 0x00134DDB
	protected override void OnBeforeDestroy()
	{
		this.CommonLogic.Clear();
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
	}

	// Token: 0x06006313 RID: 25363 RVA: 0x00136C1C File Offset: 0x00134E1C
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
		EventSystem.Instance.Add<float>(EEventName.NavigationTriggerPlotForward, new Action<float>(this.OnNavigationTriggerPlotForward));
		EventSystem.Instance.Add<float>(EEventName.NavigationTriggerPlotRight, new Action<float>(this.OnNavigationTriggerPlotRight));
		EventSystem.Instance.Add<float>(EEventName.NavigationTriggerPlotZoom, new Action<float>(this.OnNavigationTriggerPlotZoom));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		PlotSkipComponent skipComp = this.SkipComp;
		if (skipComp != null)
		{
			skipComp.AddEventListener();
		}
		InputDistributeController.Instance.BindTouch(0, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouchPlotVisible));
		UUIDraggableComponent uuidraggableComponent = base.GetButton(0).RootUIComp.Get().GetOwner().GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent;
		if (uuidraggableComponent != null)
		{
			uuidraggableComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDragCallBack));
			uuidraggableComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
			uuidraggableComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndDragCallBack));
			uuidraggableComponent.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnBtnSubtitleSkipClick));
			uuidraggableComponent.OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerScrollCallBack));
		}
		UUIItem item = base.GetItem(1);
		TermExplanationController.Instance.RegisterTextHyperlink(base.GetText(3), ETermExplanationViewType.Center, ETermExplanationReportType.Plot, ETermExplanationViewAttachDirection.Up, item, null, null, ETermExplanationGroup.Default, 0, ETermExplanationViewStyle.Default);
	}

	// Token: 0x06006314 RID: 25364 RVA: 0x00136EC0 File Offset: 0x001350C0
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
		EventSystem.Instance.Remove<float>(EEventName.NavigationTriggerPlotForward, new Action<float>(this.OnNavigationTriggerPlotForward));
		EventSystem.Instance.Remove<float>(EEventName.NavigationTriggerPlotRight, new Action<float>(this.OnNavigationTriggerPlotRight));
		EventSystem.Instance.Remove<float>(EEventName.NavigationTriggerPlotZoom, new Action<float>(this.OnNavigationTriggerPlotZoom));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		PlotSkipComponent skipComp = this.SkipComp;
		if (skipComp != null)
		{
			skipComp.RemoveEventListener();
		}
		InputDistributeController.Instance.UnBindTouch(0, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouchPlotVisible));
		UUIDraggableComponent uuidraggableComponent = base.GetButton(0).RootUIComp.Get().GetOwner().GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent;
		if (uuidraggableComponent != null)
		{
			uuidraggableComponent.OnPointerBeginDragCallBack.Unbind();
			uuidraggableComponent.OnPointerDragCallBack.Unbind();
			uuidraggableComponent.OnPointerEndDragCallBack.Unbind();
			uuidraggableComponent.OnPointerUpCallBack.Unbind();
			uuidraggableComponent.OnPointerScrollCallBack.Unbind();
		}
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(3));
	}

	// Token: 0x06006315 RID: 25365 RVA: 0x0013710B File Offset: 0x0013530B
	private void OnNavigationTriggerPlotForward(float value)
	{
		InputController.Instance.InputAxis(EInputAxis.LookUp, value, true);
	}

	// Token: 0x06006316 RID: 25366 RVA: 0x0013711E File Offset: 0x0013531E
	private void OnNavigationTriggerPlotRight(float value)
	{
		InputController.Instance.InputAxis(EInputAxis.Turn, value, true);
	}

	// Token: 0x06006317 RID: 25367 RVA: 0x00137134 File Offset: 0x00135334
	private void OnNavigationTriggerPlotZoom(float value)
	{
		if (MathUtils.Instance.IsNearlyZero((double)value, null))
		{
			return;
		}
		float num = value * 1.2f;
		InputController.Instance.InputAxis(EInputAxis.Zoom, -num, true);
	}

	// Token: 0x06006318 RID: 25368 RVA: 0x00137173 File Offset: 0x00135373
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!PlotModel.Instance.CanControlView)
		{
			return;
		}
		this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
	}

	// Token: 0x06006319 RID: 25369 RVA: 0x00137194 File Offset: 0x00135394
	private void OnPointerScrollCallBack(ULGUIPointerEventData eventData)
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
		float value = eventData.scrollAxisValue * 1.2f;
		InputController.Instance.InputAxis(EInputAxis.Zoom, value, true);
	}

	// Token: 0x0600631A RID: 25370 RVA: 0x001371E8 File Offset: 0x001353E8
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

	// Token: 0x0600631B RID: 25371 RVA: 0x001372A9 File Offset: 0x001354A9
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!PlotModel.Instance.CanControlView)
		{
			return;
		}
		this.CurrentDragPosition = null;
	}

	// Token: 0x0600631C RID: 25372 RVA: 0x001372C4 File Offset: 0x001354C4
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

	// Token: 0x0600631D RID: 25373 RVA: 0x001372F0 File Offset: 0x001354F0
	public void SimulateClickSubtitle()
	{
		if (Info.Instance.IsBuildShipping)
		{
			return;
		}
		this.OnBtnSubtitleSkipClick(null);
	}

	// Token: 0x0600631E RID: 25374 RVA: 0x00137308 File Offset: 0x00135508
	public void SimulateClickOption()
	{
		if (Info.Instance.IsBuildShipping)
		{
			return;
		}
		if (this.Options == null)
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

	// Token: 0x0600631F RID: 25375 RVA: 0x00137360 File Offset: 0x00135560
	private void UpdateCaptionData()
	{
		PlotConfig plotConfig = PlotModel.Instance.PlotConfig;
		if (plotConfig.ActivityGamePlayPlotConfig == null)
		{
			return;
		}
		ActivityGamePlayPlot? config = ConfigActivityGamePlayPlotById.GetConfig(plotConfig.ActivityGamePlayPlotConfig.Value, true);
		if (config == null)
		{
			return;
		}
		this.CaptionItem.SetTitleByTextIdAndArgNew(config.Value.Name, Array.Empty<object>());
		this.CaptionItem.SetTitleIcon(config.Value.Icon);
		this.CaptionItem.SetHelpBtnActive(config.Value.HelpId != 0);
		if (config.Value.HelpId != 0)
		{
			this.CaptionItem.SetHelpCallBack(delegate
			{
				HelpController.Instance.OpenHelpById(config.Value.HelpId);
			});
		}
		this.CaptionItem.SetCloseBtnActive(config.Value.NeedClose);
	}

	// Token: 0x06006320 RID: 25376 RVA: 0x00137460 File Offset: 0x00135660
	private void UpdateByPlotConfig()
	{
		this.ClearOptions();
		this.UpdateCaptionData();
		base.GetButton(0).RootUIComp.Get().SetUIActive(true);
		this.IsShowBlackBg = true;
		base.GetSprite(7).SetUIActive(this.IsShowBlackBg);
	}

	// Token: 0x06006321 RID: 25377 RVA: 0x001374AC File Offset: 0x001356AC
	[NullableContext(1)]
	private void UpdateSeqSubtitle(ITalkItem inPlotSubtitleInfo)
	{
		this.RemoveDelayTimer();
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
			ITalkItemSystemOption talkItemSystemOption = inPlotSubtitleInfo as ITalkItemSystemOption;
			flag = (talkItemSystemOption != null && talkItemSystemOption.OptionConfig.KeepPreTalkItem.GetValueOrDefault());
		}
		if (PlotModel.Instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelC && num > 20f)
		{
			if (!flag)
			{
				this.ShowBlackBg(false);
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
				this.ShowBlackBg(false);
			}
			this.ClearOptions();
			this.HandleSubtitleActions();
			return;
		}
		this.PlaySubtitle(inPlotSubtitleInfo);
	}

	// Token: 0x06006322 RID: 25378 RVA: 0x0013761B File Offset: 0x0013581B
	private void ShowOptions()
	{
		this.CommonLogic.ShowOptions();
	}

	// Token: 0x06006323 RID: 25379 RVA: 0x00137628 File Offset: 0x00135828
	private void ClearOptions()
	{
		this.CommonLogic.ClearOptions();
	}

	// Token: 0x06006324 RID: 25380 RVA: 0x00137635 File Offset: 0x00135835
	private void ShowUiExceptPhoto()
	{
		UUIItem item = base.GetItem(23);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIItem item2 = base.GetItem(24);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(true);
	}

	// Token: 0x06006325 RID: 25381 RVA: 0x0013765E File Offset: 0x0013585E
	[NullableContext(1)]
	private void HandlePortraitVisible(SetHeadIconVisible headIconInfo, Action callback)
	{
		this.CommonLogic.HandlePortraitVisible(this.RootItem, headIconInfo, callback);
	}

	// Token: 0x06006326 RID: 25382 RVA: 0x00137674 File Offset: 0x00135874
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

	// Token: 0x06006327 RID: 25383 RVA: 0x001376E8 File Offset: 0x001358E8
	[NullableContext(1)]
	private void PlaySubtitle(ITalkItem currentContent)
	{
		this.ClearOptions();
		this.ShowBlackBg(true);
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
			currentContent.WaitTime = waitTime;
		}
		if ((double)waitTime.Value < PlotModel.Instance.PlotTemplate.MinWaitingTime)
		{
			waitTime = new float?((float)PlotModel.Instance.PlotTemplate.MinWaitingTime);
			currentContent.WaitTime = waitTime;
		}
		double num = TimeUtil.Instance.SetTimeMillisecond((double)waitTime.Value);
		if (num < 20.0)
		{
			this.SkipSubtitleTipItemActive(true);
			this.ShowWaitingPoint(false);
			this.CanJumpToNextTalk = true;
			return;
		}
		this.SkipSubtitleTipItemActive(false);
		this.ShowWaitingPoint(true);
		this.WaitingSkipTimerId = TimerSystem.Instance.Delay(delegate(float timeId)
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
				if (PlotModel.Instance.PlotConfig.AutoPlayState != EAutoPlayState.Manual)
				{
					this.DelayHandleSubtitleActions();
				}
			}
			this.SkipSubtitleTipItemActive(true);
		}, (float)num, null, null, true, 1f);
	}

	// Token: 0x06006328 RID: 25384 RVA: 0x00137804 File Offset: 0x00135A04
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
		if (PlotModel.Instance.PlotConfig.AutoPlayState != EAutoPlayState.Manual)
		{
			this.DelayHandleSubtitleActions();
		}
	}

	// Token: 0x06006329 RID: 25385 RVA: 0x0013785C File Offset: 0x00135A5C
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
		float num2 = num * 1000f;
		TimerSystemInstance instance = TimerSystem.Instance;
		TTimerAction action = delegate(float _)
		{
			this.SkipSubtitleTipItemActive(false);
			this.HandleSubtitleActions();
		};
		float? playDelayTime = this.CommonLogic.PlayDelayTime;
		float num3 = num2;
		this.DelayId = instance.Delay(action, (playDelayTime.GetValueOrDefault() <= num3 & playDelayTime != null) ? num2 : this.CommonLogic.PlayDelayTime.Value, null, null, true, 1f);
	}

	// Token: 0x0600632A RID: 25386 RVA: 0x00137943 File Offset: 0x00135B43
	private void HandleSubtitleActions()
	{
		this.CanJumpToNextTalk = false;
		this.RemoveDelayTimer();
		if (this.CommonLogic.IsInteraction)
		{
			this.PlayNextPreTalk();
			return;
		}
		FlowController.Instance.FlowShowTalk.SubmitSubtitle(this.CommonLogic.CurrentContent);
	}

	// Token: 0x0600632B RID: 25387 RVA: 0x00137980 File Offset: 0x00135B80
	private void InitInteractOptions()
	{
		this.CommonLogic.InitInteractOptions();
	}

	// Token: 0x0600632C RID: 25388 RVA: 0x00137990 File Offset: 0x00135B90
	private void PlayNextPreTalk()
	{
		this.PreTalkIndex++;
		if (this.PreTalkItems != null && this.PreTalkIndex < this.PreTalkItems.Count)
		{
			this.CommonLogic.ClearPlotContent(false);
			ITalkItem talkItem = this.PreTalkItems[this.PreTalkIndex];
			this.CommonLogic.PlaySubtitle(talkItem);
			this.PlaySubtitle(talkItem);
			return;
		}
		if (this.PreTalkItems != null && this.PreTalkIndex == this.PreTalkItems.Count)
		{
			this.InitInteractOptions();
		}
	}

	// Token: 0x0600632D RID: 25389 RVA: 0x00137A1C File Offset: 0x00135C1C
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

	// Token: 0x0600632E RID: 25390 RVA: 0x00137B79 File Offset: 0x00135D79
	private void OnOpenView(EUiViewName viewName, int _)
	{
		if (viewName == EUiViewName.PlotReviewView)
		{
			AudioSystem.Instance.PostEvent("plot_review_enter");
		}
	}

	// Token: 0x0600632F RID: 25391 RVA: 0x00137B98 File Offset: 0x00135D98
	private void OnCloseView(EUiViewName viewName, int _)
	{
		if (viewName == EUiViewName.PlotReviewView)
		{
			AudioSystem.Instance.PostEvent("plot_review_exit");
			this.IsVisible = true;
			this.ShowUiExceptPhoto();
		}
	}

	// Token: 0x06006330 RID: 25392 RVA: 0x00137BC4 File Offset: 0x00135DC4
	private void SkipSubtitleTipItemActive(bool value)
	{
		PlotModel.Instance.CanClick = value;
		UUIItem skipSubtitleTipItem = this.SkipSubtitleTipItem;
		if (skipSubtitleTipItem != null)
		{
			skipSubtitleTipItem.SetUIActive(value);
		}
		EventSystem.Instance.Emit<bool>(EEventName.NavigationRefreshPlotNextPage, value);
	}

	// Token: 0x06006331 RID: 25393 RVA: 0x00137BF4 File Offset: 0x00135DF4
	private void ShowWaitingPoint(bool enable)
	{
		base.GetItem(14).SetUIActive(enable);
	}

	// Token: 0x06006332 RID: 25394 RVA: 0x00137C04 File Offset: 0x00135E04
	private void RemoveDelayTimer()
	{
		if (TimerSystem.Instance.Has(this.DelayId))
		{
			TimerSystem.Instance.Remove(this.DelayId);
		}
		this.DelayId = null;
	}

	// Token: 0x06006333 RID: 25395 RVA: 0x00137C30 File Offset: 0x00135E30
	public void RemoveWaitSkipTimer()
	{
		if (TimerSystem.Instance.Has(this.WaitingSkipTimerId))
		{
			TimerSystem.Instance.Remove(this.WaitingSkipTimerId);
		}
		this.WaitingSkipTimerId = null;
	}

	// Token: 0x06006334 RID: 25396 RVA: 0x00137C5C File Offset: 0x00135E5C
	private void HideAll(bool isHidden)
	{
		this.RootItem.SetUIActive(!isHidden);
	}

	// Token: 0x06006335 RID: 25397 RVA: 0x00137C6D File Offset: 0x00135E6D
	[NullableContext(1)]
	private void OnInputAnyKey(bool bPress, FKey _)
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
	}

	// Token: 0x06006336 RID: 25398 RVA: 0x00137C89 File Offset: 0x00135E89
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
	}

	// Token: 0x06006337 RID: 25399 RVA: 0x00137CAC File Offset: 0x00135EAC
	private Number GetCurrentPercentPhoto()
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
				return 0;
			}
			this.BgWidget.SetAlpha(rangePct);
		}
		return rangePct;
	}

	// Token: 0x06006338 RID: 25400 RVA: 0x00137D2C File Offset: 0x00135F2C
	private Number GetCurrentPercentPhotoMiddle()
	{
		float rangePct = MathUtils.Instance.GetRangePct(0f, 1000f, this.FadeTimePhoto);
		if (!this.IsFadeInPhoto && this.WidgetMiddle.GetAlpha() <= 0f)
		{
			return 0;
		}
		this.WidgetMiddle.SetAlpha(rangePct);
		return rangePct;
	}

	// Token: 0x06006339 RID: 25401 RVA: 0x00137D8C File Offset: 0x00135F8C
	private void OnFadeTickPhoto(float deltaTime)
	{
		if (this.FadeTimePhoto < 0)
		{
			this.FadeTimePhoto = 0;
		}
		if (this.FadeTimePhoto > 1000)
		{
			this.FadeTimePhoto = 1000;
		}
		if (this.IsFadeInPhoto)
		{
			this.FadeTimePhoto += deltaTime;
			if (this.IsFullPhoto.GetValueOrDefault())
			{
				if (this.GetCurrentPercentPhoto() > 1)
				{
					this.RemoveTickPhoto();
					this.OnCloseEventPhoto();
					return;
				}
			}
			else if (this.GetCurrentPercentPhotoMiddle() > 1)
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
				if (this.GetCurrentPercentPhoto() <= 0)
				{
					this.RemoveTickPhoto();
					this.OnCloseEventPhoto();
					return;
				}
			}
			else if (this.GetCurrentPercentPhotoMiddle() <= 0)
			{
				this.RemoveTickPhoto();
				this.OnCloseEventPhoto();
			}
		}
	}

	// Token: 0x0600633A RID: 25402 RVA: 0x00137EB4 File Offset: 0x001360B4
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
					this.PlotFadeHidePromise.SetResult(true);
					this.PlotFadeHidePromise = null;
				}
				else
				{
					this.PlotFadeHidePromise.SetResult(true);
					this.PlotFadeHidePromise = null;
				}
				this.IsAlreadyHavePhoto = true;
			}
			else if (!this.IsFadeInPhoto && this.PlotFadeShowPromise != null)
			{
				global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "Plot图片FadeOut结束", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.PlotFadeShowPromise.SetResult(true);
				this.PlotFadeShowPromise = null;
				base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI", this.BgWidget, null, null);
				this.IsAlreadyHavePhoto = false;
				PlotController.Instance.ResetViewControl();
			}
		}
		else if (this.IsFadeInPhoto && this.PlotFadeHidePromise != null)
		{
			global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "Plot Middle图片FadeIn结束", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.PlotFadeHidePromise.SetResult(true);
			this.PlotFadeHidePromise = null;
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
			this.PlotFadeShowPromise.SetResult(true);
			this.PlotFadeShowPromise = null;
			base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI", this.WidgetMiddle, null, null);
			this.IsAlreadyHavePhoto = false;
			PlotController.Instance.ResetViewControl();
		}
		Action<ITalkItem> plotViewPhotoCallback = this.PlotViewPhotoCallback;
		if (plotViewPhotoCallback == null)
		{
			return;
		}
		plotViewPhotoCallback(this.CurrentSubtitle);
	}

	// Token: 0x0600633B RID: 25403 RVA: 0x001380C8 File Offset: 0x001362C8
	public UniTask FadeInBgPhoto(string path = null, Action<ITalkItem> callback = null)
	{
		ActivityGamePlayPlotView.<FadeInBgPhoto>d__98 <FadeInBgPhoto>d__;
		<FadeInBgPhoto>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FadeInBgPhoto>d__.<>4__this = this;
		<FadeInBgPhoto>d__.path = path;
		<FadeInBgPhoto>d__.callback = callback;
		<FadeInBgPhoto>d__.<>1__state = -1;
		<FadeInBgPhoto>d__.<>t__builder.Start<ActivityGamePlayPlotView.<FadeInBgPhoto>d__98>(ref <FadeInBgPhoto>d__);
		return <FadeInBgPhoto>d__.<>t__builder.Task;
	}

	// Token: 0x0600633C RID: 25404 RVA: 0x0013811C File Offset: 0x0013631C
	public UniTask FadeOutBgPhoto(Action<ITalkItem> callback = null)
	{
		ActivityGamePlayPlotView.<FadeOutBgPhoto>d__99 <FadeOutBgPhoto>d__;
		<FadeOutBgPhoto>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FadeOutBgPhoto>d__.<>4__this = this;
		<FadeOutBgPhoto>d__.callback = callback;
		<FadeOutBgPhoto>d__.<>1__state = -1;
		<FadeOutBgPhoto>d__.<>t__builder.Start<ActivityGamePlayPlotView.<FadeOutBgPhoto>d__99>(ref <FadeOutBgPhoto>d__);
		return <FadeOutBgPhoto>d__.<>t__builder.Task;
	}

	// Token: 0x0600633D RID: 25405 RVA: 0x00138168 File Offset: 0x00136368
	public UniTask FadeInBgPhotoMiddle(string path = null, Action<ITalkItem> callback = null)
	{
		ActivityGamePlayPlotView.<FadeInBgPhotoMiddle>d__100 <FadeInBgPhotoMiddle>d__;
		<FadeInBgPhotoMiddle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FadeInBgPhotoMiddle>d__.<>4__this = this;
		<FadeInBgPhotoMiddle>d__.path = path;
		<FadeInBgPhotoMiddle>d__.callback = callback;
		<FadeInBgPhotoMiddle>d__.<>1__state = -1;
		<FadeInBgPhotoMiddle>d__.<>t__builder.Start<ActivityGamePlayPlotView.<FadeInBgPhotoMiddle>d__100>(ref <FadeInBgPhotoMiddle>d__);
		return <FadeInBgPhotoMiddle>d__.<>t__builder.Task;
	}

	// Token: 0x0600633E RID: 25406 RVA: 0x001381BC File Offset: 0x001363BC
	public UniTask FadeOutBgPhotoMiddle(Action<ITalkItem> callback = null)
	{
		ActivityGamePlayPlotView.<FadeOutBgPhotoMiddle>d__101 <FadeOutBgPhotoMiddle>d__;
		<FadeOutBgPhotoMiddle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FadeOutBgPhotoMiddle>d__.<>4__this = this;
		<FadeOutBgPhotoMiddle>d__.callback = callback;
		<FadeOutBgPhotoMiddle>d__.<>1__state = -1;
		<FadeOutBgPhotoMiddle>d__.<>t__builder.Start<ActivityGamePlayPlotView.<FadeOutBgPhotoMiddle>d__101>(ref <FadeOutBgPhotoMiddle>d__);
		return <FadeOutBgPhotoMiddle>d__.<>t__builder.Task;
	}

	// Token: 0x0600633F RID: 25407 RVA: 0x00138207 File Offset: 0x00136407
	private void AddTickPhoto()
	{
		this.TickPhotoFade = true;
	}

	// Token: 0x06006340 RID: 25408 RVA: 0x00138210 File Offset: 0x00136410
	private void RemoveTickPhoto()
	{
		this.TickPhotoFade = false;
	}

	// Token: 0x06006341 RID: 25409 RVA: 0x00138219 File Offset: 0x00136419
	private void AddTickBlackScreen()
	{
		this.TickBlackScreenFade = true;
	}

	// Token: 0x06006342 RID: 25410 RVA: 0x00138222 File Offset: 0x00136422
	private void RemoveTickBlackScreen()
	{
		this.TickBlackScreenFade = false;
	}

	// Token: 0x06006343 RID: 25411 RVA: 0x0013822C File Offset: 0x0013642C
	private Number GetCurrentPercentBlackScreen()
	{
		float rangePct = MathUtils.Instance.GetRangePct(0f, 1000f, this.FadeTimeBlackScreen);
		this.BlackBgWidget.SetAlpha(rangePct);
		return rangePct;
	}

	// Token: 0x06006344 RID: 25412 RVA: 0x0013826C File Offset: 0x0013646C
	private void OnFadeTickBlackScreen(float deltaTime)
	{
		if (this.FadeTimeBlackScreen < 0)
		{
			this.FadeTimeBlackScreen = 0;
		}
		if (this.FadeTimeBlackScreen > 1000)
		{
			this.FadeTimeBlackScreen = 1000;
		}
		if (this.IsFadeInBlackScreen)
		{
			this.FadeTimeBlackScreen += deltaTime;
			if (this.GetCurrentPercentBlackScreen() > 1)
			{
				this.RemoveTickBlackScreen();
				this.OnCloseEventBlackScreen();
				return;
			}
		}
		else
		{
			this.FadeTimeBlackScreen -= deltaTime;
			if (this.GetCurrentPercentBlackScreen() < 0)
			{
				this.RemoveTickBlackScreen();
				this.OnCloseEventBlackScreen();
			}
		}
	}

	// Token: 0x06006345 RID: 25413 RVA: 0x00138334 File Offset: 0x00136534
	private void OnCloseEventBlackScreen()
	{
		if (this.IsFadeInBlackScreen && this.PlotFadeHidePromise != null)
		{
			global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "Plot黑幕FadeIn结束", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.PlotFadeHidePromise.SetResult(true);
			this.PlotFadeHidePromise = null;
		}
		else if (!this.IsFadeInBlackScreen && this.PlotFadeShowPromise != null)
		{
			global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "Plot黑幕FadeOut结束", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.PlotFadeShowPromise.SetResult(true);
			this.PlotFadeShowPromise = null;
		}
		Action<ITalkItem> plotViewBlackScreenCallback = this.PlotViewBlackScreenCallback;
		if (plotViewBlackScreenCallback == null)
		{
			return;
		}
		plotViewBlackScreenCallback(this.CurrentSubtitle);
	}

	// Token: 0x06006346 RID: 25414 RVA: 0x001383E0 File Offset: 0x001365E0
	public UniTask FadeInBgBlackScreen(Action<ITalkItem> callback = null)
	{
		ActivityGamePlayPlotView.<FadeInBgBlackScreen>d__109 <FadeInBgBlackScreen>d__;
		<FadeInBgBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FadeInBgBlackScreen>d__.<>4__this = this;
		<FadeInBgBlackScreen>d__.callback = callback;
		<FadeInBgBlackScreen>d__.<>1__state = -1;
		<FadeInBgBlackScreen>d__.<>t__builder.Start<ActivityGamePlayPlotView.<FadeInBgBlackScreen>d__109>(ref <FadeInBgBlackScreen>d__);
		return <FadeInBgBlackScreen>d__.<>t__builder.Task;
	}

	// Token: 0x06006347 RID: 25415 RVA: 0x0013842C File Offset: 0x0013662C
	public UniTask FadeOutBgBlackScreen(Action<ITalkItem> callback = null)
	{
		ActivityGamePlayPlotView.<FadeOutBgBlackScreen>d__110 <FadeOutBgBlackScreen>d__;
		<FadeOutBgBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FadeOutBgBlackScreen>d__.<>4__this = this;
		<FadeOutBgBlackScreen>d__.callback = callback;
		<FadeOutBgBlackScreen>d__.<>1__state = -1;
		<FadeOutBgBlackScreen>d__.<>t__builder.Start<ActivityGamePlayPlotView.<FadeOutBgBlackScreen>d__110>(ref <FadeOutBgBlackScreen>d__);
		return <FadeOutBgBlackScreen>d__.<>t__builder.Task;
	}

	// Token: 0x06006348 RID: 25416 RVA: 0x00138478 File Offset: 0x00136678
	public UniTask OpenChildView(int id, bool isLoop)
	{
		ActivityGamePlayPlotView.<OpenChildView>d__113 <OpenChildView>d__;
		<OpenChildView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenChildView>d__.<>4__this = this;
		<OpenChildView>d__.id = id;
		<OpenChildView>d__.isLoop = isLoop;
		<OpenChildView>d__.<>1__state = -1;
		<OpenChildView>d__.<>t__builder.Start<ActivityGamePlayPlotView.<OpenChildView>d__113>(ref <OpenChildView>d__);
		return <OpenChildView>d__.<>t__builder.Task;
	}

	// Token: 0x06006349 RID: 25417 RVA: 0x001384CC File Offset: 0x001366CC
	public UniTask CloseChildView()
	{
		ActivityGamePlayPlotView.<CloseChildView>d__114 <CloseChildView>d__;
		<CloseChildView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseChildView>d__.<>4__this = this;
		<CloseChildView>d__.<>1__state = -1;
		<CloseChildView>d__.<>t__builder.Start<ActivityGamePlayPlotView.<CloseChildView>d__114>(ref <CloseChildView>d__);
		return <CloseChildView>d__.<>t__builder.Task;
	}

	// Token: 0x0600634A RID: 25418 RVA: 0x00138510 File Offset: 0x00136710
	public void AddScreenEffectPlotRoot()
	{
		BP_ScreenEffectSystem_C instance = ScreenEffectSystem.GetInstance();
		UUIItem item = base.GetItem(11);
		if (instance == null || !instance.IsValid() || item == null)
		{
			return;
		}
		AUIContainerActor screenEffectPlotRoot = null;
		instance.GetScreenEffectPlotRoot(ref screenEffectPlotRoot);
		this.ScreenEffectPlotRoot = screenEffectPlotRoot;
		if (this.ScreenEffectPlotRoot != null && this.ScreenEffectPlotRoot.IsValid())
		{
			this.ScreenEffectPlotRoot.K2_AttachRootComponentTo(item, default(FName), EAttachLocation.KeepRelativeOffset, true);
		}
	}

	// Token: 0x0600634B RID: 25419 RVA: 0x00138578 File Offset: 0x00136778
	public void RemoveScreenEffectPlotRoot()
	{
		if (this.ScreenEffectPlotRoot != null && this.ScreenEffectPlotRoot.IsValid())
		{
			this.ScreenEffectPlotRoot.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
		}
		this.ScreenEffectPlotRoot = null;
	}

	// Token: 0x0600634C RID: 25420 RVA: 0x001385A4 File Offset: 0x001367A4
	private void OnPlotViewBgFadePhoto(bool isFadeIn, bool isFull, string path, Action callback)
	{
		this.DoOnPlotViewBgFadePhoto(isFadeIn, isFull, path, delegate(ITalkItem _)
		{
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		});
	}

	// Token: 0x0600634D RID: 25421 RVA: 0x001385D8 File Offset: 0x001367D8
	private UniTask DoOnPlotViewBgFadePhoto(bool isFadeIn, bool isFull, string path, Action<ITalkItem> callback)
	{
		ActivityGamePlayPlotView.<DoOnPlotViewBgFadePhoto>d__118 <DoOnPlotViewBgFadePhoto>d__;
		<DoOnPlotViewBgFadePhoto>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DoOnPlotViewBgFadePhoto>d__.<>4__this = this;
		<DoOnPlotViewBgFadePhoto>d__.isFadeIn = isFadeIn;
		<DoOnPlotViewBgFadePhoto>d__.isFull = isFull;
		<DoOnPlotViewBgFadePhoto>d__.path = path;
		<DoOnPlotViewBgFadePhoto>d__.callback = callback;
		<DoOnPlotViewBgFadePhoto>d__.<>1__state = -1;
		<DoOnPlotViewBgFadePhoto>d__.<>t__builder.Start<ActivityGamePlayPlotView.<DoOnPlotViewBgFadePhoto>d__118>(ref <DoOnPlotViewBgFadePhoto>d__);
		return <DoOnPlotViewBgFadePhoto>d__.<>t__builder.Task;
	}

	// Token: 0x0600634E RID: 25422 RVA: 0x0013863C File Offset: 0x0013683C
	private void OnPlotViewBgFadeBlackScreen(bool isFadeIn, Action callback)
	{
		this.DoOnPlotViewBgFadeBlackScreen(isFadeIn, delegate(ITalkItem _)
		{
			Action callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2();
		}).Forget();
	}

	// Token: 0x0600634F RID: 25423 RVA: 0x00138670 File Offset: 0x00136870
	private UniTask DoOnPlotViewBgFadeBlackScreen(bool isFadeIn, Action<ITalkItem> callback)
	{
		ActivityGamePlayPlotView.<DoOnPlotViewBgFadeBlackScreen>d__120 <DoOnPlotViewBgFadeBlackScreen>d__;
		<DoOnPlotViewBgFadeBlackScreen>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<DoOnPlotViewBgFadeBlackScreen>d__.<>4__this = this;
		<DoOnPlotViewBgFadeBlackScreen>d__.isFadeIn = isFadeIn;
		<DoOnPlotViewBgFadeBlackScreen>d__.callback = callback;
		<DoOnPlotViewBgFadeBlackScreen>d__.<>1__state = -1;
		<DoOnPlotViewBgFadeBlackScreen>d__.<>t__builder.Start<ActivityGamePlayPlotView.<DoOnPlotViewBgFadeBlackScreen>d__120>(ref <DoOnPlotViewBgFadeBlackScreen>d__);
		return <DoOnPlotViewBgFadeBlackScreen>d__.<>t__builder.Task;
	}

	// Token: 0x06006350 RID: 25424 RVA: 0x001386C3 File Offset: 0x001368C3
	private void ClearPlotSubtitle()
	{
		this.ClearPlotView();
		this.CommonLogic.ClearPlotContent(false);
	}

	// Token: 0x06006351 RID: 25425 RVA: 0x001386D8 File Offset: 0x001368D8
	private void ClearPlotView()
	{
		this.RemoveWaitSkipTimer();
		this.RemoveDelayTimer();
		this.ClearOptions();
		base.GetItem(1).SetUIActive(false);
		base.GetText(2).SetUIActive(false);
		base.GetText(12).SetUIActive(false);
		base.GetItem(9).SetUIActive(false);
	}

	// Token: 0x04002CE8 RID: 11496
	private const int FADE_TIME = 1000;

	// Token: 0x04002CE9 RID: 11497
	private const float ROTATE_RATE_X = 0.06f;

	// Token: 0x04002CEA RID: 11498
	private const float ROTATE_RATE_Y = 0.03f;

	// Token: 0x04002CEB RID: 11499
	private const float ZOOM_RATE = 1.2f;

	// Token: 0x04002CEC RID: 11500
	[Nullable(1)]
	private const string DEFAULT_PATH = "/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI";

	// Token: 0x04002CED RID: 11501
	[Nullable(1)]
	private const string CLICK_AUDIO_EVENT = "play_ui_ia_spl_plot_next";

	// Token: 0x04002CEE RID: 11502
	[Nullable(1)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04002CEF RID: 11503
	[Nullable(1)]
	public List<PlotOption> CurOption = new List<PlotOption>();

	// Token: 0x04002CF0 RID: 11504
	private PlotSkipComponent SkipComp;

	// Token: 0x04002CF1 RID: 11505
	private TimerHandle DelayId;

	// Token: 0x04002CF2 RID: 11506
	private TimerHandle WaitingSkipTimerId;

	// Token: 0x04002CF3 RID: 11507
	public PawnInteractController InteractController;

	// Token: 0x04002CF4 RID: 11508
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ITalkItem> PreTalkItems;

	// Token: 0x04002CF5 RID: 11509
	private int PreTalkIndex;

	// Token: 0x04002CF6 RID: 11510
	private bool CanJumpToNextTalk;

	// Token: 0x04002CF7 RID: 11511
	private UUIItem SkipSubtitleTipItem;

	// Token: 0x04002CF8 RID: 11512
	private AUIContainerActor ScreenEffectPlotRoot;

	// Token: 0x04002CF9 RID: 11513
	private PlotTextCommonLogic CommonLogic;

	// Token: 0x04002CFA RID: 11514
	private bool TickBlackScreenFade;

	// Token: 0x04002CFB RID: 11515
	private bool TickPhotoFade;

	// Token: 0x04002CFC RID: 11516
	private UUITexture BgWidget;

	// Token: 0x04002CFD RID: 11517
	private UUITexture BgWidgetFront;

	// Token: 0x04002CFE RID: 11518
	private UUITexture WidgetMiddle;

	// Token: 0x04002CFF RID: 11519
	private UUISprite BgWidgetMiddle;

	// Token: 0x04002D00 RID: 11520
	private UUISprite BlackBgWidget;

	// Token: 0x04002D01 RID: 11521
	private CustomPromise<bool> PlotFadeShowPromise;

	// Token: 0x04002D02 RID: 11522
	private CustomPromise<bool> PlotFadeHidePromise;

	// Token: 0x04002D03 RID: 11523
	private Action<ITalkItem> PlotViewPhotoCallback;

	// Token: 0x04002D04 RID: 11524
	private Action<ITalkItem> PlotViewBlackScreenCallback;

	// Token: 0x04002D05 RID: 11525
	private Number FadeTimePhoto = 0;

	// Token: 0x04002D06 RID: 11526
	private Number FadeTimeBlackScreen = 0;

	// Token: 0x04002D07 RID: 11527
	private bool IsFadeInPhoto;

	// Token: 0x04002D08 RID: 11528
	private bool IsFadeInBlackScreen;

	// Token: 0x04002D09 RID: 11529
	private bool IsVisible = true;

	// Token: 0x04002D0A RID: 11530
	private bool IsAlreadyHavePhoto;

	// Token: 0x04002D0B RID: 11531
	private bool? IsFullPhoto;

	// Token: 0x04002D0C RID: 11532
	private bool IsShowBlackBg;

	// Token: 0x04002D0D RID: 11533
	private FVector? CurrentDragPosition;

	// Token: 0x04002D0E RID: 11534
	private TimerHandle StartDelayTimer;

	// Token: 0x04002D0F RID: 11535
	[Nullable(1)]
	private readonly Action OnSkip = delegate()
	{
		FlowController.Instance.BackgroundFlow("UI点击跳过(PlotView)", true, false, false);
	};

	// Token: 0x04002D10 RID: 11536
	private readonly Action OnSkipPop;

	// Token: 0x04002D11 RID: 11537
	private readonly Action OnSkipCancel;

	// Token: 0x04002D12 RID: 11538
	private PlotChildView ChildView;

	// Token: 0x04002D13 RID: 11539
	[Nullable(1)]
	private string ChildViewName = "";

	// Token: 0x02007584 RID: 30084
	[NullableContext(0)]
	private class EPlotChildCom
	{
		// Token: 0x04026D9E RID: 159134
		public const int BtnNextPage = 0;

		// Token: 0x04026D9F RID: 159135
		public const int PlotText = 1;

		// Token: 0x04026DA0 RID: 159136
		public const int NPCName = 2;

		// Token: 0x04026DA1 RID: 159137
		public const int TxtList = 3;

		// Token: 0x04026DA2 RID: 159138
		public const int OptionItem = 4;

		// Token: 0x04026DA3 RID: 159139
		public const int OptionLayout = 5;

		// Token: 0x04026DA4 RID: 159140
		public const int TextList = 6;

		// Token: 0x04026DA5 RID: 159141
		public const int PlotBg = 7;

		// Token: 0x04026DA6 RID: 159142
		public const int PlotTextUHD = 8;

		// Token: 0x04026DA7 RID: 159143
		public const int PanelLine = 9;

		// Token: 0x04026DA8 RID: 159144
		public const int TxtFloat = 10;

		// Token: 0x04026DA9 RID: 159145
		public const int ScreenEffect = 11;

		// Token: 0x04026DAA RID: 159146
		public const int NPCTitle = 12;

		// Token: 0x04026DAB RID: 159147
		public const int NextIcon = 13;

		// Token: 0x04026DAC RID: 159148
		public const int WaitingPoint = 14;

		// Token: 0x04026DAD RID: 159149
		public const int BlackScreenBg = 15;

		// Token: 0x04026DAE RID: 159150
		public const int PhotoScreenBg = 16;

		// Token: 0x04026DAF RID: 159151
		public const int PhotoScreenBgFront = 17;

		// Token: 0x04026DB0 RID: 159152
		public const int DoingText = 18;

		// Token: 0x04026DB1 RID: 159153
		public const int PhotoScreenMiddle = 19;

		// Token: 0x04026DB2 RID: 159154
		public const int PhotoScreenBgMiddle = 20;

		// Token: 0x04026DB3 RID: 159155
		public const int TextScrollView = 21;

		// Token: 0x04026DB4 RID: 159156
		public const int OptionAdjustItem = 22;

		// Token: 0x04026DB5 RID: 159157
		public const int PnlBg = 23;

		// Token: 0x04026DB6 RID: 159158
		public const int PnlInfo = 24;

		// Token: 0x04026DB7 RID: 159159
		public const int SonUi = 25;

		// Token: 0x04026DB8 RID: 159160
		public const int BlockOption = 26;

		// Token: 0x04026DB9 RID: 159161
		public const int OptionLimitBar = 27;

		// Token: 0x04026DBA RID: 159162
		public const int Caption = 28;
	}
}
