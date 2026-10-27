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

// Token: 0x02001650 RID: 5712
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerSubView : ActivitySubViewBase
{
	// Token: 0x0600A059 RID: 41049 RVA: 0x00235174 File Offset: 0x00233374
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A05A RID: 41050 RVA: 0x00235220 File Offset: 0x00233420
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A05B RID: 41051 RVA: 0x00235264 File Offset: 0x00233464
	protected override void OnStart()
	{
		WheelTowerSubViewGeneralInfo commonActivityInfo = this.CommonActivityInfo;
		if (commonActivityInfo != null)
		{
			commonActivityInfo.SetClickFunc(delegate(ActivityBaseData _)
			{
				this.OnClickEnter();
			});
		}
		WheelTowerSubViewGeneralInfo commonActivityInfo2 = this.CommonActivityInfo;
		if (commonActivityInfo2 != null)
		{
			commonActivityInfo2.SetBtnText("PrefabTextItem_3920397242_Text", Array.Empty<object>());
		}
		ActivityCircleButtonItem rewardButton = this.RewardButton;
		if (rewardButton != null)
		{
			rewardButton.SetOnClick(new Action(this.OnClickReward));
		}
		WheelTowerData wheelTowerData = this.ActivityBaseData as WheelTowerData;
		if (wheelTowerData != null)
		{
			wheelTowerData.ReadRedDot();
		}
		this.OnRefreshView();
	}

	// Token: 0x0600A05C RID: 41052 RVA: 0x002352E2 File Offset: 0x002334E2
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
	}

	// Token: 0x0600A05D RID: 41053 RVA: 0x00235300 File Offset: 0x00233500
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
	}

	// Token: 0x0600A05E RID: 41054 RVA: 0x00235320 File Offset: 0x00233520
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
		WheelTowerSubViewGeneralInfo commonActivityInfo = this.CommonActivityInfo;
		if (commonActivityInfo == null)
		{
			return;
		}
		commonActivityInfo.OnRefreshView();
	}

	// Token: 0x0600A05F RID: 41055 RVA: 0x0023537C File Offset: 0x0023357C
	protected override void OnTimer(float gap)
	{
		this.RefreshUnlockTimeText();
		this.CheckUpdateData();
	}

	// Token: 0x0600A060 RID: 41056 RVA: 0x0023538C File Offset: 0x0023358C
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

	// Token: 0x0600A061 RID: 41057 RVA: 0x002353D4 File Offset: 0x002335D4
	private bool ShouldUpdateData()
	{
		WheelTowerData wheelTowerData = this.ActivityBaseData as WheelTowerData;
		if (wheelTowerData == null || this.IsUpdatingData)
		{
			return false;
		}
		double cycleBeginTime = wheelTowerData.CycleBeginTime;
		double cycleEndTime = wheelTowerData.CycleEndTime;
		if (cycleBeginTime == -1.0 && cycleEndTime == -1.0)
		{
			return false;
		}
		if (TimeUtil.Instance.GetServerTime() > cycleEndTime)
		{
			return true;
		}
		bool flag = wheelTowerData.IsUnLock();
		bool flag2 = wheelTowerData.IsInCycleTime();
		bool flag3 = wheelTowerData.IsInCycle();
		return flag && flag2 && !flag3;
	}

	// Token: 0x0600A062 RID: 41058 RVA: 0x00235455 File Offset: 0x00233655
	private void CheckUpdateData()
	{
		if (!this.ShouldUpdateData())
		{
			return;
		}
		this.IsUpdatingData = true;
		ActivityController.Instance.RequestActivityData().ContinueWith((bool result) => this.IsUpdatingData = false);
	}

	// Token: 0x0600A063 RID: 41059 RVA: 0x00235484 File Offset: 0x00233684
	private UniTask CheckUpdateDataAsync()
	{
		WheelTowerSubView.<CheckUpdateDataAsync>d__15 <CheckUpdateDataAsync>d__;
		<CheckUpdateDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckUpdateDataAsync>d__.<>4__this = this;
		<CheckUpdateDataAsync>d__.<>1__state = -1;
		<CheckUpdateDataAsync>d__.<>t__builder.Start<WheelTowerSubView.<CheckUpdateDataAsync>d__15>(ref <CheckUpdateDataAsync>d__);
		return <CheckUpdateDataAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A064 RID: 41060 RVA: 0x002354C8 File Offset: 0x002336C8
	private void RefreshUnlockState()
	{
		ActivityCircleButtonItem rewardButton = this.RewardButton;
		if (rewardButton != null)
		{
			rewardButton.SetUiActive(false);
		}
		WheelTowerSubViewGeneralInfo commonActivityInfo = this.CommonActivityInfo;
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

	// Token: 0x0600A065 RID: 41061 RVA: 0x00235530 File Offset: 0x00233730
	private void RefreshUnlockTimeText()
	{
		WheelTowerData wheelTowerData = this.ActivityBaseData as WheelTowerData;
		if (wheelTowerData != null && wheelTowerData.IsInCycleTime())
		{
			WheelTowerSubViewGeneralInfo commonActivityInfo = this.CommonActivityInfo;
			if (commonActivityInfo == null)
			{
				return;
			}
			commonActivityInfo.RefreshFunction();
			return;
		}
		else
		{
			WheelTowerSubViewGeneralInfo commonActivityInfo2 = this.CommonActivityInfo;
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
				WheelTowerSubViewGeneralInfo commonActivityInfo3 = this.CommonActivityInfo;
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
				WheelTowerSubViewGeneralInfo commonActivityInfo4 = this.CommonActivityInfo;
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

	// Token: 0x0600A066 RID: 41062 RVA: 0x002355E8 File Offset: 0x002337E8
	private void RefreshRewardButton()
	{
		WheelTowerData wheelTowerData = this.ActivityBaseData as WheelTowerData;
		bool flag = wheelTowerData != null && wheelTowerData.IsUnLock();
		ActivityCircleButtonItem rewardButton = this.RewardButton;
		if (rewardButton != null)
		{
			rewardButton.SetUiActive(flag);
		}
		if (!flag || wheelTowerData == null)
		{
			return;
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
		if (rewardButton3 != null)
		{
			rewardButton3.SetRedDotVisible(wheelTowerData.ShouldShowRewardRedDot());
		}
		WheelTowerProgressBar normalProgress = this.NormalProgress;
		if (normalProgress != null)
		{
			normalProgress.Refresh(wheelTowerData.GetTotalScore(false));
		}
		WheelTowerProgressBar endlessProgress = this.EndlessProgress;
		if (endlessProgress == null)
		{
			return;
		}
		endlessProgress.Refresh(wheelTowerData.GetTotalScore(true));
	}

	// Token: 0x0600A067 RID: 41063 RVA: 0x002356B8 File Offset: 0x002338B8
	private void RefreshFunctionButton()
	{
		WheelTowerData wheelTowerData = this.ActivityBaseData as WheelTowerData;
		if (wheelTowerData == null)
		{
			return;
		}
		WheelTowerSubViewGeneralInfo commonActivityInfo = this.CommonActivityInfo;
		if (commonActivityInfo == null)
		{
			return;
		}
		commonActivityInfo.SetFunctionRedDotVisible(wheelTowerData.HasAnyLevelRedDot());
	}

	// Token: 0x0600A068 RID: 41064 RVA: 0x002356EB File Offset: 0x002338EB
	private void OnClickEnter()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (!WheelTowerModel.Instance.ActivityData.IsTowerUnlocked())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("WheelTower_TowerLocked", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.WheelTowerModeSelectView, null, null);
		});
	}

	// Token: 0x0600A069 RID: 41065 RVA: 0x0023571C File Offset: 0x0023391C
	private void OnClickReward()
	{
		UiManager.Instance.OpenView(EUiViewName.WheelTowerRewardView, null, delegate(bool success, int viewId)
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

	// Token: 0x0400492C RID: 18732
	private WheelTowerSubViewGeneralInfo CommonActivityInfo;

	// Token: 0x0400492D RID: 18733
	private ActivityCircleButtonItem RewardButton;

	// Token: 0x0400492E RID: 18734
	private WheelTowerProgressBar NormalProgress;

	// Token: 0x0400492F RID: 18735
	private WheelTowerProgressBar EndlessProgress;

	// Token: 0x04004930 RID: 18736
	private bool IsUpdatingData;
}
