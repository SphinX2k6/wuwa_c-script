using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200607F RID: 24703
	public static class IActionInfoVerify
	{
		// Token: 0x06029D8B RID: 171403 RVA: 0x005BD8BC File Offset: 0x005BBABC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 2UL, 2UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IActionInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IActionInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IActionParams_UnionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CCA RID: 31946
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137FA RID: 79866
			public static VerifyTableAction <0>__Verify;
		}
	}
}
