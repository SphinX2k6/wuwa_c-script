using System;
using System.Runtime.CompilerServices;

// Token: 0x0200022B RID: 555
public class WaterDetectedCapability : GameCapability, IWaterDetectedCapability, IGameCapability
{
	// Token: 0x06002279 RID: 8825 RVA: 0x000D93F3 File Offset: 0x000D75F3
	public virtual void OnWaterDetectedStart()
	{
	}

	// Token: 0x0600227A RID: 8826 RVA: 0x000D93F5 File Offset: 0x000D75F5
	public virtual void OnWaterDetectedEnd()
	{
	}

	// Token: 0x0600227B RID: 8827 RVA: 0x000D93F7 File Offset: 0x000D75F7
	[NullableContext(1)]
	public virtual void OnWaterDetectedTick(float deltaTime, Vector impactPoint, Vector impactNormal)
	{
	}
}
