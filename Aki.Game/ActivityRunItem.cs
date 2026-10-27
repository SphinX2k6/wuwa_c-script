using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014D8 RID: 5336
public class ActivityRunItem : UiPanelBase, IGridProxy<int>
{
	// Token: 0x17000D18 RID: 3352
	// (get) Token: 0x060097C5 RID: 38853 RVA: 0x0020CC53 File Offset: 0x0020AE53
	// (set) Token: 0x060097C6 RID: 38854 RVA: 0x0020CC5B File Offset: 0x0020AE5B
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

	// Token: 0x17000D19 RID: 3353
	// (get) Token: 0x060097C7 RID: 38855 RVA: 0x0020CC64 File Offset: 0x0020AE64
	// (set) Token: 0x060097C8 RID: 38856 RVA: 0x0020CC6C File Offset: 0x0020AE6C
	public int GridIndex { get; set; }

	// Token: 0x17000D1A RID: 3354
	// (get) Token: 0x060097C9 RID: 38857 RVA: 0x0020CC75 File Offset: 0x0020AE75
	// (set) Token: 0x060097CA RID: 38858 RVA: 0x0020CC7D File Offset: 0x0020AE7D
	public int DisplayIndex { get; set; }

	// Token: 0x060097CB RID: 38859 RVA: 0x0020CC86 File Offset: 0x0020AE86
	[NullableContext(1)]
	public object GetKey(int data, int gridIndex)
	{
		return null;
	}

	// Token: 0x060097CC RID: 38860 RVA: 0x0020CC8C File Offset: 0x0020AE8C
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

	// Token: 0x060097CD RID: 38861 RVA: 0x0020CDB8 File Offset: 0x0020AFB8
	protected override void OnStart()
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
		this.RewardScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(scrollViewWithScrollbar, new Func<CommonItemSmallItemGrid>(this.CreatePropItem), null, false, null);
		this.AddEventListener();
	}

	// Token: 0x060097CE RID: 38862 RVA: 0x0020CDEE File Offset: 0x0020AFEE
	protected void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnGetRunActivityReward, new Action<int>(this.OnGetRunActivityReward));
	}

	// Token: 0x060097CF RID: 38863 RVA: 0x0020CE0C File Offset: 0x0020B00C
	protected void RemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnGetRunActivityReward, new Action<int>(this.OnGetRunActivityReward));
	}

	// Token: 0x060097D0 RID: 38864 RVA: 0x0020CE2A File Offset: 0x0020B02A
	private void OnGetRunActivityReward(int score)
	{
		if (score == this.CurrentScore)
		{
			this.RefreshContentState();
		}
	}

	// Token: 0x060097D1 RID: 38865 RVA: 0x0020CE3B File Offset: 0x0020B03B
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x060097D2 RID: 38866 RVA: 0x0020CE3D File Offset: 0x0020B03D
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x060097D3 RID: 38867 RVA: 0x0020CE3F File Offset: 0x0020B03F
	[NullableContext(1)]
	private CommonItemSmallItemGrid CreatePropItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x060097D4 RID: 38868 RVA: 0x0020CE48 File Offset: 0x0020B048
	private void OnClickFinishButton()
	{
		int scoreIndex = ActivityRunModel.Instance.GetActivityRunData(ActivityRunModel.Instance.CurrentSelectChallengeId).GetScoreIndex(this.CurrentScore);
		ActivityRunController.Instance.RequestTakeChallengeReward(ActivityRunModel.Instance.CurrentSelectChallengeId, scoreIndex);
	}

	// Token: 0x060097D5 RID: 38869 RVA: 0x0020CE8A File Offset: 0x0020B08A
	public void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.CurrentScore = data;
		this.RefreshTitle();
		this.RefreshReward();
		this.RefreshContentState();
	}

	// Token: 0x060097D6 RID: 38870 RVA: 0x0020CEA5 File Offset: 0x0020B0A5
	public void Clear()
	{
	}

	// Token: 0x060097D7 RID: 38871 RVA: 0x0020CEA7 File Offset: 0x0020B0A7
	private void RefreshTitle()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), "ActivityRunPointNeed", new <>z__ReadOnlySingleElementList<object>(this.CurrentScore.ToString()));
	}

	// Token: 0x060097D8 RID: 38872 RVA: 0x0020CED0 File Offset: 0x0020B0D0
	private void RefreshReward()
	{
		ActivityRunData activityRunData = ActivityRunModel.Instance.GetActivityRunData(ActivityRunModel.Instance.CurrentSelectChallengeId);
		int scoreIndex = activityRunData.GetScoreIndex(this.CurrentScore);
		List<TItem> scoreIndexPreviewItem = activityRunData.GetScoreIndexPreviewItem(scoreIndex);
		this.RewardScrollView.RefreshByData(scoreIndexPreviewItem, null, false);
	}

	// Token: 0x060097D9 RID: 38873 RVA: 0x0020CF14 File Offset: 0x0020B114
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

	// Token: 0x060097DA RID: 38874 RVA: 0x0020CFE1 File Offset: 0x0020B1E1
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x040042CE RID: 17102
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollView;

	// Token: 0x040042CF RID: 17103
	private int CurrentScore;

	// Token: 0x02007B14 RID: 31508
	private class EComponents
	{
		// Token: 0x040287AD RID: 165805
		public const int Title = 0;

		// Token: 0x040287AE RID: 165806
		public const int ItemScroller = 1;

		// Token: 0x040287AF RID: 165807
		public const int UnFinishedText = 2;

		// Token: 0x040287B0 RID: 165808
		public const int SprDone = 3;

		// Token: 0x040287B1 RID: 165809
		public const int FinishButton = 4;

		// Token: 0x040287B2 RID: 165810
		public const int FinishedItem = 5;
	}
}
