using System;
using Aki.Protocol;

// Token: 0x02000BBD RID: 3005
// (Invoke) Token: 0x06004B54 RID: 19284
[EventRule(EEventName.EncircleDataUpdate)]
internal delegate void Delegate_EncircleDataUpdate(EncircleChallengePb newData);
