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

// Token: 0x0200149D RID: 5277
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressStartupView : UiViewBase
{
	// Token: 0x0600958A RID: 38282 RVA: 0x002043EA File Offset: 0x002025EA
	public ActivityRegressStartupView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600958B RID: 38283 RVA: 0x002043F4 File Offset: 0x002025F4
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

	// Token: 0x0600958C RID: 38284 RVA: 0x002044DC File Offset: 0x002026DC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(this.RefreshReward));
	}

	// Token: 0x0600958D RID: 38285 RVA: 0x002044FA File Offset: 0x002026FA
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(this.RefreshReward));
	}

	// Token: 0x0600958E RID: 38286 RVA: 0x00204518 File Offset: 0x00202718
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

	// Token: 0x0600958F RID: 38287 RVA: 0x002045B9 File Offset: 0x002027B9
	protected override void OnBeforeShow()
	{
		ActivityRegressModel.Instance.AlreadyStartView = true;
		ActivityRegressModel.Instance.RecordActivityRecallSplashFirstShow();
		SplashScreenController.Instance.FinishCurTask(ESplashScreenSourceModuleType.Recall);
		this.StateMachine.Start();
	}

	// Token: 0x06009590 RID: 38288 RVA: 0x002045E6 File Offset: 0x002027E6
	protected override void OnBeforeDestroy()
	{
		this.StateMachine.ShutDown();
	}

	// Token: 0x06009591 RID: 38289 RVA: 0x002045F3 File Offset: 0x002027F3
	private CommonItemSmallItemGrid InitGridItem()
	{
		CommonItemSmallItemGrid commonItemSmallItemGrid = new CommonItemSmallItemGrid();
		commonItemSmallItemGrid.ShowReceivedCallBack = ((TItem _) => ActivityRegressModel.Instance.DisposableReward);
		return commonItemSmallItemGrid;
	}

	// Token: 0x06009592 RID: 38290 RVA: 0x00204620 File Offset: 0x00202820
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

	// Token: 0x06009593 RID: 38291 RVA: 0x00204684 File Offset: 0x00202884
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

	// Token: 0x06009594 RID: 38292 RVA: 0x002046E8 File Offset: 0x002028E8
	private void RefreshReward()
	{
		foreach (CommonItemSmallItemGrid commonItemSmallItemGrid in this.RewardLayout.GetLayoutItemList())
		{
			commonItemSmallItemGrid.SetReceivedVisible(ActivityRegressModel.Instance.DisposableReward);
		}
	}

	// Token: 0x06009595 RID: 38293 RVA: 0x00204748 File Offset: 0x00202948
	private void OnContinueBtnClick()
	{
		this.StateMachine.PlayNextState();
	}

	// Token: 0x0400421F RID: 16927
	private bool FormActityView;

	// Token: 0x04004220 RID: 16928
	[Nullable(2)]
	private RegressTransitionStateMachine StateMachine;

	// Token: 0x04004221 RID: 16929
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x02007AD3 RID: 31443
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04028685 RID: 165509
		public const int PnlHor = 0;

		// Token: 0x04028686 RID: 165510
		public const int BtnContinue = 1;

		// Token: 0x04028687 RID: 165511
		public const int NormalCoreCtrl = 2;

		// Token: 0x04028688 RID: 165512
		public const int HyperCoreCtrl = 3;
	}
}
