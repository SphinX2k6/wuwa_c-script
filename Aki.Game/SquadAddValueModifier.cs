using System;

// Token: 0x02002809 RID: 10249
public class SquadAddValueModifier : ISquadModifier
{
	// Token: 0x17002997 RID: 10647
	// (get) Token: 0x06019CCE RID: 105678 RVA: 0x007F2C86 File Offset: 0x007F0E86
	public ESquadCalcPolicy Type
	{
		get
		{
			return ESquadCalcPolicy.AddValue;
		}
	}

	// Token: 0x0400E243 RID: 57923
	public float Value;
}
