using System;
using System.Collections.Generic;

// Token: 0x020006AE RID: 1710
// (Invoke) Token: 0x06003718 RID: 14104
[EventRule(EEventName.AdventureTaskStateChange)]
internal delegate void Delegate_AdventureTaskStateChange(IReadOnlyList<int> ids);
