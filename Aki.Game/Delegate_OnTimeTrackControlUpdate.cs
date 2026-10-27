using System;
using Aki.Protocol;

// Token: 0x0200050D RID: 1293
// (Invoke) Token: 0x06003094 RID: 12436
[EventRule(EEventName.OnTimeTrackControlUpdate)]
internal delegate void Delegate_OnTimeTrackControlUpdate(int curControlPoint, ErrorCode UpdateCode);
