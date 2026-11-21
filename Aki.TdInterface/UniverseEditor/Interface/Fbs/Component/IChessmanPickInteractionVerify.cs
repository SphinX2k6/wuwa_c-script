using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C8 RID: 21704
	public static class IChessmanPickInteractionVerify
	{
		// Token: 0x060223BC RID: 140220 RVA: 0x004B8000 File Offset: 0x004B6200
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChessmanPickInteractionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChessmanPickInteractionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IChessmanPickInteractionVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IChessmanPickInteractionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008302 RID: 33538
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401450E RID: 83214
			public static VerifyTableAction <0>__Verify;
		}
	}
}
