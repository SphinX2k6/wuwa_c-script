using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020018E9 RID: 6377
public class PhantomBattleConfigDefine : IStaticVariableResetter
{
	// Token: 0x0600FC32 RID: 64562 RVA: 0x0049B125 File Offset: 0x00499325
	static PhantomBattleConfigDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomBattleConfigDefine.CreateStaticDefaultValue), new Action(PhantomBattleConfigDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600FC33 RID: 64563 RVA: 0x0049B144 File Offset: 0x00499344
	public static void ResetStaticDefaultValue()
	{
		PhantomBattleConfigDefine.COSTLIST = null;
	}

	// Token: 0x0600FC34 RID: 64564 RVA: 0x0049B14C File Offset: 0x0049934C
	public static void CreateStaticDefaultValue()
	{
		PhantomBattleConfigDefine.COSTLIST = new List<int>
		{
			1,
			3,
			4
		};
	}

	// Token: 0x04008CB1 RID: 36017
	public const int COST3 = 3;

	// Token: 0x04008CB2 RID: 36018
	public const int COST1 = 1;

	// Token: 0x04008CB3 RID: 36019
	[Nullable(2)]
	public static List<int> COSTLIST;
}
