using System;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x02000413 RID: 1043
// (Invoke) Token: 0x06002CAC RID: 11436
[EventRule(EEventName.OnMapMarkTaskComplete)]
internal delegate void Delegate_OnMapMarkTaskComplete(EMarkType markType, int markId);
