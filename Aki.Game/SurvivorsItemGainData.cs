using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002AF2 RID: 10994
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsItemGainData : global::SurvivorsGainData
{
	// Token: 0x06016DF7 RID: 93687 RVA: 0x005CD98E File Offset: 0x005CBB8E
	public SurvivorsItemGainData(int incId, int configId, SurvivorsToken data, ESurvivorsRogueItemType type = ESurvivorsRogueItemType.Normal) : base(incId, configId)
	{
		this.Data = data;
		this.Type = type;
	}

	// Token: 0x0400A9CF RID: 43471
	public SurvivorsToken Data;
}
