using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.DollGrabMachine;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.DollGrabMachine
{
	// Token: 0x02003759 RID: 14169
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabMachinePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024D75 RID: 150901 RVA: 0x00A6971F File Offset: 0x00A6791F
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024D76 RID: 150902 RVA: 0x00A69728 File Offset: 0x00A67928
		protected override UniTask OnBeforeStartAsync()
		{
			DollGrabMachinePanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DollGrabMachinePanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024D77 RID: 150903 RVA: 0x00A6976C File Offset: 0x00A6796C
		private UniTask InitRewardItemBar()
		{
			DollGrabMachinePanel.<InitRewardItemBar>d__4 <InitRewardItemBar>d__;
			<InitRewardItemBar>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRewardItemBar>d__.<>4__this = this;
			<InitRewardItemBar>d__.<>1__state = -1;
			<InitRewardItemBar>d__.<>t__builder.Start<DollGrabMachinePanel.<InitRewardItemBar>d__4>(ref <InitRewardItemBar>d__);
			return <InitRewardItemBar>d__.<>t__builder.Task;
		}

		// Token: 0x06024D78 RID: 150904 RVA: 0x00A697B0 File Offset: 0x00A679B0
		private UniTask CreateDollGrabMachineScore()
		{
			DollGrabMachinePanel.<CreateDollGrabMachineScore>d__5 <CreateDollGrabMachineScore>d__;
			<CreateDollGrabMachineScore>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDollGrabMachineScore>d__.<>4__this = this;
			<CreateDollGrabMachineScore>d__.<>1__state = -1;
			<CreateDollGrabMachineScore>d__.<>t__builder.Start<DollGrabMachinePanel.<CreateDollGrabMachineScore>d__5>(ref <CreateDollGrabMachineScore>d__);
			return <CreateDollGrabMachineScore>d__.<>t__builder.Task;
		}

		// Token: 0x06024D79 RID: 150905 RVA: 0x00A697F4 File Offset: 0x00A679F4
		private void RefreshScore()
		{
			DollGrabMachineMarkItem dollGrabMachineMarkItem = this.LayoutContext.MarkItem as DollGrabMachineMarkItem;
			if (dollGrabMachineMarkItem == null)
			{
				return;
			}
			int entityId = dollGrabMachineMarkItem.GetEntityId();
			bool flag = DollGrabModel.Instance.IsDollGrabMachineDeliveryComplete(dollGrabMachineMarkItem.MapId, entityId);
			int dollGrabMachineDeliveryScore = DollGrabModel.Instance.GetDollGrabMachineDeliveryScore(dollGrabMachineMarkItem.MapId, entityId);
			InstanceDungeonCostTip scoreItem = this.ScoreItem;
			if (scoreItem != null)
			{
				scoreItem.SetLeftTextNew("KClaw_EndlessReward_Desc", new object[]
				{
					dollGrabMachineDeliveryScore
				});
			}
			string resourceId = flag ? "SP_ComChoose" : "SP_LockRing";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			InstanceDungeonCostTip scoreItem2 = this.ScoreItem;
			if (scoreItem2 != null)
			{
				scoreItem2.SetSprStarByPath(resourcePath);
			}
			InstanceDungeonCostTip scoreItem3 = this.ScoreItem;
			if (scoreItem3 != null)
			{
				scoreItem3.SetSprStarChangeColor(flag);
			}
			InstanceDungeonCostTip scoreItem4 = this.ScoreItem;
			if (scoreItem4 != null)
			{
				scoreItem4.SetRightText("");
			}
			InstanceDungeonCostTip scoreItem5 = this.ScoreItem;
			if (scoreItem5 != null)
			{
				scoreItem5.SetHelpButtonVisible(false);
			}
			InstanceDungeonCostTip scoreItem6 = this.ScoreItem;
			if (scoreItem6 == null)
			{
				return;
			}
			scoreItem6.SetIconVisible(false);
		}

		// Token: 0x06024D7A RID: 150906 RVA: 0x00A698E4 File Offset: 0x00A67AE4
		private void RefreshReward()
		{
			DollGrabMachineMarkItem dollGrabMachineMarkItem = this.LayoutContext.MarkItem as DollGrabMachineMarkItem;
			if (dollGrabMachineMarkItem == null)
			{
				return;
			}
			int entityId = dollGrabMachineMarkItem.GetEntityId();
			CommonLevelPlayPanelRewardData dollGrabMachineReward = DollGrabModel.Instance.GetDollGrabMachineReward(dollGrabMachineMarkItem.MapId, entityId);
			base.GetItem(8).SetUIActive(true);
			this.RewardsView.RebuildRewardsByLevelRewardData(dollGrabMachineReward);
		}

		// Token: 0x06024D7B RID: 150907 RVA: 0x00A69938 File Offset: 0x00A67B38
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				DollGrabMachineMarkItem dollGrabMachineMarkItem = param[0] as DollGrabMachineMarkItem;
				if (dollGrabMachineMarkItem != null)
				{
					this.LayoutContext.MarkItem = dollGrabMachineMarkItem;
					this.RefreshReward();
					this.RefreshScore();
					this.UpdateEnableFastMoveLayout();
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateDesc(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
					return;
				}
			}
		}

		// Token: 0x040146D1 RID: 83665
		[Nullable(2)]
		private InstanceDungeonCostTip ScoreItem;

		// Token: 0x040146D2 RID: 83666
		[Nullable(2)]
		private RewardItemBar RewardsView;
	}
}
