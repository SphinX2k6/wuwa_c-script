using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B4 RID: 21684
	public static class IJigsawPieceMatchVerify
	{
		// Token: 0x06023B7B RID: 146299 RVA: 0x004F0424 File Offset: 0x004EE624
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

		// Token: 0x02007B78 RID: 31608
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135F2 RID: 79346
			public static VerifyTableAction <0>__Verify;
		}
	}
}
