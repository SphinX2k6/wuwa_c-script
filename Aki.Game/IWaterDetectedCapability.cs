using System;
using System.Runtime.CompilerServices;

// Token: 0x0200022A RID: 554
public interface IWaterDetectedCapability : IGameCapability
{
	// Token: 0x06002276 RID: 8822
	void OnWaterDetectedStart();

	// Token: 0x06002277 RID: 8823
	void OnWaterDetectedEnd();

	// Token: 0x06002278 RID: 8824
	[NullableContext(1)]
	void OnWaterDetectedTick(float deltaTime, Vector impactPoint, Vector impactNormal);
}
