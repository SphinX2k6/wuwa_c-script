using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004036 RID: 16438
	public static class IQuestScheduleRoleTowerChallengeTitleVerify
	{
		// Token: 0x06017C7C RID: 97404 RVA: 0x0036E364 File Offset: 0x0036C564
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IQuestScheduleRoleTowerChallengeTitleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestScheduleRoleTowerChallengeTitleVerify.<>O.<0>__Verify = new VerifyUnionAction(TRoleTowerChallengeTitleTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200793A RID: 31034
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401324D RID: 78413
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
