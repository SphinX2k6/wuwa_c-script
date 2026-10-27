using System;

// Token: 0x02003299 RID: 12953
public class SquadAddRateModifier : ISquadModifier
{
	// Token: 0x170026BE RID: 9918
	// (get) Token: 0x0601C0A2 RID: 114850 RVA: 0x007CB9D3 File Offset: 0x007C9BD3
	public ESquadCalcPolicy Type
	{
		get
		{
			return ESquadCalcPolicy.AddRate;
		}
	}

	// Token: 0x0400DD9D RID: 56733
	public float Value;
}
