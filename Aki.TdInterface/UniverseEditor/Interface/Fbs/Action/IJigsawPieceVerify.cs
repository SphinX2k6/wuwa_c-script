using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D4 RID: 27092
	public static class IJigsawPieceVerify
	{
		// Token: 0x0602F5CA RID: 193994 RVA: 0x00673244 File Offset: 0x00671444
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IJigsawPieceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IJigsawPieceVerify.<>O.<0>__Verify = new VerifyTableAction(IPieceIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D97 RID: 32151
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401392A RID: 80170
			public static VerifyTableAction <0>__Verify;
		}
	}
}
