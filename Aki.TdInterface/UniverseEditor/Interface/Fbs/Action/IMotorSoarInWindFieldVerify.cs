using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200727B RID: 29307
	public static class IMotorSoarInWindFieldVerify
	{
		// Token: 0x06033115 RID: 209173 RVA: 0x006E46BC File Offset: 0x006E28BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMotorSoarInWindFieldVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorSoarInWindFieldVerify.<>O.<0>__Verify = new VerifyUnionAction(TMotorSoarInWindFieldControlTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200863F RID: 34367
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A14 RID: 84500
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
