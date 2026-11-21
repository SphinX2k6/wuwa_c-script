using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EC1 RID: 3777
public class PinballBattleDamageNumFormatRule : IDamageNumFormatRule
{
	// Token: 0x060096F3 RID: 38643 RVA: 0x002CBD44 File Offset: 0x002C9F44
	[NullableContext(1)]
	public string FormatNumber(float num)
	{
		if (num >= 1000000f)
		{
			double value = Math.Floor((double)(num / 1000000f));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<double>(value);
			defaultInterpolatedStringHandler.AppendLiteral("M");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		if (num >= 1000f)
		{
			double value2 = Math.Floor((double)(num / 1000f));
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<double>(value2);
			defaultInterpolatedStringHandler.AppendLiteral("K");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return num.ToString();
	}
}
