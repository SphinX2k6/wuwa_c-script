using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067CD RID: 26573
	public static class IFixedCameraConfigVerify
	{
		// Token: 0x0602E430 RID: 189488 RVA: 0x00651418 File Offset: 0x0064F618
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFixedCameraConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFixedCameraConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFixedCameraConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IFixedCameraConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D6F RID: 32111
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138F2 RID: 80114
			public static VerifyTableAction <0>__Verify;
		}
	}
}
