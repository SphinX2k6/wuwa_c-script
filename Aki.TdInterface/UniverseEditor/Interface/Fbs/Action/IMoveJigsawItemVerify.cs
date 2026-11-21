using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007290 RID: 29328
	public static class IMoveJigsawItemVerify
	{
		// Token: 0x060331BD RID: 209341 RVA: 0x006E58C8 File Offset: 0x006E3AC8
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

		// Token: 0x02008641 RID: 34369
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A16 RID: 84502
			public static VerifyTableAction <0>__Verify;
		}
	}
}
