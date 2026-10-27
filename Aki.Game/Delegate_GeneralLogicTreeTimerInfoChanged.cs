using System;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;

// Token: 0x02000584 RID: 1412
// (Invoke) Token: 0x06003270 RID: 12912
[EventRule(EEventName.GeneralLogicTreeTimerInfoChanged)]
internal delegate void Delegate_GeneralLogicTreeTimerInfoChanged(long treeIncId, ETimerType timerType, TimerSetType setType, int seconds);
