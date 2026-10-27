using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020022D4 RID: 8916
[NullableContext(1)]
public interface INpcIconFunction
{
	// Token: 0x06011816 RID: 71702
	Vector GetSelfLocation();

	// Token: 0x06011817 RID: 71703
	[NullableContext(2)]
	UPrimitiveComponent GetAttachToMeshComponent();

	// Token: 0x06011818 RID: 71704
	string GetAttachToSocketName();

	// Token: 0x06011819 RID: 71705
	void GetAttachToLocation(Vector outVec);

	// Token: 0x0601181A RID: 71706
	double GetAddOffsetZ();

	// Token: 0x0601181B RID: 71707
	bool IsShowNameInfo();

	// Token: 0x0601181C RID: 71708
	bool IsShowPlayerInfo();

	// Token: 0x0601181D RID: 71709
	bool IsShowQuestInfo();

	// Token: 0x0601181E RID: 71710
	float GetDialogWorldScale3D();

	// Token: 0x0601181F RID: 71711
	bool CanTick(float deltaTime);

	// Token: 0x06011820 RID: 71712
	bool IsInHeadItemShowRange(double disSquared, double maxShowRangeDisSquared, double minShowRangeDisSquared);

	// Token: 0x06011821 RID: 71713
	bool TryGetHeadStateFollowData(HeadStateFollowData outData);
}
