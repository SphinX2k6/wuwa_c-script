using System;
using System.Collections.Generic;
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

// Token: 0x02000F88 RID: 3976
[NullableContext(1)]
[Nullable(0)]
public class MapExploreDetailView : UiTickViewBase
{
	// Token: 0x06009F60 RID: 40800 RVA: 0x002F0CFF File Offset: 0x002EEEFF
	public MapExploreDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009F61 RID: 40801 RVA: 0x002F0D20 File Offset: 0x002EEF20
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

	// Token: 0x06009F62 RID: 40802 RVA: 0x002F1294 File Offset: 0x002EF494
	protected override UniTask OnBeforeStartAsync()
	{
		MapExploreDetailView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MapExploreDetailView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009F63 RID: 40803 RVA: 0x002F12D8 File Offset: 0x002EF4D8
	private UniTask CreateStageRewardPanel()
	{
		MapExploreDetailView.<CreateStageRewardPanel>d__14 <CreateStageRewardPanel>d__;
		<CreateStageRewardPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateStageRewardPanel>d__.<>4__this = this;
		<CreateStageRewardPanel>d__.<>1__state = -1;
		<CreateStageRewardPanel>d__.<>t__builder.Start<MapExploreDetailView.<CreateStageRewardPanel>d__14>(ref <CreateStageRewardPanel>d__);
		return <CreateStageRewardPanel>d__.<>t__builder.Task;
	}

	// Token: 0x06009F64 RID: 40804 RVA: 0x002F131C File Offset: 0x002EF51C
	private UniTask CreatePlayProgressPanel()
	{
		MapExploreDetailView.<CreatePlayProgressPanel>d__15 <CreatePlayProgressPanel>d__;
		<CreatePlayProgressPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreatePlayProgressPanel>d__.<>4__this = this;
		<CreatePlayProgressPanel>d__.<>1__state = -1;
		<CreatePlayProgressPanel>d__.<>t__builder.Start<MapExploreDetailView.<CreatePlayProgressPanel>d__15>(ref <CreatePlayProgressPanel>d__);
		return <CreatePlayProgressPanel>d__.<>t__builder.Task;
	}

	// Token: 0x06009F65 RID: 40805 RVA: 0x002F1360 File Offset: 0x002EF560
	private UniTask CreateExploreDetailLockItem()
	{
		MapExploreDetailView.<CreateExploreDetailLockItem>d__16 <CreateExploreDetailLockItem>d__;
		<CreateExploreDetailLockItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateExploreDetailLockItem>d__.<>4__this = this;
		<CreateExploreDetailLockItem>d__.<>1__state = -1;
		<CreateExploreDetailLockItem>d__.<>t__builder.Start<MapExploreDetailView.<CreateExploreDetailLockItem>d__16>(ref <CreateExploreDetailLockItem>d__);
		return <CreateExploreDetailLockItem>d__.<>t__builder.Task;
	}

	// Token: 0x06009F66 RID: 40806 RVA: 0x002F13A4 File Offset: 0x002EF5A4
	private UniTask CreateExploreTrackButton()
	{
		MapExploreDetailView.<CreateExploreTrackButton>d__17 <CreateExploreTrackButton>d__;
		<CreateExploreTrackButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateExploreTrackButton>d__.<>4__this = this;
		<CreateExploreTrackButton>d__.<>1__state = -1;
		<CreateExploreTrackButton>d__.<>t__builder.Start<MapExploreDetailView.<CreateExploreTrackButton>d__17>(ref <CreateExploreTrackButton>d__);
		return <CreateExploreTrackButton>d__.<>t__builder.Task;
	}

	// Token: 0x06009F67 RID: 40807 RVA: 0x002F13E7 File Offset: 0x002EF5E7
	protected override void OnStart()
	{
		UUIText text = base.GetText(25);
		if (text == null)
		{
			return;
		}
		text.SetText("0", true);
	}

	// Token: 0x06009F68 RID: 40808 RVA: 0x002F1404 File Offset: 0x002EF604
	private void GetRewardCallback()
	{
		int[] rewardIds = NoLinq.WhereSelectToArray<DailyActivityDefine.IActivityGoalData, int>(this.CurAreaData.GetStageRewardDataList(), (DailyActivityDefine.IActivityGoalData reward) => reward.State == EDailyActiveState.FinishedAndNotTaken, (DailyActivityDefine.IActivityGoalData reward) => reward.Id);
		ExploreProgressController.Instance.ReceiveAreaStageRewardAsyncRequest(rewardIds);
	}

	// Token: 0x06009F69 RID: 40809 RVA: 0x002F146C File Offset: 0x002EF66C
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

	// Token: 0x06009F6A RID: 40810 RVA: 0x002F14D4 File Offset: 0x002EF6D4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnReceiveAreaStageRewardResponse, new Action<IReadOnlyList<int>>(this.EventReceiveAreaStageRewardResponse));
		EventSystem.Instance.Add(EEventName.OnAreaExploreProgressUpdate, new Action<int>(this.EventAreaExploreProgressUpdate));
		EventSystem.Instance.Add(EEventName.MapExploreDetailItemClick, new Action<ExploreAreaItemData>(this.EventMapExploreDetailItemClick));
		EventSystem.Instance.Add(EEventName.AreaPlayPointUpdate, new Action<int>(this.EventAreaPlayPointUpdate));
		EventSystem.Instance.Add(EEventName.AreaStoryProgressSave, new Action(this.EventAreaStoryProgressSave));
		EventSystem.Instance.Add(EEventName.OpenExploreAreaDetailViewFromMap, new <>f__AnonymousDelegate6<int, EExploreType?>(this.EventOpenExploreAreaDetailViewFromMap));
	}

	// Token: 0x06009F6B RID: 40811 RVA: 0x002F158C File Offset: 0x002EF78C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnReceiveAreaStageRewardResponse, new Action<IReadOnlyList<int>>(this.EventReceiveAreaStageRewardResponse));
		EventSystem.Instance.Remove(EEventName.OnAreaExploreProgressUpdate, new Action<int>(this.EventAreaExploreProgressUpdate));
		EventSystem.Instance.Remove(EEventName.MapExploreDetailItemClick, new Action<ExploreAreaItemData>(this.EventMapExploreDetailItemClick));
		EventSystem.Instance.Remove(EEventName.AreaPlayPointUpdate, new Action<int>(this.EventAreaPlayPointUpdate));
		EventSystem.Instance.Remove(EEventName.AreaStoryProgressSave, new Action(this.EventAreaStoryProgressSave));
		EventSystem.Instance.Remove(EEventName.OpenExploreAreaDetailViewFromMap, new <>f__AnonymousDelegate6<int, EExploreType?>(this.EventOpenExploreAreaDetailViewFromMap));
	}

	// Token: 0x06009F6C RID: 40812 RVA: 0x002F1641 File Offset: 0x002EF841
	protected override void OnBeforeShow()
	{
		if (!this.UpdateViewByAreaData())
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06009F6D RID: 40813 RVA: 0x002F1652 File Offset: 0x002EF852
	protected override void OnBeforeDestroy()
	{
		this.StageRewardPanel = null;
		this.PopupCaption = null;
	}

	// Token: 0x06009F6E RID: 40814 RVA: 0x002F1664 File Offset: 0x002EF864
	protected void InitExploreScroll()
	{
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(3);
		this.ExploreScroll = new LoopScrollView<MapExploreDetailItem, ExploreAreaItemData>(loopScrollViewComponent, base.GetItem(20).GetOwner() as AUIBaseActor, new Func<MapExploreDetailItem>(this.InitHandExploreDetailItem), false);
	}

	// Token: 0x06009F6F RID: 40815 RVA: 0x002F16A4 File Offset: 0x002EF8A4
	private void UpdateExploreScrollList()
	{
		LoopScrollView<MapExploreDetailItem, ExploreAreaItemData> exploreScroll = this.ExploreScroll;
		if (exploreScroll == null)
		{
			return;
		}
		exploreScroll.RefreshByData(this.CurAreaData.GetAllExploreAreaItemData(), false, new Action(this.ExploreScrollSelectIndex), true);
	}

	// Token: 0x06009F70 RID: 40816 RVA: 0x002F16D0 File Offset: 0x002EF8D0
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

	// Token: 0x06009F71 RID: 40817 RVA: 0x002F1748 File Offset: 0x002EF948
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

	// Token: 0x06009F72 RID: 40818 RVA: 0x002F1792 File Offset: 0x002EF992
	private MapExploreDetailItem InitHandExploreDetailItem()
	{
		return new MapExploreDetailItem();
	}

	// Token: 0x06009F73 RID: 40819 RVA: 0x002F179C File Offset: 0x002EF99C
	private void OnAreaBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.MapAreaShowView, new MapAreaShowViewParams
		{
			CountryId = new int?(this.CurAreaData.CountryId),
			AreaId = new int?(this.CurAreaData.AreaId),
			OnClickArea = new Action<int>(this.OnMapAreaShowClickArea)
		}, null);
	}

	// Token: 0x06009F74 RID: 40820 RVA: 0x002F17FC File Offset: 0x002EF9FC
	private void OnStoryBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.MapExploreStoryView, new MapExploreStoryViewParams
		{
			AreaData = this.CurAreaData
		}, new TOpenViewCallBack(this.AddViewToChild));
	}

	// Token: 0x06009F75 RID: 40821 RVA: 0x002F182C File Offset: 0x002EFA2C
	private void OnExploreToolTips()
	{
		ExploreAreaItemData curAreaItemData = this.CurAreaItemData;
		int? num = (curAreaItemData != null) ? curAreaItemData.GetPhantomSkillHelpId() : null;
		if (num != null)
		{
			HelpController.Instance.OpenHelpById(num.Value);
		}
	}

	// Token: 0x06009F76 RID: 40822 RVA: 0x002F186E File Offset: 0x002EFA6E
	private void OnAreaTaskBtn()
	{
		if (this.CurAreaItemData != null)
		{
			UiManager.Instance.OpenView(EUiViewName.ExploreMissionView, this.CurAreaItemData.AreaId, new TOpenViewCallBack(this.AddViewToChild));
		}
	}

	// Token: 0x06009F77 RID: 40823 RVA: 0x002F18A3 File Offset: 0x002EFAA3
	private void OnExploreProgressBarDetailBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.MapPlayPointDetailView, new MapPlayPointDetailViewParams
		{
			ExploreAreaItemData = this.CurAreaItemData
		}, new TOpenViewCallBack(this.AddViewToChild));
	}

	// Token: 0x06009F78 RID: 40824 RVA: 0x002F18D1 File Offset: 0x002EFAD1
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

	// Token: 0x06009F79 RID: 40825 RVA: 0x002F18F0 File Offset: 0x002EFAF0
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

	// Token: 0x06009F7A RID: 40826 RVA: 0x002F195F File Offset: 0x002EFB5F
	private void OnCloseBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009F7B RID: 40827 RVA: 0x002F1968 File Offset: 0x002EFB68
	private void OnAreaChangeLeftBtn()
	{
		this.ChangeAreaDataByAddIndex(-1);
		base.PlaySequence("SwitchLeft", null, false);
	}

	// Token: 0x06009F7C RID: 40828 RVA: 0x002F197E File Offset: 0x002EFB7E
	private void OnAreaChangeRightBtn()
	{
		this.ChangeAreaDataByAddIndex(1);
		base.PlaySequence("SwitchRight", null, false);
	}

	// Token: 0x06009F7D RID: 40829 RVA: 0x002F1994 File Offset: 0x002EFB94
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

	// Token: 0x06009F7E RID: 40830 RVA: 0x002F19F0 File Offset: 0x002EFBF0
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

	// Token: 0x06009F7F RID: 40831 RVA: 0x002F1ABC File Offset: 0x002EFCBC
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

	// Token: 0x06009F80 RID: 40832 RVA: 0x002F1B58 File Offset: 0x002EFD58
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

	// Token: 0x06009F81 RID: 40833 RVA: 0x002F1BB0 File Offset: 0x002EFDB0
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

	// Token: 0x06009F82 RID: 40834 RVA: 0x002F1C84 File Offset: 0x002EFE84
	protected override void OnTick(float delta)
	{
		MapAreaRewardPanel stageRewardPanel = this.StageRewardPanel;
		if (stageRewardPanel == null)
		{
			return;
		}
		stageRewardPanel.OnTickRefresh(delta);
	}

	// Token: 0x06009F83 RID: 40835 RVA: 0x002F1C97 File Offset: 0x002EFE97
	private void EventReceiveAreaStageRewardResponse(IReadOnlyList<int> rewardIds)
	{
		MapAreaRewardPanel stageRewardPanel = this.StageRewardPanel;
		if (stageRewardPanel == null)
		{
			return;
		}
		stageRewardPanel.UpdateRewardIds(rewardIds);
	}

	// Token: 0x06009F84 RID: 40836 RVA: 0x002F1CAA File Offset: 0x002EFEAA
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

	// Token: 0x06009F85 RID: 40837 RVA: 0x002F1CE2 File Offset: 0x002EFEE2
	private void EventMapExploreDetailItemClick(ExploreAreaItemData areaItemData)
	{
		this.CurAreaItemData = areaItemData;
		this.UpdateExploreDetail();
	}

	// Token: 0x06009F86 RID: 40838 RVA: 0x002F1CF1 File Offset: 0x002EFEF1
	private void EventAreaPlayPointUpdate(int areaId)
	{
		ExploreAreaData curAreaData = this.CurAreaData;
		if (curAreaData == null || curAreaData.AreaId != areaId)
		{
			return;
		}
		this.UpdateExploreDetail();
	}

	// Token: 0x06009F87 RID: 40839 RVA: 0x002F1D14 File Offset: 0x002EFF14
	private void EventAreaStoryProgressSave()
	{
		this.UpdateStoryRedDot();
	}

	// Token: 0x06009F88 RID: 40840 RVA: 0x002F1D1C File Offset: 0x002EFF1C
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

	// Token: 0x06009F89 RID: 40841 RVA: 0x002F1D48 File Offset: 0x002EFF48
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

	// Token: 0x06009F8A RID: 40842 RVA: 0x002F1DC1 File Offset: 0x002EFFC1
	private void ForceChangeArea(int areaId, EExploreType? exploreType = null)
	{
		if (!this.UpdateAreaDataByAreaId(areaId))
		{
			return;
		}
		this.ForceChangeAreaItem(exploreType, false);
		this.UpdateViewByAreaData();
	}

	// Token: 0x06009F8B RID: 40843 RVA: 0x002F1DDC File Offset: 0x002EFFDC
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

	// Token: 0x06009F8C RID: 40844 RVA: 0x002F1FB0 File Offset: 0x002F01B0
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

	// Token: 0x06009F8D RID: 40845 RVA: 0x002F20A8 File Offset: 0x002F02A8
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

	// Token: 0x06009F8E RID: 40846 RVA: 0x002F2110 File Offset: 0x002F0310
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

	// Token: 0x06009F8F RID: 40847 RVA: 0x002F21F0 File Offset: 0x002F03F0
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

	// Token: 0x06009F90 RID: 40848 RVA: 0x002F2280 File Offset: 0x002F0480
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

	// Token: 0x170010F6 RID: 4342
	// (get) Token: 0x06009F91 RID: 40849 RVA: 0x002F22AC File Offset: 0x002F04AC
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

	// Token: 0x06009F92 RID: 40850 RVA: 0x002F22D8 File Offset: 0x002F04D8
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

	// Token: 0x04005E62 RID: 24162
	[Nullable(2)]
	private ExploreAreaData CurAreaData;

	// Token: 0x04005E63 RID: 24163
	private List<ExploreAreaData> AreaDataList = new List<ExploreAreaData>();

	// Token: 0x04005E64 RID: 24164
	private int CurAreaDataIndex;

	// Token: 0x04005E65 RID: 24165
	[Nullable(2)]
	private MapAreaRewardPanel StageRewardPanel;

	// Token: 0x04005E66 RID: 24166
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<MapExploreDetailItem, ExploreAreaItemData> ExploreScroll;

	// Token: 0x04005E67 RID: 24167
	[Nullable(2)]
	private PopupCaptionItem PopupCaption;

	// Token: 0x04005E68 RID: 24168
	[Nullable(2)]
	private ExploreAreaItemData CurAreaItemData;

	// Token: 0x04005E69 RID: 24169
	[Nullable(2)]
	private MapExplorePlayProgressPanel PlayProgressPanel;

	// Token: 0x04005E6A RID: 24170
	[Nullable(2)]
	private ExploreDetailLockItem ExploreDetailLockItem;

	// Token: 0x04005E6B RID: 24171
	private readonly ButtonItem ExploreTrackButton = new ButtonItem(null);

	// Token: 0x020071AF RID: 29103
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402507E RID: 151678
		ItemCaption,
		// Token: 0x0402507F RID: 151679
		AreaChangeLeftBtn,
		// Token: 0x04025080 RID: 151680
		AreaChangeRightBtn,
		// Token: 0x04025081 RID: 151681
		ExploreScrollView,
		// Token: 0x04025082 RID: 151682
		StoryBtn,
		// Token: 0x04025083 RID: 151683
		AreaName,
		// Token: 0x04025084 RID: 151684
		AreaBtn,
		// Token: 0x04025085 RID: 151685
		StageReward,
		// Token: 0x04025086 RID: 151686
		AreaPercent,
		// Token: 0x04025087 RID: 151687
		AreaRedDot,
		// Token: 0x04025088 RID: 151688
		AreaTaskBtn,
		// Token: 0x04025089 RID: 151689
		ExploreItemBg,
		// Token: 0x0402508A RID: 151690
		ExploreDesc,
		// Token: 0x0402508B RID: 151691
		ExploreToolItem,
		// Token: 0x0402508C RID: 151692
		ExploreToolDesc,
		// Token: 0x0402508D RID: 151693
		ExploreToolTips,
		// Token: 0x0402508E RID: 151694
		ExploreProgressBar,
		// Token: 0x0402508F RID: 151695
		ExploreProgressBarDetailBtn,
		// Token: 0x04025090 RID: 151696
		ExploreTrackBtn,
		// Token: 0x04025091 RID: 151697
		ExploreProgressBarRoot,
		// Token: 0x04025092 RID: 151698
		ExploreScrollItem,
		// Token: 0x04025093 RID: 151699
		ExploreDetailRoot,
		// Token: 0x04025094 RID: 151700
		ExploreDetailLockedRoot,
		// Token: 0x04025095 RID: 151701
		ExploreDetailLockedDesc,
		// Token: 0x04025096 RID: 151702
		ExploreDetailFinishedRoot,
		// Token: 0x04025097 RID: 151703
		ExploreZero,
		// Token: 0x04025098 RID: 151704
		StoryProgress,
		// Token: 0x04025099 RID: 151705
		StoryRedDot,
		// Token: 0x0402509A RID: 151706
		ExploreDetailLockRoot,
		// Token: 0x0402509B RID: 151707
		ExploreDetailProgressImageRoot,
		// Token: 0x0402509C RID: 151708
		PanelHighLightTips,
		// Token: 0x0402509D RID: 151709
		TextHighLightTips
	}
}
