using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA8 RID: 28072
	public static class IExitMovieModeVerify
	{
		// Token: 0x06030753 RID: 198483 RVA: 0x00695420 File Offset: 0x00693620
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

		// Token: 0x020085D5 RID: 34261
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014988 RID: 84360
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014989 RID: 84361
			public static VerifyTableAction <1>__Verify;
		}
	}
}
