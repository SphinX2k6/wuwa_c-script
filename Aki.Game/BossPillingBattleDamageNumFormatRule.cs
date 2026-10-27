using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A03 RID: 6659
public class BossPillingBattleDamageNumFormatRule : IDamageNumFormatRule
{
	// Token: 0x0600C2E7 RID: 49895 RVA: 0x002C0DEC File Offset: 0x002BEFEC
	[NullableContext(1)]
	public string FormatNumber(float num)
	{
		if ((double)num >= 100000.0)
		{
			return (Math.Floor((double)num / 100000.0 * 100.0) / 100.0).ToString() + "M";
		}
		return num.ToString();
	}

	// Token: 0x040059E7 RID: 23015
	private const double DAMAGECHECK = 100000.0;
}
