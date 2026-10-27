using System;

// Token: 0x0200040A RID: 1034
// (Invoke) Token: 0x06002C88 RID: 11400
[EventRule(EEventName.OnGameplaySettingsSet)]
internal delegate void Delegate_OnGameplaySettingsSet(EFunction functionId, int value, bool directly);
