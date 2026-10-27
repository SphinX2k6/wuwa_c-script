using System;
using System.Collections.Generic;

// Token: 0x0200038D RID: 909
// (Invoke) Token: 0x06002A94 RID: 10900
[EventRule(EEventName.DeletingMail)]
internal delegate void Delegate_DeletingMail(IReadOnlyList<string> deletedMails);
