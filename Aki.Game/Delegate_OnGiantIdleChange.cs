using System;
using CSharpScript.Game.Module.Giant;

// Token: 0x02000DB5 RID: 3509
// (Invoke) Token: 0x06005334 RID: 21300
[EventRule(EEventName.OnGiantIdleChange)]
internal delegate void Delegate_OnGiantIdleChange(string oldKey, string newKey, EIdleSwitchSource source);
