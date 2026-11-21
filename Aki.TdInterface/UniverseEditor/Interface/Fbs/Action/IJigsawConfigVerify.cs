using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200707E RID: 28798
	public static class IJigsawConfigVerify
	{
		// Token: 0x06031F4E RID: 204622 RVA: 0x006C2EA8 File Offset: 0x006C10A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IJigsawConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IJigsawConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IJigsawPieceVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008610 RID: 34320
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149D9 RID: 84441
			public static VerifyTableAction <0>__Verify;
		}
	}
}
