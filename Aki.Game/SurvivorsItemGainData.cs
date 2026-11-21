using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200206E RID: 8302
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsItemGainData : global::SurvivorsGainData
{
	// Token: 0x06014828 RID: 84008 RVA: 0x005FA50E File Offset: 0x005F870E
	public SurvivorsItemGainData(int incId, int configId, SurvivorsToken data, ESurvivorsRogueItemType type = ESurvivorsRogueItemType.Normal) : base(incId, configId)
	{
		this.Data = data;
		this.Type = type;
	}

	// Token: 0x0400ADD5 RID: 44501
	public SurvivorsToken Data;
}
