using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007275 RID: 29301
	public static class IMotorRadioUiFunctionVerify
	{
		// Token: 0x060330ED RID: 209133 RVA: 0x006E4240 File Offset: 0x006E2440
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMotorRadioUiFunctionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorRadioUiFunctionVerify.<>O.<0>__Verify = new VerifyUnionAction(TMotorRadioOperationRestrictionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200863E RID: 34366
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A13 RID: 84499
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
