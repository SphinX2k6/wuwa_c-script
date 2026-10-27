using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020012EA RID: 4842
[NullableContext(2)]
[Nullable(0)]
public class ActivitySubViewMoonChasing : ActivitySubViewBase
{
	// Token: 0x17000B79 RID: 2937
	// (get) Token: 0x060085B7 RID: 34231 RVA: 0x001C7C5A File Offset: 0x001C5E5A
	protected new ActivityMoonChasingData ActivityBaseData
	{
		get
		{
			return this.ActivityBaseData as ActivityMoonChasingData;
		}
	}

	// Token: 0x060085B8 RID: 34232 RVA: 0x001C7C68 File Offset: 0x001C5E68
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
	}

	// Token: 0x060085B9 RID: 34233 RVA: 0x001C7D5D File Offset: 0x001C5F5D
	protected override void OnSetData()
	{
	}

	// Token: 0x060085BA RID: 34234 RVA: 0x001C7D60 File Offset: 0x001C5F60
	protected override UniTask OnBeforeStartAsync()
	{
		ActivitySubViewMoonChasing.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewMoonChasing.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060085BB RID: 34235 RVA: 0x001C7DA4 File Offset: 0x001C5FA4
	protected override void OnStart()
	{
		Activity? localConfig = this.ActivityBaseData.LocalConfig;
		if (localConfig == null)
		{
			return;
		}
		string descTheme = localConfig.Value.DescTheme;
		bool flag = !StringUtils.IsEmpty(descTheme);
		this.TitleComponent.SetSubTitleVisible(flag);
		if (flag)
		{
			this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
		}
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		string desc = localConfig.Value.Desc;
		this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.SetActive(previewReward.Count > 0);
		this.RewardListComponent.SetTitleByTextId("CollectActivity_reward");
		this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
		base.GetItem(4).SetUIActive(false);
		this.FunctionalComponent.FunctionButton.SetFunction(new Action(this.JumpFunction));
		this.QuestPanelTips.SetActive(false);
		this.QuestPanelTips.SetRewardButtonFunction(new Action(this.PreStageQuestJump));
	}

	// Token: 0x060085BC RID: 34236 RVA: 0x001C7EFD File Offset: 0x001C60FD
	protected override void OnRefreshView()
	{
		this.RefreshFunctionalComponent();
		this.RefreshQuestTips();
		this.RefreshButton();
		this.RefreshRedDot();
	}

	// Token: 0x060085BD RID: 34237 RVA: 0x001C7F17 File Offset: 0x001C6117
	protected override void OnTimer(float gap)
	{
		this.RefreshTimerText();
	}

	// Token: 0x060085BE RID: 34238 RVA: 0x001C7F1F File Offset: 0x001C611F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x060085BF RID: 34239 RVA: 0x001C7F3D File Offset: 0x001C613D
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
	}

	// Token: 0x060085C0 RID: 34240 RVA: 0x001C7F5C File Offset: 0x001C615C
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		UUIItem guideUiItem = base.GetGuideUiItem("0");
		if (guideUiItem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			guideUiItem,
			guideUiItem
		};
	}

	// Token: 0x060085C1 RID: 34241 RVA: 0x001C7F88 File Offset: 0x001C6188
	private void OnRefreshCommonActivityRedDot(int id)
	{
		if (id == this.ActivityBaseData.Id)
		{
			this.RefreshRedDot();
		}
	}

	// Token: 0x060085C2 RID: 34242 RVA: 0x001C7FA0 File Offset: 0x001C61A0
	private void RefreshTimerText()
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.TitleComponent.SetTimeTextVisible(item);
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
	}

	// Token: 0x060085C3 RID: 34243 RVA: 0x001C7FDC File Offset: 0x001C61DC
	private void RefreshQuestTips()
	{
		bool flag = this.ActivityBaseData.IsPreStageQuestFinished();
		bool preGuideQuestFinishState = this.ActivityBaseData.GetPreGuideQuestFinishState();
		this.QuestPanelTips.SetActive(!flag && !preGuideQuestFinishState);
		if (flag)
		{
			return;
		}
		TrackMoonActivity? activityMoonChasingConfig = ActivityMoonChasingConfig.Instance.GetActivityMoonChasingConfig(this.ActivityBaseData.Id);
		this.QuestPanelTips.SetContentByTextId(activityMoonChasingConfig.Value.StageQuestTips, Array.Empty<string>());
	}

	// Token: 0x060085C4 RID: 34244 RVA: 0x001C8050 File Offset: 0x001C6250
	private void RefreshButton()
	{
		int handbookUnlockCount = MoonChasingModel.Instance.GetHandbookUnlockCount();
		int count = MoonChasingBuildingModel.Instance.GetAllBuildingData().Count;
		this.HandbookBtn.SetText(handbookUnlockCount.ToString() + "/" + count.ToString());
		int targetTotalCount = MoonChasingRewardModel.Instance.TargetTotalCount;
		int num = Math.Min(targetTotalCount, MoonChasingRewardModel.Instance.TargetGetCount);
		this.RewardBtn.SetText(num.ToString() + "/" + targetTotalCount.ToString());
	}

	// Token: 0x060085C5 RID: 34245 RVA: 0x001C80DA File Offset: 0x001C62DA
	private void PreStageQuestJump()
	{
		UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.GetPreStageQuestId(), null);
	}

	// Token: 0x060085C6 RID: 34246 RVA: 0x001C80FC File Offset: 0x001C62FC
	private void RefreshFunctionalComponent()
	{
		bool flag = this.ActivityBaseData.IsUnLock();
		bool preGuideQuestFinishState = this.ActivityBaseData.GetPreGuideQuestFinishState();
		EMoonChasingActivityFlow activityFlowState = this.ActivityBaseData.ActivityFlowState;
		this.FunctionalComponent.SetPanelConditionVisible(!flag);
		if (!flag)
		{
			this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
		}
		this.FunctionalComponent.SetRewardButtonVisible(false);
		base.GetItem(6).SetUIActive(false);
		this.RewardBtn.SetActive(this.ActivityBaseData.PermanentTargetOn && flag && preGuideQuestFinishState);
		this.HandbookBtn.SetActive(flag && preGuideQuestFinishState && activityFlowState == EMoonChasingActivityFlow.Activity);
		this.FunctionalComponent.FunctionButton.SetUiActive(flag);
		string showText = "Moonfiesta_Skip";
		if (activityFlowState == EMoonChasingActivityFlow.Close)
		{
			showText = "Moonfiesta_Memory";
		}
		else if (!preGuideQuestFinishState)
		{
			showText = "JumpToQuestText";
		}
		this.FunctionalComponent.FunctionButton.SetShowText(showText);
	}

	// Token: 0x060085C7 RID: 34247 RVA: 0x001C81E7 File Offset: 0x001C63E7
	private void RefreshRedDot()
	{
		this.FunctionalComponent.FunctionButton.SetRedDotVisible(this.ActivityBaseData.IsHasMoonChasingRedDot());
		this.HandbookBtn.BindRedDot(ERedDotName.MoonChasingHandbook, 0);
		this.RewardBtn.BindRedDot(ERedDotName.MoonChasingRewardAndShop, 0);
	}

	// Token: 0x060085C8 RID: 34248 RVA: 0x001C8228 File Offset: 0x001C6428
	private void SkipToReward()
	{
		if (this.ActivityBaseData.PermanentTargetOn)
		{
			bool canAccomplishTask = this.ActivityBaseData.ActivityFlowState == EMoonChasingActivityFlow.Activity;
			MoonChasingController.Instance.OpenRewardView(canAccomplishTask);
		}
	}

	// Token: 0x060085C9 RID: 34249 RVA: 0x001C825C File Offset: 0x001C645C
	private void SkipToHandbook()
	{
		MoonChasingController.Instance.OpenHandbookView();
	}

	// Token: 0x060085CA RID: 34250 RVA: 0x001C8268 File Offset: 0x001C6468
	protected void OpenRewardPopUp()
	{
		if (!this.ActivityBaseData.LimitTimeRewardOn)
		{
			return;
		}
		IActivityRewardViewData allRewardData = this.ActivityBaseData.GetAllRewardData();
		if (allRewardData == null)
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.ActivityRewardPopUpView, allRewardData, null);
	}

	// Token: 0x060085CB RID: 34251 RVA: 0x001C82A4 File Offset: 0x001C64A4
	private void JumpFunction()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (this.ActivityBaseData.ActivityFlowState == EMoonChasingActivityFlow.Close)
			{
				MoonChasingController.Instance.OpenMemoryEntranceView();
				return;
			}
			if (this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				TrackMoonActivity? activityMoonChasingConfig = ActivityMoonChasingConfig.Instance.GetActivityMoonChasingConfig(this.ActivityBaseData.Id);
				WorldMapViewOpenParams data = new WorldMapViewOpenParams
				{
					MarkId = new int?(activityMoonChasingConfig.Value.FocusMarkId),
					MarkType = EMarkType.SmallTeleport
				};
				WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
				return;
			}
			if (!this.ActivityBaseData.IsPreStageQuestFinished())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MoonChasingJumpPreQuest);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.GetUnFinishPreGuideQuestId(), null);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.GetUnFinishPreGuideQuestId(), null);
		});
	}

	// Token: 0x04003BFE RID: 15358
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003BFF RID: 15359
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04003C00 RID: 15360
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003C01 RID: 15361
	private ActivityFunctionalArea FunctionalComponent;

	// Token: 0x04003C02 RID: 15362
	private ActivityQuestTipsItem QuestPanelTips;

	// Token: 0x04003C03 RID: 15363
	private ButtonItem HandbookBtn;

	// Token: 0x04003C04 RID: 15364
	private ButtonItem RewardBtn;

	// Token: 0x0200790B RID: 30987
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027E02 RID: 163330
		public const int TitleItem = 0;

		// Token: 0x04027E03 RID: 163331
		public const int DescriptionItem = 1;

		// Token: 0x04027E04 RID: 163332
		public const int RewardListItem = 2;

		// Token: 0x04027E05 RID: 163333
		public const int FunctionArea = 3;

		// Token: 0x04027E06 RID: 163334
		public const int PermanentTargetItem = 4;

		// Token: 0x04027E07 RID: 163335
		public const int PermanentButton = 5;

		// Token: 0x04027E08 RID: 163336
		public const int PermanentButtonRedDot = 6;

		// Token: 0x04027E09 RID: 163337
		public const int QuestPanelTips = 7;

		// Token: 0x04027E0A RID: 163338
		public const int ButtonReward = 8;

		// Token: 0x04027E0B RID: 163339
		public const int ButtonHandbook = 9;
	}
}
