using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D72 RID: 23922
	public static class ICharacterAirCurrentConfigVerify
	{
		// Token: 0x06028EC5 RID: 167621 RVA: 0x0059F088 File Offset: 0x0059D288
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

		// Token: 0x02007CA0 RID: 31904
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137CD RID: 79821
			public static VerifyTableAction <0>__Verify;
		}
	}
}
