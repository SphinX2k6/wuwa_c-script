using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068EE RID: 26862
	public class CoopPreTaskSubConditionData : CoopSubConditionDataBase
	{
		// Token: 0x06043008 RID: 274440 RVA: 0x010521E0 File Offset: 0x010503E0
		public CoopPreTaskSubConditionData(int id, ECoopSubConditionType taskType) : base(id, taskType)
		{
			CoopTaskConfig? coopTaskConfigById = CoopConfig.Instance.GetCoopTaskConfigById(id);
			if (coopTaskConfigById == null)
			{
				return;
			}
			this.CoopPreQuestId = coopTaskConfigById.Value.CoopPreQuest;
			this.Title = "Coop_Role_Condition_Task";
		}

		// Token: 0x06043009 RID: 274441 RVA: 0x0105222B File Offset: 0x0105042B
		public override bool IsTaskDone()
		{
			return this.CoopPreQuestId != 0 && QuestNewModel.Instance.CheckQuestFinished(this.CoopPreQuestId);
		}

		// Token: 0x04022E22 RID: 142882
		public int CoopPreQuestId;
	}
}
