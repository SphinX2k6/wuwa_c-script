using System;
using System.Runtime.CompilerServices;

// Token: 0x0200022E RID: 558
public interface IWaterDetectedCapability : IGameCapability
{
	// Token: 0x0600232E RID: 9006
	void OnWaterDetectedStart();

	// Token: 0x0600232F RID: 9007
	void OnWaterDetectedEnd();

	// Token: 0x06002330 RID: 9008
	[NullableContext(1)]
	void OnWaterDetectedTick(float deltaTime, Vector impactPoint, Vector impactNormal);
}
