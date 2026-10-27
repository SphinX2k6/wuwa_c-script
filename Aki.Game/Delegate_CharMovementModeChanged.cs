using System;
using UnrealEngine;

// Token: 0x020002F0 RID: 752
// (Invoke) Token: 0x06002820 RID: 10272
[EventRule(EEventName.CharMovementModeChanged)]
internal delegate void Delegate_CharMovementModeChanged(int charId, EMovementMode prevMovementMode, EMovementMode newMovementMode, byte prevCustomMode, byte newCustomMode);
