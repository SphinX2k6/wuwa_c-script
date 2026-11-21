using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EA5 RID: 32421
	public static class TCsvCommonBtOverrideDataVerify
	{
		// Token: 0x0603A890 RID: 239760 RVA: 0x007E0A78 File Offset: 0x007DEC78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = TCsvCommonBtOverrideDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvCommonBtOverrideDataVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonBtOverrideVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008779 RID: 34681
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014D0B RID: 85259
			public static VerifyTableAction <0>__Verify;
		}
	}
}
