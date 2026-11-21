using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200094B RID: 2379
public class ActivityRegressQuestionnaireView : UiViewBase
{
	// Token: 0x060068EB RID: 26859 RVA: 0x0020C4DD File Offset: 0x0020A6DD
	[NullableContext(1)]
	public ActivityRegressQuestionnaireView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060068EC RID: 26860 RVA: 0x0020C4E8 File Offset: 0x0020A6E8
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

	// Token: 0x060068ED RID: 26861 RVA: 0x0020C5EC File Offset: 0x0020A7EC
	protected override void OnStart()
	{
		this.Layout1 = new GenericLayout<ActivityRegressQuestionnaireLayoutItem, ActivityRegressQuestionnaireItemData>(base.GetHorizontalLayout(0), new Func<ActivityRegressQuestionnaireLayoutItem>(this.CreateLayoutItem), null, false, true);
		this.Layout2 = new GenericLayout<ActivityRegressQuestionnaireLayoutItem, ActivityRegressQuestionnaireItemData>(base.GetHorizontalLayout(3), new Func<ActivityRegressQuestionnaireLayoutItem>(this.CreateLayoutItem), null, false, true);
	}

	// Token: 0x060068EE RID: 26862 RVA: 0x0020C63B File Offset: 0x0020A83B
	protected override void OnBeforeShow()
	{
		ActivityRegressModel.Instance.ActivityData.SetQuestionnaireRedDotChecked();
		this.UpdateVisiuals();
	}

	// Token: 0x060068EF RID: 26863 RVA: 0x0020C652 File Offset: 0x0020A852
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(this.UpdateVisiuals));
	}

	// Token: 0x060068F0 RID: 26864 RVA: 0x0020C670 File Offset: 0x0020A870
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(this.UpdateVisiuals));
	}

	// Token: 0x060068F1 RID: 26865 RVA: 0x0020C68E File Offset: 0x0020A88E
	protected override void OnBeforeDestroy()
	{
		this.Layout1.ClearChildren();
		this.Layout2.ClearChildren();
	}

	// Token: 0x060068F2 RID: 26866 RVA: 0x0020C6A6 File Offset: 0x0020A8A6
	[NullableContext(1)]
	private ActivityRegressQuestionnaireLayoutItem CreateLayoutItem()
	{
		return new ActivityRegressQuestionnaireLayoutItem();
	}

	// Token: 0x060068F3 RID: 26867 RVA: 0x0020C6B0 File Offset: 0x0020A8B0
	private void UpdateVisiuals()
	{
		List<ActivityRegressQuestionnaireItemData> regressQuestionnaireRewardDataList = ActivityRegressModel.Instance.GetRegressQuestionnaireRewardDataList(ERegressQuestionnaireType.Type1);
		this.Layout1.RefreshByData(regressQuestionnaireRewardDataList, null, false);
		List<ActivityRegressQuestionnaireItemData> regressQuestionnaireRewardDataList2 = ActivityRegressModel.Instance.GetRegressQuestionnaireRewardDataList(ERegressQuestionnaireType.Type2);
		this.Layout2.RefreshByData(regressQuestionnaireRewardDataList2, null, false);
		base.GetItem(6).SetUIActive(ActivityRegressModel.Instance.ActivityData.IsQuestionnaireUnlock(ERegressQuestionnaireType.Type2));
	}

	// Token: 0x060068F4 RID: 26868 RVA: 0x0020C710 File Offset: 0x0020A910
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

	// Token: 0x060068F5 RID: 26869 RVA: 0x0020C778 File Offset: 0x0020A978
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

	// Token: 0x040042A1 RID: 17057
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivityRegressQuestionnaireLayoutItem, ActivityRegressQuestionnaireItemData> Layout1;

	// Token: 0x040042A2 RID: 17058
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ActivityRegressQuestionnaireLayoutItem, ActivityRegressQuestionnaireItemData> Layout2;

	// Token: 0x02006C4B RID: 27723
	private class EComponents
	{
		// Token: 0x04023961 RID: 145761
		public const int PnlHor1 = 0;

		// Token: 0x04023962 RID: 145762
		public const int PnlItem1 = 1;

		// Token: 0x04023963 RID: 145763
		public const int PnlBtn1 = 2;

		// Token: 0x04023964 RID: 145764
		public const int PnlHor2 = 3;

		// Token: 0x04023965 RID: 145765
		public const int PnlItem2 = 4;

		// Token: 0x04023966 RID: 145766
		public const int PnlBtn2 = 5;

		// Token: 0x04023967 RID: 145767
		public const int RootItem2 = 6;

		// Token: 0x04023968 RID: 145768
		public const int RootItem1 = 7;
	}
}
