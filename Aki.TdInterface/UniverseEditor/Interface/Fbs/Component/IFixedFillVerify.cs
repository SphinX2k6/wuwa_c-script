using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057DA RID: 22490
	public static class IFixedFillVerify
	{
		// Token: 0x0602452A RID: 148778 RVA: 0x004FD884 File Offset: 0x004FBA84
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

		// Token: 0x0200837E RID: 33662
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145DA RID: 83418
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040145DB RID: 83419
			public static VerifyTableAction <1>__Verify;
		}
	}
}
