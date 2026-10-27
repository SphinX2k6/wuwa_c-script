using System;
using Aki.TDConfigMgr.Quest;

// Token: 0x02000D27 RID: 3367
// (Invoke) Token: 0x060050FC RID: 20732
[EventRule(EEventName.OnArcadeGameplayFinish)]
internal delegate void Delegate_OnArcadeGameplayFinish(EArcadeGameplayType type, int levelId);
