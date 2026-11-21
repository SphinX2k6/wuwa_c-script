using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.ActivityPanel
{
	// Token: 0x02003776 RID: 14198
	[NullableContext(1)]
	[Nullable(0)]
	public class ParkourEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024E63 RID: 151139 RVA: 0x00A6CD4D File Offset: 0x00A6AF4D
		public override string GetResourceId()
		{
			return "UiView_Huodong_Prefab";
		}

		// Token: 0x06024E64 RID: 151140 RVA: 0x00A6CD54 File Offset: 0x00A6AF54
		protected override void OnStart()
		{
			this.ScoreTipsView = new TipsListView();
			this.ScoreTipsView.Initialize(base.GetVerticalLayout(5));
			base.OnStart();
		}

		// Token: 0x06024E65 RID: 151141 RVA: 0x00A6CD79 File Offset: 0x00A6AF79
		protected override void OnBeforeDestroy()
		{
			TipsListView scoreTipsView = this.ScoreTipsView;
			if (scoreTipsView != null)
			{
				scoreTipsView.Clear();
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x06024E66 RID: 151142 RVA: 0x00A6CD94 File Offset: 0x00A6AF94
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

		// Token: 0x06024E67 RID: 151143 RVA: 0x00A6CDDC File Offset: 0x00A6AFDC
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

		// Token: 0x06024E68 RID: 151144 RVA: 0x00A6CE3E File Offset: 0x00A6B03E
		protected override void OnCloseWorldMapSecondaryUi()
		{
			TipsListView scoreTipsView = this.ScoreTipsView;
			if (scoreTipsView == null)
			{
				return;
			}
			scoreTipsView.Clear();
		}

		// Token: 0x06024E69 RID: 151145 RVA: 0x00A6CE50 File Offset: 0x00A6B050
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

		// Token: 0x06024E6A RID: 151146 RVA: 0x00A6CF93 File Offset: 0x00A6B193
		protected override void OnConfirmBtnClick(int index)
		{
			this.HandleTrack();
		}

		// Token: 0x0401470F RID: 83727
		[Nullable(2)]
		private ParkourMarkItem SelectedMarkItem;

		// Token: 0x04014710 RID: 83728
		[Nullable(2)]
		private TipsListView ScoreTipsView;

		// Token: 0x020094D2 RID: 38098
		[Nullable(0)]
		public static class ParkourConstants
		{
			// Token: 0x0402E79C RID: 190364
			public const string SCORE_KEY = "score";

			// Token: 0x0402E79D RID: 190365
			public const string LINE_NUMBER_KEY = "line";
		}
	}
}
