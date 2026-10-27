using System;

// Token: 0x020002C2 RID: 706
// (Invoke) Token: 0x06002768 RID: 10088
[EventRule(EEventName.OnBeforeSkillSimulateMontage)]
internal delegate void Delegate_OnBeforeSkillSimulateMontage(int entityId, int skillId, int montageIndex, float startTimeSeconds);
