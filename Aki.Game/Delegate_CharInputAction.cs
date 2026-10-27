using System;
using UnrealEngine;

// Token: 0x02000316 RID: 790
// (Invoke) Token: 0x060028B8 RID: 10424
[EventRule(EEventName.CharInputAction)]
internal delegate void Delegate_CharInputAction(string actionName, bool isPress, FKey key);
