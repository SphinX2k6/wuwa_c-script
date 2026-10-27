using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F22 RID: 12066
[NullableContext(2)]
[Nullable(0)]
public class ExtraEffectParameters
{
	// Token: 0x0400C1B3 RID: 49587
	public EExtraEffectId ExtraEffectId = EExtraEffectId.AddBuff;

	// Token: 0x0400C1B4 RID: 49588
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] ExtraEffectParameters_;

	// Token: 0x0400C1B5 RID: 49589
	public float[] ExtraEffectGrowParameters1;

	// Token: 0x0400C1B6 RID: 49590
	public float[] ExtraEffectGrowParameters2;

	// Token: 0x0400C1B7 RID: 49591
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] ExtraEffectGrowParameters3;

	// Token: 0x0400C1B8 RID: 49592
	public int[] ExtraEffectRequirement;

	// Token: 0x0400C1B9 RID: 49593
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] ExtraEffectRequirementPara;

	// Token: 0x0400C1BA RID: 49594
	public int ExtraEffectRequirementSetting;

	// Token: 0x0400C1BB RID: 49595
	public float[] ExtraEffectCd;

	// Token: 0x0400C1BC RID: 49596
	public float[] ExtraEffectCdForTarget;

	// Token: 0x0400C1BD RID: 49597
	public int ExtraEffectRemoveStackNum;

	// Token: 0x0400C1BE RID: 49598
	public float[] ExtraEffectProbability;

	// Token: 0x0400C1BF RID: 49599
	public BuffExecution ExecutionEffect;
}
