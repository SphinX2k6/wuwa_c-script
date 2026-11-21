using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B8C RID: 27532
	public static class ICutCameraConfigVerify
	{
		// Token: 0x0602F61C RID: 194076 RVA: 0x0067708C File Offset: 0x0067528C
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

		// Token: 0x020085AF RID: 34223
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014955 RID: 84309
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014956 RID: 84310
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014957 RID: 84311
			public static VerifyTableAction <2>__Verify;
		}
	}
}
