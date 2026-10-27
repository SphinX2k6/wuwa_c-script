using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.RecallQuest
{
	// Token: 0x02004F17 RID: 20247
	public static class RecallQuestDefine
	{
		// Token: 0x06033EB1 RID: 212657 RVA: 0x00C2B1B5 File Offset: 0x00C293B5
		public static ERecallQuestStatus ToStatus(int protoStatus)
		{
			return (ERecallQuestStatus)protoStatus;
		}

		// Token: 0x06033EB2 RID: 212658 RVA: 0x00C2B1B8 File Offset: 0x00C293B8
		public static QuestState ToProtoQuestState(ERecallQuestStatus status)
		{
			return (QuestState)status;
		}

		// Token: 0x06033EB3 RID: 212659 RVA: 0x00C2B1BB File Offset: 0x00C293BB
		public static EQuestStatusUpdateReason ToQuestUpdateReason(ERecallStatusUpdateReason reason)
		{
			return (EQuestStatusUpdateReason)reason;
		}

		// Token: 0x06033EB4 RID: 212660 RVA: 0x00C2B1BE File Offset: 0x00C293BE
		public static bool IsFinish(int state)
		{
			return state == 3;
		}
	}
}
