using System;

// Token: 0x0200280A RID: 10250
public class SquadAddRateModifier : ISquadModifier
{
	// Token: 0x17002998 RID: 10648
	// (get) Token: 0x06019CD0 RID: 105680 RVA: 0x007F2C91 File Offset: 0x007F0E91
	public ESquadCalcPolicy Type
	{
		get
		{
			return ESquadCalcPolicy.AddRate;
		}
	}

	// Token: 0x0400E244 RID: 57924
	public float Value;
}
