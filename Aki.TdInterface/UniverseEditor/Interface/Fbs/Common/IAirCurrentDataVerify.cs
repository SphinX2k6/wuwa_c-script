using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006343 RID: 25411
	public static class IAirCurrentDataVerify
	{
		// Token: 0x0602B178 RID: 176504 RVA: 0x005DF8A4 File Offset: 0x005DDAA4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAirCurrentDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAirCurrentDataVerify.<>O.<0>__Verify = new VerifyTableAction(IMotorAirCurrentConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 18;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAirCurrentDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAirCurrentDataVerify.<>O.<1>__Verify = new VerifyTableAction(ICharacterAirCurrentConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008502 RID: 34050
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014863 RID: 84067
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014864 RID: 84068
			public static VerifyTableAction <1>__Verify;
		}
	}
}
