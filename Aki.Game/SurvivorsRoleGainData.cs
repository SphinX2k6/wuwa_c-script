using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200206C RID: 8300
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRoleGainData : global::SurvivorsGainData
{
	// Token: 0x06014822 RID: 84002 RVA: 0x005FA367 File Offset: 0x005F8567
	public SurvivorsRoleGainData(int incId, int configId, SurvivorsRole data, ESurvivorsRogueItemType type = ESurvivorsRogueItemType.Character) : base(incId, configId)
	{
		this.Data = data;
		this.Type = type;
	}

	// Token: 0x06014823 RID: 84003 RVA: 0x005FA380 File Offset: 0x005F8580
	public int GetCurrentEvolveId()
	{
		if (this.Data.Evolves.Count == 0)
		{
			return 0;
		}
		return this.Data.Evolves[this.Data.Evolves.Count - 1];
	}

	// Token: 0x0400ADD3 RID: 44499
	public SurvivorsRole Data;
}
