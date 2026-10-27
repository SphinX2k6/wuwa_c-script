using System;

// Token: 0x0200031B RID: 795
// (Invoke) Token: 0x060028CC RID: 10444
[EventRule(EEventName.OnTeamLivingStateChange)]
internal delegate void Delegate_OnTeamLivingStateChange(bool isMyTeam, ETeamGroupType groupType, ETeamLivingState newState, ETeamLivingState oldState);
