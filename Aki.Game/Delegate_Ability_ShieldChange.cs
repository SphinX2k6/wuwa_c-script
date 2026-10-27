using System;

// Token: 0x02002E55 RID: 11861
// (Invoke) Token: 0x060194C2 RID: 103618
[AbilityEventRule(EAbilityEventName.ShieldChange)]
internal delegate void Delegate_Ability_ShieldChange(Entity victim, float oldShieldValue, float newShieldValue, int updateType, int shieldId);
