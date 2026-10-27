using System;

// Token: 0x02000665 RID: 1637
// (Invoke) Token: 0x060035F4 RID: 13812
[EventRule(EEventName.PlayerChallengeStateChange)]
internal delegate void Delegate_PlayerChallengeStateChange(int playerId, EContinuingChallenge state);
