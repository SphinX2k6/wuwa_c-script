using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x020004C1 RID: 1217
// (Invoke) Token: 0x06002F64 RID: 12132
[EventRule(EEventName.OnVisionIdentifyDoAnimation)]
internal delegate void Delegate_OnVisionIdentifyDoAnimation(int uniqueId, IReadOnlyList<Aki.Protocol.PhantomPropInfo> data);
