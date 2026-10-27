using System;

// Token: 0x020004E6 RID: 1254
// (Invoke) Token: 0x06002FF8 RID: 12280
[EventRule(EEventName.OnLevelUpLevelRefresh)]
internal delegate void Delegate_OnLevelUpLevelRefresh(int lastLevel, int currentLevel, int currentExp, int lastExp, int addExp, int currentMaxExp, int lastMaxExp);
