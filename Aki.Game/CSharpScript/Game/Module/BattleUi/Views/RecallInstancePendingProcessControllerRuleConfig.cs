using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.RecallQuest.Model;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D6C RID: 19820
	public class RecallInstancePendingProcessControllerRuleConfig : PendingProcessControllerRuleConfigBase
	{
		// Token: 0x06031BBD RID: 203709 RVA: 0x00DE7BD5 File Offset: 0x00DE5DD5
		public override bool IsActive()
		{
			return RecallQuestModel.Instance.IsInRecallInstance();
		}

		// Token: 0x06031BBE RID: 203710 RVA: 0x00DE7BE4 File Offset: 0x00DE5DE4
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
