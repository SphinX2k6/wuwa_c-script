using System;

// Token: 0x020025FD RID: 9725
public class DynamicFlowActorInfo
{
	// Token: 0x06018515 RID: 99605 RVA: 0x00755E63 File Offset: 0x00754063
	public bool IsValid()
	{
		return this.CreatureId != 0L || this.PbDataId != 0;
	}

	// Token: 0x0400D1D4 RID: 53716
	public long CreatureId;

	// Token: 0x0400D1D5 RID: 53717
	public int PbDataId;
}
