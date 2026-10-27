using System;

// Token: 0x020007C4 RID: 1988
// (Invoke) Token: 0x06003B70 RID: 15216
[EventRule(EEventName.HandleActionFailure)]
internal delegate void Delegate_HandleActionFailure(int groupId, string type, bool isError, bool showLog);
