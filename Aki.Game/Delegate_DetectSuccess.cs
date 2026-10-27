using System;
using Aki.Protocol;

// Token: 0x020006B0 RID: 1712
// (Invoke) Token: 0x06003720 RID: 14112
[EventRule(EEventName.DetectSuccess)]
internal delegate void Delegate_DetectSuccess(int id, DetectionType type);
