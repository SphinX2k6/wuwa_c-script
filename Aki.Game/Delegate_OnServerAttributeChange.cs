using System;
using Aki.Protocol;

// Token: 0x02000606 RID: 1542
// (Invoke) Token: 0x06003478 RID: 13432
[EventRule(EEventName.OnServerAttributeChange)]
internal delegate void Delegate_OnServerAttributeChange(int entityId, AttributeChangedNotify attributeData);
