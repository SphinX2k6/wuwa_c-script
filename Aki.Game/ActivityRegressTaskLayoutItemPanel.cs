using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020014AE RID: 5294
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressTaskLayoutItemPanel : UiPanelBase, IGridProxy<ActivityRegressTaskScoreRewardGridData>
{
	// Token: 0x17000D00 RID: 3328
	// (get) Token: 0x060095EF RID: 38383 RVA: 0x0020550F File Offset: 0x0020370F
	// (set) Token: 0x060095F0 RID: 38384 RVA: 0x00205517 File Offset: 0x00203717
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	public IScrollViewDelegate<IGridProxy<ActivityRegressTaskScoreRewardGridData>, ActivityRegressTaskScoreRewardGridData> ScrollViewDelegate { [return: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})] set; }

	// Token: 0x17000D01 RID: 3329
	// (get) Token: 0x060095F1 RID: 38385 RVA: 0x00205520 File Offset: 0x00203720
	// (set) Token: 0x060095F2 RID: 38386 RVA: 0x00205528 File Offset: 0x00203728
	public int GridIndex { get; set; }

	// Token: 0x17000D02 RID: 3330
	// (get) Token: 0x060095F3 RID: 38387 RVA: 0x00205531 File Offset: 0x00203731
	// (set) Token: 0x060095F4 RID: 38388 RVA: 0x00205539 File Offset: 0x00203739
	public int DisplayIndex { get; set; }

	// Token: 0x060095F5 RID: 38389 RVA: 0x00205544 File Offset: 0x00203744
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnBtnRewardClick))
		};
	}

	// Token: 0x060095F6 RID: 38390 RVA: 0x00205660 File Offset: 0x00203860
	protected override void OnStart()
	{
		this.ItemGridA = new SmallItemGrid();
		this.ItemGridA.Initialize(base.GetItem(6).GetOwner());
		this.ItemGridA.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.ItemGridA.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleClickedA));
		this.ItemGridB = new SmallItemGrid();
		this.ItemGridB.Initialize(base.GetItem(7).GetOwner());
		this.ItemGridB.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
		this.ItemGridB.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnExtendToggleClickedB));
	}

	// Token: 0x060095F7 RID: 38391 RVA: 0x00205734 File Offset: 0x00203934
	public void Refresh(ActivityRegressTaskScoreRewardGridData data, bool isSelected, int gridIndex)
	{
		this.ScoreRewardGridData = data;
		this.GridIndex = gridIndex;
		List<IRegressRewardItemInfo> regressScoreRewardInfoList = ActivityRegressModel.Instance.GetRegressScoreRewardInfoList(data.Config.Value);
		ERegressRewardState rewardState = data.RewardState;
		IRegressRewardItemInfo data2 = regressScoreRewardInfoList[0];
		ActivityRegressHelper.RefreshItemGridByData(this.ItemGridA, data2);
		bool flag = regressScoreRewardInfoList.Count > 1;
		this.ItemGridB.SetUiActive(flag);
		if (flag)
		{
			IRegressRewardItemInfo data3 = regressScoreRewardInfoList[1];
			ActivityRegressHelper.RefreshItemGridByData(this.ItemGridB, data3);
		}
		UUIText text = base.GetText(3);
		int needScore = data.Config.Value.NeedScore;
		UUIText uuitext = text;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(needScore);
		uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		text.useChangeColor = (rewardState == ERegressRewardState.Claim);
		if (text.useChangeColor)
		{
			text.SetColor(text.changeColor);
		}
		UUISprite sprite = base.GetSprite(0);
		ValueTuple<int, int> regressTaskRelativeScore = ActivityRegressModel.Instance.ActivityData.GetRegressTaskRelativeScore(data.Config.Value);
		int item = regressTaskRelativeScore.Item1;
		int item2 = regressTaskRelativeScore.Item2;
		float fillAmount = (float)item / (float)item2;
		sprite.SetFillAmount(fillAmount);
		base.GetItem(5).SetUIActive(rewardState == ERegressRewardState.Reached);
		base.GetItem(1).SetUIActive(rewardState != ERegressRewardState.Claim);
		base.GetItem(2).SetUIActive(rewardState == ERegressRewardState.Reached);
		base.GetItem(8).SetUIActive(rewardState == ERegressRewardState.Claim);
	}

	// Token: 0x060095F8 RID: 38392 RVA: 0x00205894 File Offset: 0x00203A94
	public void Clear()
	{
		this.ScoreRewardGridData = null;
	}

	// Token: 0x060095F9 RID: 38393 RVA: 0x0020589D File Offset: 0x00203A9D
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x060095FA RID: 38394 RVA: 0x0020589F File Offset: 0x00203A9F
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x060095FB RID: 38395 RVA: 0x002058A1 File Offset: 0x00203AA1
	public object GetKey(ActivityRegressTaskScoreRewardGridData data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x060095FC RID: 38396 RVA: 0x002058B0 File Offset: 0x00203AB0
	private void OnExtendToggleClickedA(MediumItemGridExtendCallback _)
	{
		if (this.ScoreRewardGridData.RewardState == ERegressRewardState.Reached)
		{
			ActivityRegressController.Instance.RequestAllTaskScoreRewards();
			return;
		}
		int id = ActivityRegressModel.Instance.GetRegressScoreRewardInfoList(this.ScoreRewardGridData.Config.Value)[0].ItemInfo.Value.Id;
		ItemController.Instance.OpenItemTipsByItemId(id, true, null);
	}

	// Token: 0x060095FD RID: 38397 RVA: 0x0020591C File Offset: 0x00203B1C
	private void OnExtendToggleClickedB(MediumItemGridExtendCallback _)
	{
		if (this.ScoreRewardGridData.RewardState == ERegressRewardState.Reached)
		{
			ActivityRegressController.Instance.RequestAllTaskScoreRewards();
			return;
		}
		int id = ActivityRegressModel.Instance.GetRegressScoreRewardInfoList(this.ScoreRewardGridData.Config.Value)[1].ItemInfo.Value.Id;
		ItemController.Instance.OpenItemTipsByItemId(id, true, null);
	}

	// Token: 0x060095FE RID: 38398 RVA: 0x00205988 File Offset: 0x00203B88
	private void OnBtnRewardClick()
	{
		if (this.ScoreRewardGridData.RewardState == ERegressRewardState.Reached)
		{
			ActivityRegressController.Instance.RequestAllTaskScoreRewards();
		}
	}

	// Token: 0x04004243 RID: 16963
	[Nullable(2)]
	private ActivityRegressTaskScoreRewardGridData ScoreRewardGridData;

	// Token: 0x04004244 RID: 16964
	[Nullable(2)]
	private SmallItemGrid ItemGridA;

	// Token: 0x04004245 RID: 16965
	[Nullable(2)]
	private SmallItemGrid ItemGridB;

	// Token: 0x02007AE4 RID: 31460
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040286CA RID: 165578
		public const int SprBar = 0;

		// Token: 0x040286CB RID: 165579
		public const int SprNor = 1;

		// Token: 0x040286CC RID: 165580
		public const int SprReceived = 2;

		// Token: 0x040286CD RID: 165581
		public const int TxtNum = 3;

		// Token: 0x040286CE RID: 165582
		public const int PnlHorItem = 4;

		// Token: 0x040286CF RID: 165583
		public const int RedDotItem = 5;

		// Token: 0x040286D0 RID: 165584
		public const int ItemBaseB2A = 6;

		// Token: 0x040286D1 RID: 165585
		public const int ItemBaseB2B = 7;

		// Token: 0x040286D2 RID: 165586
		public const int SprDone = 8;

		// Token: 0x040286D3 RID: 165587
		public const int BtnReward = 9;
	}
}
