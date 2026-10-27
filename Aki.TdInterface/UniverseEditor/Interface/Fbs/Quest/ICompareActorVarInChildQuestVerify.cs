using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D9F RID: 15775
	public static class ICompareActorVarInChildQuestVerify
	{
		// Token: 0x06015EC3 RID: 89795 RVA: 0x0032A600 File Offset: 0x00328800
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICompareActorVarInChildQuestVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICompareActorVarInChildQuestVerify.<>O.<0>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset = 10;
					short valueVOffset = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICompareActorVarInChildQuestVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICompareActorVarInChildQuestVerify.<>O.<1>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078C4 RID: 30916
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013149 RID: 78153
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401314A RID: 78154
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
