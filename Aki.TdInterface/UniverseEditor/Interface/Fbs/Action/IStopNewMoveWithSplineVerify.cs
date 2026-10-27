using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071DD RID: 29149
	public static class IStopNewMoveWithSplineVerify
	{
		// Token: 0x06033B4D RID: 211789 RVA: 0x006F6474 File Offset: 0x006F4674
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

		// Token: 0x02007E73 RID: 32371
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A56 RID: 80470
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013A57 RID: 80471
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
