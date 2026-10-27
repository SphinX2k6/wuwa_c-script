using System;

// Token: 0x020016ED RID: 5869
public class AttributeValueData
{
	// Token: 0x0600A852 RID: 43090 RVA: 0x0025D6ED File Offset: 0x0025B8ED
	public AttributeValueData(int attributeId, double attributeValue, bool isRatio)
	{
		this.AttributeId = attributeId;
		this.AttributeValue = attributeValue;
		this.IsRatio = isRatio;
	}

	// Token: 0x04004BCC RID: 19404
	public int AttributeId;

	// Token: 0x04004BCD RID: 19405
	public double AttributeValue;

	// Token: 0x04004BCE RID: 19406
	public bool IsRatio;
}
