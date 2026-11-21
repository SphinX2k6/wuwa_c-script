using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002423 RID: 9251
public class PassiveSkillData
{
	// Token: 0x0400C34E RID: 49998
	public long SkillId;

	// Token: 0x0400C34F RID: 49999
	public int TriggerHandle;

	// Token: 0x0400C350 RID: 50000
	[Nullable(1)]
	public List<SkillActionData> Actions = new List<SkillActionData>();

	// Token: 0x0400C351 RID: 50001
	[Nullable(2)]
	public string TargetKey;

	// Token: 0x0400C352 RID: 50002
	public long? CombatMessageId;
}
