using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200651E RID: 25886
	public static class ICutCameraConfigVerify
	{
		// Token: 0x0602CE7E RID: 183934 RVA: 0x0062ABE0 File Offset: 0x00628DE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICutCameraConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICutCameraConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ICameraParamsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICutCameraConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICutCameraConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ICutCameraConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ICutCameraConfigVerify.<>O.<2>__Verify = new VerifyTableAction(ICutCameraTimeParamsVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007D39 RID: 32057
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138A9 RID: 80041
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040138AA RID: 80042
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040138AB RID: 80043
			public static VerifyTableAction <2>__Verify;
		}
	}
}
