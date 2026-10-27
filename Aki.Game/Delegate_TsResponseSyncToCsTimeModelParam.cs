using System;

// Token: 0x02000C6D RID: 3181
// (Invoke) Token: 0x06004E14 RID: 19988
[EventRule(EEventName.TsResponseSyncToCsTimeModelParam)]
internal delegate void Delegate_TsResponseSyncToCsTimeModelParam(bool freezeTimeScale, bool timeRunLockStateClient, bool timeRunLockStateServer, bool timeSyncLockStateClient, bool timeSyncLockStateServer);
