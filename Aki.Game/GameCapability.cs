using System;

// Token: 0x0200022D RID: 557
public class GameCapability : IGameCapability
{
	// Token: 0x06002325 RID: 8997 RVA: 0x000DF893 File Offset: 0x000DDA93
	public virtual bool ShouldActivate()
	{
		return false;
	}

	// Token: 0x06002326 RID: 8998 RVA: 0x000DF896 File Offset: 0x000DDA96
	public virtual void Activate()
	{
	}

	// Token: 0x06002327 RID: 8999 RVA: 0x000DF898 File Offset: 0x000DDA98
	public virtual void OnActivated()
	{
	}

	// Token: 0x06002328 RID: 9000 RVA: 0x000DF89A File Offset: 0x000DDA9A
	public virtual bool ShouldDeactivate()
	{
		return false;
	}

	// Token: 0x06002329 RID: 9001 RVA: 0x000DF89D File Offset: 0x000DDA9D
	public virtual void Deactivate()
	{
	}

	// Token: 0x0600232A RID: 9002 RVA: 0x000DF89F File Offset: 0x000DDA9F
	public virtual bool? ShouldTickActive()
	{
		return new bool?(false);
	}

	// Token: 0x0600232B RID: 9003 RVA: 0x000DF8A7 File Offset: 0x000DDAA7
	public virtual void OnDeactivated()
	{
	}

	// Token: 0x0600232C RID: 9004 RVA: 0x000DF8A9 File Offset: 0x000DDAA9
	public virtual void TickActive(float deltaTime)
	{
	}
}
