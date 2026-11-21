using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A87 RID: 31367
	public static class ITalkEffectPlayVerify
	{
		// Token: 0x060374A6 RID: 226470 RVA: 0x00761F54 File Offset: 0x00760154
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkEffectPlayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkEffectPlayVerify.<>O.<0>__Verify = new VerifyTableAction(ITalkCommonEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008717 RID: 34583
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B3B RID: 84795
			public static VerifyTableAction <0>__Verify;
		}
	}
}
