using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.InstanceDungeonEntrancePanel
{
	// Token: 0x02003746 RID: 14150
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024CE5 RID: 150757 RVA: 0x00A666EC File Offset: 0x00A648EC
		public override string GetResourceId()
		{
			return "UiView_Map_Tower_Tip_Prefab";
		}

		// Token: 0x06024CE6 RID: 150758 RVA: 0x00A666F4 File Offset: 0x00A648F4
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
			this.RewardsView.SetRootActor(base.GetItem(8).GetOwner(), true);
			base.OnStart();
		}

		// Token: 0x06024CE7 RID: 150759 RVA: 0x00A66767 File Offset: 0x00A64967
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

		// Token: 0x06024CE8 RID: 150760 RVA: 0x00A66798 File Offset: 0x00A64998
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				TeleportMarkItem teleportMarkItem = param[0] as TeleportMarkItem;
				if (teleportMarkItem != null)
				{
					this.LayoutContext.MarkItem = teleportMarkItem;
					this.RefreshTime();
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
				}
			}
		}

		// Token: 0x06024CE9 RID: 150761 RVA: 0x00A6685B File Offset: 0x00A64A5B
		private void OnSecondRefresh()
		{
			this.RefreshDifficult();
			this.RefreshTime();
		}

		// Token: 0x06024CEA RID: 150762 RVA: 0x00A6686C File Offset: 0x00A64A6C
		private void RefreshDifficult()
		{
			WheelTowerModel instance = WheelTowerModel.Instance;
			InstanceDungeonCostTip instanceDungeonCostTip = this.InstanceCostTipView.AddItemByKey("normal");
			instanceDungeonCostTip.SetHelpButtonVisible(false);
			instanceDungeonCostTip.SetLeftText(ConfigMultiTextLang.GetLocalTextNew("WheelBattleMode_NormalProgress", null) ?? "");
			instanceDungeonCostTip.SetStarVisible(false);
			int currentRewardProgress = instance.ActivityData.GetCurrentRewardProgress(EFilterMode.Normal);
			int totalRewardProgress = instance.ActivityData.GetTotalRewardProgress(EFilterMode.Normal);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(currentRewardProgress);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(totalRewardProgress);
			instanceDungeonCostTip.SetRightText(defaultInterpolatedStringHandler.ToStringAndClear());
			InstanceDungeonCostTip instanceDungeonCostTip2 = this.InstanceCostTipView.AddItemByKey("endless");
			instanceDungeonCostTip2.SetHelpButtonVisible(false);
			instanceDungeonCostTip2.SetLeftText(ConfigMultiTextLang.GetLocalTextNew("WheelBattleMode_EndlessProgress", null) ?? "");
			instanceDungeonCostTip2.SetStarVisible(false);
			int currentRewardProgress2 = instance.ActivityData.GetCurrentRewardProgress(EFilterMode.Endless);
			int totalRewardProgress2 = instance.ActivityData.GetTotalRewardProgress(EFilterMode.Endless);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(currentRewardProgress2);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(totalRewardProgress2);
			instanceDungeonCostTip2.SetRightText(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06024CEB RID: 150763 RVA: 0x00A66988 File Offset: 0x00A64B88
		private void RefreshTime()
		{
			CommonDefine.ICountDown seasonCountDownData = WheelTowerModel.Instance.GetSeasonCountDownData();
			InstanceDungeonCostTip instanceDungeonCostTip = this.InstanceCostTipView.AddItemByKey("time");
			string leftText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_ActiveRemainTime_Text", null) ?? "", new string[]
			{
				""
			});
			instanceDungeonCostTip.SetLeftText(leftText);
			instanceDungeonCostTip.SetRightText(seasonCountDownData.CountDownText ?? "");
			instanceDungeonCostTip.SetHelpButtonVisible(false);
		}

		// Token: 0x06024CEC RID: 150764 RVA: 0x00A669FC File Offset: 0x00A64BFC
		protected override void OnCloseWorldMapSecondaryUi()
		{
			TipsListView instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView != null)
			{
				instanceCostTipView.Clear();
			}
			this.ClearTimer();
		}

		// Token: 0x06024CED RID: 150765 RVA: 0x00A66A15 File Offset: 0x00A64C15
		private void ClearTimer()
		{
			if (this.TimerId != null && TimerSystem.Instance.Has(this.TimerId))
			{
				TimerSystem.Instance.Remove(this.TimerId);
				this.TimerId = null;
			}
		}

		// Token: 0x06024CEE RID: 150766 RVA: 0x00A66A49 File Offset: 0x00A64C49
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

		// Token: 0x040146B1 RID: 83633
		private const string TIME_KEY = "time";

		// Token: 0x040146B2 RID: 83634
		private const string NORMAL_KEY = "normal";

		// Token: 0x040146B3 RID: 83635
		private const string ENDLESS_KEY = "endless";

		// Token: 0x040146B4 RID: 83636
		[Nullable(2)]
		private TipsListView InstanceCostTipView;

		// Token: 0x040146B5 RID: 83637
		[Nullable(2)]
		protected RewardItemBar RewardsView;

		// Token: 0x040146B6 RID: 83638
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x02009496 RID: 38038
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E6ED RID: 190189
			public const int WheelTowerEntrancePanel = 0;
		}
	}
}
