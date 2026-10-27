using System;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x02000938 RID: 2360
// (Invoke) Token: 0x06004140 RID: 16704
[EventRule(EEventName.OnExecutionOptionChange)]
internal delegate void Delegate_OnExecutionOptionChange(bool isExecution, int entityId, ECustomOptionType? optionType);
