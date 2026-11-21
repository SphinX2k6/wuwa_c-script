using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;

// Token: 0x020026CB RID: 9931
[NullableContext(1)]
[Nullable(0)]
public abstract class SkillTriggerBaseHandle
{
	// Token: 0x06018E1D RID: 101917 RVA: 0x00790090 File Offset: 0x0078E290
	protected SkillTriggerBaseHandle(Entity entity)
	{
		this.Entity = entity;
	}

	// Token: 0x06018E1E RID: 101918 RVA: 0x0079009F File Offset: 0x0078E29F
	public static T Spawn<[Nullable(0)] T>(Entity entity) where T : SkillTriggerBaseHandle
	{
		T t = (T)((object)Activator.CreateInstance(typeof(T), new object[]
		{
			entity
		}));
		t.Create();
		return t;
	}

	// Token: 0x06018E1F RID: 101919 RVA: 0x007900CA File Offset: 0x0078E2CA
	public virtual void Create()
	{
	}

	// Token: 0x06018E20 RID: 101920 RVA: 0x007900CC File Offset: 0x0078E2CC
	public virtual void Destroy()
	{
	}

	// Token: 0x06018E21 RID: 101921 RVA: 0x007900CE File Offset: 0x0078E2CE
	public virtual void AddSkillTrigger(SkillTriggerBase skillTrigger, int skillId, SSkillInfo info)
	{
	}

	// Token: 0x0400D80D RID: 55309
	protected readonly Entity Entity;
}
