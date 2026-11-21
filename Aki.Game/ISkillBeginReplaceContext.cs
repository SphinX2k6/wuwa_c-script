using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x02002696 RID: 9878
[NullableContext(1)]
public interface ISkillBeginReplaceContext
{
	// Token: 0x17002739 RID: 10041
	// (get) Token: 0x06018BB4 RID: 101300
	Skill SourceSkill { get; }

	// Token: 0x1700273A RID: 10042
	// (get) Token: 0x06018BB5 RID: 101301
	SSkillInfo SourceSkillInfo { get; }

	// Token: 0x1700273B RID: 10043
	// (get) Token: 0x06018BB6 RID: 101302
	ISkillParam SkillParam { get; }

	// Token: 0x1700273C RID: 10044
	// (get) Token: 0x06018BB7 RID: 101303
	IReadOnlyList<Skill> SkillsToInterrupt { get; }

	// Token: 0x1700273D RID: 10045
	// (get) Token: 0x06018BB8 RID: 101304
	Action InterruptSourceSkillTargets { get; }
}
