using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001483 RID: 5251
public class RegressBpRewardTabView : UiTabViewBase, IRegressBpTabView
{
	// Token: 0x060094A6 RID: 38054 RVA: 0x002003FC File Offset: 0x001FE5FC
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

	// Token: 0x060094A7 RID: 38055 RVA: 0x002004A8 File Offset: 0x001FE6A8
	protected override UniTask OnBeforeStartAsync()
	{
		RegressBpRewardTabView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RegressBpRewardTabView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060094A8 RID: 38056 RVA: 0x002004EB File Offset: 0x001FE6EB
	protected override void OnBeforeShow()
	{
		this.RefreshView(true);
	}

	// Token: 0x060094A9 RID: 38057 RVA: 0x002004F4 File Offset: 0x001FE6F4
	[NullableContext(1)]
	public void RefreshBtnClaimVisible(UUIItem uiItem)
	{
		uiItem.SetUIActive(ActivityRegressModel.Instance.ActivityData.CheckRegressScoreRewardReached());
	}

	// Token: 0x060094AA RID: 38058 RVA: 0x0020050B File Offset: 0x001FE70B
	public void OnClickBtnClaimAll()
	{
		ActivityRegressController.Instance.RequestAllTaskScoreRewards();
	}

	// Token: 0x060094AB RID: 38059 RVA: 0x00200517 File Offset: 0x001FE717
	[NullableContext(1)]
	private RegressBpRewardItem OnCreateRewardItem()
	{
		return new RegressBpRewardItem();
	}

	// Token: 0x060094AC RID: 38060 RVA: 0x00200520 File Offset: 0x001FE720
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

	// Token: 0x060094AD RID: 38061 RVA: 0x002005B8 File Offset: 0x001FE7B8
	private void OnScrollViewScrollValueChanged()
	{
		this.RefreshStageReward(false);
	}

	// Token: 0x060094AE RID: 38062 RVA: 0x002005C4 File Offset: 0x001FE7C4
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

	// Token: 0x060094AF RID: 38063 RVA: 0x00200659 File Offset: 0x001FE859
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

	// Token: 0x040041DB RID: 16859
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<RegressBpRewardItem, ActivityRegressTaskScoreRewardGridData> LoopScrollView;

	// Token: 0x040041DC RID: 16860
	[Nullable(2)]
	private RegressBpRewardItem StageRewardView;

	// Token: 0x02007AAA RID: 31402
	private class EComponents
	{
		// Token: 0x040285C3 RID: 165315
		public const int SpriteLock = 0;

		// Token: 0x040285C4 RID: 165316
		public const int RewardScroll = 1;

		// Token: 0x040285C5 RID: 165317
		public const int Item = 2;

		// Token: 0x040285C6 RID: 165318
		public const int StageRewardItem = 3;

		// Token: 0x040285C7 RID: 165319
		public const int BtnPay = 4;
	}
}
