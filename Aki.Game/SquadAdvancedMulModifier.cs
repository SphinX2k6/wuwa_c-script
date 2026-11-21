using System;

// Token: 0x0200280B RID: 10251
public class SquadAdvancedMulModifier : ISquadModifier
{
	// Token: 0x17002999 RID: 10649
	// (get) Token: 0x06019CD2 RID: 105682 RVA: 0x007F2C9C File Offset: 0x007F0E9C
	public ESquadCalcPolicy Type
	{
		get
		{
			return ESquadCalcPolicy.AdvancedMul;
		}
	}

	// Token: 0x0400E245 RID: 57925
	public float Value;
}
