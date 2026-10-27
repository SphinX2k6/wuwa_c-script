using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BB5 RID: 7093
internal static class FormationLimitResult
{
	// Token: 0x0600D395 RID: 54165 RVA: 0x0030A69C File Offset: 0x0030889C
	[NullableContext(1)]
	public static IValidationResult<ELimitReason> Ok()
	{
		return new IValidationResult<ELimitReason>
		{
			Pass = true
		};
	}
}
