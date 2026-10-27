using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006199 RID: 24985
	public static class IAssistCharacterMoveToPointVerify
	{
		// Token: 0x0602B097 RID: 176279 RVA: 0x005EF9D0 File Offset: 0x005EDBD0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IAssistCharacterMoveToPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAssistCharacterMoveToPointVerify.<>O.<0>__Verify = new VerifyUnionAction(TAssistCharacterMoveTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CF0 RID: 31984
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401384F RID: 79951
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
