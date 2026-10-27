using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Infrastructure;

// Token: 0x02000B6E RID: 2926
// (Invoke) Token: 0x06004A18 RID: 18968
[EventRule(EEventName.InfrastructureRoadNoticeUpdate)]
internal delegate void Delegate_InfrastructureRoadNoticeUpdate(IReadOnlyList<InfrastructureDefine.InfrNoticeData> noticeList);
