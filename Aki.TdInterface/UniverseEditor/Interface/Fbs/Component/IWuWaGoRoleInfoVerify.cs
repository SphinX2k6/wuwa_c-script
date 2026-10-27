using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD5 RID: 23509
	public static class IWuWaGoRoleInfoVerify
	{
		// Token: 0x06028484 RID: 164996 RVA: 0x00588DE4 File Offset: 0x00586FE4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWuWaGoRoleInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWuWaGoRoleInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IWuWaGoRoleInfoVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IWuWaGoRoleInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C8D RID: 31885
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137B8 RID: 79800
			public static VerifyTableAction <0>__Verify;
		}
	}
}
