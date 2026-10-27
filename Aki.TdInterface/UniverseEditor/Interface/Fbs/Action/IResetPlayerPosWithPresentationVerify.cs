using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E9F RID: 28319
	public static class IResetPlayerPosWithPresentationVerify
	{
		// Token: 0x060320DA RID: 205018 RVA: 0x006C4F44 File Offset: 0x006C3144
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IResetPlayerPosWithPresentationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IResetPlayerPosWithPresentationVerify.<>O.<0>__Verify = new VerifyTableAction(IResetPresentationFailureVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					short typeIdVOffset = 6;
					short valueVOffset = 8;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IResetPlayerPosWithPresentationVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IResetPlayerPosWithPresentationVerify.<>O.<1>__Verify = new VerifyUnionAction(TResetPosTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007E18 RID: 32280
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139D3 RID: 80339
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040139D4 RID: 80340
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
