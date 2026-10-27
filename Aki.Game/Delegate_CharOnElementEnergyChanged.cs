using System;
using CSharpScript.Game.NewWorld.Character.Common.Component.Abilities;

// Token: 0x020002FE RID: 766
// (Invoke) Token: 0x06002858 RID: 10328
[EventRule(EEventName.CharOnElementEnergyChanged)]
internal delegate void Delegate_CharOnElementEnergyChanged(EElementType elementID, float newValue, float oldValue);
