using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200426A RID: 17002
	public static class IFinishArcadeGameplayVerify
	{
		// Token: 0x06017B2D RID: 97069 RVA: 0x00361610 File Offset: 0x0035F810
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

		// Token: 0x02008121 RID: 33057
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141E0 RID: 82400
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141E1 RID: 82401
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
