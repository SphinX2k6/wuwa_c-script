using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A71 RID: 10865
public class QuestStateConditionChecker : ISkipConditionChecker
{
	// Token: 0x06016A14 RID: 92692 RVA: 0x005BC187 File Offset: 0x005BA387
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

	// Token: 0x06016A15 RID: 92693 RVA: 0x005BC1A8 File Offset: 0x005BA3A8
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
