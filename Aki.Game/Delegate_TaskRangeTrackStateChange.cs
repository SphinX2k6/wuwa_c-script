using System;

// Token: 0x0200043A RID: 1082
// (Invoke) Token: 0x06002D48 RID: 11592
[EventRule(EEventName.TaskRangeTrackStateChange)]
internal delegate void Delegate_TaskRangeTrackStateChange(ETrackSource trackSource, long treeIncId, int behaviorId, int markId, bool rangeImageActive);
