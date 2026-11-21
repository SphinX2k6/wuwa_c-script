using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005381 RID: 21377
	public static class IAfterTeleportConfigVerify
	{
		// Token: 0x060214F8 RID: 136440 RVA: 0x0049888C File Offset: 0x00496A8C
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

		// Token: 0x020082C6 RID: 33478
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144B1 RID: 83121
			public static VerifyTableAction <0>__Verify;
		}
	}
}
