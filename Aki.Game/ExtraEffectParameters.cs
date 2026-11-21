using System;
using System.Runtime.CompilerServices;

// Token: 0x02002475 RID: 9333
[NullableContext(2)]
[Nullable(0)]
public class ExtraEffectParameters
{
	// Token: 0x0400C555 RID: 50517
	public EExtraEffectId ExtraEffectId = EExtraEffectId.AddBuff;

	// Token: 0x0400C556 RID: 50518
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] ExtraEffectParameters_;

	// Token: 0x0400C557 RID: 50519
	public float[] ExtraEffectGrowParameters1;

	// Token: 0x0400C558 RID: 50520
	public float[] ExtraEffectGrowParameters2;

	// Token: 0x0400C559 RID: 50521
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] ExtraEffectGrowParameters3;

	// Token: 0x0400C55A RID: 50522
	public int[] ExtraEffectRequirement;

	// Token: 0x0400C55B RID: 50523
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] ExtraEffectRequirementPara;

	// Token: 0x0400C55C RID: 50524
	public int ExtraEffectRequirementSetting;

	// Token: 0x0400C55D RID: 50525
	public float[] ExtraEffectCd;

	// Token: 0x0400C55E RID: 50526
	public float[] ExtraEffectCdForTarget;

	// Token: 0x0400C55F RID: 50527
	public int ExtraEffectRemoveStackNum;

	// Token: 0x0400C560 RID: 50528
	public float[] ExtraEffectProbability;

	// Token: 0x0400C561 RID: 50529
	public BuffExecution ExecutionEffect;
}
