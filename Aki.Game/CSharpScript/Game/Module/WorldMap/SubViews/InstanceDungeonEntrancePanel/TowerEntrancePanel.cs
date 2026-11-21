using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.InstanceDungeonEntrancePanel
{
	// Token: 0x02003744 RID: 14148
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024CC3 RID: 150723 RVA: 0x00A65A78 File Offset: 0x00A63C78
		public override string GetResourceId()
		{
			return "UiView_Map_Tower_Tip_Prefab";
		}

		// Token: 0x06024CC4 RID: 150724 RVA: 0x00A65A80 File Offset: 0x00A63C80
		protected override void OnStart()
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(5);
			if (verticalLayout != null)
			{
				verticalLayout.RootUIComp.Get().SetUIActive(true);
			}
			this.InstanceCostTipView = new TipsListView();
			this.InstanceCostTipView.Initialize(base.GetVerticalLayout(5));
			this.RewardsView = new RewardItemBar();
			UiPanelBase rewardsView = this.RewardsView;
			UUIItem item = base.GetItem(8);
			rewardsView.SetRootActor((item != null) ? item.GetOwner() : null, true);
			base.OnStart();
		}

		// Token: 0x06024CC5 RID: 150725 RVA: 0x00A65AFA File Offset: 0x00A63CFA
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			UUIItem item = base.GetItem(25);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(32);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06024CC6 RID: 150726 RVA: 0x00A65B2C File Offset: 0x00A63D2C
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				TeleportMarkItem teleportMarkItem = param[0] as TeleportMarkItem;
				if (teleportMarkItem != null)
				{
					this.LayoutContext.MarkItem = teleportMarkItem;
					int num = (teleportMarkItem != null) ? teleportMarkItem.MarkConfig.Value.RelativeId : 0;
					int markConfigId = teleportMarkItem.MarkConfigId;
					int num2;
					if (num == 0)
					{
						InstanceDungeonEntranceConfig instance = InstanceDungeonEntranceConfig.Instance;
						num2 = ((instance != null) ? instance.GetEntranceIdByMarkId(markConfigId) : 0);
					}
					else
					{
						num2 = num;
					}
					int id = num2;
					InstanceDungeonEntranceConfig instance2 = InstanceDungeonEntranceConfig.Instance;
					int flowId = (instance2 != null) ? instance2.GetInstanceDungeonEntranceFlowId(id) : 0;
					this.FlowId = flowId;
					this.RefreshTime();
					this.RefreshReward();
					this.RefreshExploreContainer(flowId);
					this.RefreshDifficult();
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateDesc(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
					bool flag = base.UpdateQuickGoto();
					WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
					if (layoutContext != null)
					{
						layoutContext.SetConfirmBtnActive(!flag);
					}
					this.ClearTimer();
					this.TimerId = TimerSystem.Instance.Forever(delegate(float delta)
					{
						this.OnSecondRefresh();
					}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
					this.RemainingTime = (double)TowerModel.Instance.TowerEndTime.GetValueOrDefault() - TimeUtil.Instance.GetServerTime();
				}
			}
		}

		// Token: 0x06024CC7 RID: 150727 RVA: 0x00A65C7B File Offset: 0x00A63E7B
		private void OnSecondRefresh()
		{
			this.RefreshDifficult();
			this.RefreshExploreContainer(this.FlowId);
			this.RefreshTime();
		}

		// Token: 0x06024CC8 RID: 150728 RVA: 0x00A65C98 File Offset: 0x00A63E98
		private void RefreshReward()
		{
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(3331);
			if (dropPackagePreviewItemList.Count == 0)
			{
				RewardItemBar rewardsView = this.RewardsView;
				if (rewardsView == null)
				{
					return;
				}
				rewardsView.SetActive(false);
				return;
			}
			else
			{
				RewardItemBar rewardsView2 = this.RewardsView;
				if (rewardsView2 != null)
				{
					rewardsView2.SetActive(true);
				}
				RewardItemBar rewardsView3 = this.RewardsView;
				if (rewardsView3 == null)
				{
					return;
				}
				rewardsView3.RebuildRewardsByData(dropPackagePreviewItemList);
				return;
			}
		}

		// Token: 0x06024CC9 RID: 150729 RVA: 0x00A65CF4 File Offset: 0x00A63EF4
		private void RefreshDifficult()
		{
			InstanceDungeonCostTip instanceDungeonCostTip = this.InstanceCostTipView.AddItemByKey("difficult");
			int maxDifficulty = TowerModel.Instance.GetMaxDifficulty();
			instanceDungeonCostTip.SetHelpButtonVisible(false);
			instanceDungeonCostTip.SetLeftText(ConfigMultiTextLang.GetLocalTextNew("TowerProcess", null) ?? "");
			TowerClimbConfig instance = TowerClimbConfig.Instance;
			string text = (instance != null) ? instance.GetNewTowerDifficultTitle(maxDifficulty) : null;
			instanceDungeonCostTip.SetRightText(text ?? "");
		}

		// Token: 0x06024CCA RID: 150730 RVA: 0x00A65D60 File Offset: 0x00A63F60
		private void RefreshTime()
		{
			CommonDefine.ICountDown seasonCountDownData = TowerModel.Instance.GetSeasonCountDownData();
			InstanceDungeonCostTip instanceDungeonCostTip = this.InstanceCostTipView.AddItemByKey("time");
			string leftText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_ActiveRemainTime_Text", null) ?? "", new string[]
			{
				""
			});
			instanceDungeonCostTip.SetLeftText(leftText);
			instanceDungeonCostTip.SetRightText(seasonCountDownData.CountDownText ?? "");
			instanceDungeonCostTip.SetHelpButtonVisible(false);
			this.RemainingTime -= 1.0;
			if (this.RemainingTime < 2.0)
			{
				TowerController.Instance.RefreshTower(0).Forget<bool>();
			}
		}

		// Token: 0x06024CCB RID: 150731 RVA: 0x00A65E0C File Offset: 0x00A6400C
		private void RefreshExploreContainer(int flowId)
		{
			if (flowId >= 4)
			{
				InstanceDungeonCostTip instanceDungeonCostTip = this.InstanceCostTipView.AddItemByKey("score");
				TowerModel instance = TowerModel.Instance;
				int maxDifficulty = instance.GetMaxDifficulty();
				int difficultyMaxStars = instance.GetDifficultyMaxStars(maxDifficulty, false);
				int difficultyAllStars = instance.GetDifficultyAllStars(maxDifficulty, false);
				instanceDungeonCostTip.SetHelpButtonVisible(false);
				instanceDungeonCostTip.SetLeftText(ConfigMultiTextLang.GetLocalTextNew("TowerScore", null) ?? "");
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(difficultyMaxStars);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(difficultyAllStars);
				instanceDungeonCostTip.SetRightText(defaultInterpolatedStringHandler.ToStringAndClear());
				instanceDungeonCostTip.SetStarVisible(true);
			}
		}

		// Token: 0x06024CCC RID: 150732 RVA: 0x00A65EAB File Offset: 0x00A640AB
		protected override void OnCloseWorldMapSecondaryUi()
		{
			TipsListView instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView != null)
			{
				instanceCostTipView.Clear();
			}
			this.ClearTimer();
		}

		// Token: 0x06024CCD RID: 150733 RVA: 0x00A65EC4 File Offset: 0x00A640C4
		private void ClearTimer()
		{
			if (this.TimerId != null && TimerSystem.Instance.Has(this.TimerId))
			{
				TimerSystem.Instance.Remove(this.TimerId);
				this.TimerId = null;
			}
		}

		// Token: 0x06024CCE RID: 150734 RVA: 0x00A65EF8 File Offset: 0x00A640F8
		protected override void OnBeforeDestroy()
		{
			this.ClearTimer();
			RewardItemBar rewardsView = this.RewardsView;
			if (rewardsView != null)
			{
				rewardsView.Destroy(null);
			}
			TipsListView instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView != null)
			{
				instanceCostTipView.Clear();
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x040146A1 RID: 83617
		private const int REWARD_ID = 3331;

		// Token: 0x040146A2 RID: 83618
		private const string TIME_KEY = "time";

		// Token: 0x040146A3 RID: 83619
		private const string DIFFICULT_KEY = "difficult";

		// Token: 0x040146A4 RID: 83620
		private const string SCORE_KEY = "score";

		// Token: 0x040146A5 RID: 83621
		[Nullable(2)]
		private TipsListView InstanceCostTipView;

		// Token: 0x040146A6 RID: 83622
		[Nullable(2)]
		protected RewardItemBar RewardsView;

		// Token: 0x040146A7 RID: 83623
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x040146A8 RID: 83624
		private int FlowId;

		// Token: 0x040146A9 RID: 83625
		private double RemainingTime;

		// Token: 0x02009493 RID: 38035
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E6E7 RID: 190183
			public const int TowerEntrancePanel = 0;
		}
	}
}
