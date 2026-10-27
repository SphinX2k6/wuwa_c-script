using System;

// Token: 0x0200076C RID: 1900
// (Invoke) Token: 0x06003A10 RID: 14864
[EventRule(EEventName.OnCharacterCapsuleChanged)]
internal delegate void Delegate_OnCharacterCapsuleChanged(Entity entity, float newRadius, float newHalfHeight, bool bUpdateOverlaps);
