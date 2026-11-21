using System;
using System.Runtime.CompilerServices;

// Token: 0x0200274C RID: 10060
public abstract class PerformAction
{
	// Token: 0x06019403 RID: 103427 RVA: 0x007B681A File Offset: 0x007B4A1A
	[NullableContext(1)]
	public virtual void Register(Entity entity)
	{
		this.Entity = entity;
	}

	// Token: 0x06019404 RID: 103428 RVA: 0x007B6823 File Offset: 0x007B4A23
	public virtual void UnRegister()
	{
		this.Entity = null;
	}

	// Token: 0x06019405 RID: 103429 RVA: 0x007B682C File Offset: 0x007B4A2C
	public virtual void Begin()
	{
	}

	// Token: 0x06019406 RID: 103430 RVA: 0x007B682E File Offset: 0x007B4A2E
	public virtual void Tick(double delta)
	{
	}

	// Token: 0x06019407 RID: 103431 RVA: 0x007B6830 File Offset: 0x007B4A30
	public virtual void End()
	{
	}

	// Token: 0x0400DCF1 RID: 56561
	public EPerformActionType Type;

	// Token: 0x0400DCF2 RID: 56562
	[Nullable(2)]
	public Entity Entity;
}
