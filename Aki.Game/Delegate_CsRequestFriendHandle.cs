using System;
using System.Collections.Generic;

// Token: 0x02000C87 RID: 3207
// (Invoke) Token: 0x06004E7C RID: 20092
[EventRule(EEventName.CsRequestFriendHandle)]
internal delegate void Delegate_CsRequestFriendHandle(int @operator, IReadOnlyDictionary<int, int> HandleMap);
