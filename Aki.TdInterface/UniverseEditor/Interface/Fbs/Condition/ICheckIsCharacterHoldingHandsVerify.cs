using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F49 RID: 20297
	public static class ICheckIsCharacterHoldingHandsVerify
	{
		// Token: 0x0601F938 RID: 129336 RVA: 0x00464908 File Offset: 0x00462B08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckIsCharacterHoldingHandsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckIsCharacterHoldingHandsVerify.<>O.<0>__Verify = new VerifyUnionAction(TCheckHoldingHandsCharacterVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008286 RID: 33414
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014468 RID: 83048
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
