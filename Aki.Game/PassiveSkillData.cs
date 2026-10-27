using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002ED0 RID: 11984
public class PassiveSkillData
{
	// Token: 0x0400BFB3 RID: 49075
	public long SkillId;

	// Token: 0x0400BFB4 RID: 49076
	public int TriggerHandle;

	// Token: 0x0400BFB5 RID: 49077
	[Nullable(1)]
	public List<SkillActionData> Actions = new List<SkillActionData>();

	// Token: 0x0400BFB6 RID: 49078
	[Nullable(2)]
	public string TargetKey;

	// Token: 0x0400BFB7 RID: 49079
	public long? CombatMessageId;
}
