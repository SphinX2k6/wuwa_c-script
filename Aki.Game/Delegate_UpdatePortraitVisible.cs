using System;
using Aki.TDConfigMgr.Action;

// Token: 0x02000458 RID: 1112
// (Invoke) Token: 0x06002DC0 RID: 11712
[EventRule(EEventName.UpdatePortraitVisible)]
internal delegate void Delegate_UpdatePortraitVisible(SetHeadIconVisible config, Action callback);
