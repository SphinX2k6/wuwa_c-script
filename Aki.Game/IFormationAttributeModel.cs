using System;

// Token: 0x02000F08 RID: 3848
public interface IFormationAttributeModel
{
	// Token: 0x060060BA RID: 24762
	float GetValue(EFormationAttributeId attrId);

	// Token: 0x060060BB RID: 24763
	float GetMax(EFormationAttributeId attrId);

	// Token: 0x060060BC RID: 24764
	float GetSpeed(EFormationAttributeId attrId);
}
