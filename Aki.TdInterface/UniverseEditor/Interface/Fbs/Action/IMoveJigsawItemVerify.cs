using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B4A RID: 27466
	public static class IMoveJigsawItemVerify
	{
		// Token: 0x06030366 RID: 197478 RVA: 0x0068D30C File Offset: 0x0068B50C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMoveJigsawItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMoveJigsawItemVerify.<>O.<0>__Verify = new VerifyTableAction(IPieceIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DB9 RID: 32185
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013957 RID: 80215
			public static VerifyTableAction <0>__Verify;
		}
	}
}
