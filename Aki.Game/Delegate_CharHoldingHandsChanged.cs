using System;

// Token: 0x02000318 RID: 792
// (Invoke) Token: 0x060028C0 RID: 10432
[EventRule(EEventName.CharHoldingHandsChanged)]
internal delegate void Delegate_CharHoldingHandsChanged(int entityId, bool isEnter, EHoldingHandsRoleState state, EHandType handType);
