using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E9 RID: 26601
	public static class IAirPassageMoveVerify
	{
		// Token: 0x0602D718 RID: 186136 RVA: 0x006390C0 File Offset: 0x006372C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false))
			{
				short offsetId = 18;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAirPassageMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAirPassageMoveVerify.<>O.<0>__Verify = new VerifyTableAction(IAirPassageMoveLimitVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008561 RID: 34145
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148F5 RID: 84213
			public static VerifyTableAction <0>__Verify;
		}
	}
}
