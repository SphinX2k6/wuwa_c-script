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

// Token: 0x02001A97 RID: 6807
[NullableContext(1)]
[Nullable(0)]
public class ExploreLevelView : UiTickViewBase
{
	// Token: 0x0600C909 RID: 51465 RVA: 0x002DDCC0 File Offset: 0x002DBEC0
	public ExploreLevelView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C90A RID: 51466 RVA: 0x002DDCCC File Offset: 0x002DBECC
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

	// Token: 0x0600C90B RID: 51467 RVA: 0x002DDF4C File Offset: 0x002DC14C
	protected override UniTask OnBeforeStartAsync()
	{
		ExploreLevelView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ExploreLevelView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C90C RID: 51468 RVA: 0x002DDF90 File Offset: 0x002DC190
	protected override void OnStart()
	{
		this.RewardScrollView = new GenericScrollView<CommonItemSmallItemGrid>(base.GetScrollViewWithScrollbar(5), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<CommonItemSmallItemGrid>(this.OnCreateRewardItemGrid), null);
		this.ExploreLevelItemScrollView = new LoopScrollView<ExploreLevelItem, CountryExploreScoreData>(base.GetLoopScrollViewComponent(8), base.GetItem(9).GetOwner() as AUIBaseActor, new Func<ExploreLevelItem>(this.OnCreateExploreLevelItem), false);
		this.RefreshScoreDisplay();
		this.RefreshScoreProgress();
		this.RefreshExploreLevelItemScrollView();
	}

	// Token: 0x0600C90D RID: 51469 RVA: 0x002DE000 File Offset: 0x002DC200
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnExploreScoreRewardResponse, new Action(this.OnExploreScoreRewardResponse));
		EventSystem.Instance.Add(EEventName.OnCountryExploreScoreInfoResponse, new Action(this.OnCountryExploreScoreInfoResponse));
		EventSystem.Instance.Add(EEventName.OnExploreLevelNotify, new Action(this.OnExploreLevelNotify));
		EventSystem.Instance.Add(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600C90E RID: 51470 RVA: 0x002DE094 File Offset: 0x002DC294
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnExploreScoreRewardResponse, new Action(this.OnExploreScoreRewardResponse));
		EventSystem.Instance.Remove(EEventName.OnCountryExploreScoreInfoResponse, new Action(this.OnCountryExploreScoreInfoResponse));
		EventSystem.Instance.Remove(EEventName.OnExploreLevelNotify, new Action(this.OnExploreLevelNotify));
		EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600C90F RID: 51471 RVA: 0x002DE126 File Offset: 0x002DC326
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

	// Token: 0x0600C910 RID: 51472 RVA: 0x002DE15F File Offset: 0x002DC35F
	private void OnClickCloseButton()
	{
		UiManager.Instance.CloseView(EUiViewName.ExploreLevelView, null);
	}

	// Token: 0x0600C911 RID: 51473 RVA: 0x002DE171 File Offset: 0x002DC371
	private void OnExploreScoreRewardResponse()
	{
	}

	// Token: 0x0600C912 RID: 51474 RVA: 0x002DE174 File Offset: 0x002DC374
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

	// Token: 0x0600C913 RID: 51475 RVA: 0x002DE1C0 File Offset: 0x002DC3C0
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

	// Token: 0x0600C914 RID: 51476 RVA: 0x002DE2B3 File Offset: 0x002DC4B3
	private void PlayProgressBar(int exploreScore, int maxExploreScore, int targetExploreScore, int targetMaxExploreScore)
	{
		this.AnimationCurrentExploreScore = exploreScore;
		this.AnimationCurrentMaxExploreScore = maxExploreScore;
		this.AnimationTargetExploreScore = targetExploreScore;
		this.AnimationTargetMaxExploreScore = targetMaxExploreScore;
		this.AnimationCurrentAnimationTime = 0f;
		this.IsProgressBarPlaying = true;
	}

	// Token: 0x0600C915 RID: 51477 RVA: 0x002DE2E4 File Offset: 0x002DC4E4
	private void SetPausePlayProgressBar(bool bPause)
	{
		this.IsPausePlayProgressBar = bPause;
	}

	// Token: 0x0600C916 RID: 51478 RVA: 0x002DE2ED File Offset: 0x002DC4ED
	private void StopProgressBar()
	{
		this.IsProgressBarPlaying = false;
		this.AnimationCurrentAnimationTime = 0f;
	}

	// Token: 0x0600C917 RID: 51479 RVA: 0x002DE304 File Offset: 0x002DC504
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

	// Token: 0x0600C918 RID: 51480 RVA: 0x002DE334 File Offset: 0x002DC534
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

	// Token: 0x0600C919 RID: 51481 RVA: 0x002DE399 File Offset: 0x002DC599
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.ExploreLevelRewardView)
		{
			return;
		}
		this.SetPausePlayProgressBar(true);
	}

	// Token: 0x0600C91A RID: 51482 RVA: 0x002DE3B0 File Offset: 0x002DC5B0
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName != EUiViewName.ExploreLevelRewardView)
		{
			return;
		}
		this.SetPausePlayProgressBar(false);
	}

	// Token: 0x0600C91B RID: 51483 RVA: 0x002DE3C8 File Offset: 0x002DC5C8
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

	// Token: 0x0600C91C RID: 51484 RVA: 0x002DE420 File Offset: 0x002DC620
	private ExploreLevelItem OnCreateExploreLevelItem()
	{
		ExploreLevelItem exploreLevelItem = new ExploreLevelItem();
		exploreLevelItem.BindOnClickedReceiveButton(new Action<CountryExploreScoreData>(this.OnClickedReceiveButton));
		return exploreLevelItem;
	}

	// Token: 0x0600C91D RID: 51485 RVA: 0x002DE43C File Offset: 0x002DC63C
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

	// Token: 0x0600C91E RID: 51486 RVA: 0x002DE4F0 File Offset: 0x002DC6F0
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

	// Token: 0x0600C91F RID: 51487 RVA: 0x002DE513 File Offset: 0x002DC713
	private void RefreshScoreDisplay()
	{
		this.RefreshLevelText();
		this.RefreshScoreTexture();
		this.RefreshRewardScrollView();
	}

	// Token: 0x0600C920 RID: 51488 RVA: 0x002DE528 File Offset: 0x002DC728
	private void RefreshLevelText()
	{
		string scoreNameId = this.CurrentExploreLevelRewardData.GetScoreNameId();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(12), scoreNameId, Array.Empty<object>());
	}

	// Token: 0x0600C921 RID: 51489 RVA: 0x002DE55C File Offset: 0x002DC75C
	private void RefreshScoreTexture()
	{
		string scoreTexturePath = this.CurrentExploreLevelRewardData.GetScoreTexturePath();
		UUITexture texture = base.GetTexture(1);
		base.SetTextureByPath(scoreTexturePath, texture, null, null);
	}

	// Token: 0x0600C922 RID: 51490 RVA: 0x002DE590 File Offset: 0x002DC790
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

	// Token: 0x0600C923 RID: 51491 RVA: 0x002DE600 File Offset: 0x002DC800
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

	// Token: 0x0600C924 RID: 51492 RVA: 0x002DE664 File Offset: 0x002DC864
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

	// Token: 0x0600C925 RID: 51493 RVA: 0x002DE750 File Offset: 0x002DC950
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

	// Token: 0x04005C91 RID: 23697
	private const int PLAY_PROGRESS_BAR_TIME = 300;

	// Token: 0x04005C92 RID: 23698
	[Nullable(2)]
	private CountryExploreLevelData CountryExploreLevelData;

	// Token: 0x04005C93 RID: 23699
	[Nullable(2)]
	private CountryExploreLevelRewardData CurrentExploreLevelRewardData;

	// Token: 0x04005C94 RID: 23700
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<CommonItemSmallItemGrid> RewardScrollView;

	// Token: 0x04005C95 RID: 23701
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ExploreLevelItem, CountryExploreScoreData> ExploreLevelItemScrollView;

	// Token: 0x04005C96 RID: 23702
	private int CurrentExploreScore;

	// Token: 0x04005C97 RID: 23703
	private int CurrentMaxExploreScore;

	// Token: 0x04005C98 RID: 23704
	private int AnimationCurrentExploreScore;

	// Token: 0x04005C99 RID: 23705
	private int AnimationCurrentMaxExploreScore;

	// Token: 0x04005C9A RID: 23706
	private int AnimationTargetExploreScore;

	// Token: 0x04005C9B RID: 23707
	private int AnimationTargetMaxExploreScore;

	// Token: 0x04005C9C RID: 23708
	private float AnimationCurrentAnimationTime;

	// Token: 0x04005C9D RID: 23709
	private bool IsProgressBarPlaying;

	// Token: 0x04005C9E RID: 23710
	private bool IsPausePlayProgressBar;

	// Token: 0x02007FF8 RID: 32760
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029C7D RID: 171133
		CountryNameText,
		// Token: 0x04029C7E RID: 171134
		ScoreTexture,
		// Token: 0x04029C7F RID: 171135
		ScoreProgressBarSprite,
		// Token: 0x04029C80 RID: 171136
		ScoreItemTexture,
		// Token: 0x04029C81 RID: 171137
		ScoreCostText,
		// Token: 0x04029C82 RID: 171138
		ScoreRewardScrollViewWithScrollBar,
		// Token: 0x04029C83 RID: 171139
		RewardPreviewButton,
		// Token: 0x04029C84 RID: 171140
		ExploreProgressText,
		// Token: 0x04029C85 RID: 171141
		ScoreItemLoopScrollView,
		// Token: 0x04029C86 RID: 171142
		SourceExploreLevelItem,
		// Token: 0x04029C87 RID: 171143
		CloseButton,
		// Token: 0x04029C88 RID: 171144
		ExpItem,
		// Token: 0x04029C89 RID: 171145
		LevelText,
		// Token: 0x04029C8A RID: 171146
		DoneItem,
		// Token: 0x04029C8B RID: 171147
		GetExpNiagara
	}
}
