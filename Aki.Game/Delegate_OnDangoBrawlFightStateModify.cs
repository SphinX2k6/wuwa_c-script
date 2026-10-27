using System;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;

// Token: 0x02000D82 RID: 3458
// (Invoke) Token: 0x06005268 RID: 21096
[EventRule(EEventName.OnDangoBrawlFightStateModify)]
internal delegate void Delegate_OnDangoBrawlFightStateModify(EDangoBrawlFightState state, EDangoBrawlFightState preState);
