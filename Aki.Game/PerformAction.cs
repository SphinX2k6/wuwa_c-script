using System;
using System.Runtime.CompilerServices;

// Token: 0x020031DD RID: 12765
public abstract class PerformAction
{
	// Token: 0x0601B88A RID: 112778 RVA: 0x0078DF21 File Offset: 0x0078C121
	[NullableContext(1)]
	public virtual void Register(Entity entity)
	{
		this.Entity = entity;
	}

	// Token: 0x0601B88B RID: 112779 RVA: 0x0078DF2A File Offset: 0x0078C12A
	public virtual void UnRegister()
	{
		this.Entity = null;
	}

	// Token: 0x0601B88C RID: 112780 RVA: 0x0078DF33 File Offset: 0x0078C133
	public virtual void Begin()
	{
	}

	// Token: 0x0601B88D RID: 112781 RVA: 0x0078DF35 File Offset: 0x0078C135
	public virtual void Tick(double delta)
	{
	}

	// Token: 0x0601B88E RID: 112782 RVA: 0x0078DF37 File Offset: 0x0078C137
	public virtual void End()
	{
	}

	// Token: 0x0400D853 RID: 55379
	public EPerformActionType Type;

	// Token: 0x0400D854 RID: 55380
	[Nullable(2)]
	public Entity Entity;
}
