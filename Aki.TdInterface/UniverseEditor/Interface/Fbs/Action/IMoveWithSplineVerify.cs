using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B6B RID: 27499
	public static class IMoveWithSplineVerify
	{
		// Token: 0x0603049E RID: 197790 RVA: 0x0068FBA4 File Offset: 0x0068DDA4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMoveWithSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMoveWithSplineVerify.<>O.<0>__Verify = new VerifyUnionAction(TSplineMoveTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMoveWithSplineVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IMoveWithSplineVerify.<>O.<1>__Verify = new VerifyTableAction(ICheckClimbVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IMoveWithSplineVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IMoveWithSplineVerify.<>O.<2>__Verify = new VerifyTableAction(IMoveOnWallConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
						{
							short offsetId3 = 26;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IMoveWithSplineVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IMoveWithSplineVerify.<>O.<3>__Verify = new VerifyTableAction(INpcFollowConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007DC0 RID: 32192
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013960 RID: 80224
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013961 RID: 80225
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013962 RID: 80226
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013963 RID: 80227
			public static VerifyTableAction <3>__Verify;
		}
	}
}
