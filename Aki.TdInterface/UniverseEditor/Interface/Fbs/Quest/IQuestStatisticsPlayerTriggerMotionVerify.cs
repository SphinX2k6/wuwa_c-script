using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004495 RID: 17557
	public static class IQuestStatisticsPlayerTriggerMotionVerify
	{
		// Token: 0x06019487 RID: 103559 RVA: 0x0039BB50 File Offset: 0x00399D50
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IQuestStatisticsPlayerTriggerMotionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestStatisticsPlayerTriggerMotionVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008186 RID: 33158
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142BB RID: 82619
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
