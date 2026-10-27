using System;

// Token: 0x02000A3F RID: 2623
// (Invoke) Token: 0x0600455C RID: 17756
[EventRule(EEventName.OnRacingBetsMatchStateChange)]
internal delegate void Delegate_OnRacingBetsMatchStateChange(int legMatchId, ERacingBetsLegMatchState matchState);
