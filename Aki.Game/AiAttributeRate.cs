using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Monster.Common;

// Token: 0x020000DA RID: 218
public class AiAttributeRate
{
	// Token: 0x06000CE8 RID: 3304 RVA: 0x00044B64 File Offset: 0x00042D64
	public AiAttributeRate(SAiAttributeRate aiAttributeRate)
	{
		this.Denominator = (EAttributeType)aiAttributeRate.Denominator;
		this.Numerator = (EAttributeType)aiAttributeRate.Numerator;
		this.Range = new TsFloatRange(aiAttributeRate.Range.LowerBound.Type == 0, aiAttributeRate.Range.LowerBound.Value, aiAttributeRate.Range.UpperBound.Value);
	}

	// Token: 0x04000A40 RID: 2624
	public EAttributeType Denominator;

	// Token: 0x04000A41 RID: 2625
	public EAttributeType Numerator;

	// Token: 0x04000A42 RID: 2626
	[Nullable(1)]
	public TsFloatRange Range;
}
