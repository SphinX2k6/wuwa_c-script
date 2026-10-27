using System;
using System.Collections.Generic;

// Token: 0x02000402 RID: 1026
// (Invoke) Token: 0x06002C68 RID: 11368
[EventRule(EEventName.MapOpenFogFullUpdate)]
internal delegate void Delegate_MapOpenFogFullUpdate(IReadOnlyDictionary<int, bool> openAreaIds);
