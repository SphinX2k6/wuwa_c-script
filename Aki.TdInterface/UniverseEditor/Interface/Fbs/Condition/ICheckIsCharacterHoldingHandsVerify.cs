using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A83 RID: 19075
	public static class ICheckIsCharacterHoldingHandsVerify
	{
		// Token: 0x0601DE95 RID: 122517 RVA: 0x0043377C File Offset: 0x0043197C
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

		// Token: 0x02007A36 RID: 31286
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133FA RID: 78842
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
