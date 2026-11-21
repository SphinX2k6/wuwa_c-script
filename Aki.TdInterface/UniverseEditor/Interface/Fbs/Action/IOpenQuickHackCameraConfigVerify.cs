using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200738A RID: 29578
	public static class IOpenQuickHackCameraConfigVerify
	{
		// Token: 0x06033A52 RID: 211538 RVA: 0x006F6290 File Offset: 0x006F4490
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOpenQuickHackCameraConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenQuickHackCameraConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IOpenQuickHackCameraConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IOpenQuickHackCameraConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IOpenQuickHackCameraFovConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IOpenQuickHackCameraConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IOpenQuickHackCameraConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IAdjustFixedCameraRotateConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008661 RID: 34401
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A3E RID: 84542
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014A3F RID: 84543
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014A40 RID: 84544
			public static VerifyTableAction <2>__Verify;
		}
	}
}
