using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200617E RID: 24958
	public static class IAirPassageMoveVerify
	{
		// Token: 0x0602AFE7 RID: 176103 RVA: 0x005EE84C File Offset: 0x005ECA4C
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

		// Token: 0x02007CEF RID: 31983
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401384E RID: 79950
			public static VerifyTableAction <0>__Verify;
		}
	}
}
