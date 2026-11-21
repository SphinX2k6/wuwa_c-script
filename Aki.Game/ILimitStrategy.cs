using System;
using System.Runtime.CompilerServices;

// Token: 0x02001073 RID: 4211
[NullableContext(1)]
public interface ILimitStrategy
{
	// Token: 0x0600A7A6 RID: 42918
	IValidationResult<ELimitReason> CheckLimit(ILimitContext ctx);
}
