using System;
using UnrealEngine;

// Token: 0x02000C22 RID: 3106
// (Invoke) Token: 0x06004CE8 RID: 19688
[EventRule(EEventName.NotifyCsOnNetReceiveResponse)]
internal delegate void Delegate_NotifyCsOnNetReceiveResponse(int msgType, int seqNo, int rpcId, int messageId, FArrayBuffer messageBuffer);
