using System;

// Token: 0x02000AD6 RID: 2774
// (Invoke) Token: 0x060047B8 RID: 18360
[EventRule(EEventName.NotifyBattleCardChange)]
internal delegate void Delegate_NotifyBattleCardChange(bool isOwn, int indexA, int indexB);
