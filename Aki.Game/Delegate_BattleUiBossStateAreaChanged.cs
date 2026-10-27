using System;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x02000765 RID: 1893
// (Invoke) Token: 0x060039F4 RID: 14836
[EventRule(EEventName.BattleUiBossStateAreaChanged)]
internal delegate void Delegate_BattleUiBossStateAreaChanged(EBossStateAreaType lastType, EBossStateAreaType curType);
