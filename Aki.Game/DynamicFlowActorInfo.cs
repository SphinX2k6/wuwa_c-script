using System;

// Token: 0x020030A6 RID: 12454
public class DynamicFlowActorInfo
{
	// Token: 0x0601AB07 RID: 109319 RVA: 0x00730963 File Offset: 0x0072EB63
	public bool IsValid()
	{
		return this.CreatureId != 0L || this.PbDataId != 0;
	}

	// Token: 0x0400CDF0 RID: 52720
	public long CreatureId;

	// Token: 0x0400CDF1 RID: 52721
	public int PbDataId;
}
