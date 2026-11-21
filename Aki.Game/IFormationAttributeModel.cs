using System;

// Token: 0x020003BD RID: 957
public interface IFormationAttributeModel
{
	// Token: 0x06003452 RID: 13394
	float GetValue(EFormationAttributeId attrId);

	// Token: 0x06003453 RID: 13395
	float GetMax(EFormationAttributeId attrId);

	// Token: 0x06003454 RID: 13396
	float GetSpeed(EFormationAttributeId attrId);
}
