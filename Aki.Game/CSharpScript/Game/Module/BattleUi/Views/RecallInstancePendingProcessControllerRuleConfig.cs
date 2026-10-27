using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.RecallQuest.Model;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D8A RID: 23946
	public class RecallInstancePendingProcessControllerRuleConfig : PendingProcessControllerRuleConfigBase
	{
		// Token: 0x0603CC61 RID: 248929 RVA: 0x00E9738D File Offset: 0x00E9558D
		public override bool IsActive()
		{
			return RecallQuestModel.Instance.IsInRecallInstance();
		}

		// Token: 0x0603CC62 RID: 248930 RVA: 0x00E9739C File Offset: 0x00E9559C
		[NullableContext(1)]
		public override bool PendingProgressExCheck(TPendingProcess process)
		{
			MissionItemViewRefreshProcess missionItemViewRefreshProcess = process as MissionItemViewRefreshProcess;
			if (missionItemViewRefreshProcess != null)
			{
				BehaviorTreeViewShowData behaviorTreeViewShowData = missionItemViewRefreshProcess.ShowData as BehaviorTreeViewShowData;
				return behaviorTreeViewShowData == null || behaviorTreeViewShowData.BtType != BtType.Quest;
			}
			MissionItemViewStartTrackProcess missionItemViewStartTrackProcess = process as MissionItemViewStartTrackProcess;
			if (missionItemViewStartTrackProcess != null)
			{
				BehaviorTreeViewShowData behaviorTreeViewShowData2 = missionItemViewStartTrackProcess.ShowData as BehaviorTreeViewShowData;
				return behaviorTreeViewShowData2 == null || behaviorTreeViewShowData2.BtType != BtType.Quest;
			}
			ShowQuestUpdateTipsProcess showQuestUpdateTipsProcess = process as ShowQuestUpdateTipsProcess;
			if (showQuestUpdateTipsProcess == null)
			{
				return true;
			}
			int questId = showQuestUpdateTipsProcess.Info.QuestId;
			global::Quest quest = QuestNewModel.Instance.GetQuest(questId);
			return quest != null && quest.Type == EQuest.Recall;
		}
	}
}
