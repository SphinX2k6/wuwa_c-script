using System;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02000C29 RID: 3113
// (Invoke) Token: 0x06004D04 RID: 19716
[EventRule(EEventName.CsNetCall)]
internal delegate void Delegate_CsNetCall(ERequestMessageId requestMessageId, FArrayBuffer messageBuffer, int rpcId, int timeoutMs);
