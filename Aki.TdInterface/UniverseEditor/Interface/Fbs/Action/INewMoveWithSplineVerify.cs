using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072DF RID: 29407
	public static class INewMoveWithSplineVerify
	{
		// Token: 0x0603347A RID: 210042 RVA: 0x006EAE0C File Offset: 0x006E900C
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
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INewMoveWithSplineVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (INewMoveWithSplineVerify.<>O.<1>__Verify = new VerifyTableAction(IFrontAxleTrackingSplineMoveVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200864C RID: 34380
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A27 RID: 84519
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014A28 RID: 84520
			public static VerifyTableAction <1>__Verify;
		}
	}
}
