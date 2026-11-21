using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

// Token: 0x02001B31 RID: 6961
public class PoiQuest : global::Quest
{
	// Token: 0x06011605 RID: 71173 RVA: 0x0051E0A0 File Offset: 0x0051C2A0
	[NullableContext(1)]
	public PoiQuest(EQuest type, IQuest questConfig) : base(type, questConfig)
	{
	}
}
