using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BE2 RID: 7138
public class IValidationResult<[Nullable(2)] TReason>
{
	// Token: 0x04006165 RID: 24933
	public bool Pass;

	// Token: 0x04006166 RID: 24934
	[Nullable(1)]
	public TReason Reason;
}
