using System;
using System.Runtime.CompilerServices;

// Token: 0x020010A1 RID: 4257
public class IValidationResult<[Nullable(2)] TReason>
{
	// Token: 0x04006234 RID: 25140
	public bool Pass;

	// Token: 0x04006235 RID: 25141
	[Nullable(1)]
	public TReason Reason;
}
