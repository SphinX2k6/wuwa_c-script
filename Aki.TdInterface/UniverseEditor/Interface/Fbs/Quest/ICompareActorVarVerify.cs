using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B3 RID: 16819
	public static class ICompareActorVarVerify
	{
		// Token: 0x060173D4 RID: 95188 RVA: 0x003512D8 File Offset: 0x0034F4D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICompareActorVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICompareActorVarVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICompareActorVarVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICompareActorVarVerify.<>O.<1>__Verify = new VerifyTableAction(ICompareActorVarInChildQuestVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008107 RID: 33031
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141A3 RID: 82339
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141A4 RID: 82340
			public static VerifyTableAction <1>__Verify;
		}
	}
}
