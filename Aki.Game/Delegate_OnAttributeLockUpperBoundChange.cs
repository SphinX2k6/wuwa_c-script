using System;
using Aki.Protocol;

// Token: 0x0200064A RID: 1610
// (Invoke) Token: 0x06003588 RID: 13704
[EventRule(EEventName.OnAttributeLockUpperBoundChange)]
internal delegate void Delegate_OnAttributeLockUpperBoundChange(int entityId, EAttributeType attributeId);
