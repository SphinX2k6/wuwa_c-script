using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B35 RID: 27445
	public static class IMotorSoarInWindFieldVerify
	{
		// Token: 0x060302BE RID: 197310 RVA: 0x0068C100 File Offset: 0x0068A300
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

		// Token: 0x02007DB7 RID: 32183
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013955 RID: 80213
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
