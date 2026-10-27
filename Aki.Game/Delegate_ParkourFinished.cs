using System;
using System.Collections.Generic;

// Token: 0x02000607 RID: 1543
// (Invoke) Token: 0x0600347C RID: 13436
[EventRule(EEventName.ParkourFinished)]
internal delegate void Delegate_ParkourFinished(string ParkourConfig, IReadOnlyDictionary<int, int> totalScore);
