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
	// Token: 0x02003725 RID: 14117
	[NullableContext(2)]
	[Nullable(0)]
	public class QuestPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024BBE RID: 150462 RVA: 0x00A60302 File Offset: 0x00A5E502
		[NullableContext(1)]
		public override string GetResourceId()
		{
			return "UiView_Task_Prefab";
		}

		// Token: 0x06024BBF RID: 150463 RVA: 0x00A6030C File Offset: 0x00A5E50C
		protected override UniTask OnBeforeStartAsync()
		{
			QuestPanel.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuestPanel.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024BC0 RID: 150464 RVA: 0x00A60350 File Offset: 0x00A5E550
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

		// Token: 0x06024BC1 RID: 150465 RVA: 0x00A6039C File Offset: 0x00A5E59C
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

		// Token: 0x06024BC2 RID: 150466 RVA: 0x00A60405 File Offset: 0x00A5E605
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

		// Token: 0x06024BC3 RID: 150467 RVA: 0x00A60434 File Offset: 0x00A5E634
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

		// Token: 0x06024BC4 RID: 150468 RVA: 0x00A604E0 File Offset: 0x00A5E6E0
		protected override void OnCloseWorldMapSecondaryUi()
		{
			TipsListView conditionTipsView = this.ConditionTipsView;
			if (conditionTipsView == null)
			{
				return;
			}
			conditionTipsView.Clear();
		}

		// Token: 0x06024BC5 RID: 150469 RVA: 0x00A604F2 File Offset: 0x00A5E6F2
		public override UUIItem GetGuideFocusUiItem()
		{
			UUIButtonComponent button = base.GetButton(29);
			if (button == null)
			{
				return null;
			}
			return button.GetRootComponent();
		}

		// Token: 0x06024BC6 RID: 150470 RVA: 0x00A60508 File Offset: 0x00A5E708
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

		// Token: 0x06024BC7 RID: 150471 RVA: 0x00A60664 File Offset: 0x00A5E864
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

		// Token: 0x06024BC8 RID: 150472 RVA: 0x00A60760 File Offset: 0x00A5E960
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

		// Token: 0x06024BC9 RID: 150473 RVA: 0x00A607FD File Offset: 0x00A5E9FD
		private bool NeedShowReward()
		{
			return this.SelectedMarkItem == null || this.SelectedMarkItem.BtType.GetValueOrDefault() != BtType.Recall;
		}

		// Token: 0x06024BCA RID: 150474 RVA: 0x00A60820 File Offset: 0x00A5EA20
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

		// Token: 0x06024BCB RID: 150475 RVA: 0x00A608C0 File Offset: 0x00A5EAC0
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

		// Token: 0x06024BCC RID: 150476 RVA: 0x00A60A1A File Offset: 0x00A5EC1A
		protected override void OnRefreshPanel()
		{
			this.UpdateTrackButton();
		}

		// Token: 0x06024BCD RID: 150477 RVA: 0x00A60A24 File Offset: 0x00A5EC24
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

		// Token: 0x06024BCE RID: 150478 RVA: 0x00A60A73 File Offset: 0x00A5EC73
		protected override bool IsFastReturnAvailable()
		{
			if (this.QuestId == 0)
			{
				return false;
			}
			global::Quest quest = QuestNewModel.Instance.GetQuest(this.QuestId);
			return FastReturnUtil.Resolve((quest != null) ? quest.Tree : null) != null;
		}

		// Token: 0x0401463D RID: 83517
		[Nullable(1)]
		private const string QUEST_CONDITION_KEY = "questCondition";

		// Token: 0x0401463E RID: 83518
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private CommonItemSmallItemGrid[] RewardItemList;

		// Token: 0x0401463F RID: 83519
		private List<TItem> QuestRewardList;

		// Token: 0x04014640 RID: 83520
		private bool IsQuestTracked;

		// Token: 0x04014641 RID: 83521
		private int QuestId;

		// Token: 0x04014642 RID: 83522
		private int QuestBehaviorId;

		// Token: 0x04014643 RID: 83523
		private TaskMarkItem SelectedMarkItem;

		// Token: 0x04014644 RID: 83524
		private RewardItemBar RewardItemsView;

		// Token: 0x04014645 RID: 83525
		private TipsListView ConditionTipsView;

		// Token: 0x0200946D RID: 37997
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E673 RID: 190067
			public const int QuestPanel = 0;
		}
	}
}
