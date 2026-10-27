using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Controller;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.QuestPanel
{
	// Token: 0x020047F4 RID: 18420
	[NullableContext(2)]
	[Nullable(0)]
	public class QuestPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x060303EE RID: 197614 RVA: 0x00B30362 File Offset: 0x00B2E562
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiView_Task_Prefab";
		}

		// Token: 0x060303EF RID: 197615 RVA: 0x00B3036C File Offset: 0x00B2E56C
		protected override UniTask OnBeforeStartAsync()
		{
			QuestPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuestPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060303F0 RID: 197616 RVA: 0x00B303B0 File Offset: 0x00B2E5B0
		protected override void OnStart()
		{
			this.QuestRewardList = new List<TItem>();
			this.RewardItemList = Array.Empty<CommonItemSmallItemGrid>();
			this.ConditionTipsView = new TipsListView();
			TipsListView conditionTipsView = this.ConditionTipsView;
			if (conditionTipsView != null)
			{
				conditionTipsView.Initialize(base.GetVerticalLayout(5));
			}
			base.OnStart();
		}

		// Token: 0x060303F1 RID: 197617 RVA: 0x00B303FC File Offset: 0x00B2E5FC
		protected override void OnBeforeDestroy()
		{
			if (this.RewardItemList != null)
			{
				foreach (CommonItemSmallItemGrid child in this.RewardItemList)
				{
					base.AddChild(child);
				}
				this.RewardItemList = Array.Empty<CommonItemSmallItemGrid>();
			}
			RewardItemBar rewardItemsView = this.RewardItemsView;
			if (rewardItemsView != null)
			{
				rewardItemsView.Destroy(null);
			}
			TipsListView conditionTipsView = this.ConditionTipsView;
			if (conditionTipsView != null)
			{
				conditionTipsView.Clear();
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x060303F2 RID: 197618 RVA: 0x00B30465 File Offset: 0x00B2E665
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(14);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x060303F3 RID: 197619 RVA: 0x00B30494 File Offset: 0x00B2E694
		[NullableContext(1)]
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0)
			{
				TaskMarkItem taskMarkItem = param[0] as TaskMarkItem;
				if (taskMarkItem != null)
				{
					this.QuestId = ((taskMarkItem.BtType.GetValueOrDefault() == BtType.Quest || taskMarkItem.BtType.GetValueOrDefault() == BtType.Recall) ? taskMarkItem.TreeConfigId : 0);
					this.QuestBehaviorId = taskMarkItem.NodeId;
					this.SelectedMarkItem = taskMarkItem;
					this.LayoutContext.MarkItem = taskMarkItem;
					this.UpdateQuestInfo();
					this.UpdateTrackButton();
					WorldMapSecondaryUiLayoutHelper.UpdateIcon(this.LayoutContext);
					base.UpdateRightDownIconActive();
					bool flag = base.UpdateQuickGoto();
					WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
					if (layoutContext == null)
					{
						return;
					}
					layoutContext.SetConfirmBtnActive(!flag);
				}
			}
		}

		// Token: 0x060303F4 RID: 197620 RVA: 0x00B30540 File Offset: 0x00B2E740
		protected override void OnCloseWorldMapSecondaryUi()
		{
			TipsListView conditionTipsView = this.ConditionTipsView;
			if (conditionTipsView == null)
			{
				return;
			}
			conditionTipsView.Clear();
		}

		// Token: 0x060303F5 RID: 197621 RVA: 0x00B30552 File Offset: 0x00B2E752
		public override UUIItem GetGuideFocusUiItem()
		{
			UUIButtonComponent button = base.GetButton(29);
			if (button == null)
			{
				return null;
			}
			return button.GetRootComponent();
		}

		// Token: 0x060303F6 RID: 197622 RVA: 0x00B30568 File Offset: 0x00B2E768
		private void UpdateQuestInfo()
		{
			QuestNewModel instance = QuestNewModel.Instance;
			bool quest = instance.GetQuest(this.QuestId) != null;
			string questName = instance.GetQuestName(this.QuestId);
			TaskMarkItem selectedMarkItem = this.SelectedMarkItem;
			int valueOrDefault = ((selectedMarkItem != null) ? selectedMarkItem.InstanceDungeonId : null).GetValueOrDefault();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(valueOrDefault);
			int num = (config != null) ? config.GetValueOrDefault().RelatedQuestId : 0;
			IQuest quest2 = (num != 0) ? instance.GetQuestConfig(num) : null;
			if (quest && !string.IsNullOrEmpty(questName))
			{
				base.GetText(1).SetText(questName, true);
				base.GetText(4).SetText(instance.GetQuestDetails(this.QuestId), true);
			}
			else if (quest2 != null)
			{
				base.GetText(1).ShowTextNew(quest2.TidName);
				base.GetText(4).ShowTextNew(quest2.TidDesc);
			}
			else
			{
				base.GetText(1).SetText(instance.GetQuestNameFromConfig(this.QuestId), true);
				base.GetText(4).SetText(instance.GetQuestDetailsFromConfig(this.QuestId), true);
			}
			if (this.QuestBehaviorId == 0)
			{
				this.RewardItemsView.SetUiActive(false);
				return;
			}
			RewardItemBar rewardItemsView = this.RewardItemsView;
			if (rewardItemsView != null)
			{
				rewardItemsView.SetUiActive(true);
			}
			this.UpdateDetailsBehavior(this.QuestId, this.QuestBehaviorId);
			this.UpdateDetailsRewards();
		}

		// Token: 0x060303F7 RID: 197623 RVA: 0x00B306C4 File Offset: 0x00B2E8C4
		protected override void OnTrackBtnClick(int index)
		{
			base.CheckAndShowCrossMapTips(this.SelectedMarkItem);
			InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
			TaskMarkItem selectedMarkItem = this.SelectedMarkItem;
			InstanceDungeon? config = instance.GetConfig(((selectedMarkItem != null) ? selectedMarkItem.InstanceDungeonId : null).GetValueOrDefault());
			if (this.QuestBehaviorId == 0)
			{
				MapController instance2 = MapController.Instance;
				if (instance2 != null)
				{
					TrackMapMarkParams trackMapMarkParams = new TrackMapMarkParams();
					trackMapMarkParams.MarkType = EMarkType.Quest;
					TaskMarkItem selectedMarkItem2 = this.SelectedMarkItem;
					trackMapMarkParams.MarkId = ((selectedMarkItem2 != null) ? selectedMarkItem2.MarkId : 0);
					trackMapMarkParams.Track = !this.IsQuestTracked;
					instance2.RequestTrackMapMark(trackMapMarkParams, null);
				}
				this.IsQuestTracked = !this.IsQuestTracked;
				base.Close();
				return;
			}
			int questId = this.QuestId;
			int num = (config != null) ? config.GetValueOrDefault().RelatedQuestId : 0;
			if (num != 0)
			{
				questId = num;
			}
			QuestNewController instance3 = QuestNewController.Instance;
			if (instance3 == null)
			{
				return;
			}
			instance3.RequestTrackQuest(questId, !this.IsQuestTracked, ERequestTrackOperate.Manual, ESetTrackReason.None, delegate
			{
				this.UpdateTrackButton();
				base.Close();
			});
		}

		// Token: 0x060303F8 RID: 197624 RVA: 0x00B307C0 File Offset: 0x00B2E9C0
		private void UpdateDetailsBehavior(int questId, int nodeId)
		{
			QuestNewModel instance = QuestNewModel.Instance;
			global::Quest quest = (instance != null) ? instance.GetQuest(questId) : null;
			if (quest == null)
			{
				return;
			}
			GeneralLogicTreeController instance2 = GeneralLogicTreeController.Instance;
			string rightText = ((instance2 != null) ? instance2.GetNodeTrackText(quest.TreeId.GetValueOrDefault(), nodeId) : null) ?? "";
			TipsListView conditionTipsView = this.ConditionTipsView;
			InstanceDungeonCostTip instanceDungeonCostTip = (conditionTipsView != null) ? conditionTipsView.AddItemByKey("questCondition") : null;
			if (instanceDungeonCostTip != null)
			{
				instanceDungeonCostTip.SetHelpButtonVisible(false);
			}
			if (instanceDungeonCostTip != null)
			{
				instanceDungeonCostTip.SetLeftText(ConfigMultiTextLang.GetLocalTextNew("TowerProcess", null) ?? "");
			}
			if (instanceDungeonCostTip == null)
			{
				return;
			}
			instanceDungeonCostTip.SetRightText(rightText);
		}

		// Token: 0x060303F9 RID: 197625 RVA: 0x00B3085D File Offset: 0x00B2EA5D
		private bool NeedShowReward()
		{
			return this.SelectedMarkItem == null || this.SelectedMarkItem.BtType.GetValueOrDefault() != BtType.Recall;
		}

		// Token: 0x060303FA RID: 197626 RVA: 0x00B30880 File Offset: 0x00B2EA80
		private void UpdateDetailsRewards()
		{
			this.QuestRewardList = new List<TItem>();
			QuestNewModel instance = QuestNewModel.Instance;
			List<TItem> list = instance.GetDisplayRewardCommonInfo(this.QuestId) ?? instance.GetDisplayRewardCommonInfoFromQuestConfig(this.QuestId);
			if (list != null && this.NeedShowReward())
			{
				this.QuestRewardList = list;
				UUIItem uuiitem = base.GetVerticalLayout(7).RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(true);
				}
				this.RewardItemsView.RebuildRewardsByData(this.QuestRewardList);
				return;
			}
			UUIItem uuiitem2 = base.GetVerticalLayout(7).RootUIComp.Get();
			if (uuiitem2 == null)
			{
				return;
			}
			uuiitem2.SetUIActive(false);
		}

		// Token: 0x060303FB RID: 197627 RVA: 0x00B30920 File Offset: 0x00B2EB20
		private void UpdateTrackButton()
		{
			if (this.QuestBehaviorId != 0)
			{
				InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
				InstanceDungeon? instanceDungeon;
				if (instance == null)
				{
					instanceDungeon = null;
				}
				else
				{
					TaskMarkItem selectedMarkItem = this.SelectedMarkItem;
					instanceDungeon = instance.GetConfig(((selectedMarkItem != null) ? selectedMarkItem.InstanceDungeonId : null).GetValueOrDefault());
				}
				InstanceDungeon? instanceDungeon2 = instanceDungeon;
				int num = (instanceDungeon2 != null) ? instanceDungeon2.GetValueOrDefault().RelatedQuestId : 0;
				if (num != 0)
				{
					QuestNewModel instance2 = QuestNewModel.Instance;
					this.IsQuestTracked = (instance2 != null && instance2.IsTrackingQuest(num));
				}
				else
				{
					QuestNewModel instance3 = QuestNewModel.Instance;
					this.IsQuestTracked = (instance3 != null && instance3.IsTrackingQuest(this.QuestId));
				}
			}
			else
			{
				TaskMarkItem selectedMarkItem2 = this.SelectedMarkItem;
				int num2 = (selectedMarkItem2 != null) ? selectedMarkItem2.MarkId : 0;
				MapModel instance4 = MapModel.Instance;
				TrackMapMarkParams trackMapMarkParams = (instance4 != null) ? instance4.GetCurTrackMark() : null;
				if (trackMapMarkParams == null)
				{
					this.IsQuestTracked = false;
				}
				else
				{
					this.IsQuestTracked = (trackMapMarkParams.MarkId == num2);
				}
			}
			TextConfig instance5 = TextConfig.Instance;
			string textId = (instance5 != null) ? instance5.GetTextContentIdById(this.IsQuestTracked ? "InstanceDungeonEntranceCancelTrack" : "InstanceDungeonEntranceTrack") : null;
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext != null)
			{
				layoutContext.SetConfirmBtnText(textId, Array.Empty<object>());
			}
			ButtonItem trackBtn = this.TrackBtn;
			if (trackBtn == null)
			{
				return;
			}
			trackBtn.SetLocalText(this.IsQuestTracked ? "InstanceDungeonEntranceCancelTrack" : "InstanceDungeonEntranceTrack", Array.Empty<object>());
		}

		// Token: 0x060303FC RID: 197628 RVA: 0x00B30A7A File Offset: 0x00B2EC7A
		protected override void OnRefreshPanel()
		{
			this.UpdateTrackButton();
		}

		// Token: 0x060303FD RID: 197629 RVA: 0x00B30A84 File Offset: 0x00B2EC84
		protected override void HandleQuickGoto()
		{
			if (this.QuestId != 0)
			{
				global::Quest quest = QuestNewModel.Instance.GetQuest(this.QuestId);
				BaseBehaviorTree baseBehaviorTree = (quest != null) ? quest.Tree : null;
				FastReturnResolved fastReturnResolved = FastReturnUtil.Resolve(baseBehaviorTree);
				if (baseBehaviorTree != null && fastReturnResolved != null)
				{
					FastReturnUtil.Trigger(baseBehaviorTree, fastReturnResolved, true, null);
					return;
				}
			}
			base.HandleQuickGoto();
		}

		// Token: 0x060303FE RID: 197630 RVA: 0x00B30AD3 File Offset: 0x00B2ECD3
		protected override bool IsFastReturnAvailable()
		{
			if (this.QuestId == 0)
			{
				return false;
			}
			global::Quest quest = QuestNewModel.Instance.GetQuest(this.QuestId);
			return FastReturnUtil.Resolve((quest != null) ? quest.Tree : null) != null;
		}

		// Token: 0x04019F89 RID: 106377
		[Nullable(1)]
		private const string QUEST_CONDITION_KEY = "questCondition";

		// Token: 0x04019F8A RID: 106378
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private CommonItemSmallItemGrid[] RewardItemList;

		// Token: 0x04019F8B RID: 106379
		private List<TItem> QuestRewardList;

		// Token: 0x04019F8C RID: 106380
		private bool IsQuestTracked;

		// Token: 0x04019F8D RID: 106381
		private int QuestId;

		// Token: 0x04019F8E RID: 106382
		private int QuestBehaviorId;

		// Token: 0x04019F8F RID: 106383
		private TaskMarkItem SelectedMarkItem;

		// Token: 0x04019F90 RID: 106384
		private RewardItemBar RewardItemsView;

		// Token: 0x04019F91 RID: 106385
		private TipsListView ConditionTipsView;

		// Token: 0x0200AABC RID: 43708
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033EF0 RID: 212720
			public const int QuestPanel = 0;
		}
	}
}
