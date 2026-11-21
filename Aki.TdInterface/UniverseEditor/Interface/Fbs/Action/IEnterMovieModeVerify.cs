using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D30 RID: 27952
	public static class IEnterMovieModeVerify
	{
		// Token: 0x06030374 RID: 197492 RVA: 0x0068E274 File Offset: 0x0068C474
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

		// Token: 0x020085C8 RID: 34248
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014978 RID: 84344
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014979 RID: 84345
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401497A RID: 84346
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
