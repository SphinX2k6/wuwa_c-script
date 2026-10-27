using System;
using Aki.Protocol;

// Token: 0x02000376 RID: 886
// (Invoke) Token: 0x06002A38 RID: 10808
[EventRule(EEventName.RemoveEntity)]
internal delegate void Delegate_RemoveEntity(ERemoveEntityType removeType, EntityHandle handle);
