using System;

// Token: 0x020004E4 RID: 1252
// (Invoke) Token: 0x06002FF0 RID: 12272
[EventRule(EEventName.OnPlayerLevelChanged)]
internal delegate void Delegate_OnPlayerLevelChanged(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp);
