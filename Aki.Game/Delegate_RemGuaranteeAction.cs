using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Guarantee;

// Token: 0x020007C6 RID: 1990
// (Invoke) Token: 0x06003B78 RID: 15224
[EventRule(EEventName.RemGuaranteeAction)]
internal delegate void Delegate_RemGuaranteeAction(string instigatorName, [Nullable(2)] GeneralContext instigatorContext, GuaranteeActionInfo guaranteeAction, bool? bNeedGuaranteeInQuest);
