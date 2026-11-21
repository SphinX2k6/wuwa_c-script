using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D5F RID: 19807
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestUpdateTipsShowData
	{
		// Token: 0x1700621E RID: 25118
		// (get) Token: 0x06031B51 RID: 203601 RVA: 0x00DE5F58 File Offset: 0x00DE4158
		public IMissionItemViewShowData MissionViewShowData { get; }

		// Token: 0x1700621F RID: 25119
		// (get) Token: 0x06031B52 RID: 203602 RVA: 0x00DE5F60 File Offset: 0x00DE4160
		public bool IsSkipAnim { get; }

		// Token: 0x17006220 RID: 25120
		// (get) Token: 0x06031B53 RID: 203603 RVA: 0x00DE5F68 File Offset: 0x00DE4168
		public bool IsNewQuest { get; }

		// Token: 0x17006221 RID: 25121
		// (get) Token: 0x06031B54 RID: 203604 RVA: 0x00DE5F70 File Offset: 0x00DE4170
		public int NodeId { get; }

		// Token: 0x06031B55 RID: 203605 RVA: 0x00DE5F78 File Offset: 0x00DE4178
		public QuestUpdateTipsShowData(IMissionItemViewShowData missionViewShowData, bool isSkipAnim, bool isNewQuest, int nodeId)
		{
			this.MissionViewShowData = missionViewShowData;
			this.IsSkipAnim = isSkipAnim;
			this.IsNewQuest = isNewQuest;
			this.NodeId = nodeId;
		}

		// Token: 0x17006222 RID: 25122
		// (get) Token: 0x06031B56 RID: 203606 RVA: 0x00DE5FA0 File Offset: 0x00DE41A0
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
