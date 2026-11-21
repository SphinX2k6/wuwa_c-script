using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200093C RID: 2364
[NullableContext(2)]
[Nullable(0)]
public class ActivityHomePageRegressSubView : ActivitySubViewBase
{
	// Token: 0x06006860 RID: 26720 RVA: 0x0020A118 File Offset: 0x00208318
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUITexture)),
			new ValueTuple<int, Type>(23, typeof(UUITexture)),
			new ValueTuple<int, Type>(21, typeof(UUIText)),
			new ValueTuple<int, Type>(24, typeof(UUIText)),
			new ValueTuple<int, Type>(22, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUIItem)),
			new ValueTuple<int, Type>(27, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnSignBtnClick)),
			new ValueTuple<int, Delegate>(22, new Action(this.OnSignBtnClick)),
			new ValueTuple<int, Delegate>(11, new Action(this.OnShopBtnClick)),
			new ValueTuple<int, Delegate>(13, new Action(this.OnQuestionBtnClick))
		};
	}

	// Token: 0x06006861 RID: 26721 RVA: 0x0020A41C File Offset: 0x0020861C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityHomePageRegressSubView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityHomePageRegressSubView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006862 RID: 26722 RVA: 0x0020A460 File Offset: 0x00208660
	private IRegressGradeSignContext GetRegressNormalGradeSignContext()
	{
		return new IRegressGradeSignContext
		{
			Btn = base.GetButton(9),
			RedDotItem = base.GetItem(10),
			CurrencyTexNode = base.GetTexture(20),
			CurrencyText = base.GetText(21),
			BubbleNode = base.GetItem(26)
		};
	}

	// Token: 0x06006863 RID: 26723 RVA: 0x0020A4C4 File Offset: 0x002086C4
	private IRegressGradeSignContext GetRegressHyperGradeSignContext()
	{
		return new IRegressGradeSignContext
		{
			Btn = base.GetButton(22),
			RedDotItem = base.GetItem(25),
			CurrencyTexNode = base.GetTexture(23),
			CurrencyText = base.GetText(24),
			BubbleNode = base.GetItem(27)
		};
	}

	// Token: 0x06006864 RID: 26724 RVA: 0x0020A528 File Offset: 0x00208728
	protected override void OnStart()
	{
		ActivityRegressModel.Instance.SetFirstShowChecked();
		this.ActivityDescriptionTypeA.SetContentByTextId("Activity_101800001_Desc", Array.Empty<string>());
		this.RegressQuestBtnItem.BindRedDot(ERedDotName.ActivityRecallTaskEntry);
		this.RegressSignBtnItem.BindRedDot(ERedDotName.ActivityRecallSignEntry);
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityRegressQuestionnaire, base.GetItem(14), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityRegressShopDiscount, base.GetItem(12), null, 0);
	}

	// Token: 0x06006865 RID: 26725 RVA: 0x0020A5A8 File Offset: 0x002087A8
	protected override void OnBeforeDestroy()
	{
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityRegressQuestionnaire, base.GetItem(14), 0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityRegressShopDiscount, base.GetItem(12), 0);
		foreach (ActivityRegressEntryItemPanel activityRegressEntryItemPanel in this.ActivityRecallEntryMap.Values)
		{
			activityRegressEntryItemPanel.DestroyAsync();
		}
		this.ActivityRecallEntryMap.Clear();
		this.RegressSignBtnItem.Clear();
		this.RegressQuestBtnItem.Clear();
	}

	// Token: 0x06006866 RID: 26726 RVA: 0x0020A650 File Offset: 0x00208850
	protected override void OnRefreshView()
	{
		this.RefreshTitle();
		this.RefreshEntrance();
		this.RefreshTaskProgress();
		this.RefreshGrade();
		this.RefreshSignBubble();
		this.RefreshDiscountBubble();
	}

	// Token: 0x06006867 RID: 26727 RVA: 0x0020A676 File Offset: 0x00208876
	protected override void OnTimer(float gap)
	{
		this.RefreshTitle();
	}

	// Token: 0x06006868 RID: 26728 RVA: 0x0020A67E File Offset: 0x0020887E
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(this.OnActivityUpdate));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
	}

	// Token: 0x06006869 RID: 26729 RVA: 0x0020A6B8 File Offset: 0x002088B8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(this.OnActivityUpdate));
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
	}

	// Token: 0x0600686A RID: 26730 RVA: 0x0020A6F2 File Offset: 0x002088F2
	private void OnSignBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressMainView, EActivityMainSubViewType.Sign, null);
	}

	// Token: 0x0600686B RID: 26731 RVA: 0x0020A70A File Offset: 0x0020890A
	private void OnShopBtnClick()
	{
		SkipTaskManager.RunByConfigId(859201, null);
		ActivityRegressHelper.ReportRegressLog1060();
		ActivityRegressModel.Instance.ActivityData.SetShopRedDotChecked();
	}

	// Token: 0x0600686C RID: 26732 RVA: 0x0020A72B File Offset: 0x0020892B
	private void OnQuestionBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressQuestionnaireView, null, null);
	}

	// Token: 0x0600686D RID: 26733 RVA: 0x0020A73E File Offset: 0x0020893E
	private void OnRegressQuestBtnClick(ERegressGrade grade)
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressTaskMainView, EActivityRegressTaskSubViewType.MainTask, null);
	}

	// Token: 0x0600686E RID: 26734 RVA: 0x0020A758 File Offset: 0x00208958
	private void RefreshTitle()
	{
		this.TitleComponent.SetActivityBaseData(ActivityRegressModel.Instance.ActivityData);
		this.TitleComponent.SetTitleByText(ActivityRegressModel.Instance.ActivityData.GetTitle());
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(ActivityRegressModel.Instance.ActivityData, null);
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.TitleComponent.SetTimeTextVisible(item);
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
	}

	// Token: 0x0600686F RID: 26735 RVA: 0x0020A7D4 File Offset: 0x002089D4
	private void RefreshTaskProgress()
	{
		double regressTaskProgressFloat = ActivityRegressModel.Instance.ActivityData.GetRegressTaskProgressFloat01();
		base.GetText(5).SetText(((int)(regressTaskProgressFloat * 100.0)).ToString() + "%", true);
		base.GetTexture(7).SetFillAmount((float)regressTaskProgressFloat);
	}

	// Token: 0x06006870 RID: 26736 RVA: 0x0020A82C File Offset: 0x00208A2C
	private void RefreshGrade()
	{
		ERegressGrade grade = ActivityRegressModel.Instance.Grade;
		this.RegressQuestBtnItem.Grade = grade;
		this.RegressSignBtnItem.Grade = grade;
		base.GetItem(18).SetUIActive(grade == ERegressGrade.Normal);
		base.GetItem(19).SetUIActive(grade == ERegressGrade.Hyper);
	}

	// Token: 0x06006871 RID: 26737 RVA: 0x0020A87E File Offset: 0x00208A7E
	private void RefreshEntrance()
	{
		this.RefreshSingleEntrance(EActivityRegressEntranceType.NewMainLine);
		this.RefreshSingleEntrance(EActivityRegressEntranceType.NewArea);
		this.RefreshRoleEntrance();
	}

	// Token: 0x06006872 RID: 26738 RVA: 0x0020A894 File Offset: 0x00208A94
	private void RefreshSingleEntrance(EActivityRegressEntranceType entryType)
	{
		RegressEntry? regressEntrySingleConfigByType = ActivityRegressConfig.Instance.GetRegressEntrySingleConfigByType(entryType);
		this.ActivityRecallEntryMap[entryType].RefreshData(entryType, regressEntrySingleConfigByType);
	}

	// Token: 0x06006873 RID: 26739 RVA: 0x0020A8C0 File Offset: 0x00208AC0
	private void RefreshRoleEntrance()
	{
		RegressEntry? config = ActivityRegressConfig.Instance.GetSortedOpenRegressEntryConfigList()[0];
		this.ActivityRecallEntryMap[EActivityRegressEntranceType.NewRole1].RefreshData(EActivityRegressEntranceType.NewRole1, config);
	}

	// Token: 0x06006874 RID: 26740 RVA: 0x0020A8F1 File Offset: 0x00208AF1
	private void OnActivityUpdate()
	{
		this.OnRefreshView();
	}

	// Token: 0x06006875 RID: 26741 RVA: 0x0020A8F9 File Offset: 0x00208AF9
	private void OnInventoryUpdate(int configId, int count)
	{
		this.RefreshTaskProgress();
	}

	// Token: 0x06006876 RID: 26742 RVA: 0x0020A904 File Offset: 0x00208B04
	private void RefreshSignBubble()
	{
		bool flag = ActivityRegressModel.Instance.TodayFirstShowSign();
		bool flag2 = ActivityRegressModel.Instance.HasSignRewardCanClaimed();
		IRegressGradeSignContext activateContext = this.RegressSignBtnItem.GetActivateContext();
		bool flag3 = flag2 && flag;
		if (flag3)
		{
			IRegressRewardItemInfo latestSignRewardItemInfo = ActivityRegressModel.Instance.GetLatestSignRewardItemInfo();
			activateContext.CurrencyText.SetText("x" + latestSignRewardItemInfo.ItemCount.ToString(), true);
		}
		this.RegressSignBtnItem.SetClaimRewardBubbleActive(flag3);
	}

	// Token: 0x06006877 RID: 26743 RVA: 0x0020A976 File Offset: 0x00208B76
	private void RefreshDiscountBubble()
	{
		base.GetItem(15).SetUIActive(false);
	}

	// Token: 0x04004280 RID: 17024
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04004281 RID: 17025
	private ActivityDescriptionTypeA ActivityDescriptionTypeA;

	// Token: 0x04004282 RID: 17026
	private RegressGradeButtonItem RegressQuestBtnItem;

	// Token: 0x04004283 RID: 17027
	private RegressGradeSignItem RegressSignBtnItem;

	// Token: 0x04004284 RID: 17028
	[Nullable(1)]
	private readonly Dictionary<EActivityRegressEntranceType, ActivityRegressEntryItemPanel> ActivityRecallEntryMap = new Dictionary<EActivityRegressEntranceType, ActivityRegressEntryItemPanel>();

	// Token: 0x02006C37 RID: 27703
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023900 RID: 145664
		public const int ActivityTitle = 0;

		// Token: 0x04023901 RID: 145665
		public const int EntranceBtn1 = 1;

		// Token: 0x04023902 RID: 145666
		public const int EntranceBtn2 = 2;

		// Token: 0x04023903 RID: 145667
		public const int EntranceBtn3 = 3;

		// Token: 0x04023904 RID: 145668
		public const int EntranceBtn4 = 4;

		// Token: 0x04023905 RID: 145669
		public const int ProgressTxt = 5;

		// Token: 0x04023906 RID: 145670
		public const int ActivityDescriptionTypeA = 6;

		// Token: 0x04023907 RID: 145671
		public const int TexBar = 7;

		// Token: 0x04023908 RID: 145672
		public const int BtnConfirmB = 8;

		// Token: 0x04023909 RID: 145673
		public const int SignBtn = 9;

		// Token: 0x0402390A RID: 145674
		public const int SignRedDot = 10;

		// Token: 0x0402390B RID: 145675
		public const int ShopBtn = 11;

		// Token: 0x0402390C RID: 145676
		public const int ShopBtnRedDot = 12;

		// Token: 0x0402390D RID: 145677
		public const int QuestionBtn = 13;

		// Token: 0x0402390E RID: 145678
		public const int QuestionBtnRedDot = 14;

		// Token: 0x0402390F RID: 145679
		public const int ShopDiscountNode = 15;

		// Token: 0x04023910 RID: 145680
		public const int ShopDiscountText = 16;

		// Token: 0x04023911 RID: 145681
		public const int HyperConfirmBtnB = 17;

		// Token: 0x04023912 RID: 145682
		public const int NormalCurrencyTexNode = 18;

		// Token: 0x04023913 RID: 145683
		public const int HyperCurrencyTexNode = 19;

		// Token: 0x04023914 RID: 145684
		public const int NormalSignCurrencyIcon = 20;

		// Token: 0x04023915 RID: 145685
		public const int NormalSignCurrencyText = 21;

		// Token: 0x04023916 RID: 145686
		public const int HyperSignBtn = 22;

		// Token: 0x04023917 RID: 145687
		public const int HyperSignCurrencyIcon = 23;

		// Token: 0x04023918 RID: 145688
		public const int HyperSignCurrencyText = 24;

		// Token: 0x04023919 RID: 145689
		public const int HyperSignRedDot = 25;

		// Token: 0x0402391A RID: 145690
		public const int NormalSignBubbleNode = 26;

		// Token: 0x0402391B RID: 145691
		public const int HyperSignBubbleNode = 27;
	}
}
