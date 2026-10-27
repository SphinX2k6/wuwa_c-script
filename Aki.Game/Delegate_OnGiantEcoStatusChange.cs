using System;
using Aki.Protocol;

// Token: 0x02000DBA RID: 3514
// (Invoke) Token: 0x06005348 RID: 21320
[EventRule(EEventName.OnGiantEcoStatusChange)]
internal delegate void Delegate_OnGiantEcoStatusChange(GiantEcoNetType ecology, GiantEcoNetStatus oldStatus, GiantEcoNetStatus newStatus);
