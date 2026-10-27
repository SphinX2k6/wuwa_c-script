using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006432 RID: 25650
	public static class ICloseSkiConfigVerify
	{
		// Token: 0x0602C640 RID: 181824 RVA: 0x00617350 File Offset: 0x00615550
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICloseSkiConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICloseSkiConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D29 RID: 32041
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013897 RID: 80023
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
