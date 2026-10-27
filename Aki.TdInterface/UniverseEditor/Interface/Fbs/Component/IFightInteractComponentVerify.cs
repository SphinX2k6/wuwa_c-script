using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005242 RID: 21058
	public static class IFightInteractComponentVerify
	{
		// Token: 0x06022414 RID: 140308 RVA: 0x004C043C File Offset: 0x004BE63C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFightInteractComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFightInteractComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFightInteractComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFightInteractComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IAutoLockControlVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007B1D RID: 31517
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013553 RID: 79187
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013554 RID: 79188
			public static VerifyTableAction <1>__Verify;
		}
	}
}
