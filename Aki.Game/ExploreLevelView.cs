using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ExploreLevel;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F56 RID: 3926
[NullableContext(1)]
[Nullable(0)]
public class ExploreLevelView : UiTickViewBase
{
	// Token: 0x06009D1A RID: 40218 RVA: 0x002E8E0C File Offset: 0x002E700C
	public ExploreLevelView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009D1B RID: 40219 RVA: 0x002E8E18 File Offset: 0x002E7018
	protected unsafe override void OnRegisterComponent()
	{
		int num = 15;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUINiagara));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickRewardPreviewButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickCloseButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009D1C RID: 40220 RVA: 0x002E9098 File Offset: 0x002E7298
	protected override UniTask OnBeforeStartAsync()
	{
		ExploreLevelView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ExploreLevelView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009D1D RID: 40221 RVA: 0x002E90DC File Offset: 0x002E72DC
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollView<CommonItemSmallItemGrid>(base.GetScrollViewWithScrollbar(5), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonItemSmallItemGrid>(this.OnCreateRewardItemGrid), null);
		this.ExploreLevelItemScrollView = new LoopScrollView<ExploreLevelItem, CountryExploreScoreData>(base.GetLoopScrollViewComponent(8), base.GetItem(9).GetOwner() as AUIBaseActor, new Func<ExploreLevelItem>(this.OnCreateExploreLevelItem), false);
		this.RefreshScoreDisplay();
		this.RefreshScoreProgress();
		this.RefreshExploreLevelItemScrollView();
	}

	// Token: 0x06009D1E RID: 40222 RVA: 0x002E914C File Offset: 0x002E734C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnExploreScoreRewardResponse, new Action(this.OnExploreScoreRewardResponse));
		EventSystem.Instance.Add(EEventName.OnCountryExploreScoreInfoResponse, new Action(this.OnCountryExploreScoreInfoResponse));
		EventSystem.Instance.Add(EEventName.OnExploreLevelNotify, new Action(this.OnExploreLevelNotify));
		EventSystem.Instance.Add(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x06009D1F RID: 40223 RVA: 0x002E91E0 File Offset: 0x002E73E0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnExploreScoreRewardResponse, new Action(this.OnExploreScoreRewardResponse));
		EventSystem.Instance.Remove(EEventName.OnCountryExploreScoreInfoResponse, new Action(this.OnCountryExploreScoreInfoResponse));
		EventSystem.Instance.Remove(EEventName.OnExploreLevelNotify, new Action(this.OnExploreLevelNotify));
		EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x06009D20 RID: 40224 RVA: 0x002E9272 File Offset: 0x002E7472
	protected override void OnBeforeDestroy()
	{
		GenericScrollView<CommonItemSmallItemGrid> rewardScrollView = this.RewardScrollView;
		if (rewardScrollView != null)
		{
			rewardScrollView.ClearChildren();
		}
		this.RewardScrollView = null;
		LoopScrollView<ExploreLevelItem, CountryExploreScoreData> exploreLevelItemScrollView = this.ExploreLevelItemScrollView;
		if (exploreLevelItemScrollView != null)
		{
			exploreLevelItemScrollView.ClearGridProxies();
		}
		this.ExploreLevelItemScrollView = null;
		this.CountryExploreLevelData = null;
	}

	// Token: 0x06009D21 RID: 40225 RVA: 0x002E92AB File Offset: 0x002E74AB
	private void OnClickCloseButton()
	{
		UiManager.Instance.CloseView(EUiViewName.ExploreLevelView, null);
	}

	// Token: 0x06009D22 RID: 40226 RVA: 0x002E92BD File Offset: 0x002E74BD
	private void OnExploreScoreRewardResponse()
	{
	}

	// Token: 0x06009D23 RID: 40227 RVA: 0x002E92C0 File Offset: 0x002E74C0
	private void OnCountryExploreScoreInfoResponse()
	{
		this.RefreshExploreLevelItemScrollView();
		int exploreScore = this.CountryExploreLevelData.GetExploreScore();
		int maxExploreScore = this.CurrentExploreLevelRewardData.GetMaxExploreScore();
		if (maxExploreScore < 0)
		{
			this.RefreshScoreProgress();
			return;
		}
		this.PlayProgressBar(this.CurrentExploreScore, this.CurrentMaxExploreScore, exploreScore, maxExploreScore);
	}

	// Token: 0x06009D24 RID: 40228 RVA: 0x002E930C File Offset: 0x002E750C
	protected override void OnTick(float delta)
	{
		if (!this.IsProgressBarPlaying)
		{
			return;
		}
		if (this.IsPausePlayProgressBar)
		{
			return;
		}
		if (this.AnimationTargetExploreScore < this.AnimationCurrentExploreScore)
		{
			float num = MathUtils.Instance.Lerp((float)this.AnimationCurrentExploreScore, (float)this.AnimationCurrentMaxExploreScore, this.AnimationCurrentAnimationTime / 300f);
			this.SetExploreScoreDisplay((int)num, this.AnimationCurrentMaxExploreScore);
			if (num >= (float)this.AnimationCurrentMaxExploreScore)
			{
				this.PlayProgressBar(0, this.AnimationTargetMaxExploreScore, this.AnimationTargetExploreScore, this.AnimationTargetMaxExploreScore);
			}
			this.AnimationCurrentAnimationTime += delta;
			return;
		}
		float num2 = MathUtils.Instance.Lerp((float)this.AnimationCurrentExploreScore, (float)this.AnimationTargetExploreScore, this.AnimationCurrentAnimationTime / 300f);
		this.SetExploreScoreDisplay((int)num2, this.AnimationTargetMaxExploreScore);
		if (this.AnimationCurrentAnimationTime >= 300f)
		{
			this.RefreshScoreDisplay();
			this.RefreshScoreProgress();
			this.StopProgressBar();
			return;
		}
		this.AnimationCurrentAnimationTime += delta;
	}

	// Token: 0x06009D25 RID: 40229 RVA: 0x002E93FF File Offset: 0x002E75FF
	private void PlayProgressBar(int exploreScore, int maxExploreScore, int targetExploreScore, int targetMaxExploreScore)
	{
		this.AnimationCurrentExploreScore = exploreScore;
		this.AnimationCurrentMaxExploreScore = maxExploreScore;
		this.AnimationTargetExploreScore = targetExploreScore;
		this.AnimationTargetMaxExploreScore = targetMaxExploreScore;
		this.AnimationCurrentAnimationTime = 0f;
		this.IsProgressBarPlaying = true;
	}

	// Token: 0x06009D26 RID: 40230 RVA: 0x002E9430 File Offset: 0x002E7630
	private void SetPausePlayProgressBar(bool bPause)
	{
		this.IsPausePlayProgressBar = bPause;
	}

	// Token: 0x06009D27 RID: 40231 RVA: 0x002E9439 File Offset: 0x002E7639
	private void StopProgressBar()
	{
		this.IsProgressBarPlaying = false;
		this.AnimationCurrentAnimationTime = 0f;
	}

	// Token: 0x06009D28 RID: 40232 RVA: 0x002E9450 File Offset: 0x002E7650
	private void ActivateGetExpNiagara()
	{
		UUINiagara uiNiagara = base.GetUiNiagara(14);
		if (uiNiagara.IsUIActiveSelf())
		{
			uiNiagara.ActivateSystem(true);
			return;
		}
		uiNiagara.SetUIActive(true);
	}

	// Token: 0x06009D29 RID: 40233 RVA: 0x002E9480 File Offset: 0x002E7680
	private void OnExploreLevelNotify()
	{
		this.CountryExploreLevelData = ExploreLevelModel.Instance.GetCurrentCountryExploreLevelData();
		this.CurrentExploreLevelRewardData = this.CountryExploreLevelData.GetCurrentExploreLevelRewardData();
		int exploreScore = this.CountryExploreLevelData.GetExploreScore();
		int maxExploreScore = this.CurrentExploreLevelRewardData.GetMaxExploreScore();
		if (maxExploreScore < 0)
		{
			this.RefreshScoreProgress();
			return;
		}
		this.PlayProgressBar(this.CurrentExploreScore, this.CurrentMaxExploreScore, exploreScore, maxExploreScore);
	}

	// Token: 0x06009D2A RID: 40234 RVA: 0x002E94E5 File Offset: 0x002E76E5
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.ExploreLevelRewardView)
		{
			return;
		}
		this.SetPausePlayProgressBar(true);
	}

	// Token: 0x06009D2B RID: 40235 RVA: 0x002E94FC File Offset: 0x002E76FC
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.ExploreLevelRewardView)
		{
			return;
		}
		this.SetPausePlayProgressBar(false);
	}

	// Token: 0x06009D2C RID: 40236 RVA: 0x002E9514 File Offset: 0x002E7714
	private ILayoutItem<CommonItemSmallItemGrid> OnCreateRewardItemGrid(object rawData, UUIItem uiItem, int index)
	{
		ValueTuple<int, int> valueTuple = (ValueTuple<int, int>)rawData;
		CommonItemSmallItemGrid commonItemSmallItemGrid = new CommonItemSmallItemGrid();
		commonItemSmallItemGrid.Initialize(uiItem.GetOwner());
		commonItemSmallItemGrid.RefreshByConfigId(valueTuple.Item1, new int?(valueTuple.Item2), null, false, false);
		return new LayoutItem<CommonItemSmallItemGrid>
		{
			Key = index,
			Value = commonItemSmallItemGrid
		};
	}

	// Token: 0x06009D2D RID: 40237 RVA: 0x002E956C File Offset: 0x002E776C
	private ExploreLevelItem OnCreateExploreLevelItem()
	{
		ExploreLevelItem exploreLevelItem = new ExploreLevelItem();
		exploreLevelItem.BindOnClickedReceiveButton(new Action<CountryExploreScoreData>(this.OnClickedReceiveButton));
		return exploreLevelItem;
	}

	// Token: 0x06009D2E RID: 40238 RVA: 0x002E9588 File Offset: 0x002E7788
	private void OnClickedReceiveButton(CountryExploreScoreData countryExploreScoreData)
	{
		ExploreLevelView.<>c__DisplayClass35_0 CS$<>8__locals1 = new ExploreLevelView.<>c__DisplayClass35_0();
		CS$<>8__locals1.countryExploreScoreData = countryExploreScoreData;
		CS$<>8__locals1.<>4__this = this;
		List<CountryExploreScoreData> visibleExploreScoreDataList = this.CountryExploreLevelData.GetVisibleExploreScoreDataList();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (CountryExploreScoreData countryExploreScoreData2 in visibleExploreScoreDataList)
		{
			if (countryExploreScoreData2.CanReceive())
			{
				dictionary[countryExploreScoreData2.AreaId] = countryExploreScoreData2.Progress;
			}
		}
		ExploreLevelController.Instance.MultiExploreScoreRewardRequest(dictionary);
		ExploreLevelController.Instance.CountryExploreScoreInfoRequest(CS$<>8__locals1.countryExploreScoreData.CountryId, new Action(CS$<>8__locals1.<OnClickedReceiveButton>g__OnCountryExploreScoreInfoResponse|0));
	}

	// Token: 0x06009D2F RID: 40239 RVA: 0x002E963C File Offset: 0x002E783C
	private void OnClickRewardPreviewButton()
	{
		UiManager.Instance.OpenView(EUiViewName.ExploreLevelPreviewView, this.CountryExploreLevelData, delegate(bool success, int viewId)
		{
			if (!success)
			{
				return;
			}
			base.AddChildViewById(viewId);
		});
	}

	// Token: 0x06009D30 RID: 40240 RVA: 0x002E965F File Offset: 0x002E785F
	private void RefreshScoreDisplay()
	{
		this.RefreshLevelText();
		this.RefreshScoreTexture();
		this.RefreshRewardScrollView();
	}

	// Token: 0x06009D31 RID: 40241 RVA: 0x002E9674 File Offset: 0x002E7874
	private void RefreshLevelText()
	{
		string scoreNameId = this.CurrentExploreLevelRewardData.GetScoreNameId();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), scoreNameId, Array.Empty<object>());
	}

	// Token: 0x06009D32 RID: 40242 RVA: 0x002E96A8 File Offset: 0x002E78A8
	private void RefreshScoreTexture()
	{
		string scoreTexturePath = this.CurrentExploreLevelRewardData.GetScoreTexturePath();
		UUITexture texture = base.GetTexture(1);
		base.SetTextureByPath(scoreTexturePath, texture, null, null);
	}

	// Token: 0x06009D33 RID: 40243 RVA: 0x002E96DC File Offset: 0x002E78DC
	private void RefreshScoreProgress()
	{
		int maxExploreScore = this.CurrentExploreLevelRewardData.GetMaxExploreScore();
		if (maxExploreScore <= 0)
		{
			base.GetItem(11).SetUIActive(false);
			return;
		}
		int exploreScore = this.CountryExploreLevelData.GetExploreScore();
		this.SetExploreScoreDisplay(exploreScore, maxExploreScore);
		base.SetTextureByPath(ExploreLevelModel.Instance.ExploreScoreItemTexturePath, base.GetTexture(3), null, null);
		base.GetItem(11).SetUIActive(true);
	}

	// Token: 0x06009D34 RID: 40244 RVA: 0x002E974C File Offset: 0x002E794C
	private void SetExploreScoreDisplay(int exploreScore, int maxExploreScore)
	{
		int num = Math.Min(maxExploreScore, exploreScore);
		base.GetSprite(2).SetFillAmount((float)num / (float)maxExploreScore);
		UUIText text = base.GetText(4);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(maxExploreScore);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x06009D35 RID: 40245 RVA: 0x002E97B0 File Offset: 0x002E79B0
	private void RefreshRewardScrollView()
	{
		CountryExploreLevelRewardData exploreLevelRewardData = this.CountryExploreLevelData.GetExploreLevelRewardData(this.CurrentExploreLevelRewardData.GetExploreLevel() + 1);
		if (exploreLevelRewardData == null)
		{
			GenericScrollView<CommonItemSmallItemGrid> rewardScrollView = this.RewardScrollView;
			if (rewardScrollView != null)
			{
				rewardScrollView.ClearChildren();
			}
			GenericScrollView<CommonItemSmallItemGrid> rewardScrollView2 = this.RewardScrollView;
			if (rewardScrollView2 != null)
			{
				rewardScrollView2.SetActive(false);
			}
			base.GetItem(13).SetUIActive(true);
			return;
		}
		Dictionary<int, int> dropItemNumMap = exploreLevelRewardData.GetDropItemNumMap();
		List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
		if (dropItemNumMap != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair in dropItemNumMap)
			{
				list.Add(new ValueTuple<int, int>(keyValuePair.Key, keyValuePair.Value));
			}
		}
		GenericScrollView<CommonItemSmallItemGrid> rewardScrollView3 = this.RewardScrollView;
		if (rewardScrollView3 != null)
		{
			rewardScrollView3.RefreshByData<ValueTuple<int, int>>(list, null);
		}
		base.GetItem(13).SetUIActive(false);
	}

	// Token: 0x06009D36 RID: 40246 RVA: 0x002E989C File Offset: 0x002E7A9C
	private void RefreshExploreLevelItemScrollView()
	{
		List<CountryExploreScoreData> visibleExploreScoreDataList = this.CountryExploreLevelData.GetVisibleExploreScoreDataList();
		visibleExploreScoreDataList.Sort(delegate(CountryExploreScoreData a, CountryExploreScoreData b)
		{
			int num = (a.GetIsReceived() > false) ? 1 : 0;
			int num2 = (b.GetIsReceived() > false) ? 1 : 0;
			if (num != num2)
			{
				return num.CompareTo(num2);
			}
			int num3 = a.CanReceive() ? -1 : 0;
			int num4 = b.CanReceive() ? -1 : 0;
			if (num3 != num4)
			{
				return num3.CompareTo(num4);
			}
			if (a.AreaId != b.AreaId)
			{
				return a.AreaId.CompareTo(b.AreaId);
			}
			if (a.Progress != b.Progress)
			{
				return a.Progress.CompareTo(b.Progress);
			}
			return 0;
		});
		LoopScrollView<ExploreLevelItem, CountryExploreScoreData> exploreLevelItemScrollView = this.ExploreLevelItemScrollView;
		if (exploreLevelItemScrollView == null)
		{
			return;
		}
		exploreLevelItemScrollView.ReloadData(visibleExploreScoreDataList, false);
	}

	// Token: 0x04005D60 RID: 23904
	private const int PLAY_PROGRESS_BAR_TIME = 300;

	// Token: 0x04005D61 RID: 23905
	[Nullable(2)]
	private CountryExploreLevelData CountryExploreLevelData;

	// Token: 0x04005D62 RID: 23906
	[Nullable(2)]
	private CountryExploreLevelRewardData CurrentExploreLevelRewardData;

	// Token: 0x04005D63 RID: 23907
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<CommonItemSmallItemGrid> RewardScrollView;

	// Token: 0x04005D64 RID: 23908
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ExploreLevelItem, CountryExploreScoreData> ExploreLevelItemScrollView;

	// Token: 0x04005D65 RID: 23909
	private int CurrentExploreScore;

	// Token: 0x04005D66 RID: 23910
	private int CurrentMaxExploreScore;

	// Token: 0x04005D67 RID: 23911
	private int AnimationCurrentExploreScore;

	// Token: 0x04005D68 RID: 23912
	private int AnimationCurrentMaxExploreScore;

	// Token: 0x04005D69 RID: 23913
	private int AnimationTargetExploreScore;

	// Token: 0x04005D6A RID: 23914
	private int AnimationTargetMaxExploreScore;

	// Token: 0x04005D6B RID: 23915
	private float AnimationCurrentAnimationTime;

	// Token: 0x04005D6C RID: 23916
	private bool IsProgressBarPlaying;

	// Token: 0x04005D6D RID: 23917
	private bool IsPausePlayProgressBar;

	// Token: 0x02007187 RID: 29063
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04024FB7 RID: 151479
		CountryNameText,
		// Token: 0x04024FB8 RID: 151480
		ScoreTexture,
		// Token: 0x04024FB9 RID: 151481
		ScoreProgressBarSprite,
		// Token: 0x04024FBA RID: 151482
		ScoreItemTexture,
		// Token: 0x04024FBB RID: 151483
		ScoreCostText,
		// Token: 0x04024FBC RID: 151484
		ScoreRewardScrollViewWithScrollBar,
		// Token: 0x04024FBD RID: 151485
		RewardPreviewButton,
		// Token: 0x04024FBE RID: 151486
		ExploreProgressText,
		// Token: 0x04024FBF RID: 151487
		ScoreItemLoopScrollView,
		// Token: 0x04024FC0 RID: 151488
		SourceExploreLevelItem,
		// Token: 0x04024FC1 RID: 151489
		CloseButton,
		// Token: 0x04024FC2 RID: 151490
		ExpItem,
		// Token: 0x04024FC3 RID: 151491
		LevelText,
		// Token: 0x04024FC4 RID: 151492
		DoneItem,
		// Token: 0x04024FC5 RID: 151493
		GetExpNiagara
	}
}
