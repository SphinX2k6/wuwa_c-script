using System;
using System.Runtime.CompilerServices;

// Token: 0x02001074 RID: 4212
internal static class FormationLimitResult
{
	// Token: 0x0600A7A7 RID: 42919 RVA: 0x00315790 File Offset: 0x00313990
	[NullableContext(1)]
	public static IValidationResult<ELimitReason> Ok()
	{
		return new IValidationResult<ELimitReason>
		{
			Pass = true
		};
	}
}
