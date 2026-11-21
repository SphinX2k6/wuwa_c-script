using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000950 RID: 2384
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegressSignPanel : UiPanelBase
{
	// Token: 0x06006912 RID: 26898 RVA: 0x0020D08C File Offset: 0x0020B28C
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

	// Token: 0x06006913 RID: 26899 RVA: 0x0020D154 File Offset: 0x0020B354
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressSignPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressSignPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006914 RID: 26900 RVA: 0x0020D198 File Offset: 0x0020B398
	protected override void OnBeforeShow()
	{
		this.SequencePlayer.PlaySequence("Start", false, null);
	}

	// Token: 0x06006915 RID: 26901 RVA: 0x0020D1C0 File Offset: 0x0020B3C0
	protected override UniTask OnBeforeHideAsync()
	{
		ActivityRegressSignPanel.<OnBeforeHideAsync>d__8 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<ActivityRegressSignPanel.<OnBeforeHideAsync>d__8>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006916 RID: 26902 RVA: 0x0020D203 File Offset: 0x0020B403
	protected override void OnAfterHide()
	{
		this.ClearTimer();
	}

	// Token: 0x06006917 RID: 26903 RVA: 0x0020D20B File Offset: 0x0020B40B
	protected override void OnBeforeDestroy()
	{
		this.ClearTimer();
		ActivityRegressModel.Instance.ClearSignRewardConfig();
	}

	// Token: 0x06006918 RID: 26904 RVA: 0x0020D21D File Offset: 0x0020B41D
	public void RefreshView()
	{
		ActivityRegressModel.Instance.SetupSignRewardConfig();
		this.RefreshTitle();
		this.RefreshSignInItems();
	}

	// Token: 0x06006919 RID: 26905 RVA: 0x0020D238 File Offset: 0x0020B438
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

	// Token: 0x0600691A RID: 26906 RVA: 0x0020D2A8 File Offset: 0x0020B4A8
	private void RefreshSignInItems()
	{
		for (int i = 0; i < this.SignInRewardItems.Count; i++)
		{
			this.SignInRewardItems[i].RefreshByData(i);
		}
	}

	// Token: 0x0600691B RID: 26907 RVA: 0x0020D2DD File Offset: 0x0020B4DD
	private void OnTimerRefresh(float gap)
	{
		this.RefreshTitle();
	}

	// Token: 0x0600691C RID: 26908 RVA: 0x0020D2E5 File Offset: 0x0020B4E5
	private void ClearTimer()
	{
		if (TimerSystem.Instance.Has(this.RefreshTimerHandle))
		{
			TimerSystem.Instance.Remove(this.RefreshTimerHandle);
			this.RefreshTimerHandle = null;
		}
	}

	// Token: 0x0600691D RID: 26909 RVA: 0x0020D314 File Offset: 0x0020B514
	private void OnRewardItemClick(int index)
	{
		int signRewardEntityId = ActivityRegressModel.Instance.ActivityData.GetSignRewardEntityId(index + 1);
		ActivityRegressController.Instance.RequestClaimSignReward(signRewardEntityId);
	}

	// Token: 0x040042B3 RID: 17075
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x040042B4 RID: 17076
	[Nullable(1)]
	private readonly List<ActivityRegressSignInRewardItem> SignInRewardItems = new List<ActivityRegressSignInRewardItem>();

	// Token: 0x040042B5 RID: 17077
	private TimerHandle RefreshTimerHandle;

	// Token: 0x040042B6 RID: 17078
	private UiSequencePlayer SequencePlayer;

	// Token: 0x02006C54 RID: 27732
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402398E RID: 145806
		public const int ComActivityTitle = 0;

		// Token: 0x0402398F RID: 145807
		public const int SignInItem1 = 1;

		// Token: 0x04023990 RID: 145808
		public const int SignInItem2 = 2;

		// Token: 0x04023991 RID: 145809
		public const int SignInItem3 = 3;

		// Token: 0x04023992 RID: 145810
		public const int SignInItem4 = 4;

		// Token: 0x04023993 RID: 145811
		public const int SignInItem5 = 5;

		// Token: 0x04023994 RID: 145812
		public const int SignInItem6 = 6;

		// Token: 0x04023995 RID: 145813
		public const int SignInItem7 = 7;
	}
}
