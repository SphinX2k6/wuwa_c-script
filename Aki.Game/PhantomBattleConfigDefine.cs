using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002404 RID: 9220
public class PhantomBattleConfigDefine : IStaticVariableResetter
{
	// Token: 0x0601277C RID: 75644 RVA: 0x0048DB01 File Offset: 0x0048BD01
	static PhantomBattleConfigDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomBattleConfigDefine.CreateStaticDefaultValue), new Action(PhantomBattleConfigDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0601277D RID: 75645 RVA: 0x0048DB20 File Offset: 0x0048BD20
	public static void ResetStaticDefaultValue()
	{
		PhantomBattleConfigDefine.COSTLIST = null;
	}

	// Token: 0x0601277E RID: 75646 RVA: 0x0048DB28 File Offset: 0x0048BD28
	public static void CreateStaticDefaultValue()
	{
		PhantomBattleConfigDefine.COSTLIST = new List<int>
		{
			1,
			3,
			4
		};
	}

	// Token: 0x04008B6A RID: 35690
	public const int COST3 = 3;

	// Token: 0x04008B6B RID: 35691
	public const int COST1 = 1;

	// Token: 0x04008B6C RID: 35692
	[Nullable(2)]
	public static List<int> COSTLIST;
}
