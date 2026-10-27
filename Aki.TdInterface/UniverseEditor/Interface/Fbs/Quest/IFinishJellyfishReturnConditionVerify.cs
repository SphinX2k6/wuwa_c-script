using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E3B RID: 15931
	public static class IFinishJellyfishReturnConditionVerify
	{
		// Token: 0x06016584 RID: 91524 RVA: 0x00339BB0 File Offset: 0x00337DB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishJellyfishReturnConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishJellyfishReturnConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyString(tablePos, 18, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078DF RID: 30943
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013189 RID: 78217
			public static VerifyTableAction <0>__Verify;
		}
	}
}
