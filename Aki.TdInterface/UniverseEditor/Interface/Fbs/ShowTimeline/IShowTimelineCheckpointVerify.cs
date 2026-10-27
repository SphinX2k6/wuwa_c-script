using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BB5 RID: 15285
	public static class IShowTimelineCheckpointVerify
	{
		// Token: 0x06014F8A RID: 85898 RVA: 0x0030A834 File Offset: 0x00308A34
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowTimelineCheckpointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowTimelineCheckpointVerify.<>O.<0>__Verify = new VerifyTableAction(IShowTimelineRoleStateVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IShowTimelineCheckpointVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IShowTimelineCheckpointVerify.<>O.<1>__Verify = new VerifyTableAction(IShowTimelineMonsterStateVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						short typeIdVOffset = 16;
						short valueVOffset = 18;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IShowTimelineCheckpointVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IShowTimelineCheckpointVerify.<>O.<2>__Verify = new VerifyUnionAction(ICheckpointDisplay_UnionVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction3, false) && verifier.VerifyString(tablePos, 20, false))
						{
							short offsetId3 = 22;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IShowTimelineCheckpointVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IShowTimelineCheckpointVerify.<>O.<3>__Verify = new VerifyTableAction(IPosAVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false))
							{
								short offsetId4 = 24;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IShowTimelineCheckpointVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (IShowTimelineCheckpointVerify.<>O.<3>__Verify = new VerifyTableAction(IPosAVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId4, verifyAction5, false))
								{
									return verifier.VerifyTableEnd(tablePos);
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200788E RID: 30862
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130F8 RID: 78072
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040130F9 RID: 78073
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040130FA RID: 78074
			public static VerifyUnionAction <2>__Verify;

			// Token: 0x040130FB RID: 78075
			public static VerifyTableAction <3>__Verify;
		}
	}
}
