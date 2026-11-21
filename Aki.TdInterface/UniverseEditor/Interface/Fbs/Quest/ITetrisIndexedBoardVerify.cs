using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004615 RID: 17941
	public static class ITetrisIndexedBoardVerify
	{
		// Token: 0x0601A3DB RID: 107483 RVA: 0x003BC900 File Offset: 0x003BAB00
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

		// Token: 0x020081AE RID: 33198
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401432A RID: 82730
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401432B RID: 82731
			public static VerifyTableAction <1>__Verify;
		}
	}
}
