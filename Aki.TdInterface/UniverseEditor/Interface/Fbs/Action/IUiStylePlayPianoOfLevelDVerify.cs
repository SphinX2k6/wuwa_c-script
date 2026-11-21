using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CAC RID: 31916
	public static class IUiStylePlayPianoOfLevelDVerify
	{
		// Token: 0x0603993A RID: 235834 RVA: 0x007C516C File Offset: 0x007C336C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IUiStylePlayPianoOfLevelDVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUiStylePlayPianoOfLevelDVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IUiStylePlayPianoOfLevelDVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IUiStylePlayPianoOfLevelDVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008751 RID: 34641
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CD8 RID: 85208
			public static VerifyTableAction <0>__Verify;
		}
	}
}
