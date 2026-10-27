using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DF6 RID: 7670
[NullableContext(1)]
[Nullable(0)]
public class HandBookQuestNode
{
	// Token: 0x0600E990 RID: 59792 RVA: 0x0037436E File Offset: 0x0037256E
	public HandBookQuestNode(string tidText = "", [Nullable(2)] string flowListName = null, int flowId = 0, int stateId = 0)
	{
		this.TidText = tidText;
		this.FlowListName = flowListName;
		this.FlowId = flowId;
		this.StateId = stateId;
	}

	// Token: 0x04006C46 RID: 27718
	public string TidText;

	// Token: 0x04006C47 RID: 27719
	[Nullable(2)]
	public string FlowListName;

	// Token: 0x04006C48 RID: 27720
	public int FlowId;

	// Token: 0x04006C49 RID: 27721
	public int StateId;
}
