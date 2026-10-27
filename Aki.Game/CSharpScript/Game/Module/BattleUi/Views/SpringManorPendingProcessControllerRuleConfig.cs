using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D89 RID: 23945
	public class SpringManorPendingProcessControllerRuleConfig : PendingProcessControllerRuleConfigBase
	{
		// Token: 0x0603CC5E RID: 248926 RVA: 0x00E9728D File Offset: 0x00E9548D
		public override bool IsActive()
		{
			return SpringManorModel.Instance.CheckInInstance();
		}

		// Token: 0x0603CC5F RID: 248927 RVA: 0x00E9729C File Offset: 0x00E9549C
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
