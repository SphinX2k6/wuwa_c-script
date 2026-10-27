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

// Token: 0x02001448 RID: 5192
[NullableContext(2)]
[Nullable(0)]
public class ActivityRegress30MainView : ActivitySubViewBase
{
	// Token: 0x0600929B RID: 37531 RVA: 0x001F6D40 File Offset: 0x001F4F40
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

	// Token: 0x0600929C RID: 37532 RVA: 0x001F71A4 File Offset: 0x001F53A4
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegress30MainView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegress30MainView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600929D RID: 37533 RVA: 0x001F71E7 File Offset: 0x001F53E7
	protected override void OnTimer(float gap)
	{
		this.RefreshTitle();
	}

	// Token: 0x0600929E RID: 37534 RVA: 0x001F71F0 File Offset: 0x001F53F0
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

	// Token: 0x0600929F RID: 37535 RVA: 0x001F7258 File Offset: 0x001F5458
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

	// Token: 0x060092A0 RID: 37536 RVA: 0x001F73C0 File Offset: 0x001F55C0
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

	// Token: 0x060092A1 RID: 37537 RVA: 0x001F749E File Offset: 0x001F569E
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Emit(EEventName.RecallActivityInfoUpdate);
	}

	// Token: 0x060092A2 RID: 37538 RVA: 0x001F74B0 File Offset: 0x001F56B0
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

	// Token: 0x060092A3 RID: 37539 RVA: 0x001F7596 File Offset: 0x001F5796
	private void OnRecallActivityInfoUpdate()
	{
		base.GetItem(21).SetUIActive(ActivityRegressModel.Instance.DisposableReward);
	}

	// Token: 0x060092A4 RID: 37540 RVA: 0x001F75B0 File Offset: 0x001F57B0
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

	// Token: 0x060092A5 RID: 37541 RVA: 0x001F75F4 File Offset: 0x001F57F4
	private void OnClickRoleBtnBtn()
	{
		ActivityRegressHelper.ReportRecallLog1023New(EReportLogEventNewType.TrialRole);
		ActivityRegressController.Instance.OpenTrialRoleView(null);
		ActivityRegressModel.Instance.ActivityData.SetTrialRoleRedDotChecked(true);
	}

	// Token: 0x060092A6 RID: 37542 RVA: 0x001F762C File Offset: 0x001F582C
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

	// Token: 0x060092A7 RID: 37543 RVA: 0x001F766F File Offset: 0x001F586F
	private void OnClickNewVersionBtnBtn()
	{
		ActivityRegressHelper.ReportRecallLog1023New(EReportLogEventNewType.NewVersion);
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressNewVersionMainView, null, null);
	}

	// Token: 0x060092A8 RID: 37544 RVA: 0x001F7688 File Offset: 0x001F5888
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

	// Token: 0x060092A9 RID: 37545 RVA: 0x001F76CB File Offset: 0x001F58CB
	private void OnClickStartUpBtnBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressStartupView, true, null);
	}

	// Token: 0x060092AA RID: 37546 RVA: 0x001F76E3 File Offset: 0x001F58E3
	private void OnClickQuestionnaireBtnBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.ActivityRegressQuestionnaireView, null, null);
	}

	// Token: 0x060092AB RID: 37547 RVA: 0x001F76F6 File Offset: 0x001F58F6
	private void OnClickShopBtnBtn()
	{
		SkipTaskManager.RunByConfigId(859201, null);
		ActivityRegressHelper.ReportRegressLog1060();
		ActivityRegressModel.Instance.ActivityData.SetShopRedDotChecked();
	}

	// Token: 0x060092AC RID: 37548 RVA: 0x001F7718 File Offset: 0x001F5918
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

	// Token: 0x060092AD RID: 37549 RVA: 0x001F7820 File Offset: 0x001F5A20
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

	// Token: 0x060092AE RID: 37550 RVA: 0x001F78F8 File Offset: 0x001F5AF8
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

	// Token: 0x040040FE RID: 16638
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x040040FF RID: 16639
	private SignItem SignItemInternal;

	// Token: 0x04004100 RID: 16640
	private ActivityRegressRoleItem ActivityRegressRoleItemInternal;

	// Token: 0x04004101 RID: 16641
	private RegressRewardPopup RewardPopupInternal;

	// Token: 0x02007A7F RID: 31359
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040284E7 RID: 165095
		public const int TitleItem = 0;

		// Token: 0x040284E8 RID: 165096
		public const int BattlePassBtn = 1;

		// Token: 0x040284E9 RID: 165097
		public const int SignBtn = 2;

		// Token: 0x040284EA RID: 165098
		public const int CultivateBtn = 3;

		// Token: 0x040284EB RID: 165099
		public const int NewVersionBtn = 4;

		// Token: 0x040284EC RID: 165100
		public const int RoleBtn = 5;

		// Token: 0x040284ED RID: 165101
		public const int StartUpBtn = 6;

		// Token: 0x040284EE RID: 165102
		public const int QuestionnaireBtn = 7;

		// Token: 0x040284EF RID: 165103
		public const int ShopBtn = 8;

		// Token: 0x040284F0 RID: 165104
		public const int RoleItem = 9;

		// Token: 0x040284F1 RID: 165105
		public const int BpLevelText = 10;

		// Token: 0x040284F2 RID: 165106
		public const int BpMaxText = 11;

		// Token: 0x040284F3 RID: 165107
		public const int SignRedDotItem = 12;

		// Token: 0x040284F4 RID: 165108
		public const int BpRedDotItem = 13;

		// Token: 0x040284F5 RID: 165109
		public const int TrialRoleRedDotItem = 14;

		// Token: 0x040284F6 RID: 165110
		public const int StartViewRedDotItem = 15;

		// Token: 0x040284F7 RID: 165111
		public const int QuestionBtnRedDotRedDotItem = 16;

		// Token: 0x040284F8 RID: 165112
		public const int ShopRedDotItem = 17;

		// Token: 0x040284F9 RID: 165113
		public const int RewardBtn = 18;

		// Token: 0x040284FA RID: 165114
		public const int RewardBtnDotItem = 19;

		// Token: 0x040284FB RID: 165115
		public const int RewardPopup = 20;

		// Token: 0x040284FC RID: 165116
		public const int RewardBtnFinished = 21;
	}
}
