using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

// Token: 0x02002643 RID: 9795
public class TestQuest : global::Quest
{
	// Token: 0x06014120 RID: 82208 RVA: 0x0050F2C2 File Offset: 0x0050D4C2
	[NullableContext(1)]
	public TestQuest(EQuest type, IQuest questConfig) : base(type, questConfig)
	{
	}
}
