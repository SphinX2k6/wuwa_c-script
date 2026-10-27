using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.CorniceMeeting
{
	// Token: 0x0200482D RID: 18477
	[NullableContext(1)]
	[Nullable(0)]
	public class CorniceMeetingEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x060305CC RID: 198092 RVA: 0x00B3A4B2 File Offset: 0x00B386B2
		public override string GetResourceId()
		{
			return "UiView_Huodong_Prefab";
		}

		// Token: 0x060305CD RID: 198093 RVA: 0x00B3A4B9 File Offset: 0x00B386B9
		protected override void OnStart()
		{
			this.ScoreTipsView = new TipsListView();
			this.ScoreTipsView.Initialize(base.GetVerticalLayout(5));
			base.OnStart();
		}

		// Token: 0x060305CE RID: 198094 RVA: 0x00B3A4E0 File Offset: 0x00B386E0
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			UUIItem item = base.GetItem(32);
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

		// Token: 0x060305CF RID: 198095 RVA: 0x00B3A526 File Offset: 0x00B38726
		protected override void OnBeforeDestroy()
		{
			TipsListView scoreTipsView = this.ScoreTipsView;
			if (scoreTipsView != null)
			{
				scoreTipsView.Clear();
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x060305D0 RID: 198096 RVA: 0x00B3A540 File Offset: 0x00B38740
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				CorniceMeetingMarkItem corniceMeetingMarkItem = param[0] as CorniceMeetingMarkItem;
				if (corniceMeetingMarkItem != null)
				{
					this.LayoutContext.MarkItem = corniceMeetingMarkItem;
					WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
					WorldMapSecondaryUiLayoutHelper.UpdateDesc(this.LayoutContext);
					this.UpdateButtonState();
					this.RefreshScore();
				}
			}
		}

		// Token: 0x060305D1 RID: 198097 RVA: 0x00B3A596 File Offset: 0x00B38796
		protected override void OnCloseWorldMapSecondaryUi()
		{
			TipsListView scoreTipsView = this.ScoreTipsView;
			if (scoreTipsView == null)
			{
				return;
			}
			scoreTipsView.Clear();
		}

		// Token: 0x060305D2 RID: 198098 RVA: 0x00B3A5A8 File Offset: 0x00B387A8
		private void RefreshScore()
		{
			ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			CorniceMeetingMarkItem corniceMeetingMarkItem = this.LayoutContext.MarkItem as CorniceMeetingMarkItem;
			ActivityCorniceMeetingConfig instance = ActivityCorniceMeetingConfig.Instance;
			CorniceChallenge? corniceChallenge = (instance != null) ? instance.GetCorniceMeetingChallengeByMarkId((corniceMeetingMarkItem != null) ? corniceMeetingMarkItem.MarkId : 0) : null;
			if (corniceChallenge == null)
			{
				return;
			}
			ActivityCorniceMeetingLevelEntryData levelEntryData = currentActivityData.GetLevelEntryData(corniceChallenge.Value.Id);
			if (levelEntryData == null)
			{
				return;
			}
			TipsListView scoreTipsView = this.ScoreTipsView;
			InstanceDungeonCostTip instanceDungeonCostTip = (scoreTipsView != null) ? scoreTipsView.AddItemByKey("CurrentDungeon") : null;
			if (instanceDungeonCostTip != null)
			{
				instanceDungeonCostTip.SetLeftText(ConfigMultiTextLang.GetLocalTextNew("CorniceMeetingMarkPanelCurrent", null) ?? "");
				instanceDungeonCostTip.SetRightText(ConfigMultiTextLang.GetLocalTextNew(corniceChallenge.Value.Title, null) ?? "");
				instanceDungeonCostTip.SetHelpButtonVisible(false);
			}
			TipsListView scoreTipsView2 = this.ScoreTipsView;
			InstanceDungeonCostTip instanceDungeonCostTip2 = (scoreTipsView2 != null) ? scoreTipsView2.AddItemByKey("score") : null;
			if (instanceDungeonCostTip2 != null)
			{
				instanceDungeonCostTip2.SetHelpButtonVisible(false);
				instanceDungeonCostTip2.SetLeftText(ConfigMultiTextLang.GetLocalTextNew("CorniceMeetingMarkPanelScore", null) ?? "");
				if (levelEntryData.MaxScore == 0)
				{
					instanceDungeonCostTip2.SetRightText(ConfigMultiTextLang.GetLocalTextNew("ActivityCorniceMeetingScoreNoRecord", null) ?? "");
					return;
				}
				int maxScore = levelEntryData.MaxScore;
				int maxScoreConfig = levelEntryData.GetMaxScoreConfig();
				int num = (maxScore > maxScoreConfig) ? maxScoreConfig : maxScore;
				string rightText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Text_ItemCost_Text", null) ?? "", new string[]
				{
					num.ToString(),
					maxScoreConfig.ToString()
				});
				instanceDungeonCostTip2.SetRightText(rightText);
			}
		}

		// Token: 0x060305D3 RID: 198099 RVA: 0x00B3A74A File Offset: 0x00B3894A
		private void UpdateButtonState()
		{
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext == null)
			{
				return;
			}
			layoutContext.SetConfirmBtnText("Text_TeleportFastMove_Text", Array.Empty<object>());
		}

		// Token: 0x060305D4 RID: 198100 RVA: 0x00B3A766 File Offset: 0x00B38966
		protected override void OnConfirmBtnClick(int index)
		{
			base.CloseWithCallBack(delegate
			{
				CorniceMeetingMarkItem corniceMeetingMarkItem = this.LayoutContext.MarkItem as CorniceMeetingMarkItem;
				ActivityCorniceMeetingConfig instance = ActivityCorniceMeetingConfig.Instance;
				CorniceChallenge? corniceChallenge = (instance != null) ? instance.GetCorniceMeetingChallengeByMarkId((corniceMeetingMarkItem != null) ? corniceMeetingMarkItem.MarkId : 0) : null;
				if (corniceChallenge != null)
				{
					ActivityCorniceMeetingController.Instance.CorniceMeetingChallengeTransRequest(corniceChallenge.Value.Id);
				}
			}, true);
		}

		// Token: 0x0401A02C RID: 106540
		private const string CURRENT_DUNGEON = "CurrentDungeon";

		// Token: 0x0401A02D RID: 106541
		private const string SCORE_KEY = "score";

		// Token: 0x0401A02E RID: 106542
		[Nullable(2)]
		private TipsListView ScoreTipsView;

		// Token: 0x0200AB06 RID: 43782
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033FB6 RID: 212918
			public const int CorniceMeetingPanel = 0;
		}
	}
}
