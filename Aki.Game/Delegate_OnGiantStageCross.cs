using System;
using Aki.Protocol;
using CSharpScript.Game.Module.Giant;

// Token: 0x02000DB4 RID: 3508
// (Invoke) Token: 0x06005330 RID: 21296
[EventRule(EEventName.OnGiantStageCross)]
internal delegate void Delegate_OnGiantStageCross(GiantEcoNetType? ecology, EGiantStage oldStage, EGiantStage newStage);
