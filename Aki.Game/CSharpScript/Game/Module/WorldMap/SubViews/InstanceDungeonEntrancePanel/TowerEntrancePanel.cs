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
	// Token: 0x02004813 RID: 18451
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x060304F3 RID: 197875 RVA: 0x00B35B08 File Offset: 0x00B33D08
		public override string GetResourceId()
		{
			return "UiView_Map_Tower_Tip_Prefab";
		}

		// Token: 0x060304F4 RID: 197876 RVA: 0x00B35B10 File Offset: 0x00B33D10
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

		// Token: 0x060304F5 RID: 197877 RVA: 0x00B35B8A File Offset: 0x00B33D8A
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

		// Token: 0x060304F6 RID: 197878 RVA: 0x00B35BBC File Offset: 0x00B33DBC
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

		// Token: 0x060304F7 RID: 197879 RVA: 0x00B35D07 File Offset: 0x00B33F07
		private void OnSecondRefresh()
		{
			this.RefreshDifficult();
			this.RefreshExploreContainer(this.FlowId);
			this.RefreshTime();
		}

		// Token: 0x060304F8 RID: 197880 RVA: 0x00B35D24 File Offset: 0x00B33F24
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

		// Token: 0x060304F9 RID: 197881 RVA: 0x00B35D80 File Offset: 0x00B33F80
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

		// Token: 0x060304FA RID: 197882 RVA: 0x00B35DEC File Offset: 0x00B33FEC
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

		// Token: 0x060304FB RID: 197883 RVA: 0x00B35E98 File Offset: 0x00B34098
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

		// Token: 0x060304FC RID: 197884 RVA: 0x00B35F37 File Offset: 0x00B34137
		protected override void OnCloseWorldMapSecondaryUi()
		{
			TipsListView instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView != null)
			{
				instanceCostTipView.Clear();
			}
			this.ClearTimer();
		}

		// Token: 0x060304FD RID: 197885 RVA: 0x00B35F50 File Offset: 0x00B34150
		private void ClearTimer()
		{
			if (this.TimerId != null && TimerSystem.Instance.Has(this.TimerId))
			{
				TimerSystem.Instance.Remove(this.TimerId);
				this.TimerId = null;
			}
		}

		// Token: 0x060304FE RID: 197886 RVA: 0x00B35F84 File Offset: 0x00B34184
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

		// Token: 0x04019FED RID: 106477
		private const int REWARD_ID = 3331;

		// Token: 0x04019FEE RID: 106478
		private const string TIME_KEY = "time";

		// Token: 0x04019FEF RID: 106479
		private const string DIFFICULT_KEY = "difficult";

		// Token: 0x04019FF0 RID: 106480
		private const string SCORE_KEY = "score";

		// Token: 0x04019FF1 RID: 106481
		[Nullable(2)]
		private TipsListView InstanceCostTipView;

		// Token: 0x04019FF2 RID: 106482
		[Nullable(2)]
		protected RewardItemBar RewardsView;

		// Token: 0x04019FF3 RID: 106483
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x04019FF4 RID: 106484
		private int FlowId;

		// Token: 0x04019FF5 RID: 106485
		private double RemainingTime;

		// Token: 0x0200AAE2 RID: 43746
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033F64 RID: 212836
			public const int TowerEntrancePanel = 0;
		}
	}
}
