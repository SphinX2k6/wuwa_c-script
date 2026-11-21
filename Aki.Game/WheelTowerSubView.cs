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

// Token: 0x02000B08 RID: 2824
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerSubView : ActivitySubViewBase
{
	// Token: 0x06007437 RID: 29751 RVA: 0x0023EFB0 File Offset: 0x0023D1B0
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

	// Token: 0x06007438 RID: 29752 RVA: 0x0023F05C File Offset: 0x0023D25C
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007439 RID: 29753 RVA: 0x0023F0A0 File Offset: 0x0023D2A0
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

	// Token: 0x0600743A RID: 29754 RVA: 0x0023F11E File Offset: 0x0023D31E
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
	}

	// Token: 0x0600743B RID: 29755 RVA: 0x0023F13C File Offset: 0x0023D33C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
	}

	// Token: 0x0600743C RID: 29756 RVA: 0x0023F15C File Offset: 0x0023D35C
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

	// Token: 0x0600743D RID: 29757 RVA: 0x0023F1B8 File Offset: 0x0023D3B8
	protected override void OnTimer(float gap)
	{
		this.RefreshUnlockTimeText();
		this.CheckUpdateData();
	}

	// Token: 0x0600743E RID: 29758 RVA: 0x0023F1C8 File Offset: 0x0023D3C8
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

	// Token: 0x0600743F RID: 29759 RVA: 0x0023F210 File Offset: 0x0023D410
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

	// Token: 0x06007440 RID: 29760 RVA: 0x0023F291 File Offset: 0x0023D491
	private void CheckUpdateData()
	{
		if (!this.ShouldUpdateData())
		{
			return;
		}
		this.IsUpdatingData = true;
		ActivityController.Instance.RequestActivityData().ContinueWith((bool result) => this.IsUpdatingData = false);
	}

	// Token: 0x06007441 RID: 29761 RVA: 0x0023F2C0 File Offset: 0x0023D4C0
	private UniTask CheckUpdateDataAsync()
	{
		WheelTowerSubView.<CheckUpdateDataAsync>d__15 <CheckUpdateDataAsync>d__;
		<CheckUpdateDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckUpdateDataAsync>d__.<>4__this = this;
		<CheckUpdateDataAsync>d__.<>1__state = -1;
		<CheckUpdateDataAsync>d__.<>t__builder.Start<WheelTowerSubView.<CheckUpdateDataAsync>d__15>(ref <CheckUpdateDataAsync>d__);
		return <CheckUpdateDataAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007442 RID: 29762 RVA: 0x0023F304 File Offset: 0x0023D504
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

	// Token: 0x06007443 RID: 29763 RVA: 0x0023F36C File Offset: 0x0023D56C
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

	// Token: 0x06007444 RID: 29764 RVA: 0x0023F424 File Offset: 0x0023D624
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

	// Token: 0x06007445 RID: 29765 RVA: 0x0023F4F4 File Offset: 0x0023D6F4
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

	// Token: 0x06007446 RID: 29766 RVA: 0x0023F527 File Offset: 0x0023D727
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

	// Token: 0x06007447 RID: 29767 RVA: 0x0023F558 File Offset: 0x0023D758
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

	// Token: 0x040049D2 RID: 18898
	private WheelTowerSubViewGeneralInfo CommonActivityInfo;

	// Token: 0x040049D3 RID: 18899
	private ActivityCircleButtonItem RewardButton;

	// Token: 0x040049D4 RID: 18900
	private WheelTowerProgressBar NormalProgress;

	// Token: 0x040049D5 RID: 18901
	private WheelTowerProgressBar EndlessProgress;

	// Token: 0x040049D6 RID: 18902
	private bool IsUpdatingData;
}
