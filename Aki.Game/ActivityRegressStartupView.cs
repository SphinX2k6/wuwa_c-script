using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000951 RID: 2385
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressStartupView : UiViewBase
{
	// Token: 0x0600691F RID: 26911 RVA: 0x0020D352 File Offset: 0x0020B552
	public ActivityRegressStartupView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06006920 RID: 26912 RVA: 0x0020D35C File Offset: 0x0020B55C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnContinueBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006921 RID: 26913 RVA: 0x0020D444 File Offset: 0x0020B644
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(this.RefreshReward));
	}

	// Token: 0x06006922 RID: 26914 RVA: 0x0020D462 File Offset: 0x0020B662
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(this.RefreshReward));
	}

	// Token: 0x06006923 RID: 26915 RVA: 0x0020D480 File Offset: 0x0020B680
	protected override void OnStart()
	{
		this.FormActityView = (this.OpenParam as bool?).GetValueOrDefault();
		this.StateMachine = new RegressTransitionStateMachine();
		this.RewardLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(0), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, true);
		ERegressGrade grade = ActivityRegressModel.Instance.Grade;
		this.RewardLayout.RefreshByData(this.GetRewardList(grade), delegate
		{
			foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.RewardLayout.GetLayoutItemList())
			{
				commonItemSmallItemGrid.SetReceivedVisible(ActivityRegressModel.Instance.DisposableReward);
			}
		}, false);
		base.GetItem(2).SetUIActive(grade == ERegressGrade.Normal);
		base.GetItem(3).SetUIActive(grade == ERegressGrade.Hyper);
	}

	// Token: 0x06006924 RID: 26916 RVA: 0x0020D521 File Offset: 0x0020B721
	protected override void OnBeforeShow()
	{
		ActivityRegressModel.Instance.AlreadyStartView = true;
		ActivityRegressModel.Instance.RecordActivityRecallSplashFirstShow();
		SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.Recall);
		this.StateMachine.Start();
	}

	// Token: 0x06006925 RID: 26917 RVA: 0x0020D54E File Offset: 0x0020B74E
	protected override void OnBeforeDestroy()
	{
		this.StateMachine.ShutDown();
	}

	// Token: 0x06006926 RID: 26918 RVA: 0x0020D55B File Offset: 0x0020B75B
	private CommonItemSmallItemGrid InitGridItem()
	{
		CommonItemSmallItemGrid commonItemSmallItemGrid = new CommonItemSmallItemGrid();
		commonItemSmallItemGrid.ShowReceivedCallBack = ((TItem _) => ActivityRegressModel.Instance.DisposableReward);
		return commonItemSmallItemGrid;
	}

	// Token: 0x06006927 RID: 26919 RVA: 0x0020D588 File Offset: 0x0020B788
	public List<TItem> GetRewardList(ERegressGrade grade)
	{
		RegressDisposableReward? regressDisposableReward = ActivityRegressConfig.Instance.GetRegressDisposableReward(ActivityRegressModel.Instance.ActivityId);
		if (regressDisposableReward == null)
		{
			return new List<TItem>();
		}
		int id = (grade == ERegressGrade.Hyper) ? regressDisposableReward.Value.HighDropId : regressDisposableReward.Value.DropId;
		return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(id);
	}

	// Token: 0x06006928 RID: 26920 RVA: 0x0020D5EC File Offset: 0x0020B7EC
	public void GotoActivityViewAndCloseSelf()
	{
		ActivityRegressModel.Instance.SetFirstShowChecked();
		base.CloseMe(null);
		int activityId = ActivityRegressModel.Instance.ActivityId;
		if (activityId != 0 && !this.FormActityView)
		{
			ActivityController.Instance.OpenActivityById(activityId, EActivityViewOpenType.Other, null, delegate(bool _)
			{
			});
		}
	}

	// Token: 0x06006929 RID: 26921 RVA: 0x0020D650 File Offset: 0x0020B850
	private void RefreshReward()
	{
		foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.RewardLayout.GetLayoutItemList())
		{
			commonItemSmallItemGrid.SetReceivedVisible(ActivityRegressModel.Instance.DisposableReward);
		}
	}

	// Token: 0x0600692A RID: 26922 RVA: 0x0020D6B0 File Offset: 0x0020B8B0
	private void OnContinueBtnClick()
	{
		this.StateMachine.PlayNextState();
	}

	// Token: 0x040042B7 RID: 17079
	private bool FormActityView;

	// Token: 0x040042B8 RID: 17080
	[Nullable(2)]
	private RegressTransitionStateMachine StateMachine;

	// Token: 0x040042B9 RID: 17081
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x02006C57 RID: 27735
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x0402399F RID: 145823
		public const int PnlHor = 0;

		// Token: 0x040239A0 RID: 145824
		public const int BtnContinue = 1;

		// Token: 0x040239A1 RID: 145825
		public const int NormalCoreCtrl = 2;

		// Token: 0x040239A2 RID: 145826
		public const int HyperCoreCtrl = 3;
	}
}
