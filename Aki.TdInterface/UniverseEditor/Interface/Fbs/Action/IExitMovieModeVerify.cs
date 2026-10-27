using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006728 RID: 26408
	public static class IExitMovieModeVerify
	{
		// Token: 0x0602DF0D RID: 188173 RVA: 0x00647CDC File Offset: 0x00645EDC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IExitMovieModeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExitMovieModeVerify.<>O.<0>__Verify = new VerifyUnionAction(TEnterMovieModeDurationTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IExitMovieModeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IExitMovieModeVerify.<>O.<1>__Verify = new VerifyTableAction(IMovieModeFadeOutMaskConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D5E RID: 32094
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138DC RID: 80092
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040138DD RID: 80093
			public static VerifyTableAction <1>__Verify;
		}
	}
}
