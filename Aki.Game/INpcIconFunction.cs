using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020017B8 RID: 6072
[NullableContext(1)]
public interface INpcIconFunction
{
	// Token: 0x0600ECAD RID: 60589
	Vector GetSelfLocation();

	// Token: 0x0600ECAE RID: 60590
	[NullableContext(2)]
	UPrimitiveComponent GetAttachToMeshComponent();

	// Token: 0x0600ECAF RID: 60591
	string GetAttachToSocketName();

	// Token: 0x0600ECB0 RID: 60592
	void GetAttachToLocation(Vector outVec);

	// Token: 0x0600ECB1 RID: 60593
	double GetAddOffsetZ();

	// Token: 0x0600ECB2 RID: 60594
	bool IsShowNameInfo();

	// Token: 0x0600ECB3 RID: 60595
	bool IsShowPlayerInfo();

	// Token: 0x0600ECB4 RID: 60596
	bool IsShowQuestInfo();

	// Token: 0x0600ECB5 RID: 60597
	float GetDialogWorldScale3D();

	// Token: 0x0600ECB6 RID: 60598
	bool CanTick(float deltaTime);

	// Token: 0x0600ECB7 RID: 60599
	bool IsInHeadItemShowRange(double disSquared, double maxShowRangeDisSquared, double minShowRangeDisSquared);

	// Token: 0x0600ECB8 RID: 60600
	bool TryGetHeadStateFollowData(HeadStateFollowData outData);
}
