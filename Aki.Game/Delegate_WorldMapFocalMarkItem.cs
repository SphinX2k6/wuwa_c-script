using System;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x02000441 RID: 1089
// (Invoke) Token: 0x06002D64 RID: 11620
[EventRule(EEventName.WorldMapFocalMarkItem)]
internal delegate void Delegate_WorldMapFocalMarkItem(int markId, EMarkType markType, bool focal, bool focusTween, bool? needTempShow);
