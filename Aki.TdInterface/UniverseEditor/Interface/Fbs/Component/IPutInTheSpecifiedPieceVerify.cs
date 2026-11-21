using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DC3 RID: 24003
	public static class IPutInTheSpecifiedPieceVerify
	{
		// Token: 0x06028041 RID: 163905 RVA: 0x00579078 File Offset: 0x00577278
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPutInTheSpecifiedPieceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPutInTheSpecifiedPieceVerify.<>O.<0>__Verify = new VerifyTableAction(IJigsawPieceMatchVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200845C RID: 33884
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014757 RID: 83799
			public static VerifyTableAction <0>__Verify;
		}
	}
}
