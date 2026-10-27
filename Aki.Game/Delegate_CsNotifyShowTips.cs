using System;
using System.Collections.Generic;

// Token: 0x02000C1B RID: 3099
// (Invoke) Token: 0x06004CCC RID: 19660
[EventRule(EEventName.CsNotifyShowTips)]
internal delegate void Delegate_CsNotifyShowTips(int typeId, string textKey, IReadOnlyList<string> mainTextParams);
