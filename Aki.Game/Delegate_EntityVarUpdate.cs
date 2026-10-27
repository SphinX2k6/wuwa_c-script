using System;
using Aki.Protocol;

// Token: 0x02000379 RID: 889
// (Invoke) Token: 0x06002A44 RID: 10820
[EventRule(EEventName.EntityVarUpdate)]
internal delegate void Delegate_EntityVarUpdate(string name, VarDefinePb variable);
