using System;

// Token: 0x02000BAE RID: 2990
// (Invoke) Token: 0x06004B18 RID: 19224
[EventRule(EEventName.OnPhoneMsgReadProgressUpdate)]
internal delegate void Delegate_OnPhoneMsgReadProgressUpdate(int shortMessageId, int progress, bool isFinish);
