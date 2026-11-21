using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007994 RID: 31124
	public static class IStateInfoVerify
	{
		// Token: 0x06036D95 RID: 224661 RVA: 0x007562BC File Offset: 0x007544BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
			{
				short offsetId = 18;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStateInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStateInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false))
				{
					short offsetId2 = 38;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IStateInfoVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IStateInfoVerify.<>O.<1>__Verify = new VerifyTableAction(IPosAVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 40;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IStateInfoVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IStateInfoVerify.<>O.<2>__Verify = new VerifyTableAction(IStateProgramSpecialProcessChangeTeamOptimizationVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 42, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 44, 4UL, false) && verifier.VerifyField(tablePos, 46, 2UL, 2UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008708 RID: 34568
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B29 RID: 84777
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014B2A RID: 84778
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014B2B RID: 84779
			public static VerifyTableAction <2>__Verify;
		}
	}
}
