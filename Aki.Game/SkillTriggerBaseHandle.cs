using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x0200315E RID: 12638
[NullableContext(1)]
[Nullable(0)]
public abstract class SkillTriggerBaseHandle
{
	// Token: 0x0601B318 RID: 111384 RVA: 0x007686C4 File Offset: 0x007668C4
	protected SkillTriggerBaseHandle(Entity entity)
	{
		this.Entity = entity;
	}

	// Token: 0x0601B319 RID: 111385 RVA: 0x007686D3 File Offset: 0x007668D3
	public static T Spawn<[Nullable(0)] T>(Entity entity) where T : SkillTriggerBaseHandle
	{
		T t = (T)((object)Activator.CreateInstance(typeof(T), new object[]
		{
			entity
		}));
		t.Create();
		return t;
	}

	// Token: 0x0601B31A RID: 111386 RVA: 0x007686FE File Offset: 0x007668FE
	public virtual void Create()
	{
	}

	// Token: 0x0601B31B RID: 111387 RVA: 0x00768700 File Offset: 0x00766900
	public virtual void Destroy()
	{
	}

	// Token: 0x0601B31C RID: 111388 RVA: 0x00768702 File Offset: 0x00766902
	public virtual void AddSkillTrigger(SkillTriggerBase skillTrigger, int skillId, SSkillInfo info)
	{
	}

	// Token: 0x0400D3AA RID: 54186
	protected readonly Entity Entity;
}
