using System;

// Token: 0x02000C80 RID: 3200
// (Invoke) Token: 0x06004E60 RID: 20064
[EventRule(EEventName.TsNotifyQuestTrackState)]
internal delegate void Delegate_TsNotifyQuestTrackState(int questId, bool isTrack, int reason);
