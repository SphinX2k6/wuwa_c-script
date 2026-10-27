using System;

// Token: 0x02000CB8 RID: 3256
// (Invoke) Token: 0x06004F40 RID: 20288
[EventRule(EEventName.TsSyncTime)]
internal delegate void Delegate_TsSyncTime(double serverTime, double flowTime, double combatTime, double stopTime);
