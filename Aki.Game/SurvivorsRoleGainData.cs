using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002AF0 RID: 10992
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRoleGainData : global::SurvivorsGainData
{
	// Token: 0x06016DF1 RID: 93681 RVA: 0x005CD7E7 File Offset: 0x005CB9E7
	public SurvivorsRoleGainData(int incId, int configId, SurvivorsRole data, ESurvivorsRogueItemType type = ESurvivorsRogueItemType.Character) : base(incId, configId)
	{
		this.Data = data;
		this.Type = type;
	}

	// Token: 0x06016DF2 RID: 93682 RVA: 0x005CD800 File Offset: 0x005CBA00
	public int GetCurrentEvolveId()
	{
		if (this.Data.Evolves.Count == 0)
		{
			return 0;
		}
		return this.Data.Evolves[this.Data.Evolves.Count - 1];
	}

	// Token: 0x0400A9CD RID: 43469
	public SurvivorsRole Data;
}
