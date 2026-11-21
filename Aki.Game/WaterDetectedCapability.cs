using System;
using System.Runtime.CompilerServices;

// Token: 0x0200022F RID: 559
public class WaterDetectedCapability : GameCapability, IWaterDetectedCapability, IGameCapability
{
	// Token: 0x06002331 RID: 9009 RVA: 0x000DF8B3 File Offset: 0x000DDAB3
	public virtual void OnWaterDetectedStart()
	{
	}

	// Token: 0x06002332 RID: 9010 RVA: 0x000DF8B5 File Offset: 0x000DDAB5
	public virtual void OnWaterDetectedEnd()
	{
	}

	// Token: 0x06002333 RID: 9011 RVA: 0x000DF8B7 File Offset: 0x000DDAB7
	[NullableContext(1)]
	public virtual void OnWaterDetectedTick(float deltaTime, Vector impactPoint, Vector impactNormal)
	{
	}
}
