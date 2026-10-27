using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x02000383 RID: 899
// (Invoke) Token: 0x06002A6C RID: 10860
[EventRule(EEventName.OnReceivePlayerVar)]
internal delegate void Delegate_OnReceivePlayerVar(IReadOnlyDictionary<string, VarDefinePb> varInfos);
