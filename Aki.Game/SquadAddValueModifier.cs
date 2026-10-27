using System;

// Token: 0x02003298 RID: 12952
public class SquadAddValueModifier : ISquadModifier
{
	// Token: 0x170026BD RID: 9917
	// (get) Token: 0x0601C0A0 RID: 114848 RVA: 0x007CB9C8 File Offset: 0x007C9BC8
	public ESquadCalcPolicy Type
	{
		get
		{
			return ESquadCalcPolicy.AddValue;
		}
	}

	// Token: 0x0400DD9C RID: 56732
	public float Value;
}
