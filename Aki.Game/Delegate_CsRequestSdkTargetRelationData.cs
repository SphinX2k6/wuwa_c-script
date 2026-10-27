using System;
using System.Collections.Generic;

// Token: 0x02000CA2 RID: 3234
// (Invoke) Token: 0x06004EE8 RID: 20200
[EventRule(EEventName.CsRequestSdkTargetRelationData)]
internal delegate void Delegate_CsRequestSdkTargetRelationData(int reqId, IReadOnlyList<string> accountList);
