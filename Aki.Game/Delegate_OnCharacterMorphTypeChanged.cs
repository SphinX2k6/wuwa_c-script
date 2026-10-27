using System;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02000A82 RID: 2690
// (Invoke) Token: 0x06004668 RID: 18024
[EventRule(EEventName.OnCharacterMorphTypeChanged)]
internal delegate void Delegate_OnCharacterMorphTypeChanged(Entity entity, EMorphType morphType, EMorphType oldMorphType);
