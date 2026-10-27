using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A5D RID: 6749
[NullableContext(2)]
[Nullable(0)]
public class DangoAbyssSubView : ActivitySubViewBase
{
	// Token: 0x0600C6B3 RID: 50867 RVA: 0x002D3554 File Offset: 0x002D1754
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
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(USpineSkeletonAnimationComponent))
		};
	}

	// Token: 0x0600C6B4 RID: 50868 RVA: 0x002D3660 File Offset: 0x002D1860
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssSubView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssSubView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C6B5 RID: 50869 RVA: 0x002D36A3 File Offset: 0x002D18A3
	protected override void OnStart()
	{
		this.DangoAbyssActivityData = (this.ActivityBaseData as DangoAbyssActivityData);
	}

	// Token: 0x0600C6B6 RID: 50870 RVA: 0x002D36B6 File Offset: 0x002D18B6
	protected override void OnBeforeShow()
	{
		this.BindRedDot();
		base.GetSpine(10).SetAnimation(0, "start", false).AnimationComplete.Add(delegate(UTrackEntry _)
		{
			base.GetSpine(10).SetAnimation(0, "idle", true);
		});
	}

	// Token: 0x0600C6B7 RID: 50871 RVA: 0x002D36E8 File Offset: 0x002D18E8
	protected override void OnBeforeHide()
	{
		this.RemoveRedDot();
		base.GetSpine(10).ClearTracks();
	}

	// Token: 0x0600C6B8 RID: 50872 RVA: 0x002D3700 File Offset: 0x002D1900
	private void BindRedDot()
	{
		ActivityButtonItem limitRewardBtn = this.LimitRewardBtn;
		if (limitRewardBtn != null)
		{
			limitRewardBtn.BindRedDot(ERedDotName.RedDotDangoLimitReward, this.ActivityBaseData.Id);
		}
		ActivityButtonItem rewardBtn = this.RewardBtn;
		if (rewardBtn == null)
		{
			return;
		}
		rewardBtn.BindRedDot(ERedDotName.RedDotDangoCommonReward, this.ActivityBaseData.Id);
	}

	// Token: 0x0600C6B9 RID: 50873 RVA: 0x002D374E File Offset: 0x002D194E
	private void RemoveRedDot()
	{
		ActivityButtonItem limitRewardBtn = this.LimitRewardBtn;
		if (limitRewardBtn != null)
		{
			limitRewardBtn.UnBindGivenUid(this.ActivityBaseData.Id);
		}
		ActivityButtonItem rewardBtn = this.RewardBtn;
		if (rewardBtn == null)
		{
			return;
		}
		rewardBtn.UnBindGivenUid(this.ActivityBaseData.Id);
	}

	// Token: 0x0600C6BA RID: 50874 RVA: 0x002D3788 File Offset: 0x002D1988
	protected override void OnRefreshView()
	{
		Activity? localConfig = this.ActivityBaseData.LocalConfig;
		if (localConfig == null)
		{
			return;
		}
		this.RefreshDesc();
		this.RefreshTitle();
		this.RefreshReward();
		this.RefreshFunctionalComponent();
		this.RefreshState();
		this.RefreshProgressText();
	}

	// Token: 0x0600C6BB RID: 50875 RVA: 0x002D37D0 File Offset: 0x002D19D0
	private void RefreshProgressText()
	{
		bool flag = this.DangoAbyssActivityData.CheckInLimitTime();
		ActivityButtonItem limitRewardBtn = this.LimitRewardBtn;
		if (limitRewardBtn != null)
		{
			limitRewardBtn.SetActive(flag);
		}
		if (flag)
		{
			string remainTimeText = this.DangoAbyssActivityData.GetRemainTimeText();
			ActivityButtonItem limitRewardBtn2 = this.LimitRewardBtn;
			if (limitRewardBtn2 != null)
			{
				limitRewardBtn2.SetText(remainTimeText);
			}
		}
		string rewardFinishProgressText = this.DangoAbyssActivityData.GetRewardFinishProgressText();
		this.RewardBtn.SetText(rewardFinishProgressText);
	}

	// Token: 0x0600C6BC RID: 50876 RVA: 0x002D3834 File Offset: 0x002D1A34
	private void RefreshDesc()
	{
		Activity value = this.ActivityBaseData.LocalConfig.Value;
		string descTheme = value.DescTheme;
		string desc = value.Desc;
		bool flag = !StringUtils.IsEmpty(descTheme);
		this.TitleComponent.SetSubTitleVisible(flag);
		if (flag)
		{
			this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
		}
		this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
		string descThemeIcon = value.DescThemeIcon;
		if (!string.IsNullOrEmpty(descThemeIcon))
		{
			ActivityTitleTypeA titleComponent = this.TitleComponent;
			if (titleComponent == null)
			{
				return;
			}
			titleComponent.SetSubTitleIconByPath(descThemeIcon, null);
		}
	}

	// Token: 0x0600C6BD RID: 50877 RVA: 0x002D38C4 File Offset: 0x002D1AC4
	private void RefreshTitle()
	{
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.TitleComponent.SetTimeTextVisible(item);
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
	}

	// Token: 0x0600C6BE RID: 50878 RVA: 0x002D393C File Offset: 0x002D1B3C
	private void RefreshReward()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.SetTitleByTextId("BossRushCollectReward");
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
	}

	// Token: 0x0600C6BF RID: 50879 RVA: 0x002D397C File Offset: 0x002D1B7C
	private void RefreshState()
	{
		bool flag = this.ActivityBaseData.IsUnLock();
		this.FunctionalComponent.SetPanelConditionVisible(!flag);
		if (!flag)
		{
			this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
		}
		this.FunctionalComponent.FunctionButton.SetUiActive(flag);
	}

	// Token: 0x0600C6C0 RID: 50880 RVA: 0x002D39DC File Offset: 0x002D1BDC
	private void RefreshFunctionalComponent()
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("DangoAbyssEnterText", null);
		this.FunctionalComponent.FunctionButton.SetText(localTextNew);
		bool redDotVisible = this.ActivityBaseData.IsUnLock() && DangoAbyssModel.Instance.GetAbyssDangoEnterNew();
		this.FunctionalComponent.FunctionButton.SetRedDotVisible(redDotVisible);
	}

	// Token: 0x0600C6C1 RID: 50881 RVA: 0x002D3A32 File Offset: 0x002D1C32
	private void FunctionExecute()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			DangoAbyssModel.Instance.SetAbyssDangoEnterNew(false);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
			if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			DangoAbyssController.Instance.OpenCurrentActivityAbyssEntrance();
		});
	}

	// Token: 0x0600C6C2 RID: 50882 RVA: 0x002D3A50 File Offset: 0x002D1C50
	protected override void OnTimer(float gap)
	{
		base.OnTimer(gap);
		this.RefreshTitle();
	}

	// Token: 0x04005B8E RID: 23438
	private DangoAbyssActivityData DangoAbyssActivityData;

	// Token: 0x04005B8F RID: 23439
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04005B90 RID: 23440
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04005B91 RID: 23441
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04005B92 RID: 23442
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x04005B93 RID: 23443
	private ActivityButtonItem LimitRewardBtn;

	// Token: 0x04005B94 RID: 23444
	private ActivityButtonItem RewardBtn;

	// Token: 0x02007FAA RID: 32682
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04029AEE RID: 170734
		public const int TitleItem = 0;

		// Token: 0x04029AEF RID: 170735
		public const int DescItem = 1;

		// Token: 0x04029AF0 RID: 170736
		public const int RewardItem = 2;

		// Token: 0x04029AF1 RID: 170737
		public const int FunctionalAreaItem = 3;

		// Token: 0x04029AF2 RID: 170738
		public const int LimitRewardBtn = 4;

		// Token: 0x04029AF3 RID: 170739
		public const int LimitRewardProgress = 5;

		// Token: 0x04029AF4 RID: 170740
		public const int RewardBtn = 6;

		// Token: 0x04029AF5 RID: 170741
		public const int RewardProgress = 7;

		// Token: 0x04029AF6 RID: 170742
		public const int LimitRewardBtnItem = 8;

		// Token: 0x04029AF7 RID: 170743
		public const int RewardBtnItem = 9;

		// Token: 0x04029AF8 RID: 170744
		public const int SpineActor = 10;
	}
}
