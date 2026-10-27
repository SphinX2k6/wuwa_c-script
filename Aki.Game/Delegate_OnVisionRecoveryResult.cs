using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000495 RID: 1173
// (Invoke) Token: 0x06002EB4 RID: 11956
[EventRule(EEventName.OnVisionRecoveryResult)]
internal delegate void Delegate_OnVisionRecoveryResult([Nullable(new byte[]
{
	0,
	1,
	1
})] OneOf<PhantomBatchDirectRefiningResponse, PhantomRefiningResponse> response);
