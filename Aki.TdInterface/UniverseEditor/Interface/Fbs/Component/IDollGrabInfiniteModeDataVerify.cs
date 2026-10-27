using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005098 RID: 20632
	public static class IDollGrabInfiniteModeDataVerify
	{
		// Token: 0x0602120E RID: 135694 RVA: 0x0049A7B4 File Offset: 0x004989B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDollGrabInfiniteModeDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDollGrabInfiniteModeDataVerify.<>O.<0>__Verify = new VerifyTableAction(IDollGrabStandbyPoolItemVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDollGrabInfiniteModeDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDollGrabInfiniteModeDataVerify.<>O.<1>__Verify = new VerifyTableAction(IDollGrabInfiniteStageConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IDollGrabInfiniteModeDataVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IDollGrabInfiniteModeDataVerify.<>O.<2>__Verify = new VerifyTableAction(IDollGrabInfiniteScoreRewardVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IDollGrabInfiniteModeDataVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IDollGrabInfiniteModeDataVerify.<>O.<2>__Verify = new VerifyTableAction(IDollGrabInfiniteScoreRewardVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007AD7 RID: 31447
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134DF RID: 79071
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134E0 RID: 79072
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040134E1 RID: 79073
			public static VerifyTableAction <2>__Verify;
		}
	}
}
