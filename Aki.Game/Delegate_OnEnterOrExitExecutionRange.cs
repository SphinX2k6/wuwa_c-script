using System;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x02000937 RID: 2359
// (Invoke) Token: 0x0600413C RID: 16700
[EventRule(EEventName.OnEnterOrExitExecutionRange)]
internal delegate void Delegate_OnEnterOrExitExecutionRange(bool isEnter, int entityId, ECustomOptionType? optionType);
