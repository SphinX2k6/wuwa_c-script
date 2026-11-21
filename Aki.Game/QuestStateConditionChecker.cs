using System;
using System.Runtime.CompilerServices;

// Token: 0x02001FEC RID: 8172
public class QuestStateConditionChecker : ISkipConditionChecker
{
	// Token: 0x06014435 RID: 82997 RVA: 0x005E830F File Offset: 0x005E650F
	[NullableContext(1)]
	public ISkipCondition<ESkipConditionType> Parse(int[] @params)
	{
		return new QuestStateConditionImpl
		{
			ConditionType = ESkipConditionType.QuestState,
			QuestId = @params[0],
			CheckQuestState = (ESkipQuestState)@params[1]
		};
	}

	// Token: 0x06014436 RID: 82998 RVA: 0x005E8330 File Offset: 0x005E6530
	[NullableContext(1)]
	public bool Check(int[] @params)
	{
		QuestStateConditionImpl questStateConditionImpl = this.Parse(@params) as QuestStateConditionImpl;
		if (questStateConditionImpl == null)
		{
			return false;
		}
		int questId = questStateConditionImpl.QuestId;
		bool checkQuestState = questStateConditionImpl.CheckQuestState != ESkipQuestState.Uncompleted;
		bool flag = QuestNewModel.Instance.CheckQuestFinished(questId);
		if (!checkQuestState)
		{
			return !flag;
		}
		return flag;
	}
}
