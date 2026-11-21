using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007284 RID: 29316
	public static class IMotorSoarInWindFieldEnterWindFieldVerify
	{
		// Token: 0x06033161 RID: 209249 RVA: 0x006E4F68 File Offset: 0x006E3168
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorSoarInWindFieldEnterWindFieldVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorSoarInWindFieldEnterWindFieldVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMotorSoarInWindFieldEnterWindFieldVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IMotorSoarInWindFieldEnterWindFieldVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008640 RID: 34368
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A15 RID: 84501
			public static VerifyTableAction <0>__Verify;
		}
	}
}
