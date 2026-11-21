using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

// Token: 0x02001B29 RID: 6953
[NullableContext(1)]
[Nullable(0)]
public class DailyQuest : global::Quest
{
	// Token: 0x060115D7 RID: 71127 RVA: 0x0051D661 File Offset: 0x0051B861
	public DailyQuest(EQuest type, IQuest questConfig) : base(type, questConfig)
	{
	}

	// Token: 0x060115D8 RID: 71128 RVA: 0x0051D66B File Offset: 0x0051B86B
	public override void SetUpBehaviorTree(BaseBehaviorTree behaviorTree)
	{
		base.SetUpBehaviorTree(behaviorTree);
		behaviorTree.SetMapMarkResident(true);
	}

	// Token: 0x04009880 RID: 39040
	public bool TriggerQuestTips;
}
