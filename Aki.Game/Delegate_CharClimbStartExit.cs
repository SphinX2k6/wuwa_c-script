using System;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x020002DA RID: 730
// (Invoke) Token: 0x060027C8 RID: 10184
[EventRule(EEventName.CharClimbStartExit)]
internal delegate void Delegate_CharClimbStartExit(int charId, EExitClimb exitClimbType);
