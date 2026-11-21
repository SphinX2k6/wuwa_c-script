using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F1C RID: 3868
[NullableContext(2)]
[Nullable(0)]
public class DangoAbyssSubView : ActivitySubViewBase
{
	// Token: 0x06009AC3 RID: 39619 RVA: 0x002DE650 File Offset: 0x002DC850
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

	// Token: 0x06009AC4 RID: 39620 RVA: 0x002DE75C File Offset: 0x002DC95C
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssSubView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssSubView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009AC5 RID: 39621 RVA: 0x002DE79F File Offset: 0x002DC99F
	protected override void OnStart()
	{
		this.DangoAbyssActivityData = (this.ActivityBaseData as DangoAbyssActivityData);
	}

	// Token: 0x06009AC6 RID: 39622 RVA: 0x002DE7B2 File Offset: 0x002DC9B2
	protected override void OnBeforeShow()
	{
		this.BindRedDot();
		base.GetSpine(10).SetAnimation(0, "start", false).AnimationComplete.Add(delegate(UTrackEntry _)
		{
			base.GetSpine(10).SetAnimation(0, "idle", true);
		});
	}

	// Token: 0x06009AC7 RID: 39623 RVA: 0x002DE7E4 File Offset: 0x002DC9E4
	protected override void OnBeforeHide()
	{
		this.RemoveRedDot();
		base.GetSpine(10).ClearTracks();
	}

	// Token: 0x06009AC8 RID: 39624 RVA: 0x002DE7FC File Offset: 0x002DC9FC
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

	// Token: 0x06009AC9 RID: 39625 RVA: 0x002DE84A File Offset: 0x002DCA4A
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

	// Token: 0x06009ACA RID: 39626 RVA: 0x002DE884 File Offset: 0x002DCA84
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

	// Token: 0x06009ACB RID: 39627 RVA: 0x002DE8CC File Offset: 0x002DCACC
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

	// Token: 0x06009ACC RID: 39628 RVA: 0x002DE930 File Offset: 0x002DCB30
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

	// Token: 0x06009ACD RID: 39629 RVA: 0x002DE9C0 File Offset: 0x002DCBC0
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

	// Token: 0x06009ACE RID: 39630 RVA: 0x002DEA38 File Offset: 0x002DCC38
	private void RefreshReward()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.SetTitleByTextId("BossRushCollectReward");
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
	}

	// Token: 0x06009ACF RID: 39631 RVA: 0x002DEA78 File Offset: 0x002DCC78
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

	// Token: 0x06009AD0 RID: 39632 RVA: 0x002DEAD8 File Offset: 0x002DCCD8
	private void RefreshFunctionalComponent()
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("DangoAbyssEnterText", null);
		this.FunctionalComponent.FunctionButton.SetText(localTextNew);
		bool redDotVisible = this.ActivityBaseData.IsUnLock() && DangoAbyssModel.Instance.GetAbyssDangoEnterNew();
		this.FunctionalComponent.FunctionButton.SetRedDotVisible(redDotVisible);
	}

	// Token: 0x06009AD1 RID: 39633 RVA: 0x002DEB2E File Offset: 0x002DCD2E
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

	// Token: 0x06009AD2 RID: 39634 RVA: 0x002DEB4C File Offset: 0x002DCD4C
	protected override void OnTimer(float gap)
	{
		base.OnTimer(gap);
		this.RefreshTitle();
	}

	// Token: 0x04005C5D RID: 23645
	private DangoAbyssActivityData DangoAbyssActivityData;

	// Token: 0x04005C5E RID: 23646
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04005C5F RID: 23647
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04005C60 RID: 23648
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04005C61 RID: 23649
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x04005C62 RID: 23650
	private ActivityButtonItem LimitRewardBtn;

	// Token: 0x04005C63 RID: 23651
	private ActivityButtonItem RewardBtn;

	// Token: 0x02007139 RID: 28985
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04024E2B RID: 151083
		public const int TitleItem = 0;

		// Token: 0x04024E2C RID: 151084
		public const int DescItem = 1;

		// Token: 0x04024E2D RID: 151085
		public const int RewardItem = 2;

		// Token: 0x04024E2E RID: 151086
		public const int FunctionalAreaItem = 3;

		// Token: 0x04024E2F RID: 151087
		public const int LimitRewardBtn = 4;

		// Token: 0x04024E30 RID: 151088
		public const int LimitRewardProgress = 5;

		// Token: 0x04024E31 RID: 151089
		public const int RewardBtn = 6;

		// Token: 0x04024E32 RID: 151090
		public const int RewardProgress = 7;

		// Token: 0x04024E33 RID: 151091
		public const int LimitRewardBtnItem = 8;

		// Token: 0x04024E34 RID: 151092
		public const int RewardBtnItem = 9;

		// Token: 0x04024E35 RID: 151093
		public const int SpineActor = 10;
	}
}
