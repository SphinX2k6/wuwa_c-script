using System;
using System.Collections.Generic;
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

// Token: 0x02001EF2 RID: 7922
[NullableContext(2)]
[Nullable(0)]
public class PlotSubtitleView : UiTickViewBase, ISimulatePlot
{
	// Token: 0x06013944 RID: 80196 RVA: 0x005B3DD4 File Offset: 0x005B1FD4
	[NullableContext(1)]
	public PlotSubtitleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013945 RID: 80197 RVA: 0x005B3E84 File Offset: 0x005B2084
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

	// Token: 0x17001DE1 RID: 7649
	// (get) Token: 0x06013946 RID: 80198 RVA: 0x005B3F07 File Offset: 0x005B2107
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

	// Token: 0x17001DE2 RID: 7650
	// (get) Token: 0x06013947 RID: 80199 RVA: 0x005B3F26 File Offset: 0x005B2126
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

	// Token: 0x06013948 RID: 80200 RVA: 0x005B3F3C File Offset: 0x005B213C
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

	// Token: 0x06013949 RID: 80201 RVA: 0x005B4730 File Offset: 0x005B2930
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

	// Token: 0x0601394A RID: 80202 RVA: 0x005B4C7C File Offset: 0x005B2E7C
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

	// Token: 0x0601394B RID: 80203 RVA: 0x005B4CD4 File Offset: 0x005B2ED4
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

	// Token: 0x0601394C RID: 80204 RVA: 0x005B4DA6 File Offset: 0x005B2FA6
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

	// Token: 0x0601394D RID: 80205 RVA: 0x005B4DE0 File Offset: 0x005B2FE0
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		PlotSubtitleView.<OnPlayingStartSequenceAsync>d__85 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PlotSubtitleView.<OnPlayingStartSequenceAsync>d__85>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601394E RID: 80206 RVA: 0x005B4E24 File Offset: 0x005B3024
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

	// Token: 0x0601394F RID: 80207 RVA: 0x005B4E88 File Offset: 0x005B3088
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		PlotSubtitleView.<OnPlayingCloseSequenceAsync>d__87 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<PlotSubtitleView.<OnPlayingCloseSequenceAsync>d__87>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013950 RID: 80208 RVA: 0x005B4ECC File Offset: 0x005B30CC
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

	// Token: 0x06013951 RID: 80209 RVA: 0x005B504D File Offset: 0x005B324D
	[NullableContext(1)]
	private PlotOptionItem InitOptionItem()
	{
		PlotOptionItem plotOptionItem = new PlotOptionItem(this);
		plotOptionItem.BindOnHover(new Action<PlotOptionItem>(this.OnPlotOptionItemHover));
		return plotOptionItem;
	}

	// Token: 0x06013952 RID: 80210 RVA: 0x005B5067 File Offset: 0x005B3267
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

	// Token: 0x06013953 RID: 80211 RVA: 0x005B5094 File Offset: 0x005B3294
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

	// Token: 0x06013954 RID: 80212 RVA: 0x005B50F8 File Offset: 0x005B32F8
	private void ShowWaitingPoint(bool enable)
	{
		bool uiactive = enable && !PlotModel.Instance.IsNewSubtitleStyleActive();
		base.GetItem(20).SetUIActive(uiactive);
		if (this.SubtitleLevel.GetValueOrDefault() == EPlotLevel.LevelB)
		{
			TermExplanationController.Instance.SetEnableHyperLink(base.GetText(5), !enable);
		}
	}

	// Token: 0x06013955 RID: 80213 RVA: 0x005B514A File Offset: 0x005B334A
	[NullableContext(1)]
	private void OnMovieModeAspectOffsetChanged(IMovieModeAspectOffset _)
	{
		this.UpdatePlotTextOffset();
	}

	// Token: 0x06013956 RID: 80214 RVA: 0x005B5152 File Offset: 0x005B3352
	private void OnMovieModeAspectOffsetChanged(bool _, IMovieModeAspectOffset __)
	{
		this.UpdatePlotTextOffset();
	}

	// Token: 0x06013957 RID: 80215 RVA: 0x005B515C File Offset: 0x005B335C
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

	// Token: 0x06013958 RID: 80216 RVA: 0x005B51BC File Offset: 0x005B33BC
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

	// Token: 0x06013959 RID: 80217 RVA: 0x005B52B4 File Offset: 0x005B34B4
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

	// Token: 0x0601395A RID: 80218 RVA: 0x005B5328 File Offset: 0x005B3528
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

	// Token: 0x0601395B RID: 80219 RVA: 0x005B539E File Offset: 0x005B359E
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

	// Token: 0x0601395C RID: 80220 RVA: 0x005B53CC File Offset: 0x005B35CC
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

	// Token: 0x0601395D RID: 80221 RVA: 0x005B56E0 File Offset: 0x005B38E0
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

	// Token: 0x0601395E RID: 80222 RVA: 0x005B59C4 File Offset: 0x005B3BC4
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

	// Token: 0x0601395F RID: 80223 RVA: 0x005B5A28 File Offset: 0x005B3C28
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

	// Token: 0x06013960 RID: 80224 RVA: 0x005B5A74 File Offset: 0x005B3C74
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

	// Token: 0x06013961 RID: 80225 RVA: 0x005B5AC0 File Offset: 0x005B3CC0
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

	// Token: 0x06013962 RID: 80226 RVA: 0x005B5B03 File Offset: 0x005B3D03
	private void ApplySkipButtonState()
	{
		this.SkipComp.EnableSkipButton(this.DisableInteractSources.Count == 0 && this.DisableSkipSources.Count == 0);
		this.RestorePlotButtonsVisibility();
	}

	// Token: 0x06013963 RID: 80227 RVA: 0x005B5B34 File Offset: 0x005B3D34
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

	// Token: 0x06013964 RID: 80228 RVA: 0x005B5C80 File Offset: 0x005B3E80
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

	// Token: 0x06013965 RID: 80229 RVA: 0x005B5D24 File Offset: 0x005B3F24
	private void OnTermExplanationViewOpen(ETermExplanationViewType _)
	{
		this.MuteAutoPlay(true);
	}

	// Token: 0x06013966 RID: 80230 RVA: 0x005B5D2D File Offset: 0x005B3F2D
	private void OnTermExplanationViewClose()
	{
		this.MuteAutoPlay(false);
	}

	// Token: 0x06013967 RID: 80231 RVA: 0x005B5D38 File Offset: 0x005B3F38
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

	// Token: 0x06013968 RID: 80232 RVA: 0x005B5D94 File Offset: 0x005B3F94
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

	// Token: 0x06013969 RID: 80233 RVA: 0x005B5DF4 File Offset: 0x005B3FF4
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

	// Token: 0x0601396A RID: 80234 RVA: 0x005B5E3A File Offset: 0x005B403A
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

	// Token: 0x0601396B RID: 80235 RVA: 0x005B5E55 File Offset: 0x005B4055
	private void OnEnableSkipPlotRestoreTween(bool _)
	{
		this.RestorePlotButtonsVisibility();
	}

	// Token: 0x0601396C RID: 80236 RVA: 0x005B5E5D File Offset: 0x005B405D
	private void ClearPendingImmersiveSleep()
	{
		this.PendingImmersiveSleep = false;
		if (this.PendingImmersiveSleepTimerId != null && TimerSystem.Instance.Has(this.PendingImmersiveSleepTimerId))
		{
			TimerSystem.Instance.Remove(this.PendingImmersiveSleepTimerId);
		}
		this.PendingImmersiveSleepTimerId = null;
	}

	// Token: 0x0601396D RID: 80237 RVA: 0x005B5E98 File Offset: 0x005B4098
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

	// Token: 0x0601396E RID: 80238 RVA: 0x005B5F1C File Offset: 0x005B411C
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

	// Token: 0x0601396F RID: 80239 RVA: 0x005B5F90 File Offset: 0x005B4190
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

	// Token: 0x06013970 RID: 80240 RVA: 0x005B5FEC File Offset: 0x005B41EC
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

	// Token: 0x06013971 RID: 80241 RVA: 0x005B6048 File Offset: 0x005B4248
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

	// Token: 0x06013972 RID: 80242 RVA: 0x005B616C File Offset: 0x005B436C
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

	// Token: 0x06013973 RID: 80243 RVA: 0x005B6278 File Offset: 0x005B4478
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

	// Token: 0x06013974 RID: 80244 RVA: 0x005B6328 File Offset: 0x005B4528
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

	// Token: 0x06013975 RID: 80245 RVA: 0x005B6348 File Offset: 0x005B4548
	private void OnPlotConfigChanged()
	{
		this.UpdateByPlotConfig();
	}

	// Token: 0x06013976 RID: 80246 RVA: 0x005B6350 File Offset: 0x005B4550
	private void OnSkip()
	{
		this.MuteAutoPlay(false);
		this.ShowUiExceptPhoto();
		FlowController.Instance.BackgroundFlow("UI点击跳过(PlotSubtitleView)", true, false, true);
	}

	// Token: 0x06013977 RID: 80247 RVA: 0x005B6371 File Offset: 0x005B4571
	private void ShowDoingText(bool bShow)
	{
		base.GetItem(24).SetUIActive(bShow);
	}

	// Token: 0x06013978 RID: 80248 RVA: 0x005B6384 File Offset: 0x005B4584
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

	// Token: 0x06013979 RID: 80249 RVA: 0x005B6464 File Offset: 0x005B4664
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

	// Token: 0x0601397A RID: 80250 RVA: 0x005B6501 File Offset: 0x005B4701
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

	// Token: 0x0601397B RID: 80251 RVA: 0x005B653C File Offset: 0x005B473C
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

	// Token: 0x0601397C RID: 80252 RVA: 0x005B65F9 File Offset: 0x005B47F9
	private void OnSkipPop()
	{
		this.MuteAutoPlay(true);
		this.HideUiExceptPhoto();
	}

	// Token: 0x0601397D RID: 80253 RVA: 0x005B6608 File Offset: 0x005B4808
	private void OnSkipCancel()
	{
		this.MuteAutoPlay(false);
		this.ShowUiExceptPhoto();
	}

	// Token: 0x0601397E RID: 80254 RVA: 0x005B6617 File Offset: 0x005B4817
	private void OnBtnHideClick()
	{
		this.HideUiExceptPhoto();
		this.IsVisible = false;
		this.MuteAutoPlay(true);
	}

	// Token: 0x0601397F RID: 80255 RVA: 0x005B662D File Offset: 0x005B482D
	private void OnBtnReviewClick()
	{
		if (FlowController.Instance.OpenPlotReviewView())
		{
			this.HideUiExceptPhoto();
			this.MuteAutoPlay(true);
		}
	}

	// Token: 0x06013980 RID: 80256 RVA: 0x005B6648 File Offset: 0x005B4848
	private void OnOpenView(EUiViewName viewName, int _)
	{
		if (viewName == EUiViewName.PlotReviewView)
		{
			AudioSystem.Instance.PostEvent("plot_review_enter");
		}
	}

	// Token: 0x06013981 RID: 80257 RVA: 0x005B6667 File Offset: 0x005B4867
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

	// Token: 0x06013982 RID: 80258 RVA: 0x005B66A0 File Offset: 0x005B48A0
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

	// Token: 0x06013983 RID: 80259 RVA: 0x005B66C9 File Offset: 0x005B48C9
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

	// Token: 0x06013984 RID: 80260 RVA: 0x005B66F4 File Offset: 0x005B48F4
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

	// Token: 0x06013985 RID: 80261 RVA: 0x005B67AD File Offset: 0x005B49AD
	private void HideSubtitle()
	{
		this.ResetSubtitle();
		this.StopCurSubtitleAudio();
		this.SkipSubtitleTipItemActive(false);
		this.ShowWaitingPoint(false);
		this.StopWaitingSkipTimer();
		this.SubtitleInfo.Clear();
	}

	// Token: 0x06013986 RID: 80262 RVA: 0x005B67DC File Offset: 0x005B49DC
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
				ITalkItem currentSubtitle = this.CurrentSubtitle;
				if (currentSubtitle != null)
				{
					SequenceController.Instance.SelectOption(index, currentSubtitle.Id);
				}
			});
			this.SubtitleInfo.ShowOption = true;
			this.HandleSkipWaiting();
			return;
		}
		PlotModel.Instance.OptionEnable = true;
		this.SubtitleInfo.ShowOption = true;
		this.SetOptionsShow(true);
		this.CurOption = this.FilterOption(this.CurrentSubtitle.Options);
		this.OptionLayout.RefreshByData(new List<object>(this.CurOption), delegate
		{
			this.HandleOptionState();
			this.AutoSelectOptionComponent.OnOptionsShow();
		}, false);
		this.HandleSkipWaiting();
	}

	// Token: 0x06013987 RID: 80263 RVA: 0x005B68F0 File Offset: 0x005B4AF0
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

	// Token: 0x06013988 RID: 80264 RVA: 0x005B696A File Offset: 0x005B4B6A
	private void OnOptionSelected()
	{
		this.AutoSelectOptionComponent.OnOptionSelected();
	}

	// Token: 0x06013989 RID: 80265 RVA: 0x005B6977 File Offset: 0x005B4B77
	private void SelectOptionByIndex(int optionIndex)
	{
		SequenceController.Instance.SelectOption(optionIndex, this.CurrentSubtitle.Id);
	}

	// Token: 0x0601398A RID: 80266 RVA: 0x005B698F File Offset: 0x005B4B8F
	private void HideOption()
	{
		this.ClearOptions();
	}

	// Token: 0x0601398B RID: 80267 RVA: 0x005B6998 File Offset: 0x005B4B98
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

	// Token: 0x0601398C RID: 80268 RVA: 0x005B6A0C File Offset: 0x005B4C0C
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

	// Token: 0x0601398D RID: 80269 RVA: 0x005B6A54 File Offset: 0x005B4C54
	private void HideAll(bool isHidden)
	{
		this.RootItem.SetUIActive(!isHidden);
	}

	// Token: 0x0601398E RID: 80270 RVA: 0x005B6A68 File Offset: 0x005B4C68
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

	// Token: 0x0601398F RID: 80271 RVA: 0x005B6ACC File Offset: 0x005B4CCC
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

	// Token: 0x06013990 RID: 80272 RVA: 0x005B6B28 File Offset: 0x005B4D28
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

	// Token: 0x06013991 RID: 80273 RVA: 0x005B6BE7 File Offset: 0x005B4DE7
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

	// Token: 0x06013992 RID: 80274 RVA: 0x005B6C1C File Offset: 0x005B4E1C
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

	// Token: 0x06013993 RID: 80275 RVA: 0x005B6C84 File Offset: 0x005B4E84
	private void PlayAudioNow()
	{
		ExternalSourceSetting? config = ConfigExternalSourceSettingById.GetConfig(this.AudioConfig.Value.ExternalSourceSetting, true);
		string externalSourcesMediaName = PlotAudioModel.Instance.GetExternalSourcesMediaName(this.AudioConfig.Value);
		this.AudioDelegate.Enable();
		this.Duration = ((this.AudioConfig.Value.TailTime < 0) ? PlotModel.Instance.PlotGlobalConfig.AudioEndDelay : ((float)this.AudioConfig.Value.TailTime));
		AudioController.Instance.PostEventByExternalSourcesByUi(config.Value.SubtitleEvent, externalSourcesMediaName, config.Value.SubtitleSrc, this.NormalPlayEventResult, null, new int?(8), this.AudioDelegate.AudioDelegate);
	}

	// Token: 0x06013994 RID: 80276 RVA: 0x005B6D4E File Offset: 0x005B4F4E
	private void CallBackDuration(float duration)
	{
		this.Duration += duration;
		this.AudioPlayTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.OnAudioEnd();
		}, this.Duration, null, null, true, 1f);
	}

	// Token: 0x06013995 RID: 80277 RVA: 0x005B6D88 File Offset: 0x005B4F88
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

	// Token: 0x06013996 RID: 80278 RVA: 0x005B6E3F File Offset: 0x005B503F
	private void OnAutoPlayDelayEnd()
	{
		this.DelayAutoPlayTimer = null;
		if (this.IsCurSubtitlePaused)
		{
			this.ResumeSequence("Subtitle");
		}
	}

	// Token: 0x06013997 RID: 80279 RVA: 0x005B6E5C File Offset: 0x005B505C
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
		AudioController.Instance.StopEvent(this.NormalPlayEventResult, true, new int?(100));
		this.RemoveAudioDelayTimer();
		this.AudioConfig = null;
		this.RemoveAutoPlayDelay();
	}

	// Token: 0x06013998 RID: 80280 RVA: 0x005B6EF0 File Offset: 0x005B50F0
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

	// Token: 0x06013999 RID: 80281 RVA: 0x005B6FC2 File Offset: 0x005B51C2
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

	// Token: 0x0601399A RID: 80282 RVA: 0x005B6FF6 File Offset: 0x005B51F6
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

	// Token: 0x0601399B RID: 80283 RVA: 0x005B702C File Offset: 0x005B522C
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

	// Token: 0x0601399C RID: 80284 RVA: 0x005B7404 File Offset: 0x005B5604
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

	// Token: 0x0601399D RID: 80285 RVA: 0x005B7519 File Offset: 0x005B5719
	private float GetTextAnimSpeed()
	{
		if (this.Level.GetValueOrDefault() == EPlotLevel.LevelC)
		{
			return PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedLevelC;
		}
		return PlotModel.Instance.PlotGlobalConfig.TextAnimSpeedLevelD;
	}

	// Token: 0x0601399E RID: 80286 RVA: 0x005B7548 File Offset: 0x005B5748
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

	// Token: 0x0601399F RID: 80287 RVA: 0x005B75A0 File Offset: 0x005B57A0
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

	// Token: 0x060139A0 RID: 80288 RVA: 0x005B7604 File Offset: 0x005B5804
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

	// Token: 0x060139A1 RID: 80289 RVA: 0x005B76DE File Offset: 0x005B58DE
	private void ShowSeqSubtitleInternal()
	{
		this.SetSubtitleKey();
		this.SetOptions();
		this.SetAudioKeys();
		this.HandleAkEvent(true);
		this.PlaySubtitle();
	}

	// Token: 0x060139A2 RID: 80290 RVA: 0x005B7700 File Offset: 0x005B5900
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

	// Token: 0x060139A3 RID: 80291 RVA: 0x005B7750 File Offset: 0x005B5950
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

	// Token: 0x060139A4 RID: 80292 RVA: 0x005B7784 File Offset: 0x005B5984
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

	// Token: 0x060139A5 RID: 80293 RVA: 0x005B7810 File Offset: 0x005B5A10
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

	// Token: 0x060139A6 RID: 80294 RVA: 0x005B7918 File Offset: 0x005B5B18
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

	// Token: 0x060139A7 RID: 80295 RVA: 0x005B7972 File Offset: 0x005B5B72
	private void CloseTransitionView()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.PlotTransitionViewPop))
		{
			UiManager.Instance.CloseView(EUiViewName.PlotTransitionViewPop, null);
		}
	}

	// Token: 0x060139A8 RID: 80296 RVA: 0x005B7995 File Offset: 0x005B5B95
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

	// Token: 0x060139A9 RID: 80297 RVA: 0x005B79CC File Offset: 0x005B5BCC
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

	// Token: 0x060139AA RID: 80298 RVA: 0x005B7A1C File Offset: 0x005B5C1C
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

	// Token: 0x060139AB RID: 80299 RVA: 0x005B7A6C File Offset: 0x005B5C6C
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

	// Token: 0x060139AC RID: 80300 RVA: 0x005B7BCA File Offset: 0x005B5DCA
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

	// Token: 0x060139AD RID: 80301 RVA: 0x005B7BF4 File Offset: 0x005B5DF4
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

	// Token: 0x060139AE RID: 80302 RVA: 0x005B7CA8 File Offset: 0x005B5EA8
	private void StopIndependentAudio()
	{
		AudioController.Instance.StopEvent(this.IndependentPlayEventResult, true, null);
	}

	// Token: 0x060139AF RID: 80303 RVA: 0x005B7CCF File Offset: 0x005B5ECF
	private void JumpSequence()
	{
		this.SubtitleInfo.Skip = true;
		SequenceController.Instance.JumpToNextSubtitleOrChildSeq();
	}

	// Token: 0x060139B0 RID: 80304 RVA: 0x005B7CE7 File Offset: 0x005B5EE7
	[NullableContext(1)]
	private void PauseSequence(string reason = "Subtitle")
	{
		this.IsCurSubtitlePaused = true;
		SequenceController.Instance.PauseSequence(reason);
	}

	// Token: 0x060139B1 RID: 80305 RVA: 0x005B7CFC File Offset: 0x005B5EFC
	[NullableContext(1)]
	private void ResumeSequence(string reason = "Subtitle")
	{
		SequenceController.Instance.ResumeSequence(reason, null);
		this.IsCurSubtitlePaused = false;
		this.HideSeqSubtitleInternal();
	}

	// Token: 0x060139B2 RID: 80306 RVA: 0x005B7D2C File Offset: 0x005B5F2C
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

	// Token: 0x060139B3 RID: 80307 RVA: 0x005B7E88 File Offset: 0x005B6088
	private void SetSubtitleKey()
	{
		this.SubtitleKey = this.SubtitleInfo.CurrentConfig.TidTalk;
	}

	// Token: 0x060139B4 RID: 80308 RVA: 0x005B7EA0 File Offset: 0x005B60A0
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

	// Token: 0x060139B5 RID: 80309 RVA: 0x005B7F70 File Offset: 0x005B6170
	private void SetAudioKeys()
	{
		ITalkItem currentConfig = this.SubtitleInfo.CurrentConfig;
		this.AudioKey = ((currentConfig != null && currentConfig.PlayVoice.GetValueOrDefault()) ? this.SubtitleInfo.CurrentConfig.TidTalk : null);
	}

	// Token: 0x060139B6 RID: 80310 RVA: 0x005B7FB8 File Offset: 0x005B61B8
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

	// Token: 0x060139B7 RID: 80311 RVA: 0x005B8010 File Offset: 0x005B6210
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

	// Token: 0x060139B8 RID: 80312 RVA: 0x005B80EE File Offset: 0x005B62EE
	public string ParseSubtitle(string inText)
	{
		if (string.IsNullOrEmpty(inText))
		{
			return "";
		}
		return PlotModel.Instance.PlotTextReplacer.Replace(inText, false);
	}

	// Token: 0x060139B9 RID: 80313 RVA: 0x005B8110 File Offset: 0x005B6310
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

	// Token: 0x060139BA RID: 80314 RVA: 0x005B8178 File Offset: 0x005B6378
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

	// Token: 0x060139BB RID: 80315 RVA: 0x005B81DC File Offset: 0x005B63DC
	public void RemoveScreenEffectPlotRoot()
	{
		AUIContainerActor screenEffectPlotRoot = this.ScreenEffectPlotRoot;
		if (screenEffectPlotRoot != null && screenEffectPlotRoot.IsValid())
		{
			this.ScreenEffectPlotRoot.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
		}
		this.ScreenEffectPlotRoot = null;
	}

	// Token: 0x060139BC RID: 80316 RVA: 0x005B8207 File Offset: 0x005B6407
	[NullableContext(1)]
	public PlotOptionItem[] GetOptionList()
	{
		return this.OptionLayout.GetLayoutItemList().ToArray();
	}

	// Token: 0x060139BD RID: 80317 RVA: 0x005B821C File Offset: 0x005B641C
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
	}

	// Token: 0x060139BE RID: 80318 RVA: 0x005B827E File Offset: 0x005B647E
	public void SimulateClickSubtitle()
	{
	}

	// Token: 0x060139BF RID: 80319 RVA: 0x005B8280 File Offset: 0x005B6480
	public void SimulateClickOption()
	{
	}

	// Token: 0x060139C0 RID: 80320 RVA: 0x005B8290 File Offset: 0x005B6490
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

	// Token: 0x060139C1 RID: 80321 RVA: 0x005B82E4 File Offset: 0x005B64E4
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

	// Token: 0x060139C2 RID: 80322 RVA: 0x005B8348 File Offset: 0x005B6548
	private void AddTickPhoto()
	{
		this.TickPhotoFade = true;
	}

	// Token: 0x060139C3 RID: 80323 RVA: 0x005B8351 File Offset: 0x005B6551
	private void RemoveTickPhoto()
	{
		this.TickPhotoFade = false;
	}

	// Token: 0x060139C4 RID: 80324 RVA: 0x005B835C File Offset: 0x005B655C
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

	// Token: 0x060139C5 RID: 80325 RVA: 0x005B83D0 File Offset: 0x005B65D0
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

	// Token: 0x060139C6 RID: 80326 RVA: 0x005B8428 File Offset: 0x005B6628
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

	// Token: 0x060139C7 RID: 80327 RVA: 0x005B850C File Offset: 0x005B670C
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

	// Token: 0x060139C8 RID: 80328 RVA: 0x005B8720 File Offset: 0x005B6920
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

	// Token: 0x060139C9 RID: 80329 RVA: 0x005B8774 File Offset: 0x005B6974
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

	// Token: 0x060139CA RID: 80330 RVA: 0x005B87C0 File Offset: 0x005B69C0
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

	// Token: 0x060139CB RID: 80331 RVA: 0x005B8814 File Offset: 0x005B6A14
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

	// Token: 0x060139CC RID: 80332 RVA: 0x005B8860 File Offset: 0x005B6A60
	public UniTask RemovePhotoAtOnce()
	{
		PlotSubtitleView.<RemovePhotoAtOnce>d__217 <RemovePhotoAtOnce>d__;
		<RemovePhotoAtOnce>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RemovePhotoAtOnce>d__.<>4__this = this;
		<RemovePhotoAtOnce>d__.<>1__state = -1;
		<RemovePhotoAtOnce>d__.<>t__builder.Start<PlotSubtitleView.<RemovePhotoAtOnce>d__217>(ref <RemovePhotoAtOnce>d__);
		return <RemovePhotoAtOnce>d__.<>t__builder.Task;
	}

	// Token: 0x060139CD RID: 80333 RVA: 0x005B88A3 File Offset: 0x005B6AA3
	[NullableContext(1)]
	private UUIItem GetSonUiParentForBackgroundUi(bool useFullscreenAdaptAnchor = false)
	{
		if (!useFullscreenAdaptAnchor)
		{
			return this.SonUi;
		}
		return this.FullscreenAdaptAnchor;
	}

	// Token: 0x060139CE RID: 80334 RVA: 0x005B88B8 File Offset: 0x005B6AB8
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

	// Token: 0x060139CF RID: 80335 RVA: 0x005B890C File Offset: 0x005B6B0C
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

	// Token: 0x060139D0 RID: 80336 RVA: 0x005B8960 File Offset: 0x005B6B60
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

	// Token: 0x060139D1 RID: 80337 RVA: 0x005B89C4 File Offset: 0x005B6BC4
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

	// Token: 0x060139D2 RID: 80338 RVA: 0x005B8A20 File Offset: 0x005B6C20
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

	// Token: 0x060139D3 RID: 80339 RVA: 0x005B8A6C File Offset: 0x005B6C6C
	public UniTask CloseBackgroundUiThis()
	{
		PlotSubtitleView.<CloseBackgroundUiThis>d__224 <CloseBackgroundUiThis>d__;
		<CloseBackgroundUiThis>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseBackgroundUiThis>d__.<>4__this = this;
		<CloseBackgroundUiThis>d__.<>1__state = -1;
		<CloseBackgroundUiThis>d__.<>t__builder.Start<PlotSubtitleView.<CloseBackgroundUiThis>d__224>(ref <CloseBackgroundUiThis>d__);
		return <CloseBackgroundUiThis>d__.<>t__builder.Task;
	}

	// Token: 0x060139D4 RID: 80340 RVA: 0x005B8AB0 File Offset: 0x005B6CB0
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

	// Token: 0x060139D5 RID: 80341 RVA: 0x005B8AFC File Offset: 0x005B6CFC
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

	// Token: 0x060139D6 RID: 80342 RVA: 0x005B8B44 File Offset: 0x005B6D44
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

	// Token: 0x060139D7 RID: 80343 RVA: 0x005B8BEC File Offset: 0x005B6DEC
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

	// Token: 0x060139D8 RID: 80344 RVA: 0x005B8CD3 File Offset: 0x005B6ED3
	public void UpdateSpineForQte(float percentage)
	{
		if (this.SonUiInclude == null)
		{
			return;
		}
		this.SonUiInclude.UpdateFrozenSpine(percentage);
	}

	// Token: 0x060139D9 RID: 80345 RVA: 0x005B8CEA File Offset: 0x005B6EEA
	[NullableContext(1)]
	public void UpdateSpineForQteByName(string spineName, float percentage)
	{
		if (this.SonUiInclude == null)
		{
			return;
		}
		this.SonUiInclude.UpdateFrozenSpineByName(spineName, percentage);
	}

	// Token: 0x060139DA RID: 80346 RVA: 0x005B8D04 File Offset: 0x005B6F04
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

	// Token: 0x060139DB RID: 80347 RVA: 0x005B8D54 File Offset: 0x005B6F54
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

	// Token: 0x060139DC RID: 80348 RVA: 0x005B8D98 File Offset: 0x005B6F98
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

	// Token: 0x060139DD RID: 80349 RVA: 0x005B8DD8 File Offset: 0x005B6FD8
	private void DoSpineQueue()
	{
		if (this.SpineQueue == null || this.SonUiInclude == null)
		{
			return;
		}
		while (this.SpineQueue.Size > 0)
		{
			SpineQueueInfo front = this.SpineQueue.Front;
			if (front == null)
			{
				global::Log.Instance.Info(ELogModule.Plot, ELogAuthor.JYS, "Ui预览图:Queue播放但Spine队列异常", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Plot;
			ELogAuthor author = ELogAuthor.JYS;
			string message = "Ui预览图:Queue播放";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("name", front);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.SonUiInclude.PlaySpineAnimation(front.Name, front.NeedLoop.Value, front.Freeze, front.MixDuration);
			this.SpineQueue.Pop();
		}
	}

	// Token: 0x060139DE RID: 80350 RVA: 0x005B8E94 File Offset: 0x005B7094
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

	// Token: 0x060139DF RID: 80351 RVA: 0x005B8F14 File Offset: 0x005B7114
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

	// Token: 0x060139E0 RID: 80352 RVA: 0x005B8FF8 File Offset: 0x005B71F8
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

	// Token: 0x060139E1 RID: 80353 RVA: 0x005B9098 File Offset: 0x005B7298
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

	// Token: 0x0400A732 RID: 42802
	private string SubtitleKey = "";

	// Token: 0x0400A733 RID: 42803
	[Nullable(1)]
	public readonly List<string> OptionKeys = new List<string>();

	// Token: 0x0400A734 RID: 42804
	[Nullable(1)]
	public readonly List<int> OsList = new List<int>();

	// Token: 0x0400A735 RID: 42805
	private string AudioKey = "";

	// Token: 0x0400A736 RID: 42806
	private SubtitleInfo SubtitleInfo;

	// Token: 0x0400A737 RID: 42807
	private ULGUIPlayTweenComponent SubtitleAnimation;

	// Token: 0x0400A738 RID: 42808
	private UUIEffectTextAnimation SubtitleAnimDataComp;

	// Token: 0x0400A739 RID: 42809
	private bool IsCurSubtitlePaused;

	// Token: 0x0400A73A RID: 42810
	[Nullable(1)]
	private readonly PlayResult NormalPlayEventResult = new PlayResult();

	// Token: 0x0400A73B RID: 42811
	[Nullable(1)]
	private readonly PlayResult IndependentPlayEventResult = new PlayResult();

	// Token: 0x0400A73C RID: 42812
	private double AudioStartTime;

	// Token: 0x0400A73D RID: 42813
	private float Duration;

	// Token: 0x0400A73E RID: 42814
	private TimerHandle AudioDelayTimerId;

	// Token: 0x0400A73F RID: 42815
	private PlotAudio? AudioConfig;

	// Token: 0x0400A740 RID: 42816
	private UUIItem SkipSubtitleTipItem;

	// Token: 0x0400A741 RID: 42817
	private UUIItem SkipSubtitleTipItemNew;

	// Token: 0x0400A742 RID: 42818
	private float PlotTextInitialAnchorY;

	// Token: 0x0400A743 RID: 42819
	private TimerHandle WaitingSkipTimerId;

	// Token: 0x0400A744 RID: 42820
	public int HoverIndex;

	// Token: 0x0400A745 RID: 42821
	private AUIContainerActor ScreenEffectPlotRoot;

	// Token: 0x0400A746 RID: 42822
	[Nullable(new byte[]
	{
		2,
		1,
		2
	})]
	private GenericLayout<PlotOptionItem, object> OptionLayout;

	// Token: 0x0400A747 RID: 42823
	private bool IsOptionShow;

	// Token: 0x0400A748 RID: 42824
	private PlotSkipComponent SkipComp;

	// Token: 0x0400A749 RID: 42825
	private PlotReviewComponent ReviewComp;

	// Token: 0x0400A74A RID: 42826
	private bool IsVisible = true;

	// Token: 0x0400A74B RID: 42827
	private bool ImmersiveInputWakeState = true;

	// Token: 0x0400A74C RID: 42828
	private bool? MainButtonsTweenShown;

	// Token: 0x0400A74D RID: 42829
	private bool? SkipTweenShown;

	// Token: 0x0400A74E RID: 42830
	private bool? ReviewTweenShown;

	// Token: 0x0400A74F RID: 42831
	private bool PendingImmersiveSleep;

	// Token: 0x0400A750 RID: 42832
	private TimerHandle PendingImmersiveSleepTimerId;

	// Token: 0x0400A751 RID: 42833
	private TimerHandle SizeChangedTimerId;

	// Token: 0x0400A752 RID: 42834
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap;

	// Token: 0x0400A753 RID: 42835
	private PlotOptionItem SelectedPlotOptionItem;

	// Token: 0x0400A754 RID: 42836
	private EPlotLevel? Level;

	// Token: 0x0400A755 RID: 42837
	private EPlotLevel? SubtitleLevel;

	// Token: 0x0400A756 RID: 42838
	[Nullable(1)]
	public List<PlotOption> CurOption = new List<PlotOption>();

	// Token: 0x0400A757 RID: 42839
	private float FadeTimePhoto;

	// Token: 0x0400A758 RID: 42840
	private bool IsFadeInPhoto;

	// Token: 0x0400A759 RID: 42841
	private bool TickPhotoFade;

	// Token: 0x0400A75A RID: 42842
	private bool IsAlreadyHavePhoto;

	// Token: 0x0400A75B RID: 42843
	private bool? IsFullPhoto;

	// Token: 0x0400A75C RID: 42844
	private bool IsBlackBgShow;

	// Token: 0x0400A75D RID: 42845
	private bool CanShowAutoButtonByPlotConfig = true;

	// Token: 0x0400A75E RID: 42846
	private bool CanShowHideButtonByPlotConfig = true;

	// Token: 0x0400A75F RID: 42847
	private bool CanShowReviewButtonByPlotConfig = true;

	// Token: 0x0400A760 RID: 42848
	[Nullable(1)]
	private readonly Dictionary<string, bool> DisableInteractSources = new Dictionary<string, bool>();

	// Token: 0x0400A761 RID: 42849
	[Nullable(1)]
	private readonly HashSet<string> DisableSkipSources = new HashSet<string>();

	// Token: 0x0400A762 RID: 42850
	private UUITexture BgWidget;

	// Token: 0x0400A763 RID: 42851
	private UUITexture BgWidgetFront;

	// Token: 0x0400A764 RID: 42852
	private UUITexture WidgetMiddle;

	// Token: 0x0400A765 RID: 42853
	private UUISprite BgWidgetMiddle;

	// Token: 0x0400A766 RID: 42854
	private CustomPromise<bool> PlotFadeShowPromise;

	// Token: 0x0400A767 RID: 42855
	private CustomPromise<bool> PlotFadeHidePromise;

	// Token: 0x0400A768 RID: 42856
	private Action<ITalkItem> PlotViewPhotoCallback;

	// Token: 0x0400A769 RID: 42857
	private ETalkBackgroundType? NowBackgroundConfig;

	// Token: 0x0400A76A RID: 42858
	private UUIItem SonUi;

	// Token: 0x0400A76B RID: 42859
	private UUIItem FullscreenAdaptAnchor;

	// Token: 0x0400A76C RID: 42860
	public PlotChildView SonUiInclude;

	// Token: 0x0400A76D RID: 42861
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, PlotChildView> SonUiIncludeMap;

	// Token: 0x0400A76E RID: 42862
	private TimerHandle BlockOptionTimer;

	// Token: 0x0400A76F RID: 42863
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Queue<SpineQueueInfo> SpineQueue;

	// Token: 0x0400A770 RID: 42864
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Queue<PlotChildView> SonUiQueue;

	// Token: 0x0400A771 RID: 42865
	private UUISliderComponent OptionLimitBar;

	// Token: 0x0400A772 RID: 42866
	private UUISliderComponent AutoSelectTimeBar;

	// Token: 0x0400A773 RID: 42867
	[Nullable(1)]
	private readonly PlotAutoSelectOptionComponent AutoSelectOptionComponent = new PlotAutoSelectOptionComponent();

	// Token: 0x0400A774 RID: 42868
	[Nullable(1)]
	private readonly PlotAudioDelegate AudioDelegate = new PlotAudioDelegate();

	// Token: 0x0400A775 RID: 42869
	private TimerHandle AudioPlayTimer;

	// Token: 0x0400A776 RID: 42870
	private TimerHandle DelayAutoPlayTimer;

	// Token: 0x0400A777 RID: 42871
	private float TextScrollViewPrefabHeight;

	// Token: 0x0400A778 RID: 42872
	private TimerHandle ScrollStartTimer;

	// Token: 0x0400A779 RID: 42873
	public bool HasChildViewPreloaded;

	// Token: 0x0400A77A RID: 42874
	private bool MuteTimeLimitedOption;

	// Token: 0x0400A77B RID: 42875
	private float ScrollTotalTime;

	// Token: 0x0400A77C RID: 42876
	private float CurrentAnimTime;

	// Token: 0x0400A77D RID: 42877
	private TimerHandle TextScrollAnimTimer;

	// Token: 0x0400A77E RID: 42878
	private TimerHandle DelayTextScrollAnimTimer;

	// Token: 0x0400A77F RID: 42879
	private IPostAkEventType LastEndEvent;

	// Token: 0x0400A780 RID: 42880
	private bool TickIconAlpha;

	// Token: 0x0400A781 RID: 42881
	private BP_KuroMasterSeqEvent_C EventObject;

	// Token: 0x020081B9 RID: 33209
	[NullableContext(0)]
	private enum EPlotChildCom
	{
		// Token: 0x04029E4C RID: 171596
		BtnAuto,
		// Token: 0x04029E4D RID: 171597
		BtnNextPage,
		// Token: 0x04029E4E RID: 171598
		BtnSkip,
		// Token: 0x04029E4F RID: 171599
		PlotText,
		// Token: 0x04029E50 RID: 171600
		NPCName,
		// Token: 0x04029E51 RID: 171601
		TxtList,
		// Token: 0x04029E52 RID: 171602
		OptionItem,
		// Token: 0x04029E53 RID: 171603
		OptionLayout,
		// Token: 0x04029E54 RID: 171604
		TextList,
		// Token: 0x04029E55 RID: 171605
		PlotBg,
		// Token: 0x04029E56 RID: 171606
		PlotTextUHD,
		// Token: 0x04029E57 RID: 171607
		PanelLine,
		// Token: 0x04029E58 RID: 171608
		TxtFloat,
		// Token: 0x04029E59 RID: 171609
		ScreenEffect,
		// Token: 0x04029E5A RID: 171610
		AutoPlayManualItem,
		// Token: 0x04029E5B RID: 171611
		AutuPlaySemiAutoItem,
		// Token: 0x04029E5C RID: 171612
		AutuPlayAutoItem,
		// Token: 0x04029E5D RID: 171613
		NPCTitle,
		// Token: 0x04029E5E RID: 171614
		BtnHide,
		// Token: 0x04029E5F RID: 171615
		NextIcon,
		// Token: 0x04029E60 RID: 171616
		WaitingPoint,
		// Token: 0x04029E61 RID: 171617
		BlackScreenBg,
		// Token: 0x04029E62 RID: 171618
		PhotoScreenBg,
		// Token: 0x04029E63 RID: 171619
		PhotoScreenBgFront,
		// Token: 0x04029E64 RID: 171620
		DoingText,
		// Token: 0x04029E65 RID: 171621
		PhotoScreenMiddle,
		// Token: 0x04029E66 RID: 171622
		PhotoScreenBgMiddle,
		// Token: 0x04029E67 RID: 171623
		TextScrollView,
		// Token: 0x04029E68 RID: 171624
		OptionAdjustItem,
		// Token: 0x04029E69 RID: 171625
		PnlBg,
		// Token: 0x04029E6A RID: 171626
		PnlInfo,
		// Token: 0x04029E6B RID: 171627
		SonUi,
		// Token: 0x04029E6C RID: 171628
		BlockOption,
		// Token: 0x04029E6D RID: 171629
		BtnReview,
		// Token: 0x04029E6E RID: 171630
		OptionLimitBar,
		// Token: 0x04029E6F RID: 171631
		VideoLayout,
		// Token: 0x04029E70 RID: 171632
		AniSkipIn,
		// Token: 0x04029E71 RID: 171633
		AniSkipOut,
		// Token: 0x04029E72 RID: 171634
		AniReviewIn,
		// Token: 0x04029E73 RID: 171635
		AniReviewOut,
		// Token: 0x04029E74 RID: 171636
		AniAutoHideIn,
		// Token: 0x04029E75 RID: 171637
		AniAutoHideOut,
		// Token: 0x04029E76 RID: 171638
		TextDebugInfo,
		// Token: 0x04029E77 RID: 171639
		FullscreenAdaptAnchor,
		// Token: 0x04029E78 RID: 171640
		ImportantList,
		// Token: 0x04029E79 RID: 171641
		PnlLayout02,
		// Token: 0x04029E7A RID: 171642
		TextScrollViewCopy,
		// Token: 0x04029E7B RID: 171643
		ImportantOptionTipsIcon,
		// Token: 0x04029E7C RID: 171644
		ImportantOptionTipsText,
		// Token: 0x04029E7D RID: 171645
		AutoSelectTimeBar,
		// Token: 0x04029E7E RID: 171646
		AutoSelectText,
		// Token: 0x04029E7F RID: 171647
		AniAutoTextIn,
		// Token: 0x04029E80 RID: 171648
		AniAutoTextOut,
		// Token: 0x04029E81 RID: 171649
		NextIconNew
	}
}
