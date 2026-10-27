using System;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;

// Token: 0x02000D8B RID: 3467
// (Invoke) Token: 0x0600528C RID: 21132
[EventRule(EEventName.OnDangoBrawlBagOperated)]
internal delegate void Delegate_OnDangoBrawlBagOperated(EBagOpKind kind, int uid);
