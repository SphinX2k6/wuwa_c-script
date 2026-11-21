using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A3A RID: 23098
	public static class IJigsawPieceMatchVerify
	{
		// Token: 0x06025C33 RID: 154675 RVA: 0x0052D498 File Offset: 0x0052B698
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IJigsawPieceMatchVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IJigsawPieceMatchVerify.<>O.<0>__Verify = new VerifyTableAction(IPieceIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083D7 RID: 33751
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014678 RID: 83576
			public static VerifyTableAction <0>__Verify;
		}
	}
}
