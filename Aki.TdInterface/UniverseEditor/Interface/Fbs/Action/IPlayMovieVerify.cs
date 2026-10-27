using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D2E RID: 27950
	public static class IPlayMovieVerify
	{
		// Token: 0x060314FB RID: 201979 RVA: 0x006B0170 File Offset: 0x006AE370
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 2UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayMovieVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayMovieVerify.<>O.<0>__Verify = new VerifyTableAction(IMp4UiReplaceMaterialVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPlayMovieVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPlayMovieVerify.<>O.<1>__Verify = new VerifyTableAction(IMp4FrameEventVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IPlayMovieVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IPlayMovieVerify.<>O.<2>__Verify = new VerifyTableAction(ISetBlendAnimVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007DF9 RID: 32249
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139B0 RID: 80304
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040139B1 RID: 80305
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040139B2 RID: 80306
			public static VerifyTableAction <2>__Verify;
		}
	}
}
