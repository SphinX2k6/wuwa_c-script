using System;
using System.Collections.Generic;

// Token: 0x02000515 RID: 1301
// (Invoke) Token: 0x060030B4 RID: 12468
[EventRule(EEventName.OnLevelTagChanged)]
internal delegate void Delegate_OnLevelTagChanged(IReadOnlyList<int> addedTags, IReadOnlyList<int> removedTags);
