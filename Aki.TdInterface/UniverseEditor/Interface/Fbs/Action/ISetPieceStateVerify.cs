using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007817 RID: 30743
	public static class ISetPieceStateVerify
	{
		// Token: 0x06036091 RID: 221329 RVA: 0x0073CFC0 File Offset: 0x0073B1C0
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

		// Token: 0x020086E0 RID: 34528
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AE9 RID: 84713
			public static VerifyTableAction <0>__Verify;
		}
	}
}
