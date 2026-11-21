using System;
using System.Runtime.CompilerServices;

// Token: 0x020026D8 RID: 9944
[NullableContext(1)]
[Nullable(0)]
public abstract class CodeAnimNotifyBase<[Nullable(0)] TSpecialSkill> : CodeAnimNotifyBase where TSpecialSkill : SpecialSkillBase
{
	// Token: 0x06018E70 RID: 102000 RVA: 0x0079273E File Offset: 0x0079093E
	public CodeAnimNotifyBase(TSpecialSkill specialSkill)
	{
		this.SpecialSkill = specialSkill;
	}

	// Token: 0x0400D878 RID: 55416
	protected readonly TSpecialSkill SpecialSkill;
}
