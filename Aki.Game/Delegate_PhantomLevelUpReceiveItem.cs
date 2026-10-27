using System;
using System.Collections.Generic;

// Token: 0x020004B2 RID: 1202
// (Invoke) Token: 0x06002F28 RID: 12072
[EventRule(EEventName.PhantomLevelUpReceiveItem)]
internal delegate void Delegate_PhantomLevelUpReceiveItem(IReadOnlyList<TItem> itemList);
