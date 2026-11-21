using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005363 RID: 21347
	public static class IActiveRenjuPieceVerify
	{
		// Token: 0x060213E6 RID: 136166 RVA: 0x00496884 File Offset: 0x00494A84
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActiveRenjuPieceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActiveRenjuPieceVerify.<>O.<0>__Verify = new VerifyTableAction(IRenjuConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IActiveRenjuPieceVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IActiveRenjuPieceVerify.<>O.<1>__Verify = new VerifyTableAction(IJigsawItemMatchedConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020082C1 RID: 33473
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144AB RID: 83115
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040144AC RID: 83116
			public static VerifyTableAction <1>__Verify;
		}
	}
}
