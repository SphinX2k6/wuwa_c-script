using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E32 RID: 15922
	public static class IFinishBvbChallengeVerify
	{
		// Token: 0x0601651A RID: 91418 RVA: 0x00338D58 File Offset: 0x00336F58
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

		// Token: 0x020078DC RID: 30940
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013184 RID: 78212
			public static VerifyTableAction <0>__Verify;
		}
	}
}
