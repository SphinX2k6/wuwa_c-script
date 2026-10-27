using System;

// Token: 0x0200093B RID: 2363
// (Invoke) Token: 0x0600414C RID: 16716
[EventRule(EEventName.CharActionStateChange)]
internal delegate void Delegate_CharActionStateChange(ECharacterActionType actionType, bool state);
