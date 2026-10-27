using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E52 RID: 20050
	public static class IActiveRenjuPieceVerify
	{
		// Token: 0x0601F79B RID: 128923 RVA: 0x0046286C File Offset: 0x00460A6C
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

		// Token: 0x02007A6F RID: 31343
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401343B RID: 78907
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401343C RID: 78908
			public static VerifyTableAction <1>__Verify;
		}
	}
}
