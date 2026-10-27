using System;

// Token: 0x02000C70 RID: 3184
// (Invoke) Token: 0x06004E20 RID: 20000
[EventRule(EEventName.CsRequestAdjustTime)]
internal delegate void Delegate_CsRequestAdjustTime(int seconds, int reason, int addDay);
