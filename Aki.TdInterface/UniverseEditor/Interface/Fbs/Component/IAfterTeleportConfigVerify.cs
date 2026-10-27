using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E70 RID: 20080
	public static class IAfterTeleportConfigVerify
	{
		// Token: 0x0601F8AD RID: 129197 RVA: 0x00464874 File Offset: 0x00462A74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAfterTeleportConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAfterTeleportConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAfterTeleportConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IAfterTeleportConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A74 RID: 31348
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013441 RID: 78913
			public static VerifyTableAction <0>__Verify;
		}
	}
}
