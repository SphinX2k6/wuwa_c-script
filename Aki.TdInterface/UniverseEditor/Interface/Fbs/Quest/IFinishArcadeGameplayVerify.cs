using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E2F RID: 15919
	public static class IFinishArcadeGameplayVerify
	{
		// Token: 0x06016500 RID: 91392 RVA: 0x00338A18 File Offset: 0x00336C18
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishArcadeGameplayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishArcadeGameplayVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFinishArcadeGameplayVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFinishArcadeGameplayVerify.<>O.<1>__Verify = new VerifyUnionAction(TArcadeGameplayVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078DB RID: 30939
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013182 RID: 78210
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013183 RID: 78211
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
