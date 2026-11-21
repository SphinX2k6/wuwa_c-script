using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.CorniceMeeting
{
	// Token: 0x0200375E RID: 14174
	[NullableContext(1)]
	[Nullable(0)]
	public class CorniceMeetingEntrancePanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024D9C RID: 150940 RVA: 0x00A6A57E File Offset: 0x00A6877E
		public override string GetResourceId()
		{
			return "UiView_Huodong_Prefab";
		}

		// Token: 0x06024D9D RID: 150941 RVA: 0x00A6A585 File Offset: 0x00A68785
		protected override void OnStart()
		{
			this.ScoreTipsView = new TipsListView();
			this.ScoreTipsView.Initialize(base.GetVerticalLayout(5));
			base.OnStart();
		}

		// Token: 0x06024D9E RID: 150942 RVA: 0x00A6A5AC File Offset: 0x00A687AC
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

		// Token: 0x06024D9F RID: 150943 RVA: 0x00A6A5F2 File Offset: 0x00A687F2
		protected override void OnBeforeDestroy()
		{
			TipsListView scoreTipsView = this.ScoreTipsView;
			if (scoreTipsView != null)
			{
				scoreTipsView.Clear();
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x06024DA0 RID: 150944 RVA: 0x00A6A60C File Offset: 0x00A6880C
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

		// Token: 0x06024DA1 RID: 150945 RVA: 0x00A6A662 File Offset: 0x00A68862
		protected override void OnCloseWorldMapSecondaryUi()
		{
			TipsListView scoreTipsView = this.ScoreTipsView;
			if (scoreTipsView == null)
			{
				return;
			}
			scoreTipsView.Clear();
		}

		// Token: 0x06024DA2 RID: 150946 RVA: 0x00A6A674 File Offset: 0x00A68874
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

		// Token: 0x06024DA3 RID: 150947 RVA: 0x00A6A816 File Offset: 0x00A68A16
		private void UpdateButtonState()
		{
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext == null)
			{
				return;
			}
			layoutContext.SetConfirmBtnText("Text_TeleportFastMove_Text", Array.Empty<object>());
		}

		// Token: 0x06024DA4 RID: 150948 RVA: 0x00A6A832 File Offset: 0x00A68A32
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

		// Token: 0x040146E0 RID: 83680
		private const string CURRENT_DUNGEON = "CurrentDungeon";

		// Token: 0x040146E1 RID: 83681
		private const string SCORE_KEY = "score";

		// Token: 0x040146E2 RID: 83682
		[Nullable(2)]
		private TipsListView ScoreTipsView;

		// Token: 0x020094B5 RID: 38069
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E736 RID: 190262
			public const int CorniceMeetingPanel = 0;
		}
	}
}
