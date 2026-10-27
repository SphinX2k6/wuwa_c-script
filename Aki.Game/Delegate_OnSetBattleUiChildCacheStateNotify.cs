using System;
using CSharpScript.Game.Module.BattleUi;

// Token: 0x02000CEC RID: 3308
// (Invoke) Token: 0x06005010 RID: 20496
[EventRule(EEventName.OnSetBattleUiChildCacheStateNotify)]
internal delegate void Delegate_OnSetBattleUiChildCacheStateNotify(EBattleUiChildCacheType cacheType, bool needCache);
