using System;

// Token: 0x02000BA5 RID: 2981
public class AttributeValueData
{
	// Token: 0x06007C32 RID: 31794 RVA: 0x00267B0D File Offset: 0x00265D0D
	public AttributeValueData(int attributeId, double attributeValue, bool isRatio)
	{
		this.AttributeId = attributeId;
		this.AttributeValue = attributeValue;
		this.IsRatio = isRatio;
	}

	// Token: 0x04004C73 RID: 19571
	public int AttributeId;

	// Token: 0x04004C74 RID: 19572
	public double AttributeValue;

	// Token: 0x04004C75 RID: 19573
	public bool IsRatio;
}
