using System;
using Aki.Protocol;

// Token: 0x0200039A RID: 922
// (Invoke) Token: 0x06002AC8 RID: 10952
[EventRule(EEventName.RoleSkillLevelUp)]
internal delegate void Delegate_RoleSkillLevelUp(int roleId, ArrayIntInt skillInfo);
