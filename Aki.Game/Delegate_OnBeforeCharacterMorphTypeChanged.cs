using System;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02000A83 RID: 2691
// (Invoke) Token: 0x0600466C RID: 18028
[EventRule(EEventName.OnBeforeCharacterMorphTypeChanged)]
internal delegate void Delegate_OnBeforeCharacterMorphTypeChanged(Entity entity, EMorphType morphType, EMorphType oldMorphType);
