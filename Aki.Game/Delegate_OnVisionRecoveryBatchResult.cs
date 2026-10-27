using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000496 RID: 1174
// (Invoke) Token: 0x06002EB8 RID: 11960
[EventRule(EEventName.OnVisionRecoveryBatchResult)]
internal delegate void Delegate_OnVisionRecoveryBatchResult([Nullable(new byte[]
{
	0,
	1,
	1
})] OneOf<PhantomBatchDirectRefiningResponse, PhantomBatchRefiningResponse> response);
