using System;
using System.Collections.Generic;

// Token: 0x0200062C RID: 1580
// (Invoke) Token: 0x06003510 RID: 13584
[EventRule(EEventName.GachaHistoryResponse)]
internal delegate void Delegate_GachaHistoryResponse(IReadOnlyList<GachaRecord> record);
