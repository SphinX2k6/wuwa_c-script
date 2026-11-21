using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004477 RID: 17527
	public static class IQuestScheduleRoleTowerChallengeTitleVerify
	{
		// Token: 0x06019315 RID: 103189 RVA: 0x00398158 File Offset: 0x00396358
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

		// Token: 0x02008181 RID: 33153
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142B0 RID: 82608
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
