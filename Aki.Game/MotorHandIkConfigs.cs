using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020025AD RID: 9645
[NullableContext(1)]
[Nullable(0)]
public class MotorHandIkConfigs
{
	// Token: 0x06017E9C RID: 97948 RVA: 0x00720420 File Offset: 0x0071E620
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

	// Token: 0x0400CC83 RID: 52355
	public FName MotorBone = FNameUtil.EMPTY;

	// Token: 0x0400CC84 RID: 52356
	public FName HandName = FNameUtil.EMPTY;

	// Token: 0x0400CC85 RID: 52357
	public Transform HandTrans;
}
