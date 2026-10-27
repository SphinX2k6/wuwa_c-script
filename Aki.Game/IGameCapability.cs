using System;

// Token: 0x02000228 RID: 552
public interface IGameCapability
{
	// Token: 0x06002265 RID: 8805
	bool ShouldActivate();

	// Token: 0x06002266 RID: 8806
	void Activate();

	// Token: 0x06002267 RID: 8807
	void OnActivated();

	// Token: 0x06002268 RID: 8808
	bool ShouldDeactivate();

	// Token: 0x06002269 RID: 8809
	void Deactivate();

	// Token: 0x0600226A RID: 8810 RVA: 0x000D93CB File Offset: 0x000D75CB
	bool? ShouldTickActive()
	{
		return new bool?(false);
	}

	// Token: 0x0600226B RID: 8811
	void OnDeactivated();

	// Token: 0x0600226C RID: 8812
	void TickActive(float deltaTime);
}
