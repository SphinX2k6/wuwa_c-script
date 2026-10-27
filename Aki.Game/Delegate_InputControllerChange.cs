using System;

// Token: 0x020005EE RID: 1518
// (Invoke) Token: 0x06003418 RID: 13336
[EventRule(EEventName.InputControllerChange)]
internal delegate void Delegate_InputControllerChange(EInputControllerType last, EInputControllerType now);
