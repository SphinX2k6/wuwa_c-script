using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079B2 RID: 31154
	public static class IStopNewMoveWithSplineVerify
	{
		// Token: 0x06036E4F RID: 224847 RVA: 0x007577D4 File Offset: 0x007559D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IStopNewMoveWithSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStopNewMoveWithSplineVerify.<>O.<0>__Verify = new VerifyUnionAction(TNewSplineStopTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 8;
					short valueVOffset2 = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IStopNewMoveWithSplineVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IStopNewMoveWithSplineVerify.<>O.<1>__Verify = new VerifyUnionAction(TStopNewMoveWithSplineTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200870A RID: 34570
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B2D RID: 84781
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014B2E RID: 84782
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
