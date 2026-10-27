using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x0200036B RID: 875
// (Invoke) Token: 0x06002A0C RID: 10764
[EventRule(EEventName.InitArea)]
internal delegate void Delegate_InitArea(IReadOnlyList<SceneAreaState> areas);
