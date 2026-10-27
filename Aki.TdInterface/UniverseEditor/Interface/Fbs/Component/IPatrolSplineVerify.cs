using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005712 RID: 22290
	public static class IPatrolSplineVerify
	{
		// Token: 0x06025470 RID: 152688 RVA: 0x00524C2C File Offset: 0x00522E2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPatrolSplineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPatrolSplineVerify.<>O.<0>__Verify = new VerifyUnionAction(TPatrolCycleOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					short offsetId = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPatrolSplineVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPatrolSplineVerify.<>O.<1>__Verify = new VerifyTableAction(IPatrolSplinePointVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 18;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IPatrolSplineVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IPatrolSplineVerify.<>O.<2>__Verify = new VerifyTableAction(IPatrolRangeVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007BD1 RID: 31697
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013689 RID: 79497
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401368A RID: 79498
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401368B RID: 79499
			public static VerifyTableAction <2>__Verify;
		}
	}
}
