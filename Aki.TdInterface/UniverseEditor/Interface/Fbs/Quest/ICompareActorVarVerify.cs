using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D9C RID: 15772
	public static class ICompareActorVarVerify
	{
		// Token: 0x06015E9C RID: 89756 RVA: 0x00329FAC File Offset: 0x003281AC
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

		// Token: 0x020078C3 RID: 30915
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013147 RID: 78151
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013148 RID: 78152
			public static VerifyTableAction <1>__Verify;
		}
	}
}
