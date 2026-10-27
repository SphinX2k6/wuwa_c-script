using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x0200062A RID: 1578
// (Invoke) Token: 0x06003508 RID: 13576
[EventRule(EEventName.GachaResponse)]
internal delegate void Delegate_GachaResponse(IReadOnlyList<Aki.Protocol.GachaResult> result);
