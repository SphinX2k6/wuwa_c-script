using System;
using System.Runtime.CompilerServices;

// Token: 0x02003156 RID: 12630
[NullableContext(2)]
[Nullable(0)]
public class BeginSkillBehaviorConditionParam : IBeginSkillBehaviorConditionParam
{
	// Token: 0x170025AA RID: 9642
	// (get) Token: 0x0601B2F3 RID: 111347 RVA: 0x00767FB8 File Offset: 0x007661B8
	// (set) Token: 0x0601B2F4 RID: 111348 RVA: 0x00767FC0 File Offset: 0x007661C0
	[Nullable(1)]
	public Entity Entity { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170025AB RID: 9643
	// (get) Token: 0x0601B2F5 RID: 111349 RVA: 0x00767FC9 File Offset: 0x007661C9
	// (set) Token: 0x0601B2F6 RID: 111350 RVA: 0x00767FD1 File Offset: 0x007661D1
	public BaseSkillComponent SkillComponent { get; set; }

	// Token: 0x170025AC RID: 9644
	// (get) Token: 0x0601B2F7 RID: 111351 RVA: 0x00767FDA File Offset: 0x007661DA
	// (set) Token: 0x0601B2F8 RID: 111352 RVA: 0x00767FE2 File Offset: 0x007661E2
	public Skill Skill { get; set; }
}
