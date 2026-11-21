using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Monster.Common;

// Token: 0x020000DA RID: 218
public class AiAttributeRate
{
	// Token: 0x06000CEE RID: 3310 RVA: 0x000456F8 File Offset: 0x000438F8
	public AiAttributeRate(SAiAttributeRate aiAttributeRate)
	{
		this.Denominator = (EAttributeType)aiAttributeRate.Denominator;
		this.Numerator = (EAttributeType)aiAttributeRate.Numerator;
		this.Range = new TsFloatRange(aiAttributeRate.Range.LowerBound.Type == 0, aiAttributeRate.Range.LowerBound.Value, aiAttributeRate.Range.UpperBound.Value);
	}

	// Token: 0x04000A48 RID: 2632
	public EAttributeType Denominator;

	// Token: 0x04000A49 RID: 2633
	public EAttributeType Numerator;

	// Token: 0x04000A4A RID: 2634
	[Nullable(1)]
	public TsFloatRange Range;
}
