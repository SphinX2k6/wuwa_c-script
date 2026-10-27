using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066B6 RID: 26294
	public static class IEnterMovieModeVerify
	{
		// Token: 0x0602DB57 RID: 187223 RVA: 0x00640FC0 File Offset: 0x0063F1C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEnterMovieModeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEnterMovieModeVerify.<>O.<0>__Verify = new VerifyTableAction(IMovieCameraConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEnterMovieModeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEnterMovieModeVerify.<>O.<1>__Verify = new VerifyTableAction(IEnableFuncConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						short typeIdVOffset = 10;
						short valueVOffset = 12;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IEnterMovieModeVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IEnterMovieModeVerify.<>O.<2>__Verify = new VerifyUnionAction(TEnterMovieModeDurationTypeVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction3, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007D51 RID: 32081
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138CC RID: 80076
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040138CD RID: 80077
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040138CE RID: 80078
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
