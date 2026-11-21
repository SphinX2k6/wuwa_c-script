using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001379 RID: 4985
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryActivityView : ActivitySubViewBase
{
	// Token: 0x1700130B RID: 4875
	// (get) Token: 0x0600C5EC RID: 50668 RVA: 0x003AF110 File Offset: 0x003AD310
	protected new HonamiStoryActivityData ActivityBaseData
	{
		get
		{
			return this.ActivityBaseData as HonamiStoryActivityData;
		}
	}

	// Token: 0x0600C5ED RID: 50669 RVA: 0x003AF120 File Offset: 0x003AD320
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600C5EE RID: 50670 RVA: 0x003AF230 File Offset: 0x003AD430
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryActivityView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryActivityView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C5EF RID: 50671 RVA: 0x003AF273 File Offset: 0x003AD473
	protected override void OnBeforeShow()
	{
		this.SwitchGenderItem();
	}

	// Token: 0x0600C5F0 RID: 50672 RVA: 0x003AF27C File Offset: 0x003AD47C
	protected override void OnRefreshView()
	{
		this.RefreshPermanentScore();
		this.RefreshCondition();
		this.CommonInfoPanel.SetFunctionRedDotVisible(this.ActivityBaseData.CheckAllFunctionRedDot());
		this.PermanentRewardBtn.SetRedDotVisible(this.ActivityBaseData.IsPermanentTaskHasRedDot());
		this.LimitRewardBtn.SetRedDotVisible(this.ActivityBaseData.IsLimitTaskHasRedDot());
	}

	// Token: 0x0600C5F1 RID: 50673 RVA: 0x003AF2D7 File Offset: 0x003AD4D7
	protected override void OnTimer(float _)
	{
		this.RefreshTimeText();
	}

	// Token: 0x0600C5F2 RID: 50674 RVA: 0x003AF2E0 File Offset: 0x003AD4E0
	private void RefreshTimeText()
	{
		bool uiactive = this.ActivityBaseData.CheckIfInLimitTime();
		base.GetItem(1).SetUIActive(uiactive);
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityBaseData.EndRewardTime, "{0}");
		ButtonItem limitRewardBtn = this.LimitRewardBtn;
		if (limitRewardBtn == null)
		{
			return;
		}
		limitRewardBtn.SetText(remainTimeText);
	}

	// Token: 0x0600C5F3 RID: 50675 RVA: 0x003AF334 File Offset: 0x003AD534
	private void SwitchGenderItem()
	{
		bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male;
		base.GetItem(5).SetUIActive(flag);
		base.GetItem(6).SetUIActive(!flag);
		base.GetSpine(3).SetAutoPlay(false);
		base.GetSpine(4).SetAutoPlay(false);
		if (flag)
		{
			base.GetSpine(3).SetAutoPlay(true);
			return;
		}
		base.GetSpine(4).SetAutoPlay(true);
	}

	// Token: 0x0600C5F4 RID: 50676 RVA: 0x003AF3A4 File Offset: 0x003AD5A4
	private void RefreshPermanentScore()
	{
		int count = this.ActivityBaseData.GetPermanentTaskIdsByState(EActivityTaskState.FinishedAndClaimed).Count;
		int permanentTaskTotalNum = this.ActivityBaseData.GetPermanentTaskTotalNum();
		this.PermanentRewardBtn.SetText(count.ToString() + "/" + permanentTaskTotalNum.ToString());
	}

	// Token: 0x0600C5F5 RID: 50677 RVA: 0x003AF3F4 File Offset: 0x003AD5F4
	private void RefreshCondition()
	{
		ActivityFunctionalTypeA functional = this.CommonInfoPanel.GetFunctional();
		ActivityFunctionAreaParams parameters = new ActivityFunctionAreaParams
		{
			UnlockBtnTextId = "LongShanStage_Join01",
			UnlockBtnFunction = new Action(this.OnConfirmBtnClick)
		};
		functional.RefreshGeneralPerformance(parameters);
	}

	// Token: 0x0600C5F6 RID: 50678 RVA: 0x003AF435 File Offset: 0x003AD635
	private void OnConfirmBtnClick()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			int markId = this.ActivityBaseData.MarkId;
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = new int?(markId),
				MarkType = EMarkType.SmallTeleport
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
		});
	}

	// Token: 0x0600C5F7 RID: 50679 RVA: 0x003AF453 File Offset: 0x003AD653
	private void OnLimitRewardBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryLimitTaskView, null, null);
	}

	// Token: 0x0600C5F8 RID: 50680 RVA: 0x003AF466 File Offset: 0x003AD666
	private void OnPermanentRewardBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryPermanentTaskView, null, null);
	}

	// Token: 0x040070A5 RID: 28837
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x040070A6 RID: 28838
	private ButtonItem LimitRewardBtn;

	// Token: 0x040070A7 RID: 28839
	private ButtonItem PermanentRewardBtn;

	// Token: 0x02007619 RID: 30233
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040265A4 RID: 157092
		CommonActionInfo,
		// Token: 0x040265A5 RID: 157093
		ItemLimitRewardBtn,
		// Token: 0x040265A6 RID: 157094
		ItemPermanentRewardBtn,
		// Token: 0x040265A7 RID: 157095
		MaleSpine,
		// Token: 0x040265A8 RID: 157096
		FemaleSpine,
		// Token: 0x040265A9 RID: 157097
		MaleItem,
		// Token: 0x040265AA RID: 157098
		FemaleItem
	}
}
