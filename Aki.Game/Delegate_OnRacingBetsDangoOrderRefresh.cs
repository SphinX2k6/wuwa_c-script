using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x02000A37 RID: 2615
// (Invoke) Token: 0x0600453C RID: 17724
[EventRule(EEventName.OnRacingBetsDangoOrderRefresh)]
internal delegate void Delegate_OnRacingBetsDangoOrderRefresh(int round, IReadOnlyList<DangoIdToDiceNum> dangoDiceList, CustomPromise promise);
