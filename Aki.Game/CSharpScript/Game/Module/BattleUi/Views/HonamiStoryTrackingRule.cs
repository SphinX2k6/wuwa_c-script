using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CA6 RID: 19622
	[NullableContext(1)]
	[Nullable(0)]
	internal class HonamiStoryTrackingRule : TrackingDisplayRuleBase
	{
		// Token: 0x170061CA RID: 25034
		// (get) Token: 0x06031020 RID: 200736 RVA: 0x00DAD080 File Offset: 0x00DAB280
		public override EMissionRuleId Id
		{
			get
			{
				return EMissionRuleId.HonamiStory;
			}
		}

		// Token: 0x170061CB RID: 25035
		// (get) Token: 0x06031021 RID: 200737 RVA: 0x00DAD083 File Offset: 0x00DAB283
		public override bool Enabled
		{
			get
			{
				return HonamiStoryUtil.CheckHonamiQuestOpen();
			}
		}

		// Token: 0x170061CC RID: 25036
		// (get) Token: 0x06031022 RID: 200738 RVA: 0x00DAD08A File Offset: 0x00DAB28A
		public override int Priority
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06031023 RID: 200739 RVA: 0x00DAD090 File Offset: 0x00DAB290
		public override EMissionItemView? CustomTypeCheck(IMissionItemViewShowData showData, ETreeTextExpressReason? reason = null)
		{
			BehaviorTreeViewShowData behaviorTreeViewShowData = showData as BehaviorTreeViewShowData;
			if (behaviorTreeViewShowData == null)
			{
				return null;
			}
			long id = showData.Id;
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(id), false);
			int treeConfigId = behaviorTreeViewShowData.TreeConfigId;
			if (behaviorTree == null || behaviorTree.BtType == BtType.Invalid || behaviorTree.BtType == BtType.Quest)
			{
				return null;
			}
			int curAreaId = HonamiStoryModel.Instance.CurAreaId;
			HonamiStoryArea? honamiStoryAreaConfig = HonamiStoryConfig.Instance.GetHonamiStoryAreaConfig(curAreaId);
			if (((honamiStoryAreaConfig != null) ? honamiStoryAreaConfig.GetValueOrDefault().MainBTId : 0) == treeConfigId)
			{
				return new EMissionItemView?(EMissionItemView.SecondRow);
			}
			return new EMissionItemView?(EMissionItemView.ThirdRow);
		}

		// Token: 0x06031024 RID: 200740 RVA: 0x00DAD138 File Offset: 0x00DAB338
		public override void SortShowData(List<IMissionItemViewShowData> showData)
		{
			HonamiStoryQuestDataBase curTrackTaskData = HonamiStoryModel.Instance.CurTrackTaskData;
			global::LevelPlayInfo levelPlayInfo = (curTrackTaskData != null) ? curTrackTaskData.GetLevelPlayInfo() : null;
			int? configId = (levelPlayInfo != null) ? levelPlayInfo.TreeConfigId : null;
			showData.Sort(delegate(IMissionItemViewShowData a, IMissionItemViewShowData b)
			{
				if (a.DataSource != b.DataSource)
				{
					return a.DataSource - b.DataSource;
				}
				BehaviorTreeViewShowData behaviorTreeViewShowData = a as BehaviorTreeViewShowData;
				int? configId;
				if (behaviorTreeViewShowData != null)
				{
					int treeConfigId = behaviorTreeViewShowData.TreeConfigId;
					configId = configId;
					if (treeConfigId == configId.GetValueOrDefault() & configId != null)
					{
						return 1;
					}
				}
				BehaviorTreeViewShowData behaviorTreeViewShowData2 = b as BehaviorTreeViewShowData;
				if (behaviorTreeViewShowData2 != null)
				{
					int treeConfigId2 = behaviorTreeViewShowData2.TreeConfigId;
					configId = configId;
					if (treeConfigId2 == configId.GetValueOrDefault() & configId != null)
					{
						return 1;
					}
				}
				return a.ShowPriority - b.ShowPriority;
			});
		}
	}
}
