using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.InstanceDungeonEntrancePanel
{
	// Token: 0x02003743 RID: 14147
	[NullableContext(1)]
	[Nullable(0)]
	public class ShipTowerEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024CB2 RID: 150706 RVA: 0x00A65698 File Offset: 0x00A63898
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024CB3 RID: 150707 RVA: 0x00A656A0 File Offset: 0x00A638A0
		protected override UniTask OnBeforeStartAsync()
		{
			ShipTowerEntrancePanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerEntrancePanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024CB4 RID: 150708 RVA: 0x00A656E3 File Offset: 0x00A638E3
		protected override void OnStart()
		{
			base.OnStart();
		}

		// Token: 0x06024CB5 RID: 150709 RVA: 0x00A656EC File Offset: 0x00A638EC
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			UUIItem item = base.GetItem(25);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(32);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			RewardItemBar rewardsView = this.RewardsView;
			if (rewardsView == null)
			{
				return;
			}
			rewardsView.SetActive(false);
		}

		// Token: 0x06024CB6 RID: 150710 RVA: 0x00A65738 File Offset: 0x00A63938
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				TeleportMarkItem teleportMarkItem = param[0] as TeleportMarkItem;
				if (teleportMarkItem != null)
				{
					this.LayoutContext.MarkItem = teleportMarkItem;
					this.RefreshReward();
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
					bool activityOpenState = ShipTowerModel.Instance.IsOpen();
					this.SetActivityOpenState(activityOpenState);
				}
			}
		}

		// Token: 0x06024CB7 RID: 150711 RVA: 0x00A657CF File Offset: 0x00A639CF
		private void OnSecondRefresh()
		{
			this.RefreshTime();
		}

		// Token: 0x06024CB8 RID: 150712 RVA: 0x00A657D8 File Offset: 0x00A639D8
		private void RefreshTime()
		{
			CommonDefine.ICountDown seasonCountDownData = ShipTowerModel.Instance.GetSeasonCountDownData();
			InstanceDungeonCostTip instanceDungeonCostTip = this.InstanceCostTipView.AddItemByKey("time");
			string leftText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("GhostShipTimeProgress_Text", null) ?? "", new string[]
			{
				""
			});
			instanceDungeonCostTip.SetLeftText(leftText);
			instanceDungeonCostTip.SetRightText(seasonCountDownData.CountDownText ?? "");
			instanceDungeonCostTip.SetHelpButtonVisible(false);
			if (ShipTowerModel.Instance.TimeIsOver())
			{
				this.CheckUpdateProto().Forget();
			}
		}

		// Token: 0x06024CB9 RID: 150713 RVA: 0x00A65864 File Offset: 0x00A63A64
		private void SetActivityOpenState(bool isOpen)
		{
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(isOpen);
			}
			this.ClearTimer();
			if (!isOpen)
			{
				return;
			}
			this.RefreshTime();
			this.UpdateRewardProgress();
			this.TimerId = TimerSystem.Instance.Forever(delegate(float delta)
			{
				this.OnSecondRefresh();
			}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		}

		// Token: 0x06024CBA RID: 150714 RVA: 0x00A658CC File Offset: 0x00A63ACC
		private UniTask CheckUpdateProto()
		{
			ShipTowerEntrancePanel.<CheckUpdateProto>d__15 <CheckUpdateProto>d__;
			<CheckUpdateProto>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckUpdateProto>d__.<>4__this = this;
			<CheckUpdateProto>d__.<>1__state = -1;
			<CheckUpdateProto>d__.<>t__builder.Start<ShipTowerEntrancePanel.<CheckUpdateProto>d__15>(ref <CheckUpdateProto>d__);
			return <CheckUpdateProto>d__.<>t__builder.Task;
		}

		// Token: 0x06024CBB RID: 150715 RVA: 0x00A65910 File Offset: 0x00A63B10
		private void UpdateRewardProgress()
		{
			InstanceDungeonCostTip instanceDungeonCostTip = this.InstanceCostTipView.AddItemByKey("score");
			string rewardProgressText = ShipTowerModel.Instance.GetRewardProgressText(false);
			string currentStageSeasonName = ShipTowerModel.Instance.GetCurrentStageSeasonName();
			instanceDungeonCostTip.SetHelpButtonVisible(false);
			instanceDungeonCostTip.SetLeftText(currentStageSeasonName);
			instanceDungeonCostTip.SetRightText(rewardProgressText);
			instanceDungeonCostTip.SetStarVisible(false);
		}

		// Token: 0x06024CBC RID: 150716 RVA: 0x00A6595F File Offset: 0x00A63B5F
		protected override void OnCloseWorldMapSecondaryUi()
		{
			TipsListView instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView != null)
			{
				instanceCostTipView.Clear();
			}
			this.ClearTimer();
		}

		// Token: 0x06024CBD RID: 150717 RVA: 0x00A65978 File Offset: 0x00A63B78
		private void ClearTimer()
		{
			if (this.TimerId != null && TimerSystem.Instance.Has(this.TimerId))
			{
				TimerSystem.Instance.Remove(this.TimerId);
				this.TimerId = null;
			}
		}

		// Token: 0x06024CBE RID: 150718 RVA: 0x00A659AC File Offset: 0x00A63BAC
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

		// Token: 0x06024CBF RID: 150719 RVA: 0x00A659E0 File Offset: 0x00A63BE0
		private void RefreshReward()
		{
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("GhostShipReward").GetValueOrDefault(1);
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(valueOrDefault);
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
				if (rewardsView3 != null)
				{
					rewardsView3.RebuildRewardsByData(dropPackagePreviewItemList);
				}
				RewardItemBar rewardsView4 = this.RewardsView;
				if (rewardsView4 == null)
				{
					return;
				}
				rewardsView4.SetTitleNewTxt("GhostShipMarkRewardTitle_Text");
				return;
			}
		}

		// Token: 0x0401469B RID: 83611
		private const string TIME_KEY = "time";

		// Token: 0x0401469C RID: 83612
		private const string REWARD_PROGRESS_KEY = "score";

		// Token: 0x0401469D RID: 83613
		[Nullable(2)]
		private TipsListView InstanceCostTipView;

		// Token: 0x0401469E RID: 83614
		[Nullable(2)]
		protected RewardItemBar RewardsView;

		// Token: 0x0401469F RID: 83615
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x040146A0 RID: 83616
		private bool IsUpdateProto;

		// Token: 0x02009490 RID: 38032
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E6DE RID: 190174
			public const int ShipTowerEntrancePanel = 0;
		}
	}
}
