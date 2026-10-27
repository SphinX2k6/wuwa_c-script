using System;

// Token: 0x02000327 RID: 807
// (Invoke) Token: 0x060028FC RID: 10492
[EventRule(EEventName.AiTauntAddOrRemove)]
internal delegate void Delegate_AiTauntAddOrRemove(bool addOrRemove, int instigatorEntityId, int handleId);
