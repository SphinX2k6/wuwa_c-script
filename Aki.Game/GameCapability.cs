using System;

// Token: 0x02000229 RID: 553
public class GameCapability : IGameCapability
{
	// Token: 0x0600226D RID: 8813 RVA: 0x000D93D3 File Offset: 0x000D75D3
	public virtual bool ShouldActivate()
	{
		return false;
	}

	// Token: 0x0600226E RID: 8814 RVA: 0x000D93D6 File Offset: 0x000D75D6
	public virtual void Activate()
	{
	}

	// Token: 0x0600226F RID: 8815 RVA: 0x000D93D8 File Offset: 0x000D75D8
	public virtual void OnActivated()
	{
	}

	// Token: 0x06002270 RID: 8816 RVA: 0x000D93DA File Offset: 0x000D75DA
	public virtual bool ShouldDeactivate()
	{
		return false;
	}

	// Token: 0x06002271 RID: 8817 RVA: 0x000D93DD File Offset: 0x000D75DD
	public virtual void Deactivate()
	{
	}

	// Token: 0x06002272 RID: 8818 RVA: 0x000D93DF File Offset: 0x000D75DF
	public virtual bool? ShouldTickActive()
	{
		return new bool?(false);
	}

	// Token: 0x06002273 RID: 8819 RVA: 0x000D93E7 File Offset: 0x000D75E7
	public virtual void OnDeactivated()
	{
	}

	// Token: 0x06002274 RID: 8820 RVA: 0x000D93E9 File Offset: 0x000D75E9
	public virtual void TickActive(float deltaTime)
	{
	}
}
