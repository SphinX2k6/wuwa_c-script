using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x0200583E RID: 22590
	public class CoopPreTaskSubConditionData : CoopSubConditionDataBase
	{
		// Token: 0x06037B60 RID: 228192 RVA: 0x00F93808 File Offset: 0x00F91A08
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

		// Token: 0x06037B61 RID: 228193 RVA: 0x00F93853 File Offset: 0x00F91A53
		public override bool IsTaskDone()
		{
			return this.CoopPreQuestId != 0 && QuestNewModel.Instance.CheckQuestFinished(this.CoopPreQuestId);
		}

		// Token: 0x0401D67E RID: 120446
		public int CoopPreQuestId;
	}
}
