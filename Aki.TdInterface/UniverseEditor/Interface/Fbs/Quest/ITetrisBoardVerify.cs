using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B9 RID: 16825
	public static class ITetrisBoardVerify
	{
		// Token: 0x06018C69 RID: 101481 RVA: 0x00391078 File Offset: 0x0038F278
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITetrisBoardVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITetrisBoardVerify.<>O.<0>__Verify = new VerifyTableAction(ITetrisSingleGridVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITetrisBoardVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITetrisBoardVerify.<>O.<1>__Verify = new VerifyTableAction(IRequiredVector2Verify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007964 RID: 31076
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132C2 RID: 78530
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040132C3 RID: 78531
			public static VerifyTableAction <1>__Verify;
		}
	}
}
