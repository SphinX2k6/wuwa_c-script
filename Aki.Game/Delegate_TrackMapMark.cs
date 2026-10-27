using System;
using CSharpScript.Game.Module.Map.MapDefine;

// Token: 0x02000411 RID: 1041
// (Invoke) Token: 0x06002CA4 RID: 11428
[EventRule(EEventName.TrackMapMark)]
internal delegate void Delegate_TrackMapMark(EMarkType martType, int markId, bool isTrack);
