using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055FD RID: 22013
	public static class IDollGrabInfiniteModeDataVerify
	{
		// Token: 0x06023162 RID: 143714 RVA: 0x004D4740 File Offset: 0x004D2940
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

		// Token: 0x02008331 RID: 33585
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401455D RID: 83293
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401455E RID: 83294
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401455F RID: 83295
			public static VerifyTableAction <2>__Verify;
		}
	}
}
