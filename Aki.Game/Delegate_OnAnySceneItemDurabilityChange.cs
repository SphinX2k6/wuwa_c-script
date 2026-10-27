using System;

// Token: 0x020004F5 RID: 1269
// (Invoke) Token: 0x06003034 RID: 12340
[EventRule(EEventName.OnAnySceneItemDurabilityChange)]
internal delegate void Delegate_OnAnySceneItemDurabilityChange(EntityHandle entity, int newDurability, int currentDurability);
