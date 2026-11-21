using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001C4F RID: 7247
[NullableContext(2)]
[Nullable(0)]
public class RoleBuyInfoGroupData
{
	// Token: 0x06011FDD RID: 73693 RVA: 0x0054AD0E File Offset: 0x00548F0E
	public RoleBuyInfoGroupData(RogueResGainData data1 = null, RogueResGainData data2 = null)
	{
		this.Data1 = data1;
		this.Data2 = data2;
	}

	// Token: 0x04009CC2 RID: 40130
	public RogueResGainData Data1;

	// Token: 0x04009CC3 RID: 40131
	public RogueResGainData Data2;
}
