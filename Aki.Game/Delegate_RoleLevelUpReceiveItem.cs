using System;
using System.Collections.Generic;

// Token: 0x0200039C RID: 924
// (Invoke) Token: 0x06002AD0 RID: 10960
[EventRule(EEventName.RoleLevelUpReceiveItem)]
internal delegate void Delegate_RoleLevelUpReceiveItem(IReadOnlyList<TItem> itemList);
