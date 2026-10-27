using System;
using System.Runtime.CompilerServices;

// Token: 0x02003177 RID: 12663
[NullableContext(1)]
[Nullable(0)]
public abstract class CodeSkillBase
{
	// Token: 0x0601B3BA RID: 111546 RVA: 0x0076DB79 File Offset: 0x0076BD79
	protected CodeSkillBase(SpecialSkillBase specialSkill)
	{
		this.SpecialSkill = specialSkill;
	}

	// Token: 0x170025BB RID: 9659
	// (get) Token: 0x0601B3BB RID: 111547 RVA: 0x0076DB88 File Offset: 0x0076BD88
	protected Entity Entity
	{
		get
		{
			return this.SpecialSkill.GetOwnerEntity();
		}
	}

	// Token: 0x170025BC RID: 9660
	// (get) Token: 0x0601B3BC RID: 111548 RVA: 0x0076DB95 File Offset: 0x0076BD95
	protected BaseSkillComponent SkillComp
	{
		get
		{
			return this.SpecialSkill.GetSkillComp();
		}
	}

	// Token: 0x0601B3BD RID: 111549 RVA: 0x0076DBA2 File Offset: 0x0076BDA2
	public virtual void OnBegin(Skill skill)
	{
	}

	// Token: 0x0601B3BE RID: 111550 RVA: 0x0076DBA4 File Offset: 0x0076BDA4
	public virtual void OnTick(float delta, Skill skill)
	{
	}

	// Token: 0x0601B3BF RID: 111551 RVA: 0x0076DBA6 File Offset: 0x0076BDA6
	public virtual void OnEnd(Skill skill)
	{
	}

	// Token: 0x0601B3C0 RID: 111552 RVA: 0x0076DBA8 File Offset: 0x0076BDA8
	public virtual void OnInterrupt(Skill skill)
	{
	}

	// Token: 0x0601B3C1 RID: 111553 RVA: 0x0076DBAA File Offset: 0x0076BDAA
	protected void EndSelf(Skill skill)
	{
		this.SkillComp.DoSkillEnd(skill);
	}

	// Token: 0x0400D476 RID: 54390
	protected readonly SpecialSkillBase SpecialSkill;
}
