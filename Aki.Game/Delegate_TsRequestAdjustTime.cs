using System;

// Token: 0x02000C71 RID: 3185
// (Invoke) Token: 0x06004E24 RID: 20004
[EventRule(EEventName.TsRequestAdjustTime)]
internal delegate void Delegate_TsRequestAdjustTime(int seconds, int reason, int addDay);
