using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02000A74 RID: 2676
// (Invoke) Token: 0x06004630 RID: 17968
[EventRule(EEventName.StartMoveWithSpline)]
internal delegate void Delegate_StartMoveWithSpline(MoveWithSpline eventParam, bool noSyncPoint, [Nullable(2)] Action<bool> callback);
