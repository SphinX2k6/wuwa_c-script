using System;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x0200040C RID: 1036
// (Invoke) Token: 0x06002C90 RID: 11408
[EventRule(EEventName.MapReplaceMarkResponse)]
internal delegate void Delegate_MapReplaceMarkResponse(EMarkType markType, int markId, int newConfigId);
