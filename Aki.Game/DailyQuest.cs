using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

// Token: 0x0200263E RID: 9790
[NullableContext(1)]
[Nullable(0)]
public class DailyQuest : global::Quest
{
	// Token: 0x060140F5 RID: 82165 RVA: 0x0050E8A1 File Offset: 0x0050CAA1
	public DailyQuest(EQuest type, IQuest questConfig) : base(type, questConfig)
	{
	}

	// Token: 0x060140F6 RID: 82166 RVA: 0x0050E8AB File Offset: 0x0050CAAB
	public override void SetUpBehaviorTree(BaseBehaviorTree behaviorTree)
	{
		base.SetUpBehaviorTree(behaviorTree);
		behaviorTree.SetMapMarkResident(true);
	}

	// Token: 0x04009728 RID: 38696
	public bool TriggerQuestTips;
}
