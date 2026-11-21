using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020023B1 RID: 9137
public class AttributeSnapshot : IAttributeSet
{
	// Token: 0x06016DB8 RID: 93624 RVA: 0x006A9260 File Offset: 0x006A7460
	public float GetBaseValue(EAttributeType attrId)
	{
		return this.BaseValues[(int)attrId];
	}

	// Token: 0x06016DB9 RID: 93625 RVA: 0x006A926A File Offset: 0x006A746A
	public float GetCurrentValue(EAttributeType attrId)
	{
		return this.CurrentValues[(int)attrId];
	}

	// Token: 0x0400BFC4 RID: 49092
	[Nullable(1)]
	public readonly float[] BaseValues = new float[143];

	// Token: 0x0400BFC5 RID: 49093
	[Nullable(1)]
	public readonly float[] CurrentValues = new float[143];
}
