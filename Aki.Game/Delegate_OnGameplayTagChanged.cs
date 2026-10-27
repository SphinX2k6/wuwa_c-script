using System;

// Token: 0x02002E58 RID: 11864
// (Invoke) Token: 0x060194CE RID: 103630
[AbilityEventRule(EAbilityEventName.OnGameplayTagChanged)]
internal delegate void Delegate_OnGameplayTagChanged(int entityId, int gameplayTagId, int originTagCount, int newTagCount);
