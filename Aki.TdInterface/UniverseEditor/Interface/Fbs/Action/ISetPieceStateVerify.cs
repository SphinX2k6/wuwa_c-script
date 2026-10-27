using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200704B RID: 28747
	public static class ISetPieceStateVerify
	{
		// Token: 0x06032DF4 RID: 208372 RVA: 0x006DCA98 File Offset: 0x006DAC98
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetPieceStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetPieceStateVerify.<>O.<0>__Verify = new VerifyTableAction(IJigsawPieceVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E4A RID: 32330
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A15 RID: 80405
			public static VerifyTableAction <0>__Verify;
		}
	}
}
