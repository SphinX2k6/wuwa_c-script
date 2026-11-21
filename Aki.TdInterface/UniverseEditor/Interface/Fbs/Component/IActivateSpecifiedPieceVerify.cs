using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200535D RID: 21341
	public static class IActivateSpecifiedPieceVerify
	{
		// Token: 0x060213A4 RID: 136100 RVA: 0x00495F8C File Offset: 0x0049418C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActivateSpecifiedPieceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActivateSpecifiedPieceVerify.<>O.<0>__Verify = new VerifyTableAction(IActivateSpecifiedPieceConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082BF RID: 33471
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144A9 RID: 83113
			public static VerifyTableAction <0>__Verify;
		}
	}
}
