using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.ActivityPanel
{
	// Token: 0x02004845 RID: 18501
	[NullableContext(1)]
	[Nullable(0)]
	public class ParkourEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06030693 RID: 198291 RVA: 0x00B3CB65 File Offset: 0x00B3AD65
		public override string GetResourceId()
		{
			return "UiView_Huodong_Prefab";
		}

		// Token: 0x06030694 RID: 198292 RVA: 0x00B3CB6C File Offset: 0x00B3AD6C
		protected override void OnStart()
		{
			this.ScoreTipsView = new TipsListView();
			this.ScoreTipsView.Initialize(base.GetVerticalLayout(5));
			base.OnStart();
		}

		// Token: 0x06030695 RID: 198293 RVA: 0x00B3CB91 File Offset: 0x00B3AD91
		protected override void OnBeforeDestroy()
		{
			TipsListView scoreTipsView = this.ScoreTipsView;
			if (scoreTipsView != null)
			{
				scoreTipsView.Clear();
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x06030696 RID: 198294 RVA: 0x00B3CBAC File Offset: 0x00B3ADAC
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(7);
			if (verticalLayout == null)
			{
				return;
			}
			verticalLayout.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06030697 RID: 198295 RVA: 0x00B3CBF4 File Offset: 0x00B3ADF4
		protected override void OnShowWorldMapSecondaryUi(params object[] parameters)
		{
			if (parameters.Length != 0)
			{
				ParkourMarkItem parkourMarkItem = parameters[0] as ParkourMarkItem;
				if (parkourMarkItem != null)
				{
					this.SelectedMarkItem = parkourMarkItem;
					this.LayoutContext.MarkItem = parkourMarkItem;
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateDesc(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithTrackStyle(this.LayoutContext);
					this.RefreshScore();
				}
			}
		}

		// Token: 0x06030698 RID: 198296 RVA: 0x00B3CC56 File Offset: 0x00B3AE56
		protected override void OnCloseWorldMapSecondaryUi()
		{
			TipsListView scoreTipsView = this.ScoreTipsView;
			if (scoreTipsView == null)
			{
				return;
			}
			scoreTipsView.Clear();
		}

		// Token: 0x06030699 RID: 198297 RVA: 0x00B3CC68 File Offset: 0x00B3AE68
		private void RefreshScore()
		{
			if (this.SelectedMarkItem == null)
			{
				return;
			}
			ActivityRunData challengeDataByMarkId = ActivityRunModel.Instance.GetChallengeDataByMarkId(this.SelectedMarkItem.MarkConfigId);
			ParkourChallenge? config = ConfigParkourChallengeByMarkId.GetConfig(this.SelectedMarkItem.MarkId, true);
			if (config == null)
			{
				return;
			}
			InstanceDungeonCostTip instanceDungeonCostTip = this.ScoreTipsView.AddItemByKey("line");
			instanceDungeonCostTip.SetLeftText(ConfigMultiTextLang.GetLocalTextNew("CurrentLine", null) ?? "");
			string rightText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("LineNumber", null) ?? "", new string[]
			{
				config.Value.Id.ToString()
			});
			instanceDungeonCostTip.SetRightText(rightText);
			instanceDungeonCostTip.SetHelpButtonVisible(false);
			InstanceDungeonCostTip instanceDungeonCostTip2 = this.ScoreTipsView.AddItemByKey("score");
			instanceDungeonCostTip2.SetHelpButtonVisible(false);
			string leftText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_ActiveRunMaxPoint_Text", null) ?? "", new string[]
			{
				""
			});
			instanceDungeonCostTip2.SetLeftText(leftText);
			if (challengeDataByMarkId.GetMiniTime() == 0)
			{
				instanceDungeonCostTip2.SetRightText(ConfigMultiTextLang.GetLocalTextNew("Text_ActivityRunNoPoint_Text", null) ?? "");
				return;
			}
			instanceDungeonCostTip2.SetRightText(challengeDataByMarkId.GetMaxScore().ToString());
		}

		// Token: 0x0603069A RID: 198298 RVA: 0x00B3CDAB File Offset: 0x00B3AFAB
		protected override void OnConfirmBtnClick(int index)
		{
			this.HandleTrack();
		}

		// Token: 0x0401A05B RID: 106587
		[Nullable(2)]
		private ParkourMarkItem SelectedMarkItem;

		// Token: 0x0401A05C RID: 106588
		[Nullable(2)]
		private TipsListView ScoreTipsView;

		// Token: 0x0200AB24 RID: 43812
		[Nullable(0)]
		public static class ParkourConstants
		{
			// Token: 0x04034021 RID: 213025
			public const string SCORE_KEY = "score";

			// Token: 0x04034022 RID: 213026
			public const string LINE_NUMBER_KEY = "line";
		}
	}
}
