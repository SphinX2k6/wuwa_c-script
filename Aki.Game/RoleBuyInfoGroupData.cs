using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002764 RID: 10084
[NullableContext(2)]
[Nullable(0)]
public class RoleBuyInfoGroupData
{
	// Token: 0x06014AFA RID: 84730 RVA: 0x0053BEFE File Offset: 0x0053A0FE
	public RoleBuyInfoGroupData(RogueResGainData data1 = null, RogueResGainData data2 = null)
	{
		this.Data1 = data1;
		this.Data2 = data2;
	}

	// Token: 0x04009B6A RID: 39786
	public RogueResGainData Data1;

	// Token: 0x04009B6B RID: 39787
	public RogueResGainData Data2;
}
