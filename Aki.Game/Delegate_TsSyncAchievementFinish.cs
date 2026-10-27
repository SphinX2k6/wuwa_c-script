using System;
using System.Collections.Generic;

// Token: 0x02000CCD RID: 3277
// (Invoke) Token: 0x06004F94 RID: 20372
[EventRule(EEventName.TsSyncAchievementFinish)]
internal delegate void Delegate_TsSyncAchievementFinish(IReadOnlyList<int> categoryIdList, IReadOnlyList<int> groupIdList, IReadOnlyList<int> achievementIdList, int startCount, int finishCount);
