using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B99 RID: 27545
	public static class INewMoveWithSplineVerify
	{
		// Token: 0x0603061E RID: 198174 RVA: 0x00692708 File Offset: 0x00690908
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = INewMoveWithSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INewMoveWithSplineVerify.<>O.<0>__Verify = new VerifyUnionAction(TNewSplineMoveTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DC4 RID: 32196
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013968 RID: 80232
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
