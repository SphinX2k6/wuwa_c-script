using System;
using System.Runtime.CompilerServices;

// Token: 0x0200316B RID: 12651
[NullableContext(1)]
[Nullable(0)]
public abstract class CodeAnimNotifyBase<[Nullable(0)] TSpecialSkill> : CodeAnimNotifyBase where TSpecialSkill : SpecialSkillBase
{
	// Token: 0x0601B36B RID: 111467 RVA: 0x0076ADDA File Offset: 0x00768FDA
	public CodeAnimNotifyBase(TSpecialSkill specialSkill)
	{
		this.SpecialSkill = specialSkill;
	}

	// Token: 0x0400D415 RID: 54293
	protected readonly TSpecialSkill SpecialSkill;
}
