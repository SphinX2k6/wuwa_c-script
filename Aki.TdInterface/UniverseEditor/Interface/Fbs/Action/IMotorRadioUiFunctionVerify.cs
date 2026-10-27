using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B2F RID: 27439
	public static class IMotorRadioUiFunctionVerify
	{
		// Token: 0x06030296 RID: 197270 RVA: 0x0068BC84 File Offset: 0x00689E84
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

		// Token: 0x02007DB6 RID: 32182
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013954 RID: 80212
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
