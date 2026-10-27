using System;
using UnrealEngine;

// Token: 0x02000C25 RID: 3109
// (Invoke) Token: 0x06004CF4 RID: 19700
[EventRule(EEventName.NotifyCsOnNetReceivePush)]
internal delegate void Delegate_NotifyCsOnNetReceivePush(int seqNo, int messageId, FArrayBuffer messageBuffer);
