using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E0 RID: 26592
	public static class IAiAssistCharacterMoveToPointVerify
	{
		// Token: 0x0602D6BA RID: 186042 RVA: 0x00638650 File Offset: 0x00636850
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IAiAssistCharacterMoveToPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAiAssistCharacterMoveToPointVerify.<>O.<0>__Verify = new VerifyUnionAction(TAssistCharacterMoveTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008560 RID: 34144
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148F4 RID: 84212
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
