using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020008FC RID: 2300
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegress30MainView : ActivitySubViewBase
{
	// Token: 0x06006630 RID: 26160 RVA: 0x001FF87C File Offset: 0x001FDA7C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 22;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 9;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickBattlePassBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickRoleBtnBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickSignBtnBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickNewVersionBtnBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickCultivateBtnBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickStartUpBtnBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickQuestionnaireBtnBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickShopBtnBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(18, new Action(this.OnClickRewardBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006631 RID: 26161 RVA: 0x001FFCE0 File Offset: 0x001FDEE0
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegress30MainView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegress30MainView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006632 RID: 26162 RVA: 0x001FFD23 File Offset: 0x001FDF23
	protected override void OnTimer(float gap)
	{
		this.RefreshTitle();
	}

	// Token: 0x06006633 RID: 26163 RVA: 0x001FFD2C File Offset: 0x001FDF2C
	private void RefreshTitle()
	{
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		this.TitleComponent.SetTimeTextVisible(timeVisibleAndRemainTime.Item1);
		if (timeVisibleAndRemainTime.Item1)
		{
			this.TitleComponent.SetTimeTextByText(timeVisibleAndRemainTime.Item2);
		}
	}

	// Token: 0x06006634 RID: 26164 RVA: 0x001FFD94 File Offset: 0x001FDF94
	protected override void OnRefreshView()
	{
		base.OnRefreshView();
		int currentUseTrialRole = ((ActivityRegressData)this.ActivityBaseData).CurrentUseTrialRole;
		ActivityRegressRoleItem activityRegressRoleItemInternal = this.ActivityRegressRoleItemInternal;
		if (activityRegressRoleItemInternal != null)
		{
			activityRegressRoleItemInternal.RefreshItem(currentUseTrialRole);
		}
		Activity? localConfig = this.ActivityBaseData.LocalConfig;
		string descTheme = localConfig.Value.DescTheme;
		bool flag = !StringUtils.IsEmpty(descTheme);
		this.TitleComponent.SetSubTitleVisible(flag);
		if (flag)
		{
			this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
		}
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		this.TitleComponent.SetTimeTextVisible(timeVisibleAndRemainTime.Item1);
		if (timeVisibleAndRemainTime.Item1)
		{
			this.TitleComponent.SetTimeTextByText(timeVisibleAndRemainTime.Item2);
		}
		IRegressLevelProgressData curLevelProgressData = ActivityRegressModel.Instance.ActivityData.GetCurLevelProgressData();
		base.GetText(10).SetText("Lv." + curLevelProgressData.Level.ToString(), true);
		base.GetText(11).SetText("/" + curLevelProgressData.MaxLevel.ToString(), true);
		SignItem signItemInternal = this.SignItemInternal;
		if (signItemInternal != null)
		{
			signItemInternal.RefreshSignItem(ActivityRegressModel.Instance.Grade == ERegressGrade.Hyper, ActivityRegressModel.Instance.HasSignRewardCanClaimed());
		}
		this.OnRecallActivityInfoUpdate();
	}

	// Token: 0x06006635 RID: 26165 RVA: 0x001FFEFC File Offset: 0x001FE0FC
	protected override void OnStart()
	{
		base.OnStart();
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityRegressQuestionnaire, base.GetItem(16), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityRegressShopDiscount, base.GetItem(17), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityRecallSignEntry, base.GetItem(12), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityRegressDisposableReward, base.GetItem(15), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityRegressTrialRole, base.GetItem(14), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityRegressBp, base.GetItem(13), null, 0);
		RedDotController.Instance.BindRedDot(ERedDotName.ActivityRegressRewardBtn, base.GetItem(19), null, 0);
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(this.OnRecallActivityInfoUpdate));
	}

	// Token: 0x06006636 RID: 26166 RVA: 0x001FFFDA File Offset: 0x001FE1DA
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
	}

	// Token: 0x06006637 RID: 26167 RVA: 0x001FFFEC File Offset: 0x001FE1EC
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityRegressQuestionnaire, base.GetItem(16), 0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityRegressShopDiscount, base.GetItem(17), 0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityRecallSignEntry, base.GetItem(12), 0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityRegressDisposableReward, base.GetItem(15), 0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityRegressTrialRole, base.GetItem(14), 0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityRegressBp, base.GetItem(13), 0);
		RedDotController.Instance.UnBindGivenUi(ERedDotName.ActivityRegressRewardBtn, base.GetItem(19), 0);
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(this.OnRecallActivityInfoUpdate));
		if (this.RewardPopupInternal != null)
		{
			this.RewardPopupInternal = null;
		}
	}

	// Token: 0x06006638 RID: 26168 RVA: 0x002000D2 File Offset: 0x001FE2D2
	private void OnRecallActivityInfoUpdate()
	{
		base.GetItem(21).SetUIActive(ActivityRegressModel.Instance.DisposableReward);
	}

	// Token: 0x06006639 RID: 26169 RVA: 0x002000EC File Offset: 0x001FE2EC
	private void OnClickBattlePassBtn()
	{
		IActivityRegressMainViewOpenData activityRegressMainViewOpenData = new IActivityRegressMainViewOpenData
		{
			SubView = EActivityMainSubViewNewType.BattlePass,
			OpenType = EActivityRegressMainViewOpenDataType.Regress
		};
		ActivityRegressHelper.ReportRecallLog1023New(EReportLogEventNewType.BattlePass);
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressMainView, activityRegressMainViewOpenData, null);
	}

	// Token: 0x0600663A RID: 26170 RVA: 0x00200130 File Offset: 0x001FE330
	private void OnClickRoleBtnBtn()
	{
		ActivityRegressHelper.ReportRecallLog1023New(EReportLogEventNewType.TrialRole);
		ActivityRegressController.Instance.OpenTrialRoleView(null);
		ActivityRegressModel.Instance.ActivityData.SetTrialRoleRedDotChecked(true);
	}

	// Token: 0x0600663B RID: 26171 RVA: 0x00200168 File Offset: 0x001FE368
	private void OnClickSignBtnBtn()
	{
		IActivityRegressMainViewOpenData activityRegressMainViewOpenData = new IActivityRegressMainViewOpenData
		{
			SubView = EActivityMainSubViewNewType.Sign,
			OpenType = EActivityRegressMainViewOpenDataType.Regress
		};
		ActivityRegressHelper.ReportRecallLog1023New(EReportLogEventNewType.Sign);
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressMainView, activityRegressMainViewOpenData, null);
	}

	// Token: 0x0600663C RID: 26172 RVA: 0x002001AB File Offset: 0x001FE3AB
	private void OnClickNewVersionBtnBtn()
	{
		ActivityRegressHelper.ReportRecallLog1023New(EReportLogEventNewType.NewVersion);
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressNewVersionMainView, null, null);
	}

	// Token: 0x0600663D RID: 26173 RVA: 0x002001C4 File Offset: 0x001FE3C4
	private void OnClickCultivateBtnBtn()
	{
		IActivityRegressMainViewOpenData activityRegressMainViewOpenData = new IActivityRegressMainViewOpenData
		{
			SubView = EActivityMainSubViewNewType.Adventure,
			OpenType = EActivityRegressMainViewOpenDataType.Regress
		};
		ActivityRegressHelper.ReportRecallLog1023New(EReportLogEventNewType.Adventure);
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressMainView, activityRegressMainViewOpenData, null);
	}

	// Token: 0x0600663E RID: 26174 RVA: 0x00200207 File Offset: 0x001FE407
	private void OnClickStartUpBtnBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressStartupView, true, null);
	}

	// Token: 0x0600663F RID: 26175 RVA: 0x0020021F File Offset: 0x001FE41F
	private void OnClickQuestionnaireBtnBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressQuestionnaireView, null, null);
	}

	// Token: 0x06006640 RID: 26176 RVA: 0x00200232 File Offset: 0x001FE432
	private void OnClickShopBtnBtn()
	{
		SkipTaskManager.RunByConfigId(859201, null);
		ActivityRegressHelper.ReportRegressLog1060();
		ActivityRegressModel.Instance.ActivityData.SetShopRedDotChecked();
	}

	// Token: 0x06006641 RID: 26177 RVA: 0x00200254 File Offset: 0x001FE454
	private void OnClickRewardBtn()
	{
		ActivityRegressModel.Instance.ActivityData.SetRegressRewardBtnReached();
		ERegressGrade grade = ActivityRegressModel.Instance.Grade;
		List<ValueTuple<InventoryDefine.IGetItemData, int>> regressRewardList = this.GetRegressRewardList(grade);
		List<RegressRewardTuple> list = new List<RegressRewardTuple>();
		foreach (ValueTuple<InventoryDefine.IGetItemData, int> valueTuple in regressRewardList)
		{
			list.Add(new RegressRewardTuple
			{
				Id = valueTuple.Item1.ItemId,
				Num = valueTuple.Item2,
				Received = !ActivityRegressModel.Instance.ActivityData.CheckDisposableRewardRedDot()
			});
		}
		UUIItem mountItem = base.GetButton(18).RootUIComp.Get();
		RegressRewardPopupData data = new RegressRewardPopupData
		{
			RewardLists = list.ToArray(),
			MountItem = mountItem,
			PosBias = FVector.ZeroVector
		};
		this.RewardPopupInternal.Refresh(data);
	}

	// Token: 0x06006642 RID: 26178 RVA: 0x0020035C File Offset: 0x001FE55C
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public List<ValueTuple<InventoryDefine.IGetItemData, int>> GetRegressRewardList(ERegressGrade grade)
	{
		RegressDisposableReward? regressDisposableReward = ActivityRegressConfig.Instance.GetRegressDisposableReward(ActivityRegressModel.Instance.ActivityId);
		List<ValueTuple<InventoryDefine.IGetItemData, int>> list = new List<ValueTuple<InventoryDefine.IGetItemData, int>>();
		if (regressDisposableReward == null)
		{
			return list;
		}
		DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage((grade == ERegressGrade.Hyper) ? regressDisposableReward.Value.HighDropId : regressDisposableReward.Value.DropId);
		if (dropPackage == null)
		{
			return list;
		}
		foreach (DicIntInt dicIntInt in dropPackage.Value.DropPreviewIter())
		{
			list.Add(new ValueTuple<InventoryDefine.IGetItemData, int>(new InventoryDefine.GetItemData(dicIntInt.Key, 0), dicIntInt.Value));
		}
		return list;
	}

	// Token: 0x06006643 RID: 26179 RVA: 0x00200434 File Offset: 0x001FE634
	protected override void OnBeforeHide()
	{
		base.OnBeforeHide();
		UUIItem item = base.GetItem(21);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		RegressRewardPopup rewardPopupInternal = this.RewardPopupInternal;
		if (rewardPopupInternal == null)
		{
			return;
		}
		rewardPopupInternal.SetActive(false);
	}

	// Token: 0x04004196 RID: 16790
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04004197 RID: 16791
	private SignItem SignItemInternal;

	// Token: 0x04004198 RID: 16792
	private ActivityRegressRoleItem ActivityRegressRoleItemInternal;

	// Token: 0x04004199 RID: 16793
	private RegressRewardPopup RewardPopupInternal;

	// Token: 0x02006C03 RID: 27651
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023801 RID: 145409
		public const int TitleItem = 0;

		// Token: 0x04023802 RID: 145410
		public const int BattlePassBtn = 1;

		// Token: 0x04023803 RID: 145411
		public const int SignBtn = 2;

		// Token: 0x04023804 RID: 145412
		public const int CultivateBtn = 3;

		// Token: 0x04023805 RID: 145413
		public const int NewVersionBtn = 4;

		// Token: 0x04023806 RID: 145414
		public const int RoleBtn = 5;

		// Token: 0x04023807 RID: 145415
		public const int StartUpBtn = 6;

		// Token: 0x04023808 RID: 145416
		public const int QuestionnaireBtn = 7;

		// Token: 0x04023809 RID: 145417
		public const int ShopBtn = 8;

		// Token: 0x0402380A RID: 145418
		public const int RoleItem = 9;

		// Token: 0x0402380B RID: 145419
		public const int BpLevelText = 10;

		// Token: 0x0402380C RID: 145420
		public const int BpMaxText = 11;

		// Token: 0x0402380D RID: 145421
		public const int SignRedDotItem = 12;

		// Token: 0x0402380E RID: 145422
		public const int BpRedDotItem = 13;

		// Token: 0x0402380F RID: 145423
		public const int TrialRoleRedDotItem = 14;

		// Token: 0x04023810 RID: 145424
		public const int StartViewRedDotItem = 15;

		// Token: 0x04023811 RID: 145425
		public const int QuestionBtnRedDotRedDotItem = 16;

		// Token: 0x04023812 RID: 145426
		public const int ShopRedDotItem = 17;

		// Token: 0x04023813 RID: 145427
		public const int RewardBtn = 18;

		// Token: 0x04023814 RID: 145428
		public const int RewardBtnDotItem = 19;

		// Token: 0x04023815 RID: 145429
		public const int RewardPopup = 20;

		// Token: 0x04023816 RID: 145430
		public const int RewardBtnFinished = 21;
	}
}
