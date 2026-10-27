using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Data.Sequence.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
using AkiClient.Game.Aki.Sequence.Manager;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.MovieMode;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using CSharpScript.Game.Module.Plot.Sequence;
using CSharpScript.Game.Module.Plot.Sequence.Assistant;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002977 RID: 10615
[NullableContext(2)]
[Nullable(0)]
public class PlotSubtitleView : UiTickViewBase, ISimulatePlot
{
	// Token: 0x06015F3E RID: 89918 RVA: 0x00588DAC File Offset: 0x00586FAC
	[NullableContext(1)]
	public PlotSubtitleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015F3F RID: 89919 RVA: 0x00588E5C File Offset: 0x0058705C
	private void ShowBlackBg(bool isShow, bool useAnim = true)
	{
		if (isShow == this.IsBlackBgShow)
		{
			return;
		}
		this.IsBlackBgShow = isShow;
		if (isShow)
		{
			base.GetSprite(9).SetUIActive(true);
			if (useAnim)
			{
				this.UiViewSequence.StopSequenceByKey("PlotClose", false, false);
				base.PlaySequence("PlotStart", null, false);
				return;
			}
		}
		else
		{
			if (useAnim)
			{
				this.UiViewSequence.StopSequenceByKey("PlotStart", false, false);
				base.PlaySequence("PlotClose", null, false);
				return;
			}
			base.GetSprite(9).SetUIActive(false);
		}
	}

	// Token: 0x17001D88 RID: 7560
	// (get) Token: 0x06015F40 RID: 89920 RVA: 0x00588EDF File Offset: 0x005870DF
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
			GenericLayout<PlotOptionItem, object> optionLayout = this.OptionLayout;
			List<PlotOptionItem> list = (optionLayout != null) ? optionLayout.GetLayoutItemList() : null;
			if (list == null)
			{
				return null;
			}
			return list.ToArray();
		}
	}

	// Token: 0x17001D89 RID: 7561
	// (get) Token: 0x06015F41 RID: 89921 RVA: 0x00588EFE File Offset: 0x005870FE
	public ITalkItem CurrentSubtitle
	{
		get
		{
			SubtitleInfo subtitleInfo = this.SubtitleInfo;
			if (subtitleInfo == null)
			{
				return null;
			}
			return subtitleInfo.CurrentConfig;
		}
	}

	// Token: 0x06015F42 RID: 89922 RVA: 0x00588F14 File Offset: 0x00587114
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
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnSubtitleSkipClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnAutoClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(18, new Action(this.OnBtnHideClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(33, new Action(this.OnBtnReviewClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06015F43 RID: 89923 RVA: 0x00589708 File Offset: 0x00587908
	protected override void OnStart()
	{
		base.GetButton(2).RootUIComp.Get().SetUIActive(false);
		this.SkipComp = new PlotSkipComponent(base.GetButton(2), new Action(this.OnSkip), new Action(this.OnSkipPop), null, new Action(this.OnSkipCancel), null, null);
		this.SkipComp.EnableSkipButton(false);
		UUIText text = base.GetText(42);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		base.GetButton(33).RootUIComp.Get().SetUIActive(false);
		this.ReviewComp = new PlotReviewComponent(base.GetButton(33), new Action(this.OnBtnReviewClick));
		this.ReviewComp.EnableReviewButton(false);
		base.GetSprite(21).SetAlpha(0f);
		this.SubtitleInfo = new SubtitleInfo();
		this.OptionLayout = new GenericLayout<PlotOptionItem, object>(base.GetLayoutBase(7), new Func<PlotOptionItem>(this.InitOptionItem), base.GetItem(6).GetOwner() as AUIBaseActor, false, true);
		this.OptionLayout.SetActive(false);
		UUIItem item = base.GetItem(45);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.IsOptionShow = false;
		this.SubtitleAnimation = (base.GetItem(8).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
		this.SubtitleAnimDataComp = (base.GetItem(8).GetOwner().GetComponentByClass(UUIEffectTextAnimation.StaticClass()) as UUIEffectTextAnimation);
		base.GetItem(6).SetUIActive(false);
		base.GetItem(24).SetUIActive(false);
		this.OptionLimitBar = base.GetSlider(34);
		this.AutoSelectTimeBar = base.GetSlider(49);
		this.AutoSelectTimeBar.GetRootComponent().SetUIActive(false);
		this.AutoSelectOptionComponent.Init(new PlotAutoSelectOptionComponentContext
		{
			OptionLimitBar = this.OptionLimitBar,
			AutoSelectTimeBar = this.AutoSelectTimeBar,
			ImportantList = base.GetItem(44),
			ImportantOptionTipsIcon = base.GetTexture(47),
			ImportantOptionTipsText = base.GetText(48),
			GetCurrentContentDelegate = (() => this.CurrentSubtitle),
			GetSelectedOptionDelegate = (() => this.SelectedPlotOptionItem),
			GetOptionItemsDelegate = (() => this.Options),
			GetAudioRemainingTimeDelegate = new Func<float>(this.GetCurrentAudioRemainingTime),
			SelectOptionByIndexDelegate = new Action<int>(this.SelectOptionByIndex),
			SetTextureByPathDelegate = delegate(string path, UUITexture texture)
			{
				base.SetTextureByPath(path, texture, null, null);
			},
			RefreshAutoPlayButtonDelegate = delegate
			{
				this.UpdateAutoPlayButton();
			}
		});
		this.IsBlackBgShow = false;
		base.GetSprite(9).SetUIActive(false);
		this.SkipSubtitleTipItem = base.GetItem(19);
		this.SkipSubtitleTipItemNew = base.GetItem(53);
		this.PlotTextInitialAnchorY = base.GetItem(3).GetAnchorOffsetY();
		(base.GetButton(1).RootUIComp.Get().GetOwner().GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent).SetActive(false, false);
		this.SkipSubtitleTipItemActive(false);
		this.ShowWaitingPoint(false);
		this.UpdateByPlotConfig();
		this.IsCurSubtitlePaused = false;
		this.AddScreenEffectPlotRoot();
		this.IsVisible = true;
		this.AudioDelegate.Init(new Action<float>(this.CallBackDuration));
		this.UiViewSequence.AddSequenceFinishEvent("ChoiceClose", new Action<string>(this.OptionsLayoutHide), false);
		UUIScrollViewComponent scrollView = base.GetScrollView(27);
		if (scrollView != null)
		{
			scrollView.SetCanScroll(false);
		}
		if (scrollView != null)
		{
			scrollView.SetRayCastTargetForScrollView(false);
		}
		float? num;
		if (scrollView == null)
		{
			num = null;
		}
		else
		{
			UUIItem uuiitem = scrollView.RootUIComp.Get();
			num = ((uuiitem != null) ? new float?(uuiitem.GetHeight()) : null);
		}
		float? num2 = num;
		this.TextScrollViewPrefabHeight = num2.GetValueOrDefault(174f);
		this.FadeTimePhoto = 0f;
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
		this.SonUi = base.GetItem(31);
		this.FullscreenAdaptAnchor = base.GetItem(43);
		base.GetItem(32).SetUIActive(false);
		this.InitTweenAnim(36);
		this.InitTweenAnim(37);
		this.InitTweenAnim(38);
		this.InitTweenAnim(39);
		this.InitTweenAnim(40);
		this.InitTweenAnim(41);
		this.InitTweenAnim(51);
		this.InitTweenAnim(52);
		UiParam uiParam = this.OpenParam as UiParam;
		if (uiParam != null && uiParam.HideAllUi.GetValueOrDefault())
		{
			this.OnBtnHideClick();
		}
		Queue<PlotChildView> sonUiQueue = this.SonUiQueue;
		if (sonUiQueue != null)
		{
			sonUiQueue.Clear();
		}
		this.SonUiQueue = new Queue<PlotChildView>(4);
		Queue<SpineQueueInfo> spineQueue = this.SpineQueue;
		if (spineQueue != null)
		{
			spineQueue.Clear();
		}
		this.SpineQueue = new Queue<SpineQueueInfo>(4);
	}

	// Token: 0x06015F44 RID: 89924 RVA: 0x00589C54 File Offset: 0x00587E54
	[NullableContext(1)]
	private void OptionsLayoutHide(string _)
	{
		if (this.IsOptionShow)
		{
			return;
		}
		this.OptionLayout.SetActive(false);
		UUIItem item = base.GetItem(45);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.OptionLimitBar.GetRootComponent().SetUIActive(false);
		this.AutoSelectTimeBar.GetRootComponent().SetUIActive(false);
	}

	// Token: 0x06015F45 RID: 89925 RVA: 0x00589CAC File Offset: 0x00587EAC
	protected void ResetSubtitle()
	{
		UUIScrollViewComponent scrollView = base.GetScrollView(27);
		if (scrollView != null)
		{
			scrollView.SetScrollProgress(0f);
		}
		TimerHandle scrollStartTimer = this.ScrollStartTimer;
		if (scrollStartTimer != null)
		{
			scrollStartTimer.Remove();
		}
		this.ScrollStartTimer = null;
		this.RemoveTextAnimTimer();
		base.GetText(4).SetText("", true);
		base.GetText(4).SetUIActive(false);
		base.GetText(17).SetText("", true);
		base.GetText(17).SetUIActive(false);
		base.GetItem(11).SetUIActive(false);
		base.GetText(5).SetText("", true);
		base.GetText(12).SetText("", true);
		base.GetText(5).SetUIActive(false);
		base.GetText(12).SetUIActive(false);
	}

	// Token: 0x06015F46 RID: 89926 RVA: 0x00589D7E File Offset: 0x00587F7E
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

	// Token: 0x06015F47 RID: 89927 RVA: 0x00589DB8 File Offset: 0x00587FB8
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		PlotSubtitleView.<OnPlayingStartSequenceAsync>d__85 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PlotSubtitleView.<OnPlayingStartSequenceAsync>d__85>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015F48 RID: 89928 RVA: 0x00589DFC File Offset: 0x00587FFC
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Emit<EUiViewName, bool>(EEventName.PlotViewChange, this.ViewInfo.Name, false);
		TimerHandle blockOptionTimer = this.BlockOptionTimer;
		if (blockOptionTimer != null)
		{
			blockOptionTimer.Remove();
		}
		this.BlockOptionTimer = null;
		base.GetItem(32).SetUIActive(false);
		this.AutoSelectOptionComponent.Clear();
		this.ClearPendingImmersiveSleep();
	}

	// Token: 0x06015F49 RID: 89929 RVA: 0x00589E60 File Offset: 0x00588060
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		PlotSubtitleView.<OnPlayingCloseSequenceAsync>d__87 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PlotSubtitleView.<OnPlayingCloseSequenceAsync>d__87>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015F4A RID: 89930 RVA: 0x00589EA4 File Offset: 0x005880A4
	protected override void OnBeforeDestroy()
	{
		PlotModel.Instance.OptionEnable = true;
		this.ClearPendingImmersiveSleep();
		this.ClearSizeChangedTimer();
		this.AudioDelegate.Clear();
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
		this.PlotFadeShowPromise = null;
		this.PlotFadeHidePromise = null;
		base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI", this.BgWidget, null, null);
		base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI", this.BgWidgetFront, null, null);
		base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI", this.WidgetMiddle, null, null);
		this.IsAlreadyHavePhoto = false;
		this.FadeTimePhoto = 0f;
		this.RemoveTickPhoto();
		this.RemoveScreenEffectPlotRoot();
		TimerHandle scrollStartTimer = this.ScrollStartTimer;
		if (scrollStartTimer != null)
		{
			scrollStartTimer.Remove();
		}
		this.ScrollStartTimer = null;
		this.RemoveTextAnimTimer();
		this.AutoSelectOptionComponent.Clear();
		this.CloseTransitionView();
		this.HandleAkEvent(false);
		this.StopCurSubtitleAudio();
		this.RemoveAutoPlayDelay();
		this.StopIndependentAudio();
		this.StopWaitingSkipTimer();
		Dictionary<string, PlotChildView> sonUiIncludeMap = this.SonUiIncludeMap;
		if (sonUiIncludeMap != null)
		{
			sonUiIncludeMap.Clear();
		}
		this.SonUiIncludeMap = null;
		this.SonUiInclude = null;
		Queue<SpineQueueInfo> spineQueue = this.SpineQueue;
		if (spineQueue != null)
		{
			spineQueue.Clear();
		}
		this.SpineQueue = null;
		Queue<PlotChildView> sonUiQueue = this.SonUiQueue;
		if (sonUiQueue != null)
		{
			sonUiQueue.Clear();
		}
		this.SonUiQueue = null;
		this.SonUi = null;
	}

	// Token: 0x06015F4B RID: 89931 RVA: 0x0058A025 File Offset: 0x00588225
	[NullableContext(1)]
	private PlotOptionItem InitOptionItem()
	{
		PlotOptionItem plotOptionItem = new PlotOptionItem(this);
		plotOptionItem.BindOnHover(new Action<PlotOptionItem>(this.OnPlotOptionItemHover));
		return plotOptionItem;
	}

	// Token: 0x06015F4C RID: 89932 RVA: 0x0058A03F File Offset: 0x0058823F
	[NullableContext(1)]
	private void OnPlotOptionItemHover(PlotOptionItem plotOptionItem)
	{
		PlotOptionItem selectedPlotOptionItem = this.SelectedPlotOptionItem;
		if (selectedPlotOptionItem != null)
		{
			selectedPlotOptionItem.SetSelectedDisplay(false);
		}
		this.SelectedPlotOptionItem = plotOptionItem;
		plotOptionItem.SetSelectedDisplay(true);
		this.AutoSelectOptionComponent.OnSelectedOptionChanged();
	}

	// Token: 0x06015F4D RID: 89933 RVA: 0x0058A06C File Offset: 0x0058826C
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

	// Token: 0x06015F4E RID: 89934 RVA: 0x0058A0D0 File Offset: 0x005882D0
	private void ShowWaitingPoint(bool enable)
	{
		bool uiactive = enable && !PlotModel.Instance.IsNewSubtitleStyleActive();
		base.GetItem(20).SetUIActive(uiactive);
		if (this.SubtitleLevel.GetValueOrDefault() == EPlotLevel.LevelB)
		{
			TermExplanationController.Instance.SetEnableHyperLink(base.GetText(5), !enable);
		}
	}

	// Token: 0x06015F4F RID: 89935 RVA: 0x0058A122 File Offset: 0x00588322
	[NullableContext(1)]
	private void OnMovieModeAspectOffsetChanged(IMovieModeAspectOffset _)
	{
		this.UpdatePlotTextOffset();
	}

	// Token: 0x06015F50 RID: 89936 RVA: 0x0058A12A File Offset: 0x0058832A
	private void OnMovieModeAspectOffsetChanged(bool _, IMovieModeAspectOffset __)
	{
		this.UpdatePlotTextOffset();
	}

	// Token: 0x06015F51 RID: 89937 RVA: 0x0058A134 File Offset: 0x00588334
	private void UpdatePlotTextOffset()
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		bool flag = PlotModel.Instance.IsNewSubtitleStyleActive() && (SequenceModel.Instance.IsConstrainAspectActive || MovieModeController.Instance.IsHorizontalBlackBarsVisible());
		item.SetAnchorOffsetY(this.PlotTextInitialAnchorY + (flag ? -28f : 0f));
	}

	// Token: 0x06015F52 RID: 89938 RVA: 0x0058A194 File Offset: 0x00588394
	private void UpdateByPlotConfig()
	{
		PlotConfig plotConfig = PlotModel.Instance.PlotConfig;
		bool canPause = plotConfig.CanPause;
		this.CanShowAutoButtonByPlotConfig = canPause;
		this.CanShowHideButtonByPlotConfig = canPause;
		this.CanShowReviewButtonByPlotConfig = canPause;
		this.SubtitleLevel = plotConfig.SubtitleLevel;
		this.Level = plotConfig.PlotLevel;
		base.GetButton(0).RootUIComp.Get().SetUIActive(this.CanShowAutoButtonByPlotConfig);
		base.GetButton(18).RootUIComp.Get().SetUIActive(this.CanShowHideButtonByPlotConfig);
		this.ReviewComp.EnableReviewButton(this.CanShowReviewButtonByPlotConfig);
		base.GetButton(1).RootUIComp.Get().SetUIActive(this.SubtitleLevel.GetValueOrDefault() == EPlotLevel.LevelB);
		this.ClearOptions();
		this.UpdateAutoPlayButton();
		this.ResetSubtitle();
		this.DisableInteractSources.Clear();
		this.DisableSkipSources.Clear();
		this.RestorePlotButtonsVisibility();
		this.UpdatePlotTextOffset();
	}

	// Token: 0x06015F53 RID: 89939 RVA: 0x0058A28C File Offset: 0x0058848C
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

	// Token: 0x06015F54 RID: 89940 RVA: 0x0058A300 File Offset: 0x00588500
	private void UpdateAutoSelectText()
	{
		UUIText text = base.GetText(50);
		if (text == null)
		{
			return;
		}
		PlotConfig plotConfig = PlotModel.Instance.PlotConfig;
		bool flag = Info.Instance.IsInGamepad() && plotConfig.CanPause && this.DisableInteractSources.Count == 0;
		text.SetUIActive(flag);
		if (!flag)
		{
			return;
		}
		string autoSelectTextKey = this.GetAutoSelectTextKey(plotConfig.AutoPlayState);
		text.SetText(ConfigMultiTextLang.GetLocalTextNew(autoSelectTextKey, null) ?? autoSelectTextKey, true);
	}

	// Token: 0x06015F55 RID: 89941 RVA: 0x0058A376 File Offset: 0x00588576
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

	// Token: 0x06015F56 RID: 89942 RVA: 0x0058A3A4 File Offset: 0x005885A4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.PlotConfigChanged, new Action(this.OnPlotConfigChanged));
		EventSystem.Instance.Add(EEventName.ClearPlotSubtitle, new Action(this.ClearPlotSubtitle));
		EventSystem.Instance.Add<bool>(EEventName.HidePlotUi, new Action<bool>(this.HideAll));
		EventSystem.Instance.Add<bool, FKey>(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
		EventSystem.Instance.Add<bool>(EEventName.PlotDoingTextShow, new Action<bool>(this.ShowDoingText));
		EventSystem.Instance.Add<ShowTalk>(EEventName.PlotStartShowTalk, new Action<ShowTalk>(this.OnShowTalkStart));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Add<ETermExplanationViewType>(EEventName.OnTermExplanationViewOpening, new Action<ETermExplanationViewType>(this.OnTermExplanationViewOpen));
		EventSystem.Instance.Add(EEventName.OnTermExplanationViewClosed, new Action(this.OnTermExplanationViewClose));
		EventSystem.Instance.Add<float>(EEventName.PlotSequencePlay, new Action<float>(this.OnSequenceStart));
		EventSystem.Instance.Add<bool, bool?, string>(EEventName.EnableInteractPlot, new Action<bool, bool?, string>(this.OnEnableInteractPlot));
		EventSystem.Instance.Add<bool, string>(EEventName.EnableSkipPlotByReason, new Action<bool, string>(this.OnEnableSkipPlotByReason));
		EventSystem.Instance.Add<EInputControllerMainType, bool>(EEventName.OnImmersiveInputStateChange, new Action<EInputControllerMainType, bool>(this.OnImmersiveInputStateChange));
		EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnSizeChanged));
		EventSystem.Instance.Add<IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetUpdate, new Action<IMovieModeAspectOffset>(this.OnMovieModeAspectOffsetChanged));
		EventSystem.Instance.Add<bool, IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetApply, new Action<bool, IMovieModeAspectOffset>(this.OnMovieModeAspectOffsetChanged));
		SequenceController.Instance.Event.Add(ESequenceEventName.UpdateSeqSubtitle, new Action<PlotSubtitleConfig>(this.UpdateSeqSubtitle));
		SequenceController.Instance.Event.Add(ESequenceEventName.HandlePlotOptionSelected, new Action<int>(this.HandleSelectedPlotOption));
		SequenceController.Instance.Event.Add(ESequenceEventName.HandleSeqSubtitleEnd, new Action<int, bool>(this.HandleSeqSubtitleEnd));
		SequenceController.Instance.Event.Add(ESequenceEventName.HandleSubSequenceStop, new Action(this.HandleSubSequenceStop));
		SequenceController.Instance.Event.Add(ESequenceEventName.HandleIndependentSeqAudio, new Action<bool, string, float>(this.HandleIndependentSeqAudio));
		this.SkipComp.AddEventListener();
		EventSystem.Instance.Add<bool>(EEventName.EnableSkipPlot, new Action<bool>(this.OnEnableSkipPlotRestoreTween));
		InputDistributeController.Instance.BindTouch(0, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouchPlotVisible));
		UUIItem item = base.GetItem(3);
		TermExplanationController.Instance.RegisterTextHyperlink(base.GetText(5), ETermExplanationViewType.Center, ETermExplanationReportType.Plot, ETermExplanationViewAttachDirection.Up, item, delegate
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("TermClickTip", Array.Empty<object>());
		}, null, ETermExplanationGroup.Default, 0, ETermExplanationViewStyle.Default);
	}

	// Token: 0x06015F57 RID: 89943 RVA: 0x0058A6B8 File Offset: 0x005888B8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PlotConfigChanged, new Action(this.OnPlotConfigChanged));
		EventSystem.Instance.Remove(EEventName.ClearPlotSubtitle, new Action(this.ClearPlotSubtitle));
		EventSystem.Instance.Remove<bool>(EEventName.HidePlotUi, new Action<bool>(this.HideAll));
		EventSystem.Instance.Remove<bool, FKey>(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnInputAnyKey));
		EventSystem.Instance.Remove<bool>(EEventName.PlotDoingTextShow, new Action<bool>(this.ShowDoingText));
		EventSystem.Instance.Remove<ShowTalk>(EEventName.PlotStartShowTalk, new Action<ShowTalk>(this.OnShowTalkStart));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Remove<ETermExplanationViewType>(EEventName.OnTermExplanationViewOpening, new Action<ETermExplanationViewType>(this.OnTermExplanationViewOpen));
		EventSystem.Instance.Remove(EEventName.OnTermExplanationViewClosed, new Action(this.OnTermExplanationViewClose));
		EventSystem.Instance.Remove<float>(EEventName.PlotSequencePlay, new Action<float>(this.OnSequenceStart));
		EventSystem.Instance.Remove<bool, bool?, string>(EEventName.EnableInteractPlot, new Action<bool, bool?, string>(this.OnEnableInteractPlot));
		EventSystem.Instance.Remove<bool, string>(EEventName.EnableSkipPlotByReason, new Action<bool, string>(this.OnEnableSkipPlotByReason));
		EventSystem.Instance.Remove<EInputControllerMainType, bool>(EEventName.OnImmersiveInputStateChange, new Action<EInputControllerMainType, bool>(this.OnImmersiveInputStateChange));
		EventSystem.Instance.Remove<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnSizeChanged));
		EventSystem.Instance.Remove<IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetUpdate, new Action<IMovieModeAspectOffset>(this.OnMovieModeAspectOffsetChanged));
		EventSystem.Instance.Remove<bool, IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetApply, new Action<bool, IMovieModeAspectOffset>(this.OnMovieModeAspectOffsetChanged));
		this.ClearSizeChangedTimer();
		SequenceController.Instance.Event.Remove(ESequenceEventName.UpdateSeqSubtitle, new Action<PlotSubtitleConfig>(this.UpdateSeqSubtitle));
		SequenceController.Instance.Event.Remove(ESequenceEventName.HandlePlotOptionSelected, new Action<int>(this.HandleSelectedPlotOption));
		SequenceController.Instance.Event.Remove(ESequenceEventName.HandleSeqSubtitleEnd, new Action<int, bool>(this.HandleSeqSubtitleEnd));
		SequenceController.Instance.Event.Remove(ESequenceEventName.HandleSubSequenceStop, new Action(this.HandleSubSequenceStop));
		SequenceController.Instance.Event.Remove(ESequenceEventName.HandleIndependentSeqAudio, new Action<bool, string, float>(this.HandleIndependentSeqAudio));
		this.SkipComp.RemoveEventListener();
		EventSystem.Instance.Remove<bool>(EEventName.EnableSkipPlot, new Action<bool>(this.OnEnableSkipPlotRestoreTween));
		InputDistributeController.Instance.UnBindTouch(0, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouchPlotVisible));
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(5));
	}

	// Token: 0x06015F58 RID: 89944 RVA: 0x0058A99C File Offset: 0x00588B9C
	private void OnSizeChanged()
	{
		if (base.IsDestroyOrDestroying)
		{
			return;
		}
		UUIItem rootItem = this.RootItem;
		ULGUICanvas ulguicanvas = (rootItem != null && rootItem.IsValid()) ? rootItem.GetRenderCanvas() : null;
		if (ulguicanvas == null)
		{
			return;
		}
		this.ClearSizeChangedTimer();
		ulguicanvas.bPostTickUpdate = true;
		this.SizeChangedTimerId = TimerSystem.Instance.Next(delegate(float _)
		{
			this.SizeChangedTimerId = null;
			if (base.IsDestroyOrDestroying)
			{
				return;
			}
			UUIItem rootItem2 = this.RootItem;
			ULGUICanvas ulguicanvas2 = (rootItem2 != null && rootItem2.IsValid()) ? rootItem2.GetRenderCanvas() : null;
			if (ulguicanvas2 != null)
			{
				ulguicanvas2.bPostTickUpdate = false;
			}
		}, null, null);
	}

	// Token: 0x06015F59 RID: 89945 RVA: 0x0058AA00 File Offset: 0x00588C00
	private void ClearSizeChangedTimer()
	{
		TimerHandle sizeChangedTimerId = this.SizeChangedTimerId;
		if (sizeChangedTimerId != null)
		{
			sizeChangedTimerId.Remove();
		}
		this.SizeChangedTimerId = null;
		UUIItem rootItem = this.RootItem;
		ULGUICanvas ulguicanvas = (rootItem != null && rootItem.IsValid()) ? rootItem.GetRenderCanvas() : null;
		if (ulguicanvas != null)
		{
			ulguicanvas.bPostTickUpdate = false;
		}
	}

	// Token: 0x06015F5A RID: 89946 RVA: 0x0058AA4C File Offset: 0x00588C4C
	private void OnEnableInteractPlot(bool enable, bool? includeSubtitleButton, string reason)
	{
		bool valueOrDefault = includeSubtitleButton.GetValueOrDefault(true);
		string key = string.IsNullOrEmpty(reason) ? "Default" : reason;
		if (enable)
		{
			this.DisableInteractSources.Remove(key);
		}
		else
		{
			this.DisableInteractSources[key] = valueOrDefault;
		}
		this.ApplyInteractPlotState();
	}

	// Token: 0x06015F5B RID: 89947 RVA: 0x0058AA98 File Offset: 0x00588C98
	[NullableContext(1)]
	private void OnEnableSkipPlotByReason(bool enable, string reason)
	{
		string item = string.IsNullOrEmpty(reason) ? "Default" : reason;
		if (enable)
		{
			this.DisableSkipSources.Remove(item);
		}
		else
		{
			this.DisableSkipSources.Add(item);
		}
		this.ApplySkipButtonState();
	}

	// Token: 0x06015F5C RID: 89948 RVA: 0x0058AADB File Offset: 0x00588CDB
	private void ApplySkipButtonState()
	{
		this.SkipComp.EnableSkipButton(this.DisableInteractSources.Count == 0 && this.DisableSkipSources.Count == 0);
		this.RestorePlotButtonsVisibility();
	}

	// Token: 0x06015F5D RID: 89949 RVA: 0x0058AB0C File Offset: 0x00588D0C
	private void ApplyInteractPlotState()
	{
		bool flag = this.DisableInteractSources.Count > 0;
		bool flag2 = false;
		foreach (KeyValuePair<string, bool> keyValuePair in this.DisableInteractSources)
		{
			if (keyValuePair.Value)
			{
				flag2 = true;
				break;
			}
		}
		bool flag3 = !flag;
		this.MuteAutoPlay(!flag3);
		base.GetButton(0).RootUIComp.Get().SetUIActive(flag3 && this.CanShowAutoButtonByPlotConfig);
		UUIText text = base.GetText(50);
		if (text != null)
		{
			text.SetUIActive(flag3 && Info.Instance.IsInGamepad() && this.CanShowAutoButtonByPlotConfig);
		}
		base.GetButton(18).RootUIComp.Get().SetUIActive(flag3 && this.CanShowHideButtonByPlotConfig);
		this.ReviewComp.EnableReviewButton(flag3 && this.CanShowReviewButtonByPlotConfig);
		this.SkipComp.EnableSkipButton(flag3 && this.DisableSkipSources.Count == 0);
		base.GetButton(1).RootUIComp.Get().SetUIActive(!flag2);
		this.RestorePlotButtonsVisibility();
	}

	// Token: 0x06015F5E RID: 89950 RVA: 0x0058AC58 File Offset: 0x00588E58
	private void OnSequenceStart(float viewBlendDuration)
	{
		float num = viewBlendDuration * 1000f;
		if (num > 20f && num < 180000f)
		{
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
			base.GetButton(18).RootUIComp.Get().SetUIActive(false);
			this.ReviewComp.EnableReviewButton(false);
			base.GetButton(1).RootUIComp.Get().SetUIActive(false);
			TimerSystem.Instance.Delay(delegate(float _)
			{
				this.UpdateByPlotConfig();
			}, num, null, null, true, 1f);
		}
	}

	// Token: 0x06015F5F RID: 89951 RVA: 0x0058ACFC File Offset: 0x00588EFC
	private void OnTermExplanationViewOpen(ETermExplanationViewType _)
	{
		this.MuteAutoPlay(true);
	}

	// Token: 0x06015F60 RID: 89952 RVA: 0x0058AD05 File Offset: 0x00588F05
	private void OnTermExplanationViewClose()
	{
		this.MuteAutoPlay(false);
	}

	// Token: 0x06015F61 RID: 89953 RVA: 0x0058AD10 File Offset: 0x00588F10
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

	// Token: 0x06015F62 RID: 89954 RVA: 0x0058AD6C File Offset: 0x00588F6C
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
		this.AutoSelectOptionComponent.OnImmersiveInputStateChange();
	}

	// Token: 0x06015F63 RID: 89955 RVA: 0x0058ADCC File Offset: 0x00588FCC
	private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
	{
		this.UpdateAutoSelectText();
		if (this.SubtitleLevel.GetValueOrDefault() != EPlotLevel.LevelB || !PlotModel.Instance.IsUseNewLevelBStyle())
		{
			return;
		}
		UUIItem item = base.GetItem(45);
		if (item != null)
		{
			item.SetAnchorOffsetY(PlotSubtitleView.GetPnlLayout02OffsetY(now));
		}
	}

	// Token: 0x06015F64 RID: 89956 RVA: 0x0058AE12 File Offset: 0x00589012
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

	// Token: 0x06015F65 RID: 89957 RVA: 0x0058AE2D File Offset: 0x0058902D
	private void OnEnableSkipPlotRestoreTween(bool _)
	{
		this.RestorePlotButtonsVisibility();
	}

	// Token: 0x06015F66 RID: 89958 RVA: 0x0058AE35 File Offset: 0x00589035
	private void ClearPendingImmersiveSleep()
	{
		this.PendingImmersiveSleep = false;
		if (this.PendingImmersiveSleepTimerId != null && TimerSystem.Instance.Has(this.PendingImmersiveSleepTimerId))
		{
			TimerSystem.Instance.Remove(this.PendingImmersiveSleepTimerId);
		}
		this.PendingImmersiveSleepTimerId = null;
	}

	// Token: 0x06015F67 RID: 89959 RVA: 0x0058AE70 File Offset: 0x00589070
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

	// Token: 0x06015F68 RID: 89960 RVA: 0x0058AEF4 File Offset: 0x005890F4
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
		this.TweenAnimMap[componentType] = list;
	}

	// Token: 0x06015F69 RID: 89961 RVA: 0x0058AF68 File Offset: 0x00589168
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

	// Token: 0x06015F6A RID: 89962 RVA: 0x0058AFC4 File Offset: 0x005891C4
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

	// Token: 0x06015F6B RID: 89963 RVA: 0x0058B020 File Offset: 0x00589220
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

	// Token: 0x06015F6C RID: 89964 RVA: 0x0058B144 File Offset: 0x00589344
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

	// Token: 0x06015F6D RID: 89965 RVA: 0x0058B250 File Offset: 0x00589450
	private void MuteAutoPlay(bool isMute)
	{
		if (isMute)
		{
			this.MuteTimeLimitedOption = true;
			PlotModel.Instance.PlotConfig.AutoPlayState = EAutoPlayState.Manual;
			this.UpdateAutoPlayButton();
			this.AutoSelectOptionComponent.OnAutoPlayStateChanged();
			return;
		}
		this.MuteTimeLimitedOption = false;
		PlotConfig plotConfig = PlotModel.Instance.PlotConfig;
		plotConfig.AutoPlayState = plotConfig.AutoPlayStateCache;
		this.UpdateAutoPlayButton();
		this.AutoSelectOptionComponent.OnAutoPlayStateChanged();
		if (plotConfig.AutoPlayState != EAutoPlayState.Manual && SequenceModel.Instance.IsPlaying && SequenceModel.Instance.IsPaused.GetValueOrDefault() && (!this.SubtitleInfo.HasSubtitle() || !this.SubtitleInfo.HasOption))
		{
			this.ResumeSequence("Subtitle");
		}
	}

	// Token: 0x06015F6E RID: 89966 RVA: 0x0058B300 File Offset: 0x00589500
	[NullableContext(1)]
	private void OnShowTalkStart(ShowTalk inShowTalk)
	{
		this.ShowBlackBg(false, false);
		PlotSkipComponent skipComp = this.SkipComp;
		if (skipComp == null)
		{
			return;
		}
		skipComp.AddSummary(inShowTalk.TalkOutline);
	}

	// Token: 0x06015F6F RID: 89967 RVA: 0x0058B320 File Offset: 0x00589520
	private void OnPlotConfigChanged()
	{
		this.UpdateByPlotConfig();
	}

	// Token: 0x06015F70 RID: 89968 RVA: 0x0058B328 File Offset: 0x00589528
	private void OnSkip()
	{
		this.MuteAutoPlay(false);
		this.ShowUiExceptPhoto();
		FlowController.Instance.BackgroundFlow("UI点击跳过(PlotSubtitleView)", true, false, true);
	}

	// Token: 0x06015F71 RID: 89969 RVA: 0x0058B349 File Offset: 0x00589549
	private void ShowDoingText(bool bShow)
	{
		base.GetItem(24).SetUIActive(bShow);
	}

	// Token: 0x06015F72 RID: 89970 RVA: 0x0058B35C File Offset: 0x0058955C
	protected void OnBtnSubtitleSkipClick()
	{
		if (this.SubtitleLevel.GetValueOrDefault() != EPlotLevel.LevelB)
		{
			return;
		}
		if (!this.SubtitleInfo.HasSubtitle())
		{
			return;
		}
		ITalkItem currentSubtitle = this.CurrentSubtitle;
		if (currentSubtitle != null && currentSubtitle.Type.GetValueOrDefault() == ETalkItemType.CenterText)
		{
			return;
		}
		if (this.SubtitleInfo.ShowOption)
		{
			return;
		}
		if (this.SubtitleInfo.Skip)
		{
			return;
		}
		if (this.IsCurSubtitlePaused)
		{
			this.ResumeSequence("Subtitle");
			AudioSystem.Instance.PostEvent("play_ui_ia_spl_plot_next");
			return;
		}
		if (this.SubtitleInfo.EnableSkipTime > TimeUtil.Instance.GetServerTimeStamp())
		{
			return;
		}
		if (!this.SubtitleInfo.ShowAllText && this.SubtitleAnimDataComp.GetSelectorOffset() != 0f)
		{
			this.TryShowAllText();
			return;
		}
		this.TryJumpToNextSubtitleOrPlot();
		AudioSystem.Instance.PostEvent("play_ui_ia_spl_plot_next");
	}

	// Token: 0x06015F73 RID: 89971 RVA: 0x0058B43C File Offset: 0x0058963C
	private void TryShowAllText()
	{
		TimerHandle scrollStartTimer = this.ScrollStartTimer;
		if (scrollStartTimer != null)
		{
			scrollStartTimer.Remove();
		}
		this.ScrollStartTimer = null;
		this.RemoveTextAnimTimer();
		UUIScrollViewComponent scrollView = base.GetScrollView(27);
		if (scrollView != null)
		{
			scrollView.SetScrollProgress(1f);
		}
		this.SubtitleAnimation.Stop();
		this.SubtitleAnimDataComp.SetSelectorOffset(0f);
		this.SubtitleInfo.EnableSkipTime = TimeUtil.Instance.GetServerTimeStamp() + 100.0;
		this.SubtitleInfo.ShowAllText = true;
		if (this.SubtitleInfo.HasOption)
		{
			this.ShowOption();
		}
	}

	// Token: 0x06015F74 RID: 89972 RVA: 0x0058B4D9 File Offset: 0x005896D9
	private void TryJumpToNextSubtitleOrPlot()
	{
		if (this.SubtitleInfo.HasOption)
		{
			if (!this.SubtitleInfo.ShowOption)
			{
				this.ShowOption();
			}
			return;
		}
		SequenceController.Instance.FinishSubtitle(this.CurrentSubtitle.Id);
	}

	// Token: 0x06015F75 RID: 89973 RVA: 0x0058B514 File Offset: 0x00589714
	protected void OnBtnAutoClick()
	{
		bool flag = false;
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
		bool flag2 = eautoPlayState > EAutoPlayState.Manual;
		this.UpdateAutoPlayButton();
		this.AutoSelectOptionComponent.OnAutoPlayStateChanged();
		if (flag2)
		{
			flag = true;
		}
		if (flag && SequenceModel.Instance.IsPlaying && SequenceModel.Instance.IsPaused.GetValueOrDefault() && (!this.SubtitleInfo.HasSubtitle() || !this.SubtitleInfo.HasOption))
		{
			this.ResumeSequence("Subtitle");
		}
	}

	// Token: 0x06015F76 RID: 89974 RVA: 0x0058B5D1 File Offset: 0x005897D1
	private void OnSkipPop()
	{
		this.MuteAutoPlay(true);
		this.HideUiExceptPhoto();
	}

	// Token: 0x06015F77 RID: 89975 RVA: 0x0058B5E0 File Offset: 0x005897E0
	private void OnSkipCancel()
	{
		this.MuteAutoPlay(false);
		this.ShowUiExceptPhoto();
	}

	// Token: 0x06015F78 RID: 89976 RVA: 0x0058B5EF File Offset: 0x005897EF
	private void OnBtnHideClick()
	{
		this.HideUiExceptPhoto();
		this.IsVisible = false;
		this.MuteAutoPlay(true);
	}

	// Token: 0x06015F79 RID: 89977 RVA: 0x0058B605 File Offset: 0x00589805
	private void OnBtnReviewClick()
	{
		if (FlowController.Instance.OpenPlotReviewView())
		{
			this.HideUiExceptPhoto();
			this.MuteAutoPlay(true);
		}
	}

	// Token: 0x06015F7A RID: 89978 RVA: 0x0058B620 File Offset: 0x00589820
	private void OnOpenView(EUiViewName viewName, int _)
	{
		if (viewName == EUiViewName.PlotReviewView)
		{
			AudioSystem.Instance.PostEvent("plot_review_enter");
		}
	}

	// Token: 0x06015F7B RID: 89979 RVA: 0x0058B63F File Offset: 0x0058983F
	private void OnCloseView(EUiViewName viewName, int _)
	{
		if (viewName == EUiViewName.PlotReviewView)
		{
			AudioSystem.Instance.PostEvent("plot_review_exit");
			this.IsVisible = true;
			this.MuteAutoPlay(false);
			this.ShowUiExceptPhoto();
			this.RestorePlotButtonsVisibility();
		}
	}

	// Token: 0x06015F7C RID: 89980 RVA: 0x0058B678 File Offset: 0x00589878
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

	// Token: 0x06015F7D RID: 89981 RVA: 0x0058B6A1 File Offset: 0x005898A1
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

	// Token: 0x06015F7E RID: 89982 RVA: 0x0058B6CC File Offset: 0x005898CC
	private void PlaySubtitle()
	{
		SubtitleInfo subtitleInfo = this.SubtitleInfo;
		ETalkItemType? etalkItemType;
		if (subtitleInfo == null)
		{
			etalkItemType = null;
		}
		else
		{
			ITalkItem currentConfig = subtitleInfo.CurrentConfig;
			etalkItemType = ((currentConfig != null) ? currentConfig.Type : null);
		}
		ETalkItemType? etalkItemType2 = etalkItemType;
		if (etalkItemType2 != null)
		{
			switch (etalkItemType2.GetValueOrDefault())
			{
			case ETalkItemType.Option:
			case ETalkItemType.SystemOption:
				this.ResetSubtitle();
				this.SkipSubtitleTipItemActive(false);
				this.ShowWaitingPoint(false);
				this.SubtitleInfo.ShowAllText = true;
				return;
			case ETalkItemType.CenterText:
				this.ShowTransitionView();
				return;
			}
		}
		this.HandleNormalSubtitle();
		this.HandleSubtitleAudio(this.AudioKey, this.SubtitleInfo.CurrentDelayTime, this.SubtitleInfo.CurrentAudioTransitionDuration);
		this.HandleSkipWaiting();
	}

	// Token: 0x06015F7F RID: 89983 RVA: 0x0058B785 File Offset: 0x00589985
	private void HideSubtitle()
	{
		this.ResetSubtitle();
		this.StopCurSubtitleAudio();
		this.SkipSubtitleTipItemActive(false);
		this.ShowWaitingPoint(false);
		this.StopWaitingSkipTimer();
		this.SubtitleInfo.Clear();
	}

	// Token: 0x06015F80 RID: 89984 RVA: 0x0058B7B4 File Offset: 0x005899B4
	private void ShowOption()
	{
		SubtitleInfo subtitleInfo = this.SubtitleInfo;
		if (subtitleInfo == null || !subtitleInfo.HasOption)
		{
			return;
		}
		UUIItem item = base.GetItem(45);
		if (this.SubtitleLevel.GetValueOrDefault() == EPlotLevel.LevelB && PlotModel.Instance.IsUseNewLevelBStyle())
		{
			if (item != null)
			{
				item.SetAnchorOffsetY(PlotSubtitleView.GetPnlLayout02OffsetY(Info.Instance.InputControllerMainType));
			}
		}
		else if (item != null)
		{
			item.SetAnchorOffsetY(0f);
		}
		if (this.CurrentSubtitle.Type.GetValueOrDefault() == ETalkItemType.SystemOption)
		{
			PlotController.Instance.ShowSystemOption(this.CurrentSubtitle, delegate(int index, List<ActionInfo> _)
			{
				SequenceController.Instance.SelectOption(index, this.CurrentSubtitle.Id);
			});
			this.SubtitleInfo.ShowOption = true;
			this.HandleSkipWaiting();
			return;
		}
		PlotModel.Instance.OptionEnable = true;
		this.SubtitleInfo.ShowOption = true;
		this.SetOptionsShow(true);
		this.CurOption = this.FilterOption(this.CurrentSubtitle.Options);
		this.OptionLayout.RefreshByData(this.CurOption.Cast<object>().ToList<object>(), delegate
		{
			this.HandleOptionState();
			this.AutoSelectOptionComponent.OnOptionsShow();
		}, false);
		this.HandleSkipWaiting();
	}

	// Token: 0x06015F81 RID: 89985 RVA: 0x0058B8CC File Offset: 0x00589ACC
	[NullableContext(1)]
	private List<PlotOption> FilterOption(List<ITalkOption> options)
	{
		List<PlotOption> list = new List<PlotOption>();
		for (int i = 0; i < options.Count; i++)
		{
			ITalkOption talkOption = options[i];
			bool flag = PlotModel.Instance.CheckOptionCondition(talkOption, i, this.CurrentSubtitle);
			if (flag || talkOption.OptionLockTip != null)
			{
				PlotOption item = new PlotOption
				{
					Config = talkOption,
					ConditionCheck = flag,
					OnClick = new Action(this.OnOptionSelected)
				};
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06015F82 RID: 89986 RVA: 0x0058B946 File Offset: 0x00589B46
	private void OnOptionSelected()
	{
		this.AutoSelectOptionComponent.OnOptionSelected();
	}

	// Token: 0x06015F83 RID: 89987 RVA: 0x0058B953 File Offset: 0x00589B53
	private void SelectOptionByIndex(int optionIndex)
	{
		SequenceController.Instance.SelectOption(optionIndex, this.CurrentSubtitle.Id);
	}

	// Token: 0x06015F84 RID: 89988 RVA: 0x0058B96B File Offset: 0x00589B6B
	private void HideOption()
	{
		this.ClearOptions();
	}

	// Token: 0x06015F85 RID: 89989 RVA: 0x0058B974 File Offset: 0x00589B74
	private void HandleOptionState()
	{
		PlotOptionItem selectedPlotOptionItem = this.SelectedPlotOptionItem;
		if (selectedPlotOptionItem != null)
		{
			selectedPlotOptionItem.SetSelectedDisplay(false);
		}
		this.SelectedPlotOptionItem = PlotAutoSelectOptionComponent.GetDefaultSelectedOptionItem(this.GetDisplayOptionItems(), this.CurrentSubtitle);
		if (this.SelectedPlotOptionItem != null)
		{
			this.SelectedPlotOptionItem.SetSelectedDisplay(true);
			this.AutoSelectOptionComponent.OnSelectedOptionChanged();
			UiNavigationNewController.Instance.SetNavigationFocusForView(this.SelectedPlotOptionItem.GetToggleItem().GetRootComponent(), true, false, false);
		}
	}

	// Token: 0x06015F86 RID: 89990 RVA: 0x0058B9E8 File Offset: 0x00589BE8
	[NullableContext(1)]
	private PlotOptionItem[] GetDisplayOptionItems()
	{
		List<PlotOptionItem> list = new List<PlotOptionItem>();
		int displayGridEndIndex = this.OptionLayout.GetDisplayGridEndIndex();
		for (int i = 0; i <= displayGridEndIndex; i++)
		{
			PlotOptionItem layoutItemByIndex = this.OptionLayout.GetLayoutItemByIndex(i);
			if (layoutItemByIndex != null)
			{
				list.Add(layoutItemByIndex);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06015F87 RID: 89991 RVA: 0x0058BA30 File Offset: 0x00589C30
	private void HideAll(bool isHidden)
	{
		this.RootItem.SetUIActive(!isHidden);
	}

	// Token: 0x06015F88 RID: 89992 RVA: 0x0058BA44 File Offset: 0x00589C44
	private void ClearPlotSubtitle()
	{
		this.CheckAndCloseTransitionView();
		SubtitleInfo subtitleInfo = this.SubtitleInfo;
		if (subtitleInfo != null && subtitleInfo.HasSubtitle())
		{
			this.HideSeqSubtitleInternal();
		}
		else
		{
			this.ResetSubtitle();
			this.HideOption();
			this.SkipSubtitleTipItemActive(false);
			this.ShowWaitingPoint(false);
			this.StopWaitingSkipTimer();
		}
		this.StopCurSubtitleAudio();
		this.StopIndependentAudio();
		this.RemoveAutoPlayDelay();
	}

	// Token: 0x06015F89 RID: 89993 RVA: 0x0058BAA8 File Offset: 0x00589CA8
	private void HandleSubtitleAudio(string audioId, float audioDelay, float audioTransitionDuration)
	{
		if (StringUtils.IsEmpty(audioId))
		{
			return;
		}
		PlotAudio? audioConfig = StringUtils.IsEmpty(audioId) ? null : ConfigPlotAudioById.GetConfig(audioId, true);
		if (audioConfig == null)
		{
			return;
		}
		this.AudioConfig = audioConfig;
		this.AudioStartTime = TimeUtil.Instance.GetServerTimeStamp() + (double)audioDelay;
		this.CheckAndPlayAudio();
	}

	// Token: 0x06015F8A RID: 89994 RVA: 0x0058BB04 File Offset: 0x00589D04
	private void HandleSkipWaiting()
	{
		this.StopWaitingSkipTimer();
		if (this.SubtitleLevel.GetValueOrDefault() != EPlotLevel.LevelB || !this.SubtitleInfo.HasSubtitle())
		{
			this.SkipSubtitleTipItemActive(false);
			this.ShowWaitingPoint(false);
			return;
		}
		if (this.SubtitleInfo.ShowOption)
		{
			this.SkipSubtitleTipItemActive(false);
			this.ShowWaitingPoint(false);
			return;
		}
		double num = this.SubtitleInfo.EnableSkipTime - TimeUtil.Instance.GetServerTimeStamp();
		if (num < 20.0)
		{
			this.SkipSubtitleTipItemActive(true);
			this.ShowWaitingPoint(false);
			return;
		}
		this.SkipSubtitleTipItemActive(false);
		this.ShowWaitingPoint(true);
		this.WaitingSkipTimerId = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.SkipSubtitleTipItemActive(true);
			this.ShowWaitingPoint(false);
			this.WaitingSkipTimerId = null;
		}, (float)num, null, null, true, 1f);
	}

	// Token: 0x06015F8B RID: 89995 RVA: 0x0058BBC3 File Offset: 0x00589DC3
	private void StopWaitingSkipTimer()
	{
		if (this.WaitingSkipTimerId != null)
		{
			if (TimerSystem.Instance.Has(this.WaitingSkipTimerId))
			{
				TimerSystem.Instance.Remove(this.WaitingSkipTimerId);
			}
			this.WaitingSkipTimerId = null;
		}
	}

	// Token: 0x06015F8C RID: 89996 RVA: 0x0058BBF8 File Offset: 0x00589DF8
	private void CheckAndPlayAudio()
	{
		if (this.AudioConfig == null)
		{
			return;
		}
		double num = this.AudioStartTime - TimeUtil.Instance.GetServerTimeStamp();
		if (num < 20.0)
		{
			this.PlayAudioNow();
			return;
		}
		this.AudioDelayTimerId = TimerSystem.Instance.Delay(delegate(float _)
		{
			if (this.AudioConfig == null)
			{
				return;
			}
			this.PlayAudioNow();
		}, (float)num, null, null, true, 1f);
	}

	// Token: 0x06015F8D RID: 89997 RVA: 0x0058BC60 File Offset: 0x00589E60
	private void PlayAudioNow()
	{
		ExternalSourceSetting? config = ConfigExternalSourceSettingById.GetConfig(this.AudioConfig.Value.ExternalSourceSetting, true);
		string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(this.AudioConfig.Value);
		this.AudioDelegate.Enable();
		this.Duration = ((this.AudioConfig.Value.TailTime < 0) ? PlotModel.Instance.PlotGlobalConfig.AudioEndDelay : ((float)this.AudioConfig.Value.TailTime));
		AudioController.Instance.PostEventByExternalSourcesByUi(config.Value.SubtitleEvent, externalSourcesMediaName, config.Value.SubtitleSrc, this.NormalPlayEventResult, null, new int?(8), this.AudioDelegate.AudioDelegate);
	}

	// Token: 0x06015F8E RID: 89998 RVA: 0x0058BD2A File Offset: 0x00589F2A
	private void CallBackDuration(float duration)
	{
		this.Duration += duration;
		this.AudioPlayTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.OnAudioEnd();
		}, this.Duration, null, null, true, 1f);
	}

	// Token: 0x06015F8F RID: 89999 RVA: 0x0058BD64 File Offset: 0x00589F64
	private void OnAudioEnd()
	{
		this.AudioPlayTimer = null;
		SubtitleInfo subtitleInfo = this.SubtitleInfo;
		if (subtitleInfo == null || !subtitleInfo.HasSubtitle())
		{
			return;
		}
		if (!this.SubtitleInfo.ShowOption && this.SubtitleInfo.NeedDelay && this.SubtitleInfo.StartFinish)
		{
			this.SubtitleInfo.NeedDelay = false;
			this.DelayAutoPlayTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.OnAutoPlayDelayEnd();
			}, this.SubtitleInfo.CurrentAutoPlayDelayTime, null, null, true, 1f);
			return;
		}
		if (this.IsCurSubtitlePaused && !this.SubtitleInfo.ShowOption && this.IsCurSubtitleAutoPlay())
		{
			this.ResumeSequence("Subtitle");
		}
	}

	// Token: 0x06015F90 RID: 90000 RVA: 0x0058BE1B File Offset: 0x0058A01B
	private void OnAutoPlayDelayEnd()
	{
		this.DelayAutoPlayTimer = null;
		if (this.IsCurSubtitlePaused)
		{
			this.ResumeSequence("Subtitle");
		}
	}

	// Token: 0x06015F91 RID: 90001 RVA: 0x0058BE38 File Offset: 0x0058A038
	private void StopCurSubtitleAudio()
	{
		if (this.AudioConfig == null)
		{
			return;
		}
		SequenceController.Instance.StopMouthAnim();
		TimerHandle audioPlayTimer = this.AudioPlayTimer;
		if (audioPlayTimer != null)
		{
			audioPlayTimer.Remove();
		}
		this.AudioPlayTimer = null;
		this.AudioStartTime = 0.0;
		this.Duration = 0f;
		this.AudioDelegate.Disable();
		AudioController.Instance.StopEvent(this.NormalPlayEventResult, true, new int?(500));
		this.RemoveAudioDelayTimer();
		this.AudioConfig = null;
		this.RemoveAutoPlayDelay();
	}

	// Token: 0x06015F92 RID: 90002 RVA: 0x0058BED0 File Offset: 0x0058A0D0
	private float GetCurrentAudioRemainingTime()
	{
		if (this.AudioConfig == null)
		{
			return 0f;
		}
		if (this.AudioPlayTimer != null && TimerSystem.Instance.Has(this.AudioPlayTimer))
		{
			float nextRemainTime = TimerSystem.Instance.GetNextRemainTime(this.AudioPlayTimer);
			if (nextRemainTime >= 0f)
			{
				return nextRemainTime;
			}
		}
		if (this.AudioDelayTimerId != null && TimerSystem.Instance.Has(this.AudioDelayTimerId))
		{
			float nextRemainTime2 = TimerSystem.Instance.GetNextRemainTime(this.AudioDelayTimerId);
			if (nextRemainTime2 >= 0f)
			{
				return nextRemainTime2;
			}
		}
		if (this.AudioStartTime > 0.0 && this.Duration > 0f)
		{
			return Math.Max(0f, (float)(this.AudioStartTime + (double)this.Duration - TimeUtil.Instance.GetServerTimeStamp()));
		}
		return 0f;
	}

	// Token: 0x06015F93 RID: 90003 RVA: 0x0058BFA2 File Offset: 0x0058A1A2
	private void RemoveAudioDelayTimer()
	{
		if (this.AudioDelayTimerId != null)
		{
			if (TimerSystem.Instance.Has(this.AudioDelayTimerId))
			{
				TimerSystem.Instance.Remove(this.AudioDelayTimerId);
			}
			this.AudioDelayTimerId = null;
		}
	}

	// Token: 0x06015F94 RID: 90004 RVA: 0x0058BFD6 File Offset: 0x0058A1D6
	private void RemoveAutoPlayDelay()
	{
		if (this.DelayAutoPlayTimer != null)
		{
			if (TimerSystem.Instance.Has(this.DelayAutoPlayTimer))
			{
				TimerSystem.Instance.Remove(this.DelayAutoPlayTimer);
			}
			this.DelayAutoPlayTimer = null;
		}
	}

	// Token: 0x06015F95 RID: 90005 RVA: 0x0058C00C File Offset: 0x0058A20C
	private void HandleNormalSubtitle()
	{
		ITalkItem currentConfig = this.SubtitleInfo.CurrentConfig;
		EPlotLevel? subtitleLevel = this.SubtitleLevel;
		EPlotLevel eplotLevel = EPlotLevel.LevelA;
		if (subtitleLevel.GetValueOrDefault() == eplotLevel & subtitleLevel != null)
		{
			string text = PublicUtil.Instance.GetFlowConfigLocalText(this.SubtitleKey);
			if (StringUtils.IsEmpty(text))
			{
				FlowController instance = FlowController.Instance;
				string text2 = "字幕为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", this.SubtitleKey);
				instance.LogError(text2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				text = this.SubtitleKey;
			}
			text = this.ParseSubtitle(text);
			base.GetText(12).SetGameRichText(true);
			base.GetText(12).SetText(text, true);
			base.GetText(12).SetUIActive(true);
			base.GetItem(3).SetAlpha(1f);
		}
		else
		{
			UUIText text3 = base.GetText(4);
			UUIText text4 = base.GetText(17);
			UUIItem item = base.GetItem(11);
			UUIItem item2 = base.GetItem(45);
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
			if (this.SubtitleLevel.GetValueOrDefault() == EPlotLevel.LevelB && PlotModel.Instance.IsUseNewLevelBStyle())
			{
				this.ShowBlackBg(false, false);
				base.GetItem(3).SetAlpha(1f);
				text3.SetUIActive(false);
				text4.SetUIActive(false);
				item.SetUIActive(false);
				if (uuisizeControlByOther != null)
				{
					uuisizeControlByOther.MinHeight = 60;
				}
				if (item2 != null)
				{
					item2.SetAnchorOffsetY(PlotSubtitleView.GetPnlLayout02OffsetY(Info.Instance.InputControllerMainType));
				}
			}
			else
			{
				this.ShowBlackBg(true, true);
				if (uuisizeControlByOther != null)
				{
					uuisizeControlByOther.MinHeight = 174;
				}
				if (item2 != null)
				{
					item2.SetAnchorOffsetY(0f);
				}
				ITalkItemDialog talkItemDialog = currentConfig as ITalkItemDialog;
				bool flag;
				if (talkItemDialog == null)
				{
					flag = false;
				}
				else
				{
					ITalkItemStyle style = talkItemDialog.Style;
					ETalkItemStyle? etalkItemStyle = (style != null) ? new ETalkItemStyle?(style.Type) : null;
					ETalkItemStyle etalkItemStyle2 = ETalkItemStyle.InnerVoice;
					flag = (etalkItemStyle.GetValueOrDefault() == etalkItemStyle2 & etalkItemStyle != null);
				}
				if (flag)
				{
					text3.SetUIActive(false);
					text4.SetUIActive(false);
					item.SetUIActive(false);
				}
				else
				{
					Speaker? config = ConfigSpeakerById.GetConfig(currentConfig.WhoId.Value, true);
					string text5 = (config != null) ? PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerName, new int?(config.Value.Id)) : null;
					string text6 = (config != null) ? PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerTitle, new int?(config.Value.Id)) : null;
					item.SetUIActive(true);
					if (!StringUtils.IsEmpty(text5))
					{
						text3.SetUIActive(true);
						text3.SetText(text5, true);
					}
					else
					{
						text3.SetUIActive(false);
					}
					if (!StringUtils.IsEmpty(text6))
					{
						text4.SetUIActive(true);
						text4.SetText(text6, true);
					}
					else
					{
						text4.SetUIActive(false);
					}
				}
			}
			string text7 = PublicUtil.Instance.GetFlowConfigLocalText(this.SubtitleKey);
			text7 = this.ParseSubtitle(text7);
			base.GetText(5).SetGameRichText(true);
			base.GetText(5).SetText(text7, true);
			base.GetText(5).SetUIActive(true);
			int displayCharLength = base.GetText(5).GetDisplayCharLength();
			if (this.SubtitleAnimation != null)
			{
				float duration = (float)displayCharLength / PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedSeq;
				this.SubtitleAnimDataComp.SetSelectorOffset(1f);
				this.SubtitleAnimation.GetPlayTween().duration = duration;
				this.SubtitleAnimation.Play();
			}
			TimerHandle scrollStartTimer = this.ScrollStartTimer;
			if (scrollStartTimer != null)
			{
				scrollStartTimer.Remove();
			}
			this.ScrollStartTimer = null;
			this.ScrollStartTimer = TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				this.ScrollStartTimer = TimerSystem.GameplayTimeInstance.Next(delegate(float _)
				{
					this.HandlePlotContentScroll();
				}, null, null);
			}, null, null);
		}
		this.UpdatePlotTextOffset();
	}

	// Token: 0x06015F96 RID: 90006 RVA: 0x0058C3E4 File Offset: 0x0058A5E4
	private void HandlePlotContentScroll()
	{
		this.ScrollStartTimer = null;
		this.RemoveTextAnimTimer();
		UUIScrollViewComponent scrollView = base.GetScrollView(27);
		UUIItem item = base.GetItem(28);
		if (scrollView == null)
		{
			return;
		}
		UUIText text = base.GetText(5);
		float y = text.GetTextRenderSize().Y;
		UUIItem uuiitem = scrollView.RootUIComp.Get();
		float num = (uuiitem != null) ? uuiitem.GetHeight() : this.TextScrollViewPrefabHeight;
		if (item != null)
		{
			item.SetHeight(num + 265f);
		}
		if (y <= num)
		{
			return;
		}
		float textAnimSpeed = this.GetTextAnimSpeed();
		int num2 = ConfigCommonParamById.GetIntConfig("PlotAutoScrollDelayCharNum").GetValueOrDefault(25);
		int displayCharLength = text.GetDisplayCharLength();
		if (displayCharLength <= num2)
		{
			num2 = text.GetRenderLineCharNum(0);
		}
		num2 = Math.Min(num2, Math.Max(displayCharLength - 1, 1));
		float num3 = (float)num2 / textAnimSpeed * 1000f;
		int num4 = Math.Max(displayCharLength - num2, 1);
		this.ScrollTotalTime = (float)num4 / textAnimSpeed * 1000f;
		this.DelayTextScrollAnimTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.StartAutoScrollAnim();
		}, num3, null, null, true, 1f);
	}

	// Token: 0x06015F97 RID: 90007 RVA: 0x0058C4F9 File Offset: 0x0058A6F9
	private float GetTextAnimSpeed()
	{
		if (this.Level.GetValueOrDefault() == EPlotLevel.LevelC)
		{
			return PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedLevelC;
		}
		return PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedLevelD;
	}

	// Token: 0x06015F98 RID: 90008 RVA: 0x0058C528 File Offset: 0x0058A728
	private void StartAutoScrollAnim()
	{
		this.CurrentAnimTime = 0f;
		int intervalTime = 100;
		this.TextScrollAnimTimer = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			float num = this.CurrentAnimTime / this.ScrollTotalTime;
			UUIScrollViewComponent scrollView = this.GetScrollView(27);
			if (scrollView != null)
			{
				scrollView.SetScrollProgress(num);
			}
			if (num >= 1f && TimerSystem.GameplayTimeInstance.Has(this.TextScrollAnimTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TextScrollAnimTimer);
			}
			this.CurrentAnimTime += (float)intervalTime;
		}, (float)intervalTime, 1f, null, null, true);
	}

	// Token: 0x06015F99 RID: 90009 RVA: 0x0058C580 File Offset: 0x0058A780
	private void RemoveTextAnimTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.TextScrollAnimTimer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TextScrollAnimTimer);
		}
		if (TimerSystem.GameplayTimeInstance.Has(this.DelayTextScrollAnimTimer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.DelayTextScrollAnimTimer);
		}
		this.TextScrollAnimTimer = null;
		this.DelayTextScrollAnimTimer = null;
	}

	// Token: 0x06015F9A RID: 90010 RVA: 0x0058C5E4 File Offset: 0x0058A7E4
	[NullableContext(1)]
	private unsafe void UpdateSeqSubtitle(PlotSubtitleConfig inPlotSubtitleInfo)
	{
		if (this.SubtitleInfo.HasSubtitle())
		{
			FlowController instance = FlowController.Instance;
			string text = "剧情Seq字幕重复触发";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("curId", this.SubtitleInfo.CurrentConfig.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("newId", inPlotSubtitleInfo.Subtitles.Id);
			instance.LogError(text, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.CheckAndCloseTransitionView();
		this.SubtitleInfo.Clear();
		this.SubtitleInfo.SetCurrentSubtitle(inPlotSubtitleInfo);
		ITalkBackground backgroundConfig;
		if (inPlotSubtitleInfo == null)
		{
			backgroundConfig = null;
		}
		else
		{
			ITalkItem subtitles = inPlotSubtitleInfo.Subtitles;
			backgroundConfig = ((subtitles != null) ? subtitles.BackgroundConfig : null);
		}
		this.SetBackgroundImage(backgroundConfig, new Action(this.ShowSeqSubtitleInternal)).Forget();
	}

	// Token: 0x06015F9B RID: 90011 RVA: 0x0058C6BE File Offset: 0x0058A8BE
	private void ShowSeqSubtitleInternal()
	{
		this.SetSubtitleKey();
		this.SetOptions();
		this.SetAudioKeys();
		this.HandleAkEvent(true);
		this.PlaySubtitle();
	}

	// Token: 0x06015F9C RID: 90012 RVA: 0x0058C6E0 File Offset: 0x0058A8E0
	private void HandleAkEvent(bool isStart)
	{
		if (isStart)
		{
			this.PlayAkEvent(this.SubtitleInfo.CurrentConfig.TalkAkEvent);
			this.LastEndEvent = this.SubtitleInfo.CurrentConfig.TalkEndAkEvent;
			return;
		}
		this.PlayAkEvent(this.LastEndEvent);
		this.LastEndEvent = null;
	}

	// Token: 0x06015F9D RID: 90013 RVA: 0x0058C730 File Offset: 0x0058A930
	private void HideSeqSubtitleInternal()
	{
		if (this.SubtitleLevel.GetValueOrDefault() == EPlotLevel.LevelB && this.NeedSwitchTalker())
		{
			this.ShowBlackBg(false, true);
		}
		this.HandleAkEvent(false);
		this.HideSubtitle();
		this.HideOption();
	}

	// Token: 0x06015F9E RID: 90014 RVA: 0x0058C764 File Offset: 0x0058A964
	private bool NeedSwitchTalker()
	{
		ITalkItem nextTalkItem = FlowController.Instance.FlowSequence.GetNextTalkItem();
		if (nextTalkItem == null || (nextTalkItem != null && nextTalkItem.Type.GetValueOrDefault() == ETalkItemType.Option))
		{
			return true;
		}
		ITalkItem currentSubtitle = this.CurrentSubtitle;
		int? num = (currentSubtitle != null) ? currentSubtitle.WhoId : null;
		int? num2 = (nextTalkItem != null) ? nextTalkItem.WhoId : null;
		return !(num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null));
	}

	// Token: 0x06015F9F RID: 90015 RVA: 0x0058C7F0 File Offset: 0x0058A9F0
	private void ShowTransitionView()
	{
		string text = null;
		string subtitleKey = this.SubtitleKey;
		if (subtitleKey != "")
		{
			text = PublicUtil.Instance.GetFlowConfigLocalText(subtitleKey);
			text = this.ParseSubtitle(text);
		}
		else
		{
			FlowController instance = FlowController.Instance;
			string text2 = "该字幕没配置对白";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", this.SubtitleInfo.CurrentConfig.Id);
			instance.LogError(text2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		PlotCenterText centerText = PlotModel.Instance.CenterText;
		centerText.Text = text;
		centerText.AutoClose = false;
		SubtitleInfo subtitleInfo = this.SubtitleInfo;
		IPostAkEventType talkAkEvent;
		if (subtitleInfo == null)
		{
			talkAkEvent = null;
		}
		else
		{
			ITalkItem currentConfig = subtitleInfo.CurrentConfig;
			talkAkEvent = ((currentConfig != null) ? currentConfig.TalkAkEvent : null);
		}
		centerText.TalkAkEvent = talkAkEvent;
		SubtitleInfo subtitleInfo2 = this.SubtitleInfo;
		IUniversalTone universalTone;
		if (subtitleInfo2 == null)
		{
			universalTone = null;
		}
		else
		{
			ITalkItem currentConfig2 = subtitleInfo2.CurrentConfig;
			universalTone = ((currentConfig2 != null) ? currentConfig2.UniversalTone : null);
		}
		centerText.UniversalTone = universalTone;
		PlotController.Instance.HandleShowCenterText(true);
		global::Log instance2 = global::Log.Instance;
		ELogModule module = ELogModule.Plot;
		ELogAuthor author = ELogAuthor.ZFJ;
		string message = "Sequence黑幕监听日志-打开黑幕";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("subtitleKey", this.SubtitleKey);
		instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
	}

	// Token: 0x06015FA0 RID: 90016 RVA: 0x0058C8F8 File Offset: 0x0058AAF8
	private bool CheckAndCloseTransitionView()
	{
		if (this.SubtitleInfo.HasSubtitle() && this.SubtitleInfo.CurrentConfig.Type.GetValueOrDefault() == ETalkItemType.CenterText)
		{
			this.CloseTransitionView();
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.ZFJ, "Sequence黑幕监听日志-关闭黑幕", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}
		return false;
	}

	// Token: 0x06015FA1 RID: 90017 RVA: 0x0058C952 File Offset: 0x0058AB52
	private void CloseTransitionView()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.PlotTransitionViewPop))
		{
			UiManager.Instance.CloseView(EUiViewName.PlotTransitionViewPop, null);
		}
	}

	// Token: 0x06015FA2 RID: 90018 RVA: 0x0058C975 File Offset: 0x0058AB75
	private void HandleSelectedPlotOption(int inOptionIndex)
	{
		bool skip = this.SubtitleInfo.Skip;
		this.HideOption();
		this.HideSeqSubtitleInternal();
		if (skip)
		{
			this.JumpSequence();
			return;
		}
		if (this.IsCurSubtitlePaused)
		{
			this.ResumeSequence("Subtitle");
		}
	}

	// Token: 0x06015FA3 RID: 90019 RVA: 0x0058C9AC File Offset: 0x0058ABAC
	[NullableContext(1)]
	private void OnInputAnyKey(bool bPress, FKey key)
	{
		UiParam uiParam = this.OpenParam as UiParam;
		if (uiParam != null && uiParam.HideAllUi.GetValueOrDefault())
		{
			return;
		}
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
	}

	// Token: 0x06015FA4 RID: 90020 RVA: 0x0058C9FC File Offset: 0x0058ABFC
	[NullableContext(1)]
	private void OnTouchPlotVisible(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
	{
		UiParam uiParam = this.OpenParam as UiParam;
		if (uiParam != null && uiParam.HideAllUi.GetValueOrDefault())
		{
			return;
		}
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

	// Token: 0x06015FA5 RID: 90021 RVA: 0x0058CA4C File Offset: 0x0058AC4C
	private void HandleSeqSubtitleEnd(int id, bool isSkip)
	{
		this.SubtitleInfo.StartFinish = true;
		if (!this.SubtitleInfo.HasSubtitle() || this.CurrentSubtitle.Id != id)
		{
			return;
		}
		if (isSkip)
		{
			if (this.SubtitleInfo.HasOption)
			{
				this.SubtitleInfo.Skip = true;
				return;
			}
			this.HideSeqSubtitleInternal();
			this.JumpSequence();
			return;
		}
		else
		{
			if (this.SubtitleInfo.ShowOption)
			{
				this.PauseSequence("Subtitle");
				return;
			}
			if (this.SubtitleInfo.HasOption)
			{
				this.ShowOption();
				this.PauseSequence("Subtitle");
				return;
			}
			if (this.Level.GetValueOrDefault() == EPlotLevel.LevelB && this.SubtitleInfo.NeedDelay && this.SubtitleInfo.CurrentConfig.Type.GetValueOrDefault() != ETalkItemType.CenterText)
			{
				this.PauseSequence("Subtitle");
				this.RemoveAutoPlayDelay();
				this.DelayAutoPlayTimer = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.OnAutoPlayDelayEnd();
				}, this.SubtitleInfo.CurrentAutoPlayDelayTime, null, null, true, 1f);
				return;
			}
			double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
			if (this.Level.GetValueOrDefault() == EPlotLevel.LevelB && (!this.IsCurSubtitleAutoPlay() || this.AudioPlayTimer != null) && this.SubtitleInfo.EnableSkipTime <= serverTimeStamp)
			{
				this.PauseSequence("Subtitle");
				return;
			}
			this.CheckAndCloseTransitionView();
			this.HideSeqSubtitleInternal();
			return;
		}
	}

	// Token: 0x06015FA6 RID: 90022 RVA: 0x0058CBAA File Offset: 0x0058ADAA
	private void HandleSubSequenceStop()
	{
		if (this.SubtitleInfo.HasSubtitle())
		{
			this.CheckAndCloseTransitionView();
			this.HideSeqSubtitleInternal();
			this.StopCurSubtitleAudio();
			this.StopIndependentAudio();
		}
	}

	// Token: 0x06015FA7 RID: 90023 RVA: 0x0058CBD4 File Offset: 0x0058ADD4
	[NullableContext(1)]
	private void HandleIndependentSeqAudio(bool isShow, string audioKey, float audioTransitionDuration)
	{
		if (!isShow)
		{
			this.StopIndependentAudio();
			return;
		}
		PlotAudio? config = ConfigPlotAudioById.GetConfig(audioKey, true);
		if (config == null)
		{
			FlowController instance = FlowController.Instance;
			string text = "读取语音配置为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("audioKey", audioKey);
			instance.LogError(text, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		ExternalSourceSetting? config2 = ConfigExternalSourceSettingById.GetConfig(config.Value.ExternalSourceSetting, true);
		string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(config.Value);
		AudioController.Instance.PostEventByExternalSourcesByUi(config2.Value.SubtitleEvent, externalSourcesMediaName, config2.Value.SubtitleSrc, this.IndependentPlayEventResult, null, new int?(0), null);
	}

	// Token: 0x06015FA8 RID: 90024 RVA: 0x0058CC88 File Offset: 0x0058AE88
	private void StopIndependentAudio()
	{
		AudioController.Instance.StopEvent(this.IndependentPlayEventResult, true, null);
	}

	// Token: 0x06015FA9 RID: 90025 RVA: 0x0058CCAF File Offset: 0x0058AEAF
	private void JumpSequence()
	{
		this.SubtitleInfo.Skip = true;
		SequenceController.Instance.JumpToNextSubtitleOrChildSeq();
	}

	// Token: 0x06015FAA RID: 90026 RVA: 0x0058CCC7 File Offset: 0x0058AEC7
	[NullableContext(1)]
	private void PauseSequence(string reason = "Subtitle")
	{
		this.IsCurSubtitlePaused = true;
		SequenceController.Instance.PauseSequence(reason);
	}

	// Token: 0x06015FAB RID: 90027 RVA: 0x0058CCDC File Offset: 0x0058AEDC
	[NullableContext(1)]
	private void ResumeSequence(string reason = "Subtitle")
	{
		SequenceController.Instance.ResumeSequence(reason, null);
		this.IsCurSubtitlePaused = false;
		this.HideSeqSubtitleInternal();
	}

	// Token: 0x06015FAC RID: 90028 RVA: 0x0058CD0C File Offset: 0x0058AF0C
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
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		if (config.Type == EPostAkEvent.Global)
		{
			AudioSystem.Instance.PostEvent(text);
			return;
		}
		if (config.Type == EPostAkEvent.Target)
		{
			int entityId = ((IPostAkEventTargeted)config).EntityId;
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
	}

	// Token: 0x06015FAD RID: 90029 RVA: 0x0058CE68 File Offset: 0x0058B068
	private void SetSubtitleKey()
	{
		this.SubtitleKey = this.SubtitleInfo.CurrentConfig.TidTalk;
	}

	// Token: 0x06015FAE RID: 90030 RVA: 0x0058CE80 File Offset: 0x0058B080
	private void SetOptions()
	{
		this.OptionKeys.Clear();
		this.OsList.Clear();
		if (this.SubtitleInfo.CurrentConfig.Options != null)
		{
			foreach (ITalkOption talkOption in this.SubtitleInfo.CurrentConfig.Options)
			{
				this.OptionKeys.Add((talkOption.TidTalkOption != null) ? talkOption.TidTalkOption : "");
				this.OsList.Add((talkOption.Icon != null) ? talkOption.Icon.Value : 0);
			}
		}
	}

	// Token: 0x06015FAF RID: 90031 RVA: 0x0058CF50 File Offset: 0x0058B150
	private void SetAudioKeys()
	{
		ITalkItem currentConfig = this.SubtitleInfo.CurrentConfig;
		this.AudioKey = ((currentConfig != null && currentConfig.PlayVoice.GetValueOrDefault()) ? this.SubtitleInfo.CurrentConfig.TidTalk : null);
	}

	// Token: 0x06015FB0 RID: 90032 RVA: 0x0058CF98 File Offset: 0x0058B198
	private void ClearOptions()
	{
		this.CurOption.Clear();
		this.SetOptionsShow(false);
		PlotOptionItem selectedPlotOptionItem = this.SelectedPlotOptionItem;
		if (selectedPlotOptionItem != null)
		{
			selectedPlotOptionItem.SetSelectedDisplay(false);
		}
		this.SelectedPlotOptionItem = null;
		if (this.SubtitleInfo != null)
		{
			this.SubtitleInfo.ShowOption = false;
		}
		this.AutoSelectOptionComponent.Clear();
	}

	// Token: 0x06015FB1 RID: 90033 RVA: 0x0058CFF0 File Offset: 0x0058B1F0
	public void SetOptionsShow(bool value)
	{
		if (value == this.IsOptionShow)
		{
			return;
		}
		this.IsOptionShow = value;
		if (value)
		{
			this.OptionLayout.SetActive(true);
			UUIItem item = base.GetItem(45);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			this.UiViewSequence.PlaySequence("ChoiceStart", false, null);
			base.GetItem(32).SetUIActive(true);
			this.BlockOptionTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				base.GetItem(32).SetUIActive(false);
				this.BlockOptionTimer = null;
			}, PlotModel.Instance.PlotGlobalConfig.ProtectOptionTime, null, null, true, 1f);
			return;
		}
		this.UiViewSequence.PlaySequence("ChoiceClose", false, null);
		base.GetItem(32).SetUIActive(false);
		TimerHandle blockOptionTimer = this.BlockOptionTimer;
		if (blockOptionTimer != null)
		{
			blockOptionTimer.Remove();
		}
		this.BlockOptionTimer = null;
	}

	// Token: 0x06015FB2 RID: 90034 RVA: 0x0058D0CE File Offset: 0x0058B2CE
	public string ParseSubtitle(string inText)
	{
		if (string.IsNullOrEmpty(inText))
		{
			return "";
		}
		return PlotModel.Instance.PlotTextReplacer.Replace(inText, false);
	}

	// Token: 0x06015FB3 RID: 90035 RVA: 0x0058D0F0 File Offset: 0x0058B2F0
	private bool IsCurSubtitleAutoPlay()
	{
		if (this.SubtitleInfo.HasSubtitle() && this.SubtitleInfo.CurrentConfig.Type.GetValueOrDefault() == ETalkItemType.CenterText)
		{
			return true;
		}
		EPlotLevel? subtitleLevel = this.SubtitleLevel;
		EPlotLevel eplotLevel = EPlotLevel.LevelA;
		return (subtitleLevel.GetValueOrDefault() == eplotLevel & subtitleLevel != null) || PlotModel.Instance.PlotConfig.AutoPlayState > EAutoPlayState.Manual;
	}

	// Token: 0x06015FB4 RID: 90036 RVA: 0x0058D158 File Offset: 0x0058B358
	public void AddScreenEffectPlotRoot()
	{
		BP_ScreenEffectSystem_C instance = ScreenEffectSystem.GetInstance();
		if (instance == null || !instance.IsValid())
		{
			return;
		}
		AUIContainerActor screenEffectPlotRoot = null;
		instance.GetScreenEffectPlotRoot(ref screenEffectPlotRoot);
		this.ScreenEffectPlotRoot = screenEffectPlotRoot;
		UUIItem item = base.GetItem(13);
		AUIContainerActor screenEffectPlotRoot2 = this.ScreenEffectPlotRoot;
		if (screenEffectPlotRoot2 != null && screenEffectPlotRoot2.IsValid())
		{
			this.ScreenEffectPlotRoot.K2_AttachRootComponentTo(item, default(FName), EAttachLocation.KeepRelativeOffset, true);
		}
	}

	// Token: 0x06015FB5 RID: 90037 RVA: 0x0058D1BC File Offset: 0x0058B3BC
	public void RemoveScreenEffectPlotRoot()
	{
		AUIContainerActor screenEffectPlotRoot = this.ScreenEffectPlotRoot;
		if (screenEffectPlotRoot != null && screenEffectPlotRoot.IsValid())
		{
			this.ScreenEffectPlotRoot.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
		}
		this.ScreenEffectPlotRoot = null;
	}

	// Token: 0x06015FB6 RID: 90038 RVA: 0x0058D1E7 File Offset: 0x0058B3E7
	[NullableContext(1)]
	public PlotOptionItem[] GetOptionList()
	{
		return this.OptionLayout.GetLayoutItemList().ToArray();
	}

	// Token: 0x06015FB7 RID: 90039 RVA: 0x0058D1FC File Offset: 0x0058B3FC
	protected override void OnTick(float delta)
	{
		if (this.TickPhotoFade)
		{
			this.OnFadeTickPhoto(delta);
		}
		if (this.TickIconAlpha)
		{
			this.WidgetMiddle.SetAlpha(this.EventObject.Icon透明度);
			this.BgWidgetMiddle.SetAlpha(this.EventObject.Icon遮罩透明度);
		}
		this.AutoSelectOptionComponent.OnTick(delta, this.MuteTimeLimitedOption);
		if (!Info.Instance.IsBuildShipping)
		{
			this.TickDebugInfo();
		}
	}

	// Token: 0x06015FB8 RID: 90040 RVA: 0x0058D270 File Offset: 0x0058B470
	public void SimulateClickSubtitle()
	{
		if (Info.Instance.IsBuildShipping)
		{
			return;
		}
		this.OnBtnSubtitleSkipClick();
	}

	// Token: 0x06015FB9 RID: 90041 RVA: 0x0058D288 File Offset: 0x0058B488
	public void SimulateClickOption()
	{
		if (Info.Instance.IsBuildShipping)
		{
			return;
		}
		if (!this.SubtitleInfo.ShowOption)
		{
			return;
		}
		int recommendedOption = FlowController.Instance.GetRecommendedOption(null);
		PlotOptionItem[] optionList = this.GetOptionList();
		if (recommendedOption < optionList.Length)
		{
			PlotOptionItem plotOptionItem = optionList[recommendedOption];
			if (plotOptionItem != null)
			{
				plotOptionItem.OptionClick(new bool?(true));
			}
		}
	}

	// Token: 0x06015FBA RID: 90042 RVA: 0x0058D2DC File Offset: 0x0058B4DC
	private UniTask SetBackgroundImage(ITalkBackground backgroundConfig, Action callback = null)
	{
		PlotSubtitleView.<SetBackgroundImage>d__205 <SetBackgroundImage>d__;
		<SetBackgroundImage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SetBackgroundImage>d__.<>4__this = this;
		<SetBackgroundImage>d__.backgroundConfig = backgroundConfig;
		<SetBackgroundImage>d__.callback = callback;
		<SetBackgroundImage>d__.<>1__state = -1;
		<SetBackgroundImage>d__.<>t__builder.Start<PlotSubtitleView.<SetBackgroundImage>d__205>(ref <SetBackgroundImage>d__);
		return <SetBackgroundImage>d__.<>t__builder.Task;
	}

	// Token: 0x06015FBB RID: 90043 RVA: 0x0058D330 File Offset: 0x0058B530
	private UniTask OnPlotViewBgFadePhoto(bool isFadeIn, bool isFull, string path = null, Action callback = null)
	{
		PlotSubtitleView.<OnPlotViewBgFadePhoto>d__206 <OnPlotViewBgFadePhoto>d__;
		<OnPlotViewBgFadePhoto>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlotViewBgFadePhoto>d__.<>4__this = this;
		<OnPlotViewBgFadePhoto>d__.isFadeIn = isFadeIn;
		<OnPlotViewBgFadePhoto>d__.isFull = isFull;
		<OnPlotViewBgFadePhoto>d__.path = path;
		<OnPlotViewBgFadePhoto>d__.callback = callback;
		<OnPlotViewBgFadePhoto>d__.<>1__state = -1;
		<OnPlotViewBgFadePhoto>d__.<>t__builder.Start<PlotSubtitleView.<OnPlotViewBgFadePhoto>d__206>(ref <OnPlotViewBgFadePhoto>d__);
		return <OnPlotViewBgFadePhoto>d__.<>t__builder.Task;
	}

	// Token: 0x06015FBC RID: 90044 RVA: 0x0058D394 File Offset: 0x0058B594
	private void AddTickPhoto()
	{
		this.TickPhotoFade = true;
	}

	// Token: 0x06015FBD RID: 90045 RVA: 0x0058D39D File Offset: 0x0058B59D
	private void RemoveTickPhoto()
	{
		this.TickPhotoFade = false;
	}

	// Token: 0x06015FBE RID: 90046 RVA: 0x0058D3A8 File Offset: 0x0058B5A8
	private float GetCurrentPercentPhoto()
	{
		float rangePct = MathUtils.Instance.GetRangePct(0f, 200f, this.FadeTimePhoto);
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

	// Token: 0x06015FBF RID: 90047 RVA: 0x0058D41C File Offset: 0x0058B61C
	private float GetCurrentPercentPhotoMiddle()
	{
		float rangePct = MathUtils.Instance.GetRangePct(0f, 200f, this.FadeTimePhoto);
		if (!this.IsFadeInPhoto && this.WidgetMiddle.GetAlpha() <= 0f)
		{
			return 0f;
		}
		this.WidgetMiddle.SetAlpha(rangePct);
		return rangePct;
	}

	// Token: 0x06015FC0 RID: 90048 RVA: 0x0058D474 File Offset: 0x0058B674
	private void OnFadeTickPhoto(float deltaTime)
	{
		if (this.FadeTimePhoto < 0f)
		{
			this.FadeTimePhoto = 0f;
		}
		if (this.FadeTimePhoto > 200f)
		{
			this.FadeTimePhoto = 200f;
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

	// Token: 0x06015FC1 RID: 90049 RVA: 0x0058D558 File Offset: 0x0058B758
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
		}
		Action<ITalkItem> plotViewPhotoCallback = this.PlotViewPhotoCallback;
		if (plotViewPhotoCallback == null)
		{
			return;
		}
		plotViewPhotoCallback(null);
	}

	// Token: 0x06015FC2 RID: 90050 RVA: 0x0058D76C File Offset: 0x0058B96C
	public UniTask FadeInBgPhoto(string path = null, Action callback = null)
	{
		PlotSubtitleView.<FadeInBgPhoto>d__213 <FadeInBgPhoto>d__;
		<FadeInBgPhoto>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FadeInBgPhoto>d__.<>4__this = this;
		<FadeInBgPhoto>d__.path = path;
		<FadeInBgPhoto>d__.callback = callback;
		<FadeInBgPhoto>d__.<>1__state = -1;
		<FadeInBgPhoto>d__.<>t__builder.Start<PlotSubtitleView.<FadeInBgPhoto>d__213>(ref <FadeInBgPhoto>d__);
		return <FadeInBgPhoto>d__.<>t__builder.Task;
	}

	// Token: 0x06015FC3 RID: 90051 RVA: 0x0058D7C0 File Offset: 0x0058B9C0
	public UniTask FadeOutBgPhoto(Action callback = null)
	{
		PlotSubtitleView.<FadeOutBgPhoto>d__214 <FadeOutBgPhoto>d__;
		<FadeOutBgPhoto>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FadeOutBgPhoto>d__.<>4__this = this;
		<FadeOutBgPhoto>d__.callback = callback;
		<FadeOutBgPhoto>d__.<>1__state = -1;
		<FadeOutBgPhoto>d__.<>t__builder.Start<PlotSubtitleView.<FadeOutBgPhoto>d__214>(ref <FadeOutBgPhoto>d__);
		return <FadeOutBgPhoto>d__.<>t__builder.Task;
	}

	// Token: 0x06015FC4 RID: 90052 RVA: 0x0058D80C File Offset: 0x0058BA0C
	public UniTask FadeInBgPhotoMiddle(string path = null, Action callback = null)
	{
		PlotSubtitleView.<FadeInBgPhotoMiddle>d__215 <FadeInBgPhotoMiddle>d__;
		<FadeInBgPhotoMiddle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FadeInBgPhotoMiddle>d__.<>4__this = this;
		<FadeInBgPhotoMiddle>d__.path = path;
		<FadeInBgPhotoMiddle>d__.callback = callback;
		<FadeInBgPhotoMiddle>d__.<>1__state = -1;
		<FadeInBgPhotoMiddle>d__.<>t__builder.Start<PlotSubtitleView.<FadeInBgPhotoMiddle>d__215>(ref <FadeInBgPhotoMiddle>d__);
		return <FadeInBgPhotoMiddle>d__.<>t__builder.Task;
	}

	// Token: 0x06015FC5 RID: 90053 RVA: 0x0058D860 File Offset: 0x0058BA60
	public UniTask FadeOutBgPhotoMiddle(Action callback = null)
	{
		PlotSubtitleView.<FadeOutBgPhotoMiddle>d__216 <FadeOutBgPhotoMiddle>d__;
		<FadeOutBgPhotoMiddle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FadeOutBgPhotoMiddle>d__.<>4__this = this;
		<FadeOutBgPhotoMiddle>d__.callback = callback;
		<FadeOutBgPhotoMiddle>d__.<>1__state = -1;
		<FadeOutBgPhotoMiddle>d__.<>t__builder.Start<PlotSubtitleView.<FadeOutBgPhotoMiddle>d__216>(ref <FadeOutBgPhotoMiddle>d__);
		return <FadeOutBgPhotoMiddle>d__.<>t__builder.Task;
	}

	// Token: 0x06015FC6 RID: 90054 RVA: 0x0058D8AC File Offset: 0x0058BAAC
	public UniTask RemovePhotoAtOnce()
	{
		PlotSubtitleView.<RemovePhotoAtOnce>d__217 <RemovePhotoAtOnce>d__;
		<RemovePhotoAtOnce>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RemovePhotoAtOnce>d__.<>4__this = this;
		<RemovePhotoAtOnce>d__.<>1__state = -1;
		<RemovePhotoAtOnce>d__.<>t__builder.Start<PlotSubtitleView.<RemovePhotoAtOnce>d__217>(ref <RemovePhotoAtOnce>d__);
		return <RemovePhotoAtOnce>d__.<>t__builder.Task;
	}

	// Token: 0x06015FC7 RID: 90055 RVA: 0x0058D8EF File Offset: 0x0058BAEF
	[NullableContext(1)]
	private UUIItem GetSonUiParentForBackgroundUi(bool useFullscreenAdaptAnchor = false)
	{
		if (!useFullscreenAdaptAnchor)
		{
			return this.SonUi;
		}
		return this.FullscreenAdaptAnchor;
	}

	// Token: 0x06015FC8 RID: 90056 RVA: 0x0058D904 File Offset: 0x0058BB04
	[NullableContext(1)]
	public UniTask PreloadOpenBackgroundUi(TArray<string> uiNameArray, bool useFullscreenAdaptAnchor = false)
	{
		PlotSubtitleView.<PreloadOpenBackgroundUi>d__219 <PreloadOpenBackgroundUi>d__;
		<PreloadOpenBackgroundUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadOpenBackgroundUi>d__.<>4__this = this;
		<PreloadOpenBackgroundUi>d__.uiNameArray = uiNameArray;
		<PreloadOpenBackgroundUi>d__.useFullscreenAdaptAnchor = useFullscreenAdaptAnchor;
		<PreloadOpenBackgroundUi>d__.<>1__state = -1;
		<PreloadOpenBackgroundUi>d__.<>t__builder.Start<PlotSubtitleView.<PreloadOpenBackgroundUi>d__219>(ref <PreloadOpenBackgroundUi>d__);
		return <PreloadOpenBackgroundUi>d__.<>t__builder.Task;
	}

	// Token: 0x06015FC9 RID: 90057 RVA: 0x0058D958 File Offset: 0x0058BB58
	[NullableContext(1)]
	public UniTask PrePreloadOpenBackgroundUi(List<string> uiNameArray, bool useFullscreenAdaptAnchor = false)
	{
		PlotSubtitleView.<PrePreloadOpenBackgroundUi>d__220 <PrePreloadOpenBackgroundUi>d__;
		<PrePreloadOpenBackgroundUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PrePreloadOpenBackgroundUi>d__.<>4__this = this;
		<PrePreloadOpenBackgroundUi>d__.uiNameArray = uiNameArray;
		<PrePreloadOpenBackgroundUi>d__.useFullscreenAdaptAnchor = useFullscreenAdaptAnchor;
		<PrePreloadOpenBackgroundUi>d__.<>1__state = -1;
		<PrePreloadOpenBackgroundUi>d__.<>t__builder.Start<PlotSubtitleView.<PrePreloadOpenBackgroundUi>d__220>(ref <PrePreloadOpenBackgroundUi>d__);
		return <PrePreloadOpenBackgroundUi>d__.<>t__builder.Task;
	}

	// Token: 0x06015FCA RID: 90058 RVA: 0x0058D9AC File Offset: 0x0058BBAC
	[NullableContext(1)]
	public UniTask OpenBackgroundUi(string uiName, string spineName, bool needLoop = true, bool useFullscreenAdaptAnchor = false)
	{
		PlotSubtitleView.<OpenBackgroundUi>d__221 <OpenBackgroundUi>d__;
		<OpenBackgroundUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenBackgroundUi>d__.<>4__this = this;
		<OpenBackgroundUi>d__.uiName = uiName;
		<OpenBackgroundUi>d__.spineName = spineName;
		<OpenBackgroundUi>d__.needLoop = needLoop;
		<OpenBackgroundUi>d__.useFullscreenAdaptAnchor = useFullscreenAdaptAnchor;
		<OpenBackgroundUi>d__.<>1__state = -1;
		<OpenBackgroundUi>d__.<>t__builder.Start<PlotSubtitleView.<OpenBackgroundUi>d__221>(ref <OpenBackgroundUi>d__);
		return <OpenBackgroundUi>d__.<>t__builder.Task;
	}

	// Token: 0x06015FCB RID: 90059 RVA: 0x0058DA10 File Offset: 0x0058BC10
	[NullableContext(1)]
	public UniTask OpenBackgroundUiForSeekSpine(string uiName, TArray<SpineThingsInfo> spineArray, bool useFullscreenAdaptAnchor = false)
	{
		PlotSubtitleView.<OpenBackgroundUiForSeekSpine>d__222 <OpenBackgroundUiForSeekSpine>d__;
		<OpenBackgroundUiForSeekSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenBackgroundUiForSeekSpine>d__.<>4__this = this;
		<OpenBackgroundUiForSeekSpine>d__.uiName = uiName;
		<OpenBackgroundUiForSeekSpine>d__.spineArray = spineArray;
		<OpenBackgroundUiForSeekSpine>d__.useFullscreenAdaptAnchor = useFullscreenAdaptAnchor;
		<OpenBackgroundUiForSeekSpine>d__.<>1__state = -1;
		<OpenBackgroundUiForSeekSpine>d__.<>t__builder.Start<PlotSubtitleView.<OpenBackgroundUiForSeekSpine>d__222>(ref <OpenBackgroundUiForSeekSpine>d__);
		return <OpenBackgroundUiForSeekSpine>d__.<>t__builder.Task;
	}

	// Token: 0x06015FCC RID: 90060 RVA: 0x0058DA6C File Offset: 0x0058BC6C
	[NullableContext(1)]
	public UniTask PlayUiLevelSeq(string seqName)
	{
		PlotSubtitleView.<PlayUiLevelSeq>d__223 <PlayUiLevelSeq>d__;
		<PlayUiLevelSeq>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayUiLevelSeq>d__.<>4__this = this;
		<PlayUiLevelSeq>d__.seqName = seqName;
		<PlayUiLevelSeq>d__.<>1__state = -1;
		<PlayUiLevelSeq>d__.<>t__builder.Start<PlotSubtitleView.<PlayUiLevelSeq>d__223>(ref <PlayUiLevelSeq>d__);
		return <PlayUiLevelSeq>d__.<>t__builder.Task;
	}

	// Token: 0x06015FCD RID: 90061 RVA: 0x0058DAB8 File Offset: 0x0058BCB8
	public UniTask CloseBackgroundUiThis()
	{
		PlotSubtitleView.<CloseBackgroundUiThis>d__224 <CloseBackgroundUiThis>d__;
		<CloseBackgroundUiThis>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseBackgroundUiThis>d__.<>4__this = this;
		<CloseBackgroundUiThis>d__.<>1__state = -1;
		<CloseBackgroundUiThis>d__.<>t__builder.Start<PlotSubtitleView.<CloseBackgroundUiThis>d__224>(ref <CloseBackgroundUiThis>d__);
		return <CloseBackgroundUiThis>d__.<>t__builder.Task;
	}

	// Token: 0x06015FCE RID: 90062 RVA: 0x0058DAFC File Offset: 0x0058BCFC
	[NullableContext(1)]
	public UniTask CloseWhichBackgroundUi(PlotChildView sonUi)
	{
		PlotSubtitleView.<CloseWhichBackgroundUi>d__225 <CloseWhichBackgroundUi>d__;
		<CloseWhichBackgroundUi>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseWhichBackgroundUi>d__.<>4__this = this;
		<CloseWhichBackgroundUi>d__.sonUi = sonUi;
		<CloseWhichBackgroundUi>d__.<>1__state = -1;
		<CloseWhichBackgroundUi>d__.<>t__builder.Start<PlotSubtitleView.<CloseWhichBackgroundUi>d__225>(ref <CloseWhichBackgroundUi>d__);
		return <CloseWhichBackgroundUi>d__.<>t__builder.Task;
	}

	// Token: 0x06015FCF RID: 90063 RVA: 0x0058DB48 File Offset: 0x0058BD48
	public void CloseSpineAnimation(string str, float blendOutTime = 0f)
	{
		if (string.IsNullOrEmpty(str))
		{
			return;
		}
		if (this.SonUiInclude == null)
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "Ui预览图:不存在的PlotView子界面，关闭失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.SonUiInclude.CloseSpineAnimation(str, blendOutTime);
	}

	// Token: 0x06015FD0 RID: 90064 RVA: 0x0058DB90 File Offset: 0x0058BD90
	public bool PlaySonUiSpine(string spineName, bool needLoop = true, bool freeze = false, float duration = 0f)
	{
		if (string.IsNullOrEmpty(spineName))
		{
			global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.JYS, "Ui预览图:SpineName为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		if (this.SonUiInclude == null)
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "Ui预览图:不存在的PlotView子界面,已加入队列", default(ReadOnlySpan<ValueTuple<string, object>>));
			SpineQueueInfo spineQueueInfo = new SpineQueueInfo();
			spineQueueInfo.Name = spineName;
			spineQueueInfo.NeedLoop = new bool?(needLoop);
			spineQueueInfo.Freeze = freeze;
			spineQueueInfo.MixDuration = 0f;
			Queue<SpineQueueInfo> spineQueue = this.SpineQueue;
			if (spineQueue != null)
			{
				spineQueue.Push(spineQueueInfo);
			}
			return false;
		}
		return this.SonUiInclude.PlaySpineAnimation(spineName, needLoop, freeze, duration);
	}

	// Token: 0x06015FD1 RID: 90065 RVA: 0x0058DC38 File Offset: 0x0058BE38
	[NullableContext(1)]
	public void PlaySonUiSpineInArray(TArray<SpineThingsInfo> spineArray)
	{
		if (spineArray.Num() <= 0)
		{
			global::Log.Instance.Warn(ELogModule.Plot, ELogAuthor.JYS, "Ui预览图:spineArray为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (this.SonUiInclude == null)
		{
			global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "Ui预览图:不存在的PlotView子界面,已加入队列", default(ReadOnlySpan<ValueTuple<string, object>>));
			for (int i = 0; i < spineArray.Num(); i++)
			{
				SpineThingsInfo spineThingsInfo = spineArray.Get(i);
				SpineQueueInfo spineQueueInfo = new SpineQueueInfo();
				spineQueueInfo.Name = spineThingsInfo.Name;
				spineQueueInfo.NeedLoop = new bool?(spineThingsInfo.NeedLoop);
				Queue<SpineQueueInfo> spineQueue = this.SpineQueue;
				if (spineQueue != null)
				{
					spineQueue.Push(spineQueueInfo);
				}
			}
			return;
		}
		for (int j = 0; j < spineArray.Num(); j++)
		{
			this.SonUiInclude.PlaySpineAnimation(spineArray.Get(j).Name, spineArray.Get(j).NeedLoop, false, 0f);
		}
	}

	// Token: 0x06015FD2 RID: 90066 RVA: 0x0058DD1F File Offset: 0x0058BF1F
	public void UpdateSpineForQte(float percentage)
	{
		if (this.SonUiInclude == null)
		{
			return;
		}
		this.SonUiInclude.UpdateFrozenSpine(percentage);
	}

	// Token: 0x06015FD3 RID: 90067 RVA: 0x0058DD36 File Offset: 0x0058BF36
	[NullableContext(1)]
	public void UpdateSpineForQteByName(string spineName, float percentage)
	{
		if (this.SonUiInclude == null)
		{
			return;
		}
		this.SonUiInclude.UpdateFrozenSpineByName(spineName, percentage);
	}

	// Token: 0x06015FD4 RID: 90068 RVA: 0x0058DD50 File Offset: 0x0058BF50
	public void ManualUpdateNiagara([Nullable(new byte[]
	{
		2,
		1
	})] List<string> niagaraParamNames, float value)
	{
		if (niagaraParamNames == null || niagaraParamNames.Count == 0)
		{
			return;
		}
		if (this.SonUiInclude == null)
		{
			global::Log.Instance.Error(ELogModule.Plot, ELogAuthor.JYS, "Ui预览图:不存在的PlotView子界面,已加入队列", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		PlotChildView sonUiInclude = this.SonUiInclude;
		if (sonUiInclude == null)
		{
			return;
		}
		sonUiInclude.ManualUpdateNiagara(niagaraParamNames, value);
	}

	// Token: 0x06015FD5 RID: 90069 RVA: 0x0058DDA0 File Offset: 0x0058BFA0
	[NullableContext(1)]
	public void RestoreFreezeSpine(string spineName, bool isLoop = false)
	{
		if (this.SonUiInclude == null)
		{
			global::Log.Instance.Error(ELogModule.Plot, ELogAuthor.JYS, "Ui预览图:不存在的PlotView子界面,已加入队列", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		PlotChildView sonUiInclude = this.SonUiInclude;
		if (sonUiInclude == null)
		{
			return;
		}
		sonUiInclude.RestoreFreezeSpine(spineName, isLoop);
	}

	// Token: 0x06015FD6 RID: 90070 RVA: 0x0058DDE4 File Offset: 0x0058BFE4
	public bool RegisterCallback([Nullable(new byte[]
	{
		2,
		1
	})] Action<string> callback)
	{
		if (this.SonUiInclude == null)
		{
			global::Log.Instance.Error(ELogModule.Plot, ELogAuthor.JYS, "Ui预览图:不存在的PlotView子界面", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		this.SonUiInclude.FiniteSpineEndCallback = callback;
		return true;
	}

	// Token: 0x06015FD7 RID: 90071 RVA: 0x0058DE24 File Offset: 0x0058C024
	private void DoSpineQueue()
	{
		if (this.SpineQueue == null || this.SonUiInclude == null)
		{
			return;
		}
		while (this.SpineQueue.Size > 0)
		{
			SpineQueueInfo spineQueueInfo = this.SpineQueue.First<SpineQueueInfo>();
			if (spineQueueInfo == null)
			{
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "Ui预览图:Queue播放但Spine队列异常", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "Ui预览图:Queue播放";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", spineQueueInfo);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.SonUiInclude.PlaySpineAnimation(spineQueueInfo.Name, spineQueueInfo.NeedLoop.Value, spineQueueInfo.Freeze, spineQueueInfo.MixDuration);
			this.SpineQueue.Pop();
		}
	}

	// Token: 0x06015FD8 RID: 90072 RVA: 0x0058DEE0 File Offset: 0x0058C0E0
	[NullableContext(1)]
	[return: Nullable(2)]
	private unsafe PlotChildView FindSonViewInMap(string str)
	{
		if (this.SonUiIncludeMap == null)
		{
			return null;
		}
		PlotChildView plotChildView;
		if (this.SonUiIncludeMap.TryGetValue(str, out plotChildView))
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "Ui预览图:FindSonViewInMap 找到对应的预制体";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", str);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("son", plotChildView);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return plotChildView;
		}
		return null;
	}

	// Token: 0x06015FD9 RID: 90073 RVA: 0x0058DF60 File Offset: 0x0058C160
	[NullableContext(1)]
	private unsafe void DeleteSonViewInMap(PlotChildView childView)
	{
		if (this.SonUiIncludeMap == null)
		{
			return;
		}
		string text = null;
		foreach (KeyValuePair<string, PlotChildView> keyValuePair in this.SonUiIncludeMap)
		{
			if (childView == keyValuePair.Value)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Plot;
				ELogAuthor author = ELogAuthor.JYS;
				string message = "Ui预览图:DeleteSonViewInMap 找到对应的预制体";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", keyValuePair.Key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("son", keyValuePair.Value);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				text = keyValuePair.Key;
				break;
			}
		}
		if (!string.IsNullOrEmpty(text))
		{
			this.SonUiIncludeMap.Remove(text);
		}
	}

	// Token: 0x06015FDA RID: 90074 RVA: 0x0058E044 File Offset: 0x0058C244
	[NullableContext(1)]
	public void SetIconBySequence(bool bShow, UTexture2D texture, BP_KuroMasterSeqEvent_C obj)
	{
		if (bShow)
		{
			this.TickIconAlpha = true;
			this.EventObject = obj;
			UUITexture widgetMiddle = this.WidgetMiddle;
			if (widgetMiddle != null)
			{
				widgetMiddle.SetTexture(texture);
			}
			UUITexture widgetMiddle2 = this.WidgetMiddle;
			if (widgetMiddle2 != null)
			{
				widgetMiddle2.SetUIActive(true);
			}
			UUISprite bgWidgetMiddle = this.BgWidgetMiddle;
			if (bgWidgetMiddle == null)
			{
				return;
			}
			bgWidgetMiddle.SetUIActive(true);
			return;
		}
		else
		{
			this.TickIconAlpha = false;
			this.EventObject = null;
			base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/T_CommonDefault_UI.T_CommonDefault_UI", this.WidgetMiddle, null, null);
			UUITexture widgetMiddle3 = this.WidgetMiddle;
			if (widgetMiddle3 != null)
			{
				widgetMiddle3.SetUIActive(false);
			}
			UUISprite bgWidgetMiddle2 = this.BgWidgetMiddle;
			if (bgWidgetMiddle2 == null)
			{
				return;
			}
			bgWidgetMiddle2.SetUIActive(false);
			return;
		}
	}

	// Token: 0x06015FDB RID: 90075 RVA: 0x0058E0E4 File Offset: 0x0058C2E4
	private void TickDebugInfo()
	{
		bool shouldShowDebugInfoOnView = PlotModel.Instance.ShouldShowDebugInfoOnView;
		UUIText text = base.GetText(42);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(shouldShowDebugInfoOnView);
		if (!shouldShowDebugInfoOnView)
		{
			return;
		}
		string currentSequenceDebugInfo = SequenceController.Instance.GetCurrentSequenceDebugInfo();
		text.SetText(currentSequenceDebugInfo, true);
	}

	// Token: 0x0400A348 RID: 41800
	private string SubtitleKey = "";

	// Token: 0x0400A349 RID: 41801
	[Nullable(1)]
	public readonly List<string> OptionKeys = new List<string>();

	// Token: 0x0400A34A RID: 41802
	[Nullable(1)]
	public readonly List<int> OsList = new List<int>();

	// Token: 0x0400A34B RID: 41803
	private string AudioKey = "";

	// Token: 0x0400A34C RID: 41804
	private SubtitleInfo SubtitleInfo;

	// Token: 0x0400A34D RID: 41805
	private ULGUIPlayTweenComponent SubtitleAnimation;

	// Token: 0x0400A34E RID: 41806
	private UUIEffectTextAnimation SubtitleAnimDataComp;

	// Token: 0x0400A34F RID: 41807
	private bool IsCurSubtitlePaused;

	// Token: 0x0400A350 RID: 41808
	[Nullable(1)]
	private readonly PlayResult NormalPlayEventResult = new PlayResult();

	// Token: 0x0400A351 RID: 41809
	[Nullable(1)]
	private readonly PlayResult IndependentPlayEventResult = new PlayResult();

	// Token: 0x0400A352 RID: 41810
	private double AudioStartTime;

	// Token: 0x0400A353 RID: 41811
	private float Duration;

	// Token: 0x0400A354 RID: 41812
	private TimerHandle AudioDelayTimerId;

	// Token: 0x0400A355 RID: 41813
	private PlotAudio? AudioConfig;

	// Token: 0x0400A356 RID: 41814
	private UUIItem SkipSubtitleTipItem;

	// Token: 0x0400A357 RID: 41815
	private UUIItem SkipSubtitleTipItemNew;

	// Token: 0x0400A358 RID: 41816
	private float PlotTextInitialAnchorY;

	// Token: 0x0400A359 RID: 41817
	private TimerHandle WaitingSkipTimerId;

	// Token: 0x0400A35A RID: 41818
	public int HoverIndex;

	// Token: 0x0400A35B RID: 41819
	private AUIContainerActor ScreenEffectPlotRoot;

	// Token: 0x0400A35C RID: 41820
	[Nullable(new byte[]
	{
		2,
		1,
		2
	})]
	private GenericLayout<PlotOptionItem, object> OptionLayout;

	// Token: 0x0400A35D RID: 41821
	private bool IsOptionShow;

	// Token: 0x0400A35E RID: 41822
	private PlotSkipComponent SkipComp;

	// Token: 0x0400A35F RID: 41823
	private PlotReviewComponent ReviewComp;

	// Token: 0x0400A360 RID: 41824
	private bool IsVisible = true;

	// Token: 0x0400A361 RID: 41825
	private bool ImmersiveInputWakeState = true;

	// Token: 0x0400A362 RID: 41826
	private bool? MainButtonsTweenShown;

	// Token: 0x0400A363 RID: 41827
	private bool? SkipTweenShown;

	// Token: 0x0400A364 RID: 41828
	private bool? ReviewTweenShown;

	// Token: 0x0400A365 RID: 41829
	private bool PendingImmersiveSleep;

	// Token: 0x0400A366 RID: 41830
	private TimerHandle PendingImmersiveSleepTimerId;

	// Token: 0x0400A367 RID: 41831
	private TimerHandle SizeChangedTimerId;

	// Token: 0x0400A368 RID: 41832
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap;

	// Token: 0x0400A369 RID: 41833
	private PlotOptionItem SelectedPlotOptionItem;

	// Token: 0x0400A36A RID: 41834
	private EPlotLevel? Level;

	// Token: 0x0400A36B RID: 41835
	private EPlotLevel? SubtitleLevel;

	// Token: 0x0400A36C RID: 41836
	[Nullable(1)]
	public List<PlotOption> CurOption = new List<PlotOption>();

	// Token: 0x0400A36D RID: 41837
	private float FadeTimePhoto;

	// Token: 0x0400A36E RID: 41838
	private bool IsFadeInPhoto;

	// Token: 0x0400A36F RID: 41839
	private bool TickPhotoFade;

	// Token: 0x0400A370 RID: 41840
	private bool IsAlreadyHavePhoto;

	// Token: 0x0400A371 RID: 41841
	private bool? IsFullPhoto;

	// Token: 0x0400A372 RID: 41842
	private bool IsBlackBgShow;

	// Token: 0x0400A373 RID: 41843
	private bool CanShowAutoButtonByPlotConfig = true;

	// Token: 0x0400A374 RID: 41844
	private bool CanShowHideButtonByPlotConfig = true;

	// Token: 0x0400A375 RID: 41845
	private bool CanShowReviewButtonByPlotConfig = true;

	// Token: 0x0400A376 RID: 41846
	[Nullable(1)]
	private readonly Dictionary<string, bool> DisableInteractSources = new Dictionary<string, bool>();

	// Token: 0x0400A377 RID: 41847
	[Nullable(1)]
	private readonly HashSet<string> DisableSkipSources = new HashSet<string>();

	// Token: 0x0400A378 RID: 41848
	private UUITexture BgWidget;

	// Token: 0x0400A379 RID: 41849
	private UUITexture BgWidgetFront;

	// Token: 0x0400A37A RID: 41850
	private UUITexture WidgetMiddle;

	// Token: 0x0400A37B RID: 41851
	private UUISprite BgWidgetMiddle;

	// Token: 0x0400A37C RID: 41852
	private CustomPromise<bool> PlotFadeShowPromise;

	// Token: 0x0400A37D RID: 41853
	private CustomPromise<bool> PlotFadeHidePromise;

	// Token: 0x0400A37E RID: 41854
	private Action<ITalkItem> PlotViewPhotoCallback;

	// Token: 0x0400A37F RID: 41855
	private ETalkBackgroundType? NowBackgroundConfig;

	// Token: 0x0400A380 RID: 41856
	private UUIItem SonUi;

	// Token: 0x0400A381 RID: 41857
	private UUIItem FullscreenAdaptAnchor;

	// Token: 0x0400A382 RID: 41858
	public PlotChildView SonUiInclude;

	// Token: 0x0400A383 RID: 41859
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, PlotChildView> SonUiIncludeMap;

	// Token: 0x0400A384 RID: 41860
	private TimerHandle BlockOptionTimer;

	// Token: 0x0400A385 RID: 41861
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Queue<SpineQueueInfo> SpineQueue;

	// Token: 0x0400A386 RID: 41862
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Queue<PlotChildView> SonUiQueue;

	// Token: 0x0400A387 RID: 41863
	private UUISliderComponent OptionLimitBar;

	// Token: 0x0400A388 RID: 41864
	private UUISliderComponent AutoSelectTimeBar;

	// Token: 0x0400A389 RID: 41865
	[Nullable(1)]
	private readonly PlotAutoSelectOptionComponent AutoSelectOptionComponent = new PlotAutoSelectOptionComponent();

	// Token: 0x0400A38A RID: 41866
	[Nullable(1)]
	private readonly PlotAudioDelegate AudioDelegate = new PlotAudioDelegate();

	// Token: 0x0400A38B RID: 41867
	private TimerHandle AudioPlayTimer;

	// Token: 0x0400A38C RID: 41868
	private TimerHandle DelayAutoPlayTimer;

	// Token: 0x0400A38D RID: 41869
	private float TextScrollViewPrefabHeight;

	// Token: 0x0400A38E RID: 41870
	private TimerHandle ScrollStartTimer;

	// Token: 0x0400A38F RID: 41871
	public bool HasChildViewPreloaded;

	// Token: 0x0400A390 RID: 41872
	private bool MuteTimeLimitedOption;

	// Token: 0x0400A391 RID: 41873
	private float ScrollTotalTime;

	// Token: 0x0400A392 RID: 41874
	private float CurrentAnimTime;

	// Token: 0x0400A393 RID: 41875
	private TimerHandle TextScrollAnimTimer;

	// Token: 0x0400A394 RID: 41876
	private TimerHandle DelayTextScrollAnimTimer;

	// Token: 0x0400A395 RID: 41877
	private IPostAkEventType LastEndEvent;

	// Token: 0x0400A396 RID: 41878
	private bool TickIconAlpha;

	// Token: 0x0400A397 RID: 41879
	private BP_KuroMasterSeqEvent_C EventObject;

	// Token: 0x02008F70 RID: 36720
	[NullableContext(0)]
	private enum EPlotChildCom
	{
		// Token: 0x0402E74D RID: 190285
		BtnAuto,
		// Token: 0x0402E74E RID: 190286
		BtnNextPage,
		// Token: 0x0402E74F RID: 190287
		BtnSkip,
		// Token: 0x0402E750 RID: 190288
		PlotText,
		// Token: 0x0402E751 RID: 190289
		NPCName,
		// Token: 0x0402E752 RID: 190290
		TxtList,
		// Token: 0x0402E753 RID: 190291
		OptionItem,
		// Token: 0x0402E754 RID: 190292
		OptionLayout,
		// Token: 0x0402E755 RID: 190293
		TextList,
		// Token: 0x0402E756 RID: 190294
		PlotBg,
		// Token: 0x0402E757 RID: 190295
		PlotTextUHD,
		// Token: 0x0402E758 RID: 190296
		PanelLine,
		// Token: 0x0402E759 RID: 190297
		TxtFloat,
		// Token: 0x0402E75A RID: 190298
		ScreenEffect,
		// Token: 0x0402E75B RID: 190299
		AutoPlayManualItem,
		// Token: 0x0402E75C RID: 190300
		AutuPlaySemiAutoItem,
		// Token: 0x0402E75D RID: 190301
		AutuPlayAutoItem,
		// Token: 0x0402E75E RID: 190302
		NPCTitle,
		// Token: 0x0402E75F RID: 190303
		BtnHide,
		// Token: 0x0402E760 RID: 190304
		NextIcon,
		// Token: 0x0402E761 RID: 190305
		WaitingPoint,
		// Token: 0x0402E762 RID: 190306
		BlackScreenBg,
		// Token: 0x0402E763 RID: 190307
		PhotoScreenBg,
		// Token: 0x0402E764 RID: 190308
		PhotoScreenBgFront,
		// Token: 0x0402E765 RID: 190309
		DoingText,
		// Token: 0x0402E766 RID: 190310
		PhotoScreenMiddle,
		// Token: 0x0402E767 RID: 190311
		PhotoScreenBgMiddle,
		// Token: 0x0402E768 RID: 190312
		TextScrollView,
		// Token: 0x0402E769 RID: 190313
		OptionAdjustItem,
		// Token: 0x0402E76A RID: 190314
		PnlBg,
		// Token: 0x0402E76B RID: 190315
		PnlInfo,
		// Token: 0x0402E76C RID: 190316
		SonUi,
		// Token: 0x0402E76D RID: 190317
		BlockOption,
		// Token: 0x0402E76E RID: 190318
		BtnReview,
		// Token: 0x0402E76F RID: 190319
		OptionLimitBar,
		// Token: 0x0402E770 RID: 190320
		VideoLayout,
		// Token: 0x0402E771 RID: 190321
		AniSkipIn,
		// Token: 0x0402E772 RID: 190322
		AniSkipOut,
		// Token: 0x0402E773 RID: 190323
		AniReviewIn,
		// Token: 0x0402E774 RID: 190324
		AniReviewOut,
		// Token: 0x0402E775 RID: 190325
		AniAutoHideIn,
		// Token: 0x0402E776 RID: 190326
		AniAutoHideOut,
		// Token: 0x0402E777 RID: 190327
		TextDebugInfo,
		// Token: 0x0402E778 RID: 190328
		FullscreenAdaptAnchor,
		// Token: 0x0402E779 RID: 190329
		ImportantList,
		// Token: 0x0402E77A RID: 190330
		PnlLayout02,
		// Token: 0x0402E77B RID: 190331
		TextScrollViewCopy,
		// Token: 0x0402E77C RID: 190332
		ImportantOptionTipsIcon,
		// Token: 0x0402E77D RID: 190333
		ImportantOptionTipsText,
		// Token: 0x0402E77E RID: 190334
		AutoSelectTimeBar,
		// Token: 0x0402E77F RID: 190335
		AutoSelectText,
		// Token: 0x0402E780 RID: 190336
		AniAutoTextIn,
		// Token: 0x0402E781 RID: 190337
		AniAutoTextOut,
		// Token: 0x0402E782 RID: 190338
		NextIconNew
	}
}
