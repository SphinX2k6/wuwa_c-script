using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.RecallQuest
{
	// Token: 0x02003EE0 RID: 16096
	public static class RecallQuestDefine
	{
		// Token: 0x06028D1C RID: 167196 RVA: 0x00B74829 File Offset: 0x00B72A29
		public static ERecallQuestStatus ToStatus(int protoStatus)
		{
			return (ERecallQuestStatus)protoStatus;
		}

		// Token: 0x06028D1D RID: 167197 RVA: 0x00B7482C File Offset: 0x00B72A2C
		public static QuestState ToProtoQuestState(ERecallQuestStatus status)
		{
			return (QuestState)status;
		}

		// Token: 0x06028D1E RID: 167198 RVA: 0x00B7482F File Offset: 0x00B72A2F
		public static EQuestStatusUpdateReason ToQuestUpdateReason(ERecallStatusUpdateReason reason)
		{
			return (EQuestStatusUpdateReason)reason;
		}

		// Token: 0x06028D1F RID: 167199 RVA: 0x00B74832 File Offset: 0x00B72A32
		public static bool IsFinish(int state)
		{
			return state == 3;
		}
	}
}
