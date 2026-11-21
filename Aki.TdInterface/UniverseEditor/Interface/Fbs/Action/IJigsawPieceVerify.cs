using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007084 RID: 28804
	public static class IJigsawPieceVerify
	{
		// Token: 0x06031F8A RID: 204682 RVA: 0x006C359C File Offset: 0x006C179C
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

		// Token: 0x02008611 RID: 34321
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149DA RID: 84442
			public static VerifyTableAction <0>__Verify;
		}
	}
}
