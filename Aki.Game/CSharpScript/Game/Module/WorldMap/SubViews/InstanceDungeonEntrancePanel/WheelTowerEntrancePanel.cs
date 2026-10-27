using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.InstanceDungeonEntrancePanel
{
	// Token: 0x02004815 RID: 18453
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06030515 RID: 197909 RVA: 0x00B36778 File Offset: 0x00B34978
		public override string GetResourceId()
		{
			return "UiView_Map_Tower_Tip_Prefab";
		}

		// Token: 0x06030516 RID: 197910 RVA: 0x00B36780 File Offset: 0x00B34980
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

		// Token: 0x06030517 RID: 197911 RVA: 0x00B367F3 File Offset: 0x00B349F3
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

		// Token: 0x06030518 RID: 197912 RVA: 0x00B36824 File Offset: 0x00B34A24
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

		// Token: 0x06030519 RID: 197913 RVA: 0x00B368E7 File Offset: 0x00B34AE7
		private void OnSecondRefresh()
		{
			this.RefreshDifficult();
			this.RefreshTime();
		}

		// Token: 0x0603051A RID: 197914 RVA: 0x00B368F8 File Offset: 0x00B34AF8
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

		// Token: 0x0603051B RID: 197915 RVA: 0x00B36A14 File Offset: 0x00B34C14
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

		// Token: 0x0603051C RID: 197916 RVA: 0x00B36A88 File Offset: 0x00B34C88
		protected override void OnCloseWorldMapSecondaryUi()
		{
			TipsListView instanceCostTipView = this.InstanceCostTipView;
			if (instanceCostTipView != null)
			{
				instanceCostTipView.Clear();
			}
			this.ClearTimer();
		}

		// Token: 0x0603051D RID: 197917 RVA: 0x00B36AA1 File Offset: 0x00B34CA1
		private void ClearTimer()
		{
			if (this.TimerId != null && TimerSystem.Instance.Has(this.TimerId))
			{
				TimerSystem.Instance.Remove(this.TimerId);
				this.TimerId = null;
			}
		}

		// Token: 0x0603051E RID: 197918 RVA: 0x00B36AD5 File Offset: 0x00B34CD5
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

		// Token: 0x04019FFD RID: 106493
		private const string TIME_KEY = "time";

		// Token: 0x04019FFE RID: 106494
		private const string NORMAL_KEY = "normal";

		// Token: 0x04019FFF RID: 106495
		private const string ENDLESS_KEY = "endless";

		// Token: 0x0401A000 RID: 106496
		[Nullable(2)]
		private TipsListView InstanceCostTipView;

		// Token: 0x0401A001 RID: 106497
		[Nullable(2)]
		protected RewardItemBar RewardsView;

		// Token: 0x0401A002 RID: 106498
		[Nullable(2)]
		private TimerHandle TimerId;

		// Token: 0x0200AAE5 RID: 43749
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033F6A RID: 212842
			public const int WheelTowerEntrancePanel = 0;
		}
	}
}
