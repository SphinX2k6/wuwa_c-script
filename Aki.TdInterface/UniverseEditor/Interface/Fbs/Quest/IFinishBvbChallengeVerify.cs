using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200426D RID: 17005
	public static class IFinishBvbChallengeVerify
	{
		// Token: 0x06017B47 RID: 97095 RVA: 0x00361950 File Offset: 0x0035FB50
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishBvbChallengeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishBvbChallengeVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008122 RID: 33058
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141E2 RID: 82402
			public static VerifyTableAction <0>__Verify;
		}
	}
}
