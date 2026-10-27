using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D0F RID: 23823
	public static class IAirCurrentDataVerify
	{
		// Token: 0x06028B24 RID: 166692 RVA: 0x00597034 File Offset: 0x00595234
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

		// Token: 0x02007C91 RID: 31889
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137BD RID: 79805
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040137BE RID: 79806
			public static VerifyTableAction <1>__Verify;
		}
	}
}
