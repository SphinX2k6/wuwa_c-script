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
	// Token: 0x02004828 RID: 18472
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabMachinePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x060305A5 RID: 198053 RVA: 0x00B39653 File Offset: 0x00B37853
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x060305A6 RID: 198054 RVA: 0x00B3965C File Offset: 0x00B3785C
		protected override UniTask OnBeforeStartAsync()
		{
			DollGrabMachinePanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DollGrabMachinePanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060305A7 RID: 198055 RVA: 0x00B396A0 File Offset: 0x00B378A0
		private UniTask InitRewardItemBar()
		{
			DollGrabMachinePanel.<InitRewardItemBar>d__4 <InitRewardItemBar>d__;
			<InitRewardItemBar>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRewardItemBar>d__.<>4__this = this;
			<InitRewardItemBar>d__.<>1__state = -1;
			<InitRewardItemBar>d__.<>t__builder.Start<DollGrabMachinePanel.<InitRewardItemBar>d__4>(ref <InitRewardItemBar>d__);
			return <InitRewardItemBar>d__.<>t__builder.Task;
		}

		// Token: 0x060305A8 RID: 198056 RVA: 0x00B396E4 File Offset: 0x00B378E4
		private UniTask CreateDollGrabMachineScore()
		{
			DollGrabMachinePanel.<CreateDollGrabMachineScore>d__5 <CreateDollGrabMachineScore>d__;
			<CreateDollGrabMachineScore>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateDollGrabMachineScore>d__.<>4__this = this;
			<CreateDollGrabMachineScore>d__.<>1__state = -1;
			<CreateDollGrabMachineScore>d__.<>t__builder.Start<DollGrabMachinePanel.<CreateDollGrabMachineScore>d__5>(ref <CreateDollGrabMachineScore>d__);
			return <CreateDollGrabMachineScore>d__.<>t__builder.Task;
		}

		// Token: 0x060305A9 RID: 198057 RVA: 0x00B39728 File Offset: 0x00B37928
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

		// Token: 0x060305AA RID: 198058 RVA: 0x00B39818 File Offset: 0x00B37A18
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

		// Token: 0x060305AB RID: 198059 RVA: 0x00B3986C File Offset: 0x00B37A6C
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

		// Token: 0x0401A01D RID: 106525
		[Nullable(2)]
		private InstanceDungeonCostTip ScoreItem;

		// Token: 0x0401A01E RID: 106526
		[Nullable(2)]
		private RewardItemBar RewardsView;
	}
}
