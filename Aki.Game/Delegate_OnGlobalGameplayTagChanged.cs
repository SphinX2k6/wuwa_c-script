using System;

// Token: 0x02000516 RID: 1302
// (Invoke) Token: 0x060030B8 RID: 12472
[EventRule(EEventName.OnGlobalGameplayTagChanged)]
internal delegate void Delegate_OnGlobalGameplayTagChanged(int entityId, int gameplayTagId, int originTagCount, int newTagCount);
