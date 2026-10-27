using System;

// Token: 0x0200329B RID: 12955
public class SquadOverrideModifier : ISquadModifier
{
	// Token: 0x170026C0 RID: 9920
	// (get) Token: 0x0601C0A6 RID: 114854 RVA: 0x007CB9E9 File Offset: 0x007C9BE9
	public ESquadCalcPolicy Type
	{
		get
		{
			return ESquadCalcPolicy.Override;
		}
	}

	// Token: 0x0400DD9F RID: 56735
	public float Value;
}
