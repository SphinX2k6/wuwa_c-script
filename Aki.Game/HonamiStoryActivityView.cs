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

// Token: 0x02001EB7 RID: 7863
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryActivityView : ActivitySubViewBase
{
	// Token: 0x170012E1 RID: 4833
	// (get) Token: 0x0600F1CD RID: 61901 RVA: 0x003A3610 File Offset: 0x003A1810
	protected new HonamiStoryActivityData ActivityBaseData
	{
		get
		{
			return this.ActivityBaseData as HonamiStoryActivityData;
		}
	}

	// Token: 0x0600F1CE RID: 61902 RVA: 0x003A3620 File Offset: 0x003A1820
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

	// Token: 0x0600F1CF RID: 61903 RVA: 0x003A3730 File Offset: 0x003A1930
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryActivityView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryActivityView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F1D0 RID: 61904 RVA: 0x003A3773 File Offset: 0x003A1973
	protected override void OnBeforeShow()
	{
		this.SwitchGenderItem();
	}

	// Token: 0x0600F1D1 RID: 61905 RVA: 0x003A377C File Offset: 0x003A197C
	protected override void OnRefreshView()
	{
		this.RefreshPermanentScore();
		this.RefreshCondition();
		this.CommonInfoPanel.SetFunctionRedDotVisible(this.ActivityBaseData.CheckAllFunctionRedDot());
		this.PermanentRewardBtn.SetRedDotVisible(this.ActivityBaseData.IsPermanentTaskHasRedDot());
		this.LimitRewardBtn.SetRedDotVisible(this.ActivityBaseData.IsLimitTaskHasRedDot());
	}

	// Token: 0x0600F1D2 RID: 61906 RVA: 0x003A37D7 File Offset: 0x003A19D7
	protected override void OnTimer(float _)
	{
		this.RefreshTimeText();
	}

	// Token: 0x0600F1D3 RID: 61907 RVA: 0x003A37E0 File Offset: 0x003A19E0
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

	// Token: 0x0600F1D4 RID: 61908 RVA: 0x003A3834 File Offset: 0x003A1A34
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

	// Token: 0x0600F1D5 RID: 61909 RVA: 0x003A38A4 File Offset: 0x003A1AA4
	private void RefreshPermanentScore()
	{
		int count = this.ActivityBaseData.GetPermanentTaskIdsByState(EActivityTaskState.FinishedAndClaimed).Count;
		int permanentTaskTotalNum = this.ActivityBaseData.GetPermanentTaskTotalNum();
		this.PermanentRewardBtn.SetText(count.ToString() + "/" + permanentTaskTotalNum.ToString());
	}

	// Token: 0x0600F1D6 RID: 61910 RVA: 0x003A38F4 File Offset: 0x003A1AF4
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

	// Token: 0x0600F1D7 RID: 61911 RVA: 0x003A3935 File Offset: 0x003A1B35
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

	// Token: 0x0600F1D8 RID: 61912 RVA: 0x003A3953 File Offset: 0x003A1B53
	private void OnLimitRewardBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryLimitTaskView, null, null);
	}

	// Token: 0x0600F1D9 RID: 61913 RVA: 0x003A3966 File Offset: 0x003A1B66
	private void OnPermanentRewardBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryPermanentTaskView, null, null);
	}

	// Token: 0x04006FC4 RID: 28612
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x04006FC5 RID: 28613
	private ButtonItem LimitRewardBtn;

	// Token: 0x04006FC6 RID: 28614
	private ButtonItem PermanentRewardBtn;

	// Token: 0x02008494 RID: 33940
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B280 RID: 176768
		CommonActionInfo,
		// Token: 0x0402B281 RID: 176769
		ItemLimitRewardBtn,
		// Token: 0x0402B282 RID: 176770
		ItemPermanentRewardBtn,
		// Token: 0x0402B283 RID: 176771
		MaleSpine,
		// Token: 0x0402B284 RID: 176772
		FemaleSpine,
		// Token: 0x0402B285 RID: 176773
		MaleItem,
		// Token: 0x0402B286 RID: 176774
		FemaleItem
	}
}
