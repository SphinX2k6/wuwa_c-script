using System;

// Token: 0x020002FC RID: 764
// (Invoke) Token: 0x06002850 RID: 10320
[EventRule(EEventName.CharOnHealthChanged)]
internal delegate void Delegate_CharOnHealthChanged(int charId, float newValue, float oldValue);
