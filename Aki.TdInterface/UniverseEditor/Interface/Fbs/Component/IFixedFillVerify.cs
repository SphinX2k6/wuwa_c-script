using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005272 RID: 21106
	public static class IFixedFillVerify
	{
		// Token: 0x06022594 RID: 140692 RVA: 0x004C2DC0 File Offset: 0x004C0FC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFixedFillVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFixedFillVerify.<>O.<0>__Verify = new VerifyTableAction(IPieceIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFixedFillVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFixedFillVerify.<>O.<1>__Verify = new VerifyTableAction(IJigsawConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007B23 RID: 31523
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401355A RID: 79194
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401355B RID: 79195
			public static VerifyTableAction <1>__Verify;
		}
	}
}
