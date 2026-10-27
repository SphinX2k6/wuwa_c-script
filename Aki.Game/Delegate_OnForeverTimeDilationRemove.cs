using System;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x02000B0D RID: 2829
// (Invoke) Token: 0x06004894 RID: 18580
[EventRule(EEventName.OnForeverTimeDilationRemove)]
internal delegate void Delegate_OnForeverTimeDilationRemove(ETimeScaleSourceType type, float timeScale, int priority);
