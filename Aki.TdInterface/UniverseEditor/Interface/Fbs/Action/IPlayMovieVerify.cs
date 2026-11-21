using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A9 RID: 29865
	public static class IPlayMovieVerify
	{
		// Token: 0x060344F7 RID: 214263 RVA: 0x0070B848 File Offset: 0x00709A48
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
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPlayMovieVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPlayMovieVerify.<>O.<1>__Verify = new VerifyTableAction(IMp4FrameEventVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 18;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IPlayMovieVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IPlayMovieVerify.<>O.<2>__Verify = new VerifyTableAction(ISetBlendAnimVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008685 RID: 34437
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A74 RID: 84596
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014A75 RID: 84597
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014A76 RID: 84598
			public static VerifyTableAction <2>__Verify;
		}
	}
}
