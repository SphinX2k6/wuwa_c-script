using System;

// Token: 0x020005F2 RID: 1522
// (Invoke) Token: 0x06003428 RID: 13352
[EventRule(EEventName.ControllerConnectChange)]
internal delegate void Delegate_ControllerConnectChange(bool bIsConnected, int platformUserId, int controllerId);
