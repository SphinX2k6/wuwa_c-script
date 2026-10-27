using System;

// Token: 0x0200329A RID: 12954
public class SquadAdvancedMulModifier : ISquadModifier
{
	// Token: 0x170026BF RID: 9919
	// (get) Token: 0x0601C0A4 RID: 114852 RVA: 0x007CB9DE File Offset: 0x007C9BDE
	public ESquadCalcPolicy Type
	{
		get
		{
			return ESquadCalcPolicy.AdvancedMul;
		}
	}

	// Token: 0x0400DD9E RID: 56734
	public float Value;
}
