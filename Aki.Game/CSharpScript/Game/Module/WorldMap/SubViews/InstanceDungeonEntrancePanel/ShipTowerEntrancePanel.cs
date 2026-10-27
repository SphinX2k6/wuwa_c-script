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
	// Token: 0x02004812 RID: 18450
	[NullableContext(1)]
	[Nullable(0)]
	public class ShipTowerEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x060304E2 RID: 197858 RVA: 0x00B35728 File Offset: 0x00B33928
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x060304E3 RID: 197859 RVA: 0x00B35730 File Offset: 0x00B33930
		protected override UniTask OnBeforeStartAsync()
		{
			ShipTowerEntrancePanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerEntrancePanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060304E4 RID: 197860 RVA: 0x00B35773 File Offset: 0x00B33973
		protected override void OnStart()
		{
			base.OnStart();
		}

		// Token: 0x060304E5 RID: 197861 RVA: 0x00B3577C File Offset: 0x00B3397C
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

		// Token: 0x060304E6 RID: 197862 RVA: 0x00B357C8 File Offset: 0x00B339C8
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

		// Token: 0x060304E7 RID: 197863 RVA: 0x00B3585F File Offset: 0x00B33A5F
		private void OnSecondRefresh()
		{
			this.RefreshTime();
		}

		// Token: 0x060304E8 RID: 197864 RVA: 0x00B35868 File Offset: 0x00B33A68
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

		// Token: 0x060304E9 RID: 197865 RVA: 0x00B358F4 File Offset: 0x00B33AF4
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

		// Token: 0x060304EA RID: 197866 RVA: 0x00B3595C File Offset: 0x00B33B5C
		private UniTask CheckUpdateProto()
		{
			ShipTowerEntrancePanel.<CheckUpdateProto>d__15 <CheckUpdateProto>d__;
			<CheckUpdateProto>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckUpdateProto>d__.<>4__this = this;
			<CheckUpdateProto>d__.<>1__state = -1;
			<CheckUpdateProto>d__.<>t__builder.Start<ShipTowerEntrancePanel.<CheckUpdateProto>d__15>(ref <CheckUpdateProto>d__);
			return <CheckUpdateProto>d__.<>t__builder.Task;
		}

		// Token: 0x060304EB RID: 197867 RVA: 0x00B359A0 File Offset: 0x00B33BA0
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

		// Token: 0x060304EC RID: 197868 RVA: 0x00B359EF File Offset: 0x00B33BEF
		protected override void OnCloseWorldMapSecondaryUi()
		{
			TipsListView instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView != null)
			{
				instanceCostTipView.Clear();
			}
			this.ClearTimer();
		}

		// Token: 0x060304ED RID: 197869 RVA: 0x00B35A08 File Offset: 0x00B33C08
		private void ClearTimer()
		{
			if (this.TimerId != null && TimerSystem.Instance.Has(this.TimerId))
			{
				TimerSystem.Instance.Remove(this.TimerId);
				this.TimerId = null;
			}
		}

		// Token: 0x060304EE RID: 197870 RVA: 0x00B35A3C File Offset: 0x00B33C3C
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

		// Token: 0x060304EF RID: 197871 RVA: 0x00B35A70 File Offset: 0x00B33C70
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

		// Token: 0x04019FE7 RID: 106471
		private const string TIME_KEY = "time";

		// Token: 0x04019FE8 RID: 106472
		private const string REWARD_PROGRESS_KEY = "score";

		// Token: 0x04019FE9 RID: 106473
		[Nullable(2)]
		private TipsListView InstanceCostTipView;

		// Token: 0x04019FEA RID: 106474
		[Nullable(2)]
		protected RewardItemBar RewardsView;

		// Token: 0x04019FEB RID: 106475
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x04019FEC RID: 106476
		private bool IsUpdateProto;

		// Token: 0x0200AADF RID: 43743
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033F5B RID: 212827
			public const int ShipTowerEntrancePanel = 0;
		}
	}
}
