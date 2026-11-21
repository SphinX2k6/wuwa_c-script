using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078A7 RID: 30887
	public static class IShowCenterTextParamsVerify
	{
		// Token: 0x0603658C RID: 222604 RVA: 0x00746D10 File Offset: 0x00744F10
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowCenterTextParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowCenterTextParamsVerify.<>O.<0>__Verify = new VerifyTableAction(ITextStyleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086F1 RID: 34545
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B06 RID: 84742
			public static VerifyTableAction <0>__Verify;
		}
	}
}
