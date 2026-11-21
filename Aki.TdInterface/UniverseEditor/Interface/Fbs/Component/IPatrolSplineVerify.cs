using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D19 RID: 23833
	public static class IPatrolSplineVerify
	{
		// Token: 0x0602797B RID: 162171 RVA: 0x0056A878 File Offset: 0x00568A78
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
						verifyAction2 = (IPatrolSplineVerify.<>O.<1>__Verify = new VerifyTableAction(IPatrolPositionRefreshConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 18;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IPatrolSplineVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IPatrolSplineVerify.<>O.<2>__Verify = new VerifyTableAction(IPatrolSplinePointVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 20;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IPatrolSplineVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IPatrolSplineVerify.<>O.<3>__Verify = new VerifyTableAction(IPatrolRangeVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200843F RID: 33855
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014727 RID: 83751
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014728 RID: 83752
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014729 RID: 83753
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401472A RID: 83754
			public static VerifyTableAction <3>__Verify;
		}
	}
}
