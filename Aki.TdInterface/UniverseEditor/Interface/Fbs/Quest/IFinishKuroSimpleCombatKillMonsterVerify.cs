using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004279 RID: 17017
	public static class IFinishKuroSimpleCombatKillMonsterVerify
	{
		// Token: 0x06017BC9 RID: 97225 RVA: 0x00362AC0 File Offset: 0x00360CC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishKuroSimpleCombatKillMonsterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishKuroSimpleCombatKillMonsterVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008126 RID: 33062
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141E8 RID: 82408
			public static VerifyTableAction <0>__Verify;
		}
	}
}
