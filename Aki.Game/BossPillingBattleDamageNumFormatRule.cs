using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EC2 RID: 3778
public class BossPillingBattleDamageNumFormatRule : IDamageNumFormatRule
{
	// Token: 0x060096F5 RID: 38645 RVA: 0x002CBDD8 File Offset: 0x002C9FD8
	[NullableContext(1)]
	public string FormatNumber(float num)
	{
		if ((double)num >= 100000.0)
		{
			return (Math.Floor((double)num / 100000.0 * 100.0) / 100.0).ToString() + "M";
		}
		return num.ToString();
	}

	// Token: 0x04005AB6 RID: 23222
	private const double DAMAGECHECK = 100000.0;
}
