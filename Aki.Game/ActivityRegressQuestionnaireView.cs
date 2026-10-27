using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001497 RID: 5271
public class ActivityRegressQuestionnaireView : UiViewBase
{
	// Token: 0x06009556 RID: 38230 RVA: 0x00203574 File Offset: 0x00201774
	[NullableContext(1)]
	public ActivityRegressQuestionnaireView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06009557 RID: 38231 RVA: 0x00203580 File Offset: 0x00201780
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnBtn1Click)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnBtn2Click))
		};
	}

	// Token: 0x06009558 RID: 38232 RVA: 0x00203684 File Offset: 0x00201884
	protected override void OnStart()
	{
		this.Layout1 = new GenericLayout<ActivityRegressQuestionnaireLayoutItem, ActivityRegressQuestionnaireItemData>(base.GetHorizontalLayout(0), new Func<ActivityRegressQuestionnaireLayoutItem>(this.CreateLayoutItem), null, false, true);
		this.Layout2 = new GenericLayout<ActivityRegressQuestionnaireLayoutItem, ActivityRegressQuestionnaireItemData>(base.GetHorizontalLayout(3), new Func<ActivityRegressQuestionnaireLayoutItem>(this.CreateLayoutItem), null, false, true);
	}

	// Token: 0x06009559 RID: 38233 RVA: 0x002036D3 File Offset: 0x002018D3
	protected override void OnBeforeShow()
	{
		ActivityRegressModel.Instance.ActivityData.SetQuestionnaireRedDotChecked();
		this.UpdateVisiuals();
	}

	// Token: 0x0600955A RID: 38234 RVA: 0x002036EA File Offset: 0x002018EA
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(this.UpdateVisiuals));
	}

	// Token: 0x0600955B RID: 38235 RVA: 0x00203708 File Offset: 0x00201908
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(this.UpdateVisiuals));
	}

	// Token: 0x0600955C RID: 38236 RVA: 0x00203726 File Offset: 0x00201926
	protected override void OnBeforeDestroy()
	{
		this.Layout1.ClearChildren();
		this.Layout2.ClearChildren();
	}

	// Token: 0x0600955D RID: 38237 RVA: 0x0020373E File Offset: 0x0020193E
	[NullableContext(1)]
	private ActivityRegressQuestionnaireLayoutItem CreateLayoutItem()
	{
		return new ActivityRegressQuestionnaireLayoutItem();
	}

	// Token: 0x0600955E RID: 38238 RVA: 0x00203748 File Offset: 0x00201948
	private void UpdateVisiuals()
	{
		List<ActivityRegressQuestionnaireItemData> regressQuestionnaireRewardDataList = ActivityRegressModel.Instance.GetRegressQuestionnaireRewardDataList(ERegressQuestionnaireType.Type1);
		this.Layout1.RefreshByData(regressQuestionnaireRewardDataList, null, false);
		List<ActivityRegressQuestionnaireItemData> regressQuestionnaireRewardDataList2 = ActivityRegressModel.Instance.GetRegressQuestionnaireRewardDataList(ERegressQuestionnaireType.Type2);
		this.Layout2.RefreshByData(regressQuestionnaireRewardDataList2, null, false);
		base.GetItem(6).SetUIActive(ActivityRegressModel.Instance.ActivityData.IsQuestionnaireUnlock(ERegressQuestionnaireType.Type2));
	}

	// Token: 0x0600955F RID: 38239 RVA: 0x002037A8 File Offset: 0x002019A8
	private void OnBtn1Click()
	{
		ActivityRegressController.Instance.OpenQuestionnaire(ERegressQuestionnaireType.Type1);
		RegressInvestigation? regressQuestionnaireConfig = ActivityRegressConfig.Instance.GetRegressQuestionnaireConfig(ERegressQuestionnaireType.Type1);
		if (regressQuestionnaireConfig == null)
		{
			return;
		}
		RegressInvestigation value = regressQuestionnaireConfig.Value;
		if (ActivityRegressModel.Instance.ActivityData.GetQuestionnaireRewardState(value.Id) == ERegressRewardState.UnReach)
		{
			ActivityRegressController.Instance.RequestQuestionOpen(ERegressQuestionnaireType.Type1);
			ActivityRegressHelper.ReportRegressLog1061(value.QuestionnaireId);
		}
	}

	// Token: 0x06009560 RID: 38240 RVA: 0x00203810 File Offset: 0x00201A10
	private void OnBtn2Click()
	{
		ActivityRegressController.Instance.OpenQuestionnaire(ERegressQuestionnaireType.Type2);
		RegressInvestigation? regressQuestionnaireConfig = ActivityRegressConfig.Instance.GetRegressQuestionnaireConfig(ERegressQuestionnaireType.Type2);
		if (regressQuestionnaireConfig == null)
		{
			return;
		}
		RegressInvestigation value = regressQuestionnaireConfig.Value;
		if (ActivityRegressModel.Instance.ActivityData.GetQuestionnaireRewardState(value.Id) == ERegressRewardState.UnReach)
		{
			ActivityRegressController.Instance.RequestQuestionOpen(ERegressQuestionnaireType.Type2);
			ActivityRegressHelper.ReportRegressLog1061(value.QuestionnaireId);
		}
	}

	// Token: 0x04004209 RID: 16905
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivityRegressQuestionnaireLayoutItem, ActivityRegressQuestionnaireItemData> Layout1;

	// Token: 0x0400420A RID: 16906
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivityRegressQuestionnaireLayoutItem, ActivityRegressQuestionnaireItemData> Layout2;

	// Token: 0x02007AC7 RID: 31431
	private class EComponents
	{
		// Token: 0x04028647 RID: 165447
		public const int PnlHor1 = 0;

		// Token: 0x04028648 RID: 165448
		public const int PnlItem1 = 1;

		// Token: 0x04028649 RID: 165449
		public const int PnlBtn1 = 2;

		// Token: 0x0402864A RID: 165450
		public const int PnlHor2 = 3;

		// Token: 0x0402864B RID: 165451
		public const int PnlItem2 = 4;

		// Token: 0x0402864C RID: 165452
		public const int PnlBtn2 = 5;

		// Token: 0x0402864D RID: 165453
		public const int RootItem2 = 6;

		// Token: 0x0402864E RID: 165454
		public const int RootItem1 = 7;
	}
}
