using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000990 RID: 2448
public class ActivityRunItem : UiPanelBase, IGridProxy<int>
{
	// Token: 0x17000D39 RID: 3385
	// (get) Token: 0x06006B9F RID: 27551 RVA: 0x00216993 File Offset: 0x00214B93
	// (set) Token: 0x06006BA0 RID: 27552 RVA: 0x0021699B File Offset: 0x00214B9B
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IScrollViewDelegate<IGridProxy<int>, int> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17000D3A RID: 3386
	// (get) Token: 0x06006BA1 RID: 27553 RVA: 0x002169A4 File Offset: 0x00214BA4
	// (set) Token: 0x06006BA2 RID: 27554 RVA: 0x002169AC File Offset: 0x00214BAC
	public int GridIndex { get; set; }

	// Token: 0x17000D3B RID: 3387
	// (get) Token: 0x06006BA3 RID: 27555 RVA: 0x002169B5 File Offset: 0x00214BB5
	// (set) Token: 0x06006BA4 RID: 27556 RVA: 0x002169BD File Offset: 0x00214BBD
	public int DisplayIndex { get; set; }

	// Token: 0x06006BA5 RID: 27557 RVA: 0x002169C6 File Offset: 0x00214BC6
	[NullableContext(1)]
	public object GetKey(int data, int gridIndex)
	{
		return null;
	}

	// Token: 0x06006BA6 RID: 27558 RVA: 0x002169CC File Offset: 0x00214BCC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickFinishButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006BA7 RID: 27559 RVA: 0x00216AF8 File Offset: 0x00214CF8
	protected override void OnStart()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(scrollViewWithScrollbar, new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
		this.AddEventListener();
	}

	// Token: 0x06006BA8 RID: 27560 RVA: 0x00216B2E File Offset: 0x00214D2E
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnGetRunActivityReward, new Action<int>(this.OnGetRunActivityReward));
	}

	// Token: 0x06006BA9 RID: 27561 RVA: 0x00216B4C File Offset: 0x00214D4C
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnGetRunActivityReward, new Action<int>(this.OnGetRunActivityReward));
	}

	// Token: 0x06006BAA RID: 27562 RVA: 0x00216B6A File Offset: 0x00214D6A
	private void OnGetRunActivityReward(int score)
	{
		if (score == this.CurrentScore)
		{
			this.RefreshContentState();
		}
	}

	// Token: 0x06006BAB RID: 27563 RVA: 0x00216B7B File Offset: 0x00214D7B
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x06006BAC RID: 27564 RVA: 0x00216B7D File Offset: 0x00214D7D
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x06006BAD RID: 27565 RVA: 0x00216B7F File Offset: 0x00214D7F
	[NullableContext(1)]
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06006BAE RID: 27566 RVA: 0x00216B88 File Offset: 0x00214D88
	private void OnClickFinishButton()
	{
		int scoreIndex = ActivityRunModel.Instance.GetActivityRunData(ActivityRunModel.Instance.CurrentSelectChallengeId).GetScoreIndex(this.CurrentScore);
		ActivityRunController.Instance.RequestTakeChallengeReward(ActivityRunModel.Instance.CurrentSelectChallengeId, scoreIndex);
	}

	// Token: 0x06006BAF RID: 27567 RVA: 0x00216BCA File Offset: 0x00214DCA
	public void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.CurrentScore = data;
		this.RefreshTitle();
		this.RefreshReward();
		this.RefreshContentState();
	}

	// Token: 0x06006BB0 RID: 27568 RVA: 0x00216BE5 File Offset: 0x00214DE5
	public void Clear()
	{
	}

	// Token: 0x06006BB1 RID: 27569 RVA: 0x00216BE7 File Offset: 0x00214DE7
	private void RefreshTitle()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), "ActivityRunPointNeed", new <>z__ReadOnlySingleElementList<object>(this.CurrentScore.ToString()));
	}

	// Token: 0x06006BB2 RID: 27570 RVA: 0x00216C10 File Offset: 0x00214E10
	private void RefreshReward()
	{
		ActivityRunData activityRunData = ActivityRunModel.Instance.GetActivityRunData(ActivityRunModel.Instance.CurrentSelectChallengeId);
		int scoreIndex = activityRunData.GetScoreIndex(this.CurrentScore);
		List<TItem> scoreIndexPreviewItem = activityRunData.GetScoreIndexPreviewItem(scoreIndex);
		this.RewardScrollView.RefreshByData(scoreIndexPreviewItem, null, false);
	}

	// Token: 0x06006BB3 RID: 27571 RVA: 0x00216C54 File Offset: 0x00214E54
	private void RefreshContentState()
	{
		ActivityRunData activityRunData = ActivityRunModel.Instance.GetActivityRunData(ActivityRunModel.Instance.CurrentSelectChallengeId);
		EActivityRunStateEnum scoreIndexCannotGetReward = activityRunData.GetScoreIndexCannotGetReward(activityRunData.GetScoreIndex(this.CurrentScore));
		base.GetText(2).SetUIActive(false);
		UUIItem uuiitem = base.GetButton(4).RootUIComp.Get();
		if (uuiitem != null)
		{
			uuiitem.SetUIActive(false);
		}
		base.GetItem(5).SetUIActive(false);
		base.GetSprite(3).SetUIActive(false);
		if (scoreIndexCannotGetReward == EActivityRunStateEnum.UnFinished)
		{
			base.GetText(2).SetUIActive(true);
			return;
		}
		if (scoreIndexCannotGetReward != EActivityRunStateEnum.CanGetReward)
		{
			if (scoreIndexCannotGetReward == EActivityRunStateEnum.HaveGetReward)
			{
				base.GetSprite(3).SetUIActive(true);
			}
			return;
		}
		base.GetItem(5).SetUIActive(true);
		UUIItem uuiitem2 = base.GetButton(4).RootUIComp.Get();
		if (uuiitem2 == null)
		{
			return;
		}
		uuiitem2.SetUIActive(true);
	}

	// Token: 0x06006BB4 RID: 27572 RVA: 0x00216D21 File Offset: 0x00214F21
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x04004373 RID: 17267
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x04004374 RID: 17268
	private int CurrentScore;

	// Token: 0x02006CA0 RID: 27808
	private class EComponents
	{
		// Token: 0x04023AEB RID: 146155
		public const int Title = 0;

		// Token: 0x04023AEC RID: 146156
		public const int ItemScroller = 1;

		// Token: 0x04023AED RID: 146157
		public const int UnFinishedText = 2;

		// Token: 0x04023AEE RID: 146158
		public const int SprDone = 3;

		// Token: 0x04023AEF RID: 146159
		public const int FinishButton = 4;

		// Token: 0x04023AF0 RID: 146160
		public const int FinishedItem = 5;
	}
}
