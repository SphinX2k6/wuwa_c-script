using System;
using System.Collections.Generic;

// Token: 0x020005E8 RID: 1512
// (Invoke) Token: 0x06003400 RID: 13312
[EventRule(EEventName.ApplicationHandled)]
internal delegate void Delegate_ApplicationHandled(EFriendItemOperation operationType, IReadOnlyList<int> ids);
