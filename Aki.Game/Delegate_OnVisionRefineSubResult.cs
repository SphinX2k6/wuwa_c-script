using System;
using Aki.Protocol;

// Token: 0x0200049C RID: 1180
// (Invoke) Token: 0x06002ED0 RID: 11984
[EventRule(EEventName.OnVisionRefineSubResult)]
internal delegate void Delegate_OnVisionRefineSubResult(PhantomVicePolishAckResponse response, bool ack);
