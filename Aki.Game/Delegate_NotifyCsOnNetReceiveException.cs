using System;
using UnrealEngine;

// Token: 0x02000C23 RID: 3107
// (Invoke) Token: 0x06004CEC RID: 19692
[EventRule(EEventName.NotifyCsOnNetReceiveException)]
internal delegate void Delegate_NotifyCsOnNetReceiveException(int seqNo, int rpcId, int errorCode, FArrayBuffer stringBuffer);
