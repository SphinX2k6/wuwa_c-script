using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

// Token: 0x02001B2E RID: 6958
public class TestQuest : global::Quest
{
	// Token: 0x06011602 RID: 71170 RVA: 0x0051E082 File Offset: 0x0051C282
	[NullableContext(1)]
	public TestQuest(EQuest type, IQuest questConfig) : base(type, questConfig)
	{
	}
}
