using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B6 RID: 29878
	public static class IUiStylePlayPianoOfLevelDVerify
	{
		// Token: 0x06036525 RID: 222501 RVA: 0x00761F4C File Offset: 0x0076014C
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
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007EB7 RID: 32439
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BFE RID: 80894
			public static VerifyTableAction <0>__Verify;
		}
	}
}
