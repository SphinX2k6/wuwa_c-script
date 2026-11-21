using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063A9 RID: 25513
	public static class ICharacterAirCurrentConfigVerify
	{
		// Token: 0x0602B52F RID: 177455 RVA: 0x005E7AF8 File Offset: 0x005E5CF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 8UL, 8UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICharacterAirCurrentConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICharacterAirCurrentConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICharacterAirCurrentConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICharacterAirCurrentConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008511 RID: 34065
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014873 RID: 84083
			public static VerifyTableAction <0>__Verify;
		}
	}
}
