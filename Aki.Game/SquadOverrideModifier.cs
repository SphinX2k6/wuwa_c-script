using System;

// Token: 0x0200280C RID: 10252
public class SquadOverrideModifier : ISquadModifier
{
	// Token: 0x1700299A RID: 10650
	// (get) Token: 0x06019CD4 RID: 105684 RVA: 0x007F2CA7 File Offset: 0x007F0EA7
	public ESquadCalcPolicy Type
	{
		get
		{
			return ESquadCalcPolicy.Override;
		}
	}

	// Token: 0x0400E246 RID: 57926
	public float Value;
}
