using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200420A RID: 16906
	public static class IDetectCombatState2ConditionVerify
	{
		// Token: 0x0601778D RID: 96141 RVA: 0x0035A1D4 File Offset: 0x003583D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDetectCombatState2ConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDetectCombatState2ConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDetectCombatState2ConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDetectCombatState2ConditionVerify.<>O.<1>__Verify = new VerifyTableAction(ICombatState2ConditionVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008116 RID: 33046
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141CF RID: 82383
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141D0 RID: 82384
			public static VerifyTableAction <1>__Verify;
		}
	}
}
