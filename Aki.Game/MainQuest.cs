using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

// Token: 0x02002641 RID: 9793
[NullableContext(1)]
[Nullable(0)]
public class MainQuest : global::Quest
{
	// Token: 0x0601411D RID: 82205 RVA: 0x0050F29E File Offset: 0x0050D49E
	public MainQuest(EQuest type, IQuest questConfig) : base(type, questConfig)
	{
	}

	// Token: 0x0601411E RID: 82206 RVA: 0x0050F2A8 File Offset: 0x0050D4A8
	public override void SetUpBehaviorTree(BaseBehaviorTree behaviorTree)
	{
		base.SetUpBehaviorTree(behaviorTree);
		behaviorTree.SetMapMarkResident(true);
	}
}
