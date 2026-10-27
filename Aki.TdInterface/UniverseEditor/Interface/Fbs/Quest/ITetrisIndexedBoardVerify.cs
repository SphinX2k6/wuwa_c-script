using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041BC RID: 16828
	public static class ITetrisIndexedBoardVerify
	{
		// Token: 0x06018C85 RID: 101509 RVA: 0x003914AC File Offset: 0x0038F6AC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITetrisIndexedBoardVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITetrisIndexedBoardVerify.<>O.<0>__Verify = new VerifyTableAction(ITetrisSingleIndexGridVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITetrisIndexedBoardVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITetrisIndexedBoardVerify.<>O.<1>__Verify = new VerifyTableAction(IRequiredVector2Verify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007965 RID: 31077
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132C4 RID: 78532
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040132C5 RID: 78533
			public static VerifyTableAction <1>__Verify;
		}
	}
}
