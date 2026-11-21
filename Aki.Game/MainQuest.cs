using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

// Token: 0x02001B2C RID: 6956
[NullableContext(1)]
[Nullable(0)]
public class MainQuest : global::Quest
{
	// Token: 0x060115FF RID: 71167 RVA: 0x0051E05E File Offset: 0x0051C25E
	public MainQuest(EQuest type, IQuest questConfig) : base(type, questConfig)
	{
	}

	// Token: 0x06011600 RID: 71168 RVA: 0x0051E068 File Offset: 0x0051C268
	public override void SetUpBehaviorTree(BaseBehaviorTree behaviorTree)
	{
		base.SetUpBehaviorTree(behaviorTree);
		behaviorTree.SetMapMarkResident(true);
	}
}
