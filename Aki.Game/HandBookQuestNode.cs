using System;
using System.Runtime.CompilerServices;

// Token: 0x020012B8 RID: 4792
[NullableContext(1)]
[Nullable(0)]
public class HandBookQuestNode
{
	// Token: 0x0600BDAF RID: 48559 RVA: 0x00380076 File Offset: 0x0037E276
	public HandBookQuestNode(string tidText = "", [Nullable(2)] string flowListName = null, int flowId = 0, int stateId = 0)
	{
		this.TidText = tidText;
		this.FlowListName = flowListName;
		this.FlowId = flowId;
		this.StateId = stateId;
	}

	// Token: 0x04006D27 RID: 27943
	public string TidText;

	// Token: 0x04006D28 RID: 27944
	[Nullable(2)]
	public string FlowListName;

	// Token: 0x04006D29 RID: 27945
	public int FlowId;

	// Token: 0x04006D2A RID: 27946
	public int StateId;
}
