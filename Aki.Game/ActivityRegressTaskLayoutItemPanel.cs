using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000962 RID: 2402
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressTaskLayoutItemPanel : UiPanelBase, IGridProxy<ActivityRegressTaskScoreRewardGridData>
{
	// Token: 0x17000D20 RID: 3360
	// (get) Token: 0x06006984 RID: 27012 RVA: 0x0020E477 File Offset: 0x0020C677
	// (set) Token: 0x06006985 RID: 27013 RVA: 0x0020E47F File Offset: 0x0020C67F
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

	// Token: 0x17000D21 RID: 3361
	// (get) Token: 0x06006986 RID: 27014 RVA: 0x0020E488 File Offset: 0x0020C688
	// (set) Token: 0x06006987 RID: 27015 RVA: 0x0020E490 File Offset: 0x0020C690
	public int GridIndex { get; set; }

	// Token: 0x17000D22 RID: 3362
	// (get) Token: 0x06006988 RID: 27016 RVA: 0x0020E499 File Offset: 0x0020C699
	// (set) Token: 0x06006989 RID: 27017 RVA: 0x0020E4A1 File Offset: 0x0020C6A1
	public int DisplayIndex { get; set; }

	// Token: 0x0600698A RID: 27018 RVA: 0x0020E4AC File Offset: 0x0020C6AC
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

	// Token: 0x0600698B RID: 27019 RVA: 0x0020E5C8 File Offset: 0x0020C7C8
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

	// Token: 0x0600698C RID: 27020 RVA: 0x0020E69C File Offset: 0x0020C89C
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

	// Token: 0x0600698D RID: 27021 RVA: 0x0020E7FC File Offset: 0x0020C9FC
	public void Clear()
	{
		this.ScoreRewardGridData = null;
	}

	// Token: 0x0600698E RID: 27022 RVA: 0x0020E805 File Offset: 0x0020CA05
	public void OnSelected(bool fireEvent)
	{
	}

	// Token: 0x0600698F RID: 27023 RVA: 0x0020E807 File Offset: 0x0020CA07
	public void OnDeselected(bool fireEvent)
	{
	}

	// Token: 0x06006990 RID: 27024 RVA: 0x0020E809 File Offset: 0x0020CA09
	public object GetKey(ActivityRegressTaskScoreRewardGridData data, int gridIndex)
	{
		return this.GridIndex;
	}

	// Token: 0x06006991 RID: 27025 RVA: 0x0020E818 File Offset: 0x0020CA18
	private void OnExtendToggleClickedA(MediumItemGridExtendCallback _)
	{
		if (this.ScoreRewardGridData.RewardState == ERegressRewardState.Reached)
		{
			ActivityRegressController.Instance.RequestAllTaskScoreRewards();
			return;
		}
		int id = ActivityRegressModel.Instance.GetRegressScoreRewardInfoList(this.ScoreRewardGridData.Config.Value)[0].ItemInfo.Value.Id;
		ItemController.Instance.OpenItemTipsByItemId(id, true, null, false);
	}

	// Token: 0x06006992 RID: 27026 RVA: 0x0020E888 File Offset: 0x0020CA88
	private void OnExtendToggleClickedB(MediumItemGridExtendCallback _)
	{
		if (this.ScoreRewardGridData.RewardState == ERegressRewardState.Reached)
		{
			ActivityRegressController.Instance.RequestAllTaskScoreRewards();
			return;
		}
		int id = ActivityRegressModel.Instance.GetRegressScoreRewardInfoList(this.ScoreRewardGridData.Config.Value)[1].ItemInfo.Value.Id;
		ItemController.Instance.OpenItemTipsByItemId(id, true, null, false);
	}

	// Token: 0x06006993 RID: 27027 RVA: 0x0020E8F5 File Offset: 0x0020CAF5
	private void OnBtnRewardClick()
	{
		if (this.ScoreRewardGridData.RewardState == ERegressRewardState.Reached)
		{
			ActivityRegressController.Instance.RequestAllTaskScoreRewards();
		}
	}

	// Token: 0x040042DB RID: 17115
	[Nullable(2)]
	private ActivityRegressTaskScoreRewardGridData ScoreRewardGridData;

	// Token: 0x040042DC RID: 17116
	[Nullable(2)]
	private SmallItemGrid ItemGridA;

	// Token: 0x040042DD RID: 17117
	[Nullable(2)]
	private SmallItemGrid ItemGridB;

	// Token: 0x02006C68 RID: 27752
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040239E4 RID: 145892
		public const int SprBar = 0;

		// Token: 0x040239E5 RID: 145893
		public const int SprNor = 1;

		// Token: 0x040239E6 RID: 145894
		public const int SprReceived = 2;

		// Token: 0x040239E7 RID: 145895
		public const int TxtNum = 3;

		// Token: 0x040239E8 RID: 145896
		public const int PnlHorItem = 4;

		// Token: 0x040239E9 RID: 145897
		public const int RedDotItem = 5;

		// Token: 0x040239EA RID: 145898
		public const int ItemBaseB2A = 6;

		// Token: 0x040239EB RID: 145899
		public const int ItemBaseB2B = 7;

		// Token: 0x040239EC RID: 145900
		public const int SprDone = 8;

		// Token: 0x040239ED RID: 145901
		public const int BtnReward = 9;
	}
}
