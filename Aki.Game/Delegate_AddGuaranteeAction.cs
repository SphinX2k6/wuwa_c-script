using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Guarantee;

// Token: 0x020007C5 RID: 1989
// (Invoke) Token: 0x06003B74 RID: 15220
[EventRule(EEventName.AddGuaranteeAction)]
internal delegate void Delegate_AddGuaranteeAction(string instigatorName, [Nullable(2)] GeneralContext instigatorContext, GuaranteeActionInfo guaranteeAction, bool? bNeedGuaranteeInQuest);
