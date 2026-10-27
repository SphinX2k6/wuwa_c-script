using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000312 RID: 786
// (Invoke) Token: 0x060028A8 RID: 10408
[EventRule(EEventName.CharPossessed)]
internal delegate void Delegate_CharPossessed(Entity entity, [Nullable(2)] AController newController);
