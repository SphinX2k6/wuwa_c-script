using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A7E RID: 31358
	public static class ITalkCommonEffectVerify
	{
		// Token: 0x0603745E RID: 226398 RVA: 0x007617A0 File Offset: 0x0075F9A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkCommonEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkCommonEffectVerify.<>O.<0>__Verify = new VerifyTableAction(IAbsolutePos2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008716 RID: 34582
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B3A RID: 84794
			public static VerifyTableAction <0>__Verify;
		}
	}
}
