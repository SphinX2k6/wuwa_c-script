using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004060 RID: 16480
	public static class IQuestStatisticsUseSkillNewVerify
	{
		// Token: 0x06017E82 RID: 97922 RVA: 0x0037341C File Offset: 0x0037161C
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

		// Token: 0x02007942 RID: 31042
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401325B RID: 78427
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401325C RID: 78428
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
