using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C23 RID: 27683
	public static class IOpenQuickHackCameraConfigVerify
	{
		// Token: 0x06030AFE RID: 199422 RVA: 0x0069BF94 File Offset: 0x0069A194
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

		// Token: 0x02007DD7 RID: 32215
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401397C RID: 80252
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401397D RID: 80253
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401397E RID: 80254
			public static VerifyTableAction <2>__Verify;
		}
	}
}
