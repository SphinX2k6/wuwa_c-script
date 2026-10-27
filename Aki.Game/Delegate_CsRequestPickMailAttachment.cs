using System;
using System.Collections.Generic;

// Token: 0x02000C65 RID: 3173
// (Invoke) Token: 0x06004DF4 RID: 19956
[EventRule(EEventName.CsRequestPickMailAttachment)]
internal delegate void Delegate_CsRequestPickMailAttachment(IReadOnlyList<string> attachmentList, int pickType);
