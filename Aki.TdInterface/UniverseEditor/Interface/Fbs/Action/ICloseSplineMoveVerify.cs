using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006438 RID: 25656
	public static class ICloseSplineMoveVerify
	{
		// Token: 0x0602C67B RID: 181883 RVA: 0x00617B08 File Offset: 0x00615D08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICloseSplineMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICloseSplineMoveVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D2A RID: 32042
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013898 RID: 80024
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
