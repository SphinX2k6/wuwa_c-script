using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CC4 RID: 23748
	[NullableContext(1)]
	[Nullable(0)]
	internal class HonamiStoryTrackingRule : TrackingDisplayRuleBase
	{
		// Token: 0x17008DF8 RID: 36344
		// (get) Token: 0x0603C0CB RID: 245963 RVA: 0x00E5C96C File Offset: 0x00E5AB6C
		public override EMissionRuleId Id
		{
			get
			{
				return EMissionRuleId.HonamiStory;
			}
		}

		// Token: 0x17008DF9 RID: 36345
		// (get) Token: 0x0603C0CC RID: 245964 RVA: 0x00E5C96F File Offset: 0x00E5AB6F
		public override bool Enabled
		{
			get
			{
				return HonamiStoryUtil.CheckHonamiQuestOpen();
			}
		}

		// Token: 0x17008DFA RID: 36346
		// (get) Token: 0x0603C0CD RID: 245965 RVA: 0x00E5C976 File Offset: 0x00E5AB76
		public override int Priority
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x0603C0CE RID: 245966 RVA: 0x00E5C97C File Offset: 0x00E5AB7C
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

		// Token: 0x0603C0CF RID: 245967 RVA: 0x00E5CA24 File Offset: 0x00E5AC24
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
