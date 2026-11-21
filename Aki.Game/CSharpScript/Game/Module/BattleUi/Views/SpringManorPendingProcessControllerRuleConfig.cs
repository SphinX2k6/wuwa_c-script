using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D6B RID: 19819
	public class SpringManorPendingProcessControllerRuleConfig : PendingProcessControllerRuleConfigBase
	{
		// Token: 0x06031BBA RID: 203706 RVA: 0x00DE7AD5 File Offset: 0x00DE5CD5
		public override bool IsActive()
		{
			return SpringManorModel.Instance.CheckInInstance();
		}

		// Token: 0x06031BBB RID: 203707 RVA: 0x00DE7AE4 File Offset: 0x00DE5CE4
		[NullableContext(1)]
		public override bool PendingProgressExCheck(TPendingProcess process)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			MissionItemViewStartTrackProcess missionItemViewStartTrackProcess = process as MissionItemViewStartTrackProcess;
			if (missionItemViewStartTrackProcess == null)
			{
				MissionItemViewRefreshProcess missionItemViewRefreshProcess = process as MissionItemViewRefreshProcess;
				if (missionItemViewRefreshProcess == null)
				{
					ShowQuestUpdateTipsProcess showQuestUpdateTipsProcess = process as ShowQuestUpdateTipsProcess;
					return showQuestUpdateTipsProcess == null || instance.IsMainQuest(showQuestUpdateTipsProcess.Info.QuestId);
				}
				BehaviorTreeViewShowData behaviorTreeViewShowData = missionItemViewRefreshProcess.ShowData as BehaviorTreeViewShowData;
				if (behaviorTreeViewShowData == null)
				{
					return false;
				}
				EMissionItemView? emissionItemView = BattleUiModel.Instance.CheckMissionViewItem(missionItemViewRefreshProcess.ShowData, new ETreeTextExpressReason?(ETreeTextExpressReason.None));
				return emissionItemView != null || emissionItemView.GetValueOrDefault() == EMissionItemView.ThirdRow || instance.IsActivityQuest(behaviorTreeViewShowData.TreeConfigId);
			}
			else
			{
				BehaviorTreeViewShowData behaviorTreeViewShowData2 = missionItemViewStartTrackProcess.ShowData as BehaviorTreeViewShowData;
				if (behaviorTreeViewShowData2 == null)
				{
					return false;
				}
				EMissionItemView? emissionItemView2 = BattleUiModel.Instance.CheckMissionViewItem(behaviorTreeViewShowData2, new ETreeTextExpressReason?(missionItemViewStartTrackProcess.Reason));
				return emissionItemView2 != null || emissionItemView2.GetValueOrDefault() == EMissionItemView.ThirdRow || instance.IsActivityQuest(behaviorTreeViewShowData2.TreeConfigId);
			}
		}
	}
}
