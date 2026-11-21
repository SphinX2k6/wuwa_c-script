using System;

// Token: 0x0200022C RID: 556
public interface IGameCapability
{
	// Token: 0x0600231D RID: 8989
	bool ShouldActivate();

	// Token: 0x0600231E RID: 8990
	void Activate();

	// Token: 0x0600231F RID: 8991
	void OnActivated();

	// Token: 0x06002320 RID: 8992
	bool ShouldDeactivate();

	// Token: 0x06002321 RID: 8993
	void Deactivate();

	// Token: 0x06002322 RID: 8994 RVA: 0x000DF88B File Offset: 0x000DDA8B
	bool? ShouldTickActive()
	{
		return new bool?(false);
	}

	// Token: 0x06002323 RID: 8995
	void OnDeactivated();

	// Token: 0x06002324 RID: 8996
	void TickActive(float deltaTime);
}
