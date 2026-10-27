using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200149C RID: 5276
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressSignPanel : UiPanelBase
{
	// Token: 0x0600957D RID: 38269 RVA: 0x00204124 File Offset: 0x00202324
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
	}

	// Token: 0x0600957E RID: 38270 RVA: 0x002041EC File Offset: 0x002023EC
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressSignPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressSignPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600957F RID: 38271 RVA: 0x00204230 File Offset: 0x00202430
	protected override void OnBeforeShow()
	{
		this.SequencePlayer.PlaySequence("Start", false, null);
	}

	// Token: 0x06009580 RID: 38272 RVA: 0x00204258 File Offset: 0x00202458
	protected override UniTask OnBeforeHideAsync()
	{
		ActivityRegressSignPanel.<OnBeforeHideAsync>d__8 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<ActivityRegressSignPanel.<OnBeforeHideAsync>d__8>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009581 RID: 38273 RVA: 0x0020429B File Offset: 0x0020249B
	protected override void OnAfterHide()
	{
		this.ClearTimer();
	}

	// Token: 0x06009582 RID: 38274 RVA: 0x002042A3 File Offset: 0x002024A3
	protected override void OnBeforeDestroy()
	{
		this.ClearTimer();
		ActivityRegressModel.Instance.ClearSignRewardConfig();
	}

	// Token: 0x06009583 RID: 38275 RVA: 0x002042B5 File Offset: 0x002024B5
	public void RefreshView()
	{
		ActivityRegressModel.Instance.SetupSignRewardConfig();
		this.RefreshTitle();
		this.RefreshSignInItems();
	}

	// Token: 0x06009584 RID: 38276 RVA: 0x002042D0 File Offset: 0x002024D0
	private void RefreshTitle()
	{
		this.TitleComponent.SetTitleByTextId("RecallActivity_Sign_Title", Array.Empty<string>());
		ActivityRegressData activityData = ActivityRegressModel.Instance.ActivityData;
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(activityData, null);
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.TitleComponent.SetTimeTextVisible(item);
		this.TitleComponent.SetTogActPlayTypeVisible(false);
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
	}

	// Token: 0x06009585 RID: 38277 RVA: 0x00204340 File Offset: 0x00202540
	private void RefreshSignInItems()
	{
		for (int i = 0; i < this.SignInRewardItems.Count; i++)
		{
			this.SignInRewardItems[i].RefreshByData(i);
		}
	}

	// Token: 0x06009586 RID: 38278 RVA: 0x00204375 File Offset: 0x00202575
	private void OnTimerRefresh(float gap)
	{
		this.RefreshTitle();
	}

	// Token: 0x06009587 RID: 38279 RVA: 0x0020437D File Offset: 0x0020257D
	private void ClearTimer()
	{
		if (TimerSystem.Instance.Has(this.RefreshTimerHandle))
		{
			TimerSystem.Instance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x06009588 RID: 38280 RVA: 0x002043AC File Offset: 0x002025AC
	private void OnRewardItemClick(int index)
	{
		int signRewardEntityId = ActivityRegressModel.Instance.ActivityData.GetSignRewardEntityId(index + 1);
		ActivityRegressController.Instance.RequestClaimSignReward(signRewardEntityId);
	}

	// Token: 0x0400421B RID: 16923
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x0400421C RID: 16924
	[Nullable(1)]
	private readonly List<ActivityRegressSignInRewardItem> SignInRewardItems = new List<ActivityRegressSignInRewardItem>();

	// Token: 0x0400421D RID: 16925
	private TimerHandle RefreshTimerHandle;

	// Token: 0x0400421E RID: 16926
	private UiSequencePlayer SequencePlayer;

	// Token: 0x02007AD0 RID: 31440
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04028674 RID: 165492
		public const int ComActivityTitle = 0;

		// Token: 0x04028675 RID: 165493
		public const int SignInItem1 = 1;

		// Token: 0x04028676 RID: 165494
		public const int SignInItem2 = 2;

		// Token: 0x04028677 RID: 165495
		public const int SignInItem3 = 3;

		// Token: 0x04028678 RID: 165496
		public const int SignInItem4 = 4;

		// Token: 0x04028679 RID: 165497
		public const int SignInItem5 = 5;

		// Token: 0x0402867A RID: 165498
		public const int SignInItem6 = 6;

		// Token: 0x0402867B RID: 165499
		public const int SignInItem7 = 7;
	}
}
