using System;
using Aki.Protocol;

// Token: 0x02002E56 RID: 11862
// (Invoke) Token: 0x060194C6 RID: 103622
[AbilityEventRule(EAbilityEventName.OnAttributeChange)]
internal delegate void Delegate_Ability_OnAttributeChange(EAttributeType attrType, Entity entity, float newValue, float oldValue);
