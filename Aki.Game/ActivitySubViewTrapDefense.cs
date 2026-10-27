using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200152E RID: 5422
[NullableContext(1)]
[Nullable(0)]
public class ActivitySubViewTrapDefense : ActivitySubViewBase
{
	// Token: 0x17000D4C RID: 3404
	// (get) Token: 0x06009AA2 RID: 39586 RVA: 0x00217356 File Offset: 0x00215556
	// (set) Token: 0x06009AA3 RID: 39587 RVA: 0x00217363 File Offset: 0x00215563
	protected new ActivityTrapDefenseData ActivityBaseData
	{
		get
		{
			return this.ActivityBaseData as ActivityTrapDefenseData;
		}
		set
		{
			this.ActivityBaseData = value;
		}
	}

	// Token: 0x06009AA4 RID: 39588 RVA: 0x0021736C File Offset: 0x0021556C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(USpineSkeletonAnimationComponent))
		};
	}

	// Token: 0x06009AA5 RID: 39589 RVA: 0x00217408 File Offset: 0x00215608
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewTrapDefense.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewTrapDefense.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009AA6 RID: 39590 RVA: 0x0021744C File Offset: 0x0021564C
	protected override void OnAddEventListener()
	{
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			ActivityFunctionalTypeA functional = commonInfoPanel.GetFunctional();
			if (functional != null)
			{
				ActivityButtonItem functionButton = functional.FunctionButton;
				if (functionButton != null)
				{
					functionButton.BindRedDot(ERedDotName.TrapDefense, 0);
				}
			}
		}
		this.FixedRewardItem.BindRedDot(ERedDotName.TrapDefenseFixedReward, 0);
		this.LimitRewardItem.BindRedDot(ERedDotName.TrapDefenseLimitReward, 0);
	}

	// Token: 0x06009AA7 RID: 39591 RVA: 0x002174A8 File Offset: 0x002156A8
	protected override void OnRemoveEventListener()
	{
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			ActivityFunctionalTypeA functional = commonInfoPanel.GetFunctional();
			if (functional != null)
			{
				ActivityButtonItem functionButton = functional.FunctionButton;
				if (functionButton != null)
				{
					functionButton.UnBindGivenUid(0);
				}
			}
		}
		this.FixedRewardItem.UnBindGivenUid(0);
		this.LimitRewardItem.UnBindGivenUid(0);
	}

	// Token: 0x06009AA8 RID: 39592 RVA: 0x002174F5 File Offset: 0x002156F5
	protected override void OnRefreshView()
	{
		this.UpdateFixedReward();
		this.UpdateLimitReward();
		this.UpdateRougeModeTips();
	}

	// Token: 0x06009AA9 RID: 39593 RVA: 0x00217509 File Offset: 0x00215709
	[NullableContext(2)]
	private void ClickCommonInfo(ActivityBaseData _)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			TrapDefenseModel instance = TrapDefenseModel.Instance;
			if (instance != null)
			{
				instance.OpenMainEntryView();
			}
			TrapDefenseModel instance2 = TrapDefenseModel.Instance;
			if (instance2 != null && instance2.RougeModeData.CheckModeOpenSubState())
			{
				this.UpdateRougeModeTips();
			}
		});
	}

	// Token: 0x06009AAA RID: 39594 RVA: 0x00217527 File Offset: 0x00215727
	public void OnClickBtnFixedReward()
	{
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.OpenViewFixedReward();
	}

	// Token: 0x06009AAB RID: 39595 RVA: 0x00217538 File Offset: 0x00215738
	public void OnClickBtnLimitReward()
	{
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.OpenViewLimitReward();
	}

	// Token: 0x06009AAC RID: 39596 RVA: 0x0021754C File Offset: 0x0021574C
	public void UpdateFixedReward()
	{
		ValueTuple<int, int> fixedRewardTotalProgress = TrapDefenseModel.Instance.RewardData.GetFixedRewardTotalProgress();
		int item = fixedRewardTotalProgress.Item1;
		int item2 = fixedRewardTotalProgress.Item2;
		this.FixedRewardItem.GetProgressText().SetText(item.ToString() + "/" + item2.ToString(), true);
	}

	// Token: 0x06009AAD RID: 39597 RVA: 0x002175A0 File Offset: 0x002157A0
	public void UpdateLimitReward()
	{
		TrapDefenseRewardData rewardData = TrapDefenseModel.Instance.RewardData;
		bool flag = rewardData.IsOpenLimitReward();
		this.LimitRewardItem.SetActive(flag);
		if (flag)
		{
			ValueTuple<int, int> limitRewardTotalProgress = rewardData.GetLimitRewardTotalProgress();
			int item = limitRewardTotalProgress.Item1;
			int item2 = limitRewardTotalProgress.Item2;
			this.LimitRewardItem.GetProgressText().SetText(item.ToString() + "/" + item2.ToString(), true);
			this.UpdateLimitRewardDownTime();
		}
	}

	// Token: 0x06009AAE RID: 39598 RVA: 0x00217610 File Offset: 0x00215810
	public void UpdateLimitRewardDownTime()
	{
		UUIText text = base.GetText(1);
		TrapDefenseRewardData rewardData = TrapDefenseModel.Instance.RewardData;
		bool flag = rewardData.IsOpenLimitReward();
		text.SetUIActive(flag);
		if (flag)
		{
			string limitRewardRemainTimeStr = rewardData.GetLimitRewardRemainTimeStr();
			text.SetText(limitRewardRemainTimeStr, true);
		}
	}

	// Token: 0x06009AAF RID: 39599 RVA: 0x00217650 File Offset: 0x00215850
	protected override void OnTimer(float gap)
	{
		this.UpdateLimitRewardDownTime();
	}

	// Token: 0x06009AB0 RID: 39600 RVA: 0x00217658 File Offset: 0x00215858
	public UniTask UpdateSpine()
	{
		ActivitySubViewTrapDefense.<UpdateSpine>d__20 <UpdateSpine>d__;
		<UpdateSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateSpine>d__.<>4__this = this;
		<UpdateSpine>d__.<>1__state = -1;
		<UpdateSpine>d__.<>t__builder.Start<ActivitySubViewTrapDefense.<UpdateSpine>d__20>(ref <UpdateSpine>d__);
		return <UpdateSpine>d__.<>t__builder.Task;
	}

	// Token: 0x06009AB1 RID: 39601 RVA: 0x0021769C File Offset: 0x0021589C
	public void UpdateRougeModeTips()
	{
		bool active = TrapDefenseModel.Instance.RougeModeData.IsShowRougeModeTipsToActivity();
		this.PanelRougeModeTips.SetActive(active);
	}

	// Token: 0x0400440B RID: 17419
	[Nullable(2)]
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x0400440C RID: 17420
	public ActivityTrapDefenseRewardBtn FixedRewardItem;

	// Token: 0x0400440D RID: 17421
	public ActivityTrapDefenseRewardBtn LimitRewardItem;

	// Token: 0x0400440E RID: 17422
	public RecommendQuestTipsSubPanel PanelRougeModeTips;

	// Token: 0x02007B55 RID: 31573
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040288E5 RID: 166117
		public const int ItemCommonPanel = 0;

		// Token: 0x040288E6 RID: 166118
		public const int TextDownTime = 1;

		// Token: 0x040288E7 RID: 166119
		public const int ItemFixedReward = 2;

		// Token: 0x040288E8 RID: 166120
		public const int ItemLimitReward = 3;

		// Token: 0x040288E9 RID: 166121
		public const int ItemRougeModeOpenTips = 4;

		// Token: 0x040288EA RID: 166122
		public const int SpineMainRole = 5;
	}
}
