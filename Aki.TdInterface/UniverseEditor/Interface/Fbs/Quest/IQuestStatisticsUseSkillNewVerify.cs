using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044A1 RID: 17569
	public static class IQuestStatisticsUseSkillNewVerify
	{
		// Token: 0x0601951B RID: 103707 RVA: 0x0039D210 File Offset: 0x0039B410
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IQuestStatisticsUseSkillNewVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestStatisticsUseSkillNewVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IQuestStatisticsUseSkillNewVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IQuestStatisticsUseSkillNewVerify.<>O.<1>__Verify = new VerifyUnionAction(TUseSkillCheckVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008189 RID: 33161
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142BE RID: 82622
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040142BF RID: 82623
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
