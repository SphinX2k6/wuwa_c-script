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

// Token: 0x02001488 RID: 5256
[NullableContext(2)]
[Nullable(0)]
public class ActivityHomePageRegressSubView : ActivitySubViewBase
{
	// Token: 0x060094CB RID: 38091 RVA: 0x002011B0 File Offset: 0x001FF3B0
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

	// Token: 0x060094CC RID: 38092 RVA: 0x002014B4 File Offset: 0x001FF6B4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityHomePageRegressSubView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityHomePageRegressSubView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060094CD RID: 38093 RVA: 0x002014F8 File Offset: 0x001FF6F8
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

	// Token: 0x060094CE RID: 38094 RVA: 0x0020155C File Offset: 0x001FF75C
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

	// Token: 0x060094CF RID: 38095 RVA: 0x002015C0 File Offset: 0x001FF7C0
	protected override void OnStart()
	{
		ActivityRegressModel.Instance.SetFirstShowChecked();
		this.ActivityDescriptionTypeA.SetContentByTextId("Activity_101800001_Desc", Array.Empty<string>());
		this.RegressQuestBtnItem.BindRedDot(ERedDotName.ActivityRecallTaskEntry);
		this.RegressSignBtnItem.BindRedDot(ERedDotName.ActivityRecallSignEntry);
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityRegressQuestionnaire, base.GetItem(14), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityRegressShopDiscount, base.GetItem(12), null, 0);
	}

	// Token: 0x060094D0 RID: 38096 RVA: 0x00201640 File Offset: 0x001FF840
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

	// Token: 0x060094D1 RID: 38097 RVA: 0x002016E8 File Offset: 0x001FF8E8
	protected override void OnRefreshView()
	{
		this.RefreshTitle();
		this.RefreshEntrance();
		this.RefreshTaskProgress();
		this.RefreshGrade();
		this.RefreshSignBubble();
		this.RefreshDiscountBubble();
	}

	// Token: 0x060094D2 RID: 38098 RVA: 0x0020170E File Offset: 0x001FF90E
	protected override void OnTimer(float gap)
	{
		this.RefreshTitle();
	}

	// Token: 0x060094D3 RID: 38099 RVA: 0x00201716 File Offset: 0x001FF916
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(this.OnActivityUpdate));
		EventSystem.Instance.Add<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
	}

	// Token: 0x060094D4 RID: 38100 RVA: 0x00201750 File Offset: 0x001FF950
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(this.OnActivityUpdate));
		EventSystem.Instance.Remove<int, int>(EEventName.OnCommonItemCountAnyChange, new Action<int, int>(this.OnInventoryUpdate));
	}

	// Token: 0x060094D5 RID: 38101 RVA: 0x0020178A File Offset: 0x001FF98A
	private void OnSignBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressMainView, EActivityMainSubViewType.Sign, null);
	}

	// Token: 0x060094D6 RID: 38102 RVA: 0x002017A2 File Offset: 0x001FF9A2
	private void OnShopBtnClick()
	{
		SkipTaskManager.RunByConfigId(859201, null);
		ActivityRegressHelper.ReportRegressLog1060();
		ActivityRegressModel.Instance.ActivityData.SetShopRedDotChecked();
	}

	// Token: 0x060094D7 RID: 38103 RVA: 0x002017C3 File Offset: 0x001FF9C3
	private void OnQuestionBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressQuestionnaireView, null, null);
	}

	// Token: 0x060094D8 RID: 38104 RVA: 0x002017D6 File Offset: 0x001FF9D6
	private void OnRegressQuestBtnClick(ERegressGrade grade)
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressTaskMainView, EActivityRegressTaskSubViewType.MainTask, null);
	}

	// Token: 0x060094D9 RID: 38105 RVA: 0x002017F0 File Offset: 0x001FF9F0
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

	// Token: 0x060094DA RID: 38106 RVA: 0x0020186C File Offset: 0x001FFA6C
	private void RefreshTaskProgress()
	{
		double regressTaskProgressFloat = ActivityRegressModel.Instance.ActivityData.GetRegressTaskProgressFloat01();
		base.GetText(5).SetText(((int)(regressTaskProgressFloat * 100.0)).ToString() + "%", true);
		base.GetTexture(7).SetFillAmount((float)regressTaskProgressFloat);
	}

	// Token: 0x060094DB RID: 38107 RVA: 0x002018C4 File Offset: 0x001FFAC4
	private void RefreshGrade()
	{
		ERegressGrade grade = ActivityRegressModel.Instance.Grade;
		this.RegressQuestBtnItem.Grade = grade;
		this.RegressSignBtnItem.Grade = grade;
		base.GetItem(18).SetUIActive(grade == ERegressGrade.Normal);
		base.GetItem(19).SetUIActive(grade == ERegressGrade.Hyper);
	}

	// Token: 0x060094DC RID: 38108 RVA: 0x00201916 File Offset: 0x001FFB16
	private void RefreshEntrance()
	{
		this.RefreshSingleEntrance(EActivityRegressEntranceType.NewMainLine);
		this.RefreshSingleEntrance(EActivityRegressEntranceType.NewArea);
		this.RefreshRoleEntrance();
	}

	// Token: 0x060094DD RID: 38109 RVA: 0x0020192C File Offset: 0x001FFB2C
	private void RefreshSingleEntrance(EActivityRegressEntranceType entryType)
	{
		RegressEntry? regressEntrySingleConfigByType = ActivityRegressConfig.Instance.GetRegressEntrySingleConfigByType(entryType);
		this.ActivityRecallEntryMap[entryType].RefreshData(entryType, regressEntrySingleConfigByType);
	}

	// Token: 0x060094DE RID: 38110 RVA: 0x00201958 File Offset: 0x001FFB58
	private void RefreshRoleEntrance()
	{
		RegressEntry? config = ActivityRegressConfig.Instance.GetSortedOpenRegressEntryConfigList()[0];
		this.ActivityRecallEntryMap[EActivityRegressEntranceType.NewRole1].RefreshData(EActivityRegressEntranceType.NewRole1, config);
	}

	// Token: 0x060094DF RID: 38111 RVA: 0x00201989 File Offset: 0x001FFB89
	private void OnActivityUpdate()
	{
		this.OnRefreshView();
	}

	// Token: 0x060094E0 RID: 38112 RVA: 0x00201991 File Offset: 0x001FFB91
	private void OnInventoryUpdate(int configId, int count)
	{
		this.RefreshTaskProgress();
	}

	// Token: 0x060094E1 RID: 38113 RVA: 0x0020199C File Offset: 0x001FFB9C
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

	// Token: 0x060094E2 RID: 38114 RVA: 0x00201A0E File Offset: 0x001FFC0E
	private void RefreshDiscountBubble()
	{
		base.GetItem(15).SetUIActive(false);
	}

	// Token: 0x040041E8 RID: 16872
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x040041E9 RID: 16873
	private ActivityDescriptionTypeA ActivityDescriptionTypeA;

	// Token: 0x040041EA RID: 16874
	private RegressGradeButtonItem RegressQuestBtnItem;

	// Token: 0x040041EB RID: 16875
	private RegressGradeSignItem RegressSignBtnItem;

	// Token: 0x040041EC RID: 16876
	[Nullable(1)]
	private readonly Dictionary<EActivityRegressEntranceType, ActivityRegressEntryItemPanel> ActivityRecallEntryMap = new Dictionary<EActivityRegressEntranceType, ActivityRegressEntryItemPanel>();

	// Token: 0x02007AB3 RID: 31411
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040285E6 RID: 165350
		public const int ActivityTitle = 0;

		// Token: 0x040285E7 RID: 165351
		public const int EntranceBtn1 = 1;

		// Token: 0x040285E8 RID: 165352
		public const int EntranceBtn2 = 2;

		// Token: 0x040285E9 RID: 165353
		public const int EntranceBtn3 = 3;

		// Token: 0x040285EA RID: 165354
		public const int EntranceBtn4 = 4;

		// Token: 0x040285EB RID: 165355
		public const int ProgressTxt = 5;

		// Token: 0x040285EC RID: 165356
		public const int ActivityDescriptionTypeA = 6;

		// Token: 0x040285ED RID: 165357
		public const int TexBar = 7;

		// Token: 0x040285EE RID: 165358
		public const int BtnConfirmB = 8;

		// Token: 0x040285EF RID: 165359
		public const int SignBtn = 9;

		// Token: 0x040285F0 RID: 165360
		public const int SignRedDot = 10;

		// Token: 0x040285F1 RID: 165361
		public const int ShopBtn = 11;

		// Token: 0x040285F2 RID: 165362
		public const int ShopBtnRedDot = 12;

		// Token: 0x040285F3 RID: 165363
		public const int QuestionBtn = 13;

		// Token: 0x040285F4 RID: 165364
		public const int QuestionBtnRedDot = 14;

		// Token: 0x040285F5 RID: 165365
		public const int ShopDiscountNode = 15;

		// Token: 0x040285F6 RID: 165366
		public const int ShopDiscountText = 16;

		// Token: 0x040285F7 RID: 165367
		public const int HyperConfirmBtnB = 17;

		// Token: 0x040285F8 RID: 165368
		public const int NormalCurrencyTexNode = 18;

		// Token: 0x040285F9 RID: 165369
		public const int HyperCurrencyTexNode = 19;

		// Token: 0x040285FA RID: 165370
		public const int NormalSignCurrencyIcon = 20;

		// Token: 0x040285FB RID: 165371
		public const int NormalSignCurrencyText = 21;

		// Token: 0x040285FC RID: 165372
		public const int HyperSignBtn = 22;

		// Token: 0x040285FD RID: 165373
		public const int HyperSignCurrencyIcon = 23;

		// Token: 0x040285FE RID: 165374
		public const int HyperSignCurrencyText = 24;

		// Token: 0x040285FF RID: 165375
		public const int HyperSignRedDot = 25;

		// Token: 0x04028600 RID: 165376
		public const int NormalSignBubbleNode = 26;

		// Token: 0x04028601 RID: 165377
		public const int HyperSignBubbleNode = 27;
	}
}
