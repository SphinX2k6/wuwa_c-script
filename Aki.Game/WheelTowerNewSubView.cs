using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000ADA RID: 2778
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerNewSubView : ActivitySubViewBase
{
	// Token: 0x0600734E RID: 29518 RVA: 0x00239804 File Offset: 0x00237A04
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600734F RID: 29519 RVA: 0x00239978 File Offset: 0x00237B78
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerNewSubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerNewSubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007350 RID: 29520 RVA: 0x002399BC File Offset: 0x00237BBC
	protected override void OnStart()
	{
		WheelTowerNewSubViewGeneralInfo commonActivityInfo = this.CommonActivityInfo;
		if (commonActivityInfo != null)
		{
			commonActivityInfo.SetClickFunc(delegate(ActivityBaseData _)
			{
				this.OnClickEnter();
			});
		}
		WheelTowerNewSubViewGeneralInfo commonActivityInfo2 = this.CommonActivityInfo;
		if (commonActivityInfo2 != null)
		{
			commonActivityInfo2.SetBtnText("PrefabTextItem_3920397242_Text", Array.Empty<object>());
		}
		ActivityCircleButtonItem rewardButton = this.RewardButton;
		if (rewardButton != null)
		{
			rewardButton.SetOnClick(new Action(this.OnClickReward));
		}
		ActivityCircleButtonItem seasonRewardButton = this.SeasonRewardButton;
		if (seasonRewardButton != null)
		{
			seasonRewardButton.SetOnClick(new Action(this.OnClickSeasonReward));
		}
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		UUIText text2 = base.GetText(9);
		if (text2 != null)
		{
			text2.SetUIActive(false);
		}
		this.OnRefreshView();
	}

	// Token: 0x06007351 RID: 29521 RVA: 0x00239A68 File Offset: 0x00237C68
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
	}

	// Token: 0x06007352 RID: 29522 RVA: 0x00239A86 File Offset: 0x00237C86
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
	}

	// Token: 0x06007353 RID: 29523 RVA: 0x00239AA4 File Offset: 0x00237CA4
	protected override void OnRefreshView()
	{
		WheelTowerData wheelTowerData = this.ActivityBaseData as WheelTowerData;
		bool flag = wheelTowerData != null && wheelTowerData.IsUnLock();
		bool flag2 = wheelTowerData != null && wheelTowerData.IsInCycle();
		if (!flag || !flag2)
		{
			this.RefreshUnlockState();
			return;
		}
		this.RefreshRewardButton();
		this.RefreshFunctionButton();
		this.RefreshScorePanel();
		WheelTowerNewSubViewGeneralInfo commonActivityInfo = this.CommonActivityInfo;
		if (commonActivityInfo == null)
		{
			return;
		}
		commonActivityInfo.OnRefreshView();
	}

	// Token: 0x06007354 RID: 29524 RVA: 0x00239B06 File Offset: 0x00237D06
	protected override void OnTimer(float gap)
	{
		this.RefreshUnlockTimeText();
		this.CheckUpdateData();
	}

	// Token: 0x06007355 RID: 29525 RVA: 0x00239B14 File Offset: 0x00237D14
	private void OnRedDotRefresh(int activityId)
	{
		ActivityBaseData activityBaseData = this.ActivityBaseData;
		int? num = (activityBaseData != null) ? new int?(activityBaseData.Id) : null;
		if (!(activityId == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		this.OnRefreshView();
	}

	// Token: 0x06007356 RID: 29526 RVA: 0x00239B5C File Offset: 0x00237D5C
	private bool ShouldUpdateData()
	{
		WheelTowerData wheelTowerData = this.ActivityBaseData as WheelTowerData;
		if (wheelTowerData == null || this.IsUpdatingData)
		{
			return false;
		}
		double cycleBeginTime = wheelTowerData.CycleBeginTime;
		double cycleEndTime = wheelTowerData.CycleEndTime;
		return (cycleBeginTime != -1.0 || cycleEndTime != -1.0) && (TimeUtil.Instance.GetServerTime() > cycleEndTime || (wheelTowerData.IsUnLock() && wheelTowerData.IsInCycleTime() && !wheelTowerData.IsInCycle()));
	}

	// Token: 0x06007357 RID: 29527 RVA: 0x00239BD2 File Offset: 0x00237DD2
	private void CheckUpdateData()
	{
		if (!this.ShouldUpdateData())
		{
			return;
		}
		this.IsUpdatingData = true;
		ActivityController.Instance.RequestActivityData().ContinueWith((bool result) => this.IsUpdatingData = false);
	}

	// Token: 0x06007358 RID: 29528 RVA: 0x00239C00 File Offset: 0x00237E00
	private UniTask CheckUpdateDataAsync()
	{
		WheelTowerNewSubView.<CheckUpdateDataAsync>d__14 <CheckUpdateDataAsync>d__;
		<CheckUpdateDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckUpdateDataAsync>d__.<>4__this = this;
		<CheckUpdateDataAsync>d__.<>1__state = -1;
		<CheckUpdateDataAsync>d__.<>t__builder.Start<WheelTowerNewSubView.<CheckUpdateDataAsync>d__14>(ref <CheckUpdateDataAsync>d__);
		return <CheckUpdateDataAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007359 RID: 29529 RVA: 0x00239C44 File Offset: 0x00237E44
	private void RefreshUnlockState()
	{
		ActivityCircleButtonItem seasonRewardButton = this.SeasonRewardButton;
		if (seasonRewardButton != null)
		{
			seasonRewardButton.SetUiActive(false);
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(5);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(7);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		WheelTowerNewSubViewGeneralInfo commonActivityInfo = this.CommonActivityInfo;
		ActivityFunctionalTypeA activityFunctionalTypeA = (commonActivityInfo != null) ? commonActivityInfo.GetFunctional() : null;
		if (activityFunctionalTypeA != null)
		{
			ActivityButtonItem functionButton = activityFunctionalTypeA.FunctionButton;
			if (functionButton != null)
			{
				functionButton.SetUiActive(false);
			}
		}
		if (activityFunctionalTypeA != null)
		{
			FunctionalPanelConditionLock panelLock = activityFunctionalTypeA.PanelLock;
			if (panelLock != null)
			{
				panelLock.SetUiActive(true);
			}
		}
		this.RefreshUnlockTimeText();
	}

	// Token: 0x0600735A RID: 29530 RVA: 0x00239CE4 File Offset: 0x00237EE4
	private void RefreshUnlockTimeText()
	{
		WheelTowerData wheelTowerData = this.ActivityBaseData as WheelTowerData;
		if (wheelTowerData != null && wheelTowerData.IsInCycleTime())
		{
			WheelTowerNewSubViewGeneralInfo commonActivityInfo = this.CommonActivityInfo;
			if (commonActivityInfo == null)
			{
				return;
			}
			commonActivityInfo.RefreshFunction();
			return;
		}
		else
		{
			WheelTowerNewSubViewGeneralInfo commonActivityInfo2 = this.CommonActivityInfo;
			if (commonActivityInfo2 != null)
			{
				ActivityFunctionalTypeA functional = commonActivityInfo2.GetFunctional();
				if (functional != null)
				{
					functional.SetLockConditionButtonVisible(false);
				}
			}
			string nextCycleRemainTime = WheelTowerModel.Instance.GetNextCycleRemainTime();
			if (string.IsNullOrEmpty(nextCycleRemainTime))
			{
				WheelTowerNewSubViewGeneralInfo commonActivityInfo3 = this.CommonActivityInfo;
				if (commonActivityInfo3 == null)
				{
					return;
				}
				ActivityFunctionalTypeA functional2 = commonActivityInfo3.GetFunctional();
				if (functional2 == null)
				{
					return;
				}
				functional2.SetLockTextByTextId("WheelTower_NonCycle", Array.Empty<string>());
				return;
			}
			else
			{
				WheelTowerNewSubViewGeneralInfo commonActivityInfo4 = this.CommonActivityInfo;
				if (commonActivityInfo4 == null)
				{
					return;
				}
				ActivityFunctionalTypeA functional3 = commonActivityInfo4.GetFunctional();
				if (functional3 == null)
				{
					return;
				}
				functional3.SetLockTextByTextId("WheelTower_TimeLimit", new string[]
				{
					nextCycleRemainTime
				});
				return;
			}
		}
	}

	// Token: 0x0600735B RID: 29531 RVA: 0x00239D9C File Offset: 0x00237F9C
	private void RefreshRewardButton()
	{
		WheelTowerData wheelTowerData = this.ActivityBaseData as WheelTowerData;
		bool flag = wheelTowerData != null && wheelTowerData.IsUnLock();
		ActivityCircleButtonItem rewardButton = this.RewardButton;
		if (rewardButton != null)
		{
			rewardButton.SetUiActive(flag);
		}
		ActivityCircleButtonItem seasonRewardButton = this.SeasonRewardButton;
		if (seasonRewardButton != null)
		{
			seasonRewardButton.SetUiActive(flag);
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (!flag || wheelTowerData == null)
		{
			return;
		}
		ActivityCircleButtonItem seasonRewardButton2 = this.SeasonRewardButton;
		if (seasonRewardButton2 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(wheelTowerData.GetReceivedSeasonRewardIds().Count);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(wheelTowerData.GetSeasonTaskList().Count);
			seasonRewardButton2.SetSubText(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		ActivityCircleButtonItem seasonRewardButton3 = this.SeasonRewardButton;
		if (seasonRewardButton3 != null)
		{
			seasonRewardButton3.SetRedDotVisible(wheelTowerData.ShouldShowSeasonRewardRedDot());
		}
		ActivityCircleButtonItem rewardButton2 = this.RewardButton;
		if (rewardButton2 != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(wheelTowerData.GetCurrentRewardProgress(EFilterMode.All));
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(wheelTowerData.GetTotalRewardProgress(EFilterMode.All));
			rewardButton2.SetSubText(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		ActivityCircleButtonItem rewardButton3 = this.RewardButton;
		if (rewardButton3 == null)
		{
			return;
		}
		rewardButton3.SetRedDotVisible(wheelTowerData.ShouldShowRewardRedDot());
	}

	// Token: 0x0600735C RID: 29532 RVA: 0x00239EC8 File Offset: 0x002380C8
	private void RefreshFunctionButton()
	{
		WheelTowerData wheelTowerData = this.ActivityBaseData as WheelTowerData;
		if (wheelTowerData == null)
		{
			return;
		}
		bool functionRedDotVisible = wheelTowerData.CheckFirstOpenPage() || WheelTowerModel.Instance.HasUnreadSeasonMedalRedDot(wheelTowerData.SeasonId);
		WheelTowerNewSubViewGeneralInfo commonActivityInfo = this.CommonActivityInfo;
		if (commonActivityInfo == null)
		{
			return;
		}
		commonActivityInfo.SetFunctionRedDotVisible(functionRedDotVisible);
	}

	// Token: 0x0600735D RID: 29533 RVA: 0x00239F14 File Offset: 0x00238114
	private void RefreshScorePanel()
	{
		WheelTowerData wheelTowerData = this.ActivityBaseData as WheelTowerData;
		if (wheelTowerData == null)
		{
			return;
		}
		bool flag = wheelTowerData.IsLevelUnlocked(true);
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUIItem item2 = base.GetItem(7);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		int totalScore = wheelTowerData.GetTotalScore(flag);
		UUIText text = base.GetText(6);
		if (text != null)
		{
			text.SetText(totalScore.ToString(), true);
		}
		UUIText text2 = base.GetText(8);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(totalScore.ToString(), true);
	}

	// Token: 0x0600735E RID: 29534 RVA: 0x00239F9D File Offset: 0x0023819D
	private void OnClickEnter()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (!WheelTowerModel.Instance.ActivityData.IsTowerUnlocked())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("WheelTower_TowerLocked", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.WheelTowerMainView, null, null);
		});
	}

	// Token: 0x0600735F RID: 29535 RVA: 0x00239FCE File Offset: 0x002381CE
	private void OnClickSeasonReward()
	{
		UiManager.Instance.OpenView(EUiViewName.WheelTowerSeasonRewardView, null, delegate(bool success, int viewId)
		{
			if (success)
			{
				UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.CommonActivityView);
				if (viewByName == null)
				{
					return;
				}
				viewByName.AddChildViewById(viewId);
			}
		});
	}

	// Token: 0x06007360 RID: 29536 RVA: 0x00239FFF File Offset: 0x002381FF
	private void OnClickReward()
	{
		UiManager.Instance.OpenView(EUiViewName.WheelTowerLimitRewardView, null, delegate(bool success, int viewId)
		{
			if (success)
			{
				UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.CommonActivityView);
				if (viewByName == null)
				{
					return;
				}
				viewByName.AddChildViewById(viewId);
			}
		});
	}

	// Token: 0x040048B6 RID: 18614
	private WheelTowerNewSubViewGeneralInfo CommonActivityInfo;

	// Token: 0x040048B7 RID: 18615
	private ActivityCircleButtonItem SeasonRewardButton;

	// Token: 0x040048B8 RID: 18616
	private ActivityCircleButtonItem RewardButton;

	// Token: 0x040048B9 RID: 18617
	private bool IsUpdatingData;
}
