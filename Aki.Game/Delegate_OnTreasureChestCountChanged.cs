using System;
using Aki.Protocol;

// Token: 0x02000DBC RID: 3516
// (Invoke) Token: 0x06005350 RID: 21328
[EventRule(EEventName.OnTreasureChestCountChanged)]
internal delegate void Delegate_OnTreasureChestCountChanged(TreasureChestStatType? gainedStatType);
