using System;
using System.Collections.Generic;
using UnrealEngine;

// Token: 0x020005A0 RID: 1440
// (Invoke) Token: 0x060032E0 RID: 13024
[EventRule(EEventName.MotorcycleBaseMovementChanged)]
internal delegate void Delegate_MotorcycleBaseMovementChanged(IReadOnlySet<UPrimitiveComponent> newBaseMovementSet);
