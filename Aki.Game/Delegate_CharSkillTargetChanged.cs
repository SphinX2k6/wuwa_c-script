using System;
using System.Runtime.CompilerServices;

// Token: 0x020002B3 RID: 691
// (Invoke) Token: 0x0600272C RID: 10028
[EventRule(EEventName.CharSkillTargetChanged)]
internal delegate void Delegate_CharSkillTargetChanged([Nullable(2)] EntityHandle skillTarget, string skillTargetSocket);
