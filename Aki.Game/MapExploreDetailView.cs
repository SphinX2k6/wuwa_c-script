using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.VillageInfr;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AC9 RID: 6857
[NullableContext(1)]
[Nullable(0)]
public class MapExploreDetailView : UiTickViewBase
{
	// Token: 0x0600CB4F RID: 52047 RVA: 0x002E5B9F File Offset: 0x002E3D9F
	public MapExploreDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CB50 RID: 52048 RVA: 0x002E5BC0 File Offset: 0x002E3DC0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 32;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 7;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnAreaChangeLeftBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnAreaChangeRightBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnStoryBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnAreaBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnExploreToolTips));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnAreaTaskBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(17, new Action(this.OnExploreProgressBarDetailBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600CB51 RID: 52049 RVA: 0x002E6134 File Offset: 0x002E4334
	protected override UniTask OnBeforeStartAsync()
	{
		MapExploreDetailView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MapExploreDetailView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CB52 RID: 52050 RVA: 0x002E6178 File Offset: 0x002E4378
	private UniTask CreateStageRewardPanel()
	{
		MapExploreDetailView.<CreateStageRewardPanel>d__14 <CreateStageRewardPanel>d__;
		<CreateStageRewardPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateStageRewardPanel>d__.<>4__this = this;
		<CreateStageRewardPanel>d__.<>1__state = -1;
		<CreateStageRewardPanel>d__.<>t__builder.Start<MapExploreDetailView.<CreateStageRewardPanel>d__14>(ref <CreateStageRewardPanel>d__);
		return <CreateStageRewardPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600CB53 RID: 52051 RVA: 0x002E61BC File Offset: 0x002E43BC
	private UniTask CreatePlayProgressPanel()
	{
		MapExploreDetailView.<CreatePlayProgressPanel>d__15 <CreatePlayProgressPanel>d__;
		<CreatePlayProgressPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePlayProgressPanel>d__.<>4__this = this;
		<CreatePlayProgressPanel>d__.<>1__state = -1;
		<CreatePlayProgressPanel>d__.<>t__builder.Start<MapExploreDetailView.<CreatePlayProgressPanel>d__15>(ref <CreatePlayProgressPanel>d__);
		return <CreatePlayProgressPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600CB54 RID: 52052 RVA: 0x002E6200 File Offset: 0x002E4400
	private UniTask CreateExploreDetailLockItem()
	{
		MapExploreDetailView.<CreateExploreDetailLockItem>d__16 <CreateExploreDetailLockItem>d__;
		<CreateExploreDetailLockItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateExploreDetailLockItem>d__.<>4__this = this;
		<CreateExploreDetailLockItem>d__.<>1__state = -1;
		<CreateExploreDetailLockItem>d__.<>t__builder.Start<MapExploreDetailView.<CreateExploreDetailLockItem>d__16>(ref <CreateExploreDetailLockItem>d__);
		return <CreateExploreDetailLockItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600CB55 RID: 52053 RVA: 0x002E6244 File Offset: 0x002E4444
	private UniTask CreateExploreTrackButton()
	{
		MapExploreDetailView.<CreateExploreTrackButton>d__17 <CreateExploreTrackButton>d__;
		<CreateExploreTrackButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateExploreTrackButton>d__.<>4__this = this;
		<CreateExploreTrackButton>d__.<>1__state = -1;
		<CreateExploreTrackButton>d__.<>t__builder.Start<MapExploreDetailView.<CreateExploreTrackButton>d__17>(ref <CreateExploreTrackButton>d__);
		return <CreateExploreTrackButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600CB56 RID: 52054 RVA: 0x002E6287 File Offset: 0x002E4487
	protected override void OnStart()
	{
		UUIText text = base.GetText(25);
		if (text == null)
		{
			return;
		}
		text.SetText("0", true);
	}

	// Token: 0x0600CB57 RID: 52055 RVA: 0x002E62A4 File Offset: 0x002E44A4
	private void GetRewardCallback()
	{
		int[] rewardIds = (from data in this.CurAreaData.GetStageRewardDataList()
		where data.State == EDailyActiveState.FinishedAndNotTaken
		select data.Id).ToArray<int>();
		ExploreProgressController.Instance.ReceiveAreaStageRewardAsyncRequest(rewardIds);
	}

	// Token: 0x0600CB58 RID: 52056 RVA: 0x002E6318 File Offset: 0x002E4518
	private void UpdateStageRewardByArea()
	{
		MapAreaRewardPanel stageRewardPanel = this.StageRewardPanel;
		if (stageRewardPanel == null)
		{
			return;
		}
		stageRewardPanel.ChangeParamData(new MapAreaRewardParam
		{
			InitValue = this.CurAreaData.GetProgress(),
			MaxValue = this.CurAreaData.MaxExploreProgress,
			RewardDataList = this.CurAreaData.GetStageRewardDataList(),
			GetRewardCallback = new Action(this.GetRewardCallback)
		});
	}

	// Token: 0x0600CB59 RID: 52057 RVA: 0x002E6380 File Offset: 0x002E4580
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnReceiveAreaStageRewardResponse, new Action<IReadOnlyList<int>>(this.EventReceiveAreaStageRewardResponse));
		EventSystem.Instance.Add(EEventName.OnAreaExploreProgressUpdate, new Action<int>(this.EventAreaExploreProgressUpdate));
		EventSystem.Instance.Add(EEventName.MapExploreDetailItemClick, new Action<ExploreAreaItemData>(this.EventMapExploreDetailItemClick));
		EventSystem.Instance.Add(EEventName.AreaPlayPointUpdate, new Action<int>(this.EventAreaPlayPointUpdate));
		EventSystem.Instance.Add(EEventName.AreaStoryProgressSave, new Action(this.EventAreaStoryProgressSave));
		EventSystem.Instance.Add(EEventName.OpenExploreAreaDetailViewFromMap, new <>f__AnonymousDelegate6<int, EExploreType?>(this.EventOpenExploreAreaDetailViewFromMap));
	}

	// Token: 0x0600CB5A RID: 52058 RVA: 0x002E6438 File Offset: 0x002E4638
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnReceiveAreaStageRewardResponse, new Action<IReadOnlyList<int>>(this.EventReceiveAreaStageRewardResponse));
		EventSystem.Instance.Remove(EEventName.OnAreaExploreProgressUpdate, new Action<int>(this.EventAreaExploreProgressUpdate));
		EventSystem.Instance.Remove(EEventName.MapExploreDetailItemClick, new Action<ExploreAreaItemData>(this.EventMapExploreDetailItemClick));
		EventSystem.Instance.Remove(EEventName.AreaPlayPointUpdate, new Action<int>(this.EventAreaPlayPointUpdate));
		EventSystem.Instance.Remove(EEventName.AreaStoryProgressSave, new Action(this.EventAreaStoryProgressSave));
		EventSystem.Instance.Remove(EEventName.OpenExploreAreaDetailViewFromMap, new <>f__AnonymousDelegate6<int, EExploreType?>(this.EventOpenExploreAreaDetailViewFromMap));
	}

	// Token: 0x0600CB5B RID: 52059 RVA: 0x002E64ED File Offset: 0x002E46ED
	protected override void OnBeforeShow()
	{
		if (!this.UpdateViewByAreaData())
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x0600CB5C RID: 52060 RVA: 0x002E64FE File Offset: 0x002E46FE
	protected override void OnBeforeDestroy()
	{
		this.StageRewardPanel = null;
		this.PopupCaption = null;
	}

	// Token: 0x0600CB5D RID: 52061 RVA: 0x002E6510 File Offset: 0x002E4710
	protected void InitExploreScroll()
	{
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(3);
		this.ExploreScroll = new LoopScrollView<MapExploreDetailItem, ExploreAreaItemData>(loopScrollViewComponent, base.GetItem(20).GetOwner() as AUIBaseActor, new Func<MapExploreDetailItem>(this.InitHandExploreDetailItem), false);
	}

	// Token: 0x0600CB5E RID: 52062 RVA: 0x002E6550 File Offset: 0x002E4750
	private void UpdateExploreScrollList()
	{
		LoopScrollView<MapExploreDetailItem, ExploreAreaItemData> exploreScroll = this.ExploreScroll;
		if (exploreScroll == null)
		{
			return;
		}
		exploreScroll.RefreshByData(this.CurAreaData.GetAllExploreAreaItemData(), false, new Action(this.ExploreScrollSelectIndex), true);
	}

	// Token: 0x0600CB5F RID: 52063 RVA: 0x002E657C File Offset: 0x002E477C
	private void ExploreScrollSelectIndex()
	{
		int selectAreaItemIndex = this.GetSelectAreaItemIndex();
		LoopScrollView<MapExploreDetailItem, ExploreAreaItemData> exploreScroll = this.ExploreScroll;
		if (exploreScroll != null)
		{
			exploreScroll.ScrollToGridIndex(selectAreaItemIndex, true);
		}
		LoopScrollView<MapExploreDetailItem, ExploreAreaItemData> exploreScroll2 = this.ExploreScroll;
		if (exploreScroll2 != null)
		{
			exploreScroll2.DeselectCurrentGridProxy(false);
		}
		LoopScrollView<MapExploreDetailItem, ExploreAreaItemData> exploreScroll3 = this.ExploreScroll;
		if (exploreScroll3 != null)
		{
			exploreScroll3.SelectGridProxy(selectAreaItemIndex, false);
		}
		LoopScrollView<MapExploreDetailItem, ExploreAreaItemData> exploreScroll4 = this.ExploreScroll;
		MapExploreDetailItem mapExploreDetailItem = (exploreScroll4 != null) ? exploreScroll4.UnsafeGetGridProxy(selectAreaItemIndex, false) : null;
		if (mapExploreDetailItem != null)
		{
			UiNavigationNewController.Instance.SetNavigationFocusForView(mapExploreDetailItem.GetBtnRootItem(), true, false, false);
		}
	}

	// Token: 0x0600CB60 RID: 52064 RVA: 0x002E65F4 File Offset: 0x002E47F4
	private int GetSelectAreaItemIndex()
	{
		List<ExploreAreaItemData> allExploreAreaItemData = this.CurAreaData.GetAllExploreAreaItemData();
		int num = 0;
		if (this.CurAreaItemData != null)
		{
			num = allExploreAreaItemData.FindIndex((ExploreAreaItemData data) => data.ExploreType == this.CurAreaItemData.ExploreType);
		}
		if (num == -1)
		{
			num = 0;
			this.CurAreaItemData = allExploreAreaItemData[num];
		}
		return num;
	}

	// Token: 0x0600CB61 RID: 52065 RVA: 0x002E663E File Offset: 0x002E483E
	private MapExploreDetailItem InitHandExploreDetailItem()
	{
		return new MapExploreDetailItem();
	}

	// Token: 0x0600CB62 RID: 52066 RVA: 0x002E6648 File Offset: 0x002E4848
	private void OnAreaBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.MapAreaShowView, new MapAreaShowViewParams
		{
			CountryId = new int?(this.CurAreaData.CountryId),
			AreaId = new int?(this.CurAreaData.AreaId),
			OnClickArea = new Action<int>(this.OnMapAreaShowClickArea)
		}, null);
	}

	// Token: 0x0600CB63 RID: 52067 RVA: 0x002E66A8 File Offset: 0x002E48A8
	private void OnStoryBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.MapExploreStoryView, new MapExploreStoryViewParams
		{
			AreaData = this.CurAreaData
		}, new TOpenViewCallBack(this.AddViewToChild));
	}

	// Token: 0x0600CB64 RID: 52068 RVA: 0x002E66D8 File Offset: 0x002E48D8
	private void OnExploreToolTips()
	{
		ExploreAreaItemData curAreaItemData = this.CurAreaItemData;
		int? num = (curAreaItemData != null) ? curAreaItemData.GetPhantomSkillHelpId() : null;
		if (num != null)
		{
			HelpController.Instance.OpenHelpById(num.Value);
		}
	}

	// Token: 0x0600CB65 RID: 52069 RVA: 0x002E671A File Offset: 0x002E491A
	private void OnAreaTaskBtn()
	{
		if (this.CurAreaItemData != null)
		{
			UiManager.Instance.OpenView(EUiViewName.ExploreMissionView, this.CurAreaItemData.AreaId, new TOpenViewCallBack(this.AddViewToChild));
		}
	}

	// Token: 0x0600CB66 RID: 52070 RVA: 0x002E674F File Offset: 0x002E494F
	private void OnExploreProgressBarDetailBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.MapPlayPointDetailView, new MapPlayPointDetailViewParams
		{
			ExploreAreaItemData = this.CurAreaItemData
		}, new TOpenViewCallBack(this.AddViewToChild));
	}

	// Token: 0x0600CB67 RID: 52071 RVA: 0x002E677D File Offset: 0x002E497D
	private void AddViewToChild(bool success, int viewId)
	{
		if (success)
		{
			UiViewBase uiViewBase = UiModel.Instance.NormalStack.Peek();
			if (uiViewBase == null)
			{
				return;
			}
			uiViewBase.AddChildViewById(viewId);
		}
	}

	// Token: 0x0600CB68 RID: 52072 RVA: 0x002E679C File Offset: 0x002E499C
	private void OnExploreTrackBtn(int index)
	{
		if (this.CurAreaItemData != null && !this.CurAreaItemData.IsUnlocked())
		{
			SkipTaskManager.RunByConfigId(this.CurAreaItemData.AccessPathId, null);
			return;
		}
		if (UiManager.Instance.IsViewShow(EUiViewName.WorldMapView))
		{
			ExploreAreaItemData curAreaItemData = this.CurAreaItemData;
			if (curAreaItemData != null)
			{
				curAreaItemData.TrackPoint();
			}
		}
		else
		{
			ExploreProgressModel.Instance.SetTrackExploreAreaItemData(this.CurAreaItemData);
		}
		base.CloseMe(null);
	}

	// Token: 0x0600CB69 RID: 52073 RVA: 0x002E680B File Offset: 0x002E4A0B
	private void OnCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600CB6A RID: 52074 RVA: 0x002E6814 File Offset: 0x002E4A14
	private void OnAreaChangeLeftBtn()
	{
		this.ChangeAreaDataByAddIndex(-1);
		base.PlaySequence("SwitchLeft", null, false);
	}

	// Token: 0x0600CB6B RID: 52075 RVA: 0x002E682A File Offset: 0x002E4A2A
	private void OnAreaChangeRightBtn()
	{
		this.ChangeAreaDataByAddIndex(1);
		base.PlaySequence("SwitchRight", null, false);
	}

	// Token: 0x0600CB6C RID: 52076 RVA: 0x002E6840 File Offset: 0x002E4A40
	private void ChangeAreaDataByAddIndex(int add)
	{
		int count = this.AreaDataList.Count;
		int num = this.CurAreaDataIndex + add;
		num = MathUtils.Instance.Clamp(num, 0, count - 1);
		if (num == this.CurAreaDataIndex)
		{
			return;
		}
		this.CurAreaDataIndex = num;
		this.CurAreaData = this.AreaDataList[num];
		this.UpdateViewByAreaData();
	}

	// Token: 0x0600CB6D RID: 52077 RVA: 0x002E689C File Offset: 0x002E4A9C
	private bool UpdateViewByAreaData()
	{
		if (this.CurAreaData == null)
		{
			return false;
		}
		UUIButtonComponent button = base.GetButton(1);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(this.CurAreaDataIndex > 0);
		}
		UUIButtonComponent button2 = base.GetButton(2);
		if (button2 != null)
		{
			button2.RootUIComp.Get().SetUIActive(this.CurAreaDataIndex < this.AreaDataList.Count - 1);
		}
		this.CurAreaData.CheckUpdatePlayPointData();
		this.UpdateAreaBase();
		this.UpdateStageRewardByArea();
		this.UpdateExploreScrollList();
		float num = (float)this.CurAreaData.GetProgress();
		UUISprite sprite = base.GetSprite(26);
		if (sprite != null)
		{
			sprite.SetFillAmount(num / 100f);
		}
		this.UpdateChangeAreaRedDot();
		this.UpdateStoryRedDot();
		this.UpdateHighLightTips();
		return true;
	}

	// Token: 0x0600CB6E RID: 52078 RVA: 0x002E6968 File Offset: 0x002E4B68
	private void UpdateAreaBase()
	{
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.ShowTextNew(this.CurAreaData.GetNameId());
		}
		float num = (float)this.CurAreaData.GetProgress();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<float>(num);
		defaultInterpolatedStringHandler.AppendLiteral("%");
		string newText = defaultInterpolatedStringHandler.ToStringAndClear();
		UUIText text2 = base.GetText(8);
		if (text2 != null)
		{
			text2.SetText(newText, true);
		}
		UUIText text3 = base.GetText(25);
		if (text3 != null)
		{
			UUIItem uuiitem = text3;
			bool bUseChangeColor = num > 0f;
			FColor? fcolor = new FColor?(text3.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}
	}

	// Token: 0x0600CB6F RID: 52079 RVA: 0x002E6A04 File Offset: 0x002E4C04
	private void OnMapAreaShowClickArea(int areaId)
	{
		if (base.IsDestroyOrDestroying)
		{
			return;
		}
		UiManager.Instance.CloseView(EUiViewName.MapAreaShowView, null);
		ExploreAreaData curAreaData = this.CurAreaData;
		if (curAreaData != null && curAreaData.AreaId == areaId)
		{
			return;
		}
		if (!this.UpdateAreaDataByAreaId(areaId))
		{
			return;
		}
		if (base.IsShow)
		{
			this.UpdateViewByAreaData();
		}
	}

	// Token: 0x0600CB70 RID: 52080 RVA: 0x002E6A5C File Offset: 0x002E4C5C
	private bool UpdateAreaDataByAreaId(int areaId)
	{
		ExploreAreaData exploreAreaData = ExploreProgressModel.Instance.GetExploreAreaData(areaId);
		if (exploreAreaData == null)
		{
			ScrollingTipsController instance = ScrollingTipsController.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Area Id Cannot Be Found: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(areaId);
			instance.ShowTipsByText(defaultInterpolatedStringHandler.ToStringAndClear());
			return false;
		}
		this.CurAreaData = exploreAreaData;
		if (this.AreaDataList.Count <= 0)
		{
			this.AreaDataList = ExploreProgressModel.Instance.GetAllAreaDataListSortCountryState();
			foreach (ExploreAreaData exploreAreaData2 in this.AreaDataList)
			{
				exploreAreaData2.ClearFlagUpdatePlayPointData();
			}
		}
		this.CurAreaDataIndex = this.AreaDataList.FindIndex((ExploreAreaData value) => value.AreaId == this.CurAreaData.AreaId);
		return true;
	}

	// Token: 0x0600CB71 RID: 52081 RVA: 0x002E6B30 File Offset: 0x002E4D30
	protected override void OnTick(float delta)
	{
		MapAreaRewardPanel stageRewardPanel = this.StageRewardPanel;
		if (stageRewardPanel == null)
		{
			return;
		}
		stageRewardPanel.OnTickRefresh(delta);
	}

	// Token: 0x0600CB72 RID: 52082 RVA: 0x002E6B43 File Offset: 0x002E4D43
	private void EventReceiveAreaStageRewardResponse(IReadOnlyList<int> rewardIds)
	{
		MapAreaRewardPanel stageRewardPanel = this.StageRewardPanel;
		if (stageRewardPanel == null)
		{
			return;
		}
		stageRewardPanel.UpdateRewardIds(rewardIds);
	}

	// Token: 0x0600CB73 RID: 52083 RVA: 0x002E6B56 File Offset: 0x002E4D56
	private void EventAreaExploreProgressUpdate(int areaId)
	{
		ExploreAreaData curAreaData = this.CurAreaData;
		if (curAreaData == null || curAreaData.AreaId != areaId)
		{
			return;
		}
		MapAreaRewardPanel stageRewardPanel = this.StageRewardPanel;
		if (stageRewardPanel == null)
		{
			return;
		}
		stageRewardPanel.RefreshProgressBarDynamic(this.CurAreaData.GetProgress());
	}

	// Token: 0x0600CB74 RID: 52084 RVA: 0x002E6B8E File Offset: 0x002E4D8E
	private void EventMapExploreDetailItemClick(ExploreAreaItemData areaItemData)
	{
		this.CurAreaItemData = areaItemData;
		this.UpdateExploreDetail();
	}

	// Token: 0x0600CB75 RID: 52085 RVA: 0x002E6B9D File Offset: 0x002E4D9D
	private void EventAreaPlayPointUpdate(int areaId)
	{
		ExploreAreaData curAreaData = this.CurAreaData;
		if (curAreaData == null || curAreaData.AreaId != areaId)
		{
			return;
		}
		this.UpdateExploreDetail();
	}

	// Token: 0x0600CB76 RID: 52086 RVA: 0x002E6BC0 File Offset: 0x002E4DC0
	private void EventAreaStoryProgressSave()
	{
		this.UpdateStoryRedDot();
	}

	// Token: 0x0600CB77 RID: 52087 RVA: 0x002E6BC8 File Offset: 0x002E4DC8
	private void EventOpenExploreAreaDetailViewFromMap(int areaId, EExploreType? exploreType = null)
	{
		ExploreAreaData curAreaData = this.CurAreaData;
		if (curAreaData != null && curAreaData.AreaId == areaId)
		{
			this.ForceChangeAreaItem(exploreType, true);
			return;
		}
		this.ForceChangeArea(areaId, exploreType);
	}

	// Token: 0x0600CB78 RID: 52088 RVA: 0x002E6BF4 File Offset: 0x002E4DF4
	private void ForceChangeAreaItem(EExploreType? exploreType, bool isUpdate = true)
	{
		if (exploreType == null)
		{
			return;
		}
		EExploreType value = exploreType.Value;
		ExploreAreaItemData curAreaItemData = this.CurAreaItemData;
		EExploreType? eexploreType = (curAreaItemData != null) ? new EExploreType?(curAreaItemData.ExploreType) : null;
		if (value == eexploreType.GetValueOrDefault() & eexploreType != null)
		{
			return;
		}
		ExploreAreaItemData exploreAreaItemData = this.CurAreaData.GetExploreAreaItemData(exploreType.Value);
		if (exploreAreaItemData == null)
		{
			return;
		}
		this.CurAreaItemData = exploreAreaItemData;
		if (isUpdate)
		{
			this.ExploreScrollSelectIndex();
		}
	}

	// Token: 0x0600CB79 RID: 52089 RVA: 0x002E6C6D File Offset: 0x002E4E6D
	private void ForceChangeArea(int areaId, EExploreType? exploreType = null)
	{
		if (!this.UpdateAreaDataByAreaId(areaId))
		{
			return;
		}
		this.ForceChangeAreaItem(exploreType, false);
		this.UpdateViewByAreaData();
	}

	// Token: 0x0600CB7A RID: 52090 RVA: 0x002E6C88 File Offset: 0x002E4E88
	private void UpdateExploreDetail()
	{
		ExploreAreaItemData curAreaItemData = this.CurAreaItemData;
		bool flag = curAreaItemData != null && curAreaItemData.IsUnlocked();
		UUIItem item = base.GetItem(21);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(22);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		if (!flag)
		{
			this.UpdateLockState();
			return;
		}
		UUIItem item3 = base.GetItem(29);
		if (item3 != null)
		{
			item3.SetUIActive(true);
		}
		UUIText text = base.GetText(12);
		if (text != null)
		{
			text.SetUIActive(true);
		}
		base.SetTextureByPath(this.CurAreaItemData.DescBg, base.GetTexture(11), null, null);
		UUIText text2 = base.GetText(12);
		if (text2 != null)
		{
			text2.ShowTextNew(this.CurAreaItemData.DescId);
		}
		bool flag2 = this.CurAreaItemData.IsCompleted();
		bool flag3 = this.CurAreaItemData.HasPhantomSkill();
		UUIItem item4 = base.GetItem(24);
		if (item4 != null)
		{
			item4.SetUIActive(flag2);
		}
		UUIItem item5 = base.GetItem(13);
		if (item5 != null)
		{
			item5.SetUIActive(!flag2 && flag3);
		}
		bool flag4 = this.UpdateExploreDetailLockItem();
		this.UpdateExploreProgressBar();
		bool active = this.CurAreaItemData.IsShowTrackBtn && !flag2 && flag4;
		this.ExploreTrackButton.SetActive(active);
		this.ExploreTrackButton.SetLocalTextNew("ExploreButton_1", Array.Empty<object>());
		UUIText text3 = base.GetText(14);
		string text4 = this.CurAreaItemData.GetIsPhantomSkillUnlock() ? this.CurAreaItemData.GetUnlockTextId() : this.CurAreaItemData.GetLockTextId();
		if (!string.IsNullOrEmpty(text4))
		{
			text3.ShowTextNew(text4);
		}
		text3.SetUIActive(!string.IsNullOrEmpty(text4));
		bool uiactive = this.CurAreaItemData.ExploreType == EExploreType.AreaMission;
		base.GetButton(10).RootUIComp.Get().SetUIActive(uiactive);
		this.UpdateHighLightTips();
	}

	// Token: 0x0600CB7B RID: 52091 RVA: 0x002E6E5C File Offset: 0x002E505C
	private void UpdateLockState()
	{
		UUIItem item = base.GetItem(22);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		ExploreAreaItemData curAreaItemData = this.CurAreaItemData;
		if (curAreaItemData != null && curAreaItemData.AccessPathId > 0)
		{
			base.GetItem(21).SetUIActive(true);
			base.GetItem(19).SetUIActive(false);
			base.GetItem(29).SetUIActive(false);
			base.GetText(12).SetUIActive(false);
			base.GetItem(24).SetUIActive(false);
			base.GetItem(13).SetUIActive(false);
			ExploreDetailLockItem exploreDetailLockItem = this.ExploreDetailLockItem;
			if (exploreDetailLockItem != null)
			{
				exploreDetailLockItem.Reset(null);
			}
			this.ExploreTrackButton.SetActive(true);
			this.ExploreTrackButton.SetLocalTextNew("ExploreButton_2", Array.Empty<object>());
		}
		ExploreAreaItemData curAreaItemData2 = this.CurAreaItemData;
		string text = (curAreaItemData2 != null) ? curAreaItemData2.GetLockDetailId() : null;
		if (!string.IsNullOrEmpty(text))
		{
			UUIText text2 = base.GetText(23);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew(text);
		}
	}

	// Token: 0x0600CB7C RID: 52092 RVA: 0x002E6F54 File Offset: 0x002E5154
	private void UpdateExploreProgressBar()
	{
		ExploreAreaItemData curAreaItemData = this.CurAreaItemData;
		bool flag = curAreaItemData != null && curAreaItemData.IsShowProgressBar;
		UUIItem item = base.GetItem(19);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (!flag)
		{
			return;
		}
		MapExplorePlayProgressPanel playProgressPanel = this.PlayProgressPanel;
		if (playProgressPanel != null)
		{
			playProgressPanel.UpdateData(this.CurAreaItemData.GetPlayProgressDataIgnoreHiddenList(), null);
		}
		EventSystem.Instance.Emit(EEventName.OnUpdateExploreProgressBar);
	}

	// Token: 0x0600CB7D RID: 52093 RVA: 0x002E6FBC File Offset: 0x002E51BC
	private bool UpdateExploreDetailLockItem()
	{
		ExploreAreaItemData curAreaItemData = this.CurAreaItemData;
		MapMark? mapMark = (curAreaItemData != null) ? curAreaItemData.GetNearTrackMapMark() : null;
		bool result = true;
		ExploreDetailLockItem exploreDetailLockItem = this.ExploreDetailLockItem;
		if (exploreDetailLockItem != null)
		{
			exploreDetailLockItem.Reset(null);
		}
		if (mapMark == null || mapMark.Value.GameplayLockJumpId == 0 || string.IsNullOrEmpty(mapMark.Value.GameplayLockText))
		{
			return result;
		}
		ExploreAreaItemData curAreaItemData2 = this.CurAreaItemData;
		if (curAreaItemData2 == null || !curAreaItemData2.GetPlayIdIsUnlock(mapMark.Value.RelativeId))
		{
			ExploreDetailLockItem exploreDetailLockItem2 = this.ExploreDetailLockItem;
			if (exploreDetailLockItem2 != null)
			{
				exploreDetailLockItem2.RefreshExternalByData(mapMark.Value.MarkId);
			}
			result = false;
		}
		else
		{
			ExploreDetailLockItem exploreDetailLockItem3 = this.ExploreDetailLockItem;
			if (exploreDetailLockItem3 != null)
			{
				exploreDetailLockItem3.Reset(null);
			}
		}
		return result;
	}

	// Token: 0x0600CB7E RID: 52094 RVA: 0x002E709C File Offset: 0x002E529C
	private void UpdateChangeAreaRedDot()
	{
		foreach (ExploreAreaData exploreAreaData in this.AreaDataList)
		{
			if (exploreAreaData.AreaId != this.CurAreaData.AreaId && exploreAreaData.HasCanTakeStageReward())
			{
				UUIItem item = base.GetItem(9);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(true);
				return;
			}
		}
		UUIItem item2 = base.GetItem(9);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0600CB7F RID: 52095 RVA: 0x002E712C File Offset: 0x002E532C
	private void UpdateStoryRedDot()
	{
		bool uiactive = this.CurAreaData.HasNewStoryUnlocked();
		UUIItem item = base.GetItem(27);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x170010D1 RID: 4305
	// (get) Token: 0x0600CB80 RID: 52096 RVA: 0x002E7158 File Offset: 0x002E5358
	public bool? IsShowProgressBar
	{
		get
		{
			ExploreAreaItemData curAreaItemData = this.CurAreaItemData;
			if (curAreaItemData == null)
			{
				return null;
			}
			return new bool?(curAreaItemData.IsShowProgressBar);
		}
	}

	// Token: 0x0600CB81 RID: 52097 RVA: 0x002E7184 File Offset: 0x002E5384
	private void UpdateHighLightTips()
	{
		base.GetItem(30).SetUIActive(false);
		if (this.CurAreaItemData == null)
		{
			return;
		}
		if (!this.ExploreTrackButton.IsShowOrShowing)
		{
			return;
		}
		ExploreProgress? exploreProgressConfigById = ExploreProgressConfig.Instance.GetExploreProgressConfigById(this.CurAreaItemData.ConfigId);
		if (exploreProgressConfigById == null)
		{
			return;
		}
		if (exploreProgressConfigById.Value.TagType != 1)
		{
			return;
		}
		InfrV2TreeBuild? treeConfigByAreaId = VillageInfrConfig.Instance.GetTreeConfigByAreaId(this.CurAreaItemData.AreaId);
		if (treeConfigByAreaId == null)
		{
			return;
		}
		IVillageInfrTreeData treeData = VillageInfrModel.Instance.GetTreeData(treeConfigByAreaId.Value.Id);
		if (treeData != null && treeData.Status == InfrV2StatusPb.InfrV2StatusComplete)
		{
			return;
		}
		base.GetItem(30).SetUIActive(true);
	}

	// Token: 0x04005D93 RID: 23955
	[Nullable(2)]
	private ExploreAreaData CurAreaData;

	// Token: 0x04005D94 RID: 23956
	private List<ExploreAreaData> AreaDataList = new List<ExploreAreaData>();

	// Token: 0x04005D95 RID: 23957
	private int CurAreaDataIndex;

	// Token: 0x04005D96 RID: 23958
	[Nullable(2)]
	private MapAreaRewardPanel StageRewardPanel;

	// Token: 0x04005D97 RID: 23959
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<MapExploreDetailItem, ExploreAreaItemData> ExploreScroll;

	// Token: 0x04005D98 RID: 23960
	[Nullable(2)]
	private PopupCaptionItem PopupCaption;

	// Token: 0x04005D99 RID: 23961
	[Nullable(2)]
	private ExploreAreaItemData CurAreaItemData;

	// Token: 0x04005D9A RID: 23962
	[Nullable(2)]
	private MapExplorePlayProgressPanel PlayProgressPanel;

	// Token: 0x04005D9B RID: 23963
	[Nullable(2)]
	private ExploreDetailLockItem ExploreDetailLockItem;

	// Token: 0x04005D9C RID: 23964
	private readonly ButtonItem ExploreTrackButton = new ButtonItem(null);

	// Token: 0x02008021 RID: 32801
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029D4A RID: 171338
		ItemCaption,
		// Token: 0x04029D4B RID: 171339
		AreaChangeLeftBtn,
		// Token: 0x04029D4C RID: 171340
		AreaChangeRightBtn,
		// Token: 0x04029D4D RID: 171341
		ExploreScrollView,
		// Token: 0x04029D4E RID: 171342
		StoryBtn,
		// Token: 0x04029D4F RID: 171343
		AreaName,
		// Token: 0x04029D50 RID: 171344
		AreaBtn,
		// Token: 0x04029D51 RID: 171345
		StageReward,
		// Token: 0x04029D52 RID: 171346
		AreaPercent,
		// Token: 0x04029D53 RID: 171347
		AreaRedDot,
		// Token: 0x04029D54 RID: 171348
		AreaTaskBtn,
		// Token: 0x04029D55 RID: 171349
		ExploreItemBg,
		// Token: 0x04029D56 RID: 171350
		ExploreDesc,
		// Token: 0x04029D57 RID: 171351
		ExploreToolItem,
		// Token: 0x04029D58 RID: 171352
		ExploreToolDesc,
		// Token: 0x04029D59 RID: 171353
		ExploreToolTips,
		// Token: 0x04029D5A RID: 171354
		ExploreProgressBar,
		// Token: 0x04029D5B RID: 171355
		ExploreProgressBarDetailBtn,
		// Token: 0x04029D5C RID: 171356
		ExploreTrackBtn,
		// Token: 0x04029D5D RID: 171357
		ExploreProgressBarRoot,
		// Token: 0x04029D5E RID: 171358
		ExploreScrollItem,
		// Token: 0x04029D5F RID: 171359
		ExploreDetailRoot,
		// Token: 0x04029D60 RID: 171360
		ExploreDetailLockedRoot,
		// Token: 0x04029D61 RID: 171361
		ExploreDetailLockedDesc,
		// Token: 0x04029D62 RID: 171362
		ExploreDetailFinishedRoot,
		// Token: 0x04029D63 RID: 171363
		ExploreZero,
		// Token: 0x04029D64 RID: 171364
		StoryProgress,
		// Token: 0x04029D65 RID: 171365
		StoryRedDot,
		// Token: 0x04029D66 RID: 171366
		ExploreDetailLockRoot,
		// Token: 0x04029D67 RID: 171367
		ExploreDetailProgressImageRoot,
		// Token: 0x04029D68 RID: 171368
		PanelHighLightTips,
		// Token: 0x04029D69 RID: 171369
		TextHighLightTips
	}
}
