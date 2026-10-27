using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DCF RID: 15823
	public static class IDetectCombatState2ConditionVerify
	{
		// Token: 0x0601616E RID: 90478 RVA: 0x003317D0 File Offset: 0x0032F9D0
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

		// Token: 0x020078D0 RID: 30928
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013171 RID: 78193
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013172 RID: 78194
			public static VerifyTableAction <1>__Verify;
		}
	}
}
