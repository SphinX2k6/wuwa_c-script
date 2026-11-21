using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004612 RID: 17938
	public static class ITetrisBoardVerify
	{
		// Token: 0x0601A3BF RID: 107455 RVA: 0x003BC4CC File Offset: 0x003BA6CC
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

		// Token: 0x020081AD RID: 33197
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014328 RID: 82728
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014329 RID: 82729
			public static VerifyTableAction <1>__Verify;
		}
	}
}
