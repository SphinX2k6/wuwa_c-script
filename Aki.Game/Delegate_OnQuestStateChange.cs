using System;
using Aki.Protocol;

// Token: 0x02000572 RID: 1394
// (Invoke) Token: 0x06003228 RID: 12840
[EventRule(EEventName.OnQuestStateChange)]
internal delegate void Delegate_OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason reason);
