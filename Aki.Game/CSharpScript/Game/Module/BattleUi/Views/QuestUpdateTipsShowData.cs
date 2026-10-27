using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D7D RID: 23933
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestUpdateTipsShowData
	{
		// Token: 0x17008E4C RID: 36428
		// (get) Token: 0x0603CBF5 RID: 248821 RVA: 0x00E95710 File Offset: 0x00E93910
		public IMissionItemViewShowData MissionViewShowData { get; }

		// Token: 0x17008E4D RID: 36429
		// (get) Token: 0x0603CBF6 RID: 248822 RVA: 0x00E95718 File Offset: 0x00E93918
		public bool IsSkipAnim { get; }

		// Token: 0x17008E4E RID: 36430
		// (get) Token: 0x0603CBF7 RID: 248823 RVA: 0x00E95720 File Offset: 0x00E93920
		public bool IsNewQuest { get; }

		// Token: 0x17008E4F RID: 36431
		// (get) Token: 0x0603CBF8 RID: 248824 RVA: 0x00E95728 File Offset: 0x00E93928
		public int NodeId { get; }

		// Token: 0x0603CBF9 RID: 248825 RVA: 0x00E95730 File Offset: 0x00E93930
		public QuestUpdateTipsShowData(IMissionItemViewShowData missionViewShowData, bool isSkipAnim, bool isNewQuest, int nodeId)
		{
			this.MissionViewShowData = missionViewShowData;
			this.IsSkipAnim = isSkipAnim;
			this.IsNewQuest = isNewQuest;
			this.NodeId = nodeId;
		}

		// Token: 0x17008E50 RID: 36432
		// (get) Token: 0x0603CBFA RID: 248826 RVA: 0x00E95758 File Offset: 0x00E93958
		public int QuestId
		{
			get
			{
				int result = 0;
				BehaviorTreeViewShowData behaviorTreeViewShowData = this.MissionViewShowData as BehaviorTreeViewShowData;
				if (behaviorTreeViewShowData != null)
				{
					result = behaviorTreeViewShowData.TreeConfigId;
				}
				else
				{
					LackResourceQuestViewShowData lackResourceQuestViewShowData = this.MissionViewShowData as LackResourceQuestViewShowData;
					if (lackResourceQuestViewShowData != null)
					{
						result = (int)lackResourceQuestViewShowData.Id;
					}
				}
				return result;
			}
		}
	}
}
