using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006354 RID: 25428
	public static class ICharacterMoveToPointVerify
	{
		// Token: 0x0602BFC8 RID: 180168 RVA: 0x0060B6FC File Offset: 0x006098FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICharacterMoveToPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICharacterMoveToPointVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICharacterMoveToPointVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICharacterMoveToPointVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D14 RID: 32020
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013878 RID: 79992
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013879 RID: 79993
			public static VerifyTableAction <1>__Verify;
		}
	}
}
