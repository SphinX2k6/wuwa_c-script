using System;
using Aki.Protocol;

// Token: 0x02000623 RID: 1571
// (Invoke) Token: 0x060034EC RID: 13548
[EventRule(EEventName.OnRefreshPlayerPing)]
internal delegate void Delegate_OnRefreshPlayerPing(int playerId, ENetPingState ping);
