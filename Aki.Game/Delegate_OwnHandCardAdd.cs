using System;
using System.Collections.Generic;

// Token: 0x02000AC3 RID: 2755
// (Invoke) Token: 0x0600476C RID: 18284
[EventRule(EEventName.OwnHandCardAdd)]
internal delegate void Delegate_OwnHandCardAdd(IReadOnlyList<int> addCardList);
