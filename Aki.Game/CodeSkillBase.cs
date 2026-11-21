using System;
using System.Runtime.CompilerServices;

// Token: 0x020026E4 RID: 9956
[NullableContext(1)]
[Nullable(0)]
public abstract class CodeSkillBase
{
	// Token: 0x06018EBF RID: 102079 RVA: 0x007954DD File Offset: 0x007936DD
	protected CodeSkillBase(SpecialSkillBase specialSkill)
	{
		this.SpecialSkill = specialSkill;
	}

	// Token: 0x170027AC RID: 10156
	// (get) Token: 0x06018EC0 RID: 102080 RVA: 0x007954EC File Offset: 0x007936EC
	protected Entity Entity
	{
		get
		{
			return this.SpecialSkill.GetOwnerEntity();
		}
	}

	// Token: 0x170027AD RID: 10157
	// (get) Token: 0x06018EC1 RID: 102081 RVA: 0x007954F9 File Offset: 0x007936F9
	protected BaseSkillComponent SkillComp
	{
		get
		{
			return this.SpecialSkill.GetSkillComp();
		}
	}

	// Token: 0x06018EC2 RID: 102082 RVA: 0x00795506 File Offset: 0x00793706
	public virtual void OnBegin(Skill skill)
	{
	}

	// Token: 0x06018EC3 RID: 102083 RVA: 0x00795508 File Offset: 0x00793708
	public virtual void OnTick(float delta, Skill skill)
	{
	}

	// Token: 0x06018EC4 RID: 102084 RVA: 0x0079550A File Offset: 0x0079370A
	public virtual void OnEnd(Skill skill)
	{
	}

	// Token: 0x06018EC5 RID: 102085 RVA: 0x0079550C File Offset: 0x0079370C
	public virtual void OnInterrupt(Skill skill)
	{
	}

	// Token: 0x06018EC6 RID: 102086 RVA: 0x0079550E File Offset: 0x0079370E
	protected void EndSelf(Skill skill)
	{
		this.SkillComp.DoSkillEnd(skill);
	}

	// Token: 0x0400D8D9 RID: 55513
	protected readonly SpecialSkillBase SpecialSkill;
}
