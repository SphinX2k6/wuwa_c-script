using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BB4 RID: 7092
[NullableContext(1)]
public interface ILimitStrategy
{
	// Token: 0x0600D394 RID: 54164
	IValidationResult<ELimitReason> CheckLimit(ILimitContext ctx);
}
