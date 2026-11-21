using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
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

// Token: 0x020003EE RID: 1006
[NullableContext(2)]
[Nullable(0)]
public class ActivityGamePlayPlotView : UiTickViewBase, ISimulatePlot
{
	// Token: 0x0600369F RID: 13983 RVA: 0x0013EDA0 File Offset: 0x0013CFA0
	[NullableContext(1)]
	public ActivityGamePlayPlotView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x170007BD RID: 1981
	// (get) Token: 0x060036A0 RID: 13984 RVA: 0x0013EE0E File Offset: 0x0013D00E
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

	// Token: 0x170007BE RID: 1982
	// (get) Token: 0x060036A1 RID: 13985 RVA: 0x0013EE21 File Offset: 0x0013D021
	public ITalkItem CurrentSubtitle
	{
		get
		{
			return this.CommonLogic.CurrentContent;
		}
	}

	// Token: 0x170007BF RID: 1983
	// (get) Token: 0x060036A2 RID: 13986 RVA: 0x0013EE2E File Offset: 0x0013D02E
	public bool HasOptions
	{
		get
		{
			return this.CurrentSubtitle != null && this.CurrentSubtitle.Options != null && this.CurrentSubtitle.Options.Count != 0;
		}
	}

	// Token: 0x060036A3 RID: 13987 RVA: 0x0013EE5C File Offset: 0x0013D05C
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

	// Token: 0x060036A4 RID: 13988 RVA: 0x0013F108 File Offset: 0x0013D308
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

	// Token: 0x060036A5 RID: 13989 RVA: 0x0013F33D File Offset: 0x0013D53D
	private void ShowBlackBg(bool isShow)
	{
		if (isShow == this.IsShowBlackBg)
		{
			return;
		}
		this.IsShowBlackBg = isShow;
		base.PlaySequence(isShow ? "PlotStart" : "PlotClose", null, false);
	}

	// Token: 0x060036A6 RID: 13990 RVA: 0x0013F368 File Offset: 0x0013D568
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		ActivityGamePlayPlotView.<OnPlayingStartSequenceAsync>d__50 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<ActivityGamePlayPlotView.<OnPlayingStartSequenceAsync>d__50>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060036A7 RID: 13991 RVA: 0x0013F3AC File Offset: 0x0013D5AC
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		ActivityGamePlayPlotView.<OnPlayingCloseSequenceAsync>d__51 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<ActivityGamePlayPlotView.<OnPlayingCloseSequenceAsync>d__51>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060036A8 RID: 13992 RVA: 0x0013F3EF File Offset: 0x0013D5EF
	protected override void OnAfterShow()
	{
		EventSystem.Instance.Emit<EUiViewName, bool>(EEventName.PlotViewChange, this.ViewInfo.Name, true);
	}

	// Token: 0x060036A9 RID: 13993 RVA: 0x0013F410 File Offset: 0x0013D610
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

	// Token: 0x060036AA RID: 13994 RVA: 0x0013F503 File Offset: 0x0013D703
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

	// Token: 0x060036AB RID: 13995 RVA: 0x0013F544 File Offset: 0x0013D744
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

	// Token: 0x060036AC RID: 13996 RVA: 0x0013F7E8 File Offset: 0x0013D9E8
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

	// Token: 0x060036AD RID: 13997 RVA: 0x0013FA33 File Offset: 0x0013DC33
	private void OnNavigationTriggerPlotForward(float value)
	{
		InputController.Instance.InputAxis(EInputAxis.LookUp, value, true);
	}

	// Token: 0x060036AE RID: 13998 RVA: 0x0013FA46 File Offset: 0x0013DC46
	private void OnNavigationTriggerPlotRight(float value)
	{
		InputController.Instance.InputAxis(EInputAxis.Turn, value, true);
	}

	// Token: 0x060036AF RID: 13999 RVA: 0x0013FA5C File Offset: 0x0013DC5C
	private void OnNavigationTriggerPlotZoom(float value)
	{
		if (MathUtils.Instance.IsNearlyZero((double)value, null))
		{
			return;
		}
		float num = value * 1.2f;
		InputController.Instance.InputAxis(EInputAxis.Zoom, -num, true);
	}

	// Token: 0x060036B0 RID: 14000 RVA: 0x0013FA9B File Offset: 0x0013DC9B
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!PlotModel.Instance.CanControlView)
		{
			return;
		}
		this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
	}

	// Token: 0x060036B1 RID: 14001 RVA: 0x0013FABC File Offset: 0x0013DCBC
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

	// Token: 0x060036B2 RID: 14002 RVA: 0x0013FB10 File Offset: 0x0013DD10
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

	// Token: 0x060036B3 RID: 14003 RVA: 0x0013FBD1 File Offset: 0x0013DDD1
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!PlotModel.Instance.CanControlView)
		{
			return;
		}
		this.CurrentDragPosition = null;
	}

	// Token: 0x060036B4 RID: 14004 RVA: 0x0013FBEC File Offset: 0x0013DDEC
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

	// Token: 0x060036B5 RID: 14005 RVA: 0x0013FC18 File Offset: 0x0013DE18
	public void SimulateClickSubtitle()
	{
	}

	// Token: 0x060036B6 RID: 14006 RVA: 0x0013FC1C File Offset: 0x0013DE1C
	public void SimulateClickOption()
	{
	}

	// Token: 0x060036B7 RID: 14007 RVA: 0x0013FC2C File Offset: 0x0013DE2C
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

	// Token: 0x060036B8 RID: 14008 RVA: 0x0013FD2C File Offset: 0x0013DF2C
	private void UpdateByPlotConfig()
	{
		this.ClearOptions();
		this.UpdateCaptionData();
		base.GetButton(0).RootUIComp.Get().SetUIActive(true);
		this.IsShowBlackBg = true;
		base.GetSprite(7).SetUIActive(this.IsShowBlackBg);
	}

	// Token: 0x060036B9 RID: 14009 RVA: 0x0013FD78 File Offset: 0x0013DF78
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

	// Token: 0x060036BA RID: 14010 RVA: 0x0013FEE7 File Offset: 0x0013E0E7
	private void ShowOptions()
	{
		this.CommonLogic.ShowOptions();
	}

	// Token: 0x060036BB RID: 14011 RVA: 0x0013FEF4 File Offset: 0x0013E0F4
	private void ClearOptions()
	{
		this.CommonLogic.ClearOptions();
	}

	// Token: 0x060036BC RID: 14012 RVA: 0x0013FF01 File Offset: 0x0013E101
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

	// Token: 0x060036BD RID: 14013 RVA: 0x0013FF2A File Offset: 0x0013E12A
	[NullableContext(1)]
	private void HandlePortraitVisible(SetHeadIconVisible headIconInfo, Action callback)
	{
		this.CommonLogic.HandlePortraitVisible(this.RootItem, headIconInfo, callback);
	}

	// Token: 0x060036BE RID: 14014 RVA: 0x0013FF40 File Offset: 0x0013E140
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

	// Token: 0x060036BF RID: 14015 RVA: 0x0013FFB4 File Offset: 0x0013E1B4
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

	// Token: 0x060036C0 RID: 14016 RVA: 0x001400D0 File Offset: 0x0013E2D0
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

	// Token: 0x060036C1 RID: 14017 RVA: 0x00140128 File Offset: 0x0013E328
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

	// Token: 0x060036C2 RID: 14018 RVA: 0x0014020F File Offset: 0x0013E40F
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

	// Token: 0x060036C3 RID: 14019 RVA: 0x0014024C File Offset: 0x0013E44C
	private void InitInteractOptions()
	{
		this.CommonLogic.InitInteractOptions();
	}

	// Token: 0x060036C4 RID: 14020 RVA: 0x0014025C File Offset: 0x0013E45C
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

	// Token: 0x060036C5 RID: 14021 RVA: 0x001402E8 File Offset: 0x0013E4E8
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

	// Token: 0x060036C6 RID: 14022 RVA: 0x00140445 File Offset: 0x0013E645
	private void OnOpenView(EUiViewName viewName, int _)
	{
		if (viewName == EUiViewName.PlotReviewView)
		{
			AudioSystem.Instance.PostEvent("plot_review_enter");
		}
	}

	// Token: 0x060036C7 RID: 14023 RVA: 0x00140464 File Offset: 0x0013E664
	private void OnCloseView(EUiViewName viewName, int _)
	{
		if (viewName == EUiViewName.PlotReviewView)
		{
			AudioSystem.Instance.PostEvent("plot_review_exit");
			this.IsVisible = true;
			this.ShowUiExceptPhoto();
		}
	}

	// Token: 0x060036C8 RID: 14024 RVA: 0x00140490 File Offset: 0x0013E690
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

	// Token: 0x060036C9 RID: 14025 RVA: 0x001404C0 File Offset: 0x0013E6C0
	private void ShowWaitingPoint(bool enable)
	{
		base.GetItem(14).SetUIActive(enable);
	}

	// Token: 0x060036CA RID: 14026 RVA: 0x001404D0 File Offset: 0x0013E6D0
	private void RemoveDelayTimer()
	{
		if (TimerSystem.Instance.Has(this.DelayId))
		{
			TimerSystem.Instance.Remove(this.DelayId);
		}
		this.DelayId = null;
	}

	// Token: 0x060036CB RID: 14027 RVA: 0x001404FC File Offset: 0x0013E6FC
	public void RemoveWaitSkipTimer()
	{
		if (TimerSystem.Instance.Has(this.WaitingSkipTimerId))
		{
			TimerSystem.Instance.Remove(this.WaitingSkipTimerId);
		}
		this.WaitingSkipTimerId = null;
	}

	// Token: 0x060036CC RID: 14028 RVA: 0x00140528 File Offset: 0x0013E728
	private void HideAll(bool isHidden)
	{
		this.RootItem.SetUIActive(!isHidden);
	}

	// Token: 0x060036CD RID: 14029 RVA: 0x00140539 File Offset: 0x0013E739
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

	// Token: 0x060036CE RID: 14030 RVA: 0x00140555 File Offset: 0x0013E755
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

	// Token: 0x060036CF RID: 14031 RVA: 0x00140578 File Offset: 0x0013E778
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

	// Token: 0x060036D0 RID: 14032 RVA: 0x001405F8 File Offset: 0x0013E7F8
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

	// Token: 0x060036D1 RID: 14033 RVA: 0x00140658 File Offset: 0x0013E858
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

	// Token: 0x060036D2 RID: 14034 RVA: 0x00140780 File Offset: 0x0013E980
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

	// Token: 0x060036D3 RID: 14035 RVA: 0x00140994 File Offset: 0x0013EB94
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

	// Token: 0x060036D4 RID: 14036 RVA: 0x001409E8 File Offset: 0x0013EBE8
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

	// Token: 0x060036D5 RID: 14037 RVA: 0x00140A34 File Offset: 0x0013EC34
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

	// Token: 0x060036D6 RID: 14038 RVA: 0x00140A88 File Offset: 0x0013EC88
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

	// Token: 0x060036D7 RID: 14039 RVA: 0x00140AD3 File Offset: 0x0013ECD3
	private void AddTickPhoto()
	{
		this.TickPhotoFade = true;
	}

	// Token: 0x060036D8 RID: 14040 RVA: 0x00140ADC File Offset: 0x0013ECDC
	private void RemoveTickPhoto()
	{
		this.TickPhotoFade = false;
	}

	// Token: 0x060036D9 RID: 14041 RVA: 0x00140AE5 File Offset: 0x0013ECE5
	private void AddTickBlackScreen()
	{
		this.TickBlackScreenFade = true;
	}

	// Token: 0x060036DA RID: 14042 RVA: 0x00140AEE File Offset: 0x0013ECEE
	private void RemoveTickBlackScreen()
	{
		this.TickBlackScreenFade = false;
	}

	// Token: 0x060036DB RID: 14043 RVA: 0x00140AF8 File Offset: 0x0013ECF8
	private Number GetCurrentPercentBlackScreen()
	{
		float rangePct = MathUtils.Instance.GetRangePct(0f, 1000f, this.FadeTimeBlackScreen);
		this.BlackBgWidget.SetAlpha(rangePct);
		return rangePct;
	}

	// Token: 0x060036DC RID: 14044 RVA: 0x00140B38 File Offset: 0x0013ED38
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

	// Token: 0x060036DD RID: 14045 RVA: 0x00140C00 File Offset: 0x0013EE00
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

	// Token: 0x060036DE RID: 14046 RVA: 0x00140CAC File Offset: 0x0013EEAC
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

	// Token: 0x060036DF RID: 14047 RVA: 0x00140CF8 File Offset: 0x0013EEF8
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

	// Token: 0x060036E0 RID: 14048 RVA: 0x00140D44 File Offset: 0x0013EF44
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

	// Token: 0x060036E1 RID: 14049 RVA: 0x00140D98 File Offset: 0x0013EF98
	public UniTask CloseChildView()
	{
		ActivityGamePlayPlotView.<CloseChildView>d__114 <CloseChildView>d__;
		<CloseChildView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseChildView>d__.<>4__this = this;
		<CloseChildView>d__.<>1__state = -1;
		<CloseChildView>d__.<>t__builder.Start<ActivityGamePlayPlotView.<CloseChildView>d__114>(ref <CloseChildView>d__);
		return <CloseChildView>d__.<>t__builder.Task;
	}

	// Token: 0x060036E2 RID: 14050 RVA: 0x00140DDC File Offset: 0x0013EFDC
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

	// Token: 0x060036E3 RID: 14051 RVA: 0x00140E44 File Offset: 0x0013F044
	public void RemoveScreenEffectPlotRoot()
	{
		if (this.ScreenEffectPlotRoot != null && this.ScreenEffectPlotRoot.IsValid())
		{
			this.ScreenEffectPlotRoot.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
		}
		this.ScreenEffectPlotRoot = null;
	}

	// Token: 0x060036E4 RID: 14052 RVA: 0x00140E70 File Offset: 0x0013F070
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

	// Token: 0x060036E5 RID: 14053 RVA: 0x00140EA4 File Offset: 0x0013F0A4
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

	// Token: 0x060036E6 RID: 14054 RVA: 0x00140F08 File Offset: 0x0013F108
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

	// Token: 0x060036E7 RID: 14055 RVA: 0x00140F3C File Offset: 0x0013F13C
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

	// Token: 0x060036E8 RID: 14056 RVA: 0x00140F8F File Offset: 0x0013F18F
	private void ClearPlotSubtitle()
	{
		this.ClearPlotView();
		this.CommonLogic.ClearPlotContent(false);
	}

	// Token: 0x060036E9 RID: 14057 RVA: 0x00140FA4 File Offset: 0x0013F1A4
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

	// Token: 0x04002D81 RID: 11649
	private const int FADE_TIME = 1000;

	// Token: 0x04002D82 RID: 11650
	private const float ROTATE_RATE_X = 0.06f;

	// Token: 0x04002D83 RID: 11651
	private const float ROTATE_RATE_Y = 0.03f;

	// Token: 0x04002D84 RID: 11652
	private const float ZOOM_RATE = 1.2f;

	// Token: 0x04002D85 RID: 11653
	[Nullable(1)]
	private const string DEFAULT_PATH = "/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI";

	// Token: 0x04002D86 RID: 11654
	[Nullable(1)]
	private const string CLICK_AUDIO_EVENT = "play_ui_ia_spl_plot_next";

	// Token: 0x04002D87 RID: 11655
	[Nullable(1)]
	protected PopupCaptionItem CaptionItem;

	// Token: 0x04002D88 RID: 11656
	[Nullable(1)]
	public List<PlotOption> CurOption = new List<PlotOption>();

	// Token: 0x04002D89 RID: 11657
	private PlotSkipComponent SkipComp;

	// Token: 0x04002D8A RID: 11658
	private TimerHandle DelayId;

	// Token: 0x04002D8B RID: 11659
	private TimerHandle WaitingSkipTimerId;

	// Token: 0x04002D8C RID: 11660
	public PawnInteractController InteractController;

	// Token: 0x04002D8D RID: 11661
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ITalkItem> PreTalkItems;

	// Token: 0x04002D8E RID: 11662
	private int PreTalkIndex;

	// Token: 0x04002D8F RID: 11663
	private bool CanJumpToNextTalk;

	// Token: 0x04002D90 RID: 11664
	private UUIItem SkipSubtitleTipItem;

	// Token: 0x04002D91 RID: 11665
	private AUIContainerActor ScreenEffectPlotRoot;

	// Token: 0x04002D92 RID: 11666
	private PlotTextCommonLogic CommonLogic;

	// Token: 0x04002D93 RID: 11667
	private bool TickBlackScreenFade;

	// Token: 0x04002D94 RID: 11668
	private bool TickPhotoFade;

	// Token: 0x04002D95 RID: 11669
	private UUITexture BgWidget;

	// Token: 0x04002D96 RID: 11670
	private UUITexture BgWidgetFront;

	// Token: 0x04002D97 RID: 11671
	private UUITexture WidgetMiddle;

	// Token: 0x04002D98 RID: 11672
	private UUISprite BgWidgetMiddle;

	// Token: 0x04002D99 RID: 11673
	private UUISprite BlackBgWidget;

	// Token: 0x04002D9A RID: 11674
	private CustomPromise<bool> PlotFadeShowPromise;

	// Token: 0x04002D9B RID: 11675
	private CustomPromise<bool> PlotFadeHidePromise;

	// Token: 0x04002D9C RID: 11676
	private Action<ITalkItem> PlotViewPhotoCallback;

	// Token: 0x04002D9D RID: 11677
	private Action<ITalkItem> PlotViewBlackScreenCallback;

	// Token: 0x04002D9E RID: 11678
	private Number FadeTimePhoto = 0;

	// Token: 0x04002D9F RID: 11679
	private Number FadeTimeBlackScreen = 0;

	// Token: 0x04002DA0 RID: 11680
	private bool IsFadeInPhoto;

	// Token: 0x04002DA1 RID: 11681
	private bool IsFadeInBlackScreen;

	// Token: 0x04002DA2 RID: 11682
	private bool IsVisible = true;

	// Token: 0x04002DA3 RID: 11683
	private bool IsAlreadyHavePhoto;

	// Token: 0x04002DA4 RID: 11684
	private bool? IsFullPhoto;

	// Token: 0x04002DA5 RID: 11685
	private bool IsShowBlackBg;

	// Token: 0x04002DA6 RID: 11686
	private FVector? CurrentDragPosition;

	// Token: 0x04002DA7 RID: 11687
	private TimerHandle StartDelayTimer;

	// Token: 0x04002DA8 RID: 11688
	[Nullable(1)]
	private readonly Action OnSkip = delegate()
	{
		FlowController.Instance.BackgroundFlow("UI点击跳过(PlotView)", true, false, false);
	};

	// Token: 0x04002DA9 RID: 11689
	private readonly Action OnSkipPop;

	// Token: 0x04002DAA RID: 11690
	private readonly Action OnSkipCancel;

	// Token: 0x04002DAB RID: 11691
	private PlotChildView ChildView;

	// Token: 0x04002DAC RID: 11692
	[Nullable(1)]
	private string ChildViewName = "";

	// Token: 0x02006718 RID: 26392
	[NullableContext(0)]
	private class EPlotChildCom
	{
		// Token: 0x040220E9 RID: 139497
		public const int BtnNextPage = 0;

		// Token: 0x040220EA RID: 139498
		public const int PlotText = 1;

		// Token: 0x040220EB RID: 139499
		public const int NPCName = 2;

		// Token: 0x040220EC RID: 139500
		public const int TxtList = 3;

		// Token: 0x040220ED RID: 139501
		public const int OptionItem = 4;

		// Token: 0x040220EE RID: 139502
		public const int OptionLayout = 5;

		// Token: 0x040220EF RID: 139503
		public const int TextList = 6;

		// Token: 0x040220F0 RID: 139504
		public const int PlotBg = 7;

		// Token: 0x040220F1 RID: 139505
		public const int PlotTextUHD = 8;

		// Token: 0x040220F2 RID: 139506
		public const int PanelLine = 9;

		// Token: 0x040220F3 RID: 139507
		public const int TxtFloat = 10;

		// Token: 0x040220F4 RID: 139508
		public const int ScreenEffect = 11;

		// Token: 0x040220F5 RID: 139509
		public const int NPCTitle = 12;

		// Token: 0x040220F6 RID: 139510
		public const int NextIcon = 13;

		// Token: 0x040220F7 RID: 139511
		public const int WaitingPoint = 14;

		// Token: 0x040220F8 RID: 139512
		public const int BlackScreenBg = 15;

		// Token: 0x040220F9 RID: 139513
		public const int PhotoScreenBg = 16;

		// Token: 0x040220FA RID: 139514
		public const int PhotoScreenBgFront = 17;

		// Token: 0x040220FB RID: 139515
		public const int DoingText = 18;

		// Token: 0x040220FC RID: 139516
		public const int PhotoScreenMiddle = 19;

		// Token: 0x040220FD RID: 139517
		public const int PhotoScreenBgMiddle = 20;

		// Token: 0x040220FE RID: 139518
		public const int TextScrollView = 21;

		// Token: 0x040220FF RID: 139519
		public const int OptionAdjustItem = 22;

		// Token: 0x04022100 RID: 139520
		public const int PnlBg = 23;

		// Token: 0x04022101 RID: 139521
		public const int PnlInfo = 24;

		// Token: 0x04022102 RID: 139522
		public const int SonUi = 25;

		// Token: 0x04022103 RID: 139523
		public const int BlockOption = 26;

		// Token: 0x04022104 RID: 139524
		public const int OptionLimitBar = 27;

		// Token: 0x04022105 RID: 139525
		public const int Caption = 28;
	}
}
