using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078A4 RID: 30884
	public static class IShowCenterTextVerify
	{
		// Token: 0x06036560 RID: 222560 RVA: 0x00746740 File Offset: 0x00744940
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowCenterTextVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowCenterTextVerify.<>O.<0>__Verify = new VerifyTableAction(ITextStyleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086F0 RID: 34544
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B05 RID: 84741
			public static VerifyTableAction <0>__Verify;
		}
	}
}
