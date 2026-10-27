using System;
using System.Collections.Generic;

// Token: 0x02000AC4 RID: 2756
// (Invoke) Token: 0x06004770 RID: 18288
[EventRule(EEventName.OwnHandCardRemove)]
internal delegate void Delegate_OwnHandCardRemove(IReadOnlyList<int> removeCardList);
