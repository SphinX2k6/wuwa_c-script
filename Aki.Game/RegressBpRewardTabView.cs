using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000937 RID: 2359
public class RegressBpRewardTabView : UiTabViewBase, IRegressBpTabView
{
	// Token: 0x0600683B RID: 26683 RVA: 0x00209360 File Offset: 0x00207560
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnPay))
		};
	}

	// Token: 0x0600683C RID: 26684 RVA: 0x0020940C File Offset: 0x0020760C
	protected override UniTask OnBeforeStartAsync()
	{
		RegressBpRewardTabView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RegressBpRewardTabView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600683D RID: 26685 RVA: 0x0020944F File Offset: 0x0020764F
	protected override void OnBeforeShow()
	{
		this.RefreshView(true);
	}

	// Token: 0x0600683E RID: 26686 RVA: 0x00209458 File Offset: 0x00207658
	[NullableContext(1)]
	public void RefreshBtnClaimVisible(UUIItem uiItem)
	{
		uiItem.SetUIActive(ActivityRegressModel.Instance.ActivityData.CheckRegressScoreRewardReached());
	}

	// Token: 0x0600683F RID: 26687 RVA: 0x0020946F File Offset: 0x0020766F
	public void OnClickBtnClaimAll()
	{
		ActivityRegressController.Instance.RequestAllTaskScoreRewards();
	}

	// Token: 0x06006840 RID: 26688 RVA: 0x0020947B File Offset: 0x0020767B
	[NullableContext(1)]
	private RegressBpRewardItem OnCreateRewardItem()
	{
		return new RegressBpRewardItem();
	}

	// Token: 0x06006841 RID: 26689 RVA: 0x00209484 File Offset: 0x00207684
	public void RefreshView(bool playAnim = false)
	{
		if (this.LoopScrollView == null)
		{
			return;
		}
		List<ActivityRegressTaskScoreRewardGridData> regressMainTaskScoreRewardGridDataArr = ActivityRegressModel.Instance.GetRegressMainTaskScoreRewardGridDataArr();
		regressMainTaskScoreRewardGridDataArr.Sort((ActivityRegressTaskScoreRewardGridData a, ActivityRegressTaskScoreRewardGridData b) => a.Config.Value.NeedScore - b.Config.Value.NeedScore);
		this.LoopScrollView.RefreshByData(regressMainTaskScoreRewardGridDataArr, false, null, playAnim);
		this.RefreshStageReward(true);
		base.GetSprite(0).SetUIActive(!ActivityRegressModel.Instance.ActivityData.IsPayRewardUnlock());
		base.GetButton(4).SetSelfInteractive(!ActivityRegressModel.Instance.ActivityData.IsPayRewardUnlock());
	}

	// Token: 0x06006842 RID: 26690 RVA: 0x0020951C File Offset: 0x0020771C
	private void OnScrollViewScrollValueChanged()
	{
		this.RefreshStageReward(false);
	}

	// Token: 0x06006843 RID: 26691 RVA: 0x00209528 File Offset: 0x00207728
	private void RefreshStageReward(bool forceRefresh = false)
	{
		int endGridIndex = this.LoopScrollView.EndGridIndex;
		int num = (int)(Math.Ceiling((double)endGridIndex / 10.0) * 10.0 - 1.0);
		ActivityRegressTaskScoreRewardGridData activityRegressTaskScoreRewardGridData = this.LoopScrollView.TryGetCachedData(num);
		if (activityRegressTaskScoreRewardGridData == null)
		{
			num = endGridIndex;
			activityRegressTaskScoreRewardGridData = this.LoopScrollView.TryGetCachedData(num);
		}
		if (this.StageRewardView.GridIndex == num && !forceRefresh)
		{
			return;
		}
		this.StageRewardView.GridIndex = num;
		this.StageRewardView.Refresh(activityRegressTaskScoreRewardGridData, false, this.StageRewardView.GridIndex);
	}

	// Token: 0x06006844 RID: 26692 RVA: 0x002095BD File Offset: 0x002077BD
	private void OnClickBtnPay()
	{
		ActivityRegressModel.Instance.ActivityData.SetBpPayButtonRedDotChecked();
		UiManager.Instance.OpenView(EUiViewName.RegressBpPayView, null, delegate(bool success, int viewId)
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.ActivityRegressMainView);
			if (viewByName == null)
			{
				return;
			}
			viewByName.AddChildViewById(viewId);
		});
	}

	// Token: 0x04004273 RID: 17011
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<RegressBpRewardItem, ActivityRegressTaskScoreRewardGridData> LoopScrollView;

	// Token: 0x04004274 RID: 17012
	[Nullable(2)]
	private RegressBpRewardItem StageRewardView;

	// Token: 0x02006C2E RID: 27694
	private class EComponents
	{
		// Token: 0x040238DD RID: 145629
		public const int SpriteLock = 0;

		// Token: 0x040238DE RID: 145630
		public const int RewardScroll = 1;

		// Token: 0x040238DF RID: 145631
		public const int Item = 2;

		// Token: 0x040238E0 RID: 145632
		public const int StageRewardItem = 3;

		// Token: 0x040238E1 RID: 145633
		public const int BtnPay = 4;
	}
}
