using System;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x02000419 RID: 1049
// (Invoke) Token: 0x06002CC4 RID: 11460
[EventRule(EEventName.MarkForceVisibleChanged)]
internal delegate void Delegate_MarkForceVisibleChanged(EMarkType markType, int markId, bool currentVisible);
