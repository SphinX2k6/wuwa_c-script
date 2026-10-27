using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003057 RID: 12375
[NullableContext(1)]
[Nullable(0)]
public class MotorHandIkConfigs
{
	// Token: 0x0601A4FB RID: 107771 RVA: 0x006F9300 File Offset: 0x006F7500
	public MotorHandIkConfigs(Transform handTrans, bool isRight)
	{
		this.HandTrans = handTrans;
		if (isRight)
		{
			this.MotorBone = FNameUtil.GetDynamicFName("Bone_Other002_R").Value;
			this.HandName = FNameUtil.GetDynamicFName("Bip001RHand").Value;
			return;
		}
		this.MotorBone = FNameUtil.GetDynamicFName("Bone_Other002_L").Value;
		this.HandName = FNameUtil.GetDynamicFName("Bip001LHand").Value;
	}

	// Token: 0x0400C8A9 RID: 51369
	public FName MotorBone = FNameUtil.EMPTY;

	// Token: 0x0400C8AA RID: 51370
	public FName HandName = FNameUtil.EMPTY;

	// Token: 0x0400C8AB RID: 51371
	public Transform HandTrans;
}
