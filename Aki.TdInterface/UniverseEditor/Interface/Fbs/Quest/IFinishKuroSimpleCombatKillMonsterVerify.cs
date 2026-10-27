using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E3E RID: 15934
	public static class IFinishKuroSimpleCombatKillMonsterVerify
	{
		// Token: 0x060165A2 RID: 91554 RVA: 0x00339F90 File Offset: 0x00338190
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

		// Token: 0x020078E0 RID: 30944
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401318A RID: 78218
			public static VerifyTableAction <0>__Verify;
		}
	}
}
